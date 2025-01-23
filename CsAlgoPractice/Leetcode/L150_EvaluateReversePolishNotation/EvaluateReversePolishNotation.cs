namespace CsAlgoPractice.Leetcode.L150_EvaluateReversePolishNotation;

public class EvaluateReversePolishNotation
{
    public int EvalRPN(string[] tokens)
    {
        Dictionary<string, Func<int,int,int>> strategy = new Dictionary<string, Func<int,int,int>>
        {
            ["+"] = (x, y) => x + y,
            ["-"] = (x, y) => x - y,
            ["*"] = (x, y) => x * y,
            ["/"] = (x, y) => x / y
        };

        Stack<int> stk = new Stack<int>();
        foreach (var token in tokens)
        {
            if (int.TryParse(token,out var v))
            {
                stk.Push(v);    
            }
            else
            {
                if (strategy.ContainsKey(token))
                {
                    int b = stk.Pop(), a = stk.Pop();
                    stk.Push(strategy[token](a,b));
                }
                else
                {
                    throw new ArgumentException();
                }    
            }
            
            
        }
        
        return stk.Pop();
    }

}