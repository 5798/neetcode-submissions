public class Solution {
    public int CountComponents(int n, int[][] edges) {
        var graph = new List<int>[n];
        var hashSet = new HashSet<int>();
        var component = 0;

        for(int i=0; i<n ;i++)
        {
            graph[i] = new List<int>();
        }

        foreach(var edge in edges)
        {
            int i = edge[0];
            int j = edge[1];
            graph[i].Add(j);
            graph[j].Add(i);
        }

        for(int i=0; i<n ;i++)
        {
            if(!hashSet.Contains(i))
                component++;
            DFS(i, graph, hashSet);
        }

        return component;
    }

    public void DFS(int i, List<int>[] graph, HashSet<int> hashSet)
    {
        if(hashSet.Contains(i))
            return;
        
        hashSet.Add(i);

        foreach(var next in graph[i])
        {
            DFS(next, graph, hashSet);
        }

        return;
    }
}
