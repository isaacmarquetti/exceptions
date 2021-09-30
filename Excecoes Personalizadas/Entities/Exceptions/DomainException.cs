using System;
using System.Collections.Generic;
using System.Text;

namespace Excecoes_Personalizadas.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
