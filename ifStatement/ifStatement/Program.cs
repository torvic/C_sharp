namespace ifStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anyValue = 6;
            string message = "";

            if (anyValue == 7) 
            {
                message = "OMG, it's a miracle any value is 7";
            } else
            {
                message = "The value wasn't 7";
            }
            Console.WriteLine($"the answer is > {message}");
        }
    }
}