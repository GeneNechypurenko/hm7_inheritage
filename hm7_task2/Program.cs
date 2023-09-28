
using hm7_task2;

Device kettle = new Kettle("Bosch", "1.7 l");
Device microwave = new Microwave("Panasonic", "1200 W");
Device car = new Car("Ford", "V 2.4 hp");
Device steamboat = new Steamboat("Titanic", "Vulnerable to icebergs");

kettle.Show();
kettle.Sound();
kettle.Desc();

Console.WriteLine();

microwave.Show();
microwave.Sound();
microwave.Desc();

Console.WriteLine();

car.Show();
car.Sound();
car.Desc();

Console.WriteLine();

steamboat.Show();
steamboat.Sound();
steamboat.Desc();