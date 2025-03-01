namespace CsAlgoPractice.Leetcode.L1010_PairsOfSongsDivisibleBy60;

public class PairsOfSongsDivisibleBy60
{
    public int NumPairsDivisibleBy60(int[] time)
    {
        int[] dict = new int[60];
        int res = 0;

        foreach(var t in time)
        {
            res += dict[(60 - t % 60) % 60];  //count number of matching modulus in visited values
            dict[t % 60]++;
        }
        return res;
    }
}