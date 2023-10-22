
namespace Dia
{
    partial class Program
    {
        class Move_C             
        {
            /*nhan phim di chuyen con tro*/
            public void Move_F()
            {
                do
                {
                    var Key = Console.ReadKey().Key;  

                    switch (Key)                  
                    {
                        case ConsoleKey.UpArrow:
                            Direction = (int)Directions.Up;
                            Console.Beep(370, 500);
                            break;

                        case ConsoleKey.LeftArrow:
                            Direction = (int)Directions.Left;
                            Console.Beep(370, 500);
                            break;

                        case ConsoleKey.DownArrow:
                            Direction = (int)Directions.Down;
                            Console.Beep(370, 500);
                            break;

                        case ConsoleKey.RightArrow:
                            Direction = (int)Directions.Right;
                            Console.Beep(370, 500);
                            break;

                        case ConsoleKey.Spacebar :                       
                            Direction = (int)Directions.Spacebar;
                            Console.Beep(370, 500);
                            break;
                        
                        case ConsoleKey.Escape:                          
                            Console.Beep(800, 500);
                            Environment.Exit(-1);
                            break;
                        
                        case ConsoleKey.Q: 
                            Time=0;
                            break;

                        case ConsoleKey.M:       
                            Direction=(int)Directions.None;
                            if(UnMusic)
                            {
                                UnMusic=false;
                                Task.Factory.StartNew(() => Music_C.MusicBackground());
                                break;
                            } 
                            else if(!UnMusic) UnMusic=true;
                            break;
                        default :
                            Direction=(int)Directions.None;
                            break;

                    }

                    Posi();
                } while (Time>1);         

      
            }

            
            /*kiem tra chon*/
            private static void Dires()
            {
                if(Dire  || !Dire && Dire1 && !Choese1 || Choese1 )
                {
                    DisplayBroad[Position]=" ";
                    DisplayBroad[Position1]=" ";  
                    Dire=true; 
                    Choese=false;
                    Choese1=false;                                 
                }
                if(!Dire && Choese && !Dire1 && !Choese1 )
                {
                    Position1=Position;
                    Dire1=true;
                }
            }

            /*thuc hien di chuyen*/
            private void Posi()
            {

                switch ((Directions)Direction)
                {
                    case Directions.Left:
                        if(CheckLeft())
                        {
                            Move_C.Dires();
                            Position-=7;
                            DisplayBroad[Position]="<";
                            SaveI1=SaveI;
                            SaveJ1=SaveJ;
                            SaveJ--;
                        }
                        break;

                    case Directions.Right:
                        if(CheckRight())
                        {
                            Move_C.Dires();
                            Position+=7;
                            DisplayBroad[Position]=">";
                            SaveI1=SaveI;
                            SaveJ1=SaveJ;
                            SaveJ++;
                        }
                        break;

                    case Directions.Up:
                        if(CheckUp())
                        {
                            Move_C.Dires();
                            Position-=228;
                            DisplayBroad[Position]="^";
                            SaveI1=SaveI;
                            SaveJ1=SaveJ;
                            SaveI--;
                        }
                        
                        break;

                    case Directions.Down:
                        if(CheckDown())
                        {
                            Move_C.Dires();
                            Position+=228;
                            DisplayBroad[Position]="v";
                            SaveI1=SaveI;
                            SaveJ1=SaveJ;
                            SaveI++;
                        }
                        
                        break;
                    case Directions.Spacebar:
                        Dire=false;
                        
                        if(!Choese)
                        {
                            DisplayBroad[Position1]=" ";
                            DisplayBroad[Position]="+";
                            Choese=true;
                        }
                        if(Dire1 && !Choese1){
                            DisplayBroad[Position]="+";
                            Choese1=true;
                        }
                        if(Choese1) Dire1=false;
                        
                        break;
                    default :
                    break; 

                }
            }


            /*Kiem tra pham vi di chuyen*/
            private bool CheckRight()                      //vitri
            {
                if( Position ==2597   
                    || Position ==545                    
                    || Position ==773                    
                    || Position ==1001
                    || Position ==1229
                    || Position ==1457
                    || Position ==1685
                    || Position ==1913
                    || Position ==2141
                    || Position ==2369
                    ) return false;
                return true;
            }
            private bool CheckLeft()                      //vitri
            {
                if( Position==482
                    ||Position==710
                    ||Position==938
                    ||Position==1166
                    ||Position==1394
                    ||Position==1622
                    ||Position==1850
                    ||Position==2078
                    ||Position==2306
                    ||Position==2534
                    ) return false;
                return true;
            }

            private bool CheckUp()                      //vitri
            {
                if( Position<710) return false;
                return true;
            }

            private bool CheckDown()                      //vitri
            {
                if(Position >2369) return false;
                return true;
            }    
        }
    }
}