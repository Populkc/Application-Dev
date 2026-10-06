namespace VariablesAndDatatypes
{
    class Program
    {
        static void Main()
        {
            // ---- Task 1: variables and interpolated strings ----

            // TODO 1: declare a variable called userName that holds your name.
            //         Text needs the type string.
            string userName = "Prajeet Khatri";

            // TODO 2: declare a variable called luckyNumber holding your
            //         favourite single-digit number. A whole number is int.
            int luckyNumber = 7;

            // TODO 3: print ONE line that reads exactly:
            //         Hello, <your name>! Your lucky number is <the number>.
            //         Use string interpolation, not the + operator.
            Console.WriteLine($"hello, {userName}! Your Lucky Name is{luckyNumber}");
                        // ---- Task 2: constants ----

            // TODO 2: create a Circle object and print Circle.PI.
            //         PI is a constant, so you read it through the class
            //         name rather than through an object.
            Circle circle = new Circle();
            Console.WriteLine($"Circle.PI = {Circle.PI}");

            // TODO 3: now write this on a line of its own:
            //             Circle.PI = 3.15;
            //         then build and read the error.
            //         When you have read it, delete the line again so the
            //         remaining tasks still run.

        }
    }
}
