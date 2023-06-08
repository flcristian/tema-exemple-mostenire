using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exemple_mostenire.vehicle.model;
using static System.Net.Mime.MediaTypeNames;

namespace exemple_mostenire.vehicle.service
{
    public class VehicleService
    {
        List<Vehicle> _list;

        // Constructors

        public VehicleService()
        {
            this.ReadList();
        }

        public VehicleService(List<Vehicle> list)
        {
            _list = list;
        }

        // Accessors

        public List<Vehicle> List
        {
            get { return _list; }
            set
            {
                _list = value;
            }
        }

        // Methods

        public void ReadList()
        {
            _list = new List<Vehicle>();
            StreamReader sr = new StreamReader("D:\\mycode\\csharp\\mostenirea\\teme\\exemple-mostenire\\exemple-mostenire\\resources\\vehicles.txt");

            while (!sr.EndOfStream)
            {
                string text = sr.ReadLine();
                string type = text.Split('/')[0];

                switch (type)
                {
                    case "Car":
                        Car car = new Car(text);
                        _list.Add(car);
                        break;
                    case "Boat":
                        Boat boat = new Boat(text);
                        _list.Add(boat);
                        break;
                    case "Bicycle":
                        Bicycle bicycle = new Bicycle(text);
                        _list.Add(bicycle);
                        break;
                    case "Plane":
                        Plane plane = new Plane(text);
                        _list.Add(plane);
                        break;
                    case "Helicopter":
                        Helicopter helicopter = new Helicopter(text);
                        _list.Add(helicopter);
                        break;
                    default:
                        break;
                }
            }
            sr.Close();
        }

        public void Afisare()
        {
            foreach (Vehicle vehicle in _list)
            {
                string desc = "";

                switch (vehicle.Type)
                {
                    case "Car":
                        Car car = vehicle as Car;
                        desc = car.CarDescription();
                        break;
                    case "Boat":
                        Boat boat = vehicle as Boat;
                        desc = boat.BoatDescription();
                        break;
                    case "Bicycle":
                        Bicycle bicycle = vehicle as Bicycle;
                        desc = bicycle.BicycleDescription();
                        break;
                    case "Plane":
                        Plane plane = vehicle as Plane;
                        desc = plane.PlaneDescription();
                        break;
                    case "Helicopter":
                        Helicopter helicopter = vehicle as Helicopter;
                        desc = helicopter.HelicopterDescription();
                        break;
                    default:
                        break;
                }

                Console.WriteLine(desc);
            }
        }
    }
}
