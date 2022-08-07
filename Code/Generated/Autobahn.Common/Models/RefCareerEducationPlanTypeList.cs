//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCareerEducationPlanTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCareerEducationPlanType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCareerEducationPlanTypeModel"> List
         /// </summary>
        public static List<RefCareerEducationPlanTypeModel> RefCareerEducationPlanTypeList = new List<RefCareerEducationPlanTypeModel>
        {
            new RefCareerEducationPlanType { Id=Guid.Parse("570a7649-f4a3-4c54-93fc-70adae149201"), Code="Education", Description="Education plan", Definition="An individualized guidance and counseling plan for education.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCareerEducationPlanType { Id=Guid.Parse("20f9d612-4efd-40cf-9644-04575a200c00"), Code="Career", Description="Career plan", Definition="An individualized guidance and counseling plan for career.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCareerEducationPlanType { Id=Guid.Parse("79efd449-eb94-4603-a1d9-78e6ae26fd85"), Code="Both", Description="Both education and career plan", Definition="An individualized guidance and counseling plan for both career and education.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCareerEducationPlanType { Id=Guid.Parse("c8bca10d-5b7d-4e0c-8caa-77ade25c6d93"), Code="Other", Description="Other", Definition="A kind of individualized guidance and counseling plan other than an education plan and a career plan.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The Reference RefCareerEducationPlanType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCareerEducationPlanTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCareerEducationPlanType { Id=Guid.Parse("570a7649-f4a3-4c54-93fc-70adae149201"), Description="Education plan", SortOrder=Convert.ToDecimal("1.00") },
            new RefCareerEducationPlanType { Id=Guid.Parse("20f9d612-4efd-40cf-9644-04575a200c00"), Description="Career plan", SortOrder=Convert.ToDecimal("3.00") },
            new RefCareerEducationPlanType { Id=Guid.Parse("79efd449-eb94-4603-a1d9-78e6ae26fd85"), Description="Both education and career plan", SortOrder=Convert.ToDecimal("5.00") },
            new RefCareerEducationPlanType { Id=Guid.Parse("c8bca10d-5b7d-4e0c-8caa-77ade25c6d93"), Description="Other", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
