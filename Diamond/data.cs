using System.Text;                                                           //su dung stringbuilder khac string o cho khi mo rong hay xoa thi la 1 instance

namespace Dia
{
    partial class Program
    {
        class Data_C {
            /* luu diem va ten nguoi choi diem cao*/
            public void Data_F()
            {
                FileStream F =new FileStream("Diamond.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite);

                byte[] Hight_Byte=new byte[4]; 
                F.Read(Hight_Byte,0,4);  //0 la so thu tu bat dau; 4 la so byte cua kieu du lieu chuyen doi
                var GetScore=BitConverter.ToInt32(Hight_Byte,0);

                byte[] Name_Length=new byte[4]; 
                F.Read(Name_Length,0,4);
                int Length =BitConverter.ToInt32(Name_Length,0);

                var Name_Byte=new byte[Length];
                F.Read(Name_Byte,0,Length);
                var GetName=Encoding.UTF8.GetString(Name_Byte);

                if(HightScore > GetScore )
                {

                    byte[] Age_Byte=BitConverter.GetBytes(HightScore); 
                    F.Write(Age_Byte,0,4);

                    var Name_By=Encoding.UTF8.GetBytes(Name);           
                    var Name_leng=BitConverter.GetBytes(Name_By.Length);
                    F.Write(Name_leng,0,4);
                    F.Write(Name_By,0,Name_By.Length);  
                }else 
                {
                    HightScore=GetScore;
                    HightName=GetName;
                }


                F.Close();
            }
        }
    }
}
