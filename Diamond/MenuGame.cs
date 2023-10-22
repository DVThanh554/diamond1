
namespace Dia
{
    partial class Program
    {
        class Menu_C 
        {
            /* bang menu bat dau game*/
            public void Menu_F()
            {
                Data_C Data = new Data_C();
                var Broa =new Broad_C();
                Console.Clear();
                Lever=0;                                   
                Position = 482;              
                Position1 = 482;             
                Dire=true;
                Dire1=false;
                SaveI=0 ;              
                SaveJ=0 ;              
                SaveI1=0 ;             
                SaveJ1=0 ;              
                Choese = false;                               
                Choese1 = false;                                 
                Count=10;                                
                Name="player";                             
                Score =0  ; 
                Target=0;                           

                Task.Factory.StartNew(() => Music_C.MusicBackground());

                Broa.BoxMenu();

                LogIn();

                Data.Data_F();

           
            }

            
            /*Man hinh ghi ten */
            private void LogIn()
            {

                Console.Clear();
                for(int i=0;i<15;i++) Console.WriteLine();

                ConsoleColor newForeColor = ConsoleColor.White;
                ConsoleColor newBackColor = ConsoleColor.Black;
                if(Char.ToUpper(GetKeyPress("                          Do you want setup Color(Y/N): ", new Char[] { 'Y', 'N' } )) == 'Y')
                {

                    Char foreColorSelection = GetKeyPress("                      Select Text Color (D for Blue, R for Red, B for Black): ",
                    new Char[] { 'B', 'R', 'D' } );
                    switch (foreColorSelection) {
                        case 'D':
                        case 'd':
                        newForeColor = ConsoleColor.DarkBlue;
                        break;
                        case 'R':
                        case 'r':
                        newForeColor = ConsoleColor.Red;
                        break;
                        case 'B':
                        case 'b':
                        newForeColor = ConsoleColor.Black;
                        break;
                    }
                    Char backColorSelection = GetKeyPress("                     Select Background Color (W for White, Y for Yellow, M for Magenta): ",
                    new Char[] { 'W', 'Y', 'M' });
                    switch (backColorSelection) {
                        case 'W':
                        case 'w':
                        newBackColor = ConsoleColor.White;
                        break;
                        case 'Y':
                        case 'y':
                        newBackColor = ConsoleColor.Yellow;
                        break;
                        case 'M':
                        case 'm':
                        newBackColor = ConsoleColor.Magenta;
                        break;

                    }
                }
                Console.Clear();

                for(int i=0;i<15;i++) Console.WriteLine();
                Console.Write("                         ");

                Console.ForegroundColor = newForeColor;
                Console.BackgroundColor = newBackColor;

                Console.Write("Select Full Name: ");
                Name = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine(Name);
                Console.Clear();
            }

            
            /*in hien thi mau*/
            private Char GetKeyPress(String msg, Char[] validChars)
            {
                ConsoleKeyInfo keyPressed;
                bool valid = false;

                Console.WriteLine();
                do {
                    Console.Write(msg);
                    keyPressed = Console.ReadKey();
                    Console.WriteLine();
                    if (Array.Exists(validChars, ch => ch.Equals(Char.ToUpper(keyPressed.KeyChar))))
                        valid = true;
                } while (! valid);
                return keyPressed.KeyChar;
            }        
        }
    }
}