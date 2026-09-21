public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        var graph = new List<int>[numCourses];
        var visited = new List<int>();
        var path = new List<int>();

        for(int i=0; i<numCourses; i++)
        {
            graph[i]= new List<int>();
        }

        foreach(var p in prerequisites)
        {
            var prereq = p[1];
            var course = p[0];

            // pre req -> course
            graph[prereq].Add(course);
        }


        for(int i=0; i<numCourses; i++)
        {
            if(!DFS(i, graph, visited, path))
                return false;
        }

        return true;

    }

    public bool DFS(int i, List<int>[] graph, List<int> visited, List<int> path)
    {
        // hurreyy, got the cycle
        if(path.Contains(i))
            return false;

        // already done dude
        if(visited.Contains(i))
            return true;

        path.Add(i);
        visited.Add(i);

        foreach(var j in graph[i])
        {
            if(!DFS(j, graph, visited, path))
                return false;
        }

        path.Remove(i);

        return true;
    }
}
