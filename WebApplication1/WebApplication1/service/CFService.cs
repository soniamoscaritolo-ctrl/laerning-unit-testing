using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace WebApplication1.service
{
    public class CFService
    {


        public bool seVocale(char c)
        {
            char clower = char.ToLower(c);
            char[] vocali = { 'a', 'e', 'i', 'o', 'u' };
            foreach (char v in vocali)
            {
                if (v == clower)
                {
                    return true;
                }
            }
            return false;
        }
       
            public String CodNome(String s)
            {
                String vocali = "";
                String consonanti = "";
                foreach (char c in s)
                {
                    if (seVocale(c))
                    {
                        vocali += c;
                    }
                    else if (char.IsLetter(c))
                    {
                        consonanti += c;
                    }
                }

                char[] vocaliArrey = vocali.ToCharArray();
                char[] consonantiArrey = consonanti.ToCharArray();
                string risultato = "";

                if (consonanti.Length >= 4)
                {
                    // 1a, 3a, 4a consonante
                    risultato = "" + consonanti[0] + consonanti[2] + consonanti[3];
                }
                else if (consonanti.Length == 3)
                {
                    // 1a, 2a, 3a consonante
                    risultato = consonanti.Substring(0, 3);
                }
                else if (consonanti.Length == 2)
                {
                    // 2 consonanti + 1a vocale
                    risultato = consonanti;
                    if (vocali.Length >= 1)
                        risultato += vocali[0];
                    else
                        risultato += "X";
                }
                else if (consonanti.Length == 1)
                {
                    // 1 consonante + prime 2 vocali (o X se mancano)
                    risultato = consonanti;
                    if (vocali.Length == 0)
                        risultato += "XX";
                    else if (vocali.Length == 1)
                        risultato += vocali[0] + "X";
                    else
                        risultato += vocali[0].ToString() + vocali[1].ToString();
                }
                else // nessuna consonante
                {
                    if (vocali.Length == 1)
                        risultato = vocali[0] + "XX";
                    else if (vocali.Length >= 2)
                        risultato = vocali[0].ToString() + vocali[1].ToString() + "X";
                    else
                        risultato = "XXX";
                }
                return risultato;

            }

        }
    }


