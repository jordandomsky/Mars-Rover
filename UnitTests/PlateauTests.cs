namespace UnitTests;

public class PlateauTests
{
    [Fact]
    public void ValidPositionReturnTrue()
    {
        Plateau p = new Plateau(5, 6);
        Position pos = new Position (1,4);

        Assert.True(p.CheckValidPosition(pos));      
    }

    [Fact]
    public void InvalidYPositionReturnFalse()
    {
        Plateau p = new Plateau(5, 6);
        Position pos = new Position (1,1000);

        Assert.False(p.CheckValidPosition(pos));      
    }
    
    [Fact]
    public void NegativeYPositionReturnFalse()
    {
        Plateau p = new Plateau(5, 6);
        Position pos = new Position (1,-4);

        Assert.False(p.CheckValidPosition(pos));      
    }

[Fact]
    public void InvalidXPositionReturnFalse()
    {
        Plateau p = new Plateau(5, 6);
        Position pos = new Position (1000,1);

        Assert.False(p.CheckValidPosition(pos));      
    }
    
    [Fact]
    public void NegativeXPositionReturnFalse()
    {
        Plateau p = new Plateau(5, 6);
        Position pos = new Position (-1,4);

        Assert.False(p.CheckValidPosition(pos));      
    }

    [Fact]
    public void PositionAtZeroReturnTrue()
    {
        Plateau p = new Plateau(5, 6);
        Position pos = new Position (0,0);

        Assert.True(p.CheckValidPosition(pos));      
    }

    [Fact]
    public void InvalidBothPositionReturnFalse()
    {
        Plateau p = new Plateau(5, 6);
        Position pos = new Position (-1,305930);

        Assert.False(p.CheckValidPosition(pos));      
    }

    [Fact]
    public void NegativePlateauReturnFalse()
    {
        Plateau p = new Plateau(-5, 6);
        Position pos = new Position (1,3);

        Assert.False(p.CheckValidPosition(pos));      
    }

}