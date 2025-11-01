using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static int ArrayOutputDouble(double[,] massiv)
        {
            int rows = massiv.GetUpperBound(0) + 1;
            int columns = massiv.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{massiv[i, j]} ");
                }
                Console.WriteLine();
            }
            return 1;
        }

        static double[,] CreatingMatrix(bool tue = true)
        {
            double[,] matrix = new double[3, 3];
            int rows = 3;
            int columns = 3;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"matrix[{i+1},{j+1}]");
                    matrix[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            return matrix;
        }

        static double[,] MatrixMultiplicationOnNumber(double[,] matrix, double number)
        {
            int rows = 3;
            int columns = 3;
            double[,] newMatrix = new double[rows, columns]; 
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    newMatrix[i, j] = matrix[i, j] * number;
                }
            }
            return newMatrix;
        }

        public static string Encrypt(string text)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string result = "";

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                bool isUpper = char.IsUpper(c); 
                c = char.ToLower(c); 

                int index = alphabet.IndexOf(c);
                if (index != -1) 
                {
                    int newIndex = (index + 3) % alphabet.Length;
                    char shiftedChar = alphabet[newIndex];

                    if (isUpper)
                    {
                        result += char.ToUpper(shiftedChar);
                    }
                    else
                    {
                        result += shiftedChar;
                    }
                }
                else 
                {
                    result += c;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            ////    1 задание:
            //double[] a = new double[5];
            //double[,] b = new double[3, 4];

            //Console.WriteLine("Заполните массив a: ");
            //for (int i = 0; i < a.Length; i++)
            //{
            //    a[i] = Convert.ToDouble(Console.ReadLine());
            //}

            //int rows = b.GetUpperBound(0) + 1;
            //int columns = b.Length / rows;
            //Random rand = new Random();
            //for (int i = 0; i < rows; i++)
            //    for (int j = 0; j < columns; j++)
            //        b[i, j] = rand.NextDouble();

            //Console.WriteLine("Массив 'a': ");
            //foreach (double number in a) Console.Write($" {number}");

            //Console.WriteLine($"\n");

            //ArrayOutputDouble(b);

            //int numberAssistOne = 0;
            //double[,] massivThird = new double[3, 6];
            //int rowsTwo = massivThird.GetUpperBound(0) + 1; ;
            //int colunmsTwo = massivThird.Length / rowsTwo;
            //int numberAssistTwo = 0;
            //foreach (double k in b)
            //{
            //    massivThird[numberAssistTwo, numberAssistOne] = k;
            //    if (numberAssistOne < 5) numberAssistOne++;
            //    else
            //    {
            //        numberAssistOne -= 5;
            //        numberAssistTwo += 1;
            //    }
            //}

            //int numberAssistThree = 0;
            //foreach (double j in a)
            //{
            //    massivThird[2, numberAssistThree] = j;
            //    numberAssistThree++;
            //}

            //Console.WriteLine(" ");

            //ArrayOutputDouble(massivThird);

            //double maxNumber = 0;
            //double minNumber = massivThird[1, 1];
            //for (int i = 0; i < rowsTwo; i++)
            //{
            //    for (int j = 0; j < colunmsTwo; j++)
            //    {
            //        if (i == 2 && j == 5)
            //        {
            //            maxNumber += 0;
            //        }
            //        else if (massivThird[i, j] > maxNumber)
            //        {
            //            maxNumber = massivThird[i, j];
            //        }
            //        else if (massivThird[i, j] < minNumber)
            //        {
            //            minNumber = massivThird[i, j];
            //        }
            //    }
            //}

            //Console.WriteLine($"Общий максимальный элемент: {maxNumber}; Общий минимальный элемент: {minNumber} ");

            //double sumAAndB = 0;
            //double productsAAndB = 1;
            //for (int i = 0; i < rowsTwo; i++)
            //{
            //    for (int j = 0; j < colunmsTwo; j++)
            //    {
            //        if (i == 2 && j == 5)
            //        {
            //            maxNumber += 0;
            //        }
            //        else
            //        {
            //            sumAAndB += massivThird[i, j];
            //            productsAAndB *= massivThird[i, j];
            //        }
            //    }
            //}
            //Console.WriteLine($"Сумма всех элементов: {sumAAndB}; Произведение всех элементов: {productsAAndB}");

            //sumAAndB = 0;
            //foreach (double i in a)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sumAAndB += i;
            //    }
            //}

            //productsAAndB = 0;
            //for (int i = 0; i < columns; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        for (int j = 0; j < 2; j++)
            //        {
            //            productsAAndB += massivThird[i, j];
            //        }
            //    }
            //}


            //Console.WriteLine($"Сумма четных чисел в массиве 'a':{sumAAndB}; Сумма всех нечетных столбцов в массиве 'b':{productsAAndB}");


            // Задание 2:
            //double[,] massiv = new double[5, 5];

            //int rows = massiv.GetUpperBound(0) + 1;
            //int columns = massiv.Length / rows;
            //Random rand = new Random();
            //for (int i = 0; i < rows; i++)
            //    for (int j = 0; j < columns; j++)
            //        massiv[i, j] = rand.Next(-100, 100);

            //ArrayOutputDouble(massiv);

            //int sumMassiv = 0;
            //foreach (int i in massiv) sumMassiv += i;

            //double minNumber = massiv[0, 0];
            //double maxNumber = massiv[0, 0];
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < columns; j++)
            //    {
            //        if (maxNumber < massiv[i, j])
            //        {
            //            maxNumber = massiv[i, j];
            //            Console.WriteLine(maxNumber);
            //        }
            //        else if (minNumber > massiv[i, j])
            //        {
            //            minNumber = massiv[i, j];
            //            Console.WriteLine(minNumber);
            //        }
            //        else maxNumber += 0;
            //    }
            //}

            //Console.WriteLine(sumMassiv - maxNumber - minNumber);


            // задание 3:
            Console.WriteLine(Encrypt(Console.ReadLine()));

            //задание 4:
            //double[,] firstMatrix = CreatingMatrix();
            //double[,] secondMatrix = CreatingMatrix();

            //Console.WriteLine("First matrix: ");
            //ArrayOutputDouble(firstMatrix);
            //Console.WriteLine("Second matrix: ");
            //ArrayOutputDouble(secondMatrix);

            //Console.Write("The number by which you want to multiply the matrices: ");
            //double number = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("First manrix: ");
            //double[,] firstMultiplicationMatrix = MatrixMultiplicationOnNumber(firstMatrix, number);
            //ArrayOutputDouble(firstMultiplicationMatrix);
            //Console.WriteLine("Second matrix: ");
            //double[,] secondMultiplicationMatrix = MatrixMultiplicationOnNumber(secondMatrix, number);
            //ArrayOutputDouble(secondMultiplicationMatrix);

            //Console.WriteLine(" ");

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0;j < 3; j++) 
            //    {
            //        double temp = firstMatrix[i, j];
            //        firstMatrix[i,j] = firstMatrix[i,j] + secondMatrix[i,j];
            //        secondMatrix[i,j] = secondMatrix[i,j] * temp;

            //    }
            //}
            //Console.WriteLine("Mathematical product of two matrices: ");
            //ArrayOutputDouble(secondMatrix);
            //Console.WriteLine("Addition of two matrices: ");
            //ArrayOutputDouble(firstMatrix);



            ////задание 5:
            //string example = Console.ReadLine();
            //example.Trim();

            //if (example.Contains('+') == true || example.Contains('-') == true)
            //{
            //    foreach (char i in example)
            //    {
            //        if (i == '+')
            //        {
            //            int numberAssist = example.IndexOf('+');
            //            string numberOne = example.Substring(0, numberAssist);
            //            int numberAssistTwo = example.Length - numberAssist - 1;
            //            string numberTwo = example.Substring(numberAssist + 1, numberAssistTwo);
            //            Console.WriteLine(Convert.ToInt32(numberOne) + Convert.ToInt32(numberTwo));
            //        }
            //        else if (i == '-')
            //        {
            //            int numberAssist = example.IndexOf('-');
            //            string numberOne = example.Substring(0, numberAssist);
            //            int numberAssistTwo = example.Length - numberAssist - 1;
            //            string numberTwo = example.Substring(numberAssist + 1, numberAssistTwo);
            //            Console.WriteLine(Convert.ToInt32(numberOne) - Convert.ToInt32(numberTwo));
            //        }
            //        else
            //        {
            //            continue;
            //        }
            //    }
            //}


            //6 задание:
            //string sentence = Console.ReadLine();
            //string sentenceAddSpaceAtTheBeginning = " " + sentence;
            //string[] sentenceTwo = sentenceAddSpaceAtTheBeginning.Split('.', '!', '?');
            //foreach (string s in sentenceTwo)
            //{
            //    foreach (char i in s)
            //    {
            //        if (i == s[1])
            //        {
            //            string sTwo = s.Replace(s[1], char.ToUpper(s[1]));
            //            Console.Write(sTwo);
            //        }
            //        else { continue; }
            //    }
            //}

            //7 задание:
            //string text = Console.ReadLine();
            //string[] dividedText = text.Split(' ');
            //string unacceptableWord = Console.ReadLine();
            //int scor = 0;
            //int indexDiv = 0;

            //foreach (string div in dividedText)
            //{
            //    if (div == unacceptableWord)
            //    {
            //        indexDiv = Array.IndexOf(dividedText, unacceptableWord);
            //        Console.WriteLine(indexDiv);
            //        Console.WriteLine(div);
            //        dividedText[indexDiv] = "*";
            //        scor++;
            //    }
            //    else continue;
            //}
            //foreach (string div in dividedText)
            //{
            //    Console.Write(" " + div);
            //}
            //Console.WriteLine(" ");
            //Console.WriteLine($"Найдено запрещённых слов: {scor}");

        }
    }
}