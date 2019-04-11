using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribut_Demo
{
    // attribute + TAB + TAB => Automatisch generierte Variante
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property
        ,AllowMultiple =true
        ,Inherited =true)]
    class CustomAttribute : Attribute
    {
        public string Text { get; set; }
    }


    [Custom(Text = "Hallo Welt")] // Schreibweise für Properties in der Attribut-Klasse
    class Person
    {
        // [Custom(Text ="Das ist ein Ctor")]
        public Person()
        {

        }
        [Custom(Text ="Das ist ein Property")]
        [Custom(Text ="Test")]
        [Custom(Text ="Noch mehr Metadaten :) ")]
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public byte Alter { get; set; }
        public decimal Kontostand { get; set; }
    }


}
