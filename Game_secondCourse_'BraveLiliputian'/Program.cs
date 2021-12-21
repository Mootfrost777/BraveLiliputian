using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            UI.For_repeat();
            GameInit.IsNeedLoad();
            UI.Init(); //инициализация интерфейса
            GameInit.GameOver();
        }
    }
    class Learning
    {

        public Learning(int TypeOfLearning)
        {
            Player.TypeOfLearning = TypeOfLearning;
        }

        public void ChooseLevelOfLearning()
        {
            if (Player.TypeOfLearning == 1)
            {
                L_lvl_1();
            }
            else if (Player.TypeOfLearning == 2)
            {
                L_lvl_2();
            }
            else if (Player.TypeOfLearning == 3)
            {
                L_lvl_3();
            }
            else if (Player.TypeOfLearning == 4)
            {
                L_lvl_4();
            }
        }
        public void L_lvl_1()
        {
            #region // подготовка
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(Console.WindowWidth / 2, 0);
            Console.WriteLine("!ОБУЧЕНИЕ!");
            Console.SetCursorPosition(0, 4);
            Console.ResetColor();
            #endregion

            string a = "You have name (you wrote it at the beginning), power, hp, appearance (it depends from your level) \n" +
                "Your enemy has type, power, hp, sometimes special skills" +
                "Your task is to kill the enemy. If you first kill the enemy or die or win, else you will lose. \n" +
                "If you win you level, hp, power and gold grow, else they don't grow. You can't replay fighting regardnesss of the result. \n" +
                "You can attack, dodge, wait. Enemy can do the same. \n" +
                "If enemy attacks, you should dodge; if enemy dodges, you should wait; if enemy waits, you should attack \n";
            Console.WriteLine(a);
            Thread.Sleep(6000);
            Console.WriteLine("Надеюсь - ты все понял. \nГотов попробовать это в тренировочном бою? \n");
            Thread.Sleep(500);
            Console.WriteLine("ДА[Y] НЕТ[N]");

            if (Console.ReadKey(true).Key == ConsoleKey.Y)
            {
                Player.IsLearningPhase = true;
                DistributionFigting();
            }
            else
            {
                Player.IsLearningPhase = false;
                DistributionFigting();
            }
        }
        public void L_lvl_2()
        {
            #region // подготовка
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(Console.WindowWidth / 2, 0);
            Console.WriteLine("!ОБУЧЕНИЕ!");
            Console.SetCursorPosition(0, 4);
            Console.ResetColor();
            #endregion

            string a = "Привет, ты попал к мастеру, который когда-то тренировал наруто... Но не суть. \n" +
                "Он подготовит тебя к битве с врагом уровня 2. \n" +
                "- У врага добавляются новые виды атаки, а соответственно и новые виды уклонения. \n" +
                "Уклоняться можно: вверх, вниз, влево, вправо. \n" +
                "Если враг атакует сверху - надо уклониться вниз. Если справа - влево. и т.д. \n" +
                "Также добавляется новое оружие - меч, его можно использовать только 2 раза за битву.";
            Console.WriteLine(a);
            Thread.Sleep(6000);
            Console.WriteLine("Надеюсь - ты все понял. \nГотов попробовать это в тренировочном бою? \n");
            Thread.Sleep(500);
            Console.WriteLine("ДА[Y] НЕТ[N]");

            if (Console.ReadKey(true).Key == ConsoleKey.Y)
            {
                Player.IsLearningPhase = true;
                DistributionFigting();
            }
            else
            {
                Player.IsLearningPhase = false;
                DistributionFigting();
            }
        }
        public void L_lvl_3()
        {
            #region // подготовка
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(Console.WindowWidth / 2, 0);
            Console.WriteLine("!ОБУЧЕНИЕ!");
            Console.SetCursorPosition(0, 4);
            Console.ResetColor();
            #endregion

            string a = "О нет!!! Тебя похитил КАМАЗ С ПРИШЕЛЬЦАМИ, но там нашелся предатель. \n" +
                "Он научит тебя битве с врагом уровня 3. \n" +
                "У врага добавляются новые виды атаки: атака лазерной пушкой, атака нано роками. \n" +
                "От первого вида атаки может спасти только магический плащ, который ты мог купить у торговца. После атаки плащ ломается. \n" +
                "При атаке руками можно просто отойти назад. \n";
            Console.WriteLine(a);
            Thread.Sleep(6000);
            Console.WriteLine("Надеюсь - ты все понял. \nГотов попробовать это в тренировочном бою? \n");
            Thread.Sleep(500);
            Console.WriteLine("ДА[Y] НЕТ[N]");

            if (Console.ReadKey(true).Key == ConsoleKey.Y)
            {
                Player.IsLearningPhase = true;
                DistributionFigting();
            }
            else
            {
                Player.IsLearningPhase = false;
                DistributionFigting();
            }
        }
        public void L_lvl_4()
        {
            #region // подготовка
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(Console.WindowWidth / 2, 0);
            Console.WriteLine("!ОБУЧЕНИЕ!");
            Console.SetCursorPosition(0, 4);
            Console.ResetColor();
            #endregion

            string a = "Spits with acid (плюется кислотой)-особая способность гидры\nYou should neutralize the acid to protect from it \n" +
                "Attacks with fire (атакует огнем)-особая способность гидры\nYour should put out the fire to protect from it \n" +
                "You have new attack option: attack with bow\n";
            Console.WriteLine(a);
            Thread.Sleep(6000);
            Console.WriteLine("Надеюсь - ты все понял. \nГотов попробовать это в тренировочном бою? \n");
            Thread.Sleep(500);
            Console.WriteLine("ДА[Y] НЕТ[N]");

            if (Console.ReadKey(true).Key == ConsoleKey.Y)
            {
                Player.IsLearningPhase = true;
                DistributionFigting();
            }
            else
            {
                Player.IsLearningPhase = false;
                DistributionFigting();
            }
        }

        public void DistributionFigting()  //распределение битв
        {
            if (Player.TypeOfLearning == 1)
            {
                Console.Clear();
                Enemy enemy1 = new Enemy(10, "robber", 3);
                Battle battle1 = new Battle();
                battle1.Fighting(enemy1);
            }
            else if (Player.TypeOfLearning == 2)
            {
                Console.Clear();
                Enemy enemy1 = new Enemy(50, "vampire", 10);
                Battle battle1 = new Battle();
                battle1.Fighting(enemy1);
            }
            else if (Player.TypeOfLearning == 3)
            {
                Console.Clear();
                Enemy enemy1 = new Enemy(40, "kamaz with alienis", 7);
                Battle battle1 = new Battle();
                battle1.Fighting(enemy1);
            }
            else if (Player.TypeOfLearning == 4)
            {
                Console.Clear();
                Enemy enemy1 = new Enemy(65, "hidra", 13);
                Battle battle1 = new Battle();
                battle1.Fighting(enemy1);
            }
        }
    }

    class Enemy
    {
        public int hp;
        private int power;
        private string[] actions = { "Attacks", "Dodges",  "Things", "Attacks from the right",
         "Attacks from the left", "Attacks from below", "Attacks from above","Attacks with fire",
         "Spits acid", "Dodges",  "Things", "Attacks from the right",
         "Attacks from the left", "Attacks from below", "Attacks from above","Attacks with laser cannon", "Attacks with nano hands"};
        private string type;
        private string[] appearance = {
                        " 0\n" +
             "                                                  /||\n"+
             "                                                  / |\n",
                        "|||/-------|...\n"+
             "                                                  |/----------|/|\n"+
             "                                                  ..|\\-0|||/0-|..\n"+
             "                                                  ..|||.-//\\-..|\\|\n"+
             "                                                  ...|/..\\TT/..|/ \n"+
             "                                                  ....|\\_____/|...\n"+
             "                                                  .../---\\..|/ |/┈//--\n"+
             "                                                  ../|||-\\__/-|||||╲\n",
             "   .#\n"+
             "                                                      @#.#######@⠃\n"+
             "                                                    .###0###0###.\n"+
             "                                                   ############@\n"+
             "                                                     @#############@\n"+
             "                                                        @#|\\#//|##@\n"+
             "                                                          #@##@. ####@\n"+
             "                                                          @.@####@\n"+
             "                                                        @######\n",

             ".--I\"\"\"\"\"\"\"\"\"\"\"I \n" +
             "                                                  / - IKAMAZI \n" +
             "                                                  ''-O-\"\"\"\"\"\"O\"O\"- \n"

         };
        // Конструктор
        public Enemy(int hp, string type, int power)
        {
            this.hp = hp;
            this.type = type;
            this.power = power;
        }
        // методы
        public string GenerateAction()
        {
            int firstNum = 0;
            int lastNum = 3;
            if (type == "vampire")
            {
                firstNum = 1;
                lastNum = 6;
            }
            if (type == "hidra")
            {
                firstNum = 1;
                lastNum = 9;
            }
            if (type == "kamaz with alienis")
            {
                firstNum = 1;
                lastNum = 8;
            }
            Random r = new Random();
            int num = r.Next(firstNum, lastNum);
            return actions[num];
        }
        public void Prepearing()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(50, 0);
            Console.CursorSize = 70;
            Console.WriteLine(type);
            Console.SetCursorPosition(50, 2);
            Console.WriteLine("Hp: " + hp);
            Console.SetCursorPosition(50, 4);
            Console.WriteLine("Power: " + power);
            Console.CursorVisible = false;
            Console.CursorTop = 7;
            Console.CursorLeft = 50;
            if (type == "robber")
            {
                Player.PlusGold = 25;
                Console.WriteLine(appearance[0]);
            }
            if (type == "vampire")
            {
                Player.PlusGold = 80;
                Console.WriteLine(appearance[1]);
            }
            if (type == "hidra")
            {
                Player.PlusGold = 95;
                Console.WriteLine(appearance[2]);
            }
            else if (type == "kamaz with alienis")
            {
                Player.PlusGold = 34;
                Console.WriteLine(appearance[3]);
            }
        }

        // свойства
        public int Hp { get { return hp; } set { hp = value; } }
        public int Power { get { return power; } }
        public string Type { get { return type; } }
    }
    class Battle
    {
        private string input;

        private void DisplayEnemyStatus(string status)
        {
            Console.CursorSize = 50;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(66, 7);
            Console.WriteLine(status);
        }
        public int NumOfFirstVariant1(Enemy enemy)
        {
            int numOfFirstVariant = 0;
            if (enemy.Type == "robber")
            {
                numOfFirstVariant = 0;
            }
            if (enemy.Type == "vampire")
            {
                numOfFirstVariant = 1;
            }
            if (enemy.Type == "hidra")
            {
                numOfFirstVariant = 2;
            }
            else if (enemy.Type == "kamaz with alienis")
            {
                numOfFirstVariant = 9;
            }
            return numOfFirstVariant;
        }
        public int NumOfLastVariant1(Enemy enemy)
        {
            int numOfLastVariant = 2;
            if (enemy.Type == "robber")
            {
                numOfLastVariant = 3;
            }
            if (enemy.Type == "vampire")
            {
                numOfLastVariant = 6;
            }
            if (enemy.Type == "hidra")
            {
                numOfLastVariant = 9;
            }
            else if (enemy.Type == "kamaz with alienis")
            {
                numOfLastVariant = 16;
            }
            return numOfLastVariant;
        }
        private void DisplayActionVaryant(string[] variants, int numberOfFirstVariant, int numberOfLastVariant)
        {

            Console.CursorSize = 50;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(36, 18);
            int top_pos = Console.CursorTop + 2;
            int left_pos = Console.CursorLeft + 2;
            int num = 1;
            if (numberOfFirstVariant != 0)
            {
                numberOfLastVariant++;
            }
            for (int i = numberOfFirstVariant; i < numberOfLastVariant; i++)
            {
                if (num % 3 == 0)
                {
                    left_pos += 25;
                    top_pos = 20;
                }
                Console.SetCursorPosition(left_pos, top_pos);
                Console.WriteLine(num + " " + variants[i]);
                top_pos += 3;
                num++;
            }
            Console.SetCursorPosition(45, 9);
        }
        private int ProtectionFromFools(int lastVar)
        {
            Console.SetCursorPosition(75, 17);
            input = Console.ReadLine();
            if (input == "Attack with a sword" && Player.numOfUsingSword == 2)
            {
                return 100;
            }
            int num;
            bool success = Int32.TryParse(input, out num);
            if (success)
            {
                int correctInput = int.Parse(input);
                if (correctInput > 0 && correctInput <= lastVar)
                {
                    return correctInput;
                }
            }
            return 0;
        }
        private void ChosingVariant(int numOfLastVariant)
        {
            int[] correctSymbols = new int[numOfLastVariant];
            for (int i = 0; i < numOfLastVariant; i++)
            {
                correctSymbols[i] = i;
            }
            Console.SetCursorPosition(44, 17);

            Console.Write("Choose a variant from 1 to " + (numOfLastVariant) + ": ");
        }
        public void Reaction(string heroAction, string enemyAction, Enemy enemy)
        {
            Console.SetCursorPosition(20, 14);
            if (heroAction == "100")
            {
                if (Player.IsShield == false || Player.shieldIsUsed == true)
                {
                    Player.health -= enemy.Power;
                    Console.WriteLine("You were attacked because you can use a sword only 2 times.");
                }
                else
                {
                    Player.health -= (enemy.Power - Player.shieldProtection);
                    Console.WriteLine("You were attacked because you can use a sword only 2 times, but you used a shield");
                    Player.shieldIsUsed = true;
                }
            }
            else if (heroAction == "Attack with a sword")
            {
                Player.numOfUsingSword++;
            }
            else if (enemyAction == "Attacks with fire")
            {
                if (heroAction == "Put out the fire")
                {
                    Console.WriteLine(" You have put out the fire.");
                }
                else
                {
                    if (Player.IsShield == false || Player.shieldIsUsed == true)
                    {
                        Console.WriteLine("You have a burn");
                        Player.health -= enemy.Power;
                    }
                    else
                    {
                        Console.WriteLine("You have a burn, but you used a shield.");
                        Player.health -= (enemy.Power - Player.shieldProtection);
                        Player.shieldIsUsed = true;
                    }
                }
                if (heroAction == "Attack with a sword")
                {
                    Console.CursorTop += 1;
                    Console.WriteLine("You have attacked with a sword.");
                    enemy.Hp -= (Player.Power + (Player.lvl * 6));
                }
                if (heroAction == "Attack with a bow")
                {
                    Console.CursorTop += 1;
                    Console.WriteLine("You have attacked with a bow.");
                    enemy.Hp -= Player.Power;
                }
            }
            else if (enemyAction == "Spits acid")
            {
                if (heroAction == "Neutralize the acid")
                {
                    Console.WriteLine("You have protected yourself from the acid.");
                }
                else
                {
                    if (Player.IsShield == false || Player.shieldIsUsed == true)
                    {
                        Console.WriteLine("You were successfully spat on with acid.");
                        Player.health -= enemy.Power;
                    }
                    else
                    {
                        Console.WriteLine("You were successfully spat on with acid, but you used a shield.");
                        Player.health -= (enemy.Power - Player.shieldProtection);
                        Player.shieldIsUsed = true;
                    }
                }
                if (heroAction == "Attack with a sword")
                {
                    Console.CursorTop += 1;
                    Console.WriteLine("You have attacked with a sword.");
                    enemy.Hp -= (Player.Power + (Player.lvl * 6));
                }
                if (heroAction == "Attack with a bow")
                {
                    Console.CursorTop += 1;
                    Console.WriteLine("You have attacked with a bow.");
                    enemy.Hp -= Player.Power;
                }
            }
            else if (enemyAction == "Attacks")
            {
                if (heroAction == "Wait" || heroAction == "Attacks")
                {
                    if (Player.IsShield == false || Player.shieldIsUsed == true)
                    {
                        Console.WriteLine("You were attacked.");
                        Player.health -= enemy.Power;
                    }
                    else
                    {
                        Console.WriteLine("You were attacked, but you used a shield.");
                        Player.health -= (enemy.Power - Player.shieldProtection);
                        Player.shieldIsUsed = true;
                    }
                }
                else if (heroAction == "Dodge")
                {
                    Console.WriteLine("You have succesfully dodged.");
                }
                if (heroAction == "Attacks")
                {
                    enemy.Hp -= Player.strengh;
                    Console.CursorTop++;
                    Console.WriteLine("you have attacked.");
                    Console.CursorTop--;
                }
            }
            else if (enemyAction == "Dodges")
            {
                if (heroAction == "Attack")
                {
                    Player.health -= 2;
                }
                else
                {
                    Console.SetCursorPosition(20, 10);
                    Console.WriteLine("Nothing happens because you have chosen to " + heroAction + ".");
                }
            }
            else if (enemyAction == "Things")
            {

                if (heroAction == "Attack")
                {
                    enemy.Hp = enemy.Hp - Player.Power;
                    Console.SetCursorPosition(20, 10);
                    Console.WriteLine("You have attacked.");
                }
                else if (heroAction == "Attack with a sword")
                {
                    Console.CursorTop += 1;
                    Console.WriteLine("You have attacked with a sword.");
                    enemy.Hp -= Player.Power + (Player.lvl * 6);
                }
                else if (heroAction == "Attack with a bow")
                {
                    Console.CursorTop += 1;
                    Console.WriteLine("You have attacked with a bow.");
                    enemy.Hp -= Player.Power;
                }
                else
                {
                    Console.SetCursorPosition(4, 12);
                    Console.WriteLine("You missed an opportunity to attack.");
                }
            }

            else if (enemyAction == "Attacks from the right")
            {
                if (heroAction == "Dodge to the left")
                {
                    Console.SetCursorPosition(20, 10);
                    Console.WriteLine("You have succesfully dodged.");
                }
                else
                {
                    if (Player.IsShield == false || Player.shieldIsUsed == true)
                    {
                        Console.WriteLine("You were attacked.");
                        Player.health -= enemy.Power;
                    }
                    else
                    {
                        Player.health -= (enemy.Power - Player.shieldProtection);
                        Player.shieldIsUsed = true;
                    }
                }
                if (heroAction == "Attacks")
                {
                    Console.CursorTop += 1;
                    Console.WriteLine("You have attacked.");
                    enemy.Hp -= Player.strengh;
                }
                if (heroAction == "Attack with a sword")
                {
                    Console.CursorTop += 1;
                    Console.WriteLine("You have attacked with a sword.");
                    enemy.Hp -= Player.Power + (Player.lvl * 6);
                }
                if (heroAction == "Attack with a bow")
                {
                    Console.CursorTop += 1;
                    Console.WriteLine("You have attacked with a bow.");
                    enemy.Hp -= Player.Power;
                }
            }
            else if (enemyAction == "Attacks from the left")
            {
                if (heroAction == "Dodge to the right")
                {
                    Console.SetCursorPosition(20, 10);
                    Console.WriteLine("You have succesfully dodged.");
                }
                else
                {
                    if (Player.IsShield == false || Player.shieldIsUsed == true)
                    {
                        Console.WriteLine("You were attacked.");
                        Player.health -= enemy.Power;
                    }
                    else
                    {
                        Console.WriteLine("You were attacked, but you used a shield.");
                        Player.health -= (enemy.Power - Player.shieldProtection);
                        Player.shieldIsUsed = true;
                    }
                }
                if (heroAction == "Attacks")
                {
                    Console.CursorTop += 1;
                    Console.WriteLine("You have attacked.");
                    enemy.Hp -= Player.strengh;
                }
                if (heroAction == "Attack with a sword")
                {
                    Console.CursorTop += 1;
                    Console.WriteLine("You have attacked with a sword.");
                    enemy.Hp -= Player.Power + (Player.lvl * 6);
                }
                if (heroAction == "Attack with a bow")
                {
                    Console.CursorTop += 1;
                    Console.WriteLine("You have attacked with a bow.");
                    enemy.Hp -= Player.Power;
                }
            }
            else if (enemyAction == "Attacks from below")
            {
                if (heroAction == "Jump")
                {
                    Console.SetCursorPosition(20, 10);
                    Console.WriteLine("You have succesfully dodged.");
                }
                else
                {
                    if (Player.IsShield == false || Player.shieldIsUsed == true)
                    {
                        Console.WriteLine("You were attacked.");
                        Player.health -= enemy.Power;
                    }
                    else
                    {
                        Console.WriteLine("You were attacked, but you used a shield.");
                        Player.health -= (enemy.Power - Player.shieldProtection);
                        Player.shieldIsUsed = true;
                    }
                }
                if (heroAction == "Attacks")
                {
                    Console.CursorTop += 1;
                    Console.WriteLine("You have attacked.");
                    enemy.Hp -= Player.strengh;
                }
                if (heroAction == "Attack with a sword")
                {
                    Console.CursorTop += 1;
                    Console.WriteLine("You have attacked with a sword.");
                    enemy.Hp -= Player.Power + (Player.lvl * 6);
                }
                if (heroAction == "Attack with a bow")
                {
                    Console.CursorTop += 1;
                    Console.WriteLine("You have attacked with a bow.");
                    enemy.Hp -= Player.Power;
                }
            }
            else if (enemyAction == "Attacks from above")
            {
                Console.SetCursorPosition(20, 10);
                if (heroAction == "Dodge down ")
                {
                    Console.WriteLine("You have succesfully dodged.");
                }
                else
                {
                    if (Player.IsShield == false || Player.shieldIsUsed == true)
                    {
                        Player.health -= enemy.Power;
                        Console.WriteLine("You were attacked.");
                    }
                    else
                    {
                        Player.health -= (enemy.Power - Player.shieldProtection);
                        Player.shieldIsUsed = true;
                        Console.WriteLine("You were attacked, but you used a shield.");
                    }
                }
                if (heroAction == "Attacks")
                {
                    Console.CursorTop += 1;
                    Console.WriteLine("You have attacked.");
                    enemy.Hp -= Player.strengh;
                }
                if (heroAction == "Attack with a sword")
                {
                    Console.CursorTop += 1;
                    Console.WriteLine("You have attacked with a sword.");
                    enemy.Hp -= Player.Power + (Player.lvl * 6);
                }
                if (heroAction == "Attack with a bow")
                {
                    Console.CursorTop += 1;
                    Console.WriteLine("You have attacked with a bow.");
                    enemy.Hp -= Player.Power;
                }
            }
        }
        public void WinnerOrLooser(Enemy enemy)
        {
            if (enemy.Hp <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("You won.");
                if (Player.IsLearningPhase == false)
                {
                    Console.SetCursorPosition(60, 11);
                    Console.WriteLine("Level up!");
                    Player.lvl += 1;

                    Thread.Sleep(3000);

                    UI.Init();
                }
                else
                {
                    Console.SetCursorPosition(0, 11);
                    Console.WriteLine("Обучение завершено успешно! \n В ближайшее время начнется основная битва!!!");
                    Player.IsLearningPhase = false;
                    GameInit.Save();
                    Thread.Sleep(2000);
                    Console.Clear();
                    if (Player.TypeOfLearning == 1)
                    {
                        Console.Clear();
                        Enemy enemy1 = new Enemy(10, "robber", 3);
                        Battle battle1 = new Battle();
                        battle1.Fighting(enemy1);
                    }
                    else if (Player.TypeOfLearning == 2)
                    {
                        Console.Clear();
                        Enemy enemy1 = new Enemy(50, "vampire", 10);
                        Battle battle1 = new Battle();
                        battle1.Fighting(enemy1);
                    }
                    else if (Player.TypeOfLearning == 3)
                    {
                        Console.Clear();
                        Enemy enemy1 = new Enemy(40, "kamaz with alienis", 7);
                        Battle battle1 = new Battle();
                        battle1.Fighting(enemy1);
                    }
                    else if (Player.TypeOfLearning == 4)
                    {
                        Console.Clear();
                        Enemy enemy1 = new Enemy(65, "hidra", 13);
                        Battle battle1 = new Battle();
                        battle1.Fighting(enemy1);
                    }
                }

            }
            else
            {
                Console.SetCursorPosition(60, 11);
                Console.ForegroundColor = ConsoleColor.Red;
                if (Player.IsLearningPhase == false)
                {
                    GameInit.GameOver();
                    Thread.Sleep(3000);
                    Player.health = Player.lvl * 10;
                    Console.WriteLine("You lose.");


                }
                else
                {
                    Console.SetCursorPosition(0, 11);
                    Console.WriteLine("К сожалению вы проиграли тренировочному противнику, но вы можете попробовать свои силы с настроящим врагом! \n В ближайшее время начнется основная битва!!!");
                    Player.IsLearningPhase = false;
                    GameInit.Save();
                    Player.health = Player.lvl * 10;
                    Thread.Sleep(2000);
                    Console.Clear();
                    if (Player.TypeOfLearning == 1)
                    {
                        Console.Clear();
                        Enemy enemy1 = new Enemy(10, "robber", 3);
                        Battle battle1 = new Battle();
                        battle1.Fighting(enemy1);
                    }
                    else if (Player.TypeOfLearning == 2)
                    {
                        Console.Clear();
                        Enemy enemy1 = new Enemy(50, "vampire", 10);
                        Battle battle1 = new Battle();
                        battle1.Fighting(enemy1);
                    }
                    else if (Player.TypeOfLearning == 3)
                    {
                        Console.Clear();
                        Enemy enemy1 = new Enemy(40, "kamaz with alienis", 7);
                        Battle battle1 = new Battle();
                        battle1.Fighting(enemy1);
                    }
                    else if (Player.TypeOfLearning == 4)
                    {
                        Console.Clear();
                        Enemy enemy1 = new Enemy(65, "hidra", 13);
                        Battle battle1 = new Battle();
                        battle1.Fighting(enemy1);
                    }
                }
            }
        }

        public void Fighting(Enemy enemy)
        {
            Player.SetStats();
            while (Player.health > 0 && enemy.Hp > 0)
            {
                Player.shieldIsUsed = false;
                Player.numOfUsingSword = 0;
                enemy.Prepearing();
                Player.Prepearing();
                string action = enemy.GenerateAction();
                int chosenVariant = 0;
                DisplayEnemyStatus(action);
                int firstNum = NumOfFirstVariant1(enemy);
                int lastNum = NumOfLastVariant1(enemy);
                ChosingVariant(lastNum);
                DisplayActionVaryant(Player.ActionVariants, firstNum, lastNum);
                chosenVariant = ProtectionFromFools(lastNum);
                while (chosenVariant == 0)
                {
                    chosenVariant = ProtectionFromFools(lastNum);
                }
                Reaction(Player.ActionVariants[chosenVariant + firstNum - 1], action, enemy);
                Thread.Sleep(2000);
                Console.Clear();
            }
            WinnerOrLooser(enemy);
            Thread.Sleep(3000);
            Console.Clear();
        }
    }
    static class Player
    {
        public static int TypeOfLearning;
        public static int PlayerPhase = 0;
        public static int PlusGold;
        public static bool IsLearningPhase = false;
        public static bool IsShield = false;//есть ли щит
        public static int shieldProtection = lvl * 2; //на сколько меньше урона наносит враг герою
        public static bool shieldIsUsed = false;
        public static int lvl = 0; //уровень
        static public int coin = 100;
        public static int health = (lvl + 1) * 10; //хп
        public static int strengh = health / 5; //сила удара
        public static string name; //имя
        public static bool IsCloak = false;
        public static int numOfUsingSword = 0;
        public static int Charisma = 50;
        private static string[] hero_appearance = {
            "\\0/\n" +
            "                                             |\n" +
            "                                            / \\\n" ,

            "\\0/\n" +
            "                                             |\n" +
            "                                             |\n" +
            "                                            / \\\n" ,

            "0 /\n" +
            "                                           \\|/\n" +
            "                                            |\n" +
            "                                           / \\\n" ,

            "\\ 0 /\n" +
            "                                             \\|/\n" +
            "                                              |\n" +
            "                                             / \\\n" ,

            "\\ 0 /\n" +
            "                                             \\|/\n" +
            "                                              |\n" +
            "                                             / \\\n" +
            "                                                \\ \n" ,

            "\\ 0 /\n" +
            "                                             \\|/\n" +
            "                                              |\n" +
            "                                             / \\\n" +
            "                                            /   \\ \n" ,};
        public static string[] hero_weapon = { "@xxxx[{:::::::::::>",
        "\n"+
        "\n"+
        "\n"+
        "\n"+
        "/---\\\n"+
        "| Х |\n" +
        " \\ /   ",
        "|#/\\\n"+
        "| /#\n"+
        "|/#\n" };
        private static string[] actionVariants = { "Dodge", "Attack", "Wait", "Dodge down", "Jump", "Dodge to the right",
        "Dodge to the left" , "Attack with a bow","Put out the fire", "Neutralize the acid", "Attack with a sword"  ,"Dodge to the right", "Dodge to the left", "Dodge down", "Jump",
            "Hide behind a magic cloak", "Dodge back"};

        public static void SetStats()
        {
            if (lvl > 5)
            {
                PlayerPhase = 5;
            }
            else
            {
                PlayerPhase = lvl;
            }
            if (lvl > 3)
            {
                IsShield = true;
            }//проверка на наличие щита

        }

        public static void Prepearing()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(30, 0);
            Console.CursorSize = 70;
            Console.WriteLine(Player.name);
            Console.SetCursorPosition(30, 2);
            Console.WriteLine("Hp: " + Player.health);
            Console.SetCursorPosition(30, 4);
            Console.WriteLine("Power: " + Player.strengh);
            Console.SetCursorPosition(30, 5);
            Console.WriteLine("Level: " + Player.lvl);
            Console.CursorTop = 7;
            Console.CursorLeft = 44;
            if (lvl < 5)
            {
                Console.WriteLine(hero_appearance[lvl]);
            }
            else
            {
                Console.WriteLine(hero_appearance[5]);
            }

        }

        public static int Hp { get { return Player.health; } set { Player.health = value; } }
        public static string[] ActionVariants { get { return actionVariants; } }
        public static int Power { get { return Player.strengh; } set { Player.strengh = value; } }
        public static int Level { get { return Player.lvl; } set { Player.lvl = value; } }
    }
    class UI
    {
        public static int Random_U(int a, int b)
        {
            Random random1 = new Random();

            int t = random1.Next(a, b);
            return t;
        }
        public static bool QuestIsSaved;
        public static int quest = 0;
        private static int Err; //защита от выхода из массива персонажа
        private static char texture = '#'; //Текстура рисования разметки (можно изменить)
        static string[] ITEMS = { "Меч" + "  " + Player.hero_weapon[0], "Лук" + "\n" + Player.hero_weapon[1] + "\n", "Шлем", "Нагрудник", "Штаны", "Ботинки" }; //предметы <ALPHA>
        static string[] PlayerPic = //человечек и его другие формы
        {
               "\n        \\0/\n" +
            "         |\n" +
            "        / \\\n" ,

               "\n        \\0/\n" +
            "         |\n" +
            "         |\n" +
            "        / \\\n" ,

             "\n         0 /\n" +
            "        \\|/\n" +
            "         |\n" +
            "        / \\\n" ,

            "\n       \\ 0 /\n" +
            "        \\|/\n" +
            "         |\n" +
            "        / \\\n" ,

            "\n       \\ 0 /\n" +
            "        \\|/\n" +
            "         |\n" +
            "        / \\\n" +
            "           \\ \n" ,

            "\n       \\ 0 /\n" +
            "        \\|/\n" +
            "         |\n" +
            "        / \\\n" +
            "       /   \\ \n" ,
        }; //Все фазы персонажа
        public static int fr = Random_U(6, 25);

        public static string[] words = { "К тебе подошел Гендальф и спросил,\n можно ли отдохнуть в мурманске? "
                                 ,"Твой путь начинается в Новиграде,\n к тебе подошла Цири и сказала:\n" +
                                 "-Тут кое - кто интересуется что тебе\n подарили на новый год?","Долгие года скитаний привели тебя\n на Камчатку,\n рядом есть магазин,\n в нем продается нечто в виде плаща,\n хочешь купить?","Не прошло и минуты как из под земли\n вылез Индина Джонс\n  и злобно говорит тебе:\n" +
                                 "  -слухай сюда, почему в пятерочке\n столько Гулей?","-Хорошо сказано!,\n подумал ты, и пошел дальше.\n" +
                                " А после с дерева  рядом с тобой\n спрыгнул Ведьмак. \n" +
                                                                         "  На себе он тащит хоббита.\n" +
                                                                         "   Ведьмак Глаголет:\n" +
                                                                             "  я обещал своему народу\n рассмешить хоббита","Случилось в жизни многое........\n" +
                                                                        "    сразу за этим вдалеке ты увидел луг,\n на котором паслись "+ fr+"  динозавров " ,"Все началось в общественной бане.\n" +
                                                                             "      Ты задумался о жизни,вселенной\n" +
                                                                              "    и о всем таком.\n А самое главное- что есть мир,\n что есть я?","После череды невероятных событий\n пришел илсаныч и сказал:\n" +
                                                                              "    -давай выкладывай,\n что хорошо смотрится на полочке,\n " +
                                                                              "     рядом с горой трупов?","-Именно!,\nпозднее к тебе пришел граф дракула,\n" +
                                                                              "    и сказал:\n  - что собирается из циркуля?","Ты находишься в пиццерии Ктулуху,\n ты задумался - чтобы заказать?","" +
                                                                              "Но вдруг возле тебя\n на парашюте  высаживается орк Грухай\n и говорит:\n" +
                                                                              "-Сколько ты видел динозавров?","Ты очухиваешься в Перьми.\nИз под земли вылез гопник\n и пищит на азбуке морзе:\n" +
                                                                              "-ответь, где лучше никогда не бывать?","Череда невероятных событий привела\n тебя  в Карфаген","-Ну ну а после к тебе пришел\n" +
                                                                              " твой наставник и говорит тебе в лицо:\n" +
                                                                              "-где обитают самые опасные преступники?","- Точно! -  скзал он и скрылся\n" +
                                                                              "После этого ты вошел в странный портал\n и телепортировался в нарнию. \n" +
                                                                              "В местном модном кафе рядом с тобой \nкто - то жрет бургер и одновременно\n пишет симфонию","Далее из под земли вылез Персей\n и громко кричит:\n" +
                                                                              "-Где тебе всегда будут рады?"," К тебе подошел странный человек\n в балахоне и спросил:\n" +
                                                                              "Желаешь купить пузырек силы?\n" +
                                                                              "Всего за 50 голды","В интернете очень хвалят это место,\n потому ты сюда и пришел.\nНастоло время для игры на смерть!\n","К тебе подошел автор этой игры и спросил:\n Какое мое любимое число?",
                                                                               "Ты спокойно ехал домой,\n но вдруг на обочину выехал фургон\n у тебя секунда на размышление,\n что делать?!\n",
                                                                                           "К тебе пришел автор сюжета и сказал\n: Попробуй в следующий раз\n зайти как Admin","Путь твой продолжился в Челябинске\n" +
                                                                              "к тебе подошел Роберт и сказал:\n" +
                                                                              "-ты плюнул мне в суп, а это значит я буду\n бить тебя сильно и часто! ","Ты приехал в Саратов, и выпив в баре от Илсаныча\n три рюмки вишневой наливки,\n и отведав 3 котлеток попал магическим\n образом в подземелье","Ты мирно плавал в озере, \nкак вдруг осознал, что тебя \nкто то тянет на дно!" +
                                                                                "Ты попытался увидеть\n кто это,\nи понял что это.......... Гидра!" ,"Когда ты ехал закупаться\n туалеткой в магаз,\n ты повстречал нечто странное....\n Фургон с пришельцами.\n Увидев что ты покупаешь туалетку,\n у них шли бои на деньги."};
        public static string[] answ = { "1)да   " +
                    " 2)нет  " +
                    " 3)иди нафиг "," 1)переносной туалет" +
                    " 2) мешок с голдой" +
                    " 3) Билет на самолет в Чебоксары"," 1)Нет!" +
                    " 2) СМЫСЛ??" +
                    " 3) да)"," 1)может бабушек? " +
                    " 2) так надо  " +
                    " 3)меня достали твои вопросы!!","1)Ты что дурак?" +
                    " 2)Так чего же ты ждешь?" +
                    " 3)не надо!  "," 1)хорошо" +
                    " 2) и зачем мне это" +
                    " 3) что курил автор этой игры?(Мыло)"," 1) я конь по имени плотва" +
                     " 2)я мусор " +
                     " 3)я пластырь"," 1)я нуклеиновая кислота" +
                     " 2) я тортик бомба" +
                     " 3)батут"," 1) тюмень" +
                     " 2) автор этой иры" +
                     " 3) Dota 2",
                     " 1)Пиццу" +
                     " 2)Астрахань" +
                     " 3)Хагрида",
                     "1) " + fr.ToString() + "  2) "+Random_U(1,5)+" "+ "3) 0"  ," 1) в морге " +
                     " 2) в ипподроме" +
                     " 3) в России"," 1)сделать что-нибудь" +
                     " 2)Ничего не делать" +
                     " 3)ок", " 1) В Греумбурге" +
                     " 2) на острове из лотоса" +
                     " 3) в сайлент хилс"," 1)это печально" +
                     " 2) забавно" +
                     " 3) странное место" ," 1) В татарстане" +
                     " 2) в Квест- комнате" +
                     " 3) в багажнике наркоторговца"," 1) Да" +
                     " 2) Нет" +
                     " 3) Отсань!"," 1)Нет " +
                " 2) Да" +
                " 3)А  что мне будет?"
                ," 1) я то откуда знаю?" +
                " 2)"+Random_U(4000,5678)+" 3) 3714"," 1) Рули вправо 2) руль влево 3) помолиться"

                ," 1) И что мне будет ? 2) зачем? 3) хорошо спасибо"," 1)капец тебе!" +
                     " 2)получай!" +
                     " 3) Какой тебе гроб заказать?"," 1)NO"+" 2)ну что, опять!?" + " 3)Это была не просто котлетка("," 1) и что делать?! 2) Ну и задам я ей жару 3)неет!" ," 1) сыграем? 2) какой выигрышь? 3) на меня поставили!"
            };
        static bool[] repeat = new bool[words.Length];
        public static int IsFight = 1;



        public static void Init()
        {
            Console.Clear();
            Console.CursorVisible = false;


            Player.SetStats();
            GameInit.Save();

            DrawGrid(); //Рисуем интерфейс

            Write(); //все нужные надписи

            //Choose();

            DrawInventory();

            //Выбор варианта кнопками на клавиатуре

            Console.ReadLine();
        } //Инициализация

        public static void DrawGrid()
        {
            Console.ResetColor();
            Set(0, Console.WindowHeight / 2 + 3);
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write(texture);
            }
            for (int i = 0; i < Console.WindowHeight; i++)
            {
                Set(40, i);
                Console.WriteLine(texture);
            }
            for (int i = 0; i < 12; i++)
            {
                Set(17, Console.WindowHeight / 2 + 3 + i);
                Console.WriteLine(texture);
            }
        } //Разметка из '#'
        public static void End1()
        {

            GameInit.GameOver();


        }

        public static void Nadpisy()
        {
            //Текст в верхнем поле

            Console.ForegroundColor = ConsoleColor.Red;
            Set(18, Console.WindowHeight / 2 + 3 + 1);
            Console.WriteLine("Stats: ");

            Console.ResetColor();

            Set(18, Console.WindowHeight / 2 + 3 + 2);
            Console.WriteLine("Level: " + Player.lvl);

            Set(18, Console.WindowHeight / 2 + 3 + 3);
            Console.WriteLine("Health: " + Player.health);

            Set(18, Console.WindowHeight / 2 + 3 + 4);
            Console.WriteLine("Strengh: " + Player.strengh);

            Set(18, Console.WindowHeight / 2 + 3 + 5);
            Console.WriteLine("Gold: " + Player.coin);

            Set(18, Console.WindowHeight / 2 + 3 + 6);
            Console.WriteLine("Shield: " + Player.IsShield);
            //Текст в нижнем поле
            Set(18, Console.WindowHeight / 2 + 3 + 7);
            Console.WriteLine("Cloak: " + Player.IsCloak);

            Set(18, Console.WindowHeight / 2 + 3 + 8);
            // Console.WriteLine("Харизма: " + Player.Charisma);

            Console.ForegroundColor = ConsoleColor.Yellow;


            // "Выберете номер ответа:" и остальные надписи
            Console.ForegroundColor = ConsoleColor.Red;
            Set(42, 17);
            Console.Write("Выберете номер ответа: ");
            Set(0, 19);
            Console.Write(Player.name + ": ");

            Set(42, 0);
            Console.Write("Инвентарь: ");

        }
        public static void For_repeat()
        {

            for (int i = 0; i < repeat.Length; i++)
            {
                repeat[i] = false;
            }
        }
        public static bool ISorNO = false;



        public static void Write()
        {

            //MiniGame4();


            for (int i = 0; i < words.Length; i++)
            {
                if (QuestIsSaved == false)
                {
                    #region
                    if (i == 0)
                    {
                        quest = Random_U(0, 2);
                    }
                    if (i > 0)
                    {
                        quest = Random_U(2, words.Length - 5);
                    }
                    if (i == 5)
                    {
                        quest = 21;
                    }
                    if (i == 9)
                    {
                        quest = 22;
                    }
                    if (i == 15)
                    {
                        quest = 23;
                    }
                    if (i == 19)
                    {
                        quest = 24;
                    }
                    #endregion
                    if (repeat[quest] == true)
                    {

                        while (repeat[quest] == true)
                        {
                            quest = Random_U(2, words.Length - 4);

                        }
                    }
                }
                else
                {
                    QuestIsSaved = false;
                }

                repeat[quest] = true;

                Start_For_zickl();

                //печатаем вопросы
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(0, 0);

                Console.WriteLine(words[quest]);
                if (i == 1)
                {
                    Set(0, 20);
                    Console.WriteLine("3714");
                }

                //печатаем ответы
                Console.SetCursorPosition(41, 19);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(answ[quest]);
                Console.SetCursorPosition(41, 21);
                Console.Write("Ваш ответ: ");
                string a = Console.ReadLine();
                int y;
                bool flag = Int32.TryParse(a, out y);
                while (flag == false || a != "1" && a != "2" && a != "3")
                {
                    Console.Clear();

                    Start_For_zickl();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(0, 0);
                    if (i == 1)
                    {
                        Set(0, 20);
                        Console.WriteLine("3714");
                    }
                    Console.WriteLine(words[quest]);

                    //печатаем ответы
                    Console.SetCursorPosition(41, 19);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(answ[quest]);
                    Console.SetCursorPosition(41, 21);
                    Console.Write("Ваш ответ: ");
                    a = Console.ReadLine();
                    flag = Int32.TryParse(a, out y);
                }

                if (quest == 2 && a == "3")
                {
                    if (Player.coin >= 20)
                    {
                        Player.IsCloak = true;
                        Player.coin = Player.coin - 20;

                        Player.strengh += 15;
                        Nadpisy();
                    }
                    else
                    {
                        Set(42, 10);
                        Console.WriteLine("Не хватает денег");
                    }
                }
                if (quest == 1 && a == "2")
                {
                    Console.Clear();
                    Console.WriteLine("ОПА, А ВОТ И ГОЛДА!\n " +
                        "+45");
                    Player.coin += 45;
                    Thread.Sleep(3000);

                }
                if (quest == 17)
                {
                    MiniGame();
                }
                if (quest == 5)
                {
                    ISorNO = true;
                }
                if (quest == 10)
                {
                    if (ISorNO == false)
                    {
                        if (a != "3")
                        {
                            Console.Clear();
                            Console.WriteLine("Неправльный ответ(");
                            Thread.Sleep(1000);
                            Console.Clear();
                            End1();
                        }

                    }
                    else if (ISorNO == true && a != "1")
                    {
                        Console.Clear();
                        Console.WriteLine("Неправльный ответ(");
                        Thread.Sleep(1000);
                        Console.Clear();
                        End1();
                    }
                }
                if (quest == 16 && a == "1")
                {
                    if (Player.coin >= 50)
                    {
                        Player.coin -= 50;
                        Player.strengh += 25;

                    }
                    else
                    {
                        Console.Clear();
                        Set(0, 0);
                        Console.WriteLine("Не хватает денег");
                    }

                }
                if (quest == 21)
                {

                    Console.Clear();
                    Learning learn = new Learning(1);
                    learn.ChooseLevelOfLearning();



                }
                if (quest == 22)
                {
                    MiniGame2();

                }
                if (quest == 19)
                {
                    MIniGame3(a);
                }
                if (quest == 18 && a != "3")
                {

                    Console.Clear();
                    Console.WriteLine("Ты не угадал)");
                    GameInit.GameOver();
                }
                if (quest == 24)
                {
                    Console.Clear();
                    Learning learn = new Learning(4);
                    learn.ChooseLevelOfLearning();
                }
                if (quest == 23)
                {
                    Console.Clear();
                    Learning learn = new Learning(3);
                    learn.ChooseLevelOfLearning();
                }
                GameInit.Save();
            }
        }
        /*public static void MiniGame4()
w{
            if (1 == 1)
            {
                Console.Clear();
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Green;
                string text1 = "1010001010101010100110101110001101010101010101010010010101010010101101123894127687213487634876827428787348324";
                string text2 = "0101010101001010101010101011411001000000000010011001010101001010101010121341283947932184798327409827498273987";
                string text3 = "10100010101010101001101010103110101010101010101010010100101010010100010121746824925621587273268471263876876487";
                string text4 = "0010101010000101010100101010210101010010101010101010101010100101010010109876543212345678285`363748253756871648762";
                string text5 = "10100010101010101001110100101100101010101001010010101001010010100101001131275665371697697246576474767465946904";
                string text6 = "10100010101010101001100101001101001010101010101010101010101010101010101012415453776849672568648756186745879388";
                string text7 = "10100010101010101001010101010110010101010101000101010100101000101010010100123279836419274189564832645615328951631";
                for (int i = 0; i < text1.Length; i++)
                {
                    Console.Write(text1[i]);
                    Thread.Sleep(10);
                }
                Console.WriteLine();
                for (int i = 0; i < text2.Length; i++)
                {
                    Console.Write(text2[i]);
                    Thread.Sleep(10);
                }
                Console.WriteLine();
                for (int i = 0; i < text3.Length; i++)
                {
                    Console.Write(text3[i]);
                    Thread.Sleep(10);
                }
                Console.WriteLine();
                for (int i = 0; i < text4.Length; i++)
                {
                    Console.Write(text4[i]);
                    Thread.Sleep(10);
                }
                Console.WriteLine();

                for (int i = 0; i < text5.Length; i++)
                {
                    Console.Write(text5[i]);
                    Thread.Sleep(10);
                }
                Console.WriteLine();
                for (int i = 0; i < text6.Length; i++)
                {
                    Console.Write(text6[i]);
                    Thread.Sleep(10);
                }
                Console.WriteLine();
                for (int i = 0; i < text7.Length; i++)
                {
                    Console.Write(text7[i]);
                    Thread.Sleep(10);
                }
                Thread.Sleep(3000);
                Console.WriteLine();
                Console.WriteLine("Вход выполнен успешно!");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                string a1 = "Вау! Ты попал в секретный аккаунт админа! Молодец!, возьми голды ";
                for (int i = 0; i < a1.Length; i++)
                {
                    Console.Write(a1[i]);
                    Thread.Sleep(55);
                }
                Player.coin += 100000000;
                //скоро здесь что то будет.......)
                Thread.Sleep(1000);

            }


        }*/
        public static void MIniGame3(string a)
        {
            Console.Clear();
            Set(10, 10);




            Console.WriteLine("██▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀███████████████████\n" +
                              "██░░░░░░░░░░░░░░░░░░░███████████████████\n" +
                              "██░░░░░░░░░░░░░░░░░░░█▀░░░░░▀███████████\n" +
                              "██░░░░░░░░░░░░░░░░░░░█░░████░███████████\n" +
                              "██░░░░░░░░░░░░░░░░░░░█░░████░▀▀▀▀▀▀▀████\n" +
                              "██▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄█░░░░░░░░░░░░░░░▀██\n" +
                              "███▀▀▀▀▀▀█▀▀▀▀█▀▀▀▀▀▀▀░░░░░░░░░░▄▀▀▀▀▄██\n" +
                              "████▄▄▄▄█░█▀▀█░█▄▄▄▄▄░░░░░░░░░░█░█▀▀█░██\n" +
                              "█████████░█▄▄█░█████████████████░█▄▄█░██\n" +
                              "██████████▄▄▄▄███████████████████▄▄▄▄███\n");

            int yu = Random_U(1, 4);
            if (a == "1" && yu == 1)
            {
                Console.WriteLine("Фух, ты справился и фургон улетел в кювет");
                Thread.Sleep(3000);
            }
            if (a == "1" && yu != 1)
            {
                Console.WriteLine("К сожалению ты врезался в фургон, и врачи не смогли тебя спасти.");
                Thread.Sleep(3000);
                GameInit.GameOver();
            }
            if (a == "2" && yu == 2)
            {
                Console.WriteLine("Фух, ты справился и фургон улетел в кювет");
                Thread.Sleep(3000);
            }
            if (a == "2" && yu != 2)
            {
                int rrr = Random_U(1, 4);
                Console.WriteLine("Ты попал в аварию, машина в смятку, а ты в госпиталь");
                if (rrr == 1)
                {
                    Console.WriteLine("Но, врачи тебя спасли! тебя конечно потрепало, но удачи !");
                    Player.health -= 10;
                    Thread.Sleep(3000);
                }
                else
                {
                    Console.WriteLine(" К сожалению врачи не смогли тебя спасти.");
                    Thread.Sleep(3000);
                    GameInit.GameOver();
                }

            }
            if (a == "3")
            {
                int rrr = Random_U(1, 11);
                if (rrr != 1)
                {
                    Console.WriteLine("Ну, врачи тебя не спасли.Видимо это была твоя последняя молитва");
                    Thread.Sleep(3000);
                    GameInit.GameOver();
                }
                if (rrr == 1)
                {
                    Console.WriteLine("огромная удача тебя настигла!Молитва помогла))Фургон улетел в кювет Б и ты спокойно доехал домой");
                    Thread.Sleep(3000);
                }
            }

        }
        public static void MiniGame2()
        {
            Console.Clear();
            Thread.Sleep(500);
            string[] diolog_volsheblik = { "Некто : как тебя зовут, странник?\n", "Некто : Зачем ты здесь?\n" ,"Некто: И вообще , как ты сюда попал?" ,
                "Некто : что ж , я живу в этом подземелье уже очень много лет\n" ,
                "Некто : есть возможность выбраться отсюда, только вот никто так и не выбрался))\n","Да ладно, я пошутил: перед собой ты видишь три двери, в какую идем?\n"};
            string[] diolog_strannik = { "ты :" + Player.name+"\n", "1. ты : Чувак я сам в беспонятия, может ты мне объяснишь?" +
                " 2.Чтобы надовать тебе тумаков!\n","И вообще , как ты сюда попал? />долгая история","ты : И что нам делать?\n","ты : Ага ага, спасибо, вижу ты тот еще юмарист, давай пока)\n","1)В 1  2) Во 2 3) В 3\n"};
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("К тебе подошел человек в черном балахоне,\n но по строению лица похож на вампира\n");
            Thread.Sleep(2000);
            for (int i = 0; i < diolog_strannik.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(diolog_volsheblik[i]);
                Thread.Sleep(2000);
                if (i == 2)
                {
                    string r = Console.ReadLine();
                    if (r == "2")
                    {
                        Console.Clear();
                        Learning learn = new Learning(2);
                        learn.ChooseLevelOfLearning();
                        Console.Clear();
                        Player.Charisma -= 20;

                    }
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(diolog_strannik[i]);
                Thread.Sleep(2000);
                if (i == 4)
                {
                    Set(0, 25);
                    Console.Write("\n _____  _____  _____ \n" +
                              "|     ||     ||     |\n" +
                              "|    n||    n||    n|\n" +
                              "|     ||     ||     |\n" +
                              " _____  _____  _____ \n");


                }
                if (i == 5)
                {
                    string r1 = Console.ReadLine();
                    if (r1 == "1")
                    {
                        Console.WriteLine("Долгие годы скитаний привели тебя к подземному бункеру,\n и в нем сидел старый мудрец, и решал задачки с prodtime.\n" +
                            "Когда ты к нему подощел он спросил тебя:\n В чем смысл жизни? И ты ответил:");
                        string h = Console.ReadLine();
                        if (h == "его нет")
                        {
                            Console.Clear();
                            Console.WriteLine(" И мудрец промолвил: Я не ожидал найти здесь такую мудрость!" +
                                "Скажи чего тебе надо? Вся сделаю! ");
                            Thread.Sleep(2000);
                            Console.WriteLine(" Ты: Выбраться отсюда!! ");
                            Thread.Sleep(2000);
                            Console.WriteLine(" Аааа, окей. Направо по коридору,  3 дверь слева. возьми еще немного голды и подхилься ");
                            Player.coin += 75;
                            Player.health += 25;


                        }
                        Console.WriteLine("Нет! Ну и иди отсюда!");
                        Thread.Sleep(2000);
                        Console.WriteLine("В конце концов ты умер от жажды");
                        Thread.Sleep(6000);
                        GameInit.GameOver();

                    }
                    else
                    {
                        Console.WriteLine("*Вау, ты выбрался! Возьми голды!*");
                        Player.coin += 30;
                        Thread.Sleep(6000);
                    }
                }




            }

        }
        public static void MiniGame()
        {

            Console.Clear();
            Set(0, 0);
            int sum = 0;
            string a1 = "Честно говоря мне абсолютно пофиг на 3 вещи:\n" +
                  " 1) Что будет с Гвинейской экономикой через час\n" +
                  " 2) Как не попасть в зону падения Тунгусского метеорита\n" +
                  " 3) Твои ответы)))))))))\n" +
                  " Здесь я буду задовать вопросы, и получать от тебя ответы." +
                  " В случае побега ты будешь казнен.\n" +
                  " В случае неправильного ответы ты будешь сожжён.\n" +
                  "Думаю тебе уже интересно, кто я такой..... Но об этом позже.";
            for (int i = 0; i < a1.Length; i++)
            {
                Console.Write(a1[i]);
                Thread.Sleep(50);
            }
            Console.WriteLine();
            Thread.Sleep(350);
            Console.WriteLine("Всего будет 3 вопроса:\n" +
                " 1.  Когда был создан c# ");
            Thread.Sleep(100);
            Console.WriteLine("1) 2007-2009\n" +
                "2) 1996-1998\n" +
                " 3) 1998—2001 ");
            string a2 = Console.ReadLine();
            if (a2 == "3")
            {
                sum++;
            }
            Console.WriteLine(" 2. 33+77");
            Console.WriteLine("1) 100\n" +
                "2) 110\n" +
                " 3) 99 ");
            string a3 = Console.ReadLine();
            if (a3 == "2")
            {
                sum++;
            }

            Console.WriteLine("3. Когда был задуман ProgTime?(Именно идея)\n" +
                "1) в 2018\n" +
                "2) в 2019\n" +
                " 3) никто не знает\n ");
            string a4 = Console.ReadLine();
            if (a4 == "3")
            {
                sum++;
            }
            Console.WriteLine("Кол-во правильных ответов:" + sum);
            Thread.Sleep(350);
            int sr = 3 - sum;
            if (sum < 3)
            {
                Console.WriteLine("К сожалению, были неправильны ответы=>" + sr.ToString() + " ты выбываешь (=•_•=) ");
                Thread.Sleep(5000);
                GameInit.GameOver();
            }
            else
            {
                Console.WriteLine("Ну ну , молодец, на голды (>^.^)>");
                Player.coin += Random_U(45, 60);
                Thread.Sleep(5000);

            }
        }

        public static void Start_For_zickl()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Player.SetStats();
            DrawGrid();
            DrawInventory();
            Nadpisy();
        }

        public static void DrawInventory()
        {
            Console.ResetColor();
            int num = 0;
            if (Player.lvl > 6)
            {
                Err = 5;
            }
            else
            {
                Err = Player.lvl;
            }
            for (int i = 0; i < Err; i++)
            {
                Set(42, 1 + i);
                Console.WriteLine(ITEMS[i]);
                num++;
            }
            DrawPlayer(); //рисуем персонажа
        } //Инвентарь

        public static void DrawPlayer()
        {
            Console.ResetColor();
            Set(0, 20);
            Console.Write(PlayerPic[Player.PlayerPhase]);
        } //Персонаж (его вид зависит от количества шмота в инвентаре)

        public static void Set(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        } // задание позиции курсора
    }
    static class GameInit
    {
        static string[] GameNamePic = {
            "██████╗░██████╗░░█████╗░██╗░░░██╗███████╗\n"+
            "██╔══██╗██╔══██╗██╔══██╗██║░░░██║██╔════╝\n"+
            "██████╦╝██████╔╝███████║╚██╗░██╔╝█████╗░░\n"+
            "██╔══██╗██╔══██╗██╔══██║░╚████╔╝░██╔══╝░░\n"+
            "██████╦╝██║░░██║██║░░██║░░╚██╔╝░░███████╗\n"+
            "╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝░░░╚═╝░░░╚══════╝\n"+
            "\n"+
            "██╗░░░░░██╗██╗░░░░░██╗░░░░░██╗██████╗░██╗░░░██╗████████╗██╗░█████╗░███╗░░██╗\n"+
            "██║░░░░░██║██║░░░░░██║░░░░░██║██╔══██╗██║░░░██║╚══██╔══╝██║██╔══██╗████╗░██║\n"+
            "██║░░░░░██║██║░░░░░██║░░░░░██║██████╔╝██║░░░██║░░░██║░░░██║███████║██╔██╗██║\n"+
            "██║░░░░░██║██║░░░░░██║░░░░░██║██╔═══╝░██║░░░██║░░░██║░░░██║██╔══██║██║╚████║\n"+
            "███████╗██║███████╗███████╗██║██║░░░░░╚██████╔╝░░░██║░░░██║██║░░██║██║░╚███║\n"+
            "╚══════╝╚═╝╚══════╝╚══════╝╚═╝╚═╝░░░░░░╚═════╝░░░░╚═╝░░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝\n",
        };
        static string[] GameOverPic =
        {

            "░██████╗░░█████╗░███╗░░░███╗███████╗    ░█████╗░██╗░░░██╗███████╗██████╗░██╗\n"+
            "██╔════╝░██╔══██╗████╗░████║██╔════╝    ██╔══██╗██║░░░██║██╔════╝██╔══██╗██║\n"+
            "██║░░██╗░███████║██╔████╔██║█████╗░░    ██║░░██║╚██╗░██╔╝█████╗░░██████╔╝██║\n"+
            "██║░░╚██╗██╔══██║██║╚██╔╝██║██╔══╝░░    ██║░░██║░╚████╔╝░██╔══╝░░██╔══██╗╚═╝\n"+
            "╚██████╔╝██║░░██║██║░╚═╝░██║███████╗    ╚█████╔╝░░╚██╔╝░░███████╗██║░░██║██╗\n"+
            "░╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝    ░╚════╝░░░░╚═╝░░░╚══════╝╚═╝░░╚═╝╚═╝  ",


        };

        public static void IsNeedLoad()
        {
            if (File.Exists("Save.txt") == false)
            {
                StreamWriter writer = new StreamWriter("Save.txt");
                writer.Close();
            }

            StreamReader reader = new StreamReader("Save.txt");
            string y = reader.ReadToEnd();
            if (y != "")
            {
                Console.WriteLine("Save found.");
                Console.WriteLine("Do you want to load it?");
                Console.WriteLine("1) Yes (Y)");
                Console.WriteLine("2) No (N)");
                if (Console.ReadKey(true).Key == ConsoleKey.Y)
                {
                    UI.QuestIsSaved = true;
                    Load();
                    string a = "Loading...\n";
                    string b = "Complete!";
                    for (int i = 0; i < a.Length; i++)
                    {
                        Console.Write(a[i]);
                        Thread.Sleep(40);
                    }
                    for (int i = 0; i < b.Length; i++)
                    {
                        Console.Write(b[i]);
                        Thread.Sleep(40);
                    }
                    Thread.Sleep(1000);
                    reader.Close();
                }
                else if (Console.ReadKey(true).Key == ConsoleKey.N)
                {
                    reader.Close();
                    StartScreen();
                }
                else
                {
                    reader.Close();
                    IsNeedLoad();
                }
            }
            else
            {
                reader.Close();
                StartScreen();
            }

        }


        public static void StartScreen()
        {
            Console.Clear();

            Console.WriteLine(GameNamePic[0]);

            Console.Write("Write your name: ");
            Player.name = Console.ReadLine();

            if (Player.name.Length > 15 || Player.name == "")
            {
                Console.WriteLine("You entered wrong name, try again.");
                Thread.Sleep(1500);
                StartScreen();
            } //влезет ли имя в интерфейс

            Console.CursorVisible = false;
            Console.SetCursorPosition(0, 16);
            //Console.WriteLine("Everything is almost ready...\n");
            string a1 = "Everything is almost ready...";
            string a2 = "Complete!";
            string a3 = "Enjoy the game.";
            for (int i = 0; i < a1.Length; i++)
            {
                Console.Write(a1[i]);
                Thread.Sleep(80);
            }
            Console.WriteLine();
            Thread.Sleep(2000);
            for (int i = 0; i < a2.Length; i++)
            {
                Console.Write(a2[i]);
                Thread.Sleep(80);
            }
            Thread.Sleep(500);
            Console.WriteLine();
            for (int i = 0; i < a3.Length; i++)
            {
                Console.Write(a3[i]);
                Thread.Sleep(80);
            }
            Thread.Sleep(1000);
        }

        public static void GameOver()
        {
            Console.Clear();
            Console.WriteLine(GameOverPic[0]);

            Console.WriteLine("1) Reboot game.");
            Console.WriteLine("2) Close.");
            if (Console.ReadKey(true).Key == ConsoleKey.D1)
            {
                Player.lvl = 0;
                Player.IsShield = false;
                Player.shieldProtection = 0;
                UI.Init();
            }
            else if (Console.ReadKey(true).Key == ConsoleKey.D2)
            {
                Environment.Exit(0);
            }
        }

        public static void Save()
        {
            StreamWriter writer = new StreamWriter("Save.txt");
            writer.WriteLine(Player.lvl);
            writer.WriteLine(Player.health);
            writer.WriteLine(Player.strengh);
            writer.WriteLine(Player.IsShield);
            writer.WriteLine(Player.name);
            writer.WriteLine(Player.PlayerPhase);
            writer.WriteLine(Player.shieldProtection);
            writer.WriteLine(UI.quest);
            writer.Close();
        }
        public static void Load()
        {
            StreamReader reader = new StreamReader("Save.txt");
            Player.lvl = int.Parse(reader.ReadLine());
            Player.health = int.Parse(reader.ReadLine());
            Player.strengh = int.Parse(reader.ReadLine());
            Player.IsShield = bool.Parse(reader.ReadLine());
            Player.name = reader.ReadLine();
            Player.PlayerPhase = int.Parse(reader.ReadLine());
            Player.shieldProtection = int.Parse(reader.ReadLine());
            UI.quest = int.Parse(reader.ReadLine());
            reader.Close();
        }

    }

}