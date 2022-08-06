//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCriticalTeacherShortageCandidateList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCriticalTeacherShortageCandidate Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCriticalTeacherShortageCandidate"> List
         /// </summary>
        public static List<RefCriticalTeacherShortageCandidate> RefCriticalTeacherShortageCandidateList = new List<RefCriticalTeacherShortageCandidate>
        {
            new RefCriticalTeacherShortageCandidate { Id=Guid.Parse("dea0f856-debc-4c88-a4e7-f7aea882f4b8"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new RefCriticalTeacherShortageCandidate { Id=Guid.Parse("c6e86d65-2449-43bb-b433-3698c8bbeae2"), Code="No", Description="No", Definition="", SortOrder=Convert.ToDecimal("2.00") },
            new RefCriticalTeacherShortageCandidate { Id=Guid.Parse("9c0c5e56-85e8-4207-96d5-8c42c7c7c3d1"), Code="NA", Description="Not applicable", Definition="", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefCriticalTeacherShortageCandidate Pick List
         /// </summary>
        public static List<RefCriticalTeacherShortageCandidate> RefCriticalTeacherShortageCandidatePickList = new List<RefCriticalTeacherShortageCandidate>
        {
            new RefCriticalTeacherShortageCandidate { Id=Guid.Parse("dea0f856-debc-4c88-a4e7-f7aea882f4b8"), Code="Yes", Description="Yes", SortOrder=Convert.ToDecimal("1.00") },
            new RefCriticalTeacherShortageCandidate { Id=Guid.Parse("c6e86d65-2449-43bb-b433-3698c8bbeae2"), Code="No", Description="No", SortOrder=Convert.ToDecimal("2.00") },
            new RefCriticalTeacherShortageCandidate { Id=Guid.Parse("9c0c5e56-85e8-4207-96d5-8c42c7c7c3d1"), Code="NA", Description="Not applicable", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
