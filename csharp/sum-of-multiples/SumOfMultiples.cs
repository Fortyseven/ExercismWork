using System;

public class SumOfMultiples
{
    public static int To(int[] multiples_of, int upto)
    {
        int total = 0;

        for (int i = 1; i < upto; i++) {
            bool valid = false;
            foreach (int mult in multiples_of) {
                if ((i % mult) == 0) { valid = true; break; }
            }
            if (valid) {
                total += i;
            }
        }

        return total;
    }
}