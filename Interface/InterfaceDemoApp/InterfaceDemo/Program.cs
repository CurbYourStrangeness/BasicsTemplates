using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {

        //Interface is a contract
        //Classes implement the interface abstraction
        static void Main(string[] args)
        {
            List<IRaceRunner> RaceRunners = new List<IRaceRunner>();

            SerialMurderer murderer = new SerialMurderer();
            BikeMessenger MortalHermes = new BikeMessenger();
            SpaStaffMember Mandy = new SpaStaffMember();
            TeleportMessenger MidLevelHermes = new TeleportMessenger();

            RaceRunners.Add(murderer);
            RaceRunners.Add(MortalHermes);
            RaceRunners.Add(Mandy);

            foreach (IRaceRunner runner in RaceRunners)
            {
                if (runner is BikeMessenger)
                {

                }

                if (runner is SpaStaffMember)
                {

                }

                if (runner is IMessenger handler)
                {
                    handler.MessagesDelivered = 999999999;
                }
            }

            using (SerialMurderer murderThis = new SerialMurderer())
            {

            }

            List<IMessenger> Messengers = new List<IMessenger>();           


            Messengers.Add(MortalHermes);
            Messengers.Add(MidLevelHermes);


            Console.ReadLine();
        }
    }

    public interface IRaceRunner : IDisposable
    {
        void Clean();
    }

    public interface IMessenger
    {
        int MessagesDelivered { get; set; }
    }

    public class SerialMurderer : IRaceRunner
    {
        public virtual void SkullSplit()
        {

        }

        public string Weapon { get; set; }

        public void Clean()
        {

        }

        public void Dispose()
        {
            //The universe does not look favorably upon this creation...
        }
    }


    public class BikeMessenger : IRaceRunner, IMessenger
    {
        public string BikeModel { get; set; }

        public int MilesTraveled { get; set; }

        public int PackagesDelivered { get; set; }

        public int MessagesDelivered { get; set; }

        public void OilChain()
        {

        }

        public void Clean()
        {

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    public class TeleportMessenger : IMessenger
    {
        public int MessagesDelivered { get; set; }

        public int TeleportPoints { get; set; }
    }

    public class SpaStaffMember : SerialMurderer
    {
        public override void SkullSplit()
        {

        }

    }

}
