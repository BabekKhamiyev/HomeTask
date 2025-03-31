using System;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

namespace HomeTask;

internal class Program
{
    static void Main(string[] args)
    {
        //Tapşırıq 1:
        //İki ədəd dəyişən yaradın və onların cəmini ekranda çap edən proqramı yazın.

        //int num1 = 5;
        //int num2 = 10;
        //Console.WriteLine(num1+num2);

        //Tapşırıq 2:
        //Bir dəyişəndə saxlanan ədədin kvadratını(özünə vurulmasını) ekranda çap edən proqramı yazın.

        //int eded = 15;
        //Console.WriteLine(eded*eded);

        //Tapşırıq 3:
        //Adınızı və yaşınızı ayrı dəyişənlərdə saxlayın, sonra bunları aşağıdakı kimi çap edən proqramı yazın:
        //Salam, mənim adım Boss - dur və mənim 222 yaşım var.

        //string name = "Babek";
        //byte age = 20;
        //Console.WriteLine($"Salam, mənim adım {name} - dir ve menim {age} yasim var");

        //Tapşırıq 4:
        //İki dəyişəndə saxlanılan ədədlərin dəyərlərinin yerini dəyişin və ekrana aşağıdaki kimi çap edən proqramı yazın(Üçüncü dəyişəndən əlavə etmək olar):
        //a dəyişəninin əvvəlki dəyəri 10, yer dəyişmədən sonra 20 - dir.
        //b dəyişəninin əvvəlki dəyəri 20, yer dəyişmədən sonra 10 - dur.

        //int num1 = 10;
        //int num2 = 20;
        //int num3=num1 ;
        //num1 = num2;
        //num2 = num3;
        //Console.WriteLine($"num1 deyiseninin evvelki deyeri {num2}, yer deyismeden sonra {num1} - dir.\nnum2 deyiseninin evvelki deyeri {num1}, yer deyismeden sonra {num3} - dir.");

        //Tapşırıq 5:
        //Daxil edilən üç tam ədədin cəmi və ədədi ortasını hesablayıb çap edən proqramı yazın.
        //int num1 = 15;
        //int num2 = 25;
        //int num3 = 34;
        //int sum = num1 + num2 + num3;
        //double edediOrta = Convert.ToDouble(num1 + num2 + num3) / 3;
        //Console.WriteLine($"cemi: {sum}\nededi ortasi: {edediOrta}");

        //Tapşırıq 6:
        //İstifadəçidən daxil edilən dördrəqəmli ədədin rəqəmlərinin cəmini hesablayıb çap edən proqramı yazın.

        //Console.Write("4 reqemli eded daxil edin:");
        //int num=Convert.ToInt32(Console.ReadLine());  
        //int reqemCem = num / 1000+num/100%10+num%100/10+num%10;
        //Console.WriteLine(reqemCem);

        //Tapşırıq 7:
        //İstifadəçidən alınan ədədin cüt və ya tək olduğunu yoxlayan və çap edən proqramı yazın.

        //Console.Write("eded daxil edin: ");
        //int eded=Convert.ToInt32(Console.ReadLine());
        //if (eded%2 == 0)
        //{
        //    Console.WriteLine("daxil etdiyiniz eded cutdur");
        //}
        //else
        //{
        //    Console.WriteLine("daxil etdiyiniz eded tekdir");
        //}

        //Tapşırıq 8:
        //İstifadəçinin daxil etdiyi iki ədədi müqayisə edib, hansı ədədin böyük olduğunu çap edən proqram yazın.

        //Console.Write("1 ci ededi daxil edin: ");
        //int eded1=Convert.ToInt32(Console.ReadLine());
        //Console.Write("2 ci ededi daxil edin: ");
        //int eded2=Convert.ToInt32(Console.ReadLine());
        //if (eded1 > eded2)
        //    Console.WriteLine("1 ci eded boyukdur");
        //else if (eded1 < eded2)
        //    Console.WriteLine("2 ci eded boyukdur");
        //else
        //    Console.WriteLine("daxil etdiyiniz ededler beraberdir");

        //Tapşırıq 9:
        //İstifadəçinin daxil etdiyi ədədin müsbət, mənfi və ya sıfır olduğunu yoxlayan və çap edən proqramı yazın.

        //Console.Write("eded daxil edin: ");
        //int eded = Convert.ToInt32(Console.ReadLine());
        //if (eded > 0)
        //{
        //    Console.WriteLine("eded musbetdir");
        //}
        //else if (eded < 0)
        //{
        //    Console.WriteLine("eded menfidir");
        //}
        //else
        //{
        //    Console.WriteLine("eded 0 - dir");
        //}

        //Tapşırıq 10:
        //İstifadəçidən alınan ədədin həm 3 - ə həm də 5 - ə bölünüb - bölünmədiyini yoxlayan və çap edən proqramı yazın.

        //Console.Write("eded daxil edin: ");
        //int eded = Convert.ToInt32(Console.ReadLine());
        //if (eded % 3 == 0 && eded % 5 == 0)
        //{
        //    Console.WriteLine("bolunur");
        //}
        //else
        //{
        //    Console.WriteLine("bolunmur");
        //}

        //Tapşırıq 11:
        //İstifadəçinin daxil etdiyi ədədin 2 - yə və ya 3 - ə eyni zamanda bölünə bildiyini yoxlayan və çap edən proqramı yazın.

        //Console.Write("eded daxil edin: ");
        //int eded = Convert.ToInt32(Console.ReadLine());
        //if (eded % 2 == 0 || eded % 3 == 0)
        //{
        //    Console.WriteLine("bolunur");
        //}
        //else
        //{
        //    Console.WriteLine("bolunmur");
        //}

        //Tapşırıq 12:
        //İstifadəçi ayın nömrəsini daxil edir(1 - 12 arasında).Proqram həmin ayın adını ekrana yazdıran proqramı yazın.(switch-case istifadə edin)

        //Console.Write("1-12 arasi eded daxil edin: ");
        //int eded = Convert.ToInt32(Console.ReadLine());
        //switch (eded)
        //{
        //    case 1:
        //        Console.WriteLine("yanvar");
        //        break;
        //    case 2:
        //        Console.WriteLine("fevral");
        //        break;
        //    case 3:
        //        Console.WriteLine("mart");
        //        break;
        //    case 4:
        //        Console.WriteLine("aprel");
        //        break;
        //    case 5:
        //        Console.WriteLine("may");
        //        break;
        //    case 6:
        //        Console.WriteLine("iyun");
        //        break;
        //    case 7:
        //        Console.WriteLine("iyul");
        //        break;
        //    case 8:
        //        Console.WriteLine("avqust");
        //        break;
        //    case 9:
        //        Console.WriteLine("sentyabr");
        //        break;
        //    case 10:
        //        Console.WriteLine("oktyabr");
        //        break;
        //    case 11:
        //        Console.WriteLine("noyabr");
        //        break;
        //    case 12:
        //        Console.WriteLine("dekabr");
        //        break;
        //    default:
        //        Console.WriteLine("sehv eded daxil etdiniz 1-12 arasi eded daxil edin");
        //        break;
        //}

        //Tapşırıq 13:
        //İstifadəçi daxil etdiyi bal əsasında qiymət çap edən proqramı yazın.(istənilən bal sistemi)
        //Console.WriteLine("balinizi daxil edin: ");
        //int bal=Convert.ToInt32(Console.ReadLine());

        //if (bal >= 0 && bal <= 100)
        //{
        //    if (bal > 90)
        //        Console.WriteLine("A");
        //    else if (bal > 80)
        //        Console.WriteLine("B");
        //    else if (bal > 70)
        //        Console.WriteLine("C");
        //    else if (bal > 60)
        //        Console.WriteLine("D");
        //    else if (bal > 50)
        //        Console.WriteLine("E");
        //    else
        //        Console.WriteLine("kesilmisen get 25%-e");
        //}
        //else
        //{
        //    Console.WriteLine("duzgun daxil ele bal 0-100 arasi ola biler");
        //}

        //Tapşırıq 14:
        //İstifadəçi iki ədəd və bir əməliyyat işarəsi daxil edir.Nəticəni hesablayan və çap edən proqramı yazın. (+, -, *, /)

        //Console.Write("1 ci ededi daxil edin: ");
        //int eded1 = Convert.ToInt32(Console.ReadLine());
        //Console.Write("2 ci ededi daxil edin: ");
        //int eded2 = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("hansi emeliyadi elemek isteyirsizse isaresini daxil edin\n+ =>toplama\n- =>cixma\n/ =>bolme\n* =>vurma");
        //char isare=Convert.ToChar(Console.ReadLine());
        //if (isare=='+')
        //{
        //    Console.WriteLine(eded1 + eded2);
        //}
        //else if (isare == '-')
        //{
        //    Console.WriteLine(eded1 - eded2);
        //}
        //else if (isare == '*')
        //{
        //    Console.WriteLine(eded1 * eded2);
        //}
        //else if (isare == '/')
        //{
        //    Console.WriteLine(eded1 / eded2);
        //}
        //else
        //{
        //    Console.WriteLine("duzgun isare daxil edin!!!");
        //}

        //Tapşırıq 15: 
        //İstifadəçinin daxil etdiyi məbləğə əsasən endirim edən və aşağıdaki şəkildə nəticəni çap edən proqramı yazın.
        //Console.Write("meblegi daxil edin: ");
        //double mebleg=Convert.ToDouble(Console.ReadLine());
        //if (mebleg >= 100)
        //{
        //    Console.WriteLine($"Endirimli qiymət: Alınan məhsulun dəyəri {mebleg} AZN. Ödəyəcəyiniz məbləğ {mebleg * 0.9} AZN (10% endirim tətbiq edildi)");
        //}
        //else if (mebleg >= 50 && mebleg < 100)
        //{
        //    Console.WriteLine($"Endirimli qiymət: Alınan məhsulun dəyəri {mebleg} AZN. Ödəyəcəyiniz məbləğ {mebleg * 0.95} AZN (5% endirim tətbiq edildi)");
        //}
        //else
        //{
        //    Console.WriteLine($"coox teessufki size endirim dusmur. yalniz 50 aznden yuxari alis-verislere kecerlidir endirim. {50-mebleg}aznlik elave mehsul alaraq 5% endirim elde ede bilersiz");
        //}

        //Tapşırıq 16:
        //İstifadəçi adını və şifrəsini daxil edir. Əvvəldən təyin olunmuş istifadəçi adı və şifrəyə uyğun olarsa girişə icazə verən və nəticəni çap edən proqramı yazın.
        //Qeyd: əvvəlcədən istifadəçi adı "admin", şifrə "2222" olsun.

        //Console.WriteLine("adinizi daxil edin:");
        //string name = Console.ReadLine();
        //Console.WriteLine("parolu daxil edin:");
        //string password= Console.ReadLine();
        //if (name == "admin" && password == "2222")
        //{
        //    Console.WriteLine("ugurlu giris");
        //}
        //else
        //{
        //    Console.WriteLine("adiniz veya parolunuz yanlisdir zehmet olmasa tekrar deneyin");
        //}

        //Tapşırıq 17:
        //AZN - dən USD və ya USD-dən AZN - ə məzənnə çevrilməsi həyata keçirən və nəticəni çap edən proqram yazın. (sabit məzənnə təyin edin).

        //double usd = 0.59;
        //Console.Write("nece manati usd elemek isteyirsizse girin:");
        //double azn=Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine($"{azn} manat = {azn*usd} dollar eliyir");

        //Tapşırıq 18:
        //İstifadəçinin boyunu (metr ilə) və çəkisini (kg ilə) alıb BMI (Body Mass Index) hesablayın və nəticəyə uyğun olaraq aşağıdakı mesajlardan birini çap edən proqramı yazın:
        //0 - 18.5       Çəki azlığı
        //18.5 - 24.9   Normal çəki
        //25 - 29.9     Artıq çəki
        //30 və daha çox Piylənmə

        //Console.Write("boyunuzu daxil edin (metr ile): ");
        //double boy=Convert.ToDouble(Console.ReadLine());
        //Console.Write("cekivizi daxil edin(kg ile): ");
        //double ceki=Convert.ToDouble(Console.ReadLine());

        //double BMI=ceki/(boy*boy);

        //if (BMI > 0 && BMI <= 18.5)
        //{
        //    Console.WriteLine("ceki azliginiz var biraz yeyin cana gelin");
        //}
        //else if (BMI > 18.5 && BMI <= 24.9)
        //{
        //    Console.WriteLine("normalsiz");
        //}
        //else if (BMI >= 25 && BMI <= 29.9)
        //{
        //    Console.WriteLine("artiq ceki");
        //}
        //else if (BMI >=30)
        //{
        //    Console.WriteLine("PIYLENMEE!!!");
        //}
        //else
        //{
        //    Console.WriteLine("neyise duzgun daxil etmediz tekrar yoxlayin");
        //}

     

        //Tapşırıq 20:
        //Yaratmış olduğunuz massivin elementlərini ekrana çap edən proqram yazın.

        //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, };
        //foreach (int i in ints)
        //{
        //    Console.WriteLine(i);
        //}

        //Tapşırıq 21:
        //Yaratmış olduğunuz massivin bütün elementlərin cəmini hesablayıb nəticəni çap edən proqramı yazın.

        //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, };
        //int sum = 0;
        //foreach (int i in ints)
        //{
        //    sum+= i;
        //}
        //Console.WriteLine(sum);

        //Tapşırıq 22:
        //Yaratmış olduğunuz integer massivdə olan elementlərin ortalamasını hesablayıb nəticəni çap edən proqramı yazın.

        //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, };
        //int sum = 0;
        //int ededSay = 0;
        //foreach (int i in ints)
        //{
        //    sum += i;
        //    ededSay++;
        //}
        //Console.WriteLine(Convert.ToDouble(sum)/Convert.ToDouble(ededSay));


        //Tapşırıq 23:
        //Yaratmış olduğunuz integer massivdə olan ən böyük və ən kiçik elementləri index-i ilə birgə çap edən proqramı yazın.

        //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, };
        //int maks = ints[0];
        //int min = ints[0];
        //foreach (int i in ints)
        //{
        //    if (i < min)
        //        min = i;
        //    if (i > maks)
        //        maks = i;
        //}
        //int maksIndex = 0;
        //int minIndex = 0;
        //for (int i = 0; i < ints.Length; i++)
        //{
        //    if (ints[i] == min)
        //        minIndex = i;
        //    if (ints[i] == maks)
        //        maksIndex = i;
        //}
        //Console.WriteLine($"en boyuk eded: {maks} indexi: {maksIndex}\nen kicik eded: {min} indexi: {minIndex}");

        //Tapşırıq 24:
        //Yaratmış olduğunuz integer massivdə olan cüt ədədləri çap edən proqramı yazın.

        //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, };
        //foreach (int i in ints)
        //{
        //    if (i % 2 == 0)
        //        Console.WriteLine(i);
        //}

        //Tapşırıq 25:
        //Yaratmış olduğunuz massivdəki elementləri əks sıralama ilə yeni massivə əlavə edib nəticəni çap edən proqramı yazın.
        //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, };
        //int[] ints2 = new int[ints.Length];
        //int index = 0;
        //for (int i = ints.Length - 1; i >= 0; i--)
        //{
        //    ints2[index] = ints[i];
        //    index++;
        //}
        //foreach (int i in ints2)
        //{
        //    Console.WriteLine(i);
        //}

        //Tapşırıq 26:
        //Massivdə konkret ədədin olub-olmadığını yoxlayan və indexini çap edən proqramı yazın.(yoxdursa - 1)

        //int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, };
        //Console.WriteLine("eded daxil edin");
        //int eded = Convert.ToInt32(Console.ReadLine());
        //bool var=false;
        //int index = 0;
        //for (int i = 0; i < ints.Length; i++)
        //{
        //    if (ints[i] == eded)
        //    {
        //        var = true;
        //        index= i;
        //        break;
        //    }
        //}
        //Console.WriteLine(var ? index : "-1");

        //Tapşırıq 27:
        //Massivdə təkrarlanan elementləri tapıb, nəticəni çap edən proqramı yazın.(bütün təkrarlanan ədədlər)

       


        //Tapşırıq 28:
        //Massivdəki ikinci ən böyük elementi tapan və nəticəni çap edən proqramı yazın.

        //int[] ints = { 1, 2, 3, 4, 5, 2, 1, 3, 4, 412, 12, 4 };
        //int enBoyuk = 0;
        //int ikinciBoyuk = 0;
        //for (int i = 0; i < ints.Length; i++)
        //{
        //    if (ints[i] > enBoyuk)
        //    {
        //        ikinciBoyuk = enBoyuk;
        //        enBoyuk = ints[i];
        //    }
        //    else if (ints[i] > ikinciBoyuk && ints[i] != enBoyuk)
        //    {
        //        ikinciBoyuk=ints[i];
        //    }
        //}
        //Console.WriteLine(ikinciBoyuk);

        //Tapşırıq 29:
        //Verilmiş N rəqəmli ədədin rəqəmləri cəmini tapan və nəticəni çap edən proqramı yazın.

        //Console.WriteLine("eded daxil edin");
        //string eded=Console.ReadLine();
        //int sum = 0;
        //foreach (char reqem in eded)
        //{
        //    sum += Convert.ToInt32(reqem.ToString());
        //}
        //Console.WriteLine(sum);

        //Tapşırıq 30:
        //Verilmiş N rəqəmli ədədin rəqəmlərinin sayını tapan və nəticəni çap edən proqramı yazın.

        //Console.WriteLine("eded daxil edin");
        //string eded=Console.ReadLine();
        //Console.WriteLine(eded.Length);

        //Tapşırıq 31:
        //Verilmiş N rəqəmli ədədin sadə və ya mürəkkəb olduğunu tapan və nəticəni çap edən proqramı yazın.

        //int eded = Convert.ToInt32(Console.ReadLine());
        //bool murekkebEdeddir = false;
        //for (int i = 2; i < eded; i++)
        //{
        //    if (eded % i == 0)
        //    {
        //        murekkebEdeddir = true;
        //        break;
        //    }
        //}
        //Console.WriteLine(murekkebEdeddir ? "murekkebdir" : "sadedir");

        //Tapşırıq 32:
        //Verilmiş N rəqəmli ədədin Palindrome olub-olmamasını yoxlayan və nəticəni çap edən proqramı yazın.

        //int num = Convert.ToInt32(Console.ReadLine());
        //int temp = num;
        //int qaliq;
        //int reverse = 0;
        //while (num != 0)
        //{
        //    qaliq = num % 10;
        //    reverse = (reverse * 10) + qaliq;
        //    num /= 10;
        //}
        //if (temp == reverse)
        //{
        //    Console.WriteLine("polindromdur");
        //}
        //else
        //{
        //    Console.WriteLine("polindrom deyil");
        //}

        //Tapşırıq 33:
        //Fibonaçi ədədlərindən ilk N həddini tapan və çap edən proqramı yazın.
        //Console.WriteLine("nece eded cixartmaq isteyirsizse qeyd edin");
        //int n =Convert.ToInt32(Console.ReadLine());
        //int num1 = 0;
        //int num2 = 1;
        //int sum;
        //Console.Write(num1+" "+num2);
        //for (int i = 0; i < n - 2; i++)
        //{
        //    sum=num1 + num2;
        //    Console.Write(" "+ sum);
        //    num1 = num2;
        //    num2 = sum;
        //}
    }
}
