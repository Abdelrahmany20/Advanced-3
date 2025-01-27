using System.Collections;
using System.ComponentModel;

namespace Advanced_3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Part 1

            //Write a Report about all Collections Given in the Session and Compare[Structure, Time Complexity,
            //and Business Case With Implemented Examples in Separates Project at the Same Solution]




            #endregion



            #region Part 2



            #region Q01
            //int[] numbers = { 1, 2, 3, 4, 4, 4, 5, 6, 7, 7, 8, 8, 9, 9, 9 };


            //Hashtable count = new Hashtable();

            //foreach (int nums in numbers)
            //{
            //    if (count.ContainsKey(nums))
            //        count[nums] = (int)count[nums] + 1;

            //    else
            //        count[nums] = 1;
            //}


            //foreach (DictionaryEntry item in count)
            //{
            //    Console.WriteLine($"key : {item.Key} , value : {item.Value}");



            //}


            #endregion


            #region  Q02


            //int[] numbers = { 1, 2, 3, 4, 4, 4, 5, 6, 7, 7, 8, 8, 9, 9, 9 };


            //Hashtable count = new Hashtable();

            //foreach (int nums in numbers)
            //{
            //if (count.ContainsKey(nums))
            //count[nums] = (int)count[nums] + 1;

            //else
            //count[nums] = 1;
            //}


            //int maxvalue=int.MinValue;
            //int maxkey=default;

            //foreach (DictionaryEntry item in count)
            //{
            //if ((int)item.Value > maxvalue)
            //{
            //maxvalue = (int)item.Value;
            //maxkey = (int)item.Key;
            //}
            //}


            //foreach (DictionaryEntry item in count)
            //{
            //Console.WriteLine($"key : {item.Key} , value : {item.Value}");



            //}

            //Console.WriteLine($"max key: {maxkey} , max value: {maxvalue}");

            #endregion

            #region Q03

            //Hashtable fruits = new Hashtable();
            //fruits.Add("key1", "apple");
            //fruits.Add("key2", "banana");
            //fruits.Add("key3", "apple");


            //Console.Write("Enter the target: ");
            //string targetValue = Console.ReadLine();


            //bool status = false;

            //foreach (DictionaryEntry entry in fruits)
            //{
            //if (entry.Value.Equals(targetValue))
            //{
            //Console.WriteLine(entry.Key);
            //status = true;
            //}
            //}


            //if (!status)
            //Console.WriteLine("Key not found");

            #endregion


            #region Q04

            //string[] chars = { "F", "B", "E", "D", "A", "C" };


            //SortedDictionary<Anagram,string> anagrams= new SortedDictionary<Anagram,string>();


            //foreach (string _char in chars)
            //{

            //Anagram anagram = new Anagram(_char);

            //if (!anagrams.ContainsKey(anagram))
            //{
            //anagrams[anagram] = _char;

            //}

            //}

            //foreach (KeyValuePair<Anagram,string> item in anagrams)
            //{
            //Console.WriteLine($"Key: {item.Key.Word} , Values: {item.Value}");
            //}

            #endregion


            #region Q05
            //int[] numbers = { 1, 2, 2, 3, 3, 3, 3, 4, 5, 6, 7, 7, 8, 8, 9 };

            //HashSet<int> Number = new HashSet<int>();

            //foreach (int num in numbers)
            //{
            //if (!Number.Add(num))
            //{
            //Console.WriteLine($"Duplicate Number :{num}");
            //}
            //} 
            #endregion




        }
        #endregion

    }





}


