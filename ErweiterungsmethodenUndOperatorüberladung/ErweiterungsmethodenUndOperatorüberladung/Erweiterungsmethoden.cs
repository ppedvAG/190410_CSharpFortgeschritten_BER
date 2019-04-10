using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErweiterungsmethodenUndOperatorüberladung
{
    // Vorraussetzungen:
    // 1) Statische Klasse
    static class Erweiterungsmethoden
    {
        // 2) this - Schlüsselwort
        public static string Umdrehen(this string input)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--) // forr + TAB + TAB
            {
                sb.Append(input[i]);
            }
            return sb.ToString();
        }
    }
}
