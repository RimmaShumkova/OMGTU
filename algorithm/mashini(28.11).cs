class Mashina
{
    public static void FindCarByName(Mashina mashina, string name)
    {
        if (mashina._name == name)
        {
            Console.WriteLine($"Нейм: {mashina._name}, Год выпуска: {mashina._yearVipuska}, Калор: {mashina._color}");
            for (int i = 0; i < mashina._yearTexosmotra.Length; i++)
            {
                Console.WriteLine($"Год техосмотра: {mashina._yearTexosmotra[i]}");
            }
            for (int i = 0; i < mashina._vladelec.Length; i++)
            {
                Console.WriteLine($"Владелец: {mashina._vladelec[i]}");
            }
            Console.WriteLine("\n");
        }
    }

    public static void FindCarByYearVipuska(Mashina mashina, string yearVipuska)
    {
        if (mashina._yearVipuska == yearVipuska)
        {
            Console.WriteLine($"Нейм: {mashina._name}, Год выпуска: {mashina._yearVipuska}, Калор: {mashina._color}");
            for (int i = 0; i < mashina._yearTexosmotra.Length; i++)
            {
                Console.WriteLine($"Год техосмотра: {mashina._yearTexosmotra[i]}");
            }
            for (int i = 0; i < mashina._vladelec.Length; i++)
            {
                Console.WriteLine($"Владелец: {mashina._vladelec[i]}");
            }
            Console.WriteLine("\n");
        }
    }
    public static void FindCarByYearTexosmotra(Mashina mashina, string yearTexosmotra)
    {
        for (int i = 0; i < mashina._yearTexosmotra.Length; i++)
        {
            if (mashina._yearTexosmotra[i] == yearTexosmotra)
            {
                Console.WriteLine($"{mashina._name} Proshel in {yearTexosmotra} year");
            }
        }
        
    }

    public static void Filter(string filter, Mashina[] mashini)
    {
        if (filter == "n")
        {
            Console.Write("Введите name: ");
            string mashinaName = Console.ReadLine();
            foreach (Mashina mashina in mashini)
            {
                Mashina.FindCarByName(mashina, mashinaName);
            }
        }

        if (filter == "v")
        {
            Console.Write("Введите year vipuska: ");
            string mashinaVipusk = Console.ReadLine();
            foreach (Mashina mashina in mashini)
            {
                Mashina.FindCarByYearVipuska(mashina, mashinaVipusk);
            }
        }

        if (filter == "t")
        {
            Console.Write("Введите year texosmotra: ");
            string mashinaTexosmotr = Console.ReadLine();
            foreach (Mashina mashina in mashini)
            {
                Mashina.FindCarByYearTexosmotra(mashina, mashinaTexosmotr);
            }
        }
    }

    string _name, _yearVipuska, _color;
    string[] _yearTexosmotra, _vladelec;

    public Mashina(string name, string yearVipuska, string[] yearTexosmotra, string[] vladelec, string color)
    {
        this._name = name;
        this._yearVipuska = yearVipuska;
        this._yearTexosmotra = yearTexosmotra;
        this._vladelec = vladelec;
        this._color = color;
    }
}

class Program
{
    static void Main()
    {
        Mashina[] mashini = new Mashina[6];
        mashini[0] = new Mashina("bmw", "2017", new string[] { "2017", "2018", "2019" }, new string[] { "Rimma Shumkova", "Ksenia Avdyushkina", "Yana Istomina" }, "seriy color");
        mashini[1] = new Mashina("mersedes", "2022", new string[] { "2022", "2023" }, new string[] { "Shumkova Rimma", "Avdyushkina Ksenia", "Istomina Yana" }, "cherniy color");
        mashini[2] = new Mashina("chetirka(yaz-2114)", "2010", new string[] { "2011", "2018", "2023" }, new string[] { "Shumkova R", "Avdyushkina K", "Istomina Y" }, "beliy color");
        mashini[3] = new Mashina("323 marik", "2020", new string[] { "2020", "2021", "2023" }, new string[] {"Ksenia Avdyushkina" }, "orange color");
        mashini[4] = new Mashina("424 marik", "2021", new string[] { "2022", "2023" }, new string[] { "Shumkova Rimma" }, "beliy color");
        mashini[5] = new Mashina("73 autobus", "2022", new string[] { "2022"}, new string[] { "Istomina Y" }, "zeleniy color");

        Console.WriteLine("Введите тип фильтра ('n' name, 'v' vipusk 't' texosmotr)");
        string filter = Console.ReadLine();

        Mashina.Filter(filter, mashini);
    }
}
