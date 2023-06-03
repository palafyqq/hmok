using hmok.Tiles;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hmok.Code
{
    internal class GlobalVar
    {
        public static bool AdministrationMode;
        public static Command listService = new Command();
        public static string MainFolderPicture = "D:\\";
        public static List<TileService> Tiles = new List<TileService>();
    }
}
