using ExemploHttp.ModelsViews;

namespace ExemploHttp.Views;

public partial class PhotosView : ContentPage
{
	public PhotosView()
	{
        InitializeComponent();
        BindingContext = new PhotoModelsViews();

    }
}