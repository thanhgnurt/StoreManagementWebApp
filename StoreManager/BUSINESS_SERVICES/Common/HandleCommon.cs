namespace StoreManager.BUSINESS_SERVICES.Common
{
    using System;

    /// <summary>
    /// Defines the <see cref="HandleCommon" />.
    /// </summary>
    public class HandleCommon 
    {
        /// <summary>
        /// Defines the CodeHead.
        /// </summary>
        protected string CodeHead;

        /// <summary>
        /// Defines the dayBase.
        /// </summary>
        protected static DateTime dayBase = DateTime.Now;

        /// <summary>
        /// The ConcatString.
        /// </summary>
        /// <param name="listString">The listString<see cref="string[]"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        protected string ConcatString(params string[] listString)
        {
            string resultString = "";
            foreach (string item in listString)
            {
                resultString += item;
            }
            return resultString;
        }

        /// <summary>
        /// The ConcatNum.
        /// </summary> Add stretching chain example 1=001
        /// <param name="num">The num<see cref="string"/>.</param>
        /// <param name="len">The len<see cref="int"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>

        /// <summary>
        /// The CutString.
        /// </summary>
        /// <param name="input">The input<see cref="string"/>.</param>
        /// <param name="indexStart">The indexStart<see cref="int"/>.</param>
        /// <param name="indexEnd">The indexEnd<see cref="int"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        protected string CutString(string input, int indexStart, int indexEnd)
        {
            string output = "";
            for (int i = indexStart; i <= indexEnd; i++)
            {
                output += input[i];
            }
            return output;
        }
    }
}
