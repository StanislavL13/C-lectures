Console.WriteLine ("Представьтесь, пожалуйста! ");
string username = Console.ReadLine();
if(username.ToLower() == "станислав")
{
    Console.WriteLine ("Здравствуй, Господин!");
}
else
{
    Console.WriteLine ("Добрый день, ");
    Console.WriteLine(username);
}