
using Model;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using System.Windows.Input;


namespace ViewModel
{
	public class ModeView : INotifyPropertyChanged
	{

		public Modelo Modelo {
			get;
			set;
		}

		public ModeView ()
		{
			Modelo = new Modelo ();
		}

		public event PropertyChangedEventHandler PropertyChanged;

		public virtual void OnPropertyChanged(string PropertyName){
			if (PropertyChanged != null) {
				PropertyChanged (this, new PropertyChangedEventArgs (PropertyName));
			}
		}

		public String MinhaPropriedade {
			get{ return Modelo.Propriedade; }
			set{ 
				if (Modelo.Propriedade != value) {
					Modelo.Propriedade = value;
					OnPropertyChanged ("MinhaPropriedade");
				}
			}
		}
	}
}

