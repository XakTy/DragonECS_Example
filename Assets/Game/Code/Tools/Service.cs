namespace Game.Scripts.Tools
{
    public static class Service<T>
    {
        private static T _instance;

        public static T Get()
        {
            return _instance;
        }
        public static void Set(T instance)
        {
            _instance = instance;
        }
    }
}