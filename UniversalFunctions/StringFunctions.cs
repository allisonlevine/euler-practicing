namespace UniversalFunctions{
    public static class StringFunctions{
        public static bool ThatsAPal(string newNumber, int start, int numbLength)
        {
            while (start < numbLength)
            {
                if (newNumber[start] != newNumber[numbLength])
                {
                    return false;
                }
                start++;
                numbLength--;
            }
            return true;
        }
    }
}