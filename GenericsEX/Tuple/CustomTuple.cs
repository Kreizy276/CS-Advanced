using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple;

public class CustomTuple<T1, T2>
{
    private T1 _value1;
    private T2 _value2;

    public T1 Value1
    {
        get => this._value1;
        set => this._value1 = value;
    }
    public T2 Value2
    {
        get => this._value2;
        set => this._value2 = value;
    }

    public CustomTuple(T1 value1, T2 value2)
    {
        this._value1 = value1;
        this._value2 = value2;
    }

    public override string ToString()
    {
        return $"{Value1} -> {Value2}";
    }
}
