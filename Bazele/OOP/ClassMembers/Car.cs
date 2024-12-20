namespace Bazele.OOP.ClassMembers
{
    public class Car
    {
        private string make;

        private string model;

        private int year;

        private double accelerate;

        public double Acceleration
        {
            get
            {
                return accelerate;
            }
            set
            {
                if (value < 0)
                {
                    if (accelerate + value < 0)
                    {
                        accelerate = 0;
                    }
                    else
                    {
                        accelerate += value;
                    }
                }
                else
                {
                    accelerate += value;
                }
            }
        }

        public Car(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

        public Car(Car car)
        {
            make = car.make;
            model = car.model;
            year = car.year;
            accelerate = car.accelerate;
        }

        ~Car()
        {
            Console.WriteLine("Car destroyed");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Make: {make}. Model: {model}. Year: {year}. Acceleration: {accelerate}");
        }

        public void Accelerate(double acceleration)
        {
            accelerate = acceleration;
        }

        public void Brake(double brake)
        {
            if (brake > accelerate)
            {
                Console.WriteLine("Already stopped");
            }
            else
            {
                accelerate -= brake;
            }
        }

        public int GetCarAge()
        {
            var age = DateTime.Now.Year - year;
            Console.WriteLine("Car age is {0}", age);
            return age;
        }
    }
}
