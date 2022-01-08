namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            // Console.WriteLine(myValue.ToString());
            // Console.WriteLine(myValue.ToShortTimeString());
            // Console.WriteLine(myValue.ToLongDateString());
            //  Console.WriteLine(myValue.ToLongTimeString());

            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            //Console.WriteLine(myValue.AddDays(-3).ToLongDateString());

            //Console.WriteLine(myValue.Month);

            //DateTime mybirthday = new DateTime(1990, 12, 16);
            //Console.WriteLine(mybirthday.ToShortDateString());
            DateTime mybirthday = DateTime.Parse("16/12/1990");
            TimeSpan myAge = DateTime.Now.Subtract(mybirthday);
            Console.WriteLine(myAge.TotalDays);
            Console.ReadLine();

        }
    }
}