using System.Collections.Generic;
using System.Collections.Immutable;

namespace tutorial.lotto;

public class LottoLine
{
    private List<LottoNum> _lottoNums;

    public ImmutableList<LottoNum> LottoNums => _lottoNums.ToImmutableList();

    private LottoLine(List<LottoNum> lottoNums)
    {
        _lottoNums = lottoNums;
    }

    public static LottoLine Of(List<LottoNum> lottoNums)
    {
        return new LottoLine(lottoNums);
    }
}