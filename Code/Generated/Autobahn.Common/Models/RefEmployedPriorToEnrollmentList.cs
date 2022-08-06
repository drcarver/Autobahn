//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEmployedPriorToEnrollmentList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefEmployedPriorToEnrollment Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEmployedPriorToEnrollment"> List
         /// </summary>
        public static List<RefEmployedPriorToEnrollment> RefEmployedPriorToEnrollmentList = new List<RefEmployedPriorToEnrollment> =
        {
            new RefEmployedPriorToEnrollment { Id=Guid.Parse("73446e8f-ea0e-4dbc-b940-7c8e5df31d47"), Code="", Description="Yes", Definition="", SortOrder=0 },
            new RefEmployedPriorToEnrollment { Id=Guid.Parse("d52af540-63bb-47aa-aac2-4f0641cdca44"), Code="", Description="Unknown", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefEmployedPriorToEnrollment Pick List
         /// </summary>
        public static List<RefEmployedPriorToEnrollment> RefEmployedPriorToEnrollmentPickList = new List<RefEmployedPriorToEnrollment> =
        {
            new RefEmployedPriorToEnrollment { Id=Guid.Parse("73446e8f-ea0e-4dbc-b940-7c8e5df31d47"), Code="", SortOrder=0 },
            new RefEmployedPriorToEnrollment { Id=Guid.Parse("d52af540-63bb-47aa-aac2-4f0641cdca44"), Code="", SortOrder=0 },
       };
   }
}
