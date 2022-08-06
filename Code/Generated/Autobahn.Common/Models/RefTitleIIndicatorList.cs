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
        public static List<RefTitleIIndicator> RefTitleIIndicatorList = new List<RefTitleIIndicator> =
        {
            new RefTitleIIndicator { Id=Guid.Parse("1d67db88-a811-4289-97f5-8c660ee54045"), Code="Public Targeted Assistance Program", Description="01", Definition="", SortOrder=0 },
            new RefTitleIIndicator { Id=Guid.Parse("84813158-ca5c-4671-8d40-20d6bb4070b2"), Code="Public Schoolwide Program", Description="02", Definition="", SortOrder=0 },
            new RefTitleIIndicator { Id=Guid.Parse("a1a35da7-d239-459f-94c3-0abaa8604065"), Code="Private school students participating", Description="03", Definition="", SortOrder=0 },
            new RefTitleIIndicator { Id=Guid.Parse("b5f31f4c-b884-4f1f-896a-a4f9e3f6f36e"), Code="Local Neglected Program", Description="04", Definition="", SortOrder=0 },
            new RefTitleIIndicator { Id=Guid.Parse("036756b3-b411-419a-aaf8-7c6c7f897a34"), Code="Was not served", Description="05", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefTitleIIndicator Pick List
         /// </summary>
        public static List<RefTitleIIndicator> RefTitleIIndicatorPickList = new List<RefTitleIIndicator> =
        {
            new RefTitleIIndicator { Id=Guid.Parse("1d67db88-a811-4289-97f5-8c660ee54045"), Code="Public Targeted Assistance Program", SortOrder=0 },
            new RefTitleIIndicator { Id=Guid.Parse("84813158-ca5c-4671-8d40-20d6bb4070b2"), Code="Public Schoolwide Program", SortOrder=0 },
            new RefTitleIIndicator { Id=Guid.Parse("a1a35da7-d239-459f-94c3-0abaa8604065"), Code="Private school students participating", SortOrder=0 },
            new RefTitleIIndicator { Id=Guid.Parse("b5f31f4c-b884-4f1f-896a-a4f9e3f6f36e"), Code="Local Neglected Program", SortOrder=0 },
            new RefTitleIIndicator { Id=Guid.Parse("036756b3-b411-419a-aaf8-7c6c7f897a34"), Code="Was not served", SortOrder=0 },
       };
   }
}
