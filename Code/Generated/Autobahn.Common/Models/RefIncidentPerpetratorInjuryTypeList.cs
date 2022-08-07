//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIncidentPerpetratorInjuryTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIncidentPerpetratorInjuryType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIncidentPerpetratorInjuryTypeModel"> List
         /// </summary>
        public static List<RefIncidentPerpetratorInjuryTypeModel> RefIncidentPerpetratorInjuryTypeList = new List<RefIncidentPerpetratorInjuryTypeModel>
        {
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("c5319947-7851-4d1b-8b4a-d5c30ce48c0b"), Code="MajorInjury", Description="Major injury", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("04d16854-4021-4ed8-b717-51a2300cd472"), Code="MinorInjury", Description="Minor injury", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("3476ac3f-ca01-485d-8053-aaa12c8d5ce0"), Code="NoInjury", Description="No injury", Definition="", SortOrder=Convert.ToDecimal("3.00") },
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("6ea6525d-565c-4a54-aa50-e0ec3fdde1da"), Code="SeriousBodilyInjury", Description="Serious bodily injury", Definition="", SortOrder=Convert.ToDecimal("4.00") },
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("7203b540-8fc1-405d-ae45-c265dcc6120a"), Code="FatalInjury", Description="Fatal injury", Definition="", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefIncidentPerpetratorInjuryType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefIncidentPerpetratorInjuryTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("c5319947-7851-4d1b-8b4a-d5c30ce48c0b"), Description="Major injury", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("04d16854-4021-4ed8-b717-51a2300cd472"), Description="Minor injury", SortOrder=Convert.ToDecimal("2.00") },
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("3476ac3f-ca01-485d-8053-aaa12c8d5ce0"), Description="No injury", SortOrder=Convert.ToDecimal("3.00") },
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("6ea6525d-565c-4a54-aa50-e0ec3fdde1da"), Description="Serious bodily injury", SortOrder=Convert.ToDecimal("4.00") },
            new RefIncidentPerpetratorInjuryType { Id=Guid.Parse("7203b540-8fc1-405d-ae45-c265dcc6120a"), Description="Fatal injury", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
