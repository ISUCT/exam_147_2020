using System;

namespace App
{
    public class Duck : abstractDuck
    {
        public string nickname;
        public int age;
        public Duck() { nickname = "Дональд"; age = 10; }

        public override string Quack()
        {
            return "Я переопределился, но против поправок, ведь я умный утенок.";
        }
        public override string Display()
        {
            return "У уток очень хорошее зрение. Они видят лучше людей и собак.\nТакже они воспринимают окружающий мир в полномасштабной цветовой гамме.";
        }


    }
}