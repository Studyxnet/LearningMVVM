using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Usuario
    {
        public string Nome { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public Usuario()
        {

        }

        public Usuario(string nome, string login, string senha)
        {
            Nome = nome;

            Login = login;

            Senha = senha;
        }

        public bool ValidaSenha()
        {
            return this.Senha.Equals("xamarinBR");
        }

        public int Insert(Usuario novo)
        {
			//Conexão com o Banco
            return 1;
        }
    }
}
