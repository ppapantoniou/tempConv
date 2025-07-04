namespace tempConvLib
{
    public static class tempConverter
    {
        public static double CtoF(double c)
        {
            double outputTemp = (c * 9 / 5) + 32;
            return Math.Round(outputTemp, 1);
        }
        public static double FtoC(double f)
        {
            double outputTemp = (f - 32) * 5 / 9;
            return Math.Round(outputTemp, 1);
        }
        public static double CtoK(double c)
        {
            double outputTemp = c + 273.15;
            return Math.Round(outputTemp, 2);
        }
        public static double KtoC(double k)
        {
            double outputTemp = k - 273.15;
            return Math.Round(outputTemp, 1);
        }
        public static double FtoK(double f)
        {
            double outputTemp = CtoK(FtoC(f));
            return Math.Round(outputTemp, 2);
        }
        public static double KtoF(double k)
        {
            double outputTemp = CtoF(KtoC(k));
            return Math.Round(outputTemp, 1);
        }
    }
}
