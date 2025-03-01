namespace CsAlgoPractice.Leetcode.L68_TextJustification;

public class TextJustification
{
    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        IList<string> res = new List<string>();
        IList<string> cur = new List<string>();

        int acc = 0;
        foreach (string word in words)
        {
            if (acc + word.Length + cur.Count > maxWidth)
            {
                for (int i = 0; i < maxWidth - acc; i++)
                {
                    cur[i % (cur.Count - 1 > 0 ? cur.Count - 1 : 1)] += " ";
                }
                res.Add(string.Join("",cur));
                cur.Clear();
                acc = 0;
            }
            cur.Add(word);
            acc += word.Length;
        }

        string lastLine = string.Join(" ", cur);
        while (lastLine.Length != maxWidth) lastLine += " ";
        res.Add(lastLine);
        
        return res;
    }
}