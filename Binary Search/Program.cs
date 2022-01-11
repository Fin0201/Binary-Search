List<int> A = new List<int>() { 3, 5, 2, 1, 7, 4, 19, 4, 5, 9, 10, 11 };
int X = 19;

A.Sort();


int itemFound = A.BinarySearch(X);
Console.WriteLine($"The number {X} was found in position {itemFound}.");