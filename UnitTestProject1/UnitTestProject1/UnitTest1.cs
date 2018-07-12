using System;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Exercise1V4()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\marina.jechiu\Desktop\Internship1807\Internship1807\firstIn.txt");
            int[] array = Array.ConvertAll(lines, int.Parse);
            int numberOfElements = array.Length;
            for (int i = 0; i < array.Length-1; i++)
            {
                if ((array[i] > 0 && array[i + 1] < 0) || (array[i] < 0 && array[i + 1] > 0))
                {
                    numberOfElements++;
                }
            }

            AddElementsInArray(ref array, numberOfElements);
            System.IO.File.WriteAllText(@"C:\Users\marina.jechiu\Desktop\Internship1807\Internship1807\firstOut.txt", ConvertIntToString(array));
        }

        public void AddElementsInArray(ref int[] array, int element)
        {
            Array.Resize(ref array, element);
            for (int i = 0; i < array.Length - 1; i++)
            {
                if ((array[i] > 0 && array[i + 1] < 0) || (array[i] < 0 && array[i + 1] > 0))
                {
                    ReplaceelementsOfTable(ref array, i + 1);
                    array[i + 1] = 0;
                }
            }
        }

        public void ReplaceelementsOfTable(ref int[] array, int position)
        {
            for(int i = array.Length - 1; i > position; i--)
            {
                array[i] = array[i - 1];
            }
        } 

        public string ConvertIntToString(int[] array)
        {
            StringBuilder builder = new StringBuilder();
        
            builder.Append(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                builder.Append(',');
                builder.Append(array[i]);
            }
            return builder.ToString();
        }
    }
}
