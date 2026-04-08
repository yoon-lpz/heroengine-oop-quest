using System;

namespace pp7_heroengine_oop_quest_yoon_lpz
{
    public class Tools
    {
        /// <summary>
        /// Validates if a string is neither null nor empty and meets the minimum length requirement.
        /// </summary>
        /// <param name="input">The string to be validated.</param>
        /// <returns>
        /// <see langword="true"/> if the string is not null or empty and has more than 3 characters; 
        /// otherwise, <see langword="false"/>.
        /// </returns>
        public static bool isValidString(string input) => !String.IsNullOrEmpty(input) && input.Trim().Length >= 3;

        /// <summary>
        /// Validates if a string is neither null nor empty and exceeds a specified minimum length.
        /// </summary>
        /// <param name="input">The string to be validated.</param>
        /// <param name="Length">The threshold length that the string must exceed.</param>
        /// <returns>
        /// <see langword="true"/> if the string is not null or empty and its length is greater than 
        /// the <paramref name="length"/> parameter; otherwise, <see langword="false"/>.
        /// </returns>
        public static bool isValidString(string input, int length) => !String.IsNullOrEmpty(input) && input.Trim().Length >= length;

        /// <summary>
        /// Validates if an integer is a natural number (greater than 0).
        /// </summary>
        /// <param name="number">The integer to be validated.</param>
        /// <returns>
        /// <see langword="true"/> if <paramref name="number"> is a natural number ; otherwise, <see langword="false"/>.
        /// </returns>
        public static bool isNaturalNumber(int number) => number > 0;

        // <summary>
        /// Validates if a string is a natural number (greater than 0).
        /// </summary>
        /// <param name="number">The string to be validated.</param>
        /// <returns>
        /// <see langword="true"/> if <paramref name="number"> is a natural number ; otherwise, <see langword="false"/>.
        /// </returns>
        public static bool isNaturalNumber(string number)
        {
            try
            {
                return int.Parse(number) > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
