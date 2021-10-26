using System;

int count = 0;
int distance = 10000;
int first_friend_speed = 1;
int second_friend_speed = 2;
int dog_speed = 5;
int friend = 2;
int time = 0;


while(distance > 5)

    if(friend == 1)
    {
        time(Double) = distance / (second_friend_speed + dog_speed);
    }
    else
    {
        time(Double) = distance / (first_friend_speed + dog_speed);
    }

int distance = distance / (first_friend_speed + second_friend_speed) * time(Double);
count++;

Console.WriteLine(count);