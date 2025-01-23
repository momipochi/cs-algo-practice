namespace CsAlgoPractice.Leetcode.L210_CourseScheduleII;

public class CourseScheduleII
{
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        int[] track = new int[numCourses];
        for (int i = 0; i < prerequisites.Length; i++)
        {
            track[prerequisites[i][1]]++;
        }

        bool found = true;
        int count = 0;
        int[] res = new int[numCourses];
        bool[] visited = new bool[prerequisites.Length], saved = new bool[numCourses];
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
                    if( count < res.Length && (track[prerequisites[i][1]] == 0 || track[prerequisites[i][0]] == 0)){
                        if(track[prerequisites[i][0]] == 0 && !saved[prerequisites[i][0]]){
                            res[count] = prerequisites[i][0];
                            saved[prerequisites[i][0]] = true;
                            count++;
                        }else if(track[prerequisites[i][1]] == 0 && !saved[prerequisites[i][1]]){
                            res[count] = prerequisites[i][1];
                            saved[prerequisites[i][1]] = true;
                            count++;
                        }
                    }
                }
            }
        }

        for (int i = 0; i < track.Length; i++)
        {
            if (track[i] != 0)
            {
                return [];
            }
        }
        if(count < res.Length){
            for(int i = 0; i<numCourses;i++){
                if(!saved[i]){
                    res[count] = i;
                    count++;
                }
            }
        }
        Array.Reverse(res);
        return res;
    }
}