using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialisierung
{
    class ToDoItem
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        [JsonProperty("completed")]
        public bool Fertig { get; set; }


    }
}
