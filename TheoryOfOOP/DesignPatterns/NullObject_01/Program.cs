// Есть некий магазин с товарами
// 

using NullObject_01;

Console.Clear();
Product milk = new Milk();
Product coffee = new Coffee();
Product cake = new Cake();

Console.WriteLine(milk.KCalOfProduct());
milk.eat();
Console.WriteLine(coffee.KCalOfProduct());
coffee.eat();
Console.WriteLine(cake.KCalOfProduct());
cake.eat();
Console.ReadKey();

