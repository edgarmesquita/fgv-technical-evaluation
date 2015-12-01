using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGV.TechnicalEvaluation.Domain.Exceptions
{
    public class OrdenationException : Exception
    {
        public OrdenationException(string message) : base(message)
        {
            
        }
    }
}
