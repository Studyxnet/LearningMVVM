using System;
using System.ComponentModel;
using Model;
using Xamarin.Forms;
using System.Windows.Input;

namespace ViewModel
{
	public class AlunoVM : INotifyPropertyChanged
	{
		public Aluno ModeloAluno {
			get;
			set;
		}

		public AlunoVM ()
		{
			ModeloAluno = new Aluno ();

			EntrarCommand = new Command (this.Entrar);
		}
		public void Entrar(){
			if(string.IsNullOrWhiteSpace(Nome)){
				Cor = Color.Red;
			}
			else{
				
				Cor = Color.White;
			}
		}
		public event PropertyChangedEventHandler PropertyChanged;

		public virtual void OnPropertyChanged(string PropertyName){
			if (PropertyChanged != null) {
				PropertyChanged (this, new PropertyChangedEventArgs (PropertyName));
			}
		}



		public string Nome{
			get{ return ModeloAluno.Nome; }
			set{
				if (ModeloAluno.Nome != value) {

					ModeloAluno.Nome = value;
					OnPropertyChanged ("Nome");

				}
			}
		}
		public int Idade{
			get{ return ModeloAluno.Idade; }
			set{
				if (ModeloAluno.Idade != value) {
					ModeloAluno.Idade = value;
					OnPropertyChanged ("Idade");
					OnPropertyChanged ("MaiorIdade");
				}
			}
		}

		public bool MaiorIdade{
			get { return ModeloAluno.MaiorIdade (); }	}

		public ICommand EntrarCommand{ get; protected set; }

		private Color cor = Color.White;

		public Color Cor{ get{ return cor; } 
			set{
				if (cor != value) {
					cor = value;
					OnPropertyChanged ("Cor");
				}
			}}
	}
}

