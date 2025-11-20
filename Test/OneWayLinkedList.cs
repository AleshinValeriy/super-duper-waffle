using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{

    //Класс узел для односвязного списка
    public class Node
    {
        public int Value;
        public Node Next;

        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }

    //Класс одновзяный список
    public class OneWayLinkedList
    {
        private Node head;

        //Конструктор класса односвязный список
        public OneWayLinkedList()
        {
            head = null;
        }

        //Добавление числа в конец списка
        public void Add(int value)
        {
            Node newNode = new Node(value);

            if (head == null)
            {
                head = newNode;
            }

            else
            {
                Node Current = head;
                while (Current.Next != null)
                {
                    Current = Current.Next;
                }

                Current.Next = newNode;
            }
        }

        //Получение элемента списка по индексу
        public int Get(int index)
        {
            Node current = head;
            int counter = 0;

            while (current != null)
            {
                if (counter == index)
                {
                    return current.Value;
                }
                current = current.Next;
                counter++;
            }
            throw new IndexOutOfRangeException();
        }

        public void Set(int index, int value)
        {
            Node current = head;
            int counter = 0;

            while (current != null)
            {
                if (counter == index)
                {
                    current.Value = value;
                }
                current = current.Next;
                counter++;
            }
        }

        //Отчистка списка
        public void Clear()
        {

            Node current = head;

            while (current != null)
            {
                Node next = current.Next;
                current.Next = null;
                current = next;
            }
            head = null;
        }

        private void Swap(int index1, int index2)
        {
            Node current1 = head;
            int counter1 = 0;

            Node current2 = head;
            int counter2 = 0;

            while (current1 != null)
            {
                if (counter1 == index1) {
                    break;
                }
                counter1++;
                current1 = current1.Next;
            }

            while (current2 != null)
            {
                if (counter2 == index2)
                {
                    break;
                }
                counter2++;
                current2 = current2.Next;
            }

            int tmp = current1.Value;
            current1.Value = current2.Value;
            current2.Value = tmp;

        }

        //Генерация отсортированного списка
        public void Generate_Ordered(int size)
        {
            if (size <= 0) return;

            Random rnd = new Random();

            int CurrentValue = rnd.Next(1, 5);

            Add(CurrentValue);

            for (int i = 1; i < size; i++)
            {
                CurrentValue += rnd.Next(1, 5);
                Add(CurrentValue);
            }
        }

        //Генерация неотсортированного списка
        public void Generate_Unordered(int size)
        {

            if (size <= 0) return;

            Random rnd = new Random();

            Add(rnd.Next(1, size));

            for (int i = 1; i < size; i++)
            {
                Add(rnd.Next(1, size) + rnd.Next(1, 5));
            }
        }

        //Список, сортированный в обратном порядке
        public void Generate_rOrdered(int size)
        {
            if (size <= 0) return;

            Random rnd = new Random();
            int CurrentValue = 0;

            for (int i = 0; i < size; i++)
            {
                CurrentValue += rnd.Next(1, 5);
            }

            Add(CurrentValue);

            for (int i = 1; i < size; i++)
            {
                CurrentValue -= rnd.Next(1, 5);
                Add(CurrentValue);
            }
        }

        //Частично сгенерированный список
        public void Generate_PartlyOrdered(int size, int percentOfOrdered)
        {
            Random rnd = new Random();

            int sortedSize = (int)Math.Round(size * (percentOfOrdered / 100.0));

            Generate_Ordered(sortedSize);

            for (int i = sortedSize; i < size; i++)
            {
                Add((int)((rnd.Next(i, size) + rnd.Next(1, 5))));
            }
        }

        //Сортировка Шелла
        public void ShellSort(int size)
        {

            int step = size / 2;

            int j = 0;

            while (step > 0)
            {
                for (int i = 0; i < (size - step); i++)
                {
                    j = i;
                    while ((j >= 0) && (Get(j) > Get(j + step)))
                    {
                        Swap(j, j + step);
                        j -= step;
                    }
                }

                step /= 2;

            }

        }

        //Вспомогательная функция для пирамидальной сортировки
        private void Heapify(int size, int i)
        {
            int Largest = i;
            int L = 2 * i + 1;
            int R = 2 * i + 2;

            if (L < size && Get(L) > Get(Largest))
            {
                Largest = L;
            }

            if (R < size && Get(R) > Get(Largest))
            {
                Largest = R;
            }

            if (Largest != i)
            {

                Swap(i, Largest);

                Heapify(size, Largest);
            }
        }

        //Пирамидальная сортировка
        public void HeapSort(int size)
        {
            for (int i = size / 2 - 1; i >= 0; i--)
            {
                Heapify(size, i);
            }

            for (int i = size - 1; i >= 0; i--)
            {
                Swap(i, 0);

                Heapify(i, 0);
            }

        }

        //Сортировка подсчётом
        public void CountSort(int size)
        {
            int minElement = Get(0);
            int maxElement = Get(0);

            for (int i = 1; i < size; i++)
            {
                int val = Get(i);
                if (val < minElement) minElement = val;
                if (val > maxElement) maxElement = val;
            }

            int range = maxElement - minElement + 1;
            int[] count = new int[range];

            for (int i = 0; i < size; i++)
            {
                count[Get(i) - minElement]++;
            }

            int index = 0;
            for (int i = 0; i < range; i++)
            {
                while (count[i] > 0)
                {
                    Set(index, i + minElement);
                    index++;
                    count[i]--;
                }
            }
        }

        //Клонирование списка
        public OneWayLinkedList Clone()
        {
            OneWayLinkedList newList = new OneWayLinkedList();
            Node current = head;
            while (current != null)
            {
                newList.Add(current.Value);
                current = current.Next;
            }
            return newList;
        }
    }
}
