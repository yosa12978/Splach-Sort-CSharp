# Splash Sort Algorithm
splash sort is a sorting algorithm which i created with myself
## Realization

C#:
```C#
public static void sort(int[] arr)
{
    for(int i = 0; i <= arr.Length-1; i++)
        for(int j = 0; j <= arr.Length-1; j++)
            if(arr[i] < arr[j])
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
}
```
