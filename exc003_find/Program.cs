// array.Length = n, find a user-defined number

Console.WriteLine("Input number to find element: ");
int[] array = {12, 4, 6, 8, 9, 24, 16, 99, 35, 7, 8, 1};
int find = Convert.ToInt32(Console.ReadLine());
bool check = false;

for (int i = 0; i < array.Length; i++) {
    if (array[i] == find) {
        Console.WriteLine("Element " + i + " of the array corresponds with number " + find);
        check = true;
    }
}

if (check == false) {
    Console.WriteLine("There is no such number in the array");
}