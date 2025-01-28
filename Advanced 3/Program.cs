using System;
using System.Collections;
using System.ComponentModel;
using System.IO;

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





            // we can use sorted set to get max value
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

            #region Q06



            //SortedDictionary<int, string> students = new SortedDictionary<int, string>(new students_Q06());



            //students.Add(1, "A");
            //students.Add(2, "B");
            //students.Add(3, "C");
            //students.Add(4, "D");


            //foreach (KeyValuePair<int, string> st in students)
            //{
            //Console.WriteLine($"ID: {st.Key}, Name: {st.Value}");
            //}

            //Console.WriteLine(/*===========================*/);



            //if (students.Remove(1))
            //{
            //Console.WriteLine(" 1 Student removed");
            //}
            //else
            //{
            //Console.WriteLine("Student not found.");
            //}

            //Console.WriteLine(/*===========================*/); 

            //foreach (KeyValuePair<int, string> st in students)
            //{
            //Console.WriteLine($"ID: {st.Key}, Name: {st.Value}");
            //}



            //students.Add(20, "z");
            //Console.WriteLine("1 Student Added ");




            //Console.WriteLine(/*===========================*/);

            //foreach (KeyValuePair<int, string> st in students)
            //{
            //Console.WriteLine($"ID: {st.Key}, Name: {st.Value}");
            //}

            #endregion

            #region Q07

            //SortedDictionary<int, string> employee = new SortedDictionary<int, string>();

            //employee.Add(1, "Ahmed");
            //employee.Add(2, "Omar");
            //employee.Add(3, "Ali");
            //employee.Add(4, "Abdelrahman");



            //SortedList<int, string> employee_directory = new SortedList<int, string>();

            //employee_directory.Add(1, "Ahmed");
            //employee_directory.Add(2, "Omar");
            //employee_directory.Add(3, "Ali");
            //employee_directory.Add(4, "Abdelrahman");

            //foreach (KeyValuePair<int,string> employee in employee_directory)
            //{
            //Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
            //}


            //Console.WriteLine(/*===========================*/);


            //employee_directory.Add(5, "sara");

            //Console.WriteLine("After Adding 1 Employee :");


            //foreach (KeyValuePair<int, string> employee in employee_directory)
            //{
            //Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
            //}


            //Console.WriteLine(/*===========================*/);

            //employee_directory.Remove(5);

            //Console.WriteLine("After Removing 1 Employee :");


            //foreach (KeyValuePair<int, string> employee in employee_directory)
            //{
            //Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
            //}



            ////if we want to order by desc ... use (students Q06 ) class we created in Q06 -->
            ////SortedList<int, string> employee_directory = new SortedList<int, string>(new students_Q06());


            #endregion


            #region Q08

            //int[] numbers = { 1, 2, 5, 8, 11,14 };
            //int N = 15; 



            //HashSet<int> Numbers = new HashSet<int>();
            //for (int i = 1; i <= N; i++)
            //{
            //Numbers.Add(i);
            //}

            //foreach (int num in numbers)
            //{
            //Numbers.Remove(num);
            //}

            //Console.WriteLine("Missing numbers:");
            //foreach (int i in Numbers)
            //{
            //Console.WriteLine(i);
            //} 
            #endregion



            #region Q09
            //List<int> Nums = new List<int> { 1, 1, 1, 2, 2, 2, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 9, 9, 9 };



            //HashSet<int> unique = new HashSet<int>(Nums);

            //Console.WriteLine("Unique Nums:");
            //foreach (int num in unique)
            //{
            //Console.WriteLine(num);
            //} 
            #endregion



            #region Q10
            //Hashtable FirstTable = new Hashtable();

            //FirstTable.Add(1, "A");
            //FirstTable.Add(2, "B");
            //FirstTable.Add(3, "C");
            //FirstTable.Add(4, "D");
            //FirstTable.Add(5, "E");



            //foreach (DictionaryEntry first in FirstTable)
            //{
            //Console.WriteLine($"Key : {first.Key} :: Value : {first.Value}");         
            //}




            //Console.WriteLine(/*===========================*/);





            //Hashtable SecondTable = new Hashtable();

            //foreach (DictionaryEntry Second in FirstTable)
            //{
            //    SecondTable[Second.Value] = Second.Key;

            //}




            //foreach (DictionaryEntry Second in SecondTable)
            //{
            //    Console.WriteLine($"Key : {Second.Key} :: Value : {Second.Value}");
            //}







            //  Console.WriteLine(/*===========================*/);

            // if we want keys and values ordered by key use sorted list -->






            //SortedList SecondTable = new SortedList();



            //foreach (DictionaryEntry Second in FirstTable)
            //{
            //SecondTable[Second.Value] = Second.Key;
            //}


            //foreach (DictionaryEntry Second in SecondTable)
            //{
            //Console.WriteLine($"Key : {Second.Key} :: Value : {Second.Value}");
            //}

            #endregion



            #region Q11
            //HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };

            ////////////HashSet<int> set2 = new HashSet<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            //HashSet<int> set2 = new HashSet<int> { 4, 5, 6, 7, 8,9,10 };

            /////////set2.UnionWith(set1);

            /////////////foreach (int Union in set1)
            /////////{
            /////////Console.WriteLine(Union);
            /////////}





            //set1.UnionWith(set2);

            //foreach (int Union in set1)
            //{
            //    Console.WriteLine(Union);
            //} 
            #endregion



            #region Q12


            Dictionary<string, int> Element = new Dictionary<string, int>();

            Element.Add("apple", 1);
            Element.Add("animal", 2);
            Element.Add("airport", 3);




            Console.WriteLine("Enter A char");
            string Achar = Console.ReadLine();





            foreach (KeyValuePair<string, int> item in Element)

            {

                if (item.Key.StartsWith(Achar))
                {
                    Console.WriteLine(Achar);
                }
            }
            #endregion


            #endregion



        }
        }
    }







