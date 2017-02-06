using System;

namespace ConsoleApplication{
    
    public class Program{

        public delegate bool Check(object value);

        public static bool IsNull(object value){
            return value == null;
        }

        public static void Main(string[] args){

            string genericObject = "2";

            Check myObjectIsNull = IsNull;

            if(myObjectIsNull(genericObject))
                Console.WriteLine("is null!");
        }
    }
}