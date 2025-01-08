using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_24_OO_Excessao.Resolucao3
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}