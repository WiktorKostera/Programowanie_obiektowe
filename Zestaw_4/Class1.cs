namespace Zestaw_4
{
    internal class Kolo
    {
        private double promien;
        public static int ile = 0;

        public Kolo(double r)
        {
            promien = r;
            ile++;
        }

        public Kolo()
        {
            ile++;
        }
        public static double Obwod(double r)
        {
            double obw = 2 * Math.PI * r;
            return obw;
        }

        public double Obwod()
        {
            double obw = 2 * Math.PI * promien;
            return obw;
        }
    }
    internal class Prostokat
    {
        private double bok1, bok2;

        public Prostokat(double a, double b)
        {
            bok1 = a;
            bok2 = b;
        }

        public Prostokat()
        {
        }


        public double Obwod(double a, double b)
        {
            double obwod = 2 * a + 2 * b;
            return obwod;
        }

        public double Obwod()
        {
            double obwod = 2 * bok1 + 2 * bok2;
            return obwod;
        }
    }
}