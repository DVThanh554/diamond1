
namespace Dia
{
    partial class Program
    {
        static void Main()
        {
            Diamond[,] _Diamonds=new Diamond[Count,Count];
            var Menu =new Menu_C();
            var RunGame=new RunGame_C();
            var NewGame=new NewGame_C();
            for(int i =0;i <Count; i++)
            {
                for(int j =0;j <Count; j++)
                {
                    _Diamonds[i,j]=new Diamond();
                }
            }

            Menu.Menu_F();
            NewGame.NewGame_F(_Diamonds);
            RunGame.RunGame_F(_Diamonds);
        }
    }
}