using HomeWork3_10_4;

var fruits = new MyList<string>();
fruits.Add("Apple");
fruits.Add("Lemon");
fruits.Add("Peach");

var fruitsAsArr = fruits.GetArray();
for (int i = 0; i < fruitsAsArr.Length; i++) {
    Console.WriteLine(fruitsAsArr[i]);
}