public class LevelManager
{
    public int playerStartPosX;
    public int playerStartPosY;
    public int mapWidth;
    public int mapHeight;
    public string[,] levelData = new string[,] {};
    public void SelectLevel(int levelID)
    {
        if(levelID == 1)
        {
            Level1 level1 = new Level1();
            levelData = level1.mapData;
            mapWidth = level1.mapWidth;
            mapHeight = level1.mapHeight;
            playerStartPosX = level1.playerStartPosX;
            playerStartPosY = level1.playerStartPosY;
        }
        if(levelID == 2)
        {
            Level2 level2 = new Level2();
            levelData = level2.mapData;
            mapWidth = level2.mapWidth;
            mapHeight = level2.mapHeight;
            playerStartPosX = level2.playerStartPosX;
            playerStartPosY = level2.playerStartPosY;
        }
        if(levelID == 3)
        {
            Level3 level3 = new Level3();
            levelData = level3.mapData;
            mapWidth = level3.mapWidth;
            mapHeight = level3.mapHeight;
            playerStartPosX = level3.playerStartPosX;
            playerStartPosY = level3.playerStartPosY;
        }
    }
}