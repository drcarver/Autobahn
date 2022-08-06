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
        public static List<RefParticipationStatusAyp> RefParticipationStatusAypList = new List<RefParticipationStatusAyp> =
        {
            new RefParticipationStatusAyp { Id=Guid.Parse("13542fb4-5929-4ee1-83fc-19dd750f2d68"), Code="The school or district met the 95 percent participation requirement.", Description="Met", Definition="", SortOrder=0 },
            new RefParticipationStatusAyp { Id=Guid.Parse("088d4c55-67ee-4289-b713-096633c1bc34"), Code="The school or district did NOT meet the 95 percent participation requirement.", Description="DidNotMeet", Definition="", SortOrder=0 },
            new RefParticipationStatusAyp { Id=Guid.Parse("1eb6bc5d-aa4a-4413-8ffa-f20983ceb3fa"), Code="There were too Few Students for Reliability.", Description="TooFewStudents", Definition="", SortOrder=0 },
            new RefParticipationStatusAyp { Id=Guid.Parse("11176be6-ce60-46b3-948b-03a3532f607e"), Code="There were no Students in the subgroup.", Description="NoStudents", Definition="", SortOrder=0 },
            new RefParticipationStatusAyp { Id=Guid.Parse("43b069b2-8a69-4072-93d6-80f6e33baf24"), Code="The 95 percent participation status does Not apply.", Description="NA", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefParticipationStatusAyp Pick List
         /// </summary>
        public static List<RefParticipationStatusAyp> RefParticipationStatusAypPickList = new List<RefParticipationStatusAyp> =
        {
            new RefParticipationStatusAyp { Id=Guid.Parse("13542fb4-5929-4ee1-83fc-19dd750f2d68"), Code="The school or district met the 95 percent participation requirement.", SortOrder=0 },
            new RefParticipationStatusAyp { Id=Guid.Parse("088d4c55-67ee-4289-b713-096633c1bc34"), Code="The school or district did NOT meet the 95 percent participation requirement.", SortOrder=0 },
            new RefParticipationStatusAyp { Id=Guid.Parse("1eb6bc5d-aa4a-4413-8ffa-f20983ceb3fa"), Code="There were too Few Students for Reliability.", SortOrder=0 },
            new RefParticipationStatusAyp { Id=Guid.Parse("11176be6-ce60-46b3-948b-03a3532f607e"), Code="There were no Students in the subgroup.", SortOrder=0 },
            new RefParticipationStatusAyp { Id=Guid.Parse("43b069b2-8a69-4072-93d6-80f6e33baf24"), Code="The 95 percent participation status does Not apply.", SortOrder=0 },
       };
   }
}
