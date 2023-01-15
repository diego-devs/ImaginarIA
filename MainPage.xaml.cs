using Microsoft.Extensions.DependencyInjection;
using OpenAI.GPT3.ObjectModels.RequestModels;
using OpenAI.GPT3.ObjectModels;
using OpenAI.GPT3.Managers;
using OpenAI.GPT3;
using OpenAI.GPT3.ObjectModels.ResponseModels.ImageResponseModel;
using System.Diagnostics;

namespace ImaginarIA;

public partial class MainPage : ContentPage
{
	int count = 0;
    Image RequestedImage { get; set;  }

    private List<string> MainImageSearch = new List<string>()
    {
        "a cat using a truck",
        "US president as a zombie",
        "Disney princess giving a rock concert"
    };
    Random r = new Random();
    
	public MainPage()
	{
		InitializeComponent();
        InitializeMainPageImage();
        

    }
    private async void InitializeMainPageImage()
    {
        await GenerateMainImage(MainImageSearch[r.Next(0, MainImageSearch.Count - 1)]);
    }
    private async Task GenerateMainImage(string prompt)
	{
        var openAiService = new OpenAIService(new OpenAiOptions()
        {
            //ApiKey = Environment.GetEnvironmentVariable("MY_OPEN_AI_" + "API_KEY")
            ApiKey = "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"
        }) ;
        
        var imageResult = await openAiService.Image.CreateImage(new ImageCreateRequest
        {
            
            Prompt = prompt,
            N = 1,
            Size = StaticValues.ImageStatics.Size.Size1024,
            ResponseFormat = StaticValues.ImageStatics.ResponseFormat.Url,
            User = "TestUser"
        });
        if (imageResult.Successful)
        {
            Debug.WriteLine(string.Join("\n", imageResult.Results.Select(r => r.Url)));
        }

        mainImage.Source = imageResult.Results[0].Url;

       
    }
    
	private async void OnCounterClicked(object sender, EventArgs e)
	{
        
        count++;
        await GenerateMainImage(SearchBar.Text.ToString());

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);

    }

}

