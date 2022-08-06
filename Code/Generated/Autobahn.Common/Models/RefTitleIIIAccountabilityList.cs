//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefTitleIIIAccountabilityList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefTitleIIIAccountability Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefTitleIIIAccountability"> List
         /// </summary>
        public static List<RefTitleIIIAccountability> RefTitleIIIAccountabilityList = new List<RefTitleIIIAccountability> =
        {
            new RefTitleIIIAccountability { Id=Guid.Parse("bca5ccd5-914f-4ca1-9c3e-deecd0832adf"), Code="The student is making progress toward English proficiency.", Description="PROGRESS", Definition="", SortOrder=0 },
            new RefTitleIIIAccountability { Id=Guid.Parse("344f490f-b537-47e7-a806-ca67793008f8"), Code="The student did not make progress toward English proficiency.", Description="NOPROGRESS", Definition="", SortOrder=0 },
            new RefTitleIIIAccountability { Id=Guid.Parse("57fc34a2-7551-4b17-944a-2c29d1c6b37c"), Code="The student attained English proficiency.", Description="PROFICIENT", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefTitleIIIAccountability Pick List
         /// </summary>
        public static List<RefTitleIIIAccountability> RefTitleIIIAccountabilityPickList = new List<RefTitleIIIAccountability> =
        {
            new RefTitleIIIAccountability { Id=Guid.Parse("bca5ccd5-914f-4ca1-9c3e-deecd0832adf"), Code="The student is making progress toward English proficiency.", SortOrder=0 },
            new RefTitleIIIAccountability { Id=Guid.Parse("344f490f-b537-47e7-a806-ca67793008f8"), Code="The student did not make progress toward English proficiency.", SortOrder=0 },
            new RefTitleIIIAccountability { Id=Guid.Parse("57fc34a2-7551-4b17-944a-2c29d1c6b37c"), Code="The student attained English proficiency.", SortOrder=0 },
       };
   }
}
