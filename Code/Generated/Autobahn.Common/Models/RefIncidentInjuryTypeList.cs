//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIncidentInjuryTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIncidentInjuryType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIncidentInjuryType"> List
         /// </summary>
        public static List<RefIncidentInjuryType> RefIncidentInjuryTypeList = new List<RefIncidentInjuryType>
        {
            new RefIncidentInjuryType { Id=Guid.Parse("9b02ea5d-3ab4-4496-a395-7599e848ee85"), Code="MajorInjury", Description="Major injury", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncidentInjuryType { Id=Guid.Parse("2e7d805f-07ce-4257-8383-65c5d1778167"), Code="MinorInjury", Description="Minor injury", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new RefIncidentInjuryType { Id=Guid.Parse("8c0a55f5-9477-4eb5-a0da-e108fc9509b7"), Code="NoInjury", Description="No injury", Definition="", SortOrder=Convert.ToDecimal("3.00") },
            new RefIncidentInjuryType { Id=Guid.Parse("3c9ba455-9f9d-424a-af66-8baf964bb792"), Code="SeriousBodilyInjury", Description="Serious bodily injury", Definition="", SortOrder=Convert.ToDecimal("4.00") },
            new RefIncidentInjuryType { Id=Guid.Parse("b1a2a126-c102-4133-be4a-dd658b98a537"), Code="FatalInjury", Description="Fatal injury", Definition="", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefIncidentInjuryType Pick List
         /// </summary>
        public static List<RefIncidentInjuryType> RefIncidentInjuryTypePickList = new List<RefIncidentInjuryType>
        {
            new RefIncidentInjuryType { Id=Guid.Parse("9b02ea5d-3ab4-4496-a395-7599e848ee85"), Code="MajorInjury", Description="Major injury", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncidentInjuryType { Id=Guid.Parse("2e7d805f-07ce-4257-8383-65c5d1778167"), Code="MinorInjury", Description="Minor injury", SortOrder=Convert.ToDecimal("2.00") },
            new RefIncidentInjuryType { Id=Guid.Parse("8c0a55f5-9477-4eb5-a0da-e108fc9509b7"), Code="NoInjury", Description="No injury", SortOrder=Convert.ToDecimal("3.00") },
            new RefIncidentInjuryType { Id=Guid.Parse("3c9ba455-9f9d-424a-af66-8baf964bb792"), Code="SeriousBodilyInjury", Description="Serious bodily injury", SortOrder=Convert.ToDecimal("4.00") },
            new RefIncidentInjuryType { Id=Guid.Parse("b1a2a126-c102-4133-be4a-dd658b98a537"), Code="FatalInjury", Description="Fatal injury", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
