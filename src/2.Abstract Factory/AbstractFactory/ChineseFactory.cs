namespace AbstractFactory
{
    public class ChineseFactory : AbstractFactory
    {
        public override Bonus CreateBonus()
        {
            return new ChineseBonus();
        }

        public override Tax CreateTax()
        {
            return new ChineseTax();
        }
    }


}
