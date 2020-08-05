using System.Collections.Generic;

namespace IDictionarySample
{
    public class ErrorsDictionary : Dictionary<int, string>
    {
        public void Populate()
        {
            Add(21, ErrorsConstants.ErrorInApplication);
            Add(22, ErrorsConstants.ErrorInApplication);
            Add(23, ErrorsConstants.ErrorInApplication);
            Add(25, ErrorsConstants.ErrorInServer);
            Add(26, ErrorsConstants.ErrorInServer);
            Add(27, ErrorsConstants.ErrorInServer);
        }
        public ErrorsDictionary()
        {
            Populate();
        }
    }
}
