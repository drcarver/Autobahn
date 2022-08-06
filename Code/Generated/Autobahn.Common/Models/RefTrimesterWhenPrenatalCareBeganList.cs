//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefTrimesterWhenPrenatalCareBeganList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefTrimesterWhenPrenatalCareBegan Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefTrimesterWhenPrenatalCareBegan"> List
         /// </summary>
        public static List<RefTrimesterWhenPrenatalCareBegan> RefTrimesterWhenPrenatalCareBeganList = new List<RefTrimesterWhenPrenatalCareBegan>
        {
            new RefTrimesterWhenPrenatalCareBegan { Id=Guid.Parse("ae27cbae-574e-4508-85eb-84a81b3c82cb"), Code="FirstTrimester", Description="First trimester", Definition="The  child's mother began receiving prenatal health care in the first trimester.", SortOrder=Convert.ToDecimal("1.00") },
            new RefTrimesterWhenPrenatalCareBegan { Id=Guid.Parse("3510d62f-2afc-4f1a-b6a0-98fd36f3a384"), Code="SecondTrimester", Description="Second trimester", Definition="The  child's mother began receiving prenatal health care in the second trimester.", SortOrder=Convert.ToDecimal("3.00") },
            new RefTrimesterWhenPrenatalCareBegan { Id=Guid.Parse("1ab404bf-917b-4319-938a-cb1b2559816b"), Code="ThirdTrimester", Description="Third trimester", Definition="The  child's mother began receiving prenatal health care in the third trimester.", SortOrder=Convert.ToDecimal("5.00") },
            new RefTrimesterWhenPrenatalCareBegan { Id=Guid.Parse("e52e6f4e-d596-4f3b-b35c-56dbf5025eb3"), Code="NoPrenatalHealthCare", Description="No prenatal health care", Definition="The  child's mother did not receive prenatal health care.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefTrimesterWhenPrenatalCareBegan Pick List
         /// </summary>
        public static List<RefTrimesterWhenPrenatalCareBegan> RefTrimesterWhenPrenatalCareBeganPickList = new List<RefTrimesterWhenPrenatalCareBegan>
        {
            new RefTrimesterWhenPrenatalCareBegan { Id=Guid.Parse("ae27cbae-574e-4508-85eb-84a81b3c82cb"), Code="FirstTrimester", Description="First trimester", SortOrder=Convert.ToDecimal("1.00") },
            new RefTrimesterWhenPrenatalCareBegan { Id=Guid.Parse("3510d62f-2afc-4f1a-b6a0-98fd36f3a384"), Code="SecondTrimester", Description="Second trimester", SortOrder=Convert.ToDecimal("3.00") },
            new RefTrimesterWhenPrenatalCareBegan { Id=Guid.Parse("1ab404bf-917b-4319-938a-cb1b2559816b"), Code="ThirdTrimester", Description="Third trimester", SortOrder=Convert.ToDecimal("5.00") },
            new RefTrimesterWhenPrenatalCareBegan { Id=Guid.Parse("e52e6f4e-d596-4f3b-b35c-56dbf5025eb3"), Code="NoPrenatalHealthCare", Description="No prenatal health care", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
