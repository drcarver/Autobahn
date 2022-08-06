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
        public static List<RefSpecialEducationAgeGroupTaught> RefSpecialEducationAgeGroupTaughtList = new List<RefSpecialEducationAgeGroupTaught>
        {
            new RefSpecialEducationAgeGroupTaught { Id=Guid.Parse("717f2ff8-450b-40ff-b4ea-2753f5ef7d75"), Code="3TO5", Description="3 through 5", Definition="The age range of special education students taught is 3 through 5.", SortOrder=Convert.ToDecimal("1.00") },
            new RefSpecialEducationAgeGroupTaught { Id=Guid.Parse("2bc81b48-0aa2-4f13-b922-e51f357fd46f"), Code="6TO21", Description="6 through 21", Definition="The age range of special education students taught is 6 through 21.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefSpecialEducationAgeGroupTaught Pick List
         /// </summary>
        public static List<RefSpecialEducationAgeGroupTaught> RefSpecialEducationAgeGroupTaughtPickList = new List<RefSpecialEducationAgeGroupTaught>
        {
            new RefSpecialEducationAgeGroupTaught { Id=Guid.Parse("717f2ff8-450b-40ff-b4ea-2753f5ef7d75"), Code="3TO5", Description="3 through 5", SortOrder=Convert.ToDecimal("1.00") },
            new RefSpecialEducationAgeGroupTaught { Id=Guid.Parse("2bc81b48-0aa2-4f13-b922-e51f357fd46f"), Code="6TO21", Description="6 through 21", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
