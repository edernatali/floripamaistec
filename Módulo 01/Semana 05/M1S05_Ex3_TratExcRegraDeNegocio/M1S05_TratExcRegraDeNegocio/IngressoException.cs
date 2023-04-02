using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1S05_TratExcRegraDeNegocio
{
    internal class IngressoException : Exception
    {
        public IngressoException() 
        { 
        
        }

        public IngressoException(string message) : base(message)
        {

        }

        public IngressoException(string message, Exception causaException) : base(message, causaException)
        {

        }
    }
}
