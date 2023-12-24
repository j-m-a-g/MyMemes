using System;
using Xamarin.Essentials;

namespace MyMemes
{
	public partial class MainPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
		
		/*
		UNDERLYING PROGRAM METHODS
		*/
		public async void SeeOriginal(string originalMemeUrl)
		{
			if (Connectivity.NetworkAccess == NetworkAccess.Internet)
			{
				await Browser.OpenAsync(originalMemeUrl);
			}
			else
			{
				await DisplayAlert("No Internet",
					"Sorry, but currently you do not have internet access. Please try again later.", "Ok");
			}
		}

		/*
		HomeStackLayout event handlers
		*/
		
		// "See original," button click handlers
		private void OriginBtn1_OnClicked(object sender, EventArgs e)
		{
			SeeOriginal("https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.nytimes.com%2F2021%2F04%2F29%2Farts%2Fdisaster-girl-meme-nft.html&psig=AOvVaw2I_ql-Cj2jwHMo4Ny-1I33&ust=1703452476219000&source=images&cd=vfe&opi=89978449&ved=0CBIQjhxqFwoTCKDx2Y-9poMDFQAAAAAdAAAAABAD");
		}
		private void OriginBtn2_OnClicked(object sender, EventArgs e)
		{
			SeeOriginal("https://preview.redd.it/they-were-too-kind-v0-scs3dudii18c1.jpeg?width=1080&crop=smart&auto=webp&s=87c47de89be09ac846fb229454c6ec4afc791ce0");
		}
	}
}
