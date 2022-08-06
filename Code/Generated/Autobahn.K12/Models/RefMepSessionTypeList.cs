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
        public static List<RefMepSessionType> RefMepSessionTypeList = new List<RefMepSessionType>
        {
            new RefMepSessionType { Id=Guid.Parse("acc12802-b9df-42ec-a95a-36fc67edc638"), Code="RegularSchoolYear", Description="Regular School Year", Definition="The Migrant Education Program operates during the Regular School Year.", SortOrder=Convert.ToDecimal("1.00") },
            new RefMepSessionType { Id=Guid.Parse("b725b586-ed8d-4253-a03e-46da6b56230f"), Code="SummerTerm", Description="Summer Term or Intersession", Definition="The Migrant Education Program operates during the Summer Term or Intersession.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefMepSessionType Pick List
         /// </summary>
        public static List<RefMepSessionType> RefMepSessionTypePickList = new List<RefMepSessionType>
        {
            new RefMepSessionType { Id=Guid.Parse("acc12802-b9df-42ec-a95a-36fc67edc638"), Code="RegularSchoolYear", Description="Regular School Year", SortOrder=Convert.ToDecimal("1.00") },
            new RefMepSessionType { Id=Guid.Parse("b725b586-ed8d-4253-a03e-46da6b56230f"), Code="SummerTerm", Description="Summer Term or Intersession", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
