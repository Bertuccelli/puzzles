// RANDOM ARRAY
static int[] RandomArray() {
    Random randy = new Random();
    int[] randArray = new int[10];
    int min = 25;
    int max = 0;
    int total = 0;
    for(int i = 0; i < randArray.Length; i++){
        randArray[i] = randy.Next(5, 25);
        Console.WriteLine(randArray[i]);
        total += randArray[i];
        if(randArray[i] > max){
            max = randArray[i];
        }
        if(randArray[i] < min){
            min = randArray[i];
        }
    }
    Console.WriteLine("min value: " + min);
    Console.WriteLine("max value: " + max);
    Console.WriteLine("total value: " + total);
    return randArray;
}
RandomArray();


// COIN FLIP
static string TossCoin() {
    Console.WriteLine("Tossing a Coin!");
    Random coin = new Random();
    int flip = coin.Next(1, 3);
    if(flip == 1) {
        Console.WriteLine("Heads!");
        return "Heads!";
    }
    else {
        Console.WriteLine("Tails!");
        return "Tails!";
    }
}
TossCoin();

// NAMES
static List<string> Names() {
    List<string> names = new List<string>(){
        "Todd",
        "Tiffany",
        "Charlie",
        "Geneva",
        "Sydney"
    };
    for (int x = 0; x < names.Count; x++) {
        if (names[x].Length <= 5) {
            names.RemoveAt(x);
        }
    }
    foreach (string name in names) {
        Console.WriteLine(name);
    }
    return names;
}
Names();