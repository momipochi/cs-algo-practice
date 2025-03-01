namespace CsAlgoPractice.Leetcode.L49_GroupAnagrams;

public class GroupAnagram
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, IList<string>> res = new();

        for (int i = 0; i < strs.Length; i++)
        {
            var tmp = strs[i].ToCharArray();
            Array.Sort(tmp);
            var key = new string(tmp);
            if (res.ContainsKey(key))
            {
                res[key].Add(strs[i]);
            }
            else
            {
                res[key] = new List<string>() {strs[i]};
            }
        }
        
        return res.Select(x=>x.Value).ToList();
    }
}