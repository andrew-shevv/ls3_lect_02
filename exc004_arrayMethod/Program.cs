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

int IndexOf(int[] collection, int find){
    int position = -1;
    for (int i = 0; i < collection.Length; i++) {
        if (collection[i] == find) {
            position = i;
            break; 
        }
    }
    return position;
}

Console.WriteLine(" Input array length: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
FillArray(array);
PrintArray(array);

Console.WriteLine( "\n Input number to find element: ");
int fnd = Convert.ToInt32(Console.ReadLine());
int elem = IndexOf(array, fnd);
if (elem != -1) {
    Console.WriteLine("Element " + elem + " of the array corresponds with number " + fnd);
}
else Console.WriteLine("There is no such number in the array");