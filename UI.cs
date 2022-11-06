using System.Collections;
using static System.Console;

class UI
{
    public ConsoleKeyInfo keyInput;
    LevelManager manager = new LevelManager();
    TileEngine tileEngine = new TileEngine();
    TileManager tiles = new TileManager();
    public void Menu()
    {
        while (true)
        {
            Clear();
            WriteLine("MENU");
            WriteLine("");
            WriteLine("1: Level 1");
            WriteLine("2: Redbrand Hideout");
            WriteLine("3: Level 3");
            WriteLine("4: Exit");
            keyInput = ReadKey();
            switch (keyInput.Key)
            {
                case ConsoleKey.D1:
                    manager.SelectLevel(1);
                    tileEngine.SpawnPlayer(manager.playerStartPosX, manager.playerStartPosY);
                    tileEngine.currentLevel.levelData = manager.levelData;
                    tileEngine.currentLevel.mapWidth = manager.mapWidth;
                    while (true)
                    {
                        UILevelUpdate();
                        tileEngine.PlayerPositionUpdate(keyInput);
                        if (keyInput.Key == ConsoleKey.Q)
                        {
                            break;
                        }
                    }
                    break;
                case ConsoleKey.D2:
                    manager.SelectLevel(2);
                    tileEngine.SpawnPlayer(manager.playerStartPosX, manager.playerStartPosY);
                    tileEngine.currentLevel.levelData = manager.levelData;
                    tileEngine.currentLevel.mapWidth = manager.mapWidth;
                    while (true)
                    {
                        UILevelUpdate();
                        tileEngine.PlayerPositionUpdate(keyInput);
                        if (keyInput.Key == ConsoleKey.Q)
                        {
                            break;
                        }
                    }
                    break;
                case ConsoleKey.D3:
                    manager.SelectLevel(3);
                    tileEngine.SpawnPlayer(manager.playerStartPosX, manager.playerStartPosY);
                    tileEngine.currentLevel.levelData = manager.levelData;
                    tileEngine.currentLevel.mapWidth = manager.mapWidth;
                    while (true)
                    {
                        UILevelUpdate();
                        tileEngine.PlayerPositionUpdate(keyInput);
                        if (keyInput.Key == ConsoleKey.Q)
                        {
                            break;
                        }
                    }
                    break;
                case ConsoleKey.D4:
                    return;
                default:
                    break;
            }
        }
    }
    public void UILevelUpdate()
    {
        Clear();
        for (int i = 0; i < manager.mapHeight; i++)
        {
            for (int j = 0; j < manager.mapWidth; j++)
            {
                if (tileEngine.SelectTile(manager.levelData, i, j, manager.mapWidth) == new WallTile().ID)
                {
                    BackgroundColor = ConsoleColor.DarkRed;
                    Write(" ");
                }
                if (tileEngine.SelectTile(manager.levelData, i, j, manager.mapWidth) == new FloorTile().ID)
                {
                    if (tileEngine.currentPlayerPosY == i && tileEngine.currentPlayerPosX == j)
                    {
                        BackgroundColor = ConsoleColor.White;
                        Write("X");
                    }
                    else
                    {
                        BackgroundColor = ConsoleColor.White;
                        Write(" ");
                    }
                }
            }
            WriteLine("");
        }
        BackgroundColor = ConsoleColor.Black;
        WriteLine("");
        WriteLine("Q for Exit");
        keyInput = ReadKey();
    }
}