using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatenUndEvents
{
    class Button
    {
        // Variante "lang"
        //private Action click;
        //public event Action ClickEvent
        //{
        //    add
        //    {
        //        click += value;
        //    }
        //    remove
        //    {
        //        click -= value;
        //    }
        //}

        public event Action ClickEvent;
        public void Click()
        {
            #region NullConditional-Operator
            //Action c = Clicked;
            //if(c != null)
            //{
            //    c.Invoke();
            //}
            // Lange Objekte
            // if(person != null && person.GanzerName != null && person.GanzerName.Vorname != null)
            // => wird zu :
            // if(person?.GanzerName?.Vorname != null) 
            #endregion

            ClickEvent?.Invoke();
        }
    }
}
