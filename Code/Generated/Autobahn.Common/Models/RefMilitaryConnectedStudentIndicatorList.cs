//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefMilitaryConnectedStudentIndicatorList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefMilitaryConnectedStudentIndicator Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMilitaryConnectedStudentIndicator"> List
         /// </summary>
        public static List<RefMilitaryConnectedStudentIndicator> RefMilitaryConnectedStudentIndicatorList = new List<RefMilitaryConnectedStudentIndicator> =
        {
            new RefMilitaryConnectedStudentIndicator { Id=Guid.Parse("44f73243-0dc8-4c4e-8dbd-bbb2c2a87b3b"), Code="Student is not military-connected.", Description="NotMilitaryConnected", Definition="", SortOrder=0 },
            new RefMilitaryConnectedStudentIndicator { Id=Guid.Parse("25a889cf-1970-4f44-9ff8-7260061dc2d1"), Code="Student is a dependent of a member of the Active Duty Forces (full-time) Army, Navy, Air Force, Marine Corps, or Coast Guard or is a dependent of a member on Full-Time National Guard Duty.", Description="ActiveDuty", Definition="", SortOrder=0 },
            new RefMilitaryConnectedStudentIndicator { Id=Guid.Parse("5b129a2f-5fea-44cc-9991-cb07ec02a9db"), Code="Student is a dependent of a member of the National Guard (not full-time duty) or Reserve Forces (Army, Navy, Air Force, Marine Corps, or Coast Guard).", Description="NationalGuardOrReserve", Definition="", SortOrder=0 },
            new RefMilitaryConnectedStudentIndicator { Id=Guid.Parse("ba4e289a-2833-4f3d-954b-566c9989f017"), Code="It is unknown whether or not the student is military-connected.", Description="Unknown", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefMilitaryConnectedStudentIndicator Pick List
         /// </summary>
        public static List<RefMilitaryConnectedStudentIndicator> RefMilitaryConnectedStudentIndicatorPickList = new List<RefMilitaryConnectedStudentIndicator> =
        {
            new RefMilitaryConnectedStudentIndicator { Id=Guid.Parse("44f73243-0dc8-4c4e-8dbd-bbb2c2a87b3b"), Code="Student is not military-connected.", SortOrder=0 },
            new RefMilitaryConnectedStudentIndicator { Id=Guid.Parse("25a889cf-1970-4f44-9ff8-7260061dc2d1"), Code="Student is a dependent of a member of the Active Duty Forces (full-time) Army, Navy, Air Force, Marine Corps, or Coast Guard or is a dependent of a member on Full-Time National Guard Duty.", SortOrder=0 },
            new RefMilitaryConnectedStudentIndicator { Id=Guid.Parse("5b129a2f-5fea-44cc-9991-cb07ec02a9db"), Code="Student is a dependent of a member of the National Guard (not full-time duty) or Reserve Forces (Army, Navy, Air Force, Marine Corps, or Coast Guard).", SortOrder=0 },
            new RefMilitaryConnectedStudentIndicator { Id=Guid.Parse("ba4e289a-2833-4f3d-954b-566c9989f017"), Code="It is unknown whether or not the student is military-connected.", SortOrder=0 },
       };
   }
}
