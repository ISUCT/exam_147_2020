using System;

namespace CourseApp
{
public class Drake : Duck, IFly, IQuack
{
public Drake()
{
}

public override string Display()
{
return "Kono Ahiru Da!";
}
}
}