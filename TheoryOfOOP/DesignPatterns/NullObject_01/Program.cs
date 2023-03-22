// Есть некий магазин с товарами
// 

using NullObject_01;

Console.Clear();
Product milk = new Milk();
Product coffee = new Coffee();

Console.WriteLine(milk.KCalOfProduct());
milk.eat();
Console.WriteLine(coffee.KCalOfProduct());
coffee.eat();
Console.ReadKey();

