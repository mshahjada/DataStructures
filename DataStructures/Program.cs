// See https://aka.ms/new-console-template for more information

using DataStructures;
using DataStructures.Algorithms;
using DataStructures.Problems;

//int[] arr = { 10, 5, 2, 8, 2, 7 };

int[] arr = { 4,3,7,2,5};

//Console.WriteLine($"Sorted Result: {string.Join(", ", Algorithms.SelectionSort(arr))}");
//Console.WriteLine($"Sorted Result: {string.Join(", ", Algorithms.BubbleSort(arr))}");
//Console.WriteLine($"Sorted Result: {string.Join(", ", Algorithms.InsertionSort(arr))}");

//var data = BinarySearchTree.InsertNode(BinarySearchTree.GetTree(), 5);
//var data = BinarySearchTree.DeleteNode(BinarySearchTree.GetTree(), 3);
//BinarySearchTree.PreOrderTraverser(BinarySearchTree.GetTree());


//Console.WriteLine($"Sorted Result: {string.Join(", ", HeapSort.Apply(new int[] {5,3,6,2,4}))}");

//Console.WriteLine($"BFS Result:");
//var g = new BFS(4);
//g.AddVertex(0, 1);
//g.AddVertex(0, 2);
//g.AddVertex(1, 2);
//g.AddVertex(2, 0);
//g.AddVertex(2, 3);
//g.AddVertex(3, 3);

//g.Traverse(2);


//Console.WriteLine($"Longest Common Subsequent:");
//var res = new LongestCommonSubsequent().commonChild("HARRY", "SALLY");

//KnapSack.Init();

//var res = new EditDistance().Memoize("food", "money", 4, 5);

new MinCostPath().TestMain();
Console.ReadKey();
    