using System;
using System.Windows;


namespace EventDemonstrate
{
    //Declare an event argument
    public class CarInfoEventArgs : EventArgs
    {
        public CarInfoEventArgs(string car)
        {
            this.Car = car;
        }
        public string Car { get; private set; }
    }


    //Car Dealer
    public class CarDealer
    {
        //Declare an event
        public event EventHandler<CarInfoEventArgs> NewCarInfo;

        public void NewCar(string car)
        {
            Console.WriteLine("CarDealer, new car {0} arrived", car);
            if (NewCarInfo != null)
            {
                //trigger event when new car arrive
                NewCarInfo(this, new CarInfoEventArgs(car));
            }
        }
    }

    public class Consumer
    {
        private string name;
        public Consumer(string name)
        {
            this.name = name;
        }

        public void NewCarIsHere(object sender, CarInfoEventArgs e)
        {
            Console.WriteLine("{0}: car {1} is new", name, e.Car);
        }
    }

   
}