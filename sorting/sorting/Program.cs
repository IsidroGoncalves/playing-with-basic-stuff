using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------sort shell-------------");
            SortShell.ExecuteSortShell();
            Console.WriteLine("-----------bogosort sort-------------");
            BogoSort.ExecuteBogoSort();
            Console.WriteLine("-----------bubble sort-------------");
            BubbleSort.ExecuteBubbleSort();
            Console.WriteLine("-----------counting sort-------------");
            CountingSort.ExecuteCountingSort();
            Console.WriteLine("-----------heap sort-------------");
            HeapSort.ExecuteHeapSort();
            Console.WriteLine("-----------insertion sort-------------");
            Insertion.ExecuteInsertionSort();
            Console.WriteLine("-----------merge sort-------------");
            MergeSort.ExecuteMergeSort();
            Console.WriteLine("-----------Permutation-------------");
            Permutation.ExecutePermutationSort();
            Console.WriteLine("-----------Quick Sort-------------");
            QuickSort.ExecuteQuickSort();
            Console.WriteLine("-----------Radix Sort-------------");
            RadixSort.ExecuteRadixSort();
            Console.WriteLine("-----------Selection Sort-------------");
            SelectionSort.ExecuteSelectionSort();
            Console.ReadLine();            
        }
    }
}
