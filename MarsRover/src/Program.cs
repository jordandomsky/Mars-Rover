class MarsRoverProblem
{
    //Helper method to convert a string to int. If conversion cant be made, print the string and exit the program.
    static int ConvertStringToInt(string s)
    {
        if (!Int32.TryParse(s, out int i))
        {
            Console.WriteLine("Error: Cannot convert " + s + " to int");
            Environment.Exit(0);
        }
        return i;
    }

    static void Main(string[] args)
    {
        string[] plateauString = Console.ReadLine().Split();

        //Set the max dimensions of the plateau
        Plateau plateau = new Plateau(ConvertStringToInt(plateauString[0]), ConvertStringToInt(plateauString[1]));

        string line;
        List<Rover> rovers = new List<Rover>();

        //Loop until we are out of rovers
        while (!string.IsNullOrEmpty(line = Console.ReadLine()))
        {
            string[] roverStartInfo = line.Split();

            int xStart = ConvertStringToInt(roverStartInfo[0]);
            int yStart = ConvertStringToInt(roverStartInfo[1]);

            //Convert the direction to enum
            if (!Enum.TryParse(roverStartInfo[2], out Direction startDirection))
            {
                Console.WriteLine("Error: Cannot convert " + roverStartInfo[2] + " to direction");
                Environment.Exit(0);
            }

            //Get rover instructions from the next line
            string roverInstructions = Console.ReadLine();

            //If the rover has an invalid starting position then we will not consider it for output
            if (plateau.CheckValidPosition(new Position(xStart, yStart)))
            {
                //Add the new rover to the list of rovers
                rovers.Add(new Rover(xStart, yStart, startDirection, roverInstructions, plateau));
            }
        }

        //Execute each rover instruction in order and print final position and heading
        foreach (Rover r in rovers)
        {
            r.ExecuteInstructions();   
            Console.WriteLine(r.ToString()); 
        }
    }
}
