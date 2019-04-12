using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialisierung
{
    // [Serializable]
    [XmlRoot("DieBestePersonDerWelt")]
    public class Person
    {
        [XmlElement("DerVornameIst")]
        public string Vorname { get; set; }
        [XmlAttribute("DerNACHNAME")]
        public string Nachname { get; set; }
        public byte Alter { get; set; }
        [field: NonSerialized]
        public decimal Kontostand { get; set; }

        private bool geschlecht;
    }
}
