using System;
using System.Text.RegularExpressions;

namespace Spoleto.BookApi.Interfaces.Helpers
{
    internal class TypeHelper
    {
        private static readonly Regex _subtractFullNameRegex = new Regex(@", Version=\d+.\d+.\d+.\d+, Culture=\w+, PublicKeyToken=\w+", RegexOptions.Compiled);

        /// <summary>
        /// Builds the type name for serialization.
        /// </summary>
        public static string BuildTypeName(Type type)
        {
            var full = type.AssemblyQualifiedName;

            var shortened = _subtractFullNameRegex.Replace(full, String.Empty);
            if (Type.GetType(shortened, false) == null)
            {
                // if type cannot be found with shortened name - use full name
                shortened = full;
            }

            return shortened;
        }
    }
}
