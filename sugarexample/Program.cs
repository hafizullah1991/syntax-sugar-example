namespace sugarexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int answer = 4;
            string response;
            if (answer < 9)
            {
                response = answer + " is less than nine";
                Console.WriteLine(response);
            }
            else
            {
                response = answer + " is greater than or equal to nine";
                Console.WriteLine(response);

            }


            string assign= (answer <9) ? "is less than nine" : "is greater than or equal to nine";
            Console.WriteLine(assign);
        }
    }
}
