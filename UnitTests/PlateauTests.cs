namespace UnitTests;

public class PlateauTests
{
    [Fact]
    public void ValidPosition()
    {
        Plateau p = new Plateau(5, 6);
        Position pos = new Position (1,4);

        Assert.True(p.CheckValidPosition(pos));      
    }

    [Fact]
    public void InvalidYPosition()
    {
        Plateau p = new Plateau(5, 6);
        Position pos = new Position (1,1000);

        Assert.False(p.CheckValidPosition(pos));      
    }
    
    [Fact]
    public void NegativeYPosition()
    {
        Plateau p = new Plateau(5, 6);
        Position pos = new Position (1,-4);

        Assert.False(p.CheckValidPosition(pos));      
    }

[Fact]
    public void InvalidXPosition()
    {
        Plateau p = new Plateau(5, 6);
        Position pos = new Position (1000,1);

        Assert.False(p.CheckValidPosition(pos));      
    }
    
    [Fact]
    public void NegativeXPosition()
    {
        Plateau p = new Plateau(5, 6);
        Position pos = new Position (-1,4);

        Assert.False(p.CheckValidPosition(pos));      
    }

    [Fact]
    public void PositionAtZero()
    {
        Plateau p = new Plateau(5, 6);
        Position pos = new Position (0,0);

        Assert.True(p.CheckValidPosition(pos));      
    }

    [Fact]
    public void InvalidBothPosition()
    {
        Plateau p = new Plateau(5, 6);
        Position pos = new Position (-1,305930);

        Assert.False(p.CheckValidPosition(pos));      
    }

    [Fact]
    public void NegativePlateau()
    {
        Plateau p = new Plateau(-5, 6);
        Position pos = new Position (1,3);

        Assert.False(p.CheckValidPosition(pos));      
    }

}