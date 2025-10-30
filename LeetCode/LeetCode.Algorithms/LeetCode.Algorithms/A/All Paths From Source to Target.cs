using System.Collections;
using System.Xml.Linq;

namespace LeetCode.Algorithms;

public static  class All_Paths_From_Source_to_Target
{

    public static void DFS(List<IList<int>> result, List<int> currentPath, int currNode, int destination, int[][] graph)
    {
        var newCurrPath = new List<int>();
        foreach (var node in currentPath) { newCurrPath.Add(node); }
        newCurrPath.Add(currNode);
        if (currNode == destination)
        {
            result.Add(newCurrPath);
            return;
        }
        else
        {
            for (int i = 0; i < graph[currNode].Length; i++)
            {
                DFS(result, newCurrPath, graph[currNode][i], destination, graph);
            }
        }
    }

    public static IList<IList<int>> AllPathsSourceTarget(int[][] graph)
    {
        var result = new List<IList<int>>();
        for (int i = 0; i < graph[0].Length; i++)
        {
            var currPath = new List<int>{ 0 };
            DFS(result,currPath, graph[0][i], graph.Length - 1, graph);
        }
        return result;
    }
}
