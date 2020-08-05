using System.Linq;

namespace IDictionarySample
{
    public class ReturnErrorWithDictionary : IErrorHandler
    {
        private readonly ErrorsDictionary errors;

        public ReturnErrorWithDictionary()
        {
            errors = new ErrorsDictionary();
        }

        public string GetError(int cod) => errors.First(x => x.Key == cod).Value;
    }
}
