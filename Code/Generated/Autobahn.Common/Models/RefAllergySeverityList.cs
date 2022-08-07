//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAllergySeverityList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefAllergySeverity Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAllergySeverityModel"> List
         /// </summary>
        public static List<RefAllergySeverityModel> RefAllergySeverityList = new List<RefAllergySeverityModel>
        {
            new RefAllergySeverity { Id=Guid.Parse("10e397b9-1c4e-4983-8b66-64f30985cd8e"), Code="Mild", Description="Mild allergic reaction", Definition="The level of severity of a person's reaction to an allergen is mild.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAllergySeverity { Id=Guid.Parse("1ad349e1-0c2a-44fa-824a-372a8c0026e3"), Code="Severe", Description="Severe allergic reaction", Definition="The level of severity of a person's reaction to an allergen is severe.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefAllergySeverity Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAllergySeverityViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAllergySeverity { Id=Guid.Parse("10e397b9-1c4e-4983-8b66-64f30985cd8e"), Description="Mild allergic reaction", SortOrder=Convert.ToDecimal("1.00") },
            new RefAllergySeverity { Id=Guid.Parse("1ad349e1-0c2a-44fa-824a-372a8c0026e3"), Description="Severe allergic reaction", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
