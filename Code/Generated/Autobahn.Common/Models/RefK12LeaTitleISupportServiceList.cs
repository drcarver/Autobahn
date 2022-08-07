//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefK12LeaTitleISupportServiceList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefK12LeaTitleISupportService Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefK12LeaTitleISupportServiceModel"> List
         /// </summary>
        public static List<RefK12LeaTitleISupportServiceModel> RefK12LeaTitleISupportServiceList = new List<RefK12LeaTitleISupportServiceModel>
        {
            new RefK12LeaTitleISupportService { Id=Guid.Parse("4ea1aeef-f4e8-4276-a173-adbd04418c96"), Code="HealthDentalEyeCare", Description="Health, Dental and Eye Care", Definition="Health, Dental and Eye Care is the type of support services provided to students in Title I programs.", SortOrder=Convert.ToDecimal("1.00") },
            new RefK12LeaTitleISupportService { Id=Guid.Parse("59d02814-4ade-4a35-b79c-1f0375edfe17"), Code="GuidanceAdvocacy", Description="Supporting Guidance/Advocacy", Definition="Supporting Guidance/Advocacy is the type of support services provided to students in Title I programs.", SortOrder=Convert.ToDecimal("2.00") },
            new RefK12LeaTitleISupportService { Id=Guid.Parse("02dddd0c-e275-4f59-81bd-a9947790213a"), Code="Other", Description="Other", Definition="Any other type of support services provided to students in Title I programs.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefK12LeaTitleISupportService Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefK12LeaTitleISupportServiceViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefK12LeaTitleISupportService { Id=Guid.Parse("4ea1aeef-f4e8-4276-a173-adbd04418c96"), Description="Health, Dental and Eye Care", SortOrder=Convert.ToDecimal("1.00") },
            new RefK12LeaTitleISupportService { Id=Guid.Parse("59d02814-4ade-4a35-b79c-1f0375edfe17"), Description="Supporting Guidance/Advocacy", SortOrder=Convert.ToDecimal("2.00") },
            new RefK12LeaTitleISupportService { Id=Guid.Parse("02dddd0c-e275-4f59-81bd-a9947790213a"), Description="Other", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
