namespace tutorial;

public class Foo1
{
    private int num;

    public int Num
    {
        get { return num; }
        set
        {
            if (value <= 100)
            {
                num = value;
            }
            else
            {
                num = 99;
            }
        }
    }
}