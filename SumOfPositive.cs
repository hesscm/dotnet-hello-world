using System;
using System.Linq;

public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    int counter = 0;
    // Your code here
    for (int i = 0; i < arr.Length; i++) {
      if (arr[i] > 0 ) {
        counter += arr[i];
      }
    }
    return counter;
  }
}