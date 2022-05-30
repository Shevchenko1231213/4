using Lab4.Abstract;

namespace Lab4.Factory
{
    public abstract class LanguagesFactory
    {
        public abstract EncryptWords MakeEncrypt();
        public abstract DecryptWords MakeDecrypt();
    }
}
