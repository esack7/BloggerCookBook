using System;

namespace BloggerCookBook.Exemptions
{
    public class SelectionExemption : ApplicationException
    {
        public SelectionExemption() : base("You must make a selection")
        {

        }
        public SelectionExemption(string exemptionMessage) : base(exemptionMessage)
        {

        }
        public SelectionExemption(string exemptionMessage, ApplicationException inner) : base(exemptionMessage, inner)
        {

        }
    }
}
