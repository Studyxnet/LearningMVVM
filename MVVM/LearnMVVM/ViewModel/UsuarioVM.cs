using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ViewModel
{
	//Implementou INotify: Criou-se o Evento PropertyChanged
    public class UsuarioVM : INotifyPropertyChanged
    {
		//Pré implementado pelo Framework
        public event PropertyChangedEventHandler PropertyChanged;

		//Implementar Um Método com Parametro PropetyName 
		public virtual void OnPropChange(string propertyName)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		bool _senhavalida;

		public Model.Usuario UsuarioModel { get; set; }

		public ICommand ValidaSenha { protected set; get; }

        public UsuarioVM()
        {
            UsuarioModel = new Model.Usuario();

			ValidaSenha = new Command(this.Logar);
        }

		public async void Logar(){

			SenhaValida = !UsuarioModel.ValidaSenha();

		}

        public string Nome
        {
            get { return UsuarioModel.Nome; }
            set
            {
                if (UsuarioModel.Nome != value)
                {
                    UsuarioModel.Nome = value;
                    OnPropChange("Nome");
                }
            }
        }

        public string Login
        {
            get { return UsuarioModel.Login; }
            set
            {
                if (UsuarioModel.Login != value)
                {
                    UsuarioModel.Login = value;
                    OnPropChange("Login");
                }
            }
        }

        public bool SenhaValida
        {
            get { return _senhavalida; }
            set
            {
                if (_senhavalida != value)
                {
                    _senhavalida = value;
                    OnPropChange("SenhaValida");
                }
            }
        }



        public string Senha
        {
            get { return UsuarioModel.Senha; }
            set
            {
                if (UsuarioModel.Senha != value)
                {
                    UsuarioModel.Senha = value;
                    OnPropChange("Senha");
                }
            }
        }



    }
}
