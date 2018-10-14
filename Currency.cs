using System;

namespace ATMClerk.Tester
{
    /// <summary>
    /// Currency Class
    /// </summary>
    public class Currency
    {
        public Guid Id {get;} = Guid.NewGuid();

        /// <summary>
        /// Friendly currency name
        /// </summary>
        /// <value></value>
        public string Name {get; private set;}

        /// <summary>
        /// ISO 4217 Currency Code Alpha code
        /// </summary>
        /// <value></value>
        public string Code {get; private set;}
        public string Numeric {get; private set;}
        public int Exponent {get; private set;}
    }
}