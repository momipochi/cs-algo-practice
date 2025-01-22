namespace CsAlgoPractice.Leetcode.L207_CourseSchedule;

public class CourseSchedule
{
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        int[] track = new int[numCourses];
        for (int i = 0; i < prerequisites.Length; i++)
        {
            track[prerequisites[i][1]]++;
        }

        bool found = true;
        bool[] visited = new bool[prerequisites.Length];
        while (found)
        {
            found = false;
            for (int i = 0; i < prerequisites.Length; i++)
            {
                if (!visited[i] && track[prerequisites[i][0]] == 0)
                {
                    found = true;
                    track[prerequisites[i][1]]--;
                    visited[i] = true;
                }
            }
        }

        for (int i = 0; i < track.Length; i++)
        {
            if (track[i] != 0)
            {
                return false;
            }
        }
        return true;
    }
}