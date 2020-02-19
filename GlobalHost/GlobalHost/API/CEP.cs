using Newtonsoft.Json;
using System;
using System.Net;
using System.Windows.Forms;

namespace GlobalHost.API
{
    class CEP
    {
        private string cep;
        private string logradouro;
        private string complemento;
        private string bairro;
        private string localidade;
        private string uf;
        private string unidade;
        private string ibge;
        private string gia;

        public CEP(string c)
        {
            BuscaCEP busca = new BuscaCEP();
            try
            {
                if (c.Length == 8)
                {
                    ViaCEPModel Modelo = busca.GetModelo(c);

                    this.cep = Modelo.Cep;
                    this.logradouro = Modelo.Logradouro;
                    this.complemento = Modelo.Complemento;
                    this.bairro = Modelo.Bairro;
                    this.localidade = Modelo.Localidade;
                    this.uf = Modelo.UF;
                    this.unidade = Modelo.Unidade;
                    this.ibge = Modelo.IBGE;
                    this.gia = Modelo.GIA;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string Cep
        {
            get => cep;
            set => cep = value;
        }
        public string Logradouro
        {
            get => logradouro;
            set => logradouro = value;
        }
        public string Complemento
        {
            get => complemento;
            set => complemento = value;
        }
        public string Bairro
        {
            get => bairro;
            set => bairro = value;
        }
        public string Localidade
        {
            get => localidade;
            set => localidade = value;
        }
        public string Uf
        {
            get => uf;
            set => uf = value;
        }
        public string Unidade
        {
            get => unidade;
            set => unidade = value;
        }
        public string Ibge
        {
            get => ibge;
            set => ibge = value;
        }
        public string Gia
        {
            get => gia;
            set => gia = value;
        }
    }

    internal class BuscaCEP
    {
        public string GetString(string cep)
        {
            ViaCEPService Service = new ViaCEPService();
            try
            {
                string result = Service.GetEndereco(cep);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        public ViaCEPModel GetModelo(string cep)
        {
            ViaCEPService Service = new ViaCEPService();
            try
            {
                string jsonResult = Service.GetEndereco(cep);
                ViaCEPModel Model = JsonConvert.DeserializeObject<ViaCEPModel>(jsonResult);
                return Model;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }

    [Serializable]
    internal class ViaCEPModel
    {
        [JsonProperty(PropertyName = "cep")]
        public string Cep { get; set; }

        [JsonProperty(PropertyName = "logradouro")]
        public string Logradouro { get; set; }

        [JsonProperty(PropertyName = "complemento")]
        public string Complemento { get; set; }

        [JsonProperty(PropertyName = "bairro")]
        public string Bairro { get; set; }

        [JsonProperty(PropertyName = "localidade")]
        public string Localidade { get; set; }

        [JsonProperty(PropertyName = "uf")]
        public string UF { get; set; }

        [JsonProperty(PropertyName = "unidade")]
        public string Unidade { get; set; }

        [JsonProperty(PropertyName = "ibge")]
        public string IBGE { get; set; }

        [JsonProperty(PropertyName = "gia")]
        public string GIA { get; set; }
    }

    internal class ViaCEPService
    {
        public string GetEndereco(string cep)
        {
            try
            {
                string result = string.Empty;
                string viaCEPUrl = $"https://viacep.com.br/ws/{cep}/json/";
                using (WebClient client = new WebClient())
                {
                    result = client.DownloadString(viaCEPUrl);
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }
    }
}
