namespace SingletonPattern
{
    public class StandardInterestRate
    {
        private static readonly StandardInterestRate instance = new StandardInterestRate();

        public float interestRate = 0.03f;

        private StandardInterestRate()
        {
            Console.WriteLine("The Singleton was created");
        }

        public static StandardInterestRate getInstance()
        {
            return instance;
        }
    }
}
