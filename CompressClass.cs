using System;
using System.Collections.Generic;

public class CompressClass
{
    public string Compress(string s)
    {
        if (string.IsNullOrEmpty(s))
            return s;

        int count = 1;
        char c = s[0];
        string result = "";
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == c)
                count++;
            else
            {
                result += string.Format("{0}{1}", count > 1 ? count.ToString() : "", c);
                count = 1;
                c = s[i];
            }
        }

        result += string.Format("{0}{1}", count > 1 ? count.ToString() : "", c);
        return result;
    }
}
