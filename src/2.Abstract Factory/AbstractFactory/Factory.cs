namespace AbstractFactory
{
    /// <summary>
    /// Factory类
    /// </summary>
    public class Factory
    {
        public Tax CreateTax()
        {
            return new AmericanTax();
        }

        public Bonus CreateBonus()
        {
            return new AmericanBonus();
        }
    }


}
