//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefMepProjectBasedList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefMepProjectBased Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMepProjectBasedModel"> List
         /// </summary>
        public static List<RefMepProjectBasedModel> RefMepProjectBasedList = new List<RefMepProjectBasedModel>
        {
            new RefMepProjectBased { Id=Guid.Parse("160eab8e-e31a-4613-815c-4e705cd610e1"), Code="SchoolBased", Description="School-based MEP Project", Definition="School-based Migrant Education Program Project", SortOrder=Convert.ToDecimal("1.00") },
            new RefMepProjectBased { Id=Guid.Parse("502aece6-4c35-444b-9a4b-3b64095f705a"), Code="NonSchoolBased", Description="Non-school-based MEP project", Definition="Non-school-based Migrant Education Program project", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefMepProjectBased Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefMepProjectBasedViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefMepProjectBased { Id=Guid.Parse("160eab8e-e31a-4613-815c-4e705cd610e1"), Description="School-based MEP Project", SortOrder=Convert.ToDecimal("1.00") },
            new RefMepProjectBased { Id=Guid.Parse("502aece6-4c35-444b-9a4b-3b64095f705a"), Description="Non-school-based MEP project", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
