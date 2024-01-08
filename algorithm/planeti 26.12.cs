class Program
{
    static void Main(string[] args)
    {
        Planeta[] planeti = new Planeta[5];
        planeti[0] = new Planeta("BMW", 100);
        planeti[1] = new Planeta("Den", 0);
        planeti[2] = new Planeta("Babyfox", 1000);
        planeti[3] = new Planeta("Matanaliz", 10);
        planeti[4] = new Planeta("Doska", 10000);

        List<int> sortedPlaneti = new List<int>();
        foreach (Planeta x in planeti) if (!sortedPlaneti.Contains(x.sputnikiAmount)) sortedPlaneti.Add(x.sputnikiAmount);
        sortedPlaneti.Sort();
        for (int i = (sortedPlaneti.Count - 1); i >= 0; i--)
        {
            foreach (Planeta planeta in planeti) if (planeta.sputnikiAmount == sortedPlaneti[i]) Console.WriteLine($"{planeta.name}: {planeta.sputnikiAmount}");
        }
    }
}
class Planeta
{
    public string name;
    public int sputnikiAmount;

    public Planeta(string name, int amount)
    {
        this.name = name;
        this.sputnikiAmount = amount;
    }
}
