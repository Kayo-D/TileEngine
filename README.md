# TileEngine

Alla Tiles

0="WallTile"
1="FloorTile"

    Check collision

skicka in int newPlayerPos

check tile on newPlayerPos
If selectedTile = canPlayerStandOnTile == false
return false

If selectedTile = canPlayerStandOnTile == true
return true

    Move player

skicka in newPlayerPos/skicka tillbaka playerPos

int newPlayerPosX
int newPlayerPosY

switch
up/down/left/right
check collision
move playerPos

    WallTile

canPlayerStandOnTile=false

    FloorTile

canPlayerStandOnTile=true

# LevelManager

Alla Levels

1=TestMap
2=Redbrand Hideout

    Create level

skicka in int mapWidth, int mapHeight, string array mapData

example mapData

dataX 
    0   0,0,0,0,0
    1   0,1,1,1,0
    2   0,1,1,1,0
    3   0,1,1,1,0
    4   0,0,0,0,0

int array dataX = new int[mapWidth]
int array dataY = new int[mapHeight]

loop i(2)
split mapData[i(2)] at ,
convert each split string to int
feed each int into dataX[i(2)]

select dataY = 2 and dataX = 2

dataY   dataX 
    0   0,0,0,0,0
    1   0,1,1,1,0
    2   0,1,[1],1,0
    3   0,1,1,1,0
    4   0,0,0,0,0

    Set Start Position

playerPosX(2)
playerPosY(2)