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
        public static List<RefCriticalTeacherShortageCandidate> RefCriticalTeacherShortageCandidateList = new List<RefCriticalTeacherShortageCandidate> =
        {
            new RefCriticalTeacherShortageCandidate { Id=Guid.Parse("5c28b928-ebce-489a-a96c-995b5bd521fb"), Code="", Description="Yes", Definition="", SortOrder=0 },
            new RefCriticalTeacherShortageCandidate { Id=Guid.Parse("acb2213c-ec32-43d8-8fc5-169e01df247f"), Code="", Description="No", Definition="", SortOrder=0 },
            new RefCriticalTeacherShortageCandidate { Id=Guid.Parse("42dad81b-9fa5-41e5-8c24-5218a629aad9"), Code="", Description="NA", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCriticalTeacherShortageCandidate Pick List
         /// </summary>
        public static List<RefCriticalTeacherShortageCandidate> RefCriticalTeacherShortageCandidatePickList = new List<RefCriticalTeacherShortageCandidate> =
        {
            new RefCriticalTeacherShortageCandidate { Id=Guid.Parse("5c28b928-ebce-489a-a96c-995b5bd521fb"), Code="", SortOrder=0 },
            new RefCriticalTeacherShortageCandidate { Id=Guid.Parse("acb2213c-ec32-43d8-8fc5-169e01df247f"), Code="", SortOrder=0 },
            new RefCriticalTeacherShortageCandidate { Id=Guid.Parse("42dad81b-9fa5-41e5-8c24-5218a629aad9"), Code="", SortOrder=0 },
       };
   }
}
