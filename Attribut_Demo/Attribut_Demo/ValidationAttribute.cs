using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribut_Demo
{
    [AttributeUsage(AttributeTargets.Property)]
    class ValidationAttribute : Attribute
    {
        public int MaxLength { get; set; }
    }
}
