Console.OutputEncoding = System.Text.Encoding.UTF8;


int  下庞Hp = 100; // jolly
int 末日铁拳Hp = 300; // evil


string fighter1name = "下庞";
string fighter2name = "末日铁拳";


Random aas = new Random();



while (下庞Hp > 0 && 末日铁拳Hp > 0 )
{

Console.WriteLine("\n ------ ===== 新一轮 ===== -------");
Console.WriteLine($"{fighter1name}: {下庞Hp}  {fighter2name}:  {末日铁拳Hp}");


int  下庞dmg = aas.Next(20);

末日铁拳Hp -= 下庞dmg;
末日铁拳Hp = Math.Max(0, 末日铁拳Hp);
Console.WriteLine($"{fighter1name} åstakommer {下庞dmg} dmg på {fighter2name}");



}


















Console.ReadLine();