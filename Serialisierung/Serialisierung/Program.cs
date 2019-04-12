using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialisierung
{
    class Program
    {
        static void Main(string[] args)
        {
            // Binär
            // XML
            // JSON (.NET, Newtonsoft.JSON)

            // XML kommt auch mit diesen lustigen Zeichen zurecht ;)
            Person p1 = new Person { Vorname = "T>o < ẞ m Zöhling ß 👿''' \" ", Nachname = "At & & 😘😘😘😘😘 e<?php echo asdf/>", Alter = 10, Kontostand = 1000 };

            #region Binär
            //// Serialisieren
            //FileStream stream = new FileStream("person.bin", FileMode.Create);
            //BinaryFormatter formatter = new BinaryFormatter();
            //formatter.Serialize(stream, p1);
            //// so viele sachen wie wir wollen hintereinander mit .Serialize in die selbe Datei hineinschreiben
            //stream.Flush();
            //stream.Close();

            //// Deserialisieren
            //stream = new FileStream("person.bin", FileMode.Open);
            //Person p1_deserialisiert = (Person)formatter.Deserialize(stream); // Bei vielen Dateien wie eine Queue
            //stream.Close();

            //Console.WriteLine(p1_deserialisiert.Vorname);
            //Console.WriteLine(p1_deserialisiert.Nachname);
            //Console.WriteLine(p1_deserialisiert.Kontostand); 
            #endregion

            #region XML
            //// XML - Limitierungen
            //// 1) Klasse muss public sein
            //// 2) Klasse darf nur public member haben (Properties, Methoden usw...)
            //// 3) Wenn man Properties hat, müssen die Get; UND Set; haben (sprich: keine readonly properties)
            //// 4) parameterloser Konstruktor zwingend erforderlich

            //// Serialisieren
            //FileStream stream = new FileStream("person.xml", FileMode.Create);
            //XmlSerializer formatter = new XmlSerializer(typeof(Person));
            //formatter.Serialize(stream, p1);

            //stream.Flush();
            //stream.Close();

            //// Deserialisieren
            //stream = new FileStream("person.xml", FileMode.Open);
            //Person p1_deserialisiert = (Person)formatter.Deserialize(stream);
            //stream.Close();

            //Console.WriteLine(p1_deserialisiert.Vorname);
            //Console.WriteLine(p1_deserialisiert.Nachname);
            //Console.WriteLine(p1_deserialisiert.Kontostand); 
            #endregion

            //string json = JsonConvert.SerializeObject(p1);
            //Console.WriteLine(json);

            //Person p2 = JsonConvert.DeserializeObject<Person>(json);

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine(p2.Vorname);
            //Console.WriteLine(p2.Nachname);
            //Console.WriteLine(p2.Alter);
            //Console.WriteLine(p2.Kontostand);

            // REST-API
            using (HttpClient client = new HttpClient())
            {
                string json = client.GetStringAsync(@"https://jsonplaceholder.typicode.com/todos").Result;
                ToDoItem[] items = JsonConvert.DeserializeObject<ToDoItem[]>(json);
            }

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
