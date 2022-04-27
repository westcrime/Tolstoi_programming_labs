using Task;

var eq1 = new Equation(3, -14, -5);
eq1.GetSolutions();

var eq2 = new Equation(1, 1, 1);
var eq3 = new Equation(1, 1, 1);
if (eq2 == eq3) Console.WriteLine("eq2 and eq3 are equal.");

var eq4 = new Equation(1, 1, 1);
var eq5 = new Equation(-10, 5, -2);
var eq6 = eq4 + eq5; // -9x^2 + 6x - 1 = 0
eq6.GetSolutions();

var eq7 = new Equation(6, 1, 8);
if (!eq7) Console.WriteLine("eq7 does not have solutions");

eq6--;
eq6++;

eq6.GetSolutions();

eq6 *= 2;
eq6 /= 2;

eq6.GetSolutions();