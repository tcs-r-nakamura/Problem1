using System;

class Program1
{
    static void Main(string[] args)
    {
        const int startNumber = 1;
        const int endNumber = 100;
        showPrimeNumber(startNumber,endNumber);
    }

private static void showPrimeNumber(int startNumber, int endNumber)
{
    //1～100までループさせる
    for (int number = startNumber; number <= endNumber; number++)
    {
        if (IsPrime(number))
        {

            Console.WriteLine(number);
        }
    }
}

    /*素数判別メソッド　
     * 戻り値に素数が入る*/
    private static bool IsPrime(int number)
    {
        if (number <= 1) return false;  // 1以下は素数じゃない
        if (number == 2) return true;   // 2は素数
        if (number % 2 == 0) return false; // 2以外の偶数は素数じゃない

        for (int i = 3; i * i <= number; i += 2) // 奇数だけチェック
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

}
