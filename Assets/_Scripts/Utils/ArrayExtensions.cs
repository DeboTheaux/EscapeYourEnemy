using System;
using System.Collections.Generic;
using System.Linq;

public static class ArrayExtensions
{
    public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
    {
        if (!enumerable.IsFilled())
            return;

        //Loop.
        for (int i = 0; i < enumerable.Count(); i++)
        {
            T item = enumerable.ElementAt(i);
            action.Invoke(item);
        }
    }

    public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T, int> action)
    {
        if (!enumerable.IsFilled())
            return;

        //Loop.
        for (int i = 0; i < enumerable.Count(); i++)
        {
            T item = enumerable.ElementAt(i);
            action.Invoke(item, i);
        }
    }

    public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T, int, IEnumerable<T>> action)
    {
        if (!enumerable.IsFilled())
            return;

        //Loop.
        for (int i = 0; i < enumerable.Count(); i++)
        {
            T item = enumerable.ElementAt(i);
            action.Invoke(item, i, enumerable);
        }
    }

    public static void ForEach<T1, T2>(this IEnumerable<KeyValuePair<T1, T2>> enumerable, Action<T1, T2> action)
    {
        if (enumerable == null)
            return;

        //Loop.
        for (int i = 0; i < enumerable.Count(); i++)
        {
            KeyValuePair<T1, T2> item = enumerable.ElementAt(i);
            action.Invoke(item.Key, item.Value);
        }
    }

    public static bool IsFilled<T>(this IEnumerable<T> enumerable)
    {
        //No null enumerables.
        if (enumerable == null)
            return false;

        //Return for empty enumerables.
        if (enumerable.Count() == 0)
            return false;

        return true;
    }
}
