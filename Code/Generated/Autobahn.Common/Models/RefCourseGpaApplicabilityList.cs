//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCourseGpaApplicabilityList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCourseGpaApplicability Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCourseGpaApplicabilityModel"> List
         /// </summary>
        public static List<RefCourseGpaApplicabilityModel> RefCourseGpaApplicabilityList = new List<RefCourseGpaApplicabilityModel>
        {
            new RefCourseGpaApplicability { Id=Guid.Parse("1a2902e0-03cd-4acd-8fc6-5c165f92bf82"), Code="Applicable", Description="Applicable in GPA", Definition="The course being described is included in the computation of the student's Grade Point Average (GPA).", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseGpaApplicability { Id=Guid.Parse("da978ac9-e4e4-4a44-869b-884d1de52d1d"), Code="NotApplicable", Description="Not Applicable in GPA", Definition="The course being described is not included in the computation of the student's Grade Point Average (GPA).", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseGpaApplicability { Id=Guid.Parse("dcb1c2c5-b013-4b73-ad50-a7f356865c78"), Code="Weighted", Description="Weighted in GPA", Definition="The course being described is weighted in the computation of the student's Grade Point Average (GPA)", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefCourseGpaApplicability Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCourseGpaApplicabilityViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCourseGpaApplicability { Id=Guid.Parse("1a2902e0-03cd-4acd-8fc6-5c165f92bf82"), Description="Applicable in GPA", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseGpaApplicability { Id=Guid.Parse("da978ac9-e4e4-4a44-869b-884d1de52d1d"), Description="Not Applicable in GPA", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseGpaApplicability { Id=Guid.Parse("dcb1c2c5-b013-4b73-ad50-a7f356865c78"), Description="Weighted in GPA", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
