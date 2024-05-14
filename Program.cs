using System.ComponentModel;

namespace assignment_2._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleMath.Add (1, 2);
            SimpleMath.Add (2.3m, 3.71m, 4.251m);
            SimpleMath.Multiply (2, 2);
            SimpleMath.Multiply (2, 2, 2); 
            
            int add1 = SimpleMath.Add(1, 2);
            decimal add2 = SimpleMath.Add(2.3m, 3.71m, 4.25m);
            float multiply1 = SimpleMath.Multiply(2, 2);
            float multiply2 = SimpleMath.Multiply(2, 2, 2);

            Console.WriteLine (add1);
            Console.WriteLine (add2);
            Console.WriteLine (multiply1);
            Console.WriteLine (multiply2);

            

        }
    }

        static public class SimpleMath 
    {
        static public int Add(int num1, int num2) 
        { 
            return num1 + num2;
        }
        
        static public decimal Add(decimal num1, decimal num2, decimal num3) 
        {
            return num1 + num2 + num3;
        }
        
        static public float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }

        static public float Multiply(float num1, float num2, float num3) 
        {
            return num1 * num2 * num3;        
        }    


    }

}
