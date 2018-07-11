using CTCISolutions.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCISolutions.Chapter_2_Linked_Lists
{
    class Q2_01_RemoveDupsLL
    {
        /*
         * Time Complexity: O(n)
         * Space Compexity: O(n)
         */
        private void DeleteDupsA(LinkedListNode list)
        {
            if ((list == null) || (list.Next == null))
            {
                return;
            }

            LinkedListNode current = list;
            LinkedListNode previous = null;
            HashSet<int> dataset = new HashSet<int>();

            while (current != null)
            {
                if (dataset.Contains(current.Data))
                {
                    previous.Next = current.Next;
                }
                else
                {
                    dataset.Add(current.Data);
                    previous = current;
                }
                current = current.Next;

            }
        }

        /*
         * Time Complexity: O(n^2)
         * Space Compexity: O(1)
         */
        private void DeleteDupsB(LinkedListNode list)
        {
            if ((list == null) || (list.Next == null))
            {
                return;
            }

            LinkedListNode current = list;
            LinkedListNode runner = list;
            int data;

            while (current != null)
            {
                data = current.Data;
                runner = current;

                while (runner.Next != null)
                {
                    if (runner.Next.Data == data)
                    {
                        runner.Next = runner.Next.Next;
                    }
                    else
                    {
                        runner = runner.Next;
                    }
                }

                current = current.Next;

            }

        }


        public string[] textJustification(string[] words, int l)
        {

            var result = new List<string>();
            if (words.Length == 0) return result.ToArray();
            if (l == 0) return words;

            if (words.Length == 1)
            {
                var word2 = words[0];
                for (int i = 0; i < l - words[0].Length; i++)
                {
                    word2 += " ";
                }
                result.Add(word2);
                return result.ToArray();
            }

            var index = 0;
            var index2 = 0;
            var lengthIncludingSpaces = 0;
            var length2 = 0;
            var NumOfSpacesRequired = 0;
            var newList = new List<string>();
            while (index < words.Length)
            {
                var prev = lengthIncludingSpaces;
                lengthIncludingSpaces += words[index].Length + 1;

                if (lengthIncludingSpaces >= l && prev + words[index].Length > l)
                {
                    NumOfSpacesRequired--;
                    var remainder = 0;
                    var totalspaceslength = (l - length2);


                    var divisor = (NumOfSpacesRequired == 0) ? 0 : totalspaceslength / NumOfSpacesRequired;
                    remainder = (NumOfSpacesRequired == 0) ? 0 : totalspaceslength % NumOfSpacesRequired;
                    var whitespace1 = ""; var whitespace2 = "";

                    for (int i = 0; i < divisor; i++)
                    {
                        whitespace1 += " ";
                        whitespace2 += " ";
                    }
                    if (remainder != 0) whitespace1 += " "; // All white spaces won't be of equal length
                    var word = "";

                    while (index2 < index)
                    {
                        word += words[index2];
                        if (index2 != index - 1)
                        {
                            if (NumOfSpacesRequired > 0 && remainder > 0)
                            { word += whitespace1; }
                            else if (NumOfSpacesRequired > 0 && divisor != 0)
                            { word += whitespace2; }
                        }
                        else
                        {
                            if (word.Length < l)
                            {
                                var len = word.Length;
                                while (len < l)
                                {
                                    word += " "; len++;
                                }
                            }
                        }
                        remainder--;
                        NumOfSpacesRequired--;
                        index2++;
                    }
                    lengthIncludingSpaces = 0;
                    length2 = 0;
                    NumOfSpacesRequired = 0;
                    result.Add(word);
                }
                else
                {
                    length2 += words[index].Length;
                    index++;
                    NumOfSpacesRequired++;
                }
            }
            var reminder1 = 0;
            var totalspaceslength1 = (l - length2);
            var divisor1 = (NumOfSpacesRequired == 0) ? 0 : totalspaceslength1 / NumOfSpacesRequired;
            reminder1 = (NumOfSpacesRequired == 0) ? 0 : totalspaceslength1 % NumOfSpacesRequired;
            var whitespace11 = " ";

            var str1 = "";
            // for all the words that need to be added into the last sentence, append them with a single space.
            while (index2 < index)
            {
                str1 += words[index2];
                if (index2 != index - 1)
                {
                    if (NumOfSpacesRequired > 0) str1 += whitespace11;
                }
                NumOfSpacesRequired--;
                index2++;
            }
            lengthIncludingSpaces = 0;
            length2 = 0;
            NumOfSpacesRequired = 0;

            if (str1.Length < l)
            {
                var len1 = str1.Length;
                while (len1 < l)
                {
                    str1 += " "; len1++;
                }
            }
            result.Add(str1);
            return result.ToArray();



        }
                

        /*
         Write a code to remove duplicates from a LinkedList.
         Follow up: How would you solve this problem if temporary 
                    buffer (dictionary, hashset etc) is not allowed
             */
        public void Run()
        {
            var first = new LinkedListNode(0, null, null);
            var originalList = first;
            var second = first;

            for (var i = 1; i < 8; i++)
            {
                second = new LinkedListNode(i % 2, null, null);
                first.SetNext(second);
                second.SetPrevious(first);
                first = second;
            }

            var list1 = originalList.Clone();
            var list2 = originalList.Clone();
            var list3 = originalList.Clone();

            DeleteDupsA(list1);
            DeleteDupsB(list2);

            Console.WriteLine(originalList.PrintForward());
            Console.WriteLine("");
            Console.WriteLine("Method A:");
            Console.WriteLine(list1.PrintForward());
            Console.WriteLine("");
            Console.WriteLine("Method B:");
            Console.WriteLine(list2.PrintForward());         
        }
    }
}
