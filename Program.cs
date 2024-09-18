using System;


class Program
{
    static void Main()
    {
        int[] arr = { 38, 27, 43, 3, 9, 82, 10 };
        Console.WriteLine("Orginal array :");
        Console.WriteLine(string.Join(", ", arr));

        MergeSort(arr, 0, arr.Length - 1);

        Console.WriteLine("Sorted array :");
        Console.WriteLine(string.Join(", ", arr));
    }


    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;

            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);

            Merge(arr, left, mid, right);
        }
    }
    
    static void Merge(int[] arr, int left, int  mid, int right)
    {
        int n1 = mid - left +1;
        int n2 = right - mid;

        int[] L = new int[n1];
        int[] R = new int[n2];


        Array.Copy(arr, left, L, 0, n1);
        Array.Copy(arr, mid + 1, R, 0, n2);

        int i = 0, j = 0;
        int k = left;

        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                arr[k] = L[i];
                
                i++;
            }
            else
            {
                arr[k] = R[j];

                j++;
            }
            k++;
        }

        while (i < n1)
        {
            arr[k] = L[i];
            i++;
            k++;
        }

        while(j < n2)
        {
            arr[k] = R[j];
            j++; 
            k++;
        }
    }

        
}