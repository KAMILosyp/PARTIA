// See https://aka.ms/new-console-template for more information
using PARTIA;
using System.Collections.Generic;
using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Welcome in program POLITICAL PARTY STAT");
Console.WriteLine("TTHIS PROGRAM WITHDRAW STATISTIC FOR POLITICAL PARTY");
Console.WriteLine("*************************************************************");



var PoliticalParty = new PoliticalPartyInFile("MWD - My Wam Damy");

PoliticalParty.SupportAdded += PoliticalPartySupportAdded;

void PoliticalPartySupportAdded(object sender, EventArgs args)
{
    Console.WriteLine("Support Add");
}
var Party = "MWD - My Wam Damy";
Console.WriteLine("This program is for MWD - My Wam Damy party");
Console.WriteLine($"Enter support in choosing month for {Party} ");


while (true)
    {
   
    Console.WriteLine($"Enter support {Party} ");
    var support = Console.ReadLine();
    if(support == "F" || support == "f")
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

