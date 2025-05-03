# GrokCompanion
A C#/.NET desktop application built with WPF and JetBrains Rider, providing a conversational AI interface using the Hugging Face Inference API. This app was developed as a free alternative to the paid Grok API, leveraging Hugging Face’s open-source models.

## Features

- Send text queries to the Hugging Face API and display responses.
- Configurable API key via `appsettings.json` or environment variable.

## Prerequisites

- .NET SDK: 8.0 or 9.0
- JetBrains Rider: Latest version (2024.3.5 or newer recommended)
- Hugging Face API Key: Obtain from Hugging Face Settings
- Git: For cloning the repository
- GitHub CLI (optional): For advanced GitHub interactions (winget install --id GitHub.cli)

## Setup Instructions

1. Clone the repository:
   ```bash
   git clone https://github.com/BlackRece/GrokCompanion.git
   ```
2. Open the solution (`GrokCompanion.sln`) in JetBrains Rider.
3. Configure the Hugging Face API key:
   - Copy `appsettings.json.example` to `appsettings.json`:
   ```bash
     cp appsettings.json.example appsettings.json
   ```
   - Edit `appsettings.json` and replace `InsertYourHugginFaceAPIKey` with your API key.
4. Build and run the solution in Rider (Ctrl+F5).

## Usage

Enter a query in the text box and click Send Query to get a response from the Hugging Face API.
The DeepSearch button currently mirrors the regular query (extend as needed).

## Notes

The app uses the Mistral-7B-Instruct model via Hugging Face’s free Inference API.
Stay within the free tier’s rate limits (see Hugging Face API Docs).
For contributions, submit pull requests or open issues on GitHub.

## License
This project is licensed under the MIT License. You are free to use, modify, and distribute the code, provided that you include the original copyright notice (crediting BlackRece) and the MIT License terms in all copies or substantial portions of the software. See the LICENSE file for details.
