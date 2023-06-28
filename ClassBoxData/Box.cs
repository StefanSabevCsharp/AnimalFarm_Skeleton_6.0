
namespace ClassBoxData
{
    public class Box
    {
        double length;
        double width;
        double height;

        public Box(double lenght, double widht, double height)
        {
            Lenght = lenght;
            Widht = widht;
            Height = height;
        }

        public double Lenght
        {
            get
            {
                return this.length;
            }
           init
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Lenght cannot be zero or negative.");
                }
                this.length = value;
            }
        }
        public double Widht
        {
            get
            {
                return this.width;
            }
            init
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                this.width = value;
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
           init
            {
                if (this.width <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                this.height = value;
            }
        }

        public double SurfaceArea()
        {
            double surfaceArea = 2 * (this.length * this.width) + 2 * (this.length * this.height) + 2 * (this.width * this.height);
            return surfaceArea;
        }
        public double LateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * (this.length * this.height) + 2 * (this.width * this.height);
            return lateralSurfaceArea;
        }
        public double Volume()
        {
            double volume = this.length * this.width * this.height;
            return volume;
        }

    }
}
