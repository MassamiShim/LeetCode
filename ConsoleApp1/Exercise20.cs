namespace ConsoleApp1;

//Should be using stack for the validation
public class Exercise20
{
    public bool IsValid(string s)
    {
        char[] open = ['(', '[', '{'];
        char[] text = s.ToCharArray();
        char[] close = [')', ']', '}'];

        if (s.Length % 2 != 0) return false;
        if (open.Contains(s.Last())) return false;

        Dictionary<char, int> duplas = new Dictionary<char, int>();

        foreach (char c in open)
        {
            duplas.Add(c, 0);
        }

        foreach (char c in close)
        {
            duplas.Add(c, 0);
        }

        foreach (char c in text)
        {
            if (duplas.ContainsKey(c))
                duplas[c] = duplas[c] + 1;
            else
                duplas.Add(c, 1);
        }

        if (duplas['('] != duplas[')'])
            return false;

        if (duplas['['] != duplas[']'])
            return false;

        if (duplas['{'] != duplas['}'])
            return false;

        // List<char> textCopy = s.ToCharArray();
        string textCopy = s;
        int i = 0;

        while (textCopy.Length != 0)
        {
            if (open.Contains(textCopy[i]) && close.Contains(textCopy[i + 1]))
            {
                if (textCopy[i] == '(' && textCopy[i + 1] == ')'
                || textCopy[i] == '[' && textCopy[i + 1] == ']'
                || textCopy[i] == '{' && textCopy[i + 1] == '}')
                {
                    textCopy = textCopy.Remove(i, 2);
                    if (i > 0) i--;
                }
                else
                    return false;
            }
            else
            {
                i++;
            }
        }
        return true;
    }

    public bool Run(string s)
    {
        return IsValid(s);
    }
}