int count = 0;
double distance = 150000;
int firstFriendSpeed = 1;
int secondFreinfSpeed = 2;
int dogSpeed = 10;
int friend = 2;
double time = 0;
string propis = "";
while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (dogSpeed + secondFreinfSpeed);
        friend = 1;
    }
    else
    {
        time = distance / (dogSpeed + firstFriendSpeed);
        friend = 2;
    }

    distance = distance - time * (secondFreinfSpeed + firstFriendSpeed);
    count++;
}

if (count % 10 == 2 || count % 10 < 5)
{    
  propis = " раза";
}
else 
{ 
  if (count % 10 == 1 || count % 10 > 4 || count % 10 < 10)
  {
  propis = " раз";
  }
}
Console.Write("Cобака пробежала ");
Console.Write(count);
Console.Write(propis);

