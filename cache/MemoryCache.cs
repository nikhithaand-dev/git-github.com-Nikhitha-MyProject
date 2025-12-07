namespace SpeechifyPractice.Cache
{
    public class MemoryCache
    {
        private Dictionary<string, string> _store = new();

        public void Set(string key, string value)
        {
            _store[key] = value;
        }

        public string? Get(string key)
        {
            _store.TryGetValue(key, out var val);
            return val;
        }
    }
}
