Задача 1:

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n = InputNumbers("Введите n: ");
int count = 2;
PrintNumber(n, count);
Console.Write(1);

void PrintNumber(int n, int count)
{
  if (count > n) return;
  PrintNumber(n, count + 1);
  Console.Write(count + ", ");
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

Задача 2:

// m = 2, n = 3 -> A(m,n) = 9

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

Задача 3:

// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

public static int [] CreateArray (int size, int max, int min){
            int [] array  = new int[size];
            Random rand = new();
            for (int i = 0; i < size; i++)
            {
                array [i] = rand.Next(min,max+1);
            }
            return array;
        }
        public static string PrintArray(int [] array)
        {
            return string.Join(", ",array);
        }
        public static int [] ArraySwap(int [] array,int index)
        {

            if (index <= 0)
            {
                return array;
            }
            int temp = array[index];
            array[index] = array[array.Length - index-1];
            array[array.Length - index-1] = temp;
            return ArraySwap(array,index -= 2);
        }
