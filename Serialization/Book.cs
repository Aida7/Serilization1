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

    public class Book
    { private int Year { get; set; }
        private int Prise { get; set; }
        private string Auhtor { get; set; }
        private string Name { get; set; }

        public  Book()
        {
            Year = 0;
            Prise = 0;
            Auhtor = " noname";
            Name = "noname";
        }
    }      
}

