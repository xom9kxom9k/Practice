using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeOne.Second;

public class Graph
{
    private int[,] adjMatrix;
    private int verticesCount;
    public int[] ints;

    public Graph(int[,] matrix)
    {
        verticesCount = matrix.GetLength(0);
        adjMatrix = new int[verticesCount, verticesCount];
        Array.Copy(matrix, adjMatrix, matrix.Length);
        ints = new int[verticesCount];
        
    }
    public void BFS(int startVertex)
    {
        bool[] visited = new bool[verticesCount];
        Queue<int> queue = new Queue<int>();
        int temp = 0;
        visited[startVertex] = true;
        queue.Enqueue(startVertex);
        
        while (queue.Count != 0)
        {
            int currentVertex = queue.Dequeue();
            
            for (int i = temp; i < verticesCount; i++)
            {
                ints[i] = currentVertex;
            }
            temp++;

            for (int i = 0; i < verticesCount; i++)
            {
                if (adjMatrix[currentVertex, i] == 1 && !visited[i])
                {
                    visited[i] = true;
                    queue.Enqueue(i);
                }
            }
        }
    }
}
