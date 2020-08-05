namespace IDictionarySample
{
    public class ReturnErrorWithoutDictionary : IErrorHandler
    {
        public string GetError(int cod)
        {
            if (cod == 21 || cod == 22 || cod == 23)
            {
                return "Ocorreu um erro na aplicação.";
            }
            else if (cod == 25 || cod == 26 || cod == 27)
            {
                return "Ocorreu um erro no servidor.";
            }
            else
            {
                return "Erro não encontrado.";
            }
        }
    }
}
