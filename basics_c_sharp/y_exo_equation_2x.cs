// FLYING PAD | C# | ...
// ----------------------------------------------------------------------------------------------------------------------
#region 1. Résoudre une équation du 2e degré 

// ax² + bx + c = 0

Equation equation = new Equation();

equation.A = 2;
equation.B = -9;
equation.C = -5;

equation.ResolveEquation(out double? X1, out double? X2);

Console.WriteLine($"{X1} {X2}");

public struct Equation
{
    public double A;
    public double B;
    public double C;

    public bool ResolveEquation(out double? X1, out double? X2)
    {
        double Delta = Math.Pow(B, 2) - (4 * A * C);

        if (Delta >= 0 && A != 0)
        {
            X1 = (-B - Math.Sqrt(Delta) / 2 * A);
            X2 = (-B + Math.Sqrt(Delta) / 2 * A);
            return true;
        }
        else
        {
            X1 = null;
            X2 = null;
            return false;
        }
    }
}

#endregion
// ----------------------------------------------------------------------------------------------------------------------