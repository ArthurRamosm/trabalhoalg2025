double S = 0;
double A = 3;
double B = 2;

while ( B <= 50) {
    S += (double)A / B;
    A += 2;
    B++;
}
Console.WriteLine(S);
