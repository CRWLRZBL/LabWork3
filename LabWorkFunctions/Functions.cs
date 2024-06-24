namespace LabWorkFunctions
{
    public static class Functions
    {
        public static int GetFactorial(int n)
        {
            if (n < 0)
            {
                return 0;
            }
            if (n == 0)
            {
                return 1;
            }
            return n * GetFactorial(n - 1);
        }

        public static double GetPower(double x, int n)
        {
            if (n < 0)
            {
                return 1 / GetPower(x, -n);
            }
            if (n == 0)
            {
                return 1;
            }
            return (double)x * GetPower(x, n - 1);
        }
    }
}
