namespace DemoServices
{
    public interface INumberService
    {
        int AddTwoNumbers(int number1, int number2);
        int Divide(int number1, int number2);
        int Multiply(params int[] numbers);
    }
}