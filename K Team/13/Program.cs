using System;

namespace ThirteenthProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            #region VD1
            
            // int a = 1;
            // switch (a)
            // {
            //     case 1: // label case 1
            //         Console.WriteLine("Case 1");
            //         break;
            //     case 2: // label case 2
            //         Console.WriteLine("Case 2");
            //         goto case 1; // dịch chuyển tới label case 1
            //         break; // Đoạn code này thừa vì sẽ không bao giờ thực thi
            //     case 3: // label case 3
            //         Console.WriteLine("Case 3");
            //         break;
            // }

            #endregion
            
            #region VD2

            // int a = 2;
            // switch(a)
            // {
            //     case 1:             // label case 1
            //         Console.WriteLine("Case 1");
            //         break;
            //     case 2:             // label case 2
            //         Console.WriteLine("Case 2");
            //         goto case 1;    // dịch chuyển tới label case 1
            //         break;          // Đoạn code này thừa vì sẽ không bao giờ thực thi
            //     case 3:             // label case 3
            //         Console.WriteLine("Case 3");
            //         break;
            // }

            #endregion
            
            #region VD3

            // int a = 1;
            // // nếu a == 2
            // if (a == 2)
            // {
            //     // dịch chuyển tới vị trí label a_Is_2
            //     goto a_Is_2;
            // }
            //
            // Console.WriteLine("A == 1");
            // a_Is_2:
            // Console.WriteLine("A == 2");

            #endregion
            
            #region VD4

            // int a = 2;
            // // nếu a == 2
            // if (a == 2)
            // {
            //     // dịch chuyển tới vị trí label a_Is_2
            //     goto a_Is_2;
            // }
            //
            // Console.WriteLine("A == 1");
            // a_Is_2:
            // Console.WriteLine("A == 2");


            #endregion
            
            #region VD5

            // int a = 2;
            //
            // Ifinity_Loop:
            // // nếu a == 2
            // if (a == 2)
            // {
            //     // dịch chuyển tới vị trí label a_Is_2
            //     goto a_Is_2;
            // }
            //
            // Console.WriteLine("A == 1");
            // a_Is_2:
            // Console.WriteLine("A == 2");
            // goto Ifinity_Loop; // dịch chuyển tới vị trí label Ifinity_Loop

            #endregion

            #region VD6

            string howKteamstr = "HowKteam.com";
            int count = 0;
            
            beginLoop:

            Console.WriteLine(howKteamstr);
            count++;
            
            if(count < 10)
                goto beginLoop;

            Console.WriteLine("End loop");
            #endregion

            Console.ReadKey();
        }
    }
}