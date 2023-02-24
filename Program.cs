using System.Collections;

namespace FirstProgramme
{
    class Program
    {
        static void ShowIntArray(int[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine($"[{i}] -> {t[i]}");
            }
        }
        static int ShowMaxValueArray(int[] t)
        {
            return t.Max();
        }
        static void ShowStringArray(string[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine($"[{i}] -> {t[i]}");
            }
        }
        static int SommeArray(int[] t)
        {
            int sum = 0;

            for (int i = 0; i < t.Length; i++)
            {
                sum += t[i];
            }

            return sum;
        }
        static int[] CreateStaticIntArray()
        {

            Random rnd = new Random();

            const int MAX_LENGHT = 20;
            const int MAX_RANDOM = 100;

            int[] t = new int[MAX_LENGHT];

            for (int i = 0; i < MAX_LENGHT; i++)
            {
                t[i] = rnd.Next(0, MAX_RANDOM + 1);
            }

            return t;

        }
        static int[] CreateIntArray()
        {
            string[] noms = { "Martin", "Emilie", "Paul" };

            int[] t = { 1, 2, 3, 4, 5};

            int[] d = new int[3];

            d[0] = 1;
            d[1] = 4;
            d[2] = 6;

            for (int i = 0;i < d.Length; i++)
            {

                Console.WriteLine(d[i]);
            }

            Console.WriteLine($"SOMME : {SommeArray(d)}\n");

            for (int i = 0; i < noms.Length; i++)
            {

                Console.WriteLine($"{noms[i]}");
            }

            return d;


        }
        static string[] CreateStringArray()
        {

            string[] name = { "Martin", "Emilie", "Paul" };

            return name;
        }


        // LISTE 

        static void ShowList(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
        static List<int> CreateListe()
        {
            List<int> list = new List<int>();

            list.Add(1);
            list.Add(8);
            list.Add(2);
            list.Add(4);

            //list.Remove(8);
            //list.RemoveAt(1);

            return list;
        }
        static List<String> CreateNameRequest()
        {
            List<string> strings= new List<string>();


            string userPrompt = " ";

            while (userPrompt != "")
            {
                Console.Write("Renterez un nom {ENTER pour finir} : " );
                userPrompt = Console.ReadLine();

                if(userPrompt == "")
                {
                    return strings;
                }
                else if (strings.Contains(userPrompt))
                {
                    Console.WriteLine("Erreur, veulliez ne pas rentrée un nom deja présent");
                }
                else
                {
                    strings.Add(userPrompt);
                }
            }

            return strings;
        }
        static List<String> ShowNameRequest(List<string> list, bool toggle = false)
        {
            if (toggle)
            {
                for (int i = list.Count-1; i >= 0; i--)
                {
                    if (list[i].Substring(list[i].Length - 1) == "e")
                    {
                        Console.WriteLine(list[i][^1..]);
                        list.RemoveAt(i);
                        i--;
                    }
                    else
                    {
                        Console.WriteLine($" [{i}] -> {list[i]}");
                    }
                }
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine($" [{i}] -> {list[i]}");
                }
            }

            string nameMustLong = "";

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Length > nameMustLong.Length)
                {
                    nameMustLong = list[i];
                }
            }
            Console.WriteLine($"Le nom de le plus long de cette liste est : {nameMustLong}");

            return list;

        }

        static List<string> ShowCommunElement(List<string> list1, List<string> list2)
        {
            List<string> list3 = new List<string>();

            for (int i = 0; i < list1.Count; i++)
            {
                if (list2.Contains(list1[i]))
                {
                    Console.WriteLine($"liste 1 == liste 2 ({list1[i]})");
                }
                //for (int j = 0; j < list2.Count; j++)
                //{
                //    if (list1[i] == list2[j])
                //    {
                //        Console.WriteLine($"liste 1 == liste 2 ({list1[i]})");
                //    }
                //}
            }

            return list3;
        }

        // ARRAY LIST 

        static ArrayList CreateArrrayList()
        {
            ArrayList a = new ArrayList();

            a.Add("Toto");
            a.Add(49);
            a.Add(true);


            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }

            return a;
        }

        static List<List<string>> ListInList ()
        {
            List<List<string>> pays = new List<List<string>>();

            List<string> France = new List<string> { "France", "Paris", "Toulouse", "Nice", "Bordeaux", "Lille" };
            List<string> USA = new List<string> { "Etats-unis", "New-York", "Chicago", "Los angeles", "San Franscisco"};
            List<string> Espagne = new List<string> { "Espagne", "Madrid", "Barcelone", "Séville"};
            List<string> Italie = new List<string> { "Italie", "Venis", "Florence", "Milan", "Pise" };


            pays.Add(France);
            pays.Add(USA);
            pays.Add(Espagne);
            pays.Add(Italie);


            for (int i = 0; i < pays.Count; i++)
            {
                Console.WriteLine($"{pays[i][0]} = {pays[i].Count -1} villes");
                for (int j = 1; j < pays[i].Count; j++)
                {
                    Console.WriteLine(" " + pays[i][j]);
                }
                Console.WriteLine("===============");
            }

            return pays;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int[] myIntArray = CreateIntArray();
            int[] myStaticIntArray = CreateStaticIntArray();
            string[] myStringArray = CreateStringArray();

            Console.WriteLine("\n-======- INT ARRAY -======-\n");

            ShowIntArray(myIntArray);

            Console.WriteLine("=========");

            ShowIntArray(myStaticIntArray);

            Console.WriteLine($"La valeur max de StaticArray et : {ShowMaxValueArray(myStaticIntArray)}");

            ShowStringArray(myStringArray);

            Console.WriteLine("\n-======- -======-- LES LISTE -======- -======-\n");


            // LISTE 

            List<int> myIntList = CreateListe();

            ShowList(myIntList);

            Console.WriteLine("\n====- NAME -====\n");

            List<string> myNameList = CreateNameRequest();

            ShowNameRequest(myNameList);

            Console.WriteLine("========");

            ShowNameRequest(myNameList, true);


            Console.WriteLine("\n====- LISTE FUNCTION -====\n");

            List<String> ListOne = new List<string>() { "paul", "jean", "pierre", "emilie", "martin"};
            List<String> ListTwo = new List<string>() { "sophie", "jean", "martin", "toto"};

            ShowCommunElement(ListOne, ListTwo);

            Console.WriteLine("\n-======- -======-- LES ARRAYS LISTE -======- -======-\n");


            ArrayList myArrayList = CreateArrrayList();

            Console.WriteLine("\n-======- -======-- Liste dans une liste -======- -======-\n");

            List<List<string>> myCountryList = ListInList();


        }
    }
}