using System;

namespace IDictionarySample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HandlerWithoutDictionary.GetError(21));
            Console.WriteLine(HandlerWithDictionary.GetError(21));
            Console.WriteLine(HandlerWithoutDictionary.GetError(26));
            Console.WriteLine(HandlerWithDictionary.GetError(26));
        }
        private static IErrorHandler HandlerWithoutDictionary => new ReturnErrorWithoutDictionary();
        private static IErrorHandler HandlerWithDictionary => new ReturnErrorWithDictionary();
    }
}