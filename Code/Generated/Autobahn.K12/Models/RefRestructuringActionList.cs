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
        /// The complete <see cref="RefRestructuringAction"> List
         /// </summary>
        public static List<RefRestructuringAction> RefRestructuringActionList = new List<RefRestructuringAction>
        {
            new RefRestructuringAction { Id=Guid.Parse("acb5940b-b837-4764-87f6-3607e930e5ba"), Code="RA1", Description="Replacement of all or most of the school staff (which may include the principal)", Definition="Replacement of all or most of the school staff (which may include the principal) is the type of actions being implemented in Title I schools as a result of the school being in an improvement status of restructuring - year 2 (implementation year).", SortOrder=Convert.ToDecimal("1.00") },
            new RefRestructuringAction { Id=Guid.Parse("0300c995-d589-43ff-98d0-8c7654354102"), Code="RA2", Description="Reopening the school as a public charter school", Definition="Reopening the school as a public charter school is the type of actions being implemented in Title I schools as a result of the school being in an improvement status of restructuring - year 2 (implementation year).", SortOrder=Convert.ToDecimal("2.00") },
            new RefRestructuringAction { Id=Guid.Parse("e7ab8a0e-f10d-4afc-be6d-b5df236a3b34"), Code="RA3", Description="Entering into a contract with a private entity to operate the school", Definition="Entering into a contract with a private entity to operate the school is the type of actions being implemented in Title I schools as a result of the school being in an improvement status of restructuring - year 2 (implementation year).", SortOrder=Convert.ToDecimal("3.00") },
            new RefRestructuringAction { Id=Guid.Parse("97ac6bb4-b9dd-4e38-9ef4-008a56ddff04"), Code="RA4", Description="Take of the school by the state", Definition="Take of the school by the state is the type of actions being implemented in Title I schools as a result of the school being in an improvement status of restructuring - year 2 (implementation year).", SortOrder=Convert.ToDecimal("4.00") },
            new RefRestructuringAction { Id=Guid.Parse("971c6072-dcb8-4247-a0f6-c33cf1af6a9e"), Code="RA5", Description="Other major restructuring of the school governance", Definition="Other major restructuring of the school governance is the type of actions being implemented in Title I schools as a result of the school being in an improvement status of restructuring - year 2 (implementation year).", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The RefRestructuringAction Pick List
         /// </summary>
        public static List<RefRestructuringAction> RefRestructuringActionPickList = new List<RefRestructuringAction>
        {
            new RefRestructuringAction { Id=Guid.Parse("acb5940b-b837-4764-87f6-3607e930e5ba"), Code="RA1", Description="Replacement of all or most of the school staff (which may include the principal)", SortOrder=Convert.ToDecimal("1.00") },
            new RefRestructuringAction { Id=Guid.Parse("0300c995-d589-43ff-98d0-8c7654354102"), Code="RA2", Description="Reopening the school as a public charter school", SortOrder=Convert.ToDecimal("2.00") },
            new RefRestructuringAction { Id=Guid.Parse("e7ab8a0e-f10d-4afc-be6d-b5df236a3b34"), Code="RA3", Description="Entering into a contract with a private entity to operate the school", SortOrder=Convert.ToDecimal("3.00") },
            new RefRestructuringAction { Id=Guid.Parse("97ac6bb4-b9dd-4e38-9ef4-008a56ddff04"), Code="RA4", Description="Take of the school by the state", SortOrder=Convert.ToDecimal("4.00") },
            new RefRestructuringAction { Id=Guid.Parse("971c6072-dcb8-4247-a0f6-c33cf1af6a9e"), Code="RA5", Description="Other major restructuring of the school governance", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
