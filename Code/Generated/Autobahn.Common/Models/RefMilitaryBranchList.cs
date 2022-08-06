//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefMilitaryBranchList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefMilitaryBranch Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMilitaryBranch"> List
         /// </summary>
        public static List<RefMilitaryBranch> RefMilitaryBranchList = new List<RefMilitaryBranch>
        {
            new RefMilitaryBranch { Id=Guid.Parse("10078be1-2842-4838-9e8a-8b4c9b5134da"), Code="Army", Description="Army", Definition="U.S. Army", SortOrder=Convert.ToDecimal("1.00") },
            new RefMilitaryBranch { Id=Guid.Parse("eb3109e4-5e27-4ec5-ac15-9850f4e93343"), Code="MarineCorps", Description="Marine Corps", Definition="U.S. Marine Corps", SortOrder=Convert.ToDecimal("2.00") },
            new RefMilitaryBranch { Id=Guid.Parse("838bae9a-ac36-4652-b2fc-16a707889532"), Code="Navy", Description="Navy", Definition="U.S. Navy", SortOrder=Convert.ToDecimal("3.00") },
            new RefMilitaryBranch { Id=Guid.Parse("781675cc-a502-4d8f-ae4d-ebb973ebcef3"), Code="AirForce", Description="Air Force", Definition="U.S.  Air Force", SortOrder=Convert.ToDecimal("4.00") },
            new RefMilitaryBranch { Id=Guid.Parse("8cf505a0-035d-41f2-83c0-bde469ff442a"), Code="SpaceForce", Description="Space Force", Definition="U.S. Space Force", SortOrder=Convert.ToDecimal("5.00") },
            new RefMilitaryBranch { Id=Guid.Parse("73368706-b03b-462f-8bd3-32ce88b6b864"), Code="CoastGuard", Description="Coast Guard", Definition="U.S. Coast Guard", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The RefMilitaryBranch Pick List
         /// </summary>
        public static List<RefMilitaryBranch> RefMilitaryBranchPickList = new List<RefMilitaryBranch>
        {
            new RefMilitaryBranch { Id=Guid.Parse("10078be1-2842-4838-9e8a-8b4c9b5134da"), Code="Army", Description="Army", SortOrder=Convert.ToDecimal("1.00") },
            new RefMilitaryBranch { Id=Guid.Parse("eb3109e4-5e27-4ec5-ac15-9850f4e93343"), Code="MarineCorps", Description="Marine Corps", SortOrder=Convert.ToDecimal("2.00") },
            new RefMilitaryBranch { Id=Guid.Parse("838bae9a-ac36-4652-b2fc-16a707889532"), Code="Navy", Description="Navy", SortOrder=Convert.ToDecimal("3.00") },
            new RefMilitaryBranch { Id=Guid.Parse("781675cc-a502-4d8f-ae4d-ebb973ebcef3"), Code="AirForce", Description="Air Force", SortOrder=Convert.ToDecimal("4.00") },
            new RefMilitaryBranch { Id=Guid.Parse("8cf505a0-035d-41f2-83c0-bde469ff442a"), Code="SpaceForce", Description="Space Force", SortOrder=Convert.ToDecimal("5.00") },
            new RefMilitaryBranch { Id=Guid.Parse("73368706-b03b-462f-8bd3-32ce88b6b864"), Code="CoastGuard", Description="Coast Guard", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
