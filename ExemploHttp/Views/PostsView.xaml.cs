using ExemploHttp.ModelsViews;

namespace ExemploHttp.Views;

public partial class PostsView : ContentPage
{
	public PostsView()
	{
        InitializeComponent();
        BindingContext = new PostModelsViews();
	
	}
}