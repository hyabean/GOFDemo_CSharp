namespace AbstractFactory
{
    public class AmericanTax : Tax
    {
        public override double CalculateTex()
        {
            return Constant.BASE_SALARY * 0.05 + (Constant.BASE_SALARY * 0.15) * 0.25;
        }
    }
}
