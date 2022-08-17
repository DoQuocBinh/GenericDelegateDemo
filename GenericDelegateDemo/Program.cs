using GenericDelegateDemo;

List<String> names = new List<string>();
names.Add("Phuong");
names.Add("Hung");

List<int> numbers = new List<int>();
numbers.Add(123);
numbers.Add(256);

foreach (var item in names)
{
    Console.WriteLine(item.ToUpper() + 10);
}

foreach (var item in numbers)
{
    Console.WriteLine(item + 10);
}

Nullable<int> a = 10;
a = null;

void sayHi(string name)
{
    Console.WriteLine("Hi " + name);
}
void goodBye(string name)
{
    Console.WriteLine("Goodbye " + name);
}

int sumNumbers(int a, int b)
{
    return a + b;
}

m1 mydelegate = new m1(sayHi);
mydelegate("Cuong");
mydelegate = new m1(goodBye);
mydelegate("Cuong");

mathOps ma = sumNumbers;//khong can dung new
Console.WriteLine( ma(50, 40));

//delegate tro den ham vo danh Annonymous function
mathOps ma2 = delegate(int a, int b) { return a * b; };
Console.WriteLine(ma2(50, 40));

mathOps ma3 = ( a,  b) => { return a - b; };

Func<int,int,int,long> ma4 = (x,y, z) => { return x * y * z; };
Func<String, String, String> ma5 = (x, y) => { return x + " " + y; };
Console.WriteLine(ma5("Hello","Anh"));
Predicate<int> check = (x) =>
{
    if(x %2 ==0)
        return true;
    else return false;
};
Console.WriteLine("5 la so chan: " + check(5));

List<string> animals = new List<string> { "cho dom", "meo hoang", "khung long", "ca xau xau" };
var result = animals.FindAll(a => a.StartsWith("c"));
foreach (var item in result)
{
    Console.WriteLine(item);
}
var result2 = animals.FindAll(a=>a.Replace(" ","").Length >=7);
foreach (var item in result2)
{
    Console.WriteLine(item);
}
List<int> vs = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
                            
var k = vs.FindAll(s => s >=6 && s <=12).Sum();
Console.WriteLine(k);

//1. convert so le thanh 2, so chan thanh 0; 2: cong tat ca lai
var xxx = vs.Sum(x=> (x % 2 ==1) ? 2:0);
Console.WriteLine(xxx);

var k4 = vs.FindAll(x=>x % 2 == 0).Average();

List<Person> listPerson = new List<Person>();
listPerson.Add(new Person { Name = "Trang", Age = 32 });
listPerson.Add(new Person { Name = "Hai", Age = 24 });
listPerson.Add(new Person { Name = "Phuong", Age = 25 });
listPerson.Add(new Person { Name = "Linh", Age = 24 });

var k5 = listPerson.FindAll(p => p.Age > 24);
Console.WriteLine(listPerson.Average(p=>p.Age));
Console.WriteLine(listPerson.Exists(p=>p.Name.Equals("Linh")));

listPerson.All(p => p.Age > 20);

delegate void m1(string param1);
delegate int mathOps(int x, int y);
