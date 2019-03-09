using SkyNews.Models;
using SkyNews.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SkyNews
{

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
        ArticlesViewModel articlesViewMode;

        public MainPage ()
		{
			InitializeComponent ();
            articlesViewMode = new ArticlesViewModel();
            BindingContext = articlesViewMode;
        }
        private async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            //DependencyService.Get<ArticlesViewModel>().CurrentFlag = (Flag)e.Item;
            await Navigation.PushAsync(new ArticleBodyPage((Article)e.Item));
        }
    }
}