using System;

namespace GlobalHost.API
{
    class Validate
    {
        public static bool CPF(string cpf)
        {
            //value = value.Trim().Replace(".", "").Replace("-", "").Replace("/", "").Replace(",", "");
            string valor = cpf.Replace(".", "");
            valor = valor.Replace("-", "");
            valor = valor.Replace(",", "");
            if (valor.Length != 11)
                return false;
            bool igual = true;
            for (int i = 1; i < 11 && igual; i++)
                if (valor[i] != valor[0])
                    igual = false;
            if (igual || valor == "12345678909")
                return false;
            int[] numeros = new int[11];
            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(valor[i].ToString());
            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (10 - i) * numeros[i];
            int resultado = soma % 11;
            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                    return false;
            }
            else if (numeros[9] != 11 - resultado)
                return false;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (11 - i) * numeros[i];
            resultado = soma % 11;
            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                    return false;
            }
            else
                if (numeros[10] != 11 - resultado)
                return false;
            return true;
        }

        public static bool CNPJ(string value)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            value = value.Trim().Replace(".", "").Replace("-", "").Replace("/", "").Replace(",", "");
            if (value.Length != 14)
                return false;

            string tempCnpj = value.Substring(0, 12);
            int soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            int resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCnpj += digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito += resto.ToString();

            return value.EndsWith(digito);

        }

        public static bool CEP(string cep)
        {
            cep = cep.Trim().Replace("-", "").Replace(",", "").Replace(".", "");
            if (cep.Length == 8)
            {
                cep = cep.Substring(0, 5) + "-" + cep.Substring(5, 3);
                return System.Text.RegularExpressions.Regex.IsMatch(cep, ("[0-9]{5}-[0-9]{3}"));
            }
            else
                return false;
        }

        public static bool EMAIL(string email)
        {
            bool result = false;
            string n;
            if (email.Contains("@"))
            {
                n = email.Substring(email.IndexOf('@'));
                if(n.Contains("."))
                {
                    n = n.Substring(n.IndexOf('.'));
                    if (n.Contains("."))
                        result = true;
                }
            }
            return result;
            //return System.Text.RegularExpressions.Regex.IsMatch(email, ("(?<user>[^@]+)@(?<host>.+)"));
        }

        public static string MONEY(string value)
        {
            char[] numbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', ',' };
            if (value.Contains(","))
            {
                try
                {
                    int k = value.IndexOf(',');
                    value = value.Remove(k + 3);
                }
                catch { }
            }
            else
            {
                value += ",00";
            }
            //
            if (value != string.Empty)
            {
                int max = value.Length;
                for (int i = 0; i < max; i++)
                {
                    bool result = false;
                    foreach(char n in numbers)
                    {
                        if (value[i] == n)
                            result = true;
                    }

                    if (!result)
                    {
                        value = value.Replace(value[i].ToString(), string.Empty);
                        if (i != 0)
                            i--;
                        max = value.Length;
                    }
                }
            }
            return value;
        }
    }
}
