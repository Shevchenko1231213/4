using Lab4.Abstract;
using Lab4.Factory;

namespace Lab4.Data
{
    public class Language
    {
        private EncryptWords _encrypt;
        private DecryptWords _decrypt;

        public Language(LanguagesFactory factory)
        {
            _encrypt = factory.MakeEncrypt();
            _decrypt = factory.MakeDecrypt();
        }

        public string Encrypt(string text, int value)
        {
            return _encrypt.Encrypt(text, value);
        }

        public string Decrypt(string encrypt, int value)
        {
            return _encrypt.Encrypt(encrypt, value);
        }
    }
}
