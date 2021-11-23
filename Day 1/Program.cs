// See https://aka.ms/new-console-template for more information

try
{
    var integerList = File.ReadAllLines("input.txt")
        .Select(s => Int32.Parse(s)).ToList();
    int target = 2020;
    int answer = 0;


    //Linq solution part 1
    static int LinqSolutionPart1(IEnumerable<int> ints, int targetValue)
    {


        return
            (from x in ints
             from y in ints.Skip(1)
             where x + y == targetValue
             select x * y).FirstOrDefault();
    }

    static int LinqSolutionPart2(IEnumerable<int> ints, int targetValue)
    {
        return
            (from x in ints
             from y in ints.Skip(1)
             from z in ints.Skip(2)
             where x + y + z == targetValue
             select x * y * z).FirstOrDefault();
    }


    //Answer to part 1
    answer = LinqSolutionPart1(integerList, target);
    if (answer != 0)
        Console.WriteLine("Answer to part 1: " + answer);
    else Console.WriteLine("Failed to find answer to part 1");

    //Answer to part 2
    answer = LinqSolutionPart2(integerList, target);
    if (answer != 0)
        Console.WriteLine("Answer to part 2: " + answer);
    else Console.WriteLine("Failed to find answer to part 2");



}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());

}
