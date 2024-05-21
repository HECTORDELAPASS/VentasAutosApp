using DemoAppX.modelo;
using DemoAppX.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoAppX.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsuarioPage : ContentPage
    {
        UsuarioViewModel contexto = new UsuarioViewModel();

        public UsuarioPage()
        {
            InitializeComponent();
            BindingContext = contexto;
            LvUsuario.ItemSelected += lvusuarios_Itemselected;
        }
        private void lvusuarios_Itemselected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                USUARIOS modelo = (USUARIOS)e.SelectedItem;
                contexto.Nombre = modelo.Nombre;
                contexto.Username = modelo.Username;
                contexto.Contra=modelo.Contra;
                contexto.Id=modelo.Id;

            }
        }
    }
}