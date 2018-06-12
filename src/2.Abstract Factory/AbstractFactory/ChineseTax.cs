namespace AbstractFactory
{
    public class ChineseTax : Tax
    {
        public override double CalculateTex()
        {
            return (Constant.BASE_SALARY + (Constant.BASE_SALARY * 0.1)) * 0.4;
        }
    }
}
