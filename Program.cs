// See https://aka.ms/new-console-template for more information
using GenericsTraining.cs;


Generic gen = new Generic();

int x = 10;
int y = 33;
gen.Swap(ref x, ref y);

string txt1 = "abc";
string txt2 = "xyz";
gen.Swap(ref txt1, ref txt2);

//creating a generic instance of typ int of class GenericClass
GenericClass<int> genericInt = new GenericClass<int>();
GenericClass<double> genericDouble = new GenericClass<double>();

genericInt.Push(99);
genericInt.Push(80);
genericInt.Push(100);
int popInt = genericInt.Pop();
Console.WriteLine(popInt.ToString());

genericDouble.Push(101.05);
genericDouble.Push(102.05);
genericDouble.Push(103.05);
double popDouble = genericDouble.Pop();
Console.WriteLine(popDouble.ToString());


