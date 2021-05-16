namespace CSharpAlgos
{
    public static class RecursionIntro
    {
        public static int SumRange(int num)
        {
            if (num == 1) return 1;
            return num + SumRange(num - 1);
        }

        public static int Factorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }

            return num * Factorial(num - 1);
        }
    }
}