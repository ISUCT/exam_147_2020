namespace App
{
    interface IFly
    {
        string FlightDirection(); // куда летят
        int Count { get; set; } // число уток
    }
    interface IQuack
    {
        string PlaceOfLiving(); //где обитает
    }
}