using UnityEngine;

public class Tutorial16 : MonoBehaviour
{
    private void Start()
    {
        // Single Dimensional Array
        int[] ints = {1,2,3,4,5,6};
        ints[0] = 0;
        ints[1] += 1;
        if(5<ints.Length) ints[5] = 1;
        Debug.Log(ints.Length);

        // Jagged Array
        int[][] jaggedInts = new int[5][];
        Debug.Log(jaggedInts[1]);
        jaggedInts[1] = new[] {1, 2, 3, 4, 5};
        Debug.Log(jaggedInts.Length);
        Debug.Log(jaggedInts[1].Length);
        Debug.Log(jaggedInts[1][1]);

        //Multi-Dimensional Arrays
        int[,] multiDimensionalArray = {{1,2,3},{1,2,3},{1,2,3}};
        Debug.Log(multiDimensionalArray[0,1]);
        Debug.Log(multiDimensionalArray.GetLength(0));
        Debug.Log(multiDimensionalArray.GetLength(1));
        // Debug.Log(multiDimensionalArray.GetLength(2)); // (Causes Error)
    }
}