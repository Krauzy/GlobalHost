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
            return dolar;
        }
    }
}
