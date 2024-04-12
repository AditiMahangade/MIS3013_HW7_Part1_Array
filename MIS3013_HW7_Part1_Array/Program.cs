// Aditi Mahangade
// MIS 3013 HW7 Part 1 Array

string[] clientNameArr;
clientNameArr = new string[10];
double[] bankBalanceArr;
bankBalanceArr = new double[10];
string m;

for (int i = 0; i < clientNameArr.Length; i++)
{
    m = string.Format($"Please input the client {i + 1} name: ");
    Console.Write(m);
    string name = Console.ReadLine();
    clientNameArr[i] = name;

    m = string.Format($"Please input the client {i + 1} balance: ");
    Console.Write(m);
    string balanceStr = Console.ReadLine();
    double balanceDbl = Convert.ToDouble(balanceStr);

    bankBalanceArr[i] = balanceDbl;
}

Console.Write("\nThe clients' names:\n");
for (int i = 0; i < clientNameArr.Length; i++)
{
    Console.WriteLine(clientNameArr[i]);
}

Console.WriteLine("\nPlease input a client name: ");
string searchClientName = Console.ReadLine();
for (int i = 0; i < clientNameArr.Length; i++)
{
    if (clientNameArr[i] == searchClientName)
    {
        m = string.Format($"Client name: {searchClientName}, Balance: {bankBalanceArr[i]:C2}");
        Console.WriteLine(m);
    }
}
