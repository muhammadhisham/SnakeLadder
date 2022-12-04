int[] players = new int[4]; //player1: 0, player2: 1 and so one
int currentPlayer = 0;
int funcOut = 0;
while (!Array.Exists(players, x => x == 100))
{
    for (int i = 1; i <= 4; i++)
    {
        currentPlayer = i;
        //Console.WriteLine("Enter steps");
        Random Random = new Random();
        int steps = Random.Next(1, 6);
        funcOut = SnakeLadder(i, steps);
        if (funcOut == 100) break;
    }
}

Console.WriteLine("The winner player is " + currentPlayer);


int SnakeLadder(int player, int steps)
{
    int newVal = 0;
    int currentVal = players[player - 1];

    Dictionary<int, int> snake = new Dictionary<int, int>() {
        { 62,5},{ 33,6},{ 49,9},{ 88,16},{ 41,20},{ 56,53},{ 98,64},{ 93,73},{ 95,75}
    };

    Dictionary<int, int> ladder = new Dictionary<int, int>() {
        { 2,37},{ 27,46},{ 10,32},{ 51,68},{ 61,79},{ 65,84},{ 71,91},{ 81,100}
    };

    int res = players[player - 1] + steps;

    if (res > 100)
    {
        res = players[player - 1];
        Console.WriteLine("player: " + player + " rolles " + steps + " and which is greater than 100 so it stays at " + res);
    }
    else
    {
        if (snake.ContainsKey(res))
        {
            players[player - 1] = snake[res];
        }
        else if (ladder.ContainsKey(res))
        {
            players[player - 1] = ladder[res];
        }
        else
        {
            players[player - 1] += steps;
        }
        newVal = players[player - 1];
        Console.WriteLine("player: " + player + " rolles " + steps + " and moved from " + currentVal + " to " + newVal);
    }

    return players[player - 1];
}

