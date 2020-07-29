using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeLog.SQL
{
    enum Naploszint
    {
        Info,
        Figyelmeztetes,
        Hiba
    }

    static class ExeptionLog
    {
        public static void Bejegyzes(string szoveg, Naploszint szint)
        {
            File.AppendAllText("log.txt", $"[{DateTime.Now}][{szint}] - [{szoveg}]" + Environment.NewLine);
        }
        public static void Bejegyzes(Exception ex)
        {
            File.AppendAllText("log.txt", $"[{DateTime.Now}][{Naploszint.Hiba}] - {ex.Message}{Environment.NewLine}{ex.StackTrace}{Environment.NewLine}");
        }
    }
}
