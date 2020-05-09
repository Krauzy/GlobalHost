using System;

namespace GlobalHost.API
{
    class Validate
    {
        public static bool CPF(string value)
        {
            value = value.Trim().Replace(".", "").Replace("-", "").Replace("/", "").Replace(",", "");
            if (value.Length == 11)
            {
                int[] cpf = new int[11];
                int soma = 0;
                for (int i = 0; i < value.Length - 2; i++)
                {
                    cpf[i] = Convert.ToInt32(value[i]) - 48;
                    soma += cpf[i] * (10 - i);
                }
                int resto = soma % 11;
                int aux = 11 - resto;

                if (aux > 9)
                    cpf[9] = 0;
                else
                    cpf[9] = aux;

                soma = 0;
                for (int i = 0; i < value.Length - 1; i++)
                {
                    cpf[i] = Convert.ToInt32(value[i]) - 48;
                    soma += cpf[i] * (11 - i);
                }
                resto = soma % 11;
                aux = 11 - resto;

                if (aux > 9)
                    cpf[10] = 0;
                else
                    cpf[10] = aux;

                for (int i = 0; i < value.Length; i++)
                {
                    if (cpf[i] != (Convert.ToInt32(value[i]) - 48))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                //MessageBox.Show("CPF Inválido!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

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
            return System.Text.RegularExpressions.Regex.IsMatch(email, ("(?<user>[^@]+)@(?<host>.+)"));
        }
    }
}
