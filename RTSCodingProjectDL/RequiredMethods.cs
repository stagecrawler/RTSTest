using System.Net.Http.Headers;

namespace RTSCodingProjectDL
{
    public static class RequiredMethods
    {
        /// <summary>
        /// Get's all the numbers above and below the comparison value, does not include the comparison value
        /// </summary>
        /// <param name="numbersToCheck">List of numbers to check</param>
        /// <param name="comparisonValue">The number to check against</param>
        /// <returns>Returns a <see cref="AboveBelowResponse"/> which contains the count of numbers both above and below comparison</returns>
        public static AboveBelowResponse AboveBelow(List<int> numbersToCheck, int comparisonValue)
        {
            AboveBelowResponse retval = new AboveBelowResponse();
            retval.BelowCount = numbersToCheck.Count(x => x < comparisonValue);
            retval.AboveCount = numbersToCheck.Count(x => x > comparisonValue);
            return retval;
        }

        /// <summary>
        /// Takes a string and a shift value and shifts the characters of the string to the right by the shift value.
        /// Places the overflow back at the beginning of the string. 
        /// </summary>
        /// <param name="originalString">String to shift to the right</param>
        /// <param name="shifter">The amount to shift the string to the right.</param>
        /// <returns>The shifted string</returns>
        public static string StringRotation(string originalString, int shifter)
        {
            string overFlow = originalString.Substring(originalString.Length - shifter);
            return overFlow + originalString.Substring(0, originalString.Length - shifter);
        }
    }
}