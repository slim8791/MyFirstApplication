using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstApplication
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RestfullPage : ContentPage
	{
        private const string _url = "https://jsonplaceholder.typicode.com/posts";
        private HttpClient _client = new HttpClient();
        ObservableCollection<Post> _posts = new ObservableCollection<Post>();
        public RestfullPage ()
		{
			InitializeComponent ();
		}
        protected async override void OnAppearing()
        {
            var content = await _client.GetStringAsync(_url);
            var posts = JsonConvert.DeserializeObject<List<Post>>(content);
            _posts = new ObservableCollection<Post>(posts);
            postsListView.ItemsSource = _posts;
            base.OnAppearing();
        }
        async void OnAdd(object sender, System.EventArgs e)
        {
            var post = new Post
            {
                Title = "My post",
                Body = "body of my post"

            };
            var content = JsonConvert.SerializeObject(post);
            var rep = await _client.PostAsync(_url, new StringContent(content));
            _posts.Insert(0, post);
        }

        async void  OnUpdate(object sender, System.EventArgs e)
        {
            var p =  _posts[0];
            p.Title += " Updated ";
            var content = JsonConvert.SerializeObject(p);

            var rep = await _client.PutAsync(_url + "/" + p.Id, new StringContent(content));
        }

        async void OnDelete(object sender, System.EventArgs e)
        {

            var rep = await _client.DeleteAsync(_url + "/1");
        }
    }
}