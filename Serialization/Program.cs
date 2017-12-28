using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Book> listPerson = new List<Book>();

            XmlSerializer formater = new XmlSerializer(typeof(List<Book>));
            
            using (FileStream straem = new FileStream(@"c:\csv.bin", FileMode.OpenOrCreate))
            {
               
                formater.Serialize(straem, listPerson);
            }
            using (FileStream straem = new FileStream(@"c:\csv.bin", FileMode.OpenOrCreate))
            {
                Book gettingOrder = formater.Deserialize(straem) as Book;
            }
            string data = JsonConvert.SerializeObject(listPerson);
            var newOrder = JsonConvert.DeserializeObject<List<Book>>(data);

        }
    }
}
