namespace Практическая_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            string action; // Переменные

            Console.WriteLine("Введите первое число");
            a = double.Parse(Console.ReadLine()); //Ввод первого числа

            Console.WriteLine("Введите второе число");
            b = double.Parse(Console.ReadLine()); //Ввод второго числа

            Console.WriteLine("Выбор операции: (+) (-) (*) (/) (^) (Корень из числа) (1% из числа) (Факториал числа)"); 
            action = Console.ReadLine(); //Ввод дествия

            switch (action) //При введении неизвестного выводит default
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;

                case "-":
                    Console.WriteLine(a - b);
                    break;

                case "*":
                    Console.WriteLine(a * b);
                    break;

                case "/":
                    double resultat = a / Math.Pow(a, b);
                    Console.WriteLine(resultat);
                        break;

                case "%":
                    Console.WriteLine(a / 100);
                    break;

                case "Корень":
                    double resulta = a / Math.Sqrt(a);
                    Console.WriteLine(resulta);
                    break;


                case "Факториал числа":
                    int resultate = 1;
                    for (int i = (int)a; i > 1; i--) {
                        resultate *= i;
                    }
                    
                break;




                default:
                    Console.WriteLine("Ошибка! Введите дествия из предложенных");
                    break;

            }
        }
    }
}