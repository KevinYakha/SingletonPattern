namespace SingletonPattern
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Main starts here!");

            // and object reference is required:
            // Console.WriteLine($"The current interest rate is at: {currentRate.interestRate * 100}%");

            StandardInterestRate currentRate = StandardInterestRate.getInstance();
            Console.WriteLine($"The current interest rate is at: {currentRate.interestRate * 100}%");

            // changing interest rate
            currentRate.interestRate = 0.05f;

            // trying to get another instance
            StandardInterestRate anotherRate = StandardInterestRate.getInstance();

            Console.WriteLine($"The current interest rate is at: {anotherRate.interestRate * 100}%");
        }
    }
}
