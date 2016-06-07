using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProductManager
{
    public partial class MainWindow : Form
    {
        private List<Car> lCars;
        private List<Truck> lTrucks;
        private List<Motorcycle> lMotorcycles;
        private List<Bike> lBikes;
        public MainWindow()
        {
            InitializeComponent();


            lCars = new List<Car>();
            lTrucks = new List<Truck>();
            lMotorcycles = new List<Motorcycle>();
            lBikes = new List<Bike>();

        }

        private void addCar(object sender, EventArgs e)
        {
            Car c = new Car();

            c.name = boxName.Text;
            c.no_wheels = Convert.ToUInt16(boxWheels.Text);
            c.wheel_right = Convert.ToBoolean(boxWheelRight.Checked);
            c.price = Convert.ToUInt16(boxPrice.Text);
            c.engine = new Engine(
                                boxTypeEngine.Text,
                                Convert.ToDouble(boxCapacity.Text),
                                Convert.ToUInt16(boxHorsepower.Text),
                                Convert.ToUInt16(boxMilage.Text));
            lCars.Add(c);
            listCars.Items.Add(c.name);
        }

        private void addTruck(object sender, EventArgs e)
        {
            Truck c = new Truck();

            c.name = boxName.Text;
            c.no_wheels = Convert.ToUInt16(boxWheels.Text);
            c.wheel_right = Convert.ToBoolean(boxWheelRight.Checked);
            c.price = Convert.ToUInt16(boxPrice.Text);
            c.no_wheels = Convert.ToUInt16(boxPrice.Text);
            c.max_load = Convert.ToUInt16(boxPrice.Text);
            c.engine = new Engine(
                                boxTypeEngine.Text,
                                Convert.ToDouble(boxCapacity.Text),
                                Convert.ToUInt16(boxHorsepower.Text),
                                Convert.ToUInt16(boxMilage.Text));
            lTrucks.Add(c);
            listTrucks.Items.Add(c.name);
        }

        private void addBicycle(object sender, EventArgs e)
        {
            Bike c = new Bike();

            c.name = boxName.Text;
            c.no_wheels = Convert.ToUInt16(boxWheels.Text);
            c.wheel_right = Convert.ToBoolean(boxWheelRight.Checked);
            c.price = Convert.ToUInt16(boxPrice.Text);
            c.gears = Convert.ToUInt16(boxGears.Text);
            c.has_engine = false;

            lBikes.Add(c);
            listBicycles.Items.Add(c.name);
        }

        private void addMotorcycle(object sender, EventArgs e)
        {
            Motorcycle c = new Motorcycle();

            c.name = boxName.Text;
            c.no_wheels = Convert.ToUInt16(boxWheels.Text);
            c.wheel_right = Convert.ToBoolean(boxWheelRight.Checked);
            c.price = Convert.ToUInt16(boxPrice.Text);
            c.type = boxMotorcycleType.Text;

            c.engine = new Engine(
                                boxTypeEngine.Text,
                                Convert.ToDouble(boxCapacity.Text),
                                Convert.ToUInt16(boxHorsepower.Text),
                                Convert.ToUInt16(boxMilage.Text));
            lMotorcycles.Add(c);
            listMotorcycles.Items.Add(c.name);
        }

        private void readAll()
        {
            try
            {
                var vcars = XDocument.Load(DataManager.DATA_FILE_NAME).Element("vehicles").Element("cars").Descendants("car").Select(
                    car => new Car()
                    {
                        name = car.Attribute("name").Value,
                        no_wheels = Convert.ToUInt16(car.Element("no_wheels").Value),
                        wheel_right = Convert.ToBoolean(car.Element("wheel_right").Value),
                        has_engine = Convert.ToBoolean(car.Element("has_engine").Value),
                        price = Convert.ToUInt16(car.Element("price").Value),
                        engine = new Engine(
                                car.Element("engine").Attribute("type").Value,
                                Convert.ToDouble(car.Element("engine").Attribute("capacity").Value),
                                Convert.ToUInt16(car.Element("engine").Attribute("horsepower").Value),
                                Convert.ToUInt16(car.Element("engine").Attribute("milage").Value))

                    }).ToList();
                lCars = new List<Car>(vcars);
                var vtrucks = XDocument.Load(DataManager.DATA_FILE_NAME).Element("vehicles").Element("trucks").Descendants("truck").Select(
                    truck => new Truck()
                    {
                        name = truck.Attribute("name").Value,
                        no_wheels = Convert.ToUInt16(truck.Element("no_wheels").Value),
                        wheel_right = Convert.ToBoolean(truck.Element("wheel_right").Value),
                        has_engine = Convert.ToBoolean(truck.Element("has_engine").Value),
                        price = Convert.ToUInt16(truck.Element("price").Value),
                        max_load = Convert.ToUInt16(truck.Element("max_load").Value),
                        no_trailers = Convert.ToUInt16(truck.Element("no_trailers").Value),
                        engine = new Engine(
                                truck.Element("engine").Attribute("type").Value,
                                Convert.ToDouble(truck.Element("engine").Attribute("capacity").Value),
                                Convert.ToUInt16(truck.Element("engine").Attribute("horsepower").Value),
                                Convert.ToUInt16(truck.Element("engine").Attribute("milage").Value))

                    }).ToList();
                lTrucks = new List<Truck>(vtrucks);
                var vmotorcycles = XDocument.Load(DataManager.DATA_FILE_NAME).Element("vehicles").Element("motorcycles").Descendants("motorcycle").Select(
                    motorcycle => new Motorcycle()
                    {
                        name = motorcycle.Attribute("name").Value,
                        no_wheels = Convert.ToUInt16(motorcycle.Element("no_wheels").Value),
                        wheel_right = Convert.ToBoolean(motorcycle.Element("wheel_right").Value),
                        has_engine = Convert.ToBoolean(motorcycle.Element("has_engine").Value),
                        price = Convert.ToUInt16(motorcycle.Element("price").Value),
                        type = motorcycle.Element("type").Value,
                        engine = new Engine(
                                motorcycle.Element("engine").Attribute("type").Value,
                                Convert.ToDouble(motorcycle.Element("engine").Attribute("capacity").Value),
                                Convert.ToUInt16(motorcycle.Element("engine").Attribute("horsepower").Value),
                                Convert.ToUInt16(motorcycle.Element("engine").Attribute("milage").Value))

                    }).ToList();
                lMotorcycles = new List<Motorcycle>(vmotorcycles);
                var vbikes = XDocument.Load(DataManager.DATA_FILE_NAME).Element("vehicles").Element("bikes").Descendants("bike").Select(
                    bike => new Bike()
                    {
                        name = bike.Attribute("name").Value,
                        no_wheels = Convert.ToUInt16(bike.Element("no_wheels").Value),
                        wheel_right = Convert.ToBoolean(bike.Element("wheel_right").Value),
                        has_engine = Convert.ToBoolean(bike.Element("has_engine").Value),
                        price = Convert.ToUInt16(bike.Element("price").Value),
                        gears = Convert.ToUInt16(bike.Element("gears").Value)

                    }).ToList();
                lBikes = new List<Bike>(vbikes);


                foreach (Car v in lCars)
                {
                    listCars.Items.Add(v.name);
                }
                foreach (Truck v in lTrucks)
                {
                    listTrucks.Items.Add(v.name);
                }
                foreach (Motorcycle v in lMotorcycles)
                {
                    listMotorcycles.Items.Add(v.name);
                }
                foreach (Bike v in lBikes)
                {
                    listBicycles.Items.Add(v.name);
                }
            }
            catch (Exception exc)
            {
                throw new Exception("Sorry, error ocurred: " + exc.Message);
            }
            finally
            {
            }
        }

        private void writeAll()
        {
            try
            {
                XDocument document = new XDocument(new XDeclaration("1.0", "utf8", "yes"), new XComment("Modification timestamp : " + DateTime.Now));
                XElement allvehicles = new XElement("vehicles");
                XElement carsElement = new XElement("cars");
                XElement trucksElement = new XElement("trucks");
                XElement motorcyclesElement = new XElement("motorcycles");
                XElement bikesElement = new XElement("bikes");
                foreach (Car veh in lCars)
                {
                    carsElement.Add(new XElement("car",
                        new XAttribute("name", veh.name),
                        new XElement("no_wheels", veh.no_wheels),
                        new XElement("wheel_right", veh.wheel_right),
                        new XElement("price", veh.price),
                        new XElement("_vType", veh.getVType()),
                        new XElement("has_engine", veh.has_engine),
                        new XElement("engine",
                            new XAttribute("type", veh.engine.type),
                            new XAttribute("capacity", veh.engine.capacity),
                            new XAttribute("horsepower", veh.engine.horsepower),
                            new XAttribute("milage", veh.engine.milage)
                    )));
                }
                foreach (Truck veh in lTrucks)
                {
                    trucksElement.Add(new XElement("truck",
                        new XAttribute("name", veh.name),
                        new XElement("no_wheels", veh.no_wheels),
                        new XElement("wheel_right", veh.wheel_right),
                        new XElement("price", veh.price),
                        new XElement("_vType", veh.getVType()),
                        new XElement("no_trailers", veh.no_trailers),
                        new XElement("max_load", veh.max_load),
                        new XElement("has_engine", veh.has_engine),
                        new XElement("engine",
                            new XAttribute("type", veh.engine.type),
                            new XAttribute("capacity", veh.engine.capacity),
                            new XAttribute("horsepower", veh.engine.horsepower),
                            new XAttribute("milage", veh.engine.milage)
                    )));
                }
                foreach (Motorcycle veh in lMotorcycles)
                {
                    motorcyclesElement.Add(new XElement("motorcycle",
                        new XAttribute("name", veh.name),
                        new XElement("no_wheels", veh.no_wheels),
                        new XElement("wheel_right", veh.wheel_right),
                        new XElement("price", veh.price),
                        new XElement("_vType", veh.getVType()),
                        new XElement("type", veh.type),
                        new XElement("has_engine", veh.has_engine),
                        new XElement("engine",
                            new XAttribute("type", veh.engine.type),
                            new XAttribute("capacity", veh.engine.capacity),
                            new XAttribute("horsepower", veh.engine.horsepower),
                            new XAttribute("milage", veh.engine.milage)
                    )));
                }
                foreach (Bike veh in lBikes)
                {
                    bikesElement.Add(new XElement("bike",
                        new XAttribute("name", veh.name),
                        new XElement("no_wheels", veh.no_wheels),
                        new XElement("wheel_right", veh.wheel_right),
                        new XElement("price", veh.price),
                        new XElement("_vType", veh.getVType()),
                        new XElement("gears", veh.gears),
                        new XElement("has_engine", veh.has_engine)
                    ));
                }
                allvehicles.Add(carsElement);
                allvehicles.Add(trucksElement);
                allvehicles.Add(motorcyclesElement);
                allvehicles.Add(bikesElement);
                document.Add(allvehicles);
                document.Save(DataManager.DATA_FILE_NAME);
            }
            catch (Exception exc)
            {
                throw new Exception("Sorry, error ocurred: " + exc.Message);
            }
            finally
            {
            }
        }

        private void write(object sender, EventArgs e)
        {
            writeAll();
        }

        private void load(object sender, EventArgs e)
        {
            readAll();
        }

        private void listCars_SelectedIndexChanged(object sender, EventArgs e)
        {

            Car selected = lCars[listCars.SelectedIndex];


            boxName.Text = selected.name;
            boxWheels.Text = selected.no_wheels.ToString();
            boxWheelRight.Text = selected.wheel_right.ToString();
            boxPrice.Text = selected.price.ToString();
            boxTypeEngine.Text = selected.engine.type.ToString();
            boxCapacity.Text = selected.engine.capacity.ToString();
            boxHorsepower.Text = selected.engine.horsepower.ToString();
            boxMilage.Text = selected.engine.milage.ToString();
        }

        private void listTrucks_SelectedIndexChanged(object sender, EventArgs e)
        {

            Truck selected = lTrucks[listTrucks.SelectedIndex];


            boxName.Text = selected.name;
            boxWheels.Text = selected.no_wheels.ToString();
            boxWheelRight.Text = selected.wheel_right.ToString();
            boxPrice.Text = selected.price.ToString();
            boxLoad.Text = selected.max_load.ToString();
            boxTrailors.Text = selected.no_trailers.ToString();
            boxTypeEngine.Text = selected.engine.type.ToString();
            boxCapacity.Text = selected.engine.capacity.ToString();
            boxHorsepower.Text = selected.engine.horsepower.ToString();
            boxMilage.Text = selected.engine.milage.ToString();
        }

        private void listBicycles_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bike selected = lBikes[listBicycles.SelectedIndex];


            boxName.Text = selected.name;
            boxWheels.Text = selected.no_wheels.ToString();
            boxWheelRight.Text = selected.wheel_right.ToString();
            boxPrice.Text = selected.price.ToString();
            boxGears.Text = selected.gears.ToString();
        }

        private void listMotorcycles_SelectedIndexChanged(object sender, EventArgs e)
        {

            Motorcycle selected = lMotorcycles[listMotorcycles.SelectedIndex];


            boxName.Text = selected.name;
            boxWheels.Text = selected.no_wheels.ToString();
            boxWheelRight.Text = selected.wheel_right.ToString();
            boxPrice.Text = selected.price.ToString();
            boxMotorcycleType.Text = selected.type.ToString();
            boxTypeEngine.Text = selected.engine.type.ToString();
            boxCapacity.Text = selected.engine.capacity.ToString();
            boxHorsepower.Text = selected.engine.horsepower.ToString();
            boxMilage.Text = selected.engine.milage.ToString();
        }
    }
}
