public class FloorTile : Tile
{
    public override int ID
    {
        get
        {
            return _ID = 1;
        }
    }
    public override bool canPlayerStandOnTile
    {
        get
        {
            return _canPlayerStandOnTile = true;
        }
    }
    public override void AbstractMethod()
    {
        _ID++;
        _canPlayerStandOnTile = true;
    }
}