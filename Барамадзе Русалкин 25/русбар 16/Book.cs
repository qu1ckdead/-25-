using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR16
{
    public class Book
    {
        private string[] chapters;

        public Book(int maxChapters = 10)
        {
            chapters = new string[maxChapters];
        }

        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= chapters.Length)
                    throw new IndexOutOfRangeException();
                return chapters[index];
            }
            set
            {
                if (index < 0 || index >= chapters.Length)
                    throw new IndexOutOfRangeException();
                chapters[index] = value;
            }
        }

        public override string ToString()
        {
            var result = new System.Text.StringBuilder();
            for (int i = 0; i < chapters.Length; i++)
            {
                if (!string.IsNullOrEmpty(chapters[i]))
                {
                    result.AppendLine($"{i + 1}. {chapters[i]}");
                }
            }
            return result.ToString();
        }
    }
}
