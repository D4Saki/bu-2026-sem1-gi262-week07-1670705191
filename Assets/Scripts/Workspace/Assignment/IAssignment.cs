using System;
using System.Collections.Generic;

namespace Assignment
{
    public interface IAssignment
    {

        #region Lecture

        int LCT01_SequentialSearch1DArray();

        int[] LCT02_SequentialSearch2DArray();

        int LCT03_BinarySearch();

        #endregion

        #region Assignment

        public int[] AS01_FindFirstAndLastElementOfArray(int[] array, int target)
        {
            int first = -1;
            int last = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    if (first == -1)
                    {
                        first = i; 
                    }
                    last = i; 
                }
            }

            if (first == -1)
            {
                return new int[] { -1 };
            }

            return new int[] { first, last };
        }

        public int AS02_FindMaxLessThan(int[] array, int target)
        {
            int maxVal = -1;
            bool found = false;

            foreach (int num in array)
            {
                if (num < target)
                {
                    if (!found || num > maxVal)
                    {
                        maxVal = num;
                        found = true;
                    }
                }
            }

            return found ? maxVal : -1;
        }

        public int[] AS03_FindRange(int[] array, int min, int max)
        {
            List<int> result = new List<int>();

            foreach (int num in array)
            {
                if (num >= min && num <= max)
                {
                    result.Add(num);
                }
            }

            return result.ToArray();
        }

        #endregion

        #region Extra

        public int[] EX01_FindTargetEnemies(int[] enemyHPs, int mana)
        {
            int[] sortedHPs = (int[])enemyHPs.Clone();
            Array.Sort(sortedHPs);

            List<int> chosenEnemies = new List<int>();
            int currentManaSum = 0;

            foreach (int hp in sortedHPs)
            {
                if (currentManaSum + hp <= mana)
                {
                    chosenEnemies.Add(hp);
                    currentManaSum += hp;
                }
                else
                {
                    break;
                }
            }

            return chosenEnemies.ToArray();
        }

        #endregion
    }
}