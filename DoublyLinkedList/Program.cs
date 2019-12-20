using System;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> L = new DoublyLinkedList<int>();
            char esc;
            string str;
            do
            {
                Console.WriteLine("0. Usuwanie wszystkich elementów listy");
                Console.WriteLine("1. Sprawdzanie czy lista jest pusta");
                Console.WriteLine("2. Wyszukiwanie elementu na liście ");
                Console.WriteLine("3. Wstawienie elementu na początek listy ");
                Console.WriteLine("4. Wstawienie elementu na koniec listy ");
                Console.WriteLine("5. Usuwanie elementu z początku listy ");
                Console.WriteLine("6. Usuwanie elementu z końca listy ");
                Console.WriteLine("7. Wstawienie elementu za wybranym elementem listy ");
                Console.WriteLine("8. Wstawienie elementu do listy w sposób uporządkowany");
                Console.WriteLine("9. Usuwanie wybranegp elementu z listy ");
                Console.WriteLine("10. Wyświetlanie listy od głowy");
                Console.WriteLine("11. Wyświetlanie listy od ogona");
                str = Console.ReadLine();
                int.TryParse(str, out int choice);
                switch(choice)
                {
                    case 0:
                        {
                            while (!L.IsEmpty())
                                L.DeleteFirst();
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine(L.IsEmpty());
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Podaj klucz węzła jaki chcesz wyszukać na liście");
                            str = Console.ReadLine();
                            int.TryParse(str, out int key);
                            if (L.Find(key) == null)
                                Console.WriteLine("Węzła o podanym kluczu nie znaleziono");
                            else
                                Console.WriteLine("Węzeł o podanym kluczu znaleziono");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Podaj klucz węzła jaki chcesz wstawić");
                            str = Console.ReadLine();
                            int.TryParse(str, out int dd);
                            L.InsertFirst(dd);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Podaj klucz węzła jaki chcesz wstawić");
                            str = Console.ReadLine();
                            int.TryParse(str, out int dd);
                            L.InsertLast(dd);
                            break;
                        }
                    case 5:
                        {
                            Link<int> temp = L.DeleteFirst();
                            if (temp == null)
                                Console.WriteLine("Węzła nie udało się usunąć");
                            else
                            {
                                Console.WriteLine("Usunięto węzeł:");
                                temp.DisplayLink();
                                Console.WriteLine();
                            }
                            break;
                        }
                    case 6:
                        {
                            Link<int> temp = L.DeleteLast();
                            if (temp == null)
                                Console.WriteLine("Węzła nie udało się usunąć");
                            else
                            {
                                Console.WriteLine("Usunięto węzeł:");
                                temp.DisplayLink();
                                Console.WriteLine();
                            }
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Podaj klucz węzła za którym chcesz wstawić węzeł do listy");
                            str = Console.ReadLine();
                            int.TryParse(str, out int key);
                            Console.WriteLine("Podaj klucz węzła jaki chcesz wstawić do listy");
                            str = Console.ReadLine();
                            int.TryParse(str, out int dd);
                            Console.WriteLine(key.ToString() + " " +dd.ToString());
                            bool isInserted = L.InsertAfter(key, dd);
                            if (isInserted)
                                Console.WriteLine("Węzeł udało się wstawić");
                            else
                                Console.WriteLine("Węzła nie udało się wstawić");
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Podaj klucz węzła jaki chcesz wstawić");
                            str = Console.ReadLine();
                            int.TryParse(str, out int dd);
                            L.Insert(dd);
                            break;
                        }
                    case 9:
                        {
                            Console.WriteLine("Podaj klucz węzła jaki chcesz usunąć");
                            str = Console.ReadLine();
                            int.TryParse(str, out int dd);
                            Link<int> temp = L.DeleteKey(dd);
                            if (temp == null)
                                Console.WriteLine("Węzła nie udało się usunąć");
                            else
                            {
                                Console.WriteLine("Usunięto węzeł:");
                                temp.DisplayLink();
                                Console.WriteLine();
                            }
                            break;
                        }
                    case 10:
                        {
                            L.DisplayForward();
                            break;
                        }
                    case 11:
                        {
                            L.DisplayBackward();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Brak operacji na liście");
                            break;
                        }
                }
                esc = (char)Console.ReadKey().Key;
            }
            while (esc != (char)ConsoleKey.Escape);
        }
    }
}
