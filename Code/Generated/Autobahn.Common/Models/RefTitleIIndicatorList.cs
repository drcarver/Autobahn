//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefTitleIIndicatorList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefTitleIIndicator Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefTitleIIndicator"> List
         /// </summary>
        public static List<RefTitleIIndicator> RefTitleIIndicatorList = new List<RefTitleIIndicator>
        {
            new RefTitleIIndicator { Id=Guid.Parse("3bdc4906-545d-487d-8cc9-ab92379879ed"), Code="01", Description="Public Targeted Assistance Program", Definition="Public Targeted Assistance Program", SortOrder=Convert.ToDecimal("1.00") },
            new RefTitleIIndicator { Id=Guid.Parse("81ba8223-1cd9-4dd6-9f83-e4adc9ac32de"), Code="02", Description="Public Schoolwide Program", Definition="Public Schoolwide Program", SortOrder=Convert.ToDecimal("2.00") },
            new RefTitleIIndicator { Id=Guid.Parse("bef9e3ae-e83d-4807-8169-3b7580ffffe7"), Code="03", Description="Private school students participating", Definition="Private school students participating", SortOrder=Convert.ToDecimal("3.00") },
            new RefTitleIIndicator { Id=Guid.Parse("9b9fd6b4-bad6-49b0-8ad3-90abc7897436"), Code="04", Description="Local Neglected Program", Definition="Local Neglected Program", SortOrder=Convert.ToDecimal("4.00") },
            new RefTitleIIndicator { Id=Guid.Parse("32c7249e-4c9a-426a-bcb4-618515e11d9c"), Code="05", Description="Was not served", Definition="Was not served", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefTitleIIndicator Pick List
         /// </summary>
        public static List<RefTitleIIndicator> RefTitleIIndicatorPickList = new List<RefTitleIIndicator>
        {
            new RefTitleIIndicator { Id=Guid.Parse("3bdc4906-545d-487d-8cc9-ab92379879ed"), Code="01", Description="Public Targeted Assistance Program", SortOrder=Convert.ToDecimal("1.00") },
            new RefTitleIIndicator { Id=Guid.Parse("81ba8223-1cd9-4dd6-9f83-e4adc9ac32de"), Code="02", Description="Public Schoolwide Program", SortOrder=Convert.ToDecimal("2.00") },
            new RefTitleIIndicator { Id=Guid.Parse("bef9e3ae-e83d-4807-8169-3b7580ffffe7"), Code="03", Description="Private school students participating", SortOrder=Convert.ToDecimal("3.00") },
            new RefTitleIIndicator { Id=Guid.Parse("9b9fd6b4-bad6-49b0-8ad3-90abc7897436"), Code="04", Description="Local Neglected Program", SortOrder=Convert.ToDecimal("4.00") },
            new RefTitleIIndicator { Id=Guid.Parse("32c7249e-4c9a-426a-bcb4-618515e11d9c"), Code="05", Description="Was not served", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
