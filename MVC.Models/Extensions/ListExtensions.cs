namespace MVC.Models.Extensions
{
    using System;
    using System.Collections.Generic;

    public static class ListExtensions
    {
        private const string RangeParameter = "range";
        private const string RangeNullExceptionMessage = "Range cannot be null";

        public static void AddRange<T>(this IList<T> list, IList<T> range)
        {
            if (range == null) throw new ArgumentNullException(RangeParameter, RangeNullExceptionMessage);

            foreach (var element in range)
            {
                list.Add(element);
            }
        }

        public static void AddRange<T>(this IList<T> list, T[] range)
        {
            if (range == null) throw new ArgumentNullException(RangeParameter, RangeNullExceptionMessage);

            foreach (var element in range)
            {
                list.Add(element);
            }
        }
    }
}
