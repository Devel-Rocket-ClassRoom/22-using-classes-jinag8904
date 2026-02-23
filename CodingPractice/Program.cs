using System;

// 1.
ClassName.MemberName();
Console.WriteLine();

// 2.
Console.WriteLine(Square.GetName());
Console.WriteLine();

// 3.
MyFirstClass.StaticMethod();

MyFirstClass mfc = new MyFirstClass();
mfc.InstanceMethod();

Console.WriteLine();

// 4.
Person person1 = new Person();
person1.Name = "홍길동";
person1.Age = 25;
person1.Introduce();

Person person2 = new Person();
person2.Name = "김철수";
person2.Age = 30;
person2.Introduce();

Console.WriteLine();

// 5.
Point point1 = new Point();
point1.X = 100;

Point point2 = point1;
point2.X = 200;

Console.WriteLine(point1.X);
Console.WriteLine(point2.X);

Console.WriteLine();

// 6.
PointStruct ps1 = new PointStruct();
ps1.X = 100;
PointStruct ps2 = ps1;
ps2.X = 200;

PointClass pc1 = new PointClass();
pc1.X = 100;
PointClass pc2 = pc1;
pc2.X = 200;

Console.WriteLine($"구조체: ps1.X = {ps1.X}, ps2.X = {ps2.X}");
Console.WriteLine($"클래스: pc1.X = {pc1.X}, pc2.X = {pc2.X}");

Console.WriteLine();

// 7.
Calculator calc = new Calculator();
Console.WriteLine($"3 + 5 = {calc.Add(3, 5)}");
Console.WriteLine($"3 * 5 = {calc.Multiply(3, 5)}");

Console.WriteLine();

// 8.
Player player1 = new Player();
Player player2 = new Player("용사", 150);

Console.WriteLine($"이름: {player1.name}, 체력: {player1.HP}");
Console.WriteLine($"이름: {player2}, 체력: {player2.HP}");

Console.WriteLine();

// 9.
Stock stock = new Stock();
stock.CurrentPrice = 30;
Console.WriteLine(stock.CurrentPrice);

Console.WriteLine();

// 10.
Product product = new Product();
product.Name = "노트북";
product.Price = 1500000;

Console.WriteLine($"{product.Name}: {product.Price}원 (수량: {product.Quantity})");

Console.WriteLine();

// 11.
Circle circle = new Circle();
circle.Radius = 5;
Console.WriteLine($"반지름: {circle.Radius}, 넓이: {circle.Area:F2}");

Console.WriteLine();

// 12.
Monster monster1 = new Monster();
monster1.Name = "고블린";
monster1.Health = 10;

Monster monster2 = new Monster()
{
    Name = "오크",
    Health = 50
};

monster1.Attack();
monster2.Attack();

Console.WriteLine();

// 13.
Character character = new Character()
{
    Name = "용사",
    Level = 10,
    Job = "전사"
};

Console.WriteLine($"{character.Name} - Lv.{character.Level} {character.Job}");

Console.WriteLine();

// 14.
Random random = new Random();
Console.WriteLine($"임의의 정수: {random.Next()}");
Console.WriteLine($"0 ~ 4: {random.Next(0, 4)}");
Console.WriteLine($"1 ~ 9: {random.Next(1, 9)}");
Console.WriteLine($"0.0 ~ 1.0: {random.NextDouble():F4}");

Console.WriteLine();

// 15.
Console.WriteLine("주사위를 5번 굴립니다:");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{i}번째: {random.Next(1, 7)}");
}

Console.WriteLine();

// 16.
Person2 alice = new Person2("앨리스");
Person2 bob = new Person2("밥");

alice.SetFriend(bob);

// 1.
class ClassName
{
    public static void MemberName()
    {
        Console.WriteLine("클래스의 멤버가 호출되어 실행됩니다.");
    }
}

// 2.
class Square
{
    public static string GetName()
    {
        return "정사각형";
    }
}

// 3.
class MyFirstClass
{
    public static void StaticMethod()
    {
        Console.WriteLine("[1] 정적 메서드");
    }

    public void InstanceMethod()
    {
        Console.WriteLine("[2] 인스턴스 메서드");
    }
}

// 4.
class Person
{
    public string Name;
    public int Age;

    public void Introduce()
    {
        Console.WriteLine($"안녕하세요, {Name}입니다. {Age}살입니다.");
    }
}

// 5.
class Point
{
    public int X = 50;
    public int Y = 50;
}

// 6.
struct PointStruct
{
    public int X;
}

class PointClass
{
    public int X;
}

// 7.
class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Multiply(int a, int b) => a * b;
}

// 8.
class Player
{
    public string name;
    public int HP;

    public Player()
    {
        name = "Unknown";
        HP = 100;
    }

    public Player(string name, int HP)
    {
        this.name = name;
        this.HP = HP;
    }
}

// 9.
class Stock
{
    int stock;

    public int CurrentPrice{
        get { return stock; }
        set { stock = value; } 
    }
}

// 10.
class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; } = 1;
}

// 11.
class Circle
{
    public double Radius { get; set; }
    public double Area => Math.PI * Radius * Radius;
}

// 12.
class Monster
{
    public string Name;
    public int Health;

    public void Attack()
    {
        Console.WriteLine($"{Name}이(가) 공격합니다!");
    }
}

// 13.
class Character
{
    public string Name { get; set; }
    public int Level { get; set; }
    public string Job { get; set; }
}

// 16.
class Person2
{
    public string name;

    public Person2 (string name)
    {
        this.name = name;   
    }

    public void SetFriend(Person2 friend)
    {
        Console.WriteLine($"{this.name}의 친구는 {friend.name}입니다.");
    }
}