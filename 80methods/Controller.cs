using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _80methods
{
    internal class Controller
    {

        static private Menu menu;
        static private ArrList arrList;
        static private Arra array;
        static private HasthTable hash;

        public Controller()
        {
            menu = new Menu();
            arrList = new ArrList();
            array = new Arra();
            hash = new HasthTable();

            switch_to_Main();
        }

        static public void switch_to_Main() { menu.ini(); }
        static public void switch_to_ArrList() { arrList.ini(); }
        static public void switch_to_Arr() { array.ini(); }
        static public void switch_to_HashTable() { hash.ini(); }
    }
}
