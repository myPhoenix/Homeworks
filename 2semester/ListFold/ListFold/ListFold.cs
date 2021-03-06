﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListFold
{
    /// <summary>
    /// Static lass for list fold function
    /// </summary>
    public static class FoldClass
    {
        /// <summary>
        /// list fold function
        /// </summary>
        /// <param name="list"></param>
        /// <param name="initialValue"></param>
        /// <param name="updateValue"></param>
        /// <returns></returns>
        public static int Fold(List list, int initialValue, Func<int, int, int> updateValue)
        {
            var temp = list.GetHead;
            int foldedValue = initialValue;
            while (temp != null)
            {
                foldedValue = updateValue(foldedValue, temp.Key);
                temp = temp.Next;
            }
            return foldedValue;
        }

        /// <summary>
        /// Counts the sum of the folded value and the list element key
        /// </summary>
        /// <param name="foldedValue"> folded value</param>
        /// <param name="listElementKey"> list element key </param>
        /// <returns> its sum </returns>
        public static int Sum(int foldedValue, int listElementKey)
        {
            return (foldedValue + listElementKey);
        }
    }
}
