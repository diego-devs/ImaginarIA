# ImaginarIA

ImaginarIA is a cross-platform .NET MAUI application that allows you to generate images using the OpenAI API. Describe any scene or concept, and ImaginarIA will create an AI-generated image for you in seconds.

## Features

- 🌐 Cross-platform: Runs on Android, iOS, Windows, macOS, and Tizen.
- 🖼️ Generate images from text prompts using OpenAI's DALL·E API.
- 🎨 Modern UI with theming and responsive layouts.
- 🔍 Example prompts to inspire creativity.
- ⚡ Fast and easy-to-use interface.

## Screenshots

<!-- Add screenshots here if available -->
<!-- ![Screenshot](Resources/Images/screenshot.png) -->

## Getting Started

### Prerequisites

- [.NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)
- Visual Studio 2022 or later with MAUI workload installed
- An [OpenAI API key](https://platform.openai.com/account/api-keys)

### Setup

1. **Clone the repository:**
   ```sh
   git clone https://github.com/yourusername/ImaginarIA.git
   cd ImaginarIA
   ```

2. **Configure your OpenAI API key:**
   - Open [`MainPage.xaml.cs`](MainPage.xaml.cs).
   - Replace the value of `ApiKey` in the `OpenAiOptions` with your own OpenAI API key.
   - **Important:** Never commit your API key to a public repository.

3. **Restore dependencies:**
   ```sh
   dotnet restore
   ```

4. **Build and run the app:**
   - For Windows:
     ```sh
     dotnet build -f net7.0-windows10.0.19041.0
     dotnet run -f net7.0-windows10.0.19041.0
     ```
   - For Android/iOS/macOS, use Visual Studio or the appropriate CLI commands.

## Usage

1. Enter a description of the image you want to generate in the search bar.
2. Click the **Generate** button.
3. The generated image will appear below.

## Project Structure

- [`MainPage.xaml`](MainPage.xaml) / [`MainPage.xaml.cs`](MainPage.xaml.cs): Main UI and logic for image generation.
- [`App.xaml`](App.xaml): Application resources and theming.
- [`MauiProgram.cs`](MauiProgram.cs): App startup and DI configuration.
- [`Resources/`](Resources/): Images, fonts, styles, and raw assets.

## Dependencies

- [Betalgo.OpenAI.GPT3](https://www.nuget.org/packages/Betalgo.OpenAI.GPT3)
- [Microsoft.Maui](https://github.com/dotnet/maui)

## License

This project is licensed under the MIT License.

---

**Disclaimer:** This app uses the OpenAI API and may incur costs based on your usage. Please review OpenAI's pricing and terms.
