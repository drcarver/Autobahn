//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCriticalTeacherShortageCandidateList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCriticalTeacherShortageCandidate Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCriticalTeacherShortageCandidateModel"> List
         /// </summary>
        public static List<RefCriticalTeacherShortageCandidateModel> RefCriticalTeacherShortageCandidateList = new List<RefCriticalTeacherShortageCandidateModel>
        {
            new RefCriticalTeacherShortageCandidate { Id=Guid.Parse("fcee2956-f43c-4730-9604-88deb21e7e14"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new RefCriticalTeacherShortageCandidate { Id=Guid.Parse("0ef45800-fee3-43e7-b19c-2ab4ba2290f8"), Code="No", Description="No", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new RefCriticalTeacherShortageCandidate { Id=Guid.Parse("1df3687f-7a8f-451e-9b27-d609a1234c4a"), Code="NA", Description="Not applicable", Definition="", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefCriticalTeacherShortageCandidate Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCriticalTeacherShortageCandidateViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCriticalTeacherShortageCandidate { Id=Guid.Parse("fcee2956-f43c-4730-9604-88deb21e7e14"), Description="Yes", SortOrder=Convert.ToDecimal("1.00") },
            new RefCriticalTeacherShortageCandidate { Id=Guid.Parse("0ef45800-fee3-43e7-b19c-2ab4ba2290f8"), Description="No", SortOrder=Convert.ToDecimal("2.00") },
            new RefCriticalTeacherShortageCandidate { Id=Guid.Parse("1df3687f-7a8f-451e-9b27-d609a1234c4a"), Description="Not applicable", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
