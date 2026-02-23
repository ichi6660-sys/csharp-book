using System;
using System.ComponentModel.DataAnnotations;

namespace MySample2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int age = 23;
            //string name = "市川";

            //Console.WriteLine("私、年齢{0}ですが、{1}でし", age , name);

            //name = "山田";

            //Console.WriteLine("私、年齢{0}ですが、{1}でし", age, name);

            //int height = 8;
            //int width = 5;
            //int area;

            //area = height * width;
            //Console.WriteLine("面積は{0}です", area);

            //Console.WriteLine("insart your name");
            //var name = Console.ReadLine();
            //Console.WriteLine("{0}さん、おはちょ\nうございます", name);

            //double squareRoot = 1.41421356;
            //double sideLength = 10.0;
            //double diagonalLength = sideLength * squareRoot;
            //Console.WriteLine("対角線の長さは{0}です", diagonalLength);

            //var average = 3.28m;
            //Console.WriteLine(average);

            //var price = 1280m;
            //var priceIncludingTax = price * 1.08m;
            //Console.WriteLine(priceIncludingTax);

            //string name = "市川";
            //Console.WriteLine("私の名前は{0}です", name);

            //var name = "市川";
            //var age = 19;
            //Console.WriteLine("{0}さんは、{1}歳です", name, age);

            //var kilometersPerHour = 54;
            //var hour = 3;
            //var kilometer = kilometersPerHour * hour;
            //Console.WriteLine(kilometer);

            //var str = "改行を示すエスケープシーケンスは、\\nです";
            //Console.WriteLine(str);

            //var price1 = 1100;
            //var price2 = 800;
            //var price3 = 1250;

            //var total = price1 + price2 + price3;
            //Console.WriteLine("合計金額は、{0}ｴﾝです", total);

            //var member = 4;
            //var perPerson = total / member;
            //Console.WriteLine("{0}人で割った一人当たりの金額は、{1}ｴﾝです", member , perPerson);

            //var remainder = total % member;
            //Console.WriteLine("余りは、{0}ｴﾝです", remainder);

            //var total = 998;
            //var discount = total * 0.1;
            //var payment = total - discount;

            //Console.WriteLine("割引額は{0}ｴﾝです", discount);
            //Console.WriteLine("支払額は{0}ｴﾝです2", payment);

            //var x = +100;
            //var y = -5;
            //var a = +(x + y);
            //var b = -(x + y);
            //Console.WriteLine("a = {0}, b = {1}", a, b);

            //var num = 6;
            //var dup = num;
            //Console.WriteLine(num);
            //Console.WriteLine(dup);

            //var num = 10;
            //num += 20;
            //Console.WriteLine(num);

            //var source = 15.8;
            //var width = (int)source;
            //Console.WriteLine(width);

            //var total = 998;
            //var discount = (int)(total * 0.1);
            //var payment = total - discount;

            //Console.WriteLine("割引額：{0}ｴﾝです", discount);
            //Console.WriteLine("支払額：{0}ｴﾝです", payment);

            //var total = 100;
            //var line = Console.ReadLine();
            //var count = int.Parse(line);
            //var num = total / count;
            //Console.WriteLine(num);

            //var name = Console.ReadLine();
            //var message = name + "さん、こんにちは";
            //Console.WriteLine(message);

            //var str = "これは正しい文字列です" +
            //          "+演算子で連結させています";

            //Console.WriteLine(str);

            //var s1 = "おはよう";
            //            var s2 = "ございます";
            //var s3 = "こんにちは";
            //            var s4 = "こんばんは";
            //var message = s1 + s2 + "、" + s3+ s4;

            //Console.WriteLine(message);

            //var message = "こんにちは、";
            //message += "世界！";
            //Console.WriteLine(message);

            //var season = '夏';
            //var temperature = 39;
            //var str = $"今日は{season}で、気温は{temperature}度です";
            //Console.WriteLine(str);

            //var line = Console.ReadLine();
            //var num = int.Parse(line);
            //if (num >= 10)
            //{
            //    Console.WriteLine($"{num}は10以上です");
            //}

            //var lang = Console.ReadLine();
            //if (lang == "C#")
            //{
            //    Console.WriteLine("C#");
            // }
            //if (lang != "java")
            //{
            //    Console.WriteLine("javaではない");
            //}

            //var line = Console.ReadLine();
            //var month = int.Parse(line);
            //if (1 <= month && month <= 12)
            //{
            //    Console.WriteLine("1以上12以下の数値です");
            //}

            //var line = Console.ReadLine();
            //var num = int.Parse(line);
            //if (num % 3 == 0 || num % 5 == 0)
            //{
            //    Console.WriteLine("3の倍数か5の倍数です");
            //}

            //Console.WriteLine("ご希望の時間帯を番号で選択してください");
            //Console.WriteLine("1: 朝 2: 昼 3: 夜"); 
            //Console.WriteLine("番号を入力してください");

            //var line = Console.ReadLine();
            //var value = int.Parse(line);

            //switch (value)
            //{
            //    case 1:
            //        Console.WriteLine("おはようございます");
            //        break;
            //    case 2:
            //        Console.WriteLine("こんにちは");
            //        break;
            //    case 3:
            //        Console.WriteLine("こんばんは");
            //        break;
            //    default:
            //        Console.WriteLine("1から3の番号を入力してください");
            //        break;
            //}


            //var word = Console.ReadLine();
            // var term = "";

            // switch (word)
            // {
            //     case "API":
            //         term = "Application Programming Interfaceの略で、ソフトウェア同士がやりとりするためのルールや仕様のことです";
            //         break;

            //     case "RDB":
            //         term = "Relational Databaseの略で、データを表形式で管理するデータベースのことです";
            //         break;

            //     case "UI":
            //         term = "User Interfaceの略で、ユーザーがコンピュータやソフトウェアとやりとりするための画面や操作方法のことです";
            //         break;

            // }

            // if (term != "")
            // {
            //     Console.WriteLine($"{word}は{term}");　
            // }


            //var temp = 29.5;

            //if (temp >= 35.0)
            //{
            //    Console.WriteLine("危険な暑さです。熱中症に注意してください");
            //}
            //else if (temp >= 30.0)
            //{
            //    Console.WriteLine("非常に暑いです。こまめに水分をとってください");
            //}
            //else if (temp >= 25.0)
            //{
            //    Console.WriteLine("暑いです。適度に休憩をとってください");
            //}
            //else
            //{
            //    Console.WriteLine("快適な気温です。外出を楽しんでください");
            //}

            //for (var year = 1; year <= 64; year++)
            //{
            //    var westernYear = year + 1925;
            //    Console.WriteLine($"昭和{year}年は西暦{westernYear}年です");
            //    year++;
            //}


            //var num = 0;
            //while (num <= 0 || 5 <= num)
            //{
            //    Console.WriteLine("0以上5以下の数値を入力してください");
            //    var line = Console.ReadLine();
            //    num = int.Parse(line);
            //}
            //Console.WriteLine($"{num}は0以上5以下の数値です");

            //var n = 5;
            //for (var i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"i = {i}");
            //}

            //var line = "";
            //do
            //{
            //    Console.WriteLine("何か入力してください");
            //    line = Console.ReadLine();
            //}while (line == "");
            // Console.WriteLine($"あなたは「{line}」と入力しました");





        }   
    }
}
