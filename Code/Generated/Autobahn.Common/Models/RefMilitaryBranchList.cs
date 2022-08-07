//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefMilitaryBranchList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefMilitaryBranch Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMilitaryBranchModel"> List
         /// </summary>
        public static List<RefMilitaryBranchModel> RefMilitaryBranchList = new List<RefMilitaryBranchModel>
        {
            new RefMilitaryBranch { Id=Guid.Parse("b7174b10-d684-475a-9ab2-31147be87f5d"), Code="Army", Description="Army", Definition="U.S. Army", SortOrder=Convert.ToDecimal("1.00") },
            new RefMilitaryBranch { Id=Guid.Parse("b3a6b1cf-1dc3-4ccd-af88-49274307c936"), Code="MarineCorps", Description="Marine Corps", Definition="U.S. Marine Corps", SortOrder=Convert.ToDecimal("2.00") },
            new RefMilitaryBranch { Id=Guid.Parse("ea3c9f64-fece-4e5a-8204-6f4855ebd700"), Code="Navy", Description="Navy", Definition="U.S. Navy", SortOrder=Convert.ToDecimal("3.00") },
            new RefMilitaryBranch { Id=Guid.Parse("4c282a4d-2355-42cc-aca5-9582f36f1a87"), Code="AirForce", Description="Air Force", Definition="U.S.  Air Force", SortOrder=Convert.ToDecimal("4.00") },
            new RefMilitaryBranch { Id=Guid.Parse("04ab766f-3abe-4a4b-a684-5d8d0aa3c585"), Code="SpaceForce", Description="Space Force", Definition="U.S. Space Force", SortOrder=Convert.ToDecimal("5.00") },
            new RefMilitaryBranch { Id=Guid.Parse("afaf8c43-b494-4182-b2a0-085e399a0a94"), Code="CoastGuard", Description="Coast Guard", Definition="U.S. Coast Guard", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The Reference RefMilitaryBranch Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefMilitaryBranchViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefMilitaryBranch { Id=Guid.Parse("b7174b10-d684-475a-9ab2-31147be87f5d"), Description="Army", SortOrder=Convert.ToDecimal("1.00") },
            new RefMilitaryBranch { Id=Guid.Parse("b3a6b1cf-1dc3-4ccd-af88-49274307c936"), Description="Marine Corps", SortOrder=Convert.ToDecimal("2.00") },
            new RefMilitaryBranch { Id=Guid.Parse("ea3c9f64-fece-4e5a-8204-6f4855ebd700"), Description="Navy", SortOrder=Convert.ToDecimal("3.00") },
            new RefMilitaryBranch { Id=Guid.Parse("4c282a4d-2355-42cc-aca5-9582f36f1a87"), Description="Air Force", SortOrder=Convert.ToDecimal("4.00") },
            new RefMilitaryBranch { Id=Guid.Parse("04ab766f-3abe-4a4b-a684-5d8d0aa3c585"), Description="Space Force", SortOrder=Convert.ToDecimal("5.00") },
            new RefMilitaryBranch { Id=Guid.Parse("afaf8c43-b494-4182-b2a0-085e399a0a94"), Description="Coast Guard", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
