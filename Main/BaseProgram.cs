/*
 * Playing around with generics and method extensions! :D
 */

using System;

public static class BaseProgram
{
    #region Extension Methods 
    static int trying = 3;
    public static T TestData<T>(this int t, T aaar, bool art = false) where T : struct => aaar;
    #endregion

    public static void Main(string[] args)
    {
        int[] ar = new int[] { trying, trying.TestData(trying + 17, true) }.FlipArray();
        ar.DisplayArray();

        int[] arr = new int[] { 1, 2, 3 }.FlipArray();
        int[] a = new int[] { 1, 2, 3, 15, 213, 616, 829 }.FlipArray();
        arr.DisplayArray(); //Display single array
        //a.DisplayArray();
        ReadArray.DisplayMultipleArrays(new int[][] { arr, a });   //Moved it to a single line + multi array! C:<

        string sArr =  "a f";
        string sA = "a rTY";
        sA.ToCharArray().DisplayArray(); //Single string display as a char array!
        ReadArray.DisplayMultipleArrays(new char[][] { sArr.ToCharArray(), sA.ToCharArray() }); //Since strings are arrays of chars!!! :|
    }
}

public static class RetArray
{
    public static T[] FlipArray<T>(this T[] arr) where T : struct
    {
        T[] flip = new T[arr.Length];
        for (int i = arr.Length - 1; i >= 0; i--)
            flip[arr.Length - 1 - i] = arr[i];
        return flip;
    }
}

public static class ReadArray
{
    public static void DisplayArray<T>(this T[] a) where T : struct
    {
        foreach (var r in a) Console.Write($"{r} ");
        Console.WriteLine("");
    }

    public static void DisplayMultipleArrays<T>(T[][] multiArray) where T : struct 
    {
        foreach (T[] mA in multiArray)
            mA.DisplayArray();
    }
}
