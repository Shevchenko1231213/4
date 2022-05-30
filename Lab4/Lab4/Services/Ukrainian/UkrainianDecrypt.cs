using Lab4.Abstract;

namespace Lab4.Services.Ukrainian
{
    public class UkrainianDecrypt : DecryptWords
    {
        string decrypt = "";
        public override string Decrypt(string encrypt, int value)
        {
            for(int ichar = 0; ichar < encrypt.Length; ichar++)
            {
                decrypt += (char)(encrypt[ichar] - value);
            }

            return decrypt;
        }
    }
}
