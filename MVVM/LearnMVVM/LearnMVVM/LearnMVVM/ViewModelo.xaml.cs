using System;
using System.Collections.Generic;
using ViewModel;
using Xamarin.Forms;

namespace LearnMVVM
{
	public partial class ViewModelo : ContentPage
	{
		public ViewModelo ()
		{
			InitializeComponent ();
			BindingContext = new ModeView ();
		}
	}
}

