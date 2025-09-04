namespace MyLinq
{
    public static class MyLinq
    {
        public static bool All<T>(this IEnumerator<T> enumerator, Func<T, bool> predicate)
        {
            while (enumerator.MoveNext())
            {
                if (!predicate(enumerator.Current))
                    return false;
            }
            return true;
        }

        public static bool Any<T>(this IEnumerator<T> enumerator)
        {
            bool result = enumerator.MoveNext();
            return result;
        }

        public static bool Any<T>(this IEnumerator<T> enumerator, Func<T, bool> predicate)
        {
            while (enumerator.MoveNext())
            {
                if (predicate(enumerator.Current))
                    return true;
            }
            return false;
        }

        public static T First<T>(this IEnumerator<T> enumerator)
        {
            bool result = enumerator.MoveNext();
            if (result) return enumerator.Current;
            else throw new InvalidOperationException();
        }

        public static T First<T>(this IEnumerator<T> enumerator, Func<T, bool> predicate)
        {
            while (enumerator.MoveNext())
            {
                if (predicate(enumerator.Current))
                    return enumerator.Current;
            }
            throw new InvalidOperationException();
        }

        public static T? FirstOrDefault<T>(this IEnumerator<T> enumerator)
        {
            bool result = enumerator.MoveNext();
            if (result) return enumerator.Current;
            else return default;
        }

        public static T? FirstOrDefault<T>(this IEnumerator<T> enumerator, Func<T, bool> predicate)
        {
            while (enumerator.MoveNext())
            {
                if (predicate(enumerator.Current))
                    return enumerator.Current;
            }
            return default;
        }

        public static T? FirstOrDefault<T>(this IEnumerator<T> enumerator, Func<T, bool> predicate, T Default)
        {
            while (enumerator.MoveNext())
            {
                if (predicate(enumerator.Current))
                    return enumerator.Current;
            }
            return Default;
        }

        public static IEnumerator<T> Where<T>(this IEnumerator<T> enumerator, Func<T, bool> predicate)
        {
            var listWhere = new List<T>();
            while (enumerator.MoveNext())
            {
                if (predicate(enumerator.Current))
                    listWhere.Add(enumerator.Current);
            }
            return listWhere.GetEnumerator();
        }

        public static int Count<T>(this IEnumerator<T> enumerator)
        {
            int count = 0;
            while (enumerator.MoveNext())
            {
                count++;
            }
            return count;
        }

        public static int Count<T>(this IEnumerator<T> enumerator, Func<T, bool> predicate)
        {
            int count = 0;
            while (enumerator.MoveNext())
            {
                if (predicate(enumerator.Current))
                    count++;
            }
            return count;
        }
    }
}