
public static class Utils
{
    public static IList<IList<T>> TwoDimensionalArrayToList<T>(T[][] arr)
    {
        IList<IList<T>> res = [];
        for (int i = 0; i < arr.Length; i++)
        {
            IList<T> tmp = [];
            for (int j = 0; j < arr[i].Length; j++)
            {
                tmp.Add(arr[i][j]);
            }
            res.Add(tmp);
        }
        return res;
    }
    public static bool AreTwoDimensionalListsEqual<T>(IList<IList<T>> a, IList<IList<T>> b)
    {
        return a.Count == b.Count &&
                a.Zip(b, (innerListA, innerListB) => innerListA.SequenceEqual(innerListB))
                 .All(result => result);

    }
}