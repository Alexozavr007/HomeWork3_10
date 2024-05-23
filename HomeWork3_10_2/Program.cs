using HomeWork3_10_2;

var primeNumbers = new MyList<int>();
primeNumbers.Add(2);
primeNumbers.Add(3);
primeNumbers.Add(5);
primeNumbers.Add(8);//on purpose

primeNumbers[3] = 7;

Console.WriteLine(primeNumbers.ListLength);