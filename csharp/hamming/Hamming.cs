class Hamming
{
    public static int Compute(string str1, string str2)
    {
        int dist = 0;
        for (int i = 0; i < str1.Length; i++) {
            if (str1[i] != str2[i]) dist++;
        }
        return dist;
    }
}
