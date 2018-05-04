using System;
using System.Runtime.InteropServices.ComTypes;

namespace Isen.Cs.Library.Lessons
{
    public class C_Arrays
    {
        public static void StaticRunner()
        {
            new C_Arrays().RunArrays();
        }

        private void RunArrays()
        {
            //tableau primitifs de 1 dimension
            //initialisation 
            int[] arrayOfIntegers = new int[3];
            //affectation
            arrayOfIntegers[0] = 22;
            arrayOfIntegers[1] = 23;
            arrayOfIntegers[2] = 24;
            Console.Write("[\t");
            foreach (var integer in arrayOfIntegers) Console.Write($"{integer}\t");
            Console.WriteLine("]");
            //syntaxe littéral 
            string[] literalArray = new string[] {"Bonjour", "tout", "le", "monde"};
            Console.Write("[\t");
            foreach (var integer in literalArray) Console.Write($"{integer}\t");
            Console.WriteLine("]");

            //Tableau à 2 dimensions 
            string[,] array2D = new string[,]
            
            {
                {"A1", "B1", "C1"},
                {"A2", "B2", "C2"}, 
                {"A3", "B3", "C3"}, 
                {"A4", "B4", "C4"}
            };
            for (var x = 0; x < array2D.GetLength(0); x++)
            {
                Console.Write($"[\t");
                for (var y = 0;  y < array2D.GetLength(1); y++)
                {
                    Console.Write($"{array2D[x, y]}\t");
                }
                Console.WriteLine($"]");
            }
            //Tableaux imbriqués
            string[][] nestedArrays = new string[][]
            {
                new string[] {"A1", "B1", "C1"},
                new string[] {"A2", "B2"}
            };
            for (var x = 0; x < nestedArrays.Length; x++)
            {
                Console.Write("[\t");
                for (var y = 0; y < nestedArrays[x].Length; y++)
                {
                    Console.Write($"{nestedArrays[x][y]}\t");
                }
                Console.WriteLine("]");
            }

        }
        
        #region RunValuesAndRefs
        
        private void RunArraysRefs()
        {
            //Types Valeurs (ValueTypes) et Types références
            int four = 4;
            Console.WriteLine($"{nameof(four)} = {four} (expected : 4)");
            AddOneByValue(four);
            Console.WriteLine($"{nameof(four)} = {four} (expected : 4)");

            four = AddOneAsPureMethod(four);
            Console.WriteLine($"{nameof(four)} = {four} (expected : 5)");

            AddOneByRef(ref four);
            Console.WriteLine($"{nameof(four)} = {four} (expected : 6)");
            
            //String : passage par valeur ou ref ? 
            var lowerString = "hello";
            Console.WriteLine($"{nameof(lowerString)} = {lowerString} (expected hello)");
            UpperCaseMyString( lowerString);
            Console.WriteLine($"{nameof(lowerString)} = {lowerString} (excepted : hello)");
            UpperCaseMyStringByRef(ref lowerString);
            Console.WriteLine($"{nameof(lowerString)} = {lowerString} (excepted : HELLO)");
        }

        public void UpperCaseMyString(string input)
        {
            input = input.ToUpper();
        }
        public void UpperCaseMyStringByRef(ref string input)
        {
            input = input.ToUpper();
        }

        //Passage par copie. a e ressort jamais de la méthode et n'est pas modifié en dehors du scope de la méthode 
        public void AddOneByValue(int a)
        {
             a++;
        }

        //C#6 : Expression body 
        public int AddOneAsPureMethod(int a)
        {
            return ++a;
        }
        
        public void AddOneByRef(ref int a)
        {
             ++a;
        }
        
        //Parser vers result, qui n'est pas init 
        // Donc c'est du out et pas du ref
        public bool TryParseInt(string input, out int result)
        {
            try
            {
                result = int.Parse(input);
                return true;
            }
            catch
            {
                result = int.MinValue;
                return false;
            }
        }
        #endregion
        
    }
}