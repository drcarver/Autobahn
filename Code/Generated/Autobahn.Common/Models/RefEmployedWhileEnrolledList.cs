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
        public static List<RefEmployedWhileEnrolled> RefEmployedWhileEnrolledList = new List<RefEmployedWhileEnrolled> =
        {
            new RefEmployedWhileEnrolled { Id=Guid.Parse("74cebfbc-8668-4639-b8c2-cc18b60ada0c"), Code="", Description="Yes", Definition="", SortOrder=0 },
            new RefEmployedWhileEnrolled { Id=Guid.Parse("07065941-0a9e-4ff1-a0ac-731743bc1987"), Code="", Description="Unknown", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefEmployedWhileEnrolled Pick List
         /// </summary>
        public static List<RefEmployedWhileEnrolled> RefEmployedWhileEnrolledPickList = new List<RefEmployedWhileEnrolled> =
        {
            new RefEmployedWhileEnrolled { Id=Guid.Parse("74cebfbc-8668-4639-b8c2-cc18b60ada0c"), Code="", SortOrder=0 },
            new RefEmployedWhileEnrolled { Id=Guid.Parse("07065941-0a9e-4ff1-a0ac-731743bc1987"), Code="", SortOrder=0 },
       };
   }
}
