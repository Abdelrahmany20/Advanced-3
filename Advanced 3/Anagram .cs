using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_3
{
    internal class Anagram : IComparable<Anagram>
    {



        public string Word { get; set; }

        public Anagram (string word)
        {
            Word = word;
        }



        public int CompareTo(Anagram? other)
        {
            return Word.CompareTo(other.Word);    
        }
    }
}
