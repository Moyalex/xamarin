
using Contactos.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contactos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NuevoContactoPage : ContentPage
    {
        public NuevoContactoPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs args)
        {
           Contacto nuevocontacto = new Contacto()
            {
                Nombre = nombreentry.Text,
                Apellido = apellidoentry.Text,
                Telefono = telefono.Text,
                Email = correoentry.Text
            };

            //using (var conn = new SQLite.SQLiteConnection(App.RUTA_DB))
            //{
            //    conn.CreateTable<Contacto>();
            //    conn.Insert(nuevocontacto);
            //}
            try
            {
                await App.mobileclient.GetTable<Contacto>().InsertAsync(nuevocontacto);
                await DisplayAlert("Exito", "El contacto ha sido insertado", "Ok");
            }
            catch (Exception)
            {
                await DisplayAlert("Error", "El contacto no pudo ser  insertado", "Ok");
            }
        }
    }
}