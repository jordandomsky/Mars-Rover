namespace UnitTests;
public class RoverTests
{
    [Fact]
    public void ValidateRoverStartPosition()
    {
        Plateau map = new Plateau(5, 5);
        
        Rover r1 = new Rover(1, 2, Direction.N, "LMLMLMLMM", map);
        Rover r2 = new Rover(3, 3, Direction.E, "MMRMMRMRRM", map);

        Assert.Equal("1 2 N", r1.ToString());
        Assert.Equal("3 3 E", r2.ToString());
    }
    
    [Fact]
    public void ValidateRoverInstructions()
    {
        Plateau map = new Plateau(5, 5);
        
        Rover r1 = new Rover(1, 2, Direction.N, "LMLMLMLMM", map);
        Rover r2 = new Rover(3, 3, Direction.E, "MMRMMRMRRM", map);

        r1.ExecuteInstructions();
        Assert.Equal("1 3 N", r1.ToString());      

        r2.ExecuteInstructions();
        Assert.Equal("5 1 E", r2.ToString());      
    }

    [Fact]
    public void InvalidRoverInstructionsDoesNotMoveRoverPosition()
    {
        Plateau map = new Plateau(5, 5);
        
        Rover r1 = new Rover(1, 2, Direction.N, "LMLML1ML4M5M", map);
        Rover r2 = new Rover(3, 3, Direction.E, "QMMRMUMRM_RRMZ", map);

        r1.ExecuteInstructions();
        Assert.Equal("1 3 N", r1.ToString());      

        r2.ExecuteInstructions();
        Assert.Equal("5 1 E", r2.ToString());      
    }

    [Fact]
    public void OutofBoundsRoverInstructionsDoesNotMoveRoverPosition()
    {
        Plateau map = new Plateau(5, 5);
        
        Rover r1 = new Rover(3, 4, Direction.N, "MRMMMMRMM", map);

        r1.ExecuteInstructions();
        Assert.Equal("5 3 S", r1.ToString());      
    }

    [Fact]
    public void TurnLeftPastNorth()
    {
        Plateau map = new Plateau(5, 5);
        
        Rover r1 = new Rover(3, 4, Direction.E, "LLL", map);

        r1.ExecuteInstructions();
        Assert.Equal("3 4 S", r1.ToString());

        r1 = new Rover(3, 4, Direction.E, "LLLLLL", map);
        r1.ExecuteInstructions();
        Assert.Equal("3 4 W", r1.ToString());
    }

    [Fact]
    public void TurnRightPastWest()
    {
        Plateau map = new Plateau(5, 5);
        
        Rover r1 = new Rover(3, 4, Direction.E, "RRR", map);

        r1.ExecuteInstructions();
        Assert.Equal("3 4 N", r1.ToString());

        r1 = new Rover(3, 4, Direction.E, "RRRRRR", map);
        r1.ExecuteInstructions();
        Assert.Equal("3 4 W", r1.ToString());
    }
}