using System;

namespace Model
{
	public class Aluno
	{
		public Aluno ()
		{
		}

		public string Nome {
			get;
			set;
		}
		public int Idade{ get;
			set;}

		public bool MaiorIdade(){
			return Idade >=18;
		}

		public bool ValidaNome(){
			return Nome.Length > 5;
		}
	}
}

