using System.Collections.Frozen;

namespace Lib;

public class WordBreaker
{
    private readonly FrozenSet<string> _wordList;

    public WordBreaker(IEnumerable<string> words)
    {
        _wordList = words.ToFrozenSet(StringComparer.InvariantCulture);
    }

    public string Break(string input)
    {
        if(_wordList.Contains(input))
            return input;

        for (var i = 1; i < input.Length; i++)
        {
            var prefix = input[..i];
            if (!_wordList.Contains(prefix)) 
                continue;
            
            var suffix = input[i..];
            if (!_wordList.Contains(suffix))
                continue;

            return $"{prefix} {suffix}";
        }

        return string.Empty;
    }
}