using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace DemoAppX.modelo
{
    public class USUARIOS:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
		private bool isBusy = false;

		public bool IsBusy
		{
			get { return isBusy = false; }
			set { isBusy = value;
				OnPropertyChanged();
			}
		}


		private string id;

		public string Id
		{
			get { return id; }
			set { 
				id = value;
				OnPropertyChanged();

            }
		}
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set {
				nombre = value;
                OnPropertyChanged();
            }
		}

		private string username;

		public string Username
        {
			get { return username; }
			set {
				username = value;
                OnPropertyChanged();
            }
		}

		private bool status;

		public bool Status
		{
			get { return status; }
			set { 
				status = value;
                OnPropertyChanged();
            }
		}
        private string contra;

        public string Contra
        {
            get { return contra; }
            set
            {
                contra = value;
                OnPropertyChanged();
            }
        }

        private string mensaje;
  
        public string Mensaje
		{
			get {
				return $"Tu nombre es {nombre}"; 
			}
		}




	}
}
