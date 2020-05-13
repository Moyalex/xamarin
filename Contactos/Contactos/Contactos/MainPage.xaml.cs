using Contactos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Contactos
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        List<Contacto> contactos;
        public MainPage()
        {
            InitializeComponent();

            contactos = new List<Contacto>();

            contactoslistview.ItemSelected += Contactoslistview_ItemSelected;
        }

        private void Contactoslistview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var seleccionado= e.SelectedItem as Contacto;

            Navigation.PushAsync(new DetalleContactoPage(seleccionado));
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //using(var conn = new SQLite.SQLiteConnection(App.RUTA_DB))
            //{
            //    conn.CreateTable<Contacto>();
            //    contactos = conn.Table<Contacto>().ToList();

            //    contactoslistview.ItemsSource = contactos;
            //}

            try
            {
                contactos = await App.mobileclient.GetTable<Contacto>().ToListAsync();
                contactoslistview.ItemsSource = contactos;
            }
            catch (Exception)
            {

            }
        }

        private void toolbaritem_click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NuevoContactoPage());
        }


    }
}
