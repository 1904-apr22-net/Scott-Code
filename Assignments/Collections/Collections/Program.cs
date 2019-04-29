using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 123;
            //Random r = new Random();

            var num = 123;
            var r = new Random();

            //C# has " var:" for compile time type interface
            //the compiler guesses the type of the variable
            // use this when its obvious to reader what the type is 
            //but dont use car when it would make the code less self-documenting

            Arrays();
            
        }
        //remidnder: default member accesss is private
        static void Arrays()
        {
            //"int[]" is a typem it means array of int
            //this line declares an int[] variable and creates a size-5 array
            //filled with the default value of [0]
            int[] myNums = new int[5];
            //once an array has been created it has that size forever

            for (int i = 0; i < myNums.Length; i++)
            {
                myNums[i] = i * i;
                //print the value at the ith place
                Console.WriteLine(myNums[i]);
            }
            //the indexing in c# is zero based as in most languages

            foreach (var item in myNums)
            {
                Console.WriteLine(item);
                //we cant modify 
            }
            var names = new[] { "Nick", "fred", "bill" };

            int[][] twoD new int[3][];
            twoD[0] = new int[4];
            twoD[1] = new[] { 1, 6, 3, 6 };
            twoD[2] = new int[4];

            //access the first row and the second column
            var x = twoD[0][1];

            //thats one way 2d and 3d etc

            int[,] twoDMulti = new int[4, 5]; //4 by 5

        }
        static void Lists()
        {
            //first we had non generic list which is call ArrayList
            ArrayList numList = new ArrayList();
            // has a changeable length starting out at size 0
            //technically it is a list of "objects"
            numList.Add(2);
            numList.Add(5);
            numList.Add(8);

            numList.Remove(8);

            var num = (int)numList[0];
            //this is called "casting" it attempts to convert
            //whatever is to the right of the given type
            //the compiler will let me write this
            //but it might fail runtime

            //var twice = num + num;//not allowed becuase num is on object type

            // generic list
            //wilth generics, we can write code for many different types
            // and when we need the codem well decide at that time 

            var genericINtList = new List<int>();

            genericINtList.Add(3);

            var value = genericINtList[0];

            List<List<string>> twoDStringList = new List<List<string>>
            {
                new List<string>{"1","3","5"};
                new List<string>{"as","2","ggg"};
            //just like for arrays we have a initialization syntax for 
            
            }

            //list class can make many list instances each of which 
            // might have its own type that it requires 
        
        }
        
    }
}
