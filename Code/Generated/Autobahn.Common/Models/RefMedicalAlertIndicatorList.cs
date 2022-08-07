//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefMedicalAlertIndicatorList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefMedicalAlertIndicator Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMedicalAlertIndicatorModel"> List
         /// </summary>
        public static List<RefMedicalAlertIndicatorModel> RefMedicalAlertIndicatorList = new List<RefMedicalAlertIndicatorModel>
        {
            new RefMedicalAlertIndicator { Id=Guid.Parse("193a2d7b-76b4-43c3-a6bd-94a42f6ee858"), Code="Chronic", Description="Chronic", Definition="The person has an alert indicator for a chronic medical/health condition.", SortOrder=Convert.ToDecimal("1.00") },
            new RefMedicalAlertIndicator { Id=Guid.Parse("13e981d1-e002-49cd-a1ed-9e926717a361"), Code="Acute", Description="Acute", Definition="The person has an alert indicator for an acute medical/health condition.", SortOrder=Convert.ToDecimal("2.00") },
            new RefMedicalAlertIndicator { Id=Guid.Parse("9069c6e8-79d2-42c0-ba2f-b25b423e182d"), Code="None", Description="None", Definition="The person does not have an alert indicator for a medical/health condition.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefMedicalAlertIndicator Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefMedicalAlertIndicatorViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefMedicalAlertIndicator { Id=Guid.Parse("193a2d7b-76b4-43c3-a6bd-94a42f6ee858"), Description="Chronic", SortOrder=Convert.ToDecimal("1.00") },
            new RefMedicalAlertIndicator { Id=Guid.Parse("13e981d1-e002-49cd-a1ed-9e926717a361"), Description="Acute", SortOrder=Convert.ToDecimal("2.00") },
            new RefMedicalAlertIndicator { Id=Guid.Parse("9069c6e8-79d2-42c0-ba2f-b25b423e182d"), Description="None", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
