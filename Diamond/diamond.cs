using System.Text;                                                       

namespace Dia
{
    partial class Program
    {
        enum Directions { None, Up, Down, Left, Right, Spacebar,Again }                  // di chuyen
        private static int Direction { get; set; }                                      // lay di chuyen
        private static int Lever{ get; set; }                                           // lay lever        
        private static int Position { get; set; }                                      // lay vi tri chon kim cuong
        private static int Position1 { get; set; }                                     // lay vi tri chon kim cuong1
        private static bool Dire { get; set; }                                         // luu kieu di chuyen hoac chon
        private static bool Dire1 { get; set; }                                        // luu kieu di chuyen hoac chon
        private static int SaveI { get; set; }                                        // vien kien cuong duoc chon
        private static int SaveJ { get; set; }                                        
        private static int SaveI1 { get; set; }                                       // vien kien cuong duoc chon 1
        private static int SaveJ1 { get; set; }          
        private static bool Choese { get; set; }                                      // danh dau chon 
        private static bool Choese1 { get; set; }                                     // danh dau chon 1
        private static int Time { get; set; }                                        // thoi gian choi
        private static int Count{ get; set; } =10;                                   // so hang kim cuong
        private static bool UnMusic {get;set;}                                       // on/of music
        private static string Name { get; set; }                                    // ten nguoi choi
        private static string HightName { get; set; }                                // ten nguoi choi co diem cao nhat

        private static int Target { get; set; }                                      // muc tieu moi lever
        private static int Score { get; set; }                                      // diem choi
        private static int HightScore { get; set; }                                  // diem choi cao nhat

        private static StringBuilder Broad { get; set; } =new StringBuilder();                    //chuoi the hien tro choi
        private static StringBuilder Display { get; set; } =new StringBuilder();                  // chuoi in ra
        private static List<string> DisplayBroad { get; set; } = new List<string>();               // danh sach chuoi de noi them vao
        



        /* tao mang kim cuong*/
        class Diamond                //do an
        {
            public string DiamondValues { get; set; }                              // hinh dang vien kim cuong
            public Random Random { get; set; } = new Random();                    // tu dong tao vien kim cuong
            public bool Eat = false;                                              // danh dau an
            public int Random_Value { get; set; }                                 // lay gia tri random
            public bool Change { get; set; } = false;                             //bien thay doi

        }
        
        class Body_C
        {
            public static void Body_F(Diamond _Diamond)           // cong dot
            {
                switch(_Diamond.Random_Value)
                {
                    case 0:
                       _Diamond.DiamondValues="$";
                        break;
                    case 1:
                       _Diamond.DiamondValues="O";
                        break;    
                    case 2:
                       _Diamond.DiamondValues="*";
                        break;
                    case 3:
                       _Diamond.DiamondValues="X";
                        break;
                    case 4:
                       _Diamond.DiamondValues="T";
                        break;
                    case 5:
                        _Diamond.DiamondValues="@";
                        break;
                    case 6:
                        _Diamond.DiamondValues="=";
                        break;
                    case 7:
                        _Diamond.DiamondValues="K";
                        break;
                    case 8:
                        _Diamond.DiamondValues="Z";
                        break;
                    case 9:
                        _Diamond.DiamondValues="A";
                        break;
                }
            }

        }


    }
}