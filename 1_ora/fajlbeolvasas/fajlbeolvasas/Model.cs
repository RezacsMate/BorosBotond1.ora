using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fajlbeolvasas
{
    public class Model
    {
        // - Hozz létre egy List<Car> típusú listát!
        public List<Car> list = new();
        // - Készíts private függvényt, amely beolvassa a cars.txt fájl tartalmát!
        private void Import(string filename) 
        {
            list = File.ReadAllLines(filename).Skip(1).Select(x=> new Car(x)).ToList();

        }
        // - Készíts konstruktort, ahol meghívod a függvényt.
        // 1. Készíts egy függvényt, amely visszaadja az összes autó típusát!
        public Model() 
        {
            Import("cars.txt");
        }
        // 2. Készíts egy függvényt, amely paraméterként kap egy évszámot, és visszaadja a paraméterként kapott év után gyártott autók típusát!
        public List<string> feledet2(int year) 
        {
            return list.Where(x=>x.bouldYear > year).Select(x=>x.type).ToList();            
        }
        // 3. Készíts egy függvényt, amely paraméterként kap egy lóerőt, és visszaadja azoknak az autóknak a típusát, amelyek erősebbek a megadott lóerőnél!
        public List<string> feledet3(int loro)
        {
            return list.Where(x => x.HP > loro).Select(x => x.type).ToList();
        }
        // 4. Készíts egy függvényt, amely paraméterként kap egy maximális árat, és visszaadja az ennél olcsóbb autók típusát!
        public List<string> feledet4(int maxprice)
        {
            return list.Where(x => x.price < maxprice).Select(x => x.type).ToList();
        }
        // 5. Készíts egy függvényt, amely paraméterként kap egy márkát, és visszaadja, hogy hány darab autó található az adott márkából!
        public int feledet5(string band)
        {
            return list.Where(x => x.brand == band).Count();
        }
        // 6. Készíts egy függvényt, amely paraméterként kap egy márkát, és eldönti, hogy található-e legalább egy ilyen márkájú autó a listában!
        public bool feledet6(string brand)
        {
            return list.Any(x => x.brand == brand);
        }
        // 7. Készíts egy függvényt, amely paraméterként kap egy lóerőt, és eldönti, hogy található-e a megadott értéknél erősebb autó!
        public bool feledet7(int loero)
        {
            return list.Any(x => x.HP > loero);
        }
        // 8. Készíts egy függvényt, amely meghatározza és visszaadja a legdrágább autó árát!
        public int feladat8()
        {
            return list.Max(x => x.price);
        }
        // 9. Készíts egy függvényt, amely paraméterként kap egy márkát, és visszaadja az adott márkához tartozó autók átlagos lóerejét!
        public double feledet7(string brand)
        {
            return list.Where(x=>x.brand == brand).Average(x=>x.HP);
        }
        // 10. Készíts egy függvényt, amely kiszámolja és visszaadja az összes autó átlagos árát!
        public double feledet10()
        {
            return list.Average(x => x.price);
        }
        // 11. Készíts egy függvényt, amely ár szerint növekvő sorrendbe rendezi az autókat, majd ebben a sorrendben visszaadja az autók típusát!
        public List<string> feledet11()
        {
            return list.OrderBy(x=>x.price).Select(x=>x.type).ToList();
        }
        // 12. Készíts egy függvényt, amely lóerő szerint csökkenő sorrendbe rendezi az autókat, majd ebben a sorrendben visszaadja az autók típusát!
        public List<string> feledet12()
        {
            return list.OrderByDescending(x => x.HP).Select(x => x.type).ToList();
        }
        // 13. Készíts egy függvényt, amely paraméterként kap két évszámot, és visszaadja azoknak az autóknak a típusát, amelyek gyártási éve a két megadott év közé esik!
        public List<string> feledet13(int minev, int maxev)
        {
            return list.Where(x=>x.bouldYear> minev && x.bouldYear<maxev).Select(x=>x.type).ToList();
        }
        // 14. Készíts egy függvényt, amely paraméterként kap egy minimum lóerőt és egy maximális árat, majd visszaadja azoknak az autóknak a típusát, amelyek legalább a megadott lóerővel rendelkeznek és olcsóbbak a megadott árnál!
        public List<string> feledet14(int minlo, int maxar)
        {
            return list.Where(x => x.HP > minlo && x.price< maxar).Select(x => x.type).ToList();
        }
        // 15. Készíts egy függvényt, amely megkeresi a legfiatalabb autót, és visszaadja annak típusát!
        public string feledet15()
        {
            return list.OrderByDescending(x=>x.bouldYear).Select(x=>x.type).First();
        }
        // 16. Készíts egy függvényt, amely megkeresi a legrégebbi autót, és visszaadja annak típusát!
        public string feledet16()
        {
            return list.OrderBy(x => x.bouldYear).Select(x => x.type).First();
        }

        // 17. Készíts egy függvényt, amely paraméterként kap egy darabszámot, és visszaadja a megadott darabszámú legdrágább autó típusát, ár szerint csökkenő sorrendben!
        public List<string> feledet17(int db)
        {
            return list.OrderByDescending(x=>x.price).Select(x=>x.type).Take(db).ToList();
        }
        // 18. Készíts egy függvényt, amely paraméterként kap egy darabszámot, és visszaadja a megadott darabszámú legerősebb autó típusát, lóerő szerint csökkenő sorrendben!
        public List<string> feledet18(int db)
        {
            return list.OrderByDescending(x => x.HP).Select(x => x.type).Take(db).ToList();
        }
        // 19. Készíts egy függvényt, amely paraméterként kap egy márkát, megkeresi az összes hozzá tartozó autót, majd lóerő szerint csökkenő sorrendben visszaadja azok típusát!
        public List<string> feledet19(string brand)
        {
            return list.OrderByDescending(x => x.HP).Where(x=>x.brand == brand).Select(x => x.type).ToList();
        }
        // 20. Készíts egy függvényt, amely paraméterként kap egy évszámot, és visszaadja, hány autó készült a megadott évben vagy később!
        public int feledet20(int ev)
        {
            return list.Where(x => x.bouldYear >= ev ).Count();
        }
        // 21. Készíts egy függvényt, amely paraméterként kap egy minimum lóerőt, és kiszámolja az ennél legalább ilyen erős autók átlagárát!
        public double feledet21(int minlo)
        {
            return list.Where(x => x.HP >= minlo).Average(x => x.price);
        }
        // 22. Készíts egy függvényt, amely paraméterként kap egy minimum árat. Az ennél drágább autók közül keresd meg a legolcsóbbat, és add vissza annak típusát!
        public string feledet22(int minar)
        {
            return list.OrderBy(x=>x.price).Where(x => x.price >= minar).Select(x=>x.type).First();
        }
        // 23. Készíts egy függvényt, amely paraméterként kap egy évszámot. A megadott év után gyártott autók közül keresd meg a legerősebbet, és add vissza annak típusát!
        public string feledet23(int ev)
        {
            return list.OrderByDescending(x => x.HP).Where(x => x.bouldYear > ev ).Select(x => x.type).First();
        }
        // 24. Készíts egy függvényt, amely kiszámolja az összes autó átlagárát, majd visszaadja az átlagárnál olcsóbb autók típusát, ár szerint növekvő sorrendben!
        public List<string> feledet24(int ev)
        {
            return list.Where(x=>x.price < list.Average(x=>x.price)).OrderBy(x => x.price).Select(x=>x.type).ToList();
        }
        // 25. Készíts egy függvényt, amely visszaadja, milyen különböző márkák szerepelnek az adatbázisban! Egy márka csak egyszer szerepeljen az eredményben!
        public List<string> feledet25()
        {
            return list.Select(x=>x.brand).Distinct().ToList();
        }
        // 26. Készíts egy függvényt, amely megszámolja és visszaadja, hány különböző márka található az adatbázisban!
        public int feledet26()
        {
            return list.Select(x => x.brand).Distinct().Count();
        }
        // 27. Készíts egy függvényt, amely márka szerint csoportosítja az autókat, majd márkánként megadja, hogy hány autó tartozik az adott márkához!
        public Dictionary<string, int>  feledet27()
        {
            return list.GroupBy(x => x.brand).ToDictionary(x=>x.Key, y =>y.Count());
        }
        // 27. Készíts egy függvényt, amely márka szerint csoportosítja az autókat, majd márkánként megadja, hogy hány autó tartozik az adott márkához!

        // 28. Készíts egy függvényt, amely márka szerint csoportosítja az autókat, majd márkánként kiszámolja az autók átlagárát!

        // 29. Készíts egy függvényt, amely márka szerint csoportosítja az autókat, majd márkánként megadja az adott márkához tartozó legerősebb autó lóerejét!

        // 30. Készíts egy függvényt, amely márka szerint csoportosítja az autókat, majd márkánként megadja az adott márkához tartozó legdrágább autó árát!

        // 31. Készíts egy függvényt, amely márka szerint csoportosítja az autókat, majd márkánként kiszámolja az autók átlagos lóerejét!

        // 32. Készíts egy függvényt, amely márka szerint csoportosítja az autókat, majd márkánként megadja a legújabb autó típusát!

        // 33. Készíts egy függvényt, amely márka szerint csoportosítja az autókat, majd visszaadja azoknak a márkáknak a nevét, amelyekhez legalább 3 autó tartozik!

        // 34. Készíts egy függvényt, amely márka szerint csoportosítja az autókat, majd visszaadja a legtöbb autóval rendelkező márka nevét!

        // 35. Készíts egy függvényt, amely márka szerint csoportosítja az autókat. Minden márkából keresd meg a legerősebb autót, majd add vissza a márka nevét, az autó típusát és lóerejét!

        // 36. Készíts egy függvényt, amely márka szerint csoportosítja az autókat. Minden márkából keresd meg a legdrágább autót, majd add vissza a márka nevét, az autó típusát és árát!

        // 37. Készíts egy függvényt, amely paraméterként kap egy minimum átlagárat. Csoportosítsd az autókat márka szerint, számítsd ki minden márka autóinak átlagárát, majd add vissza azoknak a márkáknak a nevét, amelyek átlagára magasabb a paraméterként kapott értéknél!

        // 38. Készíts egy függvényt, amely paraméterként kap egy minimum darabszámot. Csoportosítsd az autókat márka szerint, majd add vissza azoknak a márkáknak a nevét, amelyekhez legalább a paraméterként megadott számú autó tartozik!

        // 39. Készíts egy függvényt, amely paraméterként kap egy évszámot. Csoportosítsd az autókat márka szerint, majd márkánként add vissza, hogy hány autó készült a paraméterként kapott évben vagy azután!

        // 40. Készíts egy függvényt, amely paraméterként kap egy minimum lóerőt. Csoportosítsd az autókat márka szerint, majd add vissza azoknak a márkáknak a nevét, amelyek autóinak átlagos lóereje legalább akkora, mint a paraméterként kapott érték!
    }
}
