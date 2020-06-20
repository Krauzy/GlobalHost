using System;
using GlobalHost.WebServiceDolar;

namespace GlobalHost.API
{
    class Quot
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
                return 0;
            }
            string x = "" + ((double)dolar / 10000);
            return Convert.ToDouble(x.Substring(0, x.IndexOf(',') + 3));
        }

        public static double getEuro()
        {
            double euro;
            try
            {
                FachadaWSSGSClient fachadaWSSGSClient = new FachadaWSSGSClient();
                euro = Convert.ToDouble(fachadaWSSGSClient.getUltimosValoresSerieVO(21619, 1).valores[0].svalor);
            }
            catch (Exception)
            {
                return 0;
            }
            string x = "" + ((double)euro / 10000000);
            return Convert.ToDouble(x.Substring(0, x.IndexOf(',') + 3));
        }

        public static double getDolarCanadense()
        {
            double dolar;
            try
            {
                FachadaWSSGSClient fachadaWSSGSClient = new FachadaWSSGSClient();
                dolar = Convert.ToDouble(fachadaWSSGSClient.getUltimosValoresSerieVO(21635, 1).valores[0].svalor);
            }
            catch (Exception)
            {
                return 0;
            }
            string x = "" + ((double)dolar / 1000000);
            return Convert.ToDouble(x.Substring(0, x.IndexOf(',') + 3));
        }

        public static double getIene()
        {
            double iene;
            try
            {
                FachadaWSSGSClient fachadaWSSGSClient = new FachadaWSSGSClient();
                iene = Convert.ToDouble(fachadaWSSGSClient.getUltimosValoresSerieVO(11759, 1).valores[0].svalor);
            }
            catch (Exception)
            {
                return 0;
            }
            string x = "" + ((double)iene / 100000);
            return Convert.ToDouble(x.Substring(0, x.IndexOf(',') + 4));
        }

        public static double getLibra()
        {
            double libra;
            try
            {
                FachadaWSSGSClient fachadaWSSGSClient = new FachadaWSSGSClient();
                libra = Convert.ToDouble(fachadaWSSGSClient.getUltimosValoresSerieVO(21623, 1).valores[0].svalor);
            }
            catch (Exception)
            {
                return 0;
            }
            string x = "" + ((double)libra / 100000);
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
