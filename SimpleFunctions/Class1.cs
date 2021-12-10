using System;
using System.Threading;

namespace SimpleFunctions
{
    public class Functions
    {
        public void Even()//Even Function 
        {
            int start = 1, end = 1000;

            for(int i=start;i<=end;i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + "\t");
                    Thread.Sleep(10);
                }
            }         
        }
       
        public void Pallindrome()//Pallindrome Function 
        {
            int start = 1, end = 1000, digit = 0, temp=0, reverse;

            for (int i = start; i <= end; i++)
            {
                temp = i;
                reverse = 0;

                while(temp!=0)
                {
                    digit = temp % 10;
                    reverse = reverse * 10 + digit;
                    temp = temp / 10;
                    
                }

                if(i==reverse)
                {
                    Console.Write(reverse+"*\t");
                    Thread.Sleep(10);
                }
            }
        }
    }
}
