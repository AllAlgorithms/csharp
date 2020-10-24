using System;

class Prim {
    static void PrimAlgorithm (int V, int[, ] G) {
        // create a array to track selected vertex
        int INF = 9999999;
        // set number of edge to 0
        int no_edge = 0;
        /* the number of egde in minimum spanning tree will be
        always less than(V - 1), where V is number of vertices in
        graph */
        int[] selected = new int[V];
        for (int i = 0; i < V; i++) {
            selected[i] = 0;
        }
        // choose 0th vertex and make it true
        selected[0] = 1;
        // print for edge and weight
        Console.WriteLine ("Edge : Weight\n");
        while (no_edge < V - 1) {
            /* For every vertex in the set S, find the all adjacent vertices
            calculate the distance from the vertex selected at step 1.
            if the vertex is already in the set S, discard it otherwise
            choose another vertex nearest to selected vertex  at step 1. */
            int minimum = INF;
            int x = 0;
            int y = 0;
            for (int i = 0; i < V; i++) {
                if (selected[i] == 1) {
                    for (int j = 0; j < V; j++) {
                        if ((selected[j] == 0) && G[i, j] > 0) {
                            // not in selected and there is an edge
                            if (minimum > G[i, j]) {
                                minimum = G[i, j];
                                x = i;
                                y = j;
                            }
                        }
                    }
                }
            }
            Console.WriteLine (x + "-" + y + ":" + G[x, y]);
            selected[y] = 1;
            no_edge += 1;
        }
    }

    static void Main (string[] args) {

        int V = 5;
        /* create a 2d array of size 5x5
         for adjacency matrix to represent graph */
        int[, ] G = new int[5, 5] { { 0, 9, 75, 0, 0 }, { 9, 0, 95, 19, 42 }, { 75, 95, 0, 51, 66 }, { 0, 19, 51, 0, 31 }, { 0, 42, 66, 31, 0 }

        };
        PrimAlgorithm (V, G);
    }
}