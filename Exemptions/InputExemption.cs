using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerCookBook.Exemptions
{
    public class InputExemption : ApplicationException
    {
        public InputExemption() : base("Invalide Input")
        {

        }
        public InputExemption(string exemptionMessage) : base(exemptionMessage)
        {

        }
        public InputExemption(string exemptionMessage, ApplicationException inner) : base(exemptionMessage, inner)
        {

        }
    }
}
