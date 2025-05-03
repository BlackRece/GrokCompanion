# GrokCompanion
A C#/.NET desktop application built with WPF and JetBrains Rider, providing a conversational AI interface using the Hugging Face Inference API. This app was developed as a free alternative to the paid Grok API, leveraging Hugging Face’s open-source models.
Features

Send text queries to the Hugging Face API and display responses.
Configurable API key via appsettings.json or environment variable.
Secure handling of sensitive data (API key not included in repository).

## Prerequisites

.NET SDK: 8.0 or 9.0
JetBrains Rider: Latest version (2024.3.5 or newer recommended)
Hugging Face API Key: Obtain from Hugging Face Settings
Git: For cloning the repository
GitHub CLI (optional): For advanced GitHub interactions (winget install --id GitHub.cli)

## Setup Instructions

Clone the repository:git clone https://github.com/BlackRece/GrokCompanion.git


Open the solution (GrokCompanion.sln) in JetBrains Rider.
Configure the Hugging Face API key using one of these methods:
Option 1: appsettings.json
Copy appsettings.json.example to appsettings.json:cp appsettings.json.example appsettings.json


Edit appsettings.json and replace your-huggingface-api-key-here with your API key.


Option 2: Environment Variable
Set the HUGGINGFACE_API_KEY environment variable:
Windows: set HUGGINGFACE_API_KEY=your-api-key
macOS/Linux: export HUGGINGFACE_API_KEY=your-api-key

Build and run the solution in Rider (Ctrl+F5).

## Usage

Enter a query in the text box and click Send Query to get a response from the Hugging Face API.
The DeepSearch button currently mirrors the regular query (extend as needed).

## Notes

The app uses the Mistral-7B-Instruct model via Hugging Face’s free Inference API.
Stay within the free tier’s rate limits (see Hugging Face API Docs).
For contributions, submit pull requests or open issues on GitHub.

## License
TBD
