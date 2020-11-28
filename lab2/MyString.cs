using System;

namespace lab2.library
{
    public class MyString
    {
        private char[] symbols;

        public MyString(char[] symbols)
        {
            this.symbols = symbols;
        }

        public char[] Value()
        {
            return symbols;
        }

        public int Lenght()
        {
            return symbols.Length;
        }

        ~MyString()
        {
            Console.WriteLine($"The {ToString()} destructor is executing.");
            this.symbols = null;
        }

        public void ReplaceSymbol(char symbol, char newSymbol)
        {
            for (int i = 0; i < symbols.Length; i++)
            {
                if (symbols[i] == symbol)
                {
                    symbols[i] = newSymbol;
                }
            }
        }

    }
}
