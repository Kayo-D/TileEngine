public class Level2
{
    public string[,] mapData = new string[,] {
        {"0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0"},
        {"0,1,1,1,1,0,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,1,0,1,1,1,0,0,0,0,0,0,0"},
        {"0,1,1,1,1,1,1,1,1,1,0,1,0,1,1,1,1,0,0,1,0,1,1,0,1,1,1,0,0,0,0,0,0,0"},
        {"0,1,1,1,1,0,1,1,1,1,0,1,1,1,1,1,1,0,0,1,0,1,1,0,1,1,1,0,0,0,0,0,0,0"},
        {"0,1,1,1,1,0,0,0,0,0,0,0,0,1,1,0,0,0,0,1,0,0,0,0,1,1,1,0,0,0,0,0,0,0"},
        {"0,0,0,1,0,0,0,0,0,0,0,0,0,1,1,0,0,0,0,1,0,0,0,0,1,1,1,0,0,0,0,0,0,0"},
        {"0,0,0,1,1,1,1,1,0,0,0,0,0,1,1,0,0,0,0,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0"},
        {"0,0,0,1,0,0,0,1,0,0,0,0,0,1,1,0,0,0,0,1,1,1,1,0,1,1,1,0,0,0,0,0,0,0"} };
    public int playerStartPosX = 1;
    public int playerStartPosY = 1;
    public int mapWidth = 34;
    public int mapHeight = 15;
}