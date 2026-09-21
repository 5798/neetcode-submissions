public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        var graph = new List<int>[n];
        var hashSet = new HashSet<int>();

        for(int i =0; i<n ;i++)
        {
            graph[i] = new List<int>();
        }

        foreach(var edge in edges)
        {
            var i = edge[0];
            var j = edge[1];

            graph[i].Add(j);
            graph[j].Add(i);
        }

        if(!DFS(0, -1, graph, hashSet))
            return false;

        return hashSet.Count==n;
    }

    public bool DFS(int node, int parent, List<int>[] graph, HashSet<int> hashSet)
    {
        // Store yourself
        hashSet.Add(node);

        // checl every neighbour and check if its parent
        foreach(var next in graph[node])
        {
            if(next==parent)
                continue;
                
            if(hashSet.Contains(next))
                return false;

            if(!DFS(next, node, graph, hashSet))
                return false;
        }
        return true;

    }
}
