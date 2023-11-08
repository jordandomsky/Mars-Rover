public class Plateau
{
    private int xMax;
    private int yMax;
    public Plateau(int xDimension, int yDimension)
    {
        xMax = xDimension;
        yMax = yDimension;
    }

    //Returns true of the position is within the bounds of the plateau
    public bool CheckValidPosition(Position position)
    {
        return ValidateXPosition(position.x) && ValidateYPosition(position.y);
    }

    //Helper method to validate an x position
    private bool ValidateXPosition(int x)
    {
        return x >= 0 && x <= xMax;
    }

    //Helper method to validate a y position
    private bool ValidateYPosition(int y)
    {
        return y >= 0 && y <= yMax;
    }
}