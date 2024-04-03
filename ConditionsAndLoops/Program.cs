namespace ConditionsAndLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write("数字を入力してくださ:");
            number= Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < number+1 ; i++) 
            {
                if ((i%3 ==0) && (i%5==0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    if (i%3 ==0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else
                    {
                            if(i%5 ==0)
                        {
                            Console.WriteLine("Buzz");
                        }
                        else
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }


        }
    }
}
