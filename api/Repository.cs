using System;
using System.IO;
namespace Safi
{
    public class Repository
    {   public interface IRepository
        {
            void resume();
        }
        
        private Dictionary<string, string> _path = new Dictionary<string, string>();

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
        }// contructor
        
      
        public void get(string command) 
       {     string specs_file ;
            if (_path.ContainsKey(command))  
                {
                specs_file=_path[command];
                    using (StreamReader r = new StreamReader(specs_file))
                     {
                        string json = r.ReadToEnd();
                        //source = JsonSerializer.Deserialize<List<Person>>(json);
                        Root routine = JsonConvert.DeserializeObject<Root>(json);
                     }

                }


           

            
            
        }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Detail
        {
            public string routine { get; set; }
            public string output { get; set; }
            public List<Parameter> parameters { get; set; }
        }

        public class Parameter
        {
            public int order { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public string @default { get; set; }
            public bool required { get; set; }
        }

        public class Root
        {
            public string command { get; set; }
            public Detail detail { get; set; }
        }







    } // class repository







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

