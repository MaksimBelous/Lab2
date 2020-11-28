using System;
using lab2.library;

namespace lab2.application
{
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();
            MyString myString0 = new MyString(new char[] { 'f', 'i', 'r', 's', 't' });
            MyString myString1 = new MyString(new char[] { 's', 'e', 'c', 'o', 'n', 'd' });
            MyString myString2 = new MyString(new char[] { 'f', 'i', 'r', 's', 't' });
            MyString myString3 = new MyString(new char[] { 't', 'e', 'x', 't' });
            text.AddLine(myString0);
            text.AddLine(myString1);
            text.AddLine(myString2);
            text.AddLine(myString3);

            PrintText(text);

            MyString lineToFind = new MyString(new char[] { 'f', 'i', 'r', 's', 't' });
            int count = text.CountLines(lineToFind);

            Console.WriteLine("Line '" + new string(lineToFind.Value()) + "' found: " + count);

            text.RemoveLine(lineToFind);

            Console.WriteLine("Text length: " + text.Length());

            text.ReplaceSymbol('s', '@');
            PrintText(text);
        }

        private static void PrintText(Text text)
        {
            foreach (MyString line in text.Value())
            {
                Console.WriteLine(line.Value());
            }
        }
    }
}
