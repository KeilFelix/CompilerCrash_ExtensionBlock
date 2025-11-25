using System.Numerics;

namespace CompilerCrash_ExtensionBlock.Grid;

public static class EnumEx
{
    public static IEnumerable<T> GetSetFlags<T>(this T flags) where T : struct, Enum
    {
        foreach (T value in Enum.GetValues<T>())
            if (flags.HasFlag(value))
                yield return value;
    }

    public static int HighestSetBit<TEnum>(TEnum value) where TEnum : Enum
    {
        ulong v = Convert.ToUInt64(value);
        if (v == 0UL) return -1;
        return BitOperations.Log2(v);
    }
}
