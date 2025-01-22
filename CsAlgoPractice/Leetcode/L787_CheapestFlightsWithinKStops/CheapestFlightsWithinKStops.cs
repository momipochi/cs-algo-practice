namespace CsAlgoPractice.Leetcode.L787_CheapestFlightsWithinKStops;

public class CheapestFlightsWithinKStops
{
    private int[] track;
    private int[][] flights;
    public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
    {
        this.track = new int[n];
        this.flights = flights;
        Array.Fill(track,Int32.MaxValue);
        this.track[src] = 0;
        for (int i = 0; i <= k; i++)
        {
            if (!ExistsRoute())
            {
                break;
            }
        }
        return track[dst] == Int32.MaxValue ? -1 : track[dst];
    }

    private bool ExistsRoute()
    {
        int[] copy = new int[track.Length];
        Array.Copy(track, copy, track.Length);
        bool res = false;
        foreach (var flight in flights)
        {
            int price = flight[2] + copy[flight[0]];
            if (copy[flight[0]] != Int32.MaxValue && track[flight[1]] > price)
            {
                track[flight[1]] = price;
                res = true;
            }
        }
        return res;
    }
}