using System.Collections.Generic;
using System.Linq;

namespace lab2.library
{
    public class Text
    {
        private List<MyString> lines = new List<MyString>();

        public void AddLine(MyString myString)
        {
            lines.Add(myString);
        }

        public void RemoveLine(MyString myString)
        {
            int index = -1;
            for (int i = 0; i < lines.Count; i++)
            {
                MyString line = lines[i];
                if (line.Value().SequenceEqual(myString.Value()))
                {
                    index = i;
                }
            }

            lines.RemoveAt(index);
        }

        public void Clear()
        {
            lines = new List<MyString>();
        }

        public int Length()
        {
            int count = 0;
            foreach (MyString line in lines)
            {
                count += line.Lenght();
            }

            return count;
        }

        public int CountLines(MyString myString)
        {
            int count = 0;
            foreach (MyString line in lines)
            {
                if (line.Value().SequenceEqual(myString.Value()))
                {
                    count++;
                }
            }

            return count;
        }

        public void ReplaceSymbol(char symbol, char newSymbol)
        {
            foreach (MyString line in lines)
            {
                line.ReplaceSymbol(symbol, newSymbol);
            }
        }

        public List<MyString> Value()
        {
            return lines;
        }

    }
}
