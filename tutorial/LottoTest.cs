using System;
using System.Collections.Immutable;
using NUnit.Framework;
using tutorial.lotto;

namespace tutorial;

public class LottoTest
{
    [Test]
    public void Test1()
    {
        Lotto lotto = Lotto.Of(10);
        ImmutableList<LottoLine> lottoLottoLines = lotto.LottoLines;
        foreach (LottoLine lottoLottoLine in lottoLottoLines)
        {
            ImmutableList<LottoNum> lottoNums = lottoLottoLine.LottoNums;
            Console.WriteLine(String.Join(",", lottoNums));
        }
    }
}