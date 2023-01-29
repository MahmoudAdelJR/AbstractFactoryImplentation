using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIColors_AbstractFactoryImplentation.Interfaces
{
    internal abstract class Button
    {
        public string Name { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public ConsoleColor color { get; set; }
        public override string ToString()
        {
            return $"Button--> Os : {Name}, Height = {height}, Width = {width}, Color = {color}";
        }
    }
}
