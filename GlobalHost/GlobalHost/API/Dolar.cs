using System;
using GlobalHost.WebServiceDolar;

namespace GlobalHost.API
{
    class Dolar
    {
        public static double getDolar()
        {
            double dolar;
            try
            {
                FachadaWSSGSClient fachadaWSSGSClient = new FachadaWSSGSClient();
                dolar = Convert.ToDouble(fachadaWSSGSClient.getUltimosValoresSerieVO(1, 1).valores[0].svalor);
                
            }
            catch (Exception)
            {
                dolar = 0;
            };
            string x = "" + ((double)dolar / 10000);
            return Convert.ToDouble(x.Substring(0, x.IndexOf(',') + 3));
        }

        public static double ConvertToDolar(double real)
        {
            string x = "" + (real / getDolar());
            return Convert.ToDouble(x.Substring(0, x.IndexOf(',') + 3));
        }

        public static double ConvertToDolar(string real)
        {
            string x = "" + (Convert.ToDouble(real) / getDolar());
            return Convert.ToDouble(x.Substring(0, x.IndexOf(',') + 3));
        }

        public static double ConvertToReal(double dolar)
        {
            string x = "" + (dolar * getDolar());
            return Convert.ToDouble(x.Substring(0, x.IndexOf(',') + 3));
        }

        public static double ConvertToReal(string dolar)
        {
            string x = "" + (Convert.ToDouble(dolar) * getDolar());
            return Convert.ToDouble(x.Substring(0, x.IndexOf(',') + 3));
        }
    }
}
