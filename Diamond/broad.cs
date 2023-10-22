using System.Text;                                                           //su dung stringbuilder khac string o cho khi mo rong hay xoa thi la 1 instance

namespace Dia
{
    partial class Program
    {
        class Broad_C
        {
            /* tao khung hinh play game*/
            public void Broad_F()
            {
                Broad.Append("╔═══════════════════════════════════════════════════════════════════════════════════════════════════════════════╗" + (Char)10);           
                Broad.Append("║                                                                                                               ║" + (Char)10);
                Broad.Append("║                                                                                                               ║" + (Char)10);
                Broad.Append("║                    ╔═════════════════════════════════════════════════════════════════════╗                    ║" + (Char)10);
                Broad.Append("║    ^  : UP         ║      |      |      |      |      |      |      |      |      |      ║                    ║" + (Char)10);
                Broad.Append("║                    ║______|______|______|______|______|______|______|______|______|______║                    ║" + (Char)10);
                Broad.Append("║    v  : DOWN       ║      |      |      |      |      |      |      |      |      |      ║                    ║" + (Char)10);
                Broad.Append("║                    ║______|______|______|______|______|______|______|______|______|______║                    ║" + (Char)10);
                Broad.Append("║    >  : RIGHT      ║      |      |      |      |      |      |      |      |      |      ║                    ║" + (Char)10);
                Broad.Append("║                    ║______|______|______|______|______|______|______|______|______|______║                    ║" + (Char)10);
                Broad.Append("║    <  : LEFT       ║      |      |      |      |      |      |      |      |      |      ║                    ║" + (Char)10);
                Broad.Append("║                    ║______|______|______|______|______|______|______|______|______|______║                    ║" + (Char)10);
                Broad.Append("║ SPACE : TICK (+)   ║      |      |      |      |      |      |      |      |      |      ║                    ║" + (Char)10);
                Broad.Append("║                    ║______|______|______|______|______|______|______|______|______|______║                    ║" + (Char)10);
                Broad.Append("║  Q  : Menu Game    ║      |      |      |      |      |      |      |      |      |      ║                    ║" + (Char)10);
                Broad.Append("║                    ║______|______|______|______|______|______|______|______|______|______║                    ║" + (Char)10);
                Broad.Append("║  M  : on/off Music ║      |      |      |      |      |      |      |      |      |      ║                    ║" + (Char)10);
                Broad.Append("║                    ║______|______|______|______|______|______|______|______|______|______║                    ║" + (Char)10);
                Broad.Append("║  ESC  : QUIT GAME  ║      |      |      |      |      |      |      |      |      |      ║                    ║" + (Char)10);
                Broad.Append("║                    ║______|______|______|______|______|______|______|______|______|______║                    ║" + (Char)10);
                Broad.Append("║                    ║      |      |      |      |      |      |      |      |      |      ║                    ║" + (Char)10);
                Broad.Append("║                    ║______|______|______|______|______|______|______|______|______|______║                    ║" + (Char)10);
                Broad.Append("║                    ║      |      |      |      |      |      |      |      |      |      ║                    ║" + (Char)10);
                Broad.Append("║                    ║      |      |      |      |      |      |      |      |      |      ║                    ║" + (Char)10);
                Broad.Append("║                    ╚═════════════════════════════════════════════════════════════════════╝                    ║" + (Char)10);
                Broad.Append("║                                                                                                               ║" + (Char)10);

                DisplayBroad.AddRange(Broad.ToString().Select(Chars => Chars.ToString()));   // cong vao danh sach in      
            }


            /*tao khung menu game*/
            public void BoxMenu()
            {
                // if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                // {
                //     Console.SetWindowSize(30, 22);   
                // }
                StringBuilder BroadMenu =new StringBuilder();
                DisplayBroadMenu.Clear();
                BroadMenu.Append(" " + (Char)10);
                BroadMenu.Append(" " + (Char)10);
                BroadMenu.Append(" " + (Char)10);
                BroadMenu.Append(" " + (Char)10);
                BroadMenu.Append(" " + (Char)10);
                BroadMenu.Append("                              ╔════════════════════════════════════════════════════╗" + (Char)10);
                BroadMenu.Append("                              ║                                                    ║" + (Char)10);
                BroadMenu.Append("                              ║                  DIAMOND LEGENDARY                 ║" + (Char)10);
                BroadMenu.Append("                              ║                                                    ║" + (Char)10);
                BroadMenu.Append("                              ║                                                    ║" + (Char)10);
                BroadMenu.Append("                              ║                          New Game                 ║" + (Char)10);
                BroadMenu.Append("                              ║                          Quit Game                ║" + (Char)10);
                BroadMenu.Append("                              ║                                                    ║" + (Char)10);
                BroadMenu.Append("                              ║                (press 'Space' to select)           ║" + (Char)10);
                BroadMenu.Append("                              ╚════════════════════════════════════════════════════╝" + (Char)10);
 
                DisplayBroadMenu.AddRange(BroadMenu.ToString().Select(Chars => Chars.ToString()));   // cong vao danh sach in  
                string[] Lines = BroadMenu.ToString().Split((Char)10);
                int Width = Lines[0].Length + 1;
                int Positi = (DisplayBroadMenu.Count / 2) + (Width / 2);

                DisplayBroadMenu[Positi+59]=">>";
                DisplayBroadMenu[Positi+143]="  ";

                PrintMenu();
                Task TMenu=new Task(() => PressMenu(Positi,Width));
                TMenu.Start();              
                TMenu.Wait();
                if(CheckMenu)
                {
                    Environment.Exit(-1);
                    Console.Beep(800, 500);
                }
                Console.Clear();
            }


            /*di chuyen con tro trong menu game*/
            private void PressMenu(int Positi,int Width)
            {
                bool CheckKey=false;
                while(!CheckKey)
                {
                    var Key = Console.ReadKey().Key;  //Lấy khóa bàn điều khiển .
                    switch (Key)                  
                    {
                        case ConsoleKey.UpArrow:
                        case ConsoleKey.DownArrow:
                            if(!CheckMenu)
                            { 
                                CheckMenu=true;
                                DisplayBroadMenu[Positi+143]=">>";
                                DisplayBroadMenu[Positi+59]="  ";
                            }else
                            {
                                CheckMenu=false;
                                DisplayBroadMenu[Positi+143]="  ";
                                DisplayBroadMenu[Positi+59]=">>";
                            }

                            break;
                        case ConsoleKey.Spacebar :
                            CheckKey=true;
                            break;
                        
                        case ConsoleKey.Escape:                          
                            Environment.Exit(-1);
                            Console.Beep(800, 500);
                            break;
                        
                        default :
                            break;
                    }
                    PrintMenu();
                }

            }


            /*in menu game*/
            private void PrintMenu()
            {
                StringBuilder DisplayMenu =new StringBuilder();
                Console.Clear();
                Display.Clear();
                DisplayMenu.Clear();                          
  
                DisplayBroadMenu.ForEach(Item => DisplayMenu.Append(Item));                
                DisplayMenu.Append(System.Environment.NewLine);           // tra ve chuoi moi cho dongs, ngat dong tro ve dau

                Console.SetCursorPosition(0, 0);
                Console.Write(DisplayMenu);

            }
            private static List<string> DisplayBroadMenu = new List<string>();               //chuoi hien thi menu game
            private static bool CheckMenu=false;                                             // kiem tra chon menu game     

        }
        
    }
}