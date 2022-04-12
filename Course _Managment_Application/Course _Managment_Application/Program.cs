using System;
using Course__Managment_Application.Enum;

namespace Course__Managment_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuchoice = 1; 
            if (menuchoice == 1)
            {
                Console.WriteLine("\t\t\t\t\t[Course Management Application]\n\n" +
                "[1]- Yeni qrup yarat\n" +
                "[2]- Qrupların siyahısını göstər\n" +
                "[3]- Qrup üzərində düzəliş etmək\n" +
                "[4]- Qrupdakı tələbələrin siyahısını göstər\n" +
                "[5]- Bütün tələbələrin siyahısını göstər\n" +
                "[6]- Tələbə yarat\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\t\t\t\t\t[Qrup Yaratmaq]\n\n");
                        Console.WriteLine("\t\t\tIxtisasi Secimini edin:\n\n" +
                           "[1]- Programming\n" +
                           "[2]- Design\n" +
                           "[3]- System Administration\n");
                        Categories category = new Categories();
                        int categorychoice = Convert.ToInt32(Console.ReadLine());
                        switch (categorychoice)
                        {
                            case 1:
                                category = Categories.Programming;
                                break;
                            case 2:
                                category = Categories.Design;
                                break;
                            case 3:
                                category = Categories.System_Administration;
                                break;
                            default:
                                Console.WriteLine("Uygun secim secin!!");
                                break;
                        }
                        Console.Clear();

                        Console.WriteLine("\t\t\tTehsil Formasini secin :\n\n" +
                           "[1]- Online\n" +
                           "[2]- Offline\n");
                        bool isonline = false;
                        int checkonline = Convert.ToInt32(Console.ReadLine());
                        switch (checkonline)
                        {
                            case 1:
                                isonline = true;
                                break;
                            case 2:
                                isonline = false;
                                break;
                            default:
                                Console.WriteLine("Uygun secim secin!!");
                                break;
                        }
                        Group group = new Group(category, isonline);
                        Console.Clear();
                        break;

                }
                Console.WriteLine("\t\t\tDavam etmek isteyirsiniz? :\n\n" +
                           "[1]- Menuya qayid\n" +
                           "[2]- Cixis\n");
                menuchoice = Convert.ToInt32(Console.ReadLine());
                

            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
