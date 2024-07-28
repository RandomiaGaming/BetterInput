//Internals
public static partial class RawInputHelper
{
    private static readonly int PtrSize = GetPtrSize();
    private static int GetPtrSize()
    {
        if (System.Environment.Is64BitOperatingSystem)
        {
            return 8;
        }
        else
        {
            return 4;
        }
    }
    private static string InternalIndexToString(uint value, string[] names)
    {
        if (value >= names.Length)
        {
            return "Invalid";
        }
        else
        {
            return names[value];
        }
    }
    private static string InternalFlagsToString(uint flags, string[] names)
    {
        string output = "";
        bool setFlagAlready = false;

        int lengthMinusOne = names.Length - 1;

        for (int i = 0; i < lengthMinusOne; i++)
        {
            if ((flags & (1 << i)) != 0)
            {
                if (!setFlagAlready)
                {
                    output = names[i + 1];
                    setFlagAlready = true;
                }
                else
                {
                    output += " and " + names[i];
                }
            }
        }

        if (!setFlagAlready)
        {
            output = names[0];
        }

        return output;
    }
}