public class Сalculator {
    public static void Main(){
    
        Console.WriteLine("Введите первое число:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите оператор:");
        char oper = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        double b = Convert.ToDouble(Console.ReadLine());

  Сalculator num = new Сalculator();
        if (oper == '+'){
          Console.WriteLine("Равняется:" + (a + b));
        }
 
         if (oper == '-'){
        Console.WriteLine("Равняется:" + (a - b));
        }
 
          if (oper == '*')
        {
        Console.WriteLine("Равняется:" + (a * b));
        }
 
         if (oper == '/')
        {
        Console.WriteLine("Равняется:" + (a / b));
        }
      }
    }