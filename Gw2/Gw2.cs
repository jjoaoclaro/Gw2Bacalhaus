using System;

namespace Gw2
{
    public class Gw2
    {
        private static string _ApiKey = "";

        public static string ApiKey
        {
            get
            {
                return _ApiKey;
            }
            set
            {
                _ApiKey = value;
            }
        }
    }
}
