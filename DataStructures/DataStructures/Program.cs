using DataStructures;
using System.Linq;

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
var result = BinarySearch.SearchIterable(array, 3);
Console.WriteLine(result);

int[] array2 = { 5, 2, 3, 8, 9, 0, 1, 4, 6, 7, 10 };
var result2 = Sorting.BubbleSort(array2);
var resp = string.Join(", ", result2);
Console.WriteLine(resp);
Console.ReadKey();