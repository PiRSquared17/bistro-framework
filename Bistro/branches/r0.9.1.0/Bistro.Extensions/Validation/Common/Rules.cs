﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bistro.Validation;
using System.Text.RegularExpressions;

namespace Bistro.Extensions.Validation.Common
{
    /// <summary>
    /// Builder extension methods for common rules
    /// </summary>
    public static class Rules
    {
        /// <summary>
        /// Marks the specified site as required
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="K"></typeparam>
        /// <param name="site">The site.</param>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        public static Validator<T> IsRequired<T, K>(this ValidationSite<T, K> site, string message) where T : IValidatable
        {
            site.AddValidation(new RequiredValidator<T>(message));

            return site;
        }

        /// <summary>
        /// Marks the specified site as having to match the given regular expression
        /// </summary>
        /// <param name="site">The site.</param>
        /// <param name="regex">The regex.</param>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        public static Validator<T> MatchesRegex<T, K>(this ValidationSite<T, K> site, string regex, string message) where T : IValidatable
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Marks the specified site as needing to have a string value shorter than maxLength
        /// </summary>
        /// <param name="site">The site.</param>
        /// <param name="maxLength">Length of the max.</param>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        public static Validator<T> IsShorterThan<T, K>(this ValidationSite<T, K> site, int maxLength, string message) where T : IValidatable
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Marks the specified site as needing to have a string value longer than minLength
        /// </summary>
        /// <param name="site">The site.</param>
        /// <param name="minLength">Length of the min.</param>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        public static Validator<T> IsLongerThan<T, K>(this ValidationSite<T, K> site, int minLength, string message) where T : IValidatable
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Marks the specified site as needing to have an integer value between min and max
        /// </summary>
        /// <param name="site">The site.</param>
        /// <param name="min">The min.</param>
        /// <param name="max">The max.</param>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        public static Validator<T> IsInRange<T, K>(this ValidationSite<T, K> site, int min, int max, string message) where T : IValidatable
        {
            throw new NotImplementedException();
        }
    }
}
