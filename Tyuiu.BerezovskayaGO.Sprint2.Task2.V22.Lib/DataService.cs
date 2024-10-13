using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.BerezovskayaGO.Sprint2.Task2.V22.Lib
{
    public class DataService : ISprint2Task2V22
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool a = true;
            if ((x>=3)&&(x<=13)&&(y>=3)&&(y<=14))
            {
                if ((x>5)&&(x<9)&&(y>=3)&&(y<=4))
                {
                    return a = false;
                }
                if ((x==13)&&(y>=3)&&(y<=5))
                {
                    return a = false;
                }
                if ((x==3)&&(y>=8)&&(y<=10))
                {
                    return a = false;
                }
                if ((x==6)&&(y>=12)&&(y<=13))
                {
                    return a = false;
                }
                if ((x>=7)&&(x<=8)&&(y>=8)&&(y<=13))
                {
                    return a = false;
                }
                if ((x>=9)&&(x<=10)&&(y>=10)&&(y<=13))
                {  
                    return a = false; 
                }
                if ((x==11)&&(y>=8)&&(y<=14))
                {
                    return a = false;
                }
                if ((x==12)&&(y>=12)&&(y<=14))
                {
                    return a = false;
                }
                if ((x==13)&&(y>=9)&&(y<=14))
                {
                    return a = false;
                }
                if ((x>=3)&&(x<=4)&&(y>=12)&&(y<=13))
                {
                    return a = false;
                }
                if ((x==3)&&(y==14))
                {
                    return a = false;
                }

                return a;
            }
            else
            {
                return false;
            }
        }
    }
}
