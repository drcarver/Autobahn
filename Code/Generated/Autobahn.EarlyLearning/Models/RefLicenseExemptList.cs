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
        public static List<RefLicenseExempt> RefLicenseExemptList = new List<RefLicenseExempt>
        {
            new RefLicenseExempt { Id=Guid.Parse("9c31150b-cead-40dc-9df2-84ef92449394"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new RefLicenseExempt { Id=Guid.Parse("38149f6a-1da8-469c-b928-4ccf3d0c454d"), Code="No", Description="No", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new RefLicenseExempt { Id=Guid.Parse("79893d18-d4fc-4e50-b581-c8b709203d4d"), Code="NA", Description="Not applicable", Definition="", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefLicenseExempt Pick List
         /// </summary>
        public static List<RefLicenseExempt> RefLicenseExemptPickList = new List<RefLicenseExempt>
        {
            new RefLicenseExempt { Id=Guid.Parse("9c31150b-cead-40dc-9df2-84ef92449394"), Code="Yes", Description="Yes", SortOrder=Convert.ToDecimal("1.00") },
            new RefLicenseExempt { Id=Guid.Parse("38149f6a-1da8-469c-b928-4ccf3d0c454d"), Code="No", Description="No", SortOrder=Convert.ToDecimal("2.00") },
            new RefLicenseExempt { Id=Guid.Parse("79893d18-d4fc-4e50-b581-c8b709203d4d"), Code="NA", Description="Not applicable", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
