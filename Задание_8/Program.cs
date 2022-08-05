double dist = 1000,
       time = 0;
int firstFriendSpeed = 1,
    secondFriendSpeed = 2,
    dogSpeed = 10,
    count = 0;

bool directionFirstFriend = true;

while (dist > 10)
{
    if (directionFirstFriend)
    {
        time = dist / (firstFriendSpeed + dogSpeed);
        directionFirstFriend = false;
    }
    else
    {
        time = dist / (secondFriendSpeed + dogSpeed);
        directionFirstFriend = true;
    }
    dist -= (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
}
Console.Write("Собака пробежит " + count + " раз");