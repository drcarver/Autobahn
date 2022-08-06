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
        public static List<RefRestructuringAction> RefRestructuringActionList = new List<RefRestructuringAction> =
        {
            new RefRestructuringAction { Id=Guid.Parse("31553364-c9e5-48c8-b4fe-ef039c47d424"), Code="Replacement of all or most of the school staff (which may include the principal) is the type of actions being implemented in Title I schools as a result of the school being in an improvement status of restructuring - year 2 (implementation year).", Description="RA1", Definition="", SortOrder=0 },
            new RefRestructuringAction { Id=Guid.Parse("aa15e98b-397d-4ad9-a149-4c34b267b192"), Code="Reopening the school as a public charter school is the type of actions being implemented in Title I schools as a result of the school being in an improvement status of restructuring - year 2 (implementation year).", Description="RA2", Definition="", SortOrder=0 },
            new RefRestructuringAction { Id=Guid.Parse("990dfcab-10f7-4005-813e-b0d7cc196e42"), Code="Entering into a contract with a private entity to operate the school is the type of actions being implemented in Title I schools as a result of the school being in an improvement status of restructuring - year 2 (implementation year).", Description="RA3", Definition="", SortOrder=0 },
            new RefRestructuringAction { Id=Guid.Parse("4b192593-6f3a-42db-b54f-8438a62255d7"), Code="Take of the school by the state is the type of actions being implemented in Title I schools as a result of the school being in an improvement status of restructuring - year 2 (implementation year).", Description="RA4", Definition="", SortOrder=0 },
            new RefRestructuringAction { Id=Guid.Parse("8b918e48-b245-446e-b436-b0cb686ab2e5"), Code="Other major restructuring of the school governance is the type of actions being implemented in Title I schools as a result of the school being in an improvement status of restructuring - year 2 (implementation year).", Description="RA5", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefRestructuringAction Pick List
         /// </summary>
        public static List<RefRestructuringAction> RefRestructuringActionPickList = new List<RefRestructuringAction> =
        {
            new RefRestructuringAction { Id=Guid.Parse("31553364-c9e5-48c8-b4fe-ef039c47d424"), Code="Replacement of all or most of the school staff (which may include the principal) is the type of actions being implemented in Title I schools as a result of the school being in an improvement status of restructuring - year 2 (implementation year).", SortOrder=0 },
            new RefRestructuringAction { Id=Guid.Parse("aa15e98b-397d-4ad9-a149-4c34b267b192"), Code="Reopening the school as a public charter school is the type of actions being implemented in Title I schools as a result of the school being in an improvement status of restructuring - year 2 (implementation year).", SortOrder=0 },
            new RefRestructuringAction { Id=Guid.Parse("990dfcab-10f7-4005-813e-b0d7cc196e42"), Code="Entering into a contract with a private entity to operate the school is the type of actions being implemented in Title I schools as a result of the school being in an improvement status of restructuring - year 2 (implementation year).", SortOrder=0 },
            new RefRestructuringAction { Id=Guid.Parse("4b192593-6f3a-42db-b54f-8438a62255d7"), Code="Take of the school by the state is the type of actions being implemented in Title I schools as a result of the school being in an improvement status of restructuring - year 2 (implementation year).", SortOrder=0 },
            new RefRestructuringAction { Id=Guid.Parse("8b918e48-b245-446e-b436-b0cb686ab2e5"), Code="Other major restructuring of the school governance is the type of actions being implemented in Title I schools as a result of the school being in an improvement status of restructuring - year 2 (implementation year).", SortOrder=0 },
       };
   }
}
