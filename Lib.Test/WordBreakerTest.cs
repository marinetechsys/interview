namespace Lib.Test;

[TestClass]
public class WordBreakerTest
{
    private WordBreaker _breaker;

    [TestInitialize]
    public void Init()
    {
        List<string> wordList =  [
            "apple", "pie", 
            "the", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog"
        ];
    
        _breaker = new WordBreaker(wordList);
    }
    
    [TestMethod]
    public void PieApple()
    {
        const string input = "pieapple";

        var result = _breaker.Break(input);

        Assert.AreEqual(result, "pie apple");
    }
    
    [TestMethod]
    public void Pineapple()
    {
        const string input = "pineapple";

        var result = _breaker.Break(input);

        Assert.AreEqual(result, "pineapple");
    }    
    
    [TestMethod]
    public void QuickBrownFox()
    {
        const string input = "thequickbrownfoxjumpsoverthelazydog";

        var result = _breaker.Break(input);

        Assert.AreEqual(result, "the quick brown fox jumps over the lazy dog");
    }
}