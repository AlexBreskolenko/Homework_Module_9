/*
1.Создайте свой тип исключения.

2.Сделайте массив из пяти различных видов исключений, включая собственный тип исключения. 
Реализуйте конструкцию TryCatchFinally, в которой будет итерация на каждый тип исключения (блок finally по желанию).

3.В блоке catch выведите в консольном сообщении текст исключения.
*/
//Создадим класс своих исключений
class MyExeption : Exception
{ 
    //Конструкторы класса
    public MyExeption() { }
    public MyExeption(string message) : base(message) { }
}



class Program
{
    static void Main(string[] args)
    {
        //Создадим массив из 5 исключений
        Exception[] arrException = new Exception[5] { new OverflowException(), new DivideByZeroException(), new FormatException(), new InvalidCastException(), new MyExeption("Ошибка ввода") };

        try
        {
            Console.Write("Введите первое число : ");
            int num_1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число : ");
            int num_2 = int.Parse(Console.ReadLine());

            int result = num_1 / num_2;
            Console.WriteLine($"Результат деления : {result}");
         
           
        }
        catch (Exception ex) 
        {
            for (int i = 0; i < arrException.Length; i++) 
            {
                if (ex.Message == arrException[i].Message)
                {
                    Console.WriteLine($"Произошло исключение - {arrException[i].Message}");
                }
            }
            
        }
    }
}