//csv file path
var fileData = File.ReadLines("C:\\Users\\andre\\Downloads\\K3241.K03200Y1.D40113.ESTABELE.csv");

var data = new List<string>();
int count = 0;

foreach (var line in fileData)
{
    count += 1;
    Console.WriteLine();
    Console.WriteLine(count + " - " + line);
    data.Add(line);
}