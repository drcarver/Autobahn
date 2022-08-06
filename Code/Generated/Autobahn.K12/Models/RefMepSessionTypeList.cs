//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefMepSessionTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefMepSessionType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMepSessionType"> List
         /// </summary>
        public static List<RefMepSessionType> RefMepSessionTypeList = new List<RefMepSessionType> =
        {
            new RefMepSessionType { Id=Guid.Parse("5ebd4a00-4590-4e48-8f56-3837ca6859ec"), Code="The Migrant Education Program operates during the Regular School Year.", Description="RegularSchoolYear", Definition="", SortOrder=0 },
            new RefMepSessionType { Id=Guid.Parse("e86698fc-5e08-4904-a836-78da9cd9d332"), Code="The Migrant Education Program operates during the Summer Term or Intersession.", Description="SummerTerm", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefMepSessionType Pick List
         /// </summary>
        public static List<RefMepSessionType> RefMepSessionTypePickList = new List<RefMepSessionType> =
        {
            new RefMepSessionType { Id=Guid.Parse("5ebd4a00-4590-4e48-8f56-3837ca6859ec"), Code="The Migrant Education Program operates during the Regular School Year.", SortOrder=0 },
            new RefMepSessionType { Id=Guid.Parse("e86698fc-5e08-4904-a836-78da9cd9d332"), Code="The Migrant Education Program operates during the Summer Term or Intersession.", SortOrder=0 },
       };
   }
}
