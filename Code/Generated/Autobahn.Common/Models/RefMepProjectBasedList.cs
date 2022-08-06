//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefMepProjectBasedList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefMepProjectBased Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMepProjectBased"> List
         /// </summary>
        public static List<RefMepProjectBased> RefMepProjectBasedList = new List<RefMepProjectBased> =
        {
            new RefMepProjectBased { Id=Guid.Parse("9db030b3-dd4b-4652-85b9-bceade487bcb"), Code="School-based Migrant Education Program Project", Description="SchoolBased", Definition="", SortOrder=0 },
            new RefMepProjectBased { Id=Guid.Parse("f925f610-aec1-4fe5-915c-cffcd1bdcddb"), Code="Non-school-based Migrant Education Program project", Description="NonSchoolBased", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefMepProjectBased Pick List
         /// </summary>
        public static List<RefMepProjectBased> RefMepProjectBasedPickList = new List<RefMepProjectBased> =
        {
            new RefMepProjectBased { Id=Guid.Parse("9db030b3-dd4b-4652-85b9-bceade487bcb"), Code="School-based Migrant Education Program Project", SortOrder=0 },
            new RefMepProjectBased { Id=Guid.Parse("f925f610-aec1-4fe5-915c-cffcd1bdcddb"), Code="Non-school-based Migrant Education Program project", SortOrder=0 },
       };
   }
}
