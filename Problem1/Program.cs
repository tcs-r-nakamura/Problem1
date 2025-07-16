using System;

class Program1
{
  /// <summary>
  /// Mainメソッド
  /// </summary>
    static void Main()
    {
        const int startNumber = 1;
        const int endNumber = 100;
        showPrimeNumber(startNumber,endNumber);
    }
    /// <summary>
    /// 素数表示メソッド
    /// </summary>
    /// <param name="startNumber">開始番号</param>
    /// <param name="endNumber">終了番号</param>
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

    /// <summary>
    /// 素数判定メソッド
    /// </summary>
    /// <param name="number">１～１００の数字</param>
    /// <returns>素数</returns>
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
