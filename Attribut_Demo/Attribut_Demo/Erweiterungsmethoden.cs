using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Attribut_Demo
{
    static class Erweiterungsmethoden
    {
        public static bool Validate(this Person p)
        {
            foreach (PropertyInfo propInfo in p.GetType().GetProperties())
            {
                foreach (ValidationAttribute rule in propInfo.GetCustomAttributes().Where(x => x is ValidationAttribute))
                {
                    string value = (string)propInfo.GetValue(p);
                    if (value.Length > rule.MaxLength)
                        return false;
                }
            }
            return true;
        }
    }
}
