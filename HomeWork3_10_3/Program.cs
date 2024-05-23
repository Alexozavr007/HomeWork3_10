using HomeWork3_10_3;
using System.Text;

Console.OutputEncoding = Encoding.Unicode;

var gummyBear = new Bear();
gummyBear.Type = "Гумовий";

var vinniPuh = new Bear();
vinniPuh.Type = "Жовтий";

var dog  = new Dog();
dog.Type = "Добрий";

var bag = new MagicBag<IAnimal>();

for (int i = 0; i < 10; i++) {
    var bearPresent = bag.Open(gummyBear);
    if (bearPresent == null) {
        Console.WriteLine($"Спроба №{i + 1}: Ведмедик Gummy не отримав подарунок");
    } else {
        Console.WriteLine($"Спроба №{i + 1}: Ведмедик Gummy отримав подарунок");
    }
}
for (int i = 0; i < 10; i++) {
    var bearPresent = bag.Open(vinniPuh);
    if (bearPresent == null) {
        Console.WriteLine($"Спроба №{i + 1}: Ведмедик Vinni Puh не отримав подарунок");
    } else {
        Console.WriteLine($"Спроба №{i + 1}: Ведмедик Vinni Puh отримав подарунок");
    }
}
for (int i = 0; i < 10; i++) {
    var bearPresent = bag.Open(dog);
    if (bearPresent == null) {
        Console.WriteLine($"Спроба №{i + 1}: Песик не отримав подарунок");
    } else {
        Console.WriteLine($"Спроба №{i + 1}: Песик отримав подарунок");
    }
}
