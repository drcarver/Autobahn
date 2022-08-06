//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefParticipationStatusAypList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefParticipationStatusAyp Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefParticipationStatusAyp"> List
         /// </summary>
        public static List<RefParticipationStatusAyp> RefParticipationStatusAypList = new List<RefParticipationStatusAyp>
        {
            new RefParticipationStatusAyp { Id=Guid.Parse("c6fda34d-14f5-4087-b42a-a655bc48c348"), Code="Met", Description="Met 95%", Definition="The school or district met the 95 percent participation requirement.", SortOrder=Convert.ToDecimal("1.00") },
            new RefParticipationStatusAyp { Id=Guid.Parse("7793471c-3285-4f06-bfe0-f50c5510a488"), Code="DidNotMeet", Description="Did not Meet 95%", Definition="The school or district did NOT meet the 95 percent participation requirement.", SortOrder=Convert.ToDecimal("2.00") },
            new RefParticipationStatusAyp { Id=Guid.Parse("fba1b545-5496-48c8-bf13-7d18faf2913f"), Code="TooFewStudents", Description="Too Few Students for Reliability", Definition="There were too Few Students for Reliability.", SortOrder=Convert.ToDecimal("3.00") },
            new RefParticipationStatusAyp { Id=Guid.Parse("4b8cb8f4-ff4c-4072-b9c9-57366d80dfac"), Code="NoStudents", Description="No Students in the subgroup", Definition="There were no Students in the subgroup.", SortOrder=Convert.ToDecimal("4.00") },
            new RefParticipationStatusAyp { Id=Guid.Parse("32d2aac6-5a8b-41db-ab74-467f5ee544c4"), Code="NA", Description="Not applicable", Definition="The 95 percent participation status does Not apply.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefParticipationStatusAyp Pick List
         /// </summary>
        public static List<RefParticipationStatusAyp> RefParticipationStatusAypPickList = new List<RefParticipationStatusAyp>
        {
            new RefParticipationStatusAyp { Id=Guid.Parse("c6fda34d-14f5-4087-b42a-a655bc48c348"), Code="Met", Description="Met 95%", SortOrder=Convert.ToDecimal("1.00") },
            new RefParticipationStatusAyp { Id=Guid.Parse("7793471c-3285-4f06-bfe0-f50c5510a488"), Code="DidNotMeet", Description="Did not Meet 95%", SortOrder=Convert.ToDecimal("2.00") },
            new RefParticipationStatusAyp { Id=Guid.Parse("fba1b545-5496-48c8-bf13-7d18faf2913f"), Code="TooFewStudents", Description="Too Few Students for Reliability", SortOrder=Convert.ToDecimal("3.00") },
            new RefParticipationStatusAyp { Id=Guid.Parse("4b8cb8f4-ff4c-4072-b9c9-57366d80dfac"), Code="NoStudents", Description="No Students in the subgroup", SortOrder=Convert.ToDecimal("4.00") },
            new RefParticipationStatusAyp { Id=Guid.Parse("32d2aac6-5a8b-41db-ab74-467f5ee544c4"), Code="NA", Description="Not applicable", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
