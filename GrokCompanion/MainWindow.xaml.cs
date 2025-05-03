using System.Windows;
using System.IO;

using Microsoft.Extensions.Configuration;

namespace GrokCompanion {
    public partial class MainWindow : Window {
        private readonly HuggingFaceApiClient _apiClient;
        private readonly string ERROR_MESSAGE = "Error: API key is not configured. Please check appsettings.json.";

        public MainWindow() {
            InitializeComponent();
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            string apiKey = configuration["HuggingFaceApi:ApiKey"] ?? string.Empty;
            if (string.IsNullOrWhiteSpace(apiKey) || apiKey == "InsertYourHugginFaceAPIKey") {
                ResponseTextBlock.Text = "Please enter your HuggingFace API key in appsettings.json.";
                _apiClient = null;
            } else {
                _apiClient = new HuggingFaceApiClient(apiKey);
            }
        }

        private async void SendButton_Click(object sender, RoutedEventArgs e) {
            string query = QueryTextBox.Text;
            if (string.IsNullOrWhiteSpace(query)) {
                ResponseTextBlock.Text = "Please enter a query.";
                return;
            }

            ResponseTextBlock.Text = "Processing...";
            
            ResponseTextBlock.Text = IsApiClientInitialised() 
                ? await _apiClient.SendQueryAsync(query)
                : ERROR_MESSAGE;
        }

        private async void DeepSearchButton_Click(object sender, RoutedEventArgs e) {
            string query = QueryTextBox.Text;
            if (string.IsNullOrWhiteSpace(query)) {
                ResponseTextBlock.Text = "Please enter a query.";
                return;
            }

            ResponseTextBlock.Text = "Processing DeepSearch...";
            
            ResponseTextBlock.Text = IsApiClientInitialised() 
                ? await _apiClient.SendQueryAsync(query)
                : ERROR_MESSAGE;
        }

        private bool IsApiClientInitialised() => _apiClient != null;
    }
}
