using DataLayer.Core.Model;

namespace ITSpecialProject.Monostate
{
    public static class AccountSession
    {
        private static Account _account;

        public static void SetAccount(Account account) => _account = account;

        public static Account GetAccount => _account;

        /*private static readonly object InstanceLock = new object();
        private static volatile Account _instance = null;

        public static Account Instance()
        {
            if (_instance == null)
            {
                lock (InstanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Account();
                    }
                }
            }

            return _instance;
        }

        public static Account Get => _instance;*/
    }
}
