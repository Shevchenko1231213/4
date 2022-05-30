using Lab4.Abstract;
using Lab4.Services.Ukrainian;

namespace Lab4.Factory
{
    public class UkrainianLanguageFactory : LanguagesFactory
    {
        public override EncryptWords MakeEncrypt()
        {
            return new UkrainianEncrypt();
        }
        public override DecryptWords MakeDecrypt()
        {
            return new UkrainianDecrypt();
        }
    }
}
