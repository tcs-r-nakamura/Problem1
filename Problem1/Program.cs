using System;

class Program1
{
    static void Main(string[] args)
    {
        const int startNumber = 1;
        const int endNumber = 100;
        showPrimeNumber(startNumber,endNumber);
    }

static void showPrimeNumber(int startNumber, int endNumber)
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
    static bool IsPrime(int number)
{//もしnumberが1だったらfalseを返す
    if (number == 1)
    {
        return false;
    }
    /*2～numberまでループ
     もっと処理を軽く改良*/
    for (int i = 2; i * i <= number; i ++)
    {
        //割り切れたらfalseを返す
        if (number % i == 0)
        {
            return false;
        }
    }//もし割り切れなかったらtrueを返す
    return true;

}
}
