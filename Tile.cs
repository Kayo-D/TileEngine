public abstract class Tile
{
    protected int _ID;
    protected bool _canPlayerStandOnTile;
    protected bool _isPlayerOnTile;
    public abstract int ID { get; }
    public abstract bool canPlayerStandOnTile { get; }
    public abstract void AbstractMethod();
}