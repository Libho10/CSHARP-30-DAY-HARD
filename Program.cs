using System; 
using System.Collections.Generic;
using BasicClasses; 

 namespace BasicClasses 
 {
     class Forest
    {
        public string name; 
        public string biome; 
        public int trees; 
        public int age; 

        public int Grow ()
        {
            trees += 30; 
            age ++; 
            return trees; 
        }

    }
    class Program 
    {
        static void Main(string [] args)
        {
            Forest f = new Forest(); 
            f.name = "Willow"; 
            f.biome = "idk";
            f.trees = 2; 
            f.age= 5; 

            Console.WriteLine(f.name);
            Console.WriteLine(f.trees);
        }
    }
 }