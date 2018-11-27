using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Salud.Models;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Salud.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SaludPage : ContentPage
	{
		public SaludPage ()
		{
			InitializeComponent ();
            CargarPacientes();
		}

        /*private void CargarPacientes()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("");
            var request = client.GetAsync("").Result;
            if (request.IsSuccessStatusCode)
            {
                var responseJson = request.Content.ReadAsStringAsync().Result;
                var response = JsonConvert.DeserializeObject<List<Paciente>>(responseJson);
                paciente.ItemsSource = response;
            }

           
        }*/
        private void CargarPacientes()
        {
            var listado = new List<Paciente>
            {
                new Paciente{ nombre = "Pepe", tipodeidentificacion = "cc", identificacion = 123456789, eps = "sura", tiposangre = "B+", foto="paciente.png"},

            };

            paciente.ItemsSource = listado;
        }
       /* private async void ProductoSeleccionado(object sender, SelectedItemChangedEventArgs e)
        {
            var producto = e.SelectedItem as Producto;
            string mensaje = string.Format("Producto : {0} - Cantidad : {1}", producto.Nombre, producto.Cantidad);
            await DisplayAlert("Producto seleccionado", mensaje, "Ok");
        }*/
    }
}