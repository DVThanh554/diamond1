
namespace Dia
{
    partial class Program
    {
        class Eat_C
        {
/* doi vi tri kim cuong va an diem*/            
            public void Eat_F( Diamond[,] _Diamonds )
            {
                
                if (Choese1&&Choese)
                {
                    Diamond D=new Diamond();
                    D=_Diamonds[SaveI,SaveJ];
                    _Diamonds[SaveI,SaveJ]= _Diamonds[SaveI1,SaveJ1];
                    _Diamonds[SaveI1,SaveJ1]= D;

                    if(!CheckSame(_Diamonds))
                    {
                        _Diamonds[SaveI1,SaveJ1]= _Diamonds[SaveI,SaveJ];
                        _Diamonds[SaveI,SaveJ]= D;
                    }
                    DisplayBroad[480+228*SaveI+7*SaveJ] =_Diamonds[SaveI,SaveJ].DiamondValues;
                    DisplayBroad[480+228*SaveI1+7*SaveJ1] =_Diamonds[SaveI1,SaveJ1].DiamondValues;
                    DisplayBroad[482+SaveI1*228+SaveJ1*7]=" ";

                }
                SameEat(_Diamonds);
                Change(_Diamonds);
                Thread.Sleep(1000);
            }

/*an diem va doi hinh dang*/
            void Change(Diamond[,] _Diamonds)
            {
                for(int i=0;i<Count;i++)
                {
                    for(int j=0;j<Count;j++)
                    {
                        if (_Diamonds[i,j].Eat)                
                        {
                            _Diamonds[i,j].Random_Value = _Diamonds[i,j].Random.Next(Lever+4);
                            Body_C.Body_F(_Diamonds[i,j]);
                            DisplayBroad[480+228*i+7*j] =_Diamonds[i,j].DiamondValues;
                            _Diamonds[i,j].Eat = false;
                            Target+=10;
                            Score+=10;
                            Console.Beep(2000,50);
                            Console.Beep(2000,50);

                        }
                    }
                }

            }


/*danh dau an diem*/
            void SameEat(Diamond[,] _Diamonds)
            {
                for(int i=0;i<Count-2;i++)
                {
                    for(int j=0;j<Count;j++){
                        if(_Diamonds[i,j].DiamondValues==_Diamonds[i+1,j].DiamondValues&& _Diamonds[i,j].DiamondValues==_Diamonds[i+2,j].DiamondValues)
                        {
                            int k=i+3;
                            _Diamonds[i,j].Eat=true;
                            _Diamonds[i+1,j].Eat=true;
                            _Diamonds[i+2,j].Eat=true;
                            Check(_Diamonds,i,j,k);
                        }
                    }
                }
                for(int i=0;i<Count;i++)
                {
                    for(int j=0;j<Count-2;j++)
                    {
                        if(_Diamonds[i,j].DiamondValues==_Diamonds[i,j+1].DiamondValues&& _Diamonds[i,j].DiamondValues==_Diamonds[i,j+2].DiamondValues)
                        {
                            int k=j+3;
                            _Diamonds[i,j].Eat=true;
                            _Diamonds[i,j+1].Eat=true;
                            _Diamonds[i,j+2].Eat=true;
                            Check(_Diamonds,j,i,k);
                        }
                    }

                }
            }

/*kiem tra giong nhau*/
            void Check(Diamond[,] _Diamonds ,int i, int j, int k)
            {
                while(k<Count){
                    if(_Diamonds[i,j].DiamondValues==_Diamonds[k,j].DiamondValues){
                        _Diamonds[k,j].Eat=true;
                        k++;
                    }else break;
                }
            }

            bool CheckSame(Diamond[,] _Diamonds)
            {
                for(int i=0;i<Count-2;i++)
                {
                    for(int j=0;j<Count;j++){
                        if(_Diamonds[i,j].DiamondValues==_Diamonds[i+1,j].DiamondValues&& _Diamonds[i,j].DiamondValues==_Diamonds[i+2,j].DiamondValues)
                        {
                            return true;
                        }
                    }
                }
                for(int i=0;i<Count;i++)
                {
                    for(int j=0;j<Count-2;j++)
                    {
                        if(_Diamonds[i,j].DiamondValues==_Diamonds[i,j+1].DiamondValues&& _Diamonds[i,j].DiamondValues==_Diamonds[i,j+2].DiamondValues)
                        {
                             return true;
                        }
                    }
                }
                return false;
            }
        }
    }
}