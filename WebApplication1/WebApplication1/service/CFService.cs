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
    }
}