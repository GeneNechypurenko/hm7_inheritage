
using hm7_inheritage;

Money money = new Money();
money.Currency = 125;
money.Cents = 99;

Console.WriteLine(money);

Console.WriteLine();

Product product = new Product();
product.Price = money;

product.DecreacePrice(15, 40);
Console.WriteLine(product);

Console.WriteLine();

product.IncreacePrice(3, 15);
Console.WriteLine(product);
