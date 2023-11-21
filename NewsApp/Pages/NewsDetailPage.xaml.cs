using NewsApp.Models;
namespace NewsApp.Pages;

public partial class NewsDetailPage : ContentPage
{
    private Category selectedItem;

    public NewsDetailPage(Article article)
	{
		InitializeComponent();
        ImgNews.Source = article.Image;
        LblTitle.Text = article.Title;   
        LblContent.Text = article.Content;
    }

    public NewsDetailPage(Category selectedItem)
    {
        this.selectedItem = selectedItem;
    }
}