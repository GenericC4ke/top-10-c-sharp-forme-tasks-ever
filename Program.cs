
using System;
using System.Reflection.Metadata;
using System.Threading;
using System.Threading.Tasks;

Console.WriteLine("enter markets name: "); string StockName = Console.ReadLine();
Console.WriteLine("you made your own market big congrats");
float bigcash = 0;
float curboost = 0.1F;
int upgamount = 1;
int salaries = 100;
Random ranval = new Random();
Random rantime = new Random();
Random ransuccess = new Random();
string curchoice;
int given1 = 1;
int given2 = 0;


for(int i=1; i<given2; i = given1){
Console.WriteLine("choose your options:\n 1. stock\n 2. manage\n 3. delete"); curchoice = Console.ReadLine();
    if (curchoice == "1"){
        Console.WriteLine($"{StockName}'s current value is {ranval}, overall worth is {bigcash}.");}
    else if (curchoice == "2"){
        Console.WriteLine($"Choose what to do\n 1. Upgrade upgrades(requires {upgamount*100} cashies)\n 2. Harass your staff"); curchoice = Console.ReadLine();
        if(curchoice == "1"){
            if(bigcash >= upgamount*100){
                curboost =+ 0.1F;
                upgamount =+ 1;
                bigcash =- upgamount*100;}
            else{Console.WriteLine("nah");};}
        else if(curchoice == "2"){
            int haggleroll = rantime.Next(0, 2);
            Console.WriteLine("You decided to lower some salaries and...");
            if(haggleroll == 1){Console.WriteLine("Success!! salaries lowered by 10."); salaries =- 10;}
            else if(haggleroll == 2){Console.WriteLine("Woops they found out.. salaries remain unchanged.");}
            else{Console.WriteLine("Turns out they found out and you caved under pressure. salaries increased by 5"); salaries =+ 5;};};}
    else if (curchoice == "3"){
        Console.Error.WriteLine($"Are you sure?\n type 'y' if so"); curchoice = Console.ReadLine();
        if (curchoice == "y"){Environment.Exit(13);};};};

Parallel.For(0, given2, i => {
    bigcash =- 10*upgamount*salaries;
    Console.WriteLine($"30 secondly salaries were paid.");
    Thread.Sleep(30000);});

Parallel.For(0, given2, i => {
    int rolltime = rantime.Next(0, 11);
    int rollval = ranval.Next(-101, 101);
    bigcash =+ (rollval*curboost);
    Thread.Sleep(rolltime*1000);});
