class Test
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter plateau dimensions:");
        string[] plateauString = Console.ReadLine().Split();

        //Get the max dimensions of the plateau
        Plateau plateau = new Plateau(Int32.Parse(plateauString[0]), Int32.Parse(plateauString[1]));

        string line;
        List<Rover> rovers = new List<Rover>();

        Console.WriteLine("Enter rover start position:");
        //Loop until we are out of rovers
        while (!string.IsNullOrEmpty(line = Console.ReadLine()))
        {
            string[] roverStartInfo = line.Split();
           
            int xStart = Int32.Parse(roverStartInfo[0]);
            int yStart = Int32.Parse(roverStartInfo[1]);

            //Convert the direction to enum
            Enum.TryParse(roverStartInfo[2], out Direction startDirection);

            //Get rover instructions from the next line
            Console.WriteLine("Enter rover instructions:");
            string roverInstructions = Console.ReadLine();

            //If the rover has an invalid starting position then we will not consider it for output
            if (plateau.CheckValidPosition(new Position(xStart, yStart)))
            {
                //Add the new rover to the list of rovers
                rovers.Add(new Rover(xStart, yStart, startDirection, roverInstructions, plateau));
            }
            
            Console.WriteLine("Enter next rover start position:");
        }

        //Execute each rover instruction in order and print final position and heading
        foreach (Rover r in rovers)
        {
            r.ExecuteInstructions();   
            Console.WriteLine(r.ToString()); 
        }
    }
}
