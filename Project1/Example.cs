using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    //static void Main()
    //{ }  
    /*    string s = "12 12 12dfs45 asdzfdd1 v584551 ";
            
            //"Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been " +
            //    "the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley  "
            //    + "of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also " +
            //    "the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s " +
            //    "with the release of Letraset sheets containing Lorem Ipsum passages, " +
            //    "and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";

       

        char delimiter = ' ';
        string[] split = s.Split(delimiter);
        string[] arr = new string[split.Length];
       
        int i = 0;
        int count = 0;
        //var resultList = split.ToList();
        //resultList.Sort();
        //resultList.ForEach(Console.WriteLine);
        //Console.WriteLine();

        for (int j = 0; j < split.Length; j++)
        {     
            
                if (split[j].Contains('0') || split[j].Contains('1') ||
                    split[j].Contains('2') || split[j].Contains('3') ||
                    split[j].Contains('4') || split[j].Contains('5') ||
                    split[j].Contains('6') || split[j].Contains('7') ||
                    split[j].Contains('8') || split[j].Contains('9'))

                {   arr[i] = split[j];
                    i++;
                    count++;
                }
                //}
            }
        
        
        int[] arr1 = new int[count];
        
        for (int x = 0; x < count; x++)
        {
            if (Int32.TryParse(arr[x], out arr1[x]))


            {
                //reverse
                char[] arr5 = arr[x].ToCharArray();
                for (int h = 0; h < arr5.Length / 2; h++)
                {
                    char ch = arr5[h];
                    arr5[h] = arr5[arr5.Length - 1 - h];
                    arr5[arr5.Length - 1 - h] = ch;
                }
                string s2 = new string(arr5);
                arr1[x] = Int32.Parse(s2);

            }
            else
            {
                char[] arr3 = arr[x].ToCharArray();
                //reverse
                for (int h = 0; h < arr3.Length / 2; h++)
                {
                    char ch = arr3[h];
                    arr3[h] = arr3[arr3.Length - 1 - h];
                    arr3[arr3.Length - 1 - h] = ch;
                }
                char[] arr4 = new char[arr3.Length];
                int v = 0;
                for (int a = 0; a < arr3.Length; a++)
                {
                    if (Char.IsDigit(arr3[a]))
                    {
                        arr4[v] = arr3[a];
                        v++;
                    }

                }

                string s1 = new string(arr4);
                arr1[x] = Int32.Parse(s1);

            }
        }
        for(int q = 0; q<arr1.Length; q++)
            { Console.WriteLine(arr1[q]); }
        }
    }*/



    static void Main()
    {
        // 1) Task 33  
        /*Console.WriteLine("Enter a positive number :");
        string input = Console.ReadLine();
        int number = Convert.ToInt32(input);
        if (number>0)
        {if (number % 3 == 0 || number % 7 == 0)
            Console.WriteLine("True");
            
         else {Console.WriteLine("False");}}
         
         else {Console.WriteLine("Number is negative");} */

        // 2)Task 32
        /*Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        Char delimiter = ' ';
        string[] input2 = input.Split(delimiter);
        if (input2.Length < 4)
        {
            Console.WriteLine(input);
        }
        else
        {
            char[] ch = input.ToCharArray();
            int dimension = ch.Length;
            for (int j=0; j<4;j++) 
                {
                for (int i = dimension - 4; i < dimension; i++)
                { Console.Write(ch[i]); }
        }
            Console.WriteLine();

        }*/
        // 3)Task 40
        /*Console.WriteLine("Enter 2 numbers :");
        int[] array = new int[2];
        for (int i = 0; i < 2; i++)
        {
           array[i] = int.Parse(Console.ReadLine());
        }

        if (array[0] == array[1])
        { Console.WriteLine("0"); }
        else

        if (20 - array[0] == array[1] - 20)
            Console.WriteLine("Numbers are at the same distance from 20");
        else if (Math.Abs(20 - array[0]) < Math.Abs(20 - array[1]))
            Console.WriteLine(array[0]);
        else Console.WriteLine(array[1]);*/

        // 4) Task 2 

        /* Console.WriteLine("Enter a number:");
         int a = int.Parse(Console.ReadLine());
         Console.WriteLine("Enter the desired width");
         int b = int.Parse(Console.ReadLine());
         int[] arr = new int[b];
         for (int x = 0; x < b; x++)
         {
             arr[x] = a;
         }

             for (int z=b; z>0; z--)
             {
                 for (int w = 0; w < z; w++)
                 { Console.Write(arr[w]); }
                 Console.WriteLine();
             }
             */
        // 5) Task 1
        /* Console.WriteLine("Enter 3 letters please:");

         string[] input = new string[3];
         for (int i = 0; i < input.Length; i++)
         {
             Console.Write("Enter letter:");
             input[i]= Console.ReadLine();
         }

         for (int j = 2 ; j > -1; j--)
          { Console.Write("{0}  ", input[j]); }
         Console.WriteLine();*/
        // Task 5
        /*Console.WriteLine("Enter the number of elements to be stored in array:");
        int a = int.Parse(Console.ReadLine());
        int[] arr = new int[a];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter element  " + i + " -  ");
            arr[i] =int.Parse(Console.ReadLine());
        }

        int count=0;
        int duplicate = 0;
        for (int i=0; i<a; i++)
        {
            count = 0;
            for (int j = 0; j<a; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                      
                }
                
            }
            if (count == 2)
                duplicate++;

        }
        int dup = duplicate / 2;
        if (dup == 0)
            Console.WriteLine("There are no duplicate numbers in array");
        else
            Console.WriteLine("Number of duplicate numbers in array is " + dup); */

        //Task 13, 14, 15 Arrays
        /*Console.WriteLine("Enter the size of array:");
        int a = int.Parse(Console.ReadLine());
        int x = a + 1;
        int[] arr = new int[x];
        int j = 0;
        for (int i = 1; i < x; i++)
        {
            Console.Write("Enter element  " + i + " -  ");
            arr[j] = int.Parse(Console.ReadLine());
            j++;
        }

        int stock = 0;
        Console.WriteLine("Input the element to be inserted:");
        arr[arr.Length - 1] = int.Parse(Console.ReadLine());
        Console.WriteLine("Input the position, where the element to be inserted:");
        int z = int.Parse(Console.ReadLine());
        if (z <= a && z >= 1)
        {

            for (int i = 1; i <= arr.Length - z; i++)
            {
                stock = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = arr[arr.Length - i];
                arr[arr.Length - i] = stock;
            }

            Console.WriteLine("New array:");
            for (int w = 0; w < arr.Length; w++)
            {
                Console.Write(arr[w]);
                Console.WriteLine();
            }
        }
        else goto Finish;
           

        Console.WriteLine();
        for (int r = 0; r < arr.Length; r++)
        {
            int u = 0;
            int min = arr[r];
            int min2 = min;
            //if (r != arr.Length - 1)
            {
                for (int k = r + 1; k < arr.Length; k++)
                {
                    if (min > arr[k])
                    {
                        min = arr[k];
                        u = k;
                    }
                }
                if (min == min2)
                {
                    arr[r] = min;
                }
                else
                {
                    int store = arr[r];
                    arr[r] = arr[u];
                    arr[u] = store;
                }
            }
        }
        Console.WriteLine("Sorted array:");
        for (int ww = 0; ww < arr.Length; ww++)
        {
            Console.Write(arr[ww]);
            Console.WriteLine();
        }
        Console.WriteLine("Ok, now input the position, where the element to be deleted:");
        int y = int.Parse(Console.ReadLine());
        if (y <= x && y >= 1)
        {
            for (int g = y; g <= arr.Length - y; g++)
            {
                int stock1 = arr[g - 1];
                arr[g - 1] = arr[g];
                arr[g] = stock1;

            }
            Console.WriteLine("Result array:");
            for (int ww = 0; ww < arr.Length - 1; ww++)
            {
                Console.Write(arr[ww]);
                Console.WriteLine();
            }
        }
        else goto Finish; 
        
        Finish:
        Console.WriteLine("Position is not in the limits of array");*/
        //Task 58 
        /*Console.WriteLine("Enter the size of array:");
        int a = int.Parse(Console.ReadLine());
        
        int[] arr = new int[a];
        int j = 0;
        for (int i = 1; i <= a; i++)
        {
            Console.Write("Enter element  " + i + " -  ");
            arr[j] = int.Parse(Console.ReadLine());
            j++;
        }
        int max = arr[0];
        for(int b=0; b<arr.Length-1;b++)
        {
            if (max < arr[b + 1])
            { max = arr[b + 1]; }
        }

        int elements = max - a;
        Console.WriteLine("Number of elements to complete the range is " + elements);*/

       //Task 61    Write a C# program to sort the integers in ascending order without moving the number -5.
       Console.WriteLine("Enter the size of array:");
        int a = int.Parse(Console.ReadLine());
        int count = 0;
        int[] arr = new int[a];
        int j = 0;
        for (int i = 1; i <= a; i++)
        {
            Console.Write("Enter element  " + i + " -  ");
            arr[j] = int.Parse(Console.ReadLine());
            j++;
        }
        for(int r =0; r<arr.Length; r++)
        {
            if (arr[r] == 5)
                count++;
        }
        int[] arr1 = new int[a - count];
        int x = 0;
        for (int w = 0; w < arr.Length; w++)
        {
            if (arr[w] != 5)
            { arr1[x] = arr[w];
                x++;
            }
        }

        for (int r = 0; r < arr1.Length; r++)
        {
            int u = 0;
            int min = arr1[r];
            int min2 = min;
            //if (r != arr.Length - 1)
            
                for (int k = r + 1; k < arr1.Length; k++)
                {
                    if (min > arr1[k])
                    {
                        min = arr1[k];
                        u = k;
                    }
                }
                if (min == min2)
                {
                    arr1[r] = min;
                }
                else
                {
                    int store = arr1[r];
                    arr1[r] = arr1[u];
                    arr1[u] = store;
                }
            
        }
        int f = 0;
        
        for (int w = 0; w < arr.Length; w++)
        {
            if (arr[w] != 5)
            { arr[w] = arr1[f];
                f++;
            }
        }
        Console.WriteLine("Sorted array:");
        for (int ww = 0; ww < arr.Length; ww++)
        {
            Console.Write(arr[ww]);
            Console.WriteLine();
        }






    }






    }

        







