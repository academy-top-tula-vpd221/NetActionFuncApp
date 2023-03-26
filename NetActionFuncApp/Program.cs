// Action

var messOp = SendMessage;
Action<string, string> emailOp = EmailMessage;
Action<int> actionScore = PrintScore;

// Func
Func<int> func1 = Return100;
var binOp = (int a, int b) => a + b;

// Predicate
Predicate<int> isZero = (a) => a == 0;
Predicate<int> isPositive = (a) => a > 0;
Person person = new Person() { Name = "Bob", Age = 24 };
Predicate<Person> isAdult = (p) => p.Age > 16;


Func<int> counter1 = CounterCreate(10);
for (int i = 0; i < 10; i++)
    Console.WriteLine(counter1());
Console.WriteLine();

Func<int> counter2 = CounterCreate(50);
for (int i = 0; i < 10; i++)
    Console.WriteLine(counter2());

Func<int> CounterCreate(int countBegin)
{
    int count = countBegin;
    int Counter()
    {
        return ++count;
    }
    return Counter;
}

void SendMessage(string text)
{
    Console.WriteLine(text);
}

void EmailMessage(string text, string subject)
{
    Console.WriteLine($"About {subject}, message {text}");
}

void PrintScore(int score)
{
    Console.WriteLine($"Score = {score}");
}

int Return100()
{
    return 100;
}

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}