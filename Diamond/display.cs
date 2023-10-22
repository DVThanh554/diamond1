
namespace Dia
{
    partial class Program
    {
        class Display_C
        {
            /*in ra man hinh*/
            public void Display_F()
            {
                var _Data = new Data_C();

                if(HightScore<Score){
                    HightScore=Score;
                    HightName=Name;
                }
                Time-=1;
                _Data.Data_F();
                // DisplayBroad[3076]="║";

                Display.Clear();                          // lam moi man hinh
                DisplayBroad.ForEach(Item => Display.Append(Item));                // gan kim cuong
                Display.Append($"║    Name: {Name}        Lever: {Lever}    Target: {Target}      Score: {Score}       Time: {Time}         Hight Score: {HightName}-{HightScore}                "+ (Char)10);         // in infor
                Display.Append("║                                                                                                               ║" + (Char)10);
                Display.Append("║                                                                                                               ║" + (Char)10);
                Display.Append("╚═══════════════════════════════════════════════════════════════════════════════════════════════════════════════╝" + (Char)10);


                Display.Append(System.Environment.NewLine);           // tra ve chuoi moi cho dong, ngat dong tro ve dau

                Console.SetCursorPosition(0, 0);
                
                Console.Write(Display);
                // Thread.Sleep(1000);
            }
        }
    }
}