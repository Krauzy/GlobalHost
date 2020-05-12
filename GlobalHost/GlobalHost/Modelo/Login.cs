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
        private int nivel;

        public Login()
        {
        }

        public Login(int id, string usuario, string senha, int nivel)
        {
            this.id = id;
            this.usuario = usuario;
            this.senha = senha;
            this.nivel = nivel;
        }

        public Login(string usuario, string senha, int nivel)
        {
            this.usuario = usuario;
            this.senha = senha;
            this.nivel = nivel;
        }

        public int Id { get => id; set => id = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Senha { get => senha; set => senha = value; }
        public int Nivel { get => nivel; set => nivel = value; }

        public override string ToString()
        {
            return this.usuario;
        }
    }
}
