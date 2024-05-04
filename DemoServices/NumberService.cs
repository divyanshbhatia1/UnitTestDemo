namespace DemoServices
{
    public class NumberService : INumberService
    {
        public int Multiply(params int[] numbers)
        {
            var result = 1;

            foreach (var number in numbers)
            {
                result *= number;
            }

            return result;
        }

        public int AddTwoNumbers(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Divide(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}
