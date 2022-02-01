using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Algorithms
{
    internal class BFS
    {
        public int _vertices;
        public LinkedList<int>[] _graph;
        
        public BFS(int v)
        {
            _vertices = v;
            _graph = new LinkedList<int>[_vertices];

            for(int i = 0; i < _vertices; i++)
            {
                _graph[i] = new LinkedList<int>();
            }
        }


        public void AddVertex(int v, int w)
        {
            _graph[v].AddLast(w);
        }

        public void Traverse(int s)
        {
            bool[] visited = new bool[_vertices];
            for(int i=0; i < _vertices; i++)
            {
                visited[i] = false;
            }

            Queue<int> q = new Queue<int>();

            q.Enqueue(s);
            visited[s] = true;

            while (q.Count > 0)
            {
                s = q.First();
                Console.Write($"{s} ");
                q.Dequeue();

                
                foreach(var x in _graph[s])
                {
                    if (!visited[x])
                    {
                        visited[x] = true;
                        q.Enqueue(x); 
                    }
                }
            }

        }
    }
 
}
