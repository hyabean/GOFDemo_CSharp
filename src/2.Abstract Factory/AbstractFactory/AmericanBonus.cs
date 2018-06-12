namespace AbstractFactory
{
    public class AmericanBonus : Bonus
    {
        public override double Calculate()
        {
            return Constant.BASE_SALARY * 0.1;
        }
    }


}
