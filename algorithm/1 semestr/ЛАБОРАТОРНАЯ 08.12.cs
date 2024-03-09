class Program
{
    static void Main(string[] args)
    {
        string[] crediti1 = { "Na mashinu", "Na edu", "Na babyfox" };
        string[] crediti2 = { "Na dosku", "Na kvartiru", "Na yachtu", "Na Dubai" };
        MainPersonal rabotnik1 = new MainPersonal("Den Bucketov", 25, 1, crediti1);
        MainPersonal rabotnik2 = new MainPersonal("Max Kabelev", 23, 1, crediti2);
        ExtraPersonal rabotnik3 = new ExtraPersonal("1", 24, 2, 15000);
        ExtraPersonal rabotnik4 = new ExtraPersonal("2", 20, 1, 15000);
        ExtraPersonal rabotnik5 = new ExtraPersonal("3", 50, 16, 50000);
        MainPersonal[] mainPersonals = { rabotnik1, rabotnik2 };
        ExtraPersonal[] extraPersonals = { rabotnik3, rabotnik4, rabotnik5 };
        foreach (var ma in mainPersonals) { ma.CreditiAmount(ma); }
        new ExtraPersonal("", 0, 0, 0).ZarplataAmount(extraPersonals);
    }
}
class Sotrudnik
{
    public string name { get; set; }
    public int vozrast { get; set; }
    public int opit { get; set; }
    public Sotrudnik(string name, int vozrast, int opit)
    {
        this.name = name;
        this.vozrast = vozrast;
        this.opit = opit;
    }
    public int CountEl(List<int> mas, int elem)
    {
        int count = 0;
        foreach (var ma in mas) if (ma == elem) count++;
        return count;
    }
}
class MainPersonal : Sotrudnik
{
    string[] crediti { get; set; }
    public MainPersonal(string name, int vozrast, int opit, string[] crediti) : base(name, vozrast, opit)
    {
        this.crediti = crediti;
    }
    public void CreditiAmount(MainPersonal rabotnik)
    {
        Console.WriteLine($"Работник {rabotnik.name} выдал {rabotnik.crediti.Length} кредитs");
    }
}
class ExtraPersonal : Sotrudnik
{
    int zarplata { get; set; }
    public ExtraPersonal(string name, int vozrast, int opit, int zarplata) : base(name, vozrast, opit)
    {
        this.zarplata = zarplata;
    }
    public void ZarplataAmount(ExtraPersonal[] rabotniki)
    {
        var lst1 = new List<int>();
        var lst2 = new List<int>();
        foreach (ExtraPersonal rabotnik in rabotniki)
        {
            if (!lst1.Contains(rabotnik.zarplata))
            {
                lst1.Add(rabotnik.zarplata);
            }
            lst2.Add(rabotnik.zarplata);
        }
        foreach (int zarplata in lst1) Console.WriteLine($"Зарплата: {zarplata}; Количество зарплат: {CountEl(lst2, zarplata)}");
    }
}
