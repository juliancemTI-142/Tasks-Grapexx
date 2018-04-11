using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class StringPractice
    {
        public string str;
        public StringPractice(string inputString )
        {
            str = inputString;
        }
        // Extract words with numbers from a given string array
        public string[] ExtractWordsWithNumbers(string givenString, out int count)
        {   var delimiter = ' ';
            count = 0;
            var splitString = givenString.Split(delimiter);
            var arrayWithNumbers = new string[splitString.Length];
            for (int i = 0; i < splitString.Length; i++)
            {   var str = splitString[i];
                if (str.Contains('0') || str.Contains('1') ||
                    str.Contains('2') || str.Contains('3') ||
                    str.Contains('4') || str.Contains('5') ||
                    str.Contains('6') || str.Contains('7') ||
                    str.Contains('8') || str.Contains('9'))
                {
                 arrayWithNumbers[i] = str;
                 i++;
                 count++;
                }
            }
            return arrayWithNumbers;
        }
        // Reverse a char array
        public char[] ReverseNumber(char[] reverse)
        {   
            for (int i = 0; i <reverse.Length / 2; i++)
            {   char ch = reverse[i];
                reverse[i] = reverse[reverse.Length - 1 - i];
                reverse[reverse.Length - 1 - i] = ch;
            }
        return reverse;
        }
        // return only numbers from a string
        public char[] ReturnOnlyNumbers(string StringWithNumber)
        {   var convertNumber  = StringWithNumber.ToCharArray();
            char[] onlyNumbers = new char[convertNumber.Length];
            int j = 0;
            for (int i = 0; i < convertNumber.Length; i++)
            { if (Char.IsDigit(convertNumber[i]))
                {
                    onlyNumbers[j] = convertNumber[i];
                    j++;
                }
            }
        return onlyNumbers;
        }
        // Convert to int a char
        public int ConvertToInt(char[] CharToConvert)
        {
            string convertedChar = new string(CharToConvert);
            int number = Int32.Parse(convertedChar);
            return number;
        }
        // extract numbers from a string
        public void ExtractNumbers(string inputString)
        {   int dimension;
            var wordsWithNumbers = ExtractWordsWithNumbers(inputString, out dimension);
            var numbers = new int[dimension];
            for (int i = 0; i<wordsWithNumbers.Length;i++)
            {
                var number  = ReturnOnlyNumbers(wordsWithNumbers[i]);
                var reverseNumber = ReverseNumber(number);
                numbers[i] = ConvertToInt(reverseNumber);
            }
            ShowArray(numbers);
        }

        public void ShowArray(int[] arrayOfInt)
        {
            foreach (int i in arrayOfInt)
            Console.WriteLine(i);
        }





    


        // copy elements of an 





        /*      string s = "12 12 12dfs45 asdzfdd1 v584551 ";

        //    "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been " +
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

    
    for (int j = 0; j < split.Length; j++)
    {     

            if (split[j].Contains('0') || split[j].Contains('1') ||
                split[j].Contains('2') || split[j].Contains('3') ||
                split[j].Contains('4') || split[j].Contains('5') ||
                split[j].Contains('6') || split[j].Contains('7') ||
                split[j].Contains('8') || split[j].Contains('9'))

            { 
                arr[i] = split[j];
                i++;
                count++;
            }

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
      
        
        
        
        
        
        
        
        
        
        
        
        //Task 10 String
        /* Console.WriteLine("Enter the string please:");
         int count1 = 0;
         int h = 0;
         char[] input = Console.ReadLine().ToCharArray(); // convertesc intrun array de char
         char[] input2 = new char[input.Length];

         //inscriem doar literele in alt array
         for (int w = 0; w < input.Length; w++)
         {
             if (Char.IsLetter(input[w]))
             {
                 count1++;
                 input2[h] = input[w];
                 h++;
             };
         }
         // inscriem din nou literele in alt array
         char[] input3 = new char[count1];
         for (int y = 0; y < count1; y++)
         {
             input3[y] = input2[y];
         }



         // inscriem in arr1 de cite ori se repeta fiecare caracter
         int[] arr1 = new int[input3.Length - 1];
         int count2;
         for (int i = 0; i < input3.Length - 1; i++)
         {
             count2 = 1;
             for (int j = 0; j < input3.Length - 1 - i; j++)
             {
                 if (input3[i] == input3[j + i + 1])
                 {
                     count2++;

                 }
             }
             arr1[i] = count2;
         }


         // gasim maximul in array
         int max = arr1[0];
         for (int b = 0; b < arr1.Length - 1; b++)
         {
             if (max < arr1[b + 1])
             { max = arr1[b + 1]; }
         }

         //aflam dimensiunea arrayului de char unde vom stoca elementele
         int count3 = 0;
         for (int u = 0; u < arr1.Length; u++)
         {
             if (max == arr1[u])
             { count3++; }
         }

         char[] arr4 = new char[count3];
         int maxnum = max;
         int k = 0;
         for (int g = 0; g < arr1.Length; g++)
         {

             if (maxnum == arr1[g])
             {
                 arr4[k] = input3[g];
                 k++;
             }
         }

         if (maxnum == 1)
             Console.WriteLine("All the characters are different and they appear just 1 ");
         else
         {
             if (arr4.Length == 1)
             {
                 Console.WriteLine("Highest frequency character is {0} and it appears {1} times", arr4[0], maxnum);
             }
             else
             {
                 Console.WriteLine("Highest frequency characters are:");
                 for (int l = 0; l < arr4.Length; l++)
                 { Console.WriteLine(arr4[l]); }

                 Console.Write("and they appear {0} times ", maxnum);
             }
         }*/
        // Task 41
        /*Console.WriteLine("Enter the size of string array:");
        int a = int.Parse(Console.ReadLine());

        string[] arr = new string[a];
        int j = 0;
        for (int i = 1; i <= a; i++)
        {
            Console.Write("Enter element  " + i + " -  ");
            arr[j] = Console.ReadLine();
            j++;
        }
        for (int h = 0; h < arr.Length; h++)
        {

            {   char[] arr1 = arr[h].ToCharArray();
                if (arr1[arr1.Length - 1] == '.')
                {
                    string s = new string(arr1);
                    Console.WriteLine(s + " end in a period: True ");
                }
                else
                { Console.WriteLine(arr[h] + " end in a period: False "); }
            }
        }*/

    }
}
