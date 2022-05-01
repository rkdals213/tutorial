using System;

namespace tutorial.lotto;

public class LottoNum
{
    private static int LOTTO_NUMBER_MIN = 1;
    private static int LOTTO_NUMBER_MAX = 46;
    private int _number;

    private int Number => _number;

    private LottoNum(int number)
    {
        _number = number;
    }

    public static LottoNum Of(int number)
    {
        if (LottoNumberOutOfRange(number))
        {
            throw new ArgumentException();
        }

        return new LottoNum(number);
    }

    private static bool LottoNumberOutOfRange(int number)
    {
        return number < LOTTO_NUMBER_MIN || number > LOTTO_NUMBER_MAX;
    }

    public override string ToString()
    {
        return _number.ToString();
    }
}