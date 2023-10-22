
namespace Dia
{
    partial class Program
    {
        class RunGame_C
        {
            public void RunGame_F(Diamond[,] _Diamonds)
            {
                var _Move=new Move_C();
                var _Eat=new Eat_C();
                var _Display=new Display_C();
                var _NewGame=new NewGame_C();

                Task.Factory.StartNew(() => _Move.Move_F());


                while(Time>0)
                {
                    if( Target>=500 ) _NewGame.NewGame_F(_Diamonds);
                    
                    _Eat.Eat_F(_Diamonds);

                    _Display.Display_F();
                    
                }
                if(Time<=0) Main();
                
            }
        }
    }
}