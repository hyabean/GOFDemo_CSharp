namespace AbstractFactory
{
    public class AmericanFactory : AbstractFactory
    {
        public override Bonus CreateBonus()
        {
            return new AmericanBonus();
        }

        public override Tax CreateTax()
        {
            return new AmericanTax();
        }
    }
}