
Console.WriteLine("Vill du gå höger eller vänster?");
string riktning = Console.ReadLine();
//ToLower();


if (riktning == "Höger" || riktning == "höger")
{
    Console.WriteLine("Du gick rätt. Du forsätter längs stigen och ser en run längst vägen. Ska du kolla ner eller inte?");
    string check = Console.ReadLine();
    if (check == "ja")
    {
        Console.WriteLine("Det var ett monster i brunnen. Du dog, HAHAHAHAHAHAHAH");
    }
    else if (check == "nej")
    {

        Console.WriteLine("Du kom dit du ville utan att dö, YIPPIE");
    }
}
if (riktning == "Vänster" || riktning == "vänster")
{
    Console.WriteLine("Du dog din noob HAHHAHAHAHAH SKILL ISSUE KYS");
}

Console.ReadLine();
