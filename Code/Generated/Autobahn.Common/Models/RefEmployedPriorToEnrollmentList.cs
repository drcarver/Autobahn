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
        public static List<RefEmployedPriorToEnrollment> RefEmployedPriorToEnrollmentList = new List<RefEmployedPriorToEnrollment>
        {
            new RefEmployedPriorToEnrollment { Id=Guid.Parse("392fc4ea-8ed8-477d-9e0b-7172f7cf9666"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmployedPriorToEnrollment { Id=Guid.Parse("4c4e2387-d827-4c46-82d2-f39d61bf9d43"), Code="Unknown", Description="Unknown", Definition="", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefEmployedPriorToEnrollment Pick List
         /// </summary>
        public static List<RefEmployedPriorToEnrollment> RefEmployedPriorToEnrollmentPickList = new List<RefEmployedPriorToEnrollment>
        {
            new RefEmployedPriorToEnrollment { Id=Guid.Parse("392fc4ea-8ed8-477d-9e0b-7172f7cf9666"), Code="Yes", Description="Yes", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmployedPriorToEnrollment { Id=Guid.Parse("4c4e2387-d827-4c46-82d2-f39d61bf9d43"), Code="Unknown", Description="Unknown", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
