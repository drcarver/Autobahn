//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAddressTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefAddressType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAddressType"> List
         /// </summary>
        public static List<RefAddressType> RefAddressTypeList = new List<RefAddressType>
        {
            new RefAddressType { Id=Guid.Parse("033a4097-d056-4767-95ef-5fa51b35c467"), Code="000010", Description="Address Type for Learner or Family", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefAddressType { Id=Guid.Parse("2abf15db-377f-4744-94f4-b29ac85f5b99"), Code="000722", Description="Address Type for Staff", Definition="", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The RefAddressType Pick List
         /// </summary>
        public static List<RefAddressType> RefAddressTypePickList = new List<RefAddressType>
        {
            new RefAddressType { Id=Guid.Parse("033a4097-d056-4767-95ef-5fa51b35c467"), Code="000010", Description="Address Type for Learner or Family", SortOrder=Convert.ToDecimal("") },
            new RefAddressType { Id=Guid.Parse("2abf15db-377f-4744-94f4-b29ac85f5b99"), Code="000722", Description="Address Type for Staff", SortOrder=Convert.ToDecimal("") },
       };
   }
}
