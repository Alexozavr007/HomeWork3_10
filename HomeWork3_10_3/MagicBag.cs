namespace HomeWork3_10_3;

public class MagicBag<T> where T : class, IAnimal {
    private Random rnd = new Random();

    private List<AnimalGrantedEvent<T>> grantedAnimals = new List<AnimalGrantedEvent<T>>();

    public Present Open(T animal) {
        for (int i = 0; i < grantedAnimals.Count; i++) {
            if (grantedAnimals[i].Animal == animal && grantedAnimals[i].Date == DateTime.Today) {
                return null;
            }
        }

        var p = rnd.Next(0, 2);
        if (p == 1) {
            var animalEvent = new AnimalGrantedEvent<T>();
            animalEvent.Animal = animal;
            animalEvent.Date = DateTime.Today;

            grantedAnimals.Add(animalEvent);

            var present100Coins = new Present();
            present100Coins.Coins = 100;
            return present100Coins;
        } else {
            return null;
        }
    }

    private class AnimalGrantedEvent<T> {
        public T Animal { get; set; }
        public DateTime Date { get; set; }
    }

}
