using System;

namespace ATMClerk.Tester
{
    /// <summary>
    /// Denomination of money amount, in terms of currency and denominiation
    /// </summary>
    public class Denomination
    {
        public Guid Id {get;} = Guid.NewGuid();
        /// <summary>
        /// Denomination friendly name
        /// </summary>
        /// <value></value>
        public string Name {get; private set;} 
        public double Multiplier {get; private set;}
        public Currency Currency {get; private set;}
    }
}