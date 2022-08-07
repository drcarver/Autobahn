//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefRestructuringActionList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefRestructuringAction Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefRestructuringActionModel"> List
         /// </summary>
        public static List<RefRestructuringActionModel> RefRestructuringActionList = new List<RefRestructuringActionModel>
        {
            new RefRestructuringAction { Id=Guid.Parse("d97a8983-c557-4488-a9da-2aed9bbf4a91"), Code="RA1", Description="Replacement of all or most of the school staff (which may include the principal)", Definition="Replacement of all or most of the school staff (which may include the principal) is the type of actions being implemented in Title I schools as a result of the school being in an improvement status of restructuring - year 2 (implementation year).", SortOrder=Convert.ToDecimal("1.00") },
            new RefRestructuringAction { Id=Guid.Parse("28b8a3e3-3235-41a9-a43b-7e74642efdc7"), Code="RA2", Description="Reopening the school as a public charter school", Definition="Reopening the school as a public charter school is the type of actions being implemented in Title I schools as a result of the school being in an improvement status of restructuring - year 2 (implementation year).", SortOrder=Convert.ToDecimal("2.00") },
            new RefRestructuringAction { Id=Guid.Parse("d8436ab0-436a-44ed-9387-079e9b89795b"), Code="RA3", Description="Entering into a contract with a private entity to operate the school", Definition="Entering into a contract with a private entity to operate the school is the type of actions being implemented in Title I schools as a result of the school being in an improvement status of restructuring - year 2 (implementation year).", SortOrder=Convert.ToDecimal("3.00") },
            new RefRestructuringAction { Id=Guid.Parse("4dc4f48a-ea86-437a-aa56-37d1e1ee0235"), Code="RA4", Description="Take of the school by the state", Definition="Take of the school by the state is the type of actions being implemented in Title I schools as a result of the school being in an improvement status of restructuring - year 2 (implementation year).", SortOrder=Convert.ToDecimal("4.00") },
            new RefRestructuringAction { Id=Guid.Parse("2d9d70b4-7167-4a02-85af-0de600146bdb"), Code="RA5", Description="Other major restructuring of the school governance", Definition="Other major restructuring of the school governance is the type of actions being implemented in Title I schools as a result of the school being in an improvement status of restructuring - year 2 (implementation year).", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefRestructuringAction Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefRestructuringActionViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefRestructuringAction { Id=Guid.Parse("d97a8983-c557-4488-a9da-2aed9bbf4a91"), Description="Replacement of all or most of the school staff (which may include the principal)", SortOrder=Convert.ToDecimal("1.00") },
            new RefRestructuringAction { Id=Guid.Parse("28b8a3e3-3235-41a9-a43b-7e74642efdc7"), Description="Reopening the school as a public charter school", SortOrder=Convert.ToDecimal("2.00") },
            new RefRestructuringAction { Id=Guid.Parse("d8436ab0-436a-44ed-9387-079e9b89795b"), Description="Entering into a contract with a private entity to operate the school", SortOrder=Convert.ToDecimal("3.00") },
            new RefRestructuringAction { Id=Guid.Parse("4dc4f48a-ea86-437a-aa56-37d1e1ee0235"), Description="Take of the school by the state", SortOrder=Convert.ToDecimal("4.00") },
            new RefRestructuringAction { Id=Guid.Parse("2d9d70b4-7167-4a02-85af-0de600146bdb"), Description="Other major restructuring of the school governance", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
