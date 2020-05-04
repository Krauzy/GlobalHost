using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.Modelo
{
    class Login
    {
        private int id;
        private string usuario;
        private string senha;

        public Login()
        {
        }

        public Login(int id, string usuario, string senha)
        {
            this.id = id;
            this.usuario = usuario;
            this.senha = senha;
        }

        public Login(string usuario, string senha)
        {
            this.usuario = usuario;
            this.senha = senha;
        }

        public int Id { get => id; set => id = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}
