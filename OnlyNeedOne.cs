public class Kata
{
  public static bool Check(object[] a, object x)
  {
        for(int i = 0; i < a.Length; i++) {
      if (a[i].Equals(x)) {
        return true;
      }
    }
    return false;
  }
}