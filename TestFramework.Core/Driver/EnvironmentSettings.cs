namespace TestFramework.Core.Driver
{
    public static class EnvironmentSettings
    {
        private static string _currentBrowser;

        public static string CurrentBrowser
        {
            get
            {
                return _currentBrowser;
            }
            set
            {
                if (_currentBrowser == null)
                {
                    _currentBrowser = value;
                }
            }
        }
    }
}
