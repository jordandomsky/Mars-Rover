public class Rover
{
    private Position currentPosition;
    private Direction direction;
    private string instructions;
    private Plateau map;

    public Rover(int xPosition, int yPosition, Direction direction, string instructions, Plateau map)
    {
        currentPosition = new Position(xPosition, yPosition);
        this.direction = direction;
        this.instructions = instructions;
        this.map = map;
    }

    private void TurnLeft()
    {
        switch(direction)
        {
            case Direction.N:
                direction = Direction.W;
                break;
            case Direction.E:
                direction = Direction.N;
                break;
            case Direction.S:
                direction = Direction.E;
                break;
            case Direction.W:
                direction = Direction.S;
                break;
        }
    }

    private void TurnRight()
    {
        switch(direction)
        {
            case Direction.N:
                direction = Direction.E;
                break;
            case Direction.E:
                direction = Direction.S;
                break;
            case Direction.S:
                direction = Direction.W;
                break;
            case Direction.W:
                direction = Direction.N;
                break;
        }
    }

    private void Move()
    {
        int xMovement = 0;
        int yMovement = 0;

        //Determine the direction of movement
        switch(direction)
        {
            case Direction.N:
                yMovement++;
                break;
            case Direction.E:
                xMovement++;
                break;
            case Direction.S:
                yMovement--;
                break;
            case Direction.W:
                xMovement--;
                break;
        }

        //Determine the next position
        Position nextPosition = new Position (currentPosition.x + xMovement, currentPosition.y + yMovement);

        //Only commit the movement if the next position is valid within the plateau
        if (map.CheckValidPosition(nextPosition))
        {
            currentPosition = nextPosition;
        }
    }

    public void ExecuteInstructions()
    {
        //Execute each instruction in sequence ignoring any invalid instructions
        foreach (char instruction in instructions)
        {
            switch (instruction)
            {
                case 'L':
                this.TurnLeft();
                break;
                case 'R':
                this.TurnRight();
                break;
                case 'M':
                this.Move();
                break;
                default:
                break;
            }
        }
    }

    public override string ToString()
    {
        return currentPosition + " " + direction;
    }
}