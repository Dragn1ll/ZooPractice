using Zoo;
using Zoo.Nasledovanie;

Animal dog = new Animal("Петя", "Света");
//Console.WriteLine(dog.OwnerName);

Gryzun gryzun = new Gryzun("Дима");
Gryzun gryzun1 = new Rabbit("Олег", "Ильнур");
Rabbit rabbit = new Rabbit("Марат", "Камиль");

//gryzun.Jump();
//gryzun1.Jump();
//rabbit.Jump();

Predator tiger = new Tiger("Лёва");
//tiger.Eat(dog);
IGrowlable tiger1 = new Tiger("Макс");
//tiger1.Growl();

ZooWorker zooWorker = new ZooWorker();
Animal cat = new Animal("Ксюша", "Даниил");
Console.WriteLine(zooWorker.Compare(cat, dog));