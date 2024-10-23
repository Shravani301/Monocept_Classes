namespace FacadeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HotelReception hotelReception = new HotelReception();
            hotelReception.GetItalianMenu();
            hotelReception.GetIndianMenu();
            hotelReception.GetChineseMenu();
        }
    }
}
