//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingJointUserTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingJointUserType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingJointUserType"> List
         /// </summary>
        public static List<RefBuildingJointUserType> RefBuildingJointUserTypeList = new List<RefBuildingJointUserType>
        {
            new RefBuildingJointUserType { Id=Guid.Parse("694389f8-2240-4d99-a905-d2191af7f5da"), Code="13705", Description="Civic groups", Definition="Individuals, groups, or organizations, who seek occasional use of school buildings and grounds for activities or events such as polling stations, community meetings, and special events.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingJointUserType { Id=Guid.Parse("b1c2d07a-368f-4930-b445-417d6b17c847"), Code="13704", Description="Individuals", Definition="Persons, generally residents of a community, who have access to exterior spaces, such as play equipment, athletic fields or courts, and open space for personal use.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingJointUserType { Id=Guid.Parse("f98c0373-7d38-4268-83a1-552c90565a8e"), Code="13706", Description="Other public agencies", Definition="A public agency that is not part of the school district that may offer programs, need to lease space and offer no program connection to the school, and/or may seek joint development with ongoing joint programming.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingJointUserType { Id=Guid.Parse("443aff11-dabf-4ee5-bca6-276a110d491e"), Code="13708", Description="Private for-profit corporations", Definition="The use of school building and/or grounds by a private for-profit corporation, either for education-related work such as a private testing service or unrelated work such as private offices.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingJointUserType { Id=Guid.Parse("46d54a4a-a0b4-4cf8-88e8-435a766e6915"), Code="13707", Description="Private non-profit organizations", Definition="The use of school buildings and/or grounds by a non-profit organization such as after-school programs, health clinics, or adult education classes.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefBuildingJointUserType Pick List
         /// </summary>
        public static List<RefBuildingJointUserType> RefBuildingJointUserTypePickList = new List<RefBuildingJointUserType>
        {
            new RefBuildingJointUserType { Id=Guid.Parse("694389f8-2240-4d99-a905-d2191af7f5da"), Code="13705", Description="Civic groups", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingJointUserType { Id=Guid.Parse("b1c2d07a-368f-4930-b445-417d6b17c847"), Code="13704", Description="Individuals", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingJointUserType { Id=Guid.Parse("f98c0373-7d38-4268-83a1-552c90565a8e"), Code="13706", Description="Other public agencies", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingJointUserType { Id=Guid.Parse("443aff11-dabf-4ee5-bca6-276a110d491e"), Code="13708", Description="Private for-profit corporations", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingJointUserType { Id=Guid.Parse("46d54a4a-a0b4-4cf8-88e8-435a766e6915"), Code="13707", Description="Private non-profit organizations", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
