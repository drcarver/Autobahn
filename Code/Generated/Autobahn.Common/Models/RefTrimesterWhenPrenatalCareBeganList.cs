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
        public static List<RefTrimesterWhenPrenatalCareBegan> RefTrimesterWhenPrenatalCareBeganList = new List<RefTrimesterWhenPrenatalCareBegan> =
        {
            new RefTrimesterWhenPrenatalCareBegan { Id=Guid.Parse("a5329f66-1b7b-4c7a-ae3a-4e6be84ae919"), Code="The  child's mother began receiving prenatal health care in the first trimester.", Description="FirstTrimester", Definition="", SortOrder=0 },
            new RefTrimesterWhenPrenatalCareBegan { Id=Guid.Parse("ba8717bf-e2c6-47d2-bd49-a0009434e524"), Code="The  child's mother began receiving prenatal health care in the second trimester.", Description="SecondTrimester", Definition="", SortOrder=0 },
            new RefTrimesterWhenPrenatalCareBegan { Id=Guid.Parse("c24edd8f-1118-402e-9a07-90d5b406cc53"), Code="The  child's mother began receiving prenatal health care in the third trimester.", Description="ThirdTrimester", Definition="", SortOrder=0 },
            new RefTrimesterWhenPrenatalCareBegan { Id=Guid.Parse("a35ad2b6-e1f8-42dd-be24-a9ef67782c5b"), Code="The  child's mother did not receive prenatal health care.", Description="NoPrenatalHealthCare", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefTrimesterWhenPrenatalCareBegan Pick List
         /// </summary>
        public static List<RefTrimesterWhenPrenatalCareBegan> RefTrimesterWhenPrenatalCareBeganPickList = new List<RefTrimesterWhenPrenatalCareBegan> =
        {
            new RefTrimesterWhenPrenatalCareBegan { Id=Guid.Parse("a5329f66-1b7b-4c7a-ae3a-4e6be84ae919"), Code="The  child's mother began receiving prenatal health care in the first trimester.", SortOrder=0 },
            new RefTrimesterWhenPrenatalCareBegan { Id=Guid.Parse("ba8717bf-e2c6-47d2-bd49-a0009434e524"), Code="The  child's mother began receiving prenatal health care in the second trimester.", SortOrder=0 },
            new RefTrimesterWhenPrenatalCareBegan { Id=Guid.Parse("c24edd8f-1118-402e-9a07-90d5b406cc53"), Code="The  child's mother began receiving prenatal health care in the third trimester.", SortOrder=0 },
            new RefTrimesterWhenPrenatalCareBegan { Id=Guid.Parse("a35ad2b6-e1f8-42dd-be24-a9ef67782c5b"), Code="The  child's mother did not receive prenatal health care.", SortOrder=0 },
       };
   }
}
