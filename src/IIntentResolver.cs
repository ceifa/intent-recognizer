using System.Collections.Generic;

namespace IntentRecognizer
{
    public interface IIntentResolver
    {
        bool TryGetIntent(string input, IEnumerable<Intent> possibleIntents, out Intent intent);
    }
}