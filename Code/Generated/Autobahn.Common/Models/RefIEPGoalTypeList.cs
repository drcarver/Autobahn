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
        public static List<RefIEPGoalType> RefIEPGoalTypeList = new List<RefIEPGoalType>
        {
            new RefIEPGoalType { Id=Guid.Parse("926db572-4bb2-42f0-a24b-17d6e35f96be"), Code="Academic", Description="Academic", Definition="Academic is the legal category for an IEP annual goal or short-term objectives.", SortOrder=Convert.ToDecimal("") },
            new RefIEPGoalType { Id=Guid.Parse("11adcb5d-61cf-4e87-86a2-d0fb59d928a5"), Code="Functional", Description="Functional", Definition="Functional is the legal category for an IEP annual goal or short-term objectives.", SortOrder=Convert.ToDecimal("") },
            new RefIEPGoalType { Id=Guid.Parse("31577a50-1e05-4229-a03b-ef390d5af96c"), Code="Transitional", Description="Transitional", Definition="Transitional is the legal category for an IEP annual goal or short-term objectives.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The RefIEPGoalType Pick List
         /// </summary>
        public static List<RefIEPGoalType> RefIEPGoalTypePickList = new List<RefIEPGoalType>
        {
            new RefIEPGoalType { Id=Guid.Parse("926db572-4bb2-42f0-a24b-17d6e35f96be"), Code="Academic", Description="Academic", SortOrder=Convert.ToDecimal("") },
            new RefIEPGoalType { Id=Guid.Parse("11adcb5d-61cf-4e87-86a2-d0fb59d928a5"), Code="Functional", Description="Functional", SortOrder=Convert.ToDecimal("") },
            new RefIEPGoalType { Id=Guid.Parse("31577a50-1e05-4229-a03b-ef390d5af96c"), Code="Transitional", Description="Transitional", SortOrder=Convert.ToDecimal("") },
       };
   }
}
