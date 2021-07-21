using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dp_task1
{


    //abstract class Logistic
    //{
    //    public abstract IVehicle CreateTransport();
    //}

    //class RoadLogistics : Logistic
    //{
    //    public override IVehicle CreateTransport()
    //    {
    //        return new Truck();
    //    }
    //}

    //class SeaLogistics : Logistic
    //{
    //    public override IVehicle CreateTransport()
    //    {
    //        return new Ship();
    //    }
    //}

    //class AirLogistics : Logistic
    //{
    //    public override IVehicle CreateTransport()
    //    {
    //        return new Airplane();
    //    }
    //}


//    interface IChair
//    {
//        bool sitOn();
//        bool haslegs();
//    }
//    class ArdecoChair : IChair
//    {
//        public bool haslegs()
//        {
//            return true;
//        }

//        public bool sitOn()
//        {
//            return true;
//        }
//    }
//    class ModernChair : IChair
//    {
//        public bool haslegs()
//        {
//            return true;
//        }

//        public bool sitOn()
//        {
//            return true;
//        }
//    }
//    class VictorianChair : IChair
//    {
//        public bool haslegs()
//        {
//            return false;
//        }

//        public bool sitOn()
//        {
//            return true;
//        }
//    }
//    interface ITable
//    {
//        bool sitOn();
//        bool haslegs();
//    }
//    class ArdecoTable : ITable
//    {
//        public bool haslegs()
//        {
//            return false;
//        }

//        public bool sitOn()
//        {
//            return true;
//        }
//    }
//    class ModernTable : ITable
//    {
//        public bool haslegs()
//        {
//            return true;
//        }
//        public bool sitOn()
//        {
//            return true;
//        }
//    }
//    class VictorianTable : ITable
//    {
//        public bool haslegs()
//        {
//            return false;
//        }

//        public bool sitOn()
//        {
//            return true;
//        }
//    }
//    interface ISofa
//    {
//        bool sitOn();
//        bool haslegs();
//    }
//    class ArdecoSofa : ISofa
//    {
//        public bool haslegs()
//        {
//            return false;
//        }

//        public bool sitOn()
//        {
//            return true;
//        }
//    }
//    class ModernSofa : ISofa
//    {
//        public bool haslegs()
//        {
//            return true;
//        }
//        public bool sitOn()
//        {
//            return true;
//        }
//    }
//    class VictorianSofa : ISofa
//    {
//        public bool haslegs()
//        {
//            return false;
//        }

//        public bool sitOn()
//        {
//            return true;
//        }
//    }
//    interface IFurnitureFactory
//    {
//        IChair createChair();
//        ITable createTable();
//        ISofa createSofa();
//        void Show();
//    }
//    class ModernFurniture : IFurnitureFactory
//    {
//        public IChair createChair()
//        {
//            return new ModernChair();
//        }

//        public ISofa createSofa()
//        {
//            return new ModernSofa();
//        }

//        public ITable createTable()
//        {
//            return new ModernTable();
//        }

//        public void Show()
//        {
//            Console.WriteLine("Modern");
//        }
//    }
//    class VictorinaFurniture : IFurnitureFactory
//    {
//        public IChair createChair()
//        {
//            return new VictorianChair();
//        }

//        public ISofa createSofa()
//        {
//            return new VictorianSofa();
//        }

//        public ITable createTable()
//        {
//            return new VictorianTable();
//        }

//        public void Show()
//        {
//            Console.WriteLine("Victorina");
//        }
//    }
//    class ArdecoFurniture : IFurnitureFactory
//    {
//        public IChair createChair()
//        {
//            return new ArdecoChair();
//        }

//        public ISofa createSofa()
//        {
//            return new ArdecoSofa();
//        }
//        public ITable createTable()
//        {
//            return new ArdecoTable();
//        }

//        public void Show()
//        {
//            Console.WriteLine("Ardeco");
//        }
//    }

//    class Controller
//    {
//        public void Run()
//        {
//            VictorinaFurniture furniture = new VictorinaFurniture();
//            furniture.Show();
//            ArdecoFurniture ardeco = new ArdecoFurniture();
//            ardeco.Show();
//            ModernFurniture modern = new ModernFurniture();
//            modern.Show();
//        }

//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Controller controller = new Controller();
//            controller.Run();
//        }
//    }
//}

interface IGUIFactory
    {
         Button CreateButton();
         CheckBox CreateCheckBox();
                void Show();

    }
    class WinFactory : IGUIFactory
    {
        public Button CreateButton()
        {
            return new WinButton();
        }

        public CheckBox CreateCheckBox()
        {
            return new WinCheckBox();
        }

        public void Show()
        {
            Console.WriteLine($"Win Factory");
        }
    }
    class MacFactory : IGUIFactory
    {
        public Button CreateButton()
        {
            return new MacButton();
        }

        public CheckBox CreateCheckBox()
        {
            return new MacCheckBox();
        }

        public void Show()
        {
            Console.WriteLine("mac factory");
        }
    }

  
    abstract class Button
    {
        public abstract  void Show();
    }
    class WinButton : Button
    {
        public override void Show()
        {
            Console.WriteLine("Win button");
        }
    }
    class MacButton : Button
    {
        public override void Show()
        {
            Console.WriteLine("mac button");

        }
    }
    abstract class CheckBox
    {
        public abstract void Show();

    }
    class WinCheckBox : CheckBox
    {
        public override void Show()
        {
            Console.WriteLine("win  checkbox");

        }
    }
    class MacCheckBox : CheckBox
    {
        public override void Show()
        {
            Console.WriteLine("mac checkbox");
        }
    }
     class Application
    {
      public  static void control()
        {
        IGUIFactory Factory;
            Console.WriteLine("Mac select 1 : ");
            Console.WriteLine("Win select  2 : ");
            int select = int.Parse(Console.ReadLine());
            if (select == 1)
            {
                Console.WriteLine(" Button select 1 : ");
                Console.WriteLine(" Chechkbox  select  2 : ");
                int select2 = int.Parse(Console.ReadLine());

                if (select2 == 1)
                {
                    Factory = new MacFactory ();
                    Factory.CreateButton().Show(); ;
                 
                }
                else if (select2 == 2)
                {
                    Factory = new MacFactory();
                    Factory.CreateCheckBox().Show(); ;
                 

                }
            }
            else if (select == 2)
            {

                Console.WriteLine(" Button select 1 : ");
                Console.WriteLine(" Chechkbox  select  2 : ");
                int select2 = int.Parse(Console.ReadLine());

                if (select2 == 1)
                {
                    Factory = new WinFactory();
                    Factory.CreateButton().Show(); ;

                }
                else if (select2 == 2)
                {
                    Factory = new MacFactory();
                    Factory.CreateCheckBox().Show(); ;


                }
            }
           
            //var vehicle = logistic.CreateTransport();
            //vehicle.deliver();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Application.control();
        }
    }

}
