using System;
namespace RemotingSystem
{

    // interfaces
    interface IRemote
    {
        void PowerOn();
        void changeChannel(int channelNumber);
        void ChangeVolume();
    }

    interface IPrice
    {
        double GetPrice();
    }

    // this is we can inherit the multiple interface to one interface
    // like one childinterface inherit multiple based interfaces
    // when we add the child interface to any class that class need to implement and declare the
    // parent interface methods and child interface methods
    interface IRemoteManfacture : IPrice, IRemote
    {
        void GetManfactureDetails();
    }


    // when we add the interface method to class
    // we need to mension the PUBLIC for the class 
    // actualy the interface method in public but when decalaring the class we need to make sure the access - Public

    class SonyRemote : IRemote, IPrice
    {
        public void PowerOn()
        {
            Console.WriteLine($" the sony TV Power is ON");
        }
        public void changeChannel(int channelNumber)
        {
            Console.WriteLine($" the sony TV channel is changed {channelNumber}");

        }

        public void ChangeVolume()
        {
            Console.WriteLine($" the sony TV volume incressed");

        }

        public void presschanel(int channelname)
        {
            Console.WriteLine($" the sony TV pressed channel {channelname}");
        }

        public double GetPrice()
        {
            return 10000.99;
            
        }
    }

    class LGRemote : IRemote
    {
        void IRemote.changeChannel(int channelNumber)
        {
            Console.WriteLine($" the LG TV channel is changed {channelNumber}");
        }

        void IRemote.ChangeVolume()
        {
            Console.WriteLine($" the LG TV volume incressed");
            
        }

        void IRemote.PowerOn()
        {
            Console.WriteLine($" the LG TV Power is ON");
            
        }

       
    }

    class SamsungRemote : IRemoteManfacture
    {
        public void changeChannel(int channelNumber)
        {
            Console.WriteLine($" the Samsung TV channel is changed {channelNumber}");
        }

        public void ChangeVolume()
        {
            Console.WriteLine($" the Samsung TV volume incressed");
        }

        public void GetManfactureDetails()
        {
            Console.WriteLine($" Manfactured : Samsung Electronics");
            Console.WriteLine($" Country : Japan");
        }

        public double GetPrice()
        {
            return 499.99;
        }

        public void PowerOn()
        {
            Console.WriteLine($" the Samsung TV Power is ON");
        }
    }
    class Program
    {
        static void Main()
        {
            // this make we can only call the method we initilised in the interface
            // (there are a lot methods in that class we can't able to call)
            IRemote sony = new SonyRemote();            // importent line  - "interface name" "obj name" = new "chile class name"
            sony.changeChannel(1);                      // we can only select methods we initilised in the INTERFACE
            sony.ChangeVolume();
            sony.PowerOn();
            Console.WriteLine("...................................................");
            IPrice sonyPrice = new SonyRemote();
            double sonyremoteprice = sonyPrice.GetPrice();
            Console.WriteLine($" the Sony remote price is {sonyremoteprice}");



            Console.WriteLine("...................................................");
            IRemote LG = new LGRemote();
            LG.changeChannel(1);
            LG.ChangeVolume();
            LG.PowerOn();
            Console.WriteLine("...................................................");


            //new SamsungRemote();        // this class have 3 interface - IPrice,IRemote,IRemoteManfacture so
            Console.WriteLine(".........................only price..........................");
            // if need to call only price then

            IPrice samsungremoteprice = new SamsungRemote();
            samsungremoteprice.GetPrice();

            Console.WriteLine(".........................only remote..........................");
            // if need to call only remote settings then

            IRemote samsungremotesettings = new SamsungRemote();
            samsungremotesettings.changeChannel(1);
            samsungremotesettings.ChangeVolume();
            samsungremotesettings.PowerOn();

            Console.WriteLine(".........................all interface methods and manfacture things..........................");
            // if need to call all interface methods and manfacture things then
            IRemoteManfacture samsungremoteDetails = new SamsungRemote();
            samsungremoteDetails.changeChannel(1);
            samsungremoteDetails.ChangeVolume();
            samsungremoteDetails.PowerOn();
            samsungremoteDetails.GetManfactureDetails();
            samsungremoteDetails.GetPrice();
        }

    }
}
