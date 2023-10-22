
namespace Dia
{
    partial class Program
    {
        class NewGame_C
        {
            /*bat dau 1 lever game*/
            public void NewGame_F(Diamond[,] _Diamonds)
            {                
                var Broa =new Broad_C();
                var _Display=new Display_C();
                Console.CursorVisible = false;                    

                Console.Clear();
                DisplayBroad.Clear();
                Broad.Clear();
                Broa.Broad_F();
                Time=100 ;
                Target=0;
                Lever+=1;                                  

                DisplayBroad[482]=">";

                Console.Beep(500, 500);

                for(int i =0;i <Count; i++)
                {
                    for(int j =0;j <Count; j++)
                    {
                        _Diamonds[i,j].Random_Value  = _Diamonds[i,j].Random.Next(Lever+4);   
                        Body_C.Body_F(_Diamonds[i,j]);
                        DisplayBroad[480+i*228+j*7]=_Diamonds[i,j].DiamondValues;
                        _Diamonds[i,j].Eat=false;
                    }
                }
                _Display.Display_F();
            }
        }

    }
}