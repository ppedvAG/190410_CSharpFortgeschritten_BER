using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TinyEd.Models.Interfaces;

namespace TinyEd.Models.Services
{
    public class WPFMessageService : IMessageService
    {
        public void SendMessage(string content) => MessageBox.Show(content);
    }
}
