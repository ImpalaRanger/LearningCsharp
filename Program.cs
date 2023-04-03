using System;

namespace HelloWorld {
    class StarsMain {
        public static void Main(string[] args) {
            Console.Write("Enter the number of rows: ");
            string userInput = Console.ReadLine();
            int numRows = int.Parse(userInput);

            for (int i = 0; i < numRows; i++) {

                for (int j = numRows - i; j > 0; j--) {
                    Console.Write(" ");
                }
                for (int k = 1; k <= (i*2) + 1; k++) {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }
        }
    }
}

