//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIncidentInjuryTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIncidentInjuryType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIncidentInjuryTypeModel"> List
         /// </summary>
        public static List<RefIncidentInjuryTypeModel> RefIncidentInjuryTypeList = new List<RefIncidentInjuryTypeModel>
        {
            new RefIncidentInjuryType { Id=Guid.Parse("3f8a245c-c90f-4d3d-af89-a0fc025dc5c7"), Code="MajorInjury", Description="Major injury", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncidentInjuryType { Id=Guid.Parse("fc16bde1-6d05-49d0-82d4-17a36795ebaf"), Code="MinorInjury", Description="Minor injury", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new RefIncidentInjuryType { Id=Guid.Parse("3df0f508-fb18-4bc3-ad78-220e66c65fd5"), Code="NoInjury", Description="No injury", Definition="", SortOrder=Convert.ToDecimal("3.00") },
            new RefIncidentInjuryType { Id=Guid.Parse("34ae9265-2f25-4ad3-94ae-06f903c0b4b3"), Code="SeriousBodilyInjury", Description="Serious bodily injury", Definition="", SortOrder=Convert.ToDecimal("4.00") },
            new RefIncidentInjuryType { Id=Guid.Parse("e2e8612b-9882-433e-934f-02fd97c453fd"), Code="FatalInjury", Description="Fatal injury", Definition="", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefIncidentInjuryType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefIncidentInjuryTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefIncidentInjuryType { Id=Guid.Parse("3f8a245c-c90f-4d3d-af89-a0fc025dc5c7"), Description="Major injury", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncidentInjuryType { Id=Guid.Parse("fc16bde1-6d05-49d0-82d4-17a36795ebaf"), Description="Minor injury", SortOrder=Convert.ToDecimal("2.00") },
            new RefIncidentInjuryType { Id=Guid.Parse("3df0f508-fb18-4bc3-ad78-220e66c65fd5"), Description="No injury", SortOrder=Convert.ToDecimal("3.00") },
            new RefIncidentInjuryType { Id=Guid.Parse("34ae9265-2f25-4ad3-94ae-06f903c0b4b3"), Description="Serious bodily injury", SortOrder=Convert.ToDecimal("4.00") },
            new RefIncidentInjuryType { Id=Guid.Parse("e2e8612b-9882-433e-934f-02fd97c453fd"), Description="Fatal injury", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
