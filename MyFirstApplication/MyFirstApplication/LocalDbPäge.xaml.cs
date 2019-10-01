using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstApplication
{
    [Table("Person")]
    public class ClassPerson : INotifyPropertyChanged
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get
            {
                return _name;
            } set
            {
                if (_name == value)
                    return;
                _name = value;
                OnPropertyChanged();
            } }
        private string _name;
        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LocalDbPäge : ContentPage
	{
        ObservableCollection<ClassPerson> _persons = new ObservableCollection<ClassPerson>();
        SQLiteAsyncConnection _connexion;
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            _connexion = DependencyService.Get<ISQLiteDB>().GetConnection();
            await _connexion.CreateTableAsync<ClassPerson>();

            _persons = new ObservableCollection<ClassPerson>( await _connexion.Table<ClassPerson>().ToListAsync());
            personsListView.ItemsSource = _persons;
        }
        public LocalDbPäge ()
		{
			InitializeComponent ();
		}
        public async void OnAdd(object sender, EventArgs e)
        {
            var person = new ClassPerson {
                Name = "Slim " + DateTime.Now.Ticks
            };
             await _connexion.InsertAsync(person);
             _persons.Add(person);
        }
        public async void OnUpdate(object sender, EventArgs e)
        {
            var person = _persons[0];
            person.Name += " Updated";
            await _connexion.UpdateAsync(person);
        }
        public async void OnDelete(object sender, EventArgs e)
        {
            var person = _persons[0];
            await _connexion.DeleteAsync(person);
            _persons.RemoveAt(0);
            //_connexion.QueryAsync<ClassPerson>("select * from person")

        }
    }
}