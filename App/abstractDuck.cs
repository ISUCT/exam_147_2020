using System;

namespace App
{
    public abstract class abstractDuck : IFly, IQuack // от абстрактного класса нельзя сделать экземпляр
    {
        float speedFly = 50.0F;
        public float SpeedFly => speedFly; // св-во доступно только для чтения
        public float Distance { get; set; }
        public virtual string Quack() // доступное для переопределения virtual метод
        {
            return "Кря Кря Кря Кря";
        }
        public static string Swim()
        {
            return "*Звуки плескания в воде*";
        }

        public abstract string Display(); // метод можно вызывать без экземпляра класса
    }
}