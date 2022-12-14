void FillArrayRandomNumbers(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100,1000);
    }
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}


// Task 1
// void findEven(int length){
//     int[] arr = new int[length];
//     FillArrayRandomNumbers(arr);
//     Console.WriteLine("массив: ");
//     PrintArray(arr);
//     int count = 0;
    
//     for(int i =0; i < arr.Length; i++){
//         if(arr[i] % 2 == 0){
//             count++;
//         }
//     }
//     Console.WriteLine($"{count}");
// }

// Task 2
// void arr123(){
//     int[] arr = new int[123];
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(1, 1000);
//     }
//     Console.WriteLine("массив: ");
//     PrintArray(arr);
//     int count = 0;
//     for(int i = 0; i < arr.Length; i++){
//         if(arr[i] > 9 && arr[i] < 100){
//             count++;
//         }
//     }
//     Console.WriteLine($"{count}");
// }

// Task 3
// void findSum(int length){
//     int[] arr = new int[length];
//     FillArrayRandomNumbers(arr);
//     Console.WriteLine("массив: ");
//     PrintArray(arr);
//     int sum = 0;
//     for(int i =0; i < arr.Length; i++){
//         if(i % 2 != 0){
//             sum += arr[i];
//         }
//     }
//     Console.WriteLine($"{sum}");
// }

// Task 4
// void minAndMax(int length){
//     int[] arr = new int[length];
//     FillArrayRandomNumbers(arr);
//     Console.WriteLine("массив: ");
//     PrintArray(arr);

//     int difference = 0;
//     int max = Int32.MinValue;
//     int min = Int32.MaxValue;
//     for(int i =0; i < arr.Length; i++){
//         if(arr[i] > max){
//             max = arr[i];
//         }
//         if(arr[i] < min){
//             min = arr[i];
//         }
//     }
//     difference = max - min;
//     Console.WriteLine($"{difference}");
// }

// Task 5
void pairs(int length){
    int[] arr = new int[length];
    FillArrayRandomNumbers(arr);
    Console.WriteLine("массив: ");
    PrintArray(arr);

    for(int i = 0, j = arr.Length - 1; i <= j; i++, j-- ){
        if(i == j){
            Console.Write($"{arr[i]} ");    
        }else{
            Console.Write($"{arr[i] * arr[j]} ");
        }
    }
}


Console.WriteLine("Введите количество элементов массива : ");
int length = Convert.ToInt32(Console.ReadLine());

// Task 1
// findEven(length);

// Task 2
// arr123();

// Task 3
// findSum(length);

//Task 4
//minAndMax(length);

// Task 5
pairs(length);