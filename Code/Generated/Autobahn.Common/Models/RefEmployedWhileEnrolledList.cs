//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEmployedWhileEnrolledList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefEmployedWhileEnrolled Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEmployedWhileEnrolled"> List
         /// </summary>
        public static List<RefEmployedWhileEnrolled> RefEmployedWhileEnrolledList = new List<RefEmployedWhileEnrolled>
        {
            new RefEmployedWhileEnrolled { Id=Guid.Parse("a38f47a3-3fa0-4a1f-a92e-0d31754a850f"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmployedWhileEnrolled { Id=Guid.Parse("8517c42e-099d-49b8-b5a1-f6aed037093b"), Code="Unknown", Description="Unknown", Definition="", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefEmployedWhileEnrolled Pick List
         /// </summary>
        public static List<RefEmployedWhileEnrolled> RefEmployedWhileEnrolledPickList = new List<RefEmployedWhileEnrolled>
        {
            new RefEmployedWhileEnrolled { Id=Guid.Parse("a38f47a3-3fa0-4a1f-a92e-0d31754a850f"), Code="Yes", Description="Yes", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmployedWhileEnrolled { Id=Guid.Parse("8517c42e-099d-49b8-b5a1-f6aed037093b"), Code="Unknown", Description="Unknown", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
