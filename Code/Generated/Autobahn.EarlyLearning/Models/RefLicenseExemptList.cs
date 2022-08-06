//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefLicenseExemptList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefLicenseExempt Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLicenseExempt"> List
         /// </summary>
        public static List<RefLicenseExempt> RefLicenseExemptList = new List<RefLicenseExempt> =
        {
            new RefLicenseExempt { Id=Guid.Parse("0ba2c0d3-04a9-4990-86f7-765630d53a8c"), Code="", Description="Yes", Definition="", SortOrder=0 },
            new RefLicenseExempt { Id=Guid.Parse("e3c9a736-eb49-43e3-8559-cd04706e976d"), Code="", Description="No", Definition="", SortOrder=0 },
            new RefLicenseExempt { Id=Guid.Parse("8dc40d08-1b11-4c39-8828-1def0dba516e"), Code="", Description="NA", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefLicenseExempt Pick List
         /// </summary>
        public static List<RefLicenseExempt> RefLicenseExemptPickList = new List<RefLicenseExempt> =
        {
            new RefLicenseExempt { Id=Guid.Parse("0ba2c0d3-04a9-4990-86f7-765630d53a8c"), Code="", SortOrder=0 },
            new RefLicenseExempt { Id=Guid.Parse("e3c9a736-eb49-43e3-8559-cd04706e976d"), Code="", SortOrder=0 },
            new RefLicenseExempt { Id=Guid.Parse("8dc40d08-1b11-4c39-8828-1def0dba516e"), Code="", SortOrder=0 },
       };
   }
}
