Console.WriteLine("Skriv inn en tekst så reverserer jeg for deg!");
string textInput = Console.ReadLine();
reverseString(textInput);


void reverseString(string input)
{

    string a = "";
    for (int i = input.Length -1; i >= 0; i--)
    {
     a += input[i];
    }

Console.WriteLine(a);
}