//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefSpecialEducationAgeGroupTaughtList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefSpecialEducationAgeGroupTaught Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefSpecialEducationAgeGroupTaught"> List
         /// </summary>
        public static List<RefSpecialEducationAgeGroupTaught> RefSpecialEducationAgeGroupTaughtList = new List<RefSpecialEducationAgeGroupTaught> =
        {
            new RefSpecialEducationAgeGroupTaught { Id=Guid.Parse("a46bafa9-77c9-457f-a73f-abbf4dc16420"), Code="The age range of special education students taught is 3 through 5.", Description="3TO5", Definition="", SortOrder=0 },
            new RefSpecialEducationAgeGroupTaught { Id=Guid.Parse("241caedb-0c65-4a09-958d-20906b6e97fc"), Code="The age range of special education students taught is 6 through 21.", Description="6TO21", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefSpecialEducationAgeGroupTaught Pick List
         /// </summary>
        public static List<RefSpecialEducationAgeGroupTaught> RefSpecialEducationAgeGroupTaughtPickList = new List<RefSpecialEducationAgeGroupTaught> =
        {
            new RefSpecialEducationAgeGroupTaught { Id=Guid.Parse("a46bafa9-77c9-457f-a73f-abbf4dc16420"), Code="The age range of special education students taught is 3 through 5.", SortOrder=0 },
            new RefSpecialEducationAgeGroupTaught { Id=Guid.Parse("241caedb-0c65-4a09-958d-20906b6e97fc"), Code="The age range of special education students taught is 6 through 21.", SortOrder=0 },
       };
   }
}
