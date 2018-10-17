namespace ATMClerk.Tester
{
    public class Money
    {
        public Money(double amount, Denomination denomination)
        {
            this.Amount = amount;
            this.Denomination = denomination;
        }
        
        public double Amount {get; private set;}
        public Denomination Denomination {get; private set;}
    }
}