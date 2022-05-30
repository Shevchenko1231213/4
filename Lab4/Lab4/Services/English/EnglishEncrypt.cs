using Lab4.Abstract;

namespace Lab4.Services.English
{
    public class EnglishEncrypt : EncryptWords
    {
        string encrypt = "";
        public override string Encrypt(string text, int value)
        {
            for (int ichar = 0; ichar < text.Length; ichar++)
            {
                encrypt += (char)(text[ichar] + value);
            }

            return encrypt;
        }
    }
}
