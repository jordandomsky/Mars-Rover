namespace UnitTests;
public class PositionTests
{
    [Fact]
    public void PositionStringNormal()
    {
        Position pos = new Position (1,4);

        Assert.Equal("1 4", pos.ToString());      
    }

    [Fact]
    public void PositionStringNegative()
    {
        Position pos = new Position (-2,-1);

        Assert.Equal("-2 -1", pos.ToString());      
    }
}