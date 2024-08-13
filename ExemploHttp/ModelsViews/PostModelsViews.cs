using CommunityToolkit.Mvvm.ComponentModel;
using ExemploHttp.Models;
using ExemploHttp.Services;
using ExemploHttp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExemploHttp.ModelsViews
{
    public partial class PostModelsViews : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Post> posts;

        public ICommand getPostsCommand { get; }

        public PostModelsViews()
        {
            getPostsCommand = new Command(getPosts);
        }

        public async void getPosts()
        {
            RestService postService = new RestService();
            Posts = await postService.getPostAsync();
        }
    }


}
