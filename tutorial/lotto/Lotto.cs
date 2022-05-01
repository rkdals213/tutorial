using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace tutorial.lotto;

public class Lotto
{
    private List<LottoLine> _lottoLines;

    public ImmutableList<LottoLine> LottoLines => _lottoLines.ToImmutableList();

    private Lotto(List<LottoLine> lottoLines)
    {
        _lottoLines = lottoLines;
    }

    public static Lotto Of(int size)
    {
        return new Lotto(GererateLottoLine(size));
    }

    private static List<LottoLine> GererateLottoLine(int size)
    {
        List<LottoLine> lottoLines = new List<LottoLine>();
        Random random = new Random();
        
        for (int i = 0; i < size; i++)
        {
            List<LottoNum> lottoNumber = GenerateLottoNumber(random);
            lottoLines.Add(LottoLine.Of(lottoNumber));
        }

        return lottoLines;
    }

    private static List<LottoNum> GenerateLottoNumber(Random random)
    {
        List<LottoNum> lottoNumbers = new List<LottoNum>();

        for (int i = 0; i < 6; i++)
        {
            lottoNumbers.Add(LottoNum.Of(random.Next(1, 46)));
        }

        return lottoNumbers;
    }
}