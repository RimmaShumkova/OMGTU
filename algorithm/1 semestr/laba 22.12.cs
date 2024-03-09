class Tsex
{
    public static void FindTsexByName(Tsex tsex, string name)
    {
        if (tsex._name == name)
        {
            Console.WriteLine($"Нейм: {tsex._name}, ");
            for (int i = 0; i < tsex._yearVipuska.Length; i++)
            {
                Console.WriteLine($"Год выпуска: {tsex._yearVipuska[i]}, Кол-во продакшн: {tsex._kolichestvoProduction[i]}, Интенсивность: {Convert.ToInt32(tsex._kolichestvoProduction[i]) / 365}");
            }
        }
    }

    public static void FindTsexByYearVipuska(Tsex tsex, string yearVipuska)
    {
        for (int i = 0; i < tsex._yearVipuska.Length; i++)
        {
            if (tsex._yearVipuska[i] == yearVipuska)
            {
                Console.WriteLine($"Нейм: {tsex._name} Год выпуска: {yearVipuska}, Кол-во продакшн: {tsex._kolichestvoProduction[i]}, Интенсивность: {Convert.ToInt32(tsex._kolichestvoProduction[i]) / 365}");
            }
        }
    }

    public static void FindTsexByKolichestvo(Tsex tsex, string kolichestvoProduction)
    {
        for (int i = 0; i < tsex._kolichestvoProduction.Length; i++)
        {
            if (tsex._kolichestvoProduction[i] == kolichestvoProduction)
            {
                Console.WriteLine($"Нейм: {tsex._name},  Год выпуска: {tsex._yearVipuska[i]},  Кол-во продакшн: {kolichestvoProduction}, Интенсивность: {Convert.ToInt32(kolichestvoProduction) / 365}");
            }
            
        }
    }

    public static void Filter(string filter, Tsex[] tsexi)
    {
        if (filter == "n")
        {
            Console.Write("Введите name: ");
            string tsexName = Console.ReadLine();
            
            foreach (Tsex tsex in tsexi)
            {
                Tsex.FindTsexByName(tsex, tsexName);
            }
        }

        if (filter == "v")
        {
            Console.Write("Введите year vipuska: ");
            string tsexVipusk = Console.ReadLine();
            

            foreach (Tsex tsex in tsexi)
            {
                Tsex.FindTsexByYearVipuska(tsex, tsexVipusk);
            }
        }

        if (filter == "k")
        {
            Console.Write("Введите kolichestvo production: ");
            string kolichestvoProduction = Console.ReadLine();

            foreach (Tsex tsex in tsexi)
            {
                Tsex.FindTsexByKolichestvo(tsex, kolichestvoProduction);
            }
            
        }
    }

    string _name;
    string[] _yearVipuska, _kolichestvoProduction;

    public Tsex(string name, string[] yearVipuska, string[] kolichestvoProduction)
    {
        this._name = name;
        this._yearVipuska = yearVipuska;
        this._kolichestvoProduction = kolichestvoProduction;
    }
}

class Program
{
    static void Main()
    {
        Tsex[] tsexi = new Tsex[2];
        tsexi[0] = new Tsex("babyfox", new string[] { "2021", "2022", "2023" }, new string[] { "3650", "100000", "987654321" });
        tsexi[1] = new Tsex("mashini", new string[] { "2010", "2015", "2023" }, new string[] { "50", "1234", "1000000" });

        Console.WriteLine("Введите тип фильтра ('n' name, 'v' vipusk 'k' kolichestvo)");
        string filter = Console.ReadLine();

        Tsex.Filter(filter, tsexi);
    }
