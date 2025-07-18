using System;

namespace MyPhotoshop.Data
{
    public struct Pixel
    {
        private double r;
        public double R
        {
            get => r;
            set => r = Chech(value);
        }

        private double g;
        public double G
        {
            get => g;
            set => g = Chech(value);
        }

        private double b;
        public double B
        {
            get => b;
            set => b = Chech(value);
        }

        public Pixel(double r, double g, double b) : this()
        {
            R = r;
            G = g;
            B = b;
        }

        public static Pixel operator*(Pixel pixel, double n)
        {
            return new Pixel(
                pixel.R * n,
                pixel.G * n,
                pixel.B * n);
        }

        private static double Chech(double value)
        {
            if (value < 0 || value > 1)
                throw new ArgumentOutOfRangeException("value");
            return value;
        }
    }
}
