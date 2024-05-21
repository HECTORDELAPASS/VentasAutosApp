using DemoAppX.modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;

namespace DemoAppX.Servicio
{
    public class UsuarioServicio
    {
        public ObservableCollection<USUARIOS> Usuarios { get; set; }

        public UsuarioServicio()
        {
            if (Usuarios == null)
            {
                Usuarios = new ObservableCollection<USUARIOS>();
            }
        }
        public ObservableCollection<USUARIOS> consultar()
        {

            return Usuarios;
        }
        public void guardar(USUARIOS modelo)
        {
            Usuarios.Add(modelo);
        }
        public void modificar(USUARIOS modelo)
        {
            for (int i = 0; i < Usuarios.Count; i++)
            {
                if (Usuarios[i].Id==modelo.Id)
                {
                    Usuarios[i] = modelo;
                }
            }
        }
        public void eliminar(string idUsuario)
        {
            USUARIOS modelo = Usuarios.FirstOrDefault(u => u.Id == idUsuario);
            Usuarios.Remove(modelo);
        }
    }
}
