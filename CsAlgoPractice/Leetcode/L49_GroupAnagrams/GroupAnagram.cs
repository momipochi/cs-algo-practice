namespace CsAlgoPractice.Leetcode.L49_GroupAnagrams;

public class GroupAnagram
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string,IList<string>> res = new Dictionary<string,IList<string>>();

        foreach (var str in strs)
        {
            char[] tmp = str.ToCharArray();
            Array.Sort(tmp);
            var stmp = new string(tmp);
            if (res.ContainsKey(stmp))
            {
                res[stmp].Add(str);
            }
            else
            {
                res[stmp] = new List<string> { str };
            }
        }
        
        return res.Select(x=>x.Value).ToList();
    }
}