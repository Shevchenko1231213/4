using Lab4.Abstract;
using Lab4.Services.English;

namespace Lab4.Factory
{
    public class EnglishLanguageFactory : LanguagesFactory
    {
        public override EncryptWords MakeEncrypt()
        {
            return new EnglishEncrypt();
        }
        public override DecryptWords MakeDecrypt()
        {
            return new EnglishDecrypt();
        }
    }
}
