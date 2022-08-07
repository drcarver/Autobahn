//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCourseRepeatCodeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCourseRepeatCode Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCourseRepeatCodeModel"> List
         /// </summary>
        public static List<RefCourseRepeatCodeModel> RefCourseRepeatCodeList = new List<RefCourseRepeatCodeModel>
        {
            new RefCourseRepeatCode { Id=Guid.Parse("a6ab0cbe-261a-4c7b-aa7c-dde12dd51daf"), Code="RepeatCounted", Description="Repeated, counted in grade point average", Definition="The student repeated the course and it has been counted in grade point average. ", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseRepeatCode { Id=Guid.Parse("7f375478-46bc-4a17-a329-f31d3785c6e4"), Code="RepeatNotCounted", Description="Repeated, not counted in grade point average", Definition="The student repeated the course and it has not been counted in grade point average. ", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseRepeatCode { Id=Guid.Parse("a3b413e1-0fd9-4230-98e8-e4a38ba886e0"), Code="ReplacementCounted", Description="Replacement counted", Definition="Replacement course counted.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCourseRepeatCode { Id=Guid.Parse("775b6af6-158a-4317-82e7-fcc634e14c75"), Code="ReplacedNotCounted", Description="Replacement not counted", Definition="Replacement course not counted.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseRepeatCode { Id=Guid.Parse("11de3bb1-ee04-43c3-a02a-c9e85952159b"), Code="RepeatOtherInstitution", Description="Repeated, other institution", Definition="The student repeated the course and it has been counted by another institution.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCourseRepeatCode { Id=Guid.Parse("c8f93851-4458-495b-80f6-705ecb9fe9da"), Code="NotCountedOther", Description="Other, not counted in GPA (e.g., used for academic forgiveness or clemency).", Definition="Other, the course is not counted in GPA (e.g., used for academic forgiveness or clemency).", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The Reference RefCourseRepeatCode Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCourseRepeatCodeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCourseRepeatCode { Id=Guid.Parse("a6ab0cbe-261a-4c7b-aa7c-dde12dd51daf"), Description="Repeated, counted in grade point average", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseRepeatCode { Id=Guid.Parse("7f375478-46bc-4a17-a329-f31d3785c6e4"), Description="Repeated, not counted in grade point average", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseRepeatCode { Id=Guid.Parse("a3b413e1-0fd9-4230-98e8-e4a38ba886e0"), Description="Replacement counted", SortOrder=Convert.ToDecimal("3.00") },
            new RefCourseRepeatCode { Id=Guid.Parse("775b6af6-158a-4317-82e7-fcc634e14c75"), Description="Replacement not counted", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseRepeatCode { Id=Guid.Parse("11de3bb1-ee04-43c3-a02a-c9e85952159b"), Description="Repeated, other institution", SortOrder=Convert.ToDecimal("5.00") },
            new RefCourseRepeatCode { Id=Guid.Parse("c8f93851-4458-495b-80f6-705ecb9fe9da"), Description="Other, not counted in GPA (e.g., used for academic forgiveness or clemency).", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
