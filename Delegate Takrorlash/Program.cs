using Delegate_Takrorlash;
using Wwn = Delegate_Takrorlash.Working_with_numbers;
BaseMethod basa = new();
var result = basa.FuncMethod(12, 34, Wwn.Pow);
basa.ActionMethod(23.5, Wwn.Print);
Console.WriteLine(basa.PredicateMethod(34, Wwn.Fibonachi));
