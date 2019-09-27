using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstApplication
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CustomListViewItem : ContentPage
	{
	    ObservableCollection<Employe> employes = new ObservableCollection<Employe>();

        public CustomListViewItem ()
		{
			InitializeComponent ();
		    //List<Employe> employes = new List<Employe>();
		    Employe emp1 = new Employe { Nom = "Slim", Poste = "Enseignant ", UrlImage = "http://lorempixel.com/100/100/people/1" };
		    Employe emp2 = new Employe { Nom = "Ali", Poste = "Dévelppeur ", UrlImage = "http://lorempixel.com/100/100/people/2" };
		    employes.Add(emp1);
		    employes.Add(emp2);

		    listView.ItemsSource = employes;
        }

	    private async void ListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
	    {
	        
	        var employe = e.SelectedItem as Employe;
	        var response = await DisplayAlert(employe.Nom + " selected ", employe.Poste, "Ok","Cancel ");
	        
	        //if(response)
         //       listView.SelectedItem = null;
        }

	    private async void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
	    {

	        var employe = e.Item as Employe;
            //var response = await DisplayAlert(employe.Nom + " tapped ", employe.Poste, "Ok", "Cancel ");
            //var page = new EmployeInfo(employe);
	        var page = new EmployeInfo();
	        page.BindingContext = employe;
            await Navigation.PushAsync(page);
	    }

	    private void MenuItem_OnClicked(object sender, EventArgs e)
	    {
	        var obj = sender as MenuItem;
	        var employe = obj.CommandParameter as Employe;
	        employes.Remove(employe);
            

	    }

	    public ObservableCollection<Employe> GetList()
	    {
            return new ObservableCollection<Employe> {  new Employe
                {
                    Nom = "Ahmed",
                    Poste = "Enseignant",
                    UrlImage = "http://lorempixel.com/100/100/people/3"

                },
                new Employe
                {
                    Nom = "Mohamed",
                    Poste = "Ingénieur",
                    UrlImage = "http://lorempixel.com/100/100/people/4"

                } };
	    }
        

        private void ListView_OnRefreshing(object sender, EventArgs e)
	    {

	        var list = GetList();
	        listView.ItemsSource = list;
            listView.EndRefresh();
	    }

	    private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
	    {

            var list = employes.Where(a => a.Nom.Contains(e.NewTextValue)  ).ToList();
            var newList = new ObservableCollection<Employe>(list);
	        listView.ItemsSource = newList;
	    }

	    private void SearchBar_OnSearchButtonPressed(object sender, EventArgs e)
	    {
	        
	        var list = employes.Where(a => a.Nom.Contains(searchBar.Text)).ToList();
	        var newList = new ObservableCollection<Employe>(list);
	        listView.ItemsSource = newList;
        }

	 
	}
}