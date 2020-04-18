using System;

namespace GlobalHost.Modelo
{
    class Parametros
    {
        private int id;
        private string nome_fantasia;
        private string razao_social;
        private string cnpj;
        private DateTime data_abertura;
        private string endereco;
        private string email;
        private string site;
        private string atividade;
        private string status;
        private string telefone;

        public Parametros(int id, string nome_fantasia, string razao_social, string cnpj, DateTime data_abertura, string endereco, string email, string site, string atividade, string status, string telefone)
        {
            this.id = id;
            this.nome_fantasia = nome_fantasia;
            this.razao_social = razao_social;
            this.cnpj = cnpj;
            this.data_abertura = data_abertura;
            this.endereco = endereco;
            this.email = email;
            this.site = site;
            this.atividade = atividade;
            this.status = status;
            this.telefone = telefone;
        }

        public Parametros(string nome_fantasia, string razao_social, string cnpj, DateTime data_abertura, string endereco, string email, string site, string atividade, string status, string telefone)
        {
            this.nome_fantasia = nome_fantasia;
            this.razao_social = razao_social;
            this.cnpj = cnpj;
            this.data_abertura = data_abertura;
            this.endereco = endereco;
            this.email = email;
            this.site = site;
            this.atividade = atividade;
            this.status = status;
            this.telefone = telefone;
        }

        public int Id { get => id; set => id = value; }
        public string Nome_fantasia { get => nome_fantasia; set => nome_fantasia = value; }
        public string Razao_social { get => razao_social; set => razao_social = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public DateTime Data_abertura { get => data_abertura; set => data_abertura = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Email { get => email; set => email = value; }
        public string Site { get => site; set => site = value; }
        public string Atividade { get => atividade; set => atividade = value; }
        public string Status { get => status; set => status = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}
