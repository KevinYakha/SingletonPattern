namespace SingletonPattern
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Main starts here!");

            // Console.WriteLine(StandardInterestRate.interestRate); // an object reference required
            StandardInterestRate currentRate = StandardInterestRate.getInstance();
            Console.WriteLine(currentRate.interestRate);

            // changing interest rate
            currentRate.interestRate = 0.05f;

            // trying to get another instance
            StandardInterestRate anotherRate = StandardInterestRate.getInstance();

            Console.WriteLine(currentRate.interestRate);
        }
    }
}
