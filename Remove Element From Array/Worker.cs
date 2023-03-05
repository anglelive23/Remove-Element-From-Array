using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Element_From_Array
{
    public class Worker
    {
        public Worker()
        {
            Work();
        }
        public void Work()
        {
            var nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            RemoveElement(nums, 2);
        }

        public int RemoveElement(int[] nums, int val)
        {
            int index = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                var current = nums[i];
                if (current != val)
                    nums[index++] = current;
            }

            Console.Write($"array without {val}: ");
            for (int i = 0; i < index; i++)
            {
                Console.Write($"{nums[i]}, ");
            }

            return index;
        }
    }
}
