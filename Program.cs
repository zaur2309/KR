
string[] CreateArray(int size){
    string[] array = new string [size];
    Console.WriteLine("Enter the array elements: ");
    for(int i = 0; i < size; i++){
        array[i] = Console.ReadLine();
    }
    return array;
}
// Функция для создания массива с длиной которую задает пользователь

void PrintArray(string[] arr){
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++){
        if (i == arr.Length -1)
        {
            Console.Write($"\"{arr[i]}\"");
        }
        else
        {
            Console.Write($"\"{arr[i]}\", ");
        } 
    }
    Console.Write("]");
}
// Функция для вывода массива пользователя на экран

string[] Symbol(string[] arr) {   
    int count = 0;
    int index = 0;
    for (int i = 0; i < arr.Length; i++) { 
        if (arr[i].Length < 4) 
        {
            count++;
        }
    }
    // Нашел длину для нового массива, записал в переменную count
    string[] res = new string[count];
    for (int j = 0; j < arr.Length; j++) { 
        if (arr[j].Length < 4) 
        {
            res[index] = arr[j];
            index++;
        }
    }
    // Заполнил массив res, через условие
    return res;
}
// Функция для формирования нового массива, который будет удовлетворять требование:
// из имеющегося массива строк формирует массив из строк, длина которых меньше либо 
// равна 3 символа


Console.WriteLine("Please enter the length of your array: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] arr = CreateArray(size);
// Сохраняю в переменную arr, результат выполнения функции CreateArray

PrintArray(arr);

string[] result = Symbol(arr);
// Сохраняю в переменную result, результат выполнения функции Symbol

Console.Write("->");
PrintArray(result);