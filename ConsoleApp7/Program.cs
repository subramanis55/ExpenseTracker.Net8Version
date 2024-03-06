using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        public int[,] Transport(int[,] Matrix)
        {
            int[,] Temp = new int[Matrix.GetLength(1), Matrix.GetLength(0)];
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    
                    
                    Temp[j, i] = Matrix[i,j];

                }
            }
            return Temp;
        }
        public void Reverse(int[,] Matrix)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                int j = 0, k = Matrix.GetLength(1) - 1;
                while (j<=k)
                {
                    int temp = Matrix[i,j];
                    Matrix[i, j] = Matrix[i, k];
                    Matrix[i, k] = temp;
                    j++;
                    k--;
                }
            }
        }
        public void Print(int[,] Matrix)
        {
            for(int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write(Matrix[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            string[] str=new string[1];
            Program obj = new Program();
            Console.WriteLine("Enter the Row:");
            int Row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the col:");
            int Col = Convert.ToInt32(Console.ReadLine());
           
            int[,] Matrix = new int[Row,Col];
            Console.WriteLine("Enter the Matrix:");
            for (int i = 0; i < Row; i++)
            {


                input:
                str = Console.ReadLine().Split(' ');
                try
                {
                    for (int j = 0; j < Col; j++)
                    {
                        if (!int.TryParse(str[j], out Matrix[i, j]))
                        {
                            Console.WriteLine("Invalid input Try again");
                            goto input;
                        }
                    }
               
                }
                catch(Exception e)
                {
                    Console.WriteLine("Invalid Format Try again");
                    goto input;

                }
            }
            while (true)
            {
                Console.WriteLine("Enter the Rotation degree:");
                int degree = Convert.ToInt32(Console.ReadLine());

                 bool clock = false;
                 if (degree > 0)
             clock = true;
                 Console.WriteLine("Before Rotation");
                 obj.Print(Matrix);
                if (clock)
                {
                    for (int i = 0; i < (degree / 90) % 4; i++)
                    {
                        Matrix = obj.Transport(Matrix);
                        obj.Reverse(Matrix);
                    }
                }
                else
                {
                    for (int i = 0; i < (Math.Abs(degree) / 90) % 4; i++)
                    {
                        obj.Reverse(Matrix);
                        Matrix = obj.Transport(Matrix);
                        
                    }
                }
                Console.WriteLine("After Rotation");
                obj.Print(Matrix);
            }
           
            
           
           
            Console.ReadKey();
            
        }
    }
}
