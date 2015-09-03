using System;
using System.Collections.Generic;

using ViewModel;

using Xamarin.Forms;

namespace LearnMVVM
{
	public partial class ValidarIdadeAluno : ContentPage
	{
		public ValidarIdadeAluno ()
		{
			InitializeComponent ();
			BindingContext = new AlunoVM ();
		}

		public void Button_Clicked(object sender, EventArgs e){
			(BindingContext as AlunoVM).Entrar ();
		}
	}
}

