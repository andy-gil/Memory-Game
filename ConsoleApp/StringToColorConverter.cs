using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public static class StringToColorConverter
    {
        public static Colors Convert(string color)
        {
            switch (color.ToLower())
            {
                case "red":
                    return Colors.red;
                case "blue":
                    return Colors.blue;
                case "green":
                    return Colors.green;
                case "yellow":
                    return Colors.yellow;
                default:
                    return Colors.unknown;
            }
        }
    }
}
