using DemoAppX.modelo;
using DemoAppX.Servicio;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoAppX.ViewModel
{
    public class UsuarioViewModel:USUARIOS
    {
        public ObservableCollection<USUARIOS> Usuarios {  get; set; }
        UsuarioServicio servicio = new UsuarioServicio();
        USUARIOS modelo;

        public UsuarioViewModel()
        {
            Usuarios = servicio.consultar();
            Guardarcommand = new Command(async () => await Guardar(), () => !IsBusy);
            modificarcommand = new Command(async () => await Modificar(), () =>! IsBusy);
            eliminarcommand = new Command(async () => await Eliminar(), () =>! IsBusy);
            Limpiarcommand = new Command(limpiar, () => !IsBusy);

        }
        public Command Guardarcommand { get; set; }
        public Command modificarcommand { get; set; }
        public Command eliminarcommand { get; set; }
        public Command Limpiarcommand { get; set; }

        private async Task Guardar()
        {
            IsBusy = true;
            Guid idUsuario = Guid.NewGuid();
            modelo = new USUARIOS()
            {
                Nombre = Nombre,
                Username = Username,
                Contra = Contra,
                Status = Status,
                Id = idUsuario.ToString()
            };
            servicio.guardar(modelo);
            await Task.Delay(2000);
            IsBusy = false;
        }

        private async Task Modificar()
        {
            IsBusy = true;
            modelo = new USUARIOS()
            {
                Nombre = Nombre,
                Username = Username,
                Contra = Contra,
                Status = Status,
                Id = Id
            };
            servicio.modificar(modelo);
            await Task.Delay(2000);
            IsBusy = false;
        }
        private async Task Eliminar()
        {
            IsBusy = true;
            servicio.eliminar(Id);
            await Task.Delay(2000);
            IsBusy = false;
        }

        private void limpiar ()
        {
            Nombre = "";
            Username = "";
            Contra = "";
            Status = false;
            Id = "";
        }
    }
}
