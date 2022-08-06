//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIEPGoalTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIEPGoalType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIEPGoalType"> List
         /// </summary>
        public static List<RefIEPGoalType> RefIEPGoalTypeList = new List<RefIEPGoalType> =
        {
            new RefIEPGoalType { Id=Guid.Parse("9f747da9-3ad3-4783-85b3-088c7adb36dd"), Code="Academic is the legal category for an IEP annual goal or short-term objectives.", Description="Academic", Definition="", SortOrder=0 },
            new RefIEPGoalType { Id=Guid.Parse("c19e9b4c-8ae0-4395-87d4-c3ca9f1aea81"), Code="Functional is the legal category for an IEP annual goal or short-term objectives.", Description="Functional", Definition="", SortOrder=0 },
            new RefIEPGoalType { Id=Guid.Parse("e343a864-0004-4e3d-bb4a-5bfebde24dc9"), Code="Transitional is the legal category for an IEP annual goal or short-term objectives.", Description="Transitional", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefIEPGoalType Pick List
         /// </summary>
        public static List<RefIEPGoalType> RefIEPGoalTypePickList = new List<RefIEPGoalType> =
        {
            new RefIEPGoalType { Id=Guid.Parse("9f747da9-3ad3-4783-85b3-088c7adb36dd"), Code="Academic is the legal category for an IEP annual goal or short-term objectives.", SortOrder=0 },
            new RefIEPGoalType { Id=Guid.Parse("c19e9b4c-8ae0-4395-87d4-c3ca9f1aea81"), Code="Functional is the legal category for an IEP annual goal or short-term objectives.", SortOrder=0 },
            new RefIEPGoalType { Id=Guid.Parse("e343a864-0004-4e3d-bb4a-5bfebde24dc9"), Code="Transitional is the legal category for an IEP annual goal or short-term objectives.", SortOrder=0 },
       };
   }
}
