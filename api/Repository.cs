using System;
using System.IO;
namespace Safi
{
    public class Repository
    {   public interface IRepository
        {
            void resume();
        }

        public Repository()
        {
            string instance_object = this.GetType().Name.ToLower();

            string dir = Directory.GetCurrentDirectory() + "/data/" + instance_object ;
            //file_name=
            Console.WriteLine(instance_object);
            // add and map all json request/json files
            _path.Add("resume", dir + "/resume.json");
            _path.Add("detail", dir + "/detail.json");


            foreach (KeyValuePair<string, string> entry in _path)
            {
                Console.WriteLine(entry.Value);
                if (!File.Exists(entry.Value))
                {
                    _path.Remove(entry.Key); 
                }

            }

            string public resume






        }
        private Dictionary<string, string> _path = new Dictionary<string, string>();




        public class Client :  Repository 
        {

            public Client(string request):base()
            {
                

            }
        }


        public class Account : Repository
        {

            public Account(string request) : base()
            {


            }
        }



    }
}

