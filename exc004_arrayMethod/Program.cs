// make an array from scratch w/ method and complete prev exc using rand array and methods

void FillArray(int[] collection){
    for (int i = 0; i < collection.Length; i++){
        collection[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] collection){
    for (int i = 0; i < collection.Length; i++){
        Console.Write(collection[i] + " ");
    }
}

string IndexOf(int[] collection, int find){
    int position = 0;
    bool check = false;
    for (int i = 0; i < collection.Length; i++) {
        if (collection[i] == find) {
            position = i;
            check = true;
            break; 
        }
    }

    if (check == true) {
        return "Element " + position + " of the array corresponds with number " + find;
    }
    else return "There is no such number in the array";
}

Console.WriteLine(" Input array length: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

FillArray(array);
PrintArray(array);

Console.WriteLine( "\n Input number to find element: ");
int fnd = Convert.ToInt32(Console.ReadLine());
string elem = IndexOf(array, fnd);

Console.WriteLine(elem);