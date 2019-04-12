using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyEd.Models.Interfaces
{
    public interface IMessageService
    {
        void SendMessage(string content);
    }
}
