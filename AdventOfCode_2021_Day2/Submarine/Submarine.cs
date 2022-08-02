


namespace Submarine {
    public class Submarine : ISubmarine 
    {
        //public int depth = 0;
        //public int horizontalPosition = 0;

        public Submarine(string InstructionFile = "input.txt") : this(File.ReadAllLines(InstructionFile)) { }

        public Submarine(string[] Instructions) {
        //    foreach (string[] instruction in Instructions)
        //    {
        //        instruction.Split(" ");
        //        string direction = instruction[0];
        //        int value = int.Parse(instruction[1]);

        //        if (direction == "forward")
        //        {
        //            forward(value);
        //        }
        //        if (direction == "up")
        //        {
        //            up(value);
        //        }
        //        if (direction == "down")
        //        {
        //            down(value);
        //        }
        //        else
        //        {
        //            throw new Exception("Sorry, directions unclear");
        //        }
        //    }

        //    finalPosition(horizontalPosition, depth);
        //}

        //public int forward(int x)
        //{
        //    horizontalPosition += x;
        //    return horizontalPosition;
        //}

        //public int up(int y)
        //{
        //    return depth -= y;
        //}

        //public int down(int y)
        //{
        //    return depth += y;
        //}

        //public int finalPosition(int x, int y)
        //{
        //    return x * y;
        }
        public decimal Answer_Part1 { get; private set; }

        public decimal Answer_Part2 { get; private set; }
    }
}