using System;

namespace BloggerCookBook.Exemptions
{
    class LoginException : ApplicationException
    {
        public LoginException() : base("Incorrect form input")
        {

        }
        public LoginException(string exemptionMessage) : base(exemptionMessage)
        {

        }
        public LoginException(string exemptionMessage, ApplicationException inner) : base(exemptionMessage, inner)
        {

        }
    }
}
