namespace StoreManager
{
    /// <summary>
    /// Defines the <see cref="ExString" />.
    /// </summary>
    public static class ExString
    {
        /// <summary>
        /// Add 0 into header 
        /// </summary>
        /// <param name="num">The num<see cref="string"/>.</param>
        /// <param name="len">The len<see cref="int"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string ConCatNumber0(this string num, int len)
        {
            if (num.Length <= len)
            {
                for (int i = num.Length; i < len; i++)
                {
                    num = "0" + num;
                }
            }
            return num;
        }
    }
}
