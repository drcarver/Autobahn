//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefMilitaryVeteranStudentIndicatorList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefMilitaryVeteranStudentIndicator Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMilitaryVeteranStudentIndicator"> List
         /// </summary>
        public static List<RefMilitaryVeteranStudentIndicator> RefMilitaryVeteranStudentIndicatorList = new List<RefMilitaryVeteranStudentIndicator> =
        {
            new RefMilitaryVeteranStudentIndicator { Id=Guid.Parse("5573ecfa-9e14-44dd-ad17-c68f42f504b6"), Code="Student is not a veteran of the military.", Description="NotVeteran", Definition="", SortOrder=0 },
            new RefMilitaryVeteranStudentIndicator { Id=Guid.Parse("5e0e44c2-1062-425a-9861-452845023314"), Code="Student is a Veteran of the Active Duty Forces, National Guard, or Reserve Forces.", Description="Veteran", Definition="", SortOrder=0 },
            new RefMilitaryVeteranStudentIndicator { Id=Guid.Parse("e92c179b-5caa-4c7f-9843-9cff8dc34cd0"), Code="It is unknown whether or not the Student is a veteran of the military.", Description="Unknown", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefMilitaryVeteranStudentIndicator Pick List
         /// </summary>
        public static List<RefMilitaryVeteranStudentIndicator> RefMilitaryVeteranStudentIndicatorPickList = new List<RefMilitaryVeteranStudentIndicator> =
        {
            new RefMilitaryVeteranStudentIndicator { Id=Guid.Parse("5573ecfa-9e14-44dd-ad17-c68f42f504b6"), Code="Student is not a veteran of the military.", SortOrder=0 },
            new RefMilitaryVeteranStudentIndicator { Id=Guid.Parse("5e0e44c2-1062-425a-9861-452845023314"), Code="Student is a Veteran of the Active Duty Forces, National Guard, or Reserve Forces.", SortOrder=0 },
            new RefMilitaryVeteranStudentIndicator { Id=Guid.Parse("e92c179b-5caa-4c7f-9843-9cff8dc34cd0"), Code="It is unknown whether or not the Student is a veteran of the military.", SortOrder=0 },
       };
   }
}
