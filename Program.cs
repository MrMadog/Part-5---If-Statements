namespace Part_5___If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Simple Banking Machines");
            int num;
            Console.WriteLine("pick a number");
            num = Convert.ToInt32(Console.ReadLine()); 

            if(num > 5 && num <15)
            {
                Console.WriteLine("between");
            }
            else
            {
                Console.WriteLine("not between");
            }

        }
    }
}