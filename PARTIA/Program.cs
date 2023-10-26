
using PARTIA;


Console.WriteLine("Welcome in program POLITICAL PARTY STAT");
Console.WriteLine("TTHIS PROGRAM WITHDRAW STATISTIC FOR POLITICAL PARTY");
Console.WriteLine("*************************************************************");



var PoliticalParty = new PoliticalPartyInFile("MWD - My Wam Damy Party");
var partyName = PoliticalParty.Name;

PoliticalParty.SupportAdded += PoliticalPartySupportAdded;

void PoliticalPartySupportAdded(object sender, EventArgs args)
{
    Console.WriteLine("Support Add");
}

Console.WriteLine($"This program is for {partyName}");



while (true)
{

    Console.WriteLine($"Enter support for {partyName} ");
    var support = Console.ReadLine();
    if (support == "F" || support == "f")
    {
        break;
    }
    try
    {
        PoliticalParty.AddSupport(support);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"invalid format:{ex.Message}");
    }
    Console.WriteLine();
    Console.WriteLine("Enter next support");
}
Console.WriteLine("Result of support");
Console.WriteLine();
var statistics = PoliticalParty.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

