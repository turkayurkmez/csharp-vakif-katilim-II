// See https://aka.ms/new-console-template for more information
using Inheritance;

Console.WriteLine("Hello, World!");
AK47 aK47 = new AK47();
M60 m60 = new M60();
MKA1 mKA1 = new MKA1();

Player player = new Player();
player.Weapon = aK47;
player.Attack();
player.ChangeCharger();
player.Weapon = m60;
player.Attack();
player.ChangeCharger();


player.Weapon = mKA1;
player.Attack();
player.ChangeCharger();


