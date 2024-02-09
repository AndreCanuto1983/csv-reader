static List<string> CsvFileReaderV1(string path)
{
    var listData = new List<string>();

    using (StreamReader stream = new StreamReader(path))
    {
        string data = stream.ReadLine();
        string[] arrData = data.Split(';');

        do
        {
            for (int i = 0; i <= arrData.GetUpperBound(0); i++)
            {
                listData.Add(arrData[i]);
            }

        } while (!(stream.EndOfStream));
    }

    return listData;
}

static List<string> CsvFileReaderV2(string path)
{
    var data = File.ReadLines(path);
    var listData = new List<string>();

    foreach (var line in data)
    {
        listData.Add(line);
    }

    return listData;
}

var dataV1 = CsvFileReaderV1("C:\\Users\\andre\\Downloads\\K3241.K03200Y1.D40113.ESTABELE.csv");

var dataV2 = CsvFileReaderV2("C:\\Users\\andre\\Downloads\\K3241.K03200Y1.D40113.ESTABELE.csv");

int count = 0;

foreach (var line in dataV1)
{
    count += 1;
    Console.WriteLine();
    Console.WriteLine(count + " - " + line);
}

foreach (var line in dataV2)
{
    count += 1;
    Console.WriteLine();
    Console.WriteLine(count + " - " + line);
}