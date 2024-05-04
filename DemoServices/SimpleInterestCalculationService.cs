namespace DemoServices
{
    public class SimpleInterestCalculationService
    {
        private readonly INumberService _numberService;

        public SimpleInterestCalculationService(INumberService numberService)
        {
            _numberService = numberService;
        }

        public int Calculate(int principle, int rate, int years)
        {
            var multiplyResult = _numberService.Multiply(principle, rate, years);

            return _numberService.Divide(multiplyResult, 100);
        }
    }
}
