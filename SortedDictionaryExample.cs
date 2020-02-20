using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Test_App_For_GoAir
{
    public class SortedDictionaryExample
    {
        public static void AddBox(Dictionary<Box, string> dict, Box box, string name)
        {
            try
            {
                dict.Add(box, name);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Unable to add {0}: {1}", box, e.Message);
            }
        }
    }
    public class Box
    {
        public Box(int h, int l, int w)
        {
            Height = h;
            Length = l;
            Width = w;
        }

        public int Height { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }

        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", Height, Length, Width);
        }
    }
    public class BoxEqualityComparer : IEqualityComparer<Box>
    {
        public bool Equals(Box b1, Box b2)
        {
            if (b2 == null && b1 == null)
                return true;
            else if (b1 == null || b2 == null)
                return false;
            else if (b1.Height == b2.Height && b1.Length == b2.Length
                                && b1.Width == b2.Width)
                return true;
            else
                return false;
        }

        public int GetHashCode(Box bx)
        {
            int hCode = bx.Height ^ bx.Length ^ bx.Width;
            return hCode.GetHashCode();
        }
    }
}
// The example displays the following output:
//    Unable to add (4, 3, 4): An item with the same key has already been added.
//
//    The dictionary contains 2 Box objects.