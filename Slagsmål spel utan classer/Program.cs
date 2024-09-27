Console.OutputEncoding = System.Text.Encoding.UTF8;
string val_1 = "";
while (val_1 != "1" && val_1 != "2") {
    Console.WriteLine("Tryck 1 för Xia Pang:下庞 Tryck 2 för Doomfist:末日铁拳");
    val_1 = Console.ReadLine();
}



if (val_1 == "1") {

Console.WriteLine("Du spelar som Xia Pang");
} 

else if (val_1 == "2") {
    Console.WriteLine("Du spelar som Doomfist");
}


int  下庞Hp = 100; // jolly
int 末日铁拳Hp = 300; // evil 


string fighter1name = "下庞";
string fighter2name = "末日铁拳";


Random bejing = new Random();



while (下庞Hp > 0 && 末日铁拳Hp > 0 )
{

Console.WriteLine("\n ------ ===== 新一轮 ===== -------");
Console.WriteLine($"{fighter1name}: {下庞Hp}  {fighter2name}:  {末日铁拳Hp}");


int  下庞dmg = bejing.Next(70);

末日铁拳Hp -= 下庞dmg;
末日铁拳Hp = Math.Max(0, 末日铁拳Hp);
Console.WriteLine($"{fighter1name} åstakommer {下庞dmg} dmg på {fighter2name}");


int  末日铁拳dmg = bejing.Next(20);

下庞Hp -= 末日铁拳dmg;
下庞Hp = Math.Max(0, 下庞Hp );
Console.WriteLine($"{fighter2name} rocket punch gör {末日铁拳dmg}dmg på {fighter1name}");

Console.WriteLine("按任一按鈕");
Console.ReadKey();
}

Console.WriteLine("\n ----- ===== 戰鬥結束了 ===== -----");

if(下庞Hp == 0 &&  末日铁拳Hp == 0  )
{
Console.WriteLine("平局");

}

else if (下庞Hp == 0)
{
    Console.WriteLine("末日铁拳 获胜!");
}

else
{
    Console.WriteLine("下庞 获胜! ");
}

Console.WriteLine("按任意按钮关闭!");
Console.ReadKey();







Console.ReadLine();