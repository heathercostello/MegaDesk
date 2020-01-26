using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Costello
{
    class Desk
    {
        public double Width { get; set; }
        public double Depth { get; set; }
        public int Drawers { get; set; }
        public string material { get; set; }
        public enum DesktopMaterials
        {
            Oak = 200,
            Laminate = 100,
            Pine = 50,
            Rossewood = 300,
            Veneer = 125
        };

        public int size { get; set; }

        //Desk Constraints
        public const double MINWIDTH = 24;
        public const double MAXWIDTH = 96;
        public const double MINDEPTH = 12;
        public const double MAXDEPTH = 48;
    }


}
