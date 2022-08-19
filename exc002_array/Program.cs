// max of 9 w/ array

int[] array = {13, 6, 11, 43, 16, 27, 8, 54};

int maxTotal = array[0];

for (int i = 1; i < array.Length; i++) {
    if (array[i] > maxTotal) {
        maxTotal = array[i];
    }
}

Console.WriteLine("maxTotal = " + maxTotal);