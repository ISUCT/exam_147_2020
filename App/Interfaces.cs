namespace App
{
    interface IFly
    {
        public float SpeedFly { get; }
        public float Distance { get; set; }
    }
    interface IQuack
    {
        string Quack();
    }
}