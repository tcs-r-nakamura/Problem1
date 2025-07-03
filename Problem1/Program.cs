using System;

class Program1
{
    static void Main(string[] args)
    {
        //2～100までループさせる
        for (int number = 2; number <= 100; number++)
        {//素数だったらture
            bool answer = true;
            //2～numberまでループ
            for (int i = 2; i < number; i++)
            {//割り切れたら素数じゃない
                if (number % i == 0)
                {
                    answer = false;
                    break;

                }
            }//もし素数だったら
            if (answer)
            {//素数を表示
                Console.WriteLine(number);
            }
        }
    }
}