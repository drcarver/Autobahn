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
        public static List<RefMilitaryBranch> RefMilitaryBranchList = new List<RefMilitaryBranch> =
        {
            new RefMilitaryBranch { Id=Guid.Parse("566432d4-2c7f-4615-a5d0-ac39d273eedf"), Code="U.S. Army", Description="Army", Definition="", SortOrder=0 },
            new RefMilitaryBranch { Id=Guid.Parse("175bc92f-b5a4-4a61-96f6-3830c1cff3ce"), Code="U.S. Marine Corps", Description="MarineCorps", Definition="", SortOrder=0 },
            new RefMilitaryBranch { Id=Guid.Parse("a87a0098-3f02-4504-aea9-97341f690bb9"), Code="U.S. Navy", Description="Navy", Definition="", SortOrder=0 },
            new RefMilitaryBranch { Id=Guid.Parse("be90940a-d8f7-4748-8d0c-d924c808a243"), Code="U.S.  Air Force", Description="AirForce", Definition="", SortOrder=0 },
            new RefMilitaryBranch { Id=Guid.Parse("34648452-ff65-49df-a92d-b40486cb5772"), Code="U.S. Space Force", Description="SpaceForce", Definition="", SortOrder=0 },
            new RefMilitaryBranch { Id=Guid.Parse("c5877a66-6170-4e2f-b068-1d56ef65acb2"), Code="U.S. Coast Guard", Description="CoastGuard", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefMilitaryBranch Pick List
         /// </summary>
        public static List<RefMilitaryBranch> RefMilitaryBranchPickList = new List<RefMilitaryBranch> =
        {
            new RefMilitaryBranch { Id=Guid.Parse("566432d4-2c7f-4615-a5d0-ac39d273eedf"), Code="U.S. Army", SortOrder=0 },
            new RefMilitaryBranch { Id=Guid.Parse("175bc92f-b5a4-4a61-96f6-3830c1cff3ce"), Code="U.S. Marine Corps", SortOrder=0 },
            new RefMilitaryBranch { Id=Guid.Parse("a87a0098-3f02-4504-aea9-97341f690bb9"), Code="U.S. Navy", SortOrder=0 },
            new RefMilitaryBranch { Id=Guid.Parse("be90940a-d8f7-4748-8d0c-d924c808a243"), Code="U.S.  Air Force", SortOrder=0 },
            new RefMilitaryBranch { Id=Guid.Parse("34648452-ff65-49df-a92d-b40486cb5772"), Code="U.S. Space Force", SortOrder=0 },
            new RefMilitaryBranch { Id=Guid.Parse("c5877a66-6170-4e2f-b068-1d56ef65acb2"), Code="U.S. Coast Guard", SortOrder=0 },
       };
   }
}
