//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefParaprofessionalQualificationList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefParaprofessionalQualification Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefParaprofessionalQualificationModel"> List
         /// </summary>
        public static List<RefParaprofessionalQualificationModel> RefParaprofessionalQualificationList = new List<RefParaprofessionalQualificationModel>
        {
            new RefParaprofessionalQualification { Id=Guid.Parse("05160eed-c1d6-40e6-a058-d62180127b94"), Code="Qualified", Description="Qualified", Definition="The paraprofessional is qualified for their assignment according to state definition.", SortOrder=Convert.ToDecimal("1.00") },
            new RefParaprofessionalQualification { Id=Guid.Parse("4082b5bf-bfb7-4413-a872-9614c594c077"), Code="NotQualified", Description="Not Qualified", Definition="The paraprofessional is NOT qualified for their assignment according to state definition.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefParaprofessionalQualification Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefParaprofessionalQualificationViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefParaprofessionalQualification { Id=Guid.Parse("05160eed-c1d6-40e6-a058-d62180127b94"), Description="Qualified", SortOrder=Convert.ToDecimal("1.00") },
            new RefParaprofessionalQualification { Id=Guid.Parse("4082b5bf-bfb7-4413-a872-9614c594c077"), Description="Not Qualified", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
