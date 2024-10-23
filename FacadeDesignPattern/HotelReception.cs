using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{
    internal class HotelReception
    {
        public void GetIndianMenu()
        {
            IHotel indHotel = new IndianHotel();
            IMenu menu = indHotel.GetMenu();
            menu.DisplayMenu();
        }
        public void GetItalianMenu()
        {
            IHotel italianHotel = new ItalianHotel();
            IMenu menu= italianHotel.GetMenu();  
            menu.DisplayMenu();
        }
        public void GetChineseMenu()
        {
            IHotel chineseMenu = new ChineseHotel();
            IMenu menu= chineseMenu.GetMenu();  
            menu.DisplayMenu();
        }

    }
}
