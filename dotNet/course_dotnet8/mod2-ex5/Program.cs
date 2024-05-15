using mod2_ex5.Operations;

int nb1 = 6;
int nb2 = 8;

Addidion add = new(nb1, nb2);
add.Executer();
Console.WriteLine(add.Resultat);

Soustraction sub = new(nb1, nb2);
sub.Executer();
Console.WriteLine(sub.Resultat);

Multiplication mul = new(nb1, nb2);
mul.Executer();
Console.WriteLine(mul.Resultat);

Division div = new(nb1, nb2);
div.Executer();
Console.WriteLine(div.Resultat);

Modulo mod = new(nb1, nb2);
mod.Executer();
Console.WriteLine(mod.Resultat);
