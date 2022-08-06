//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefSigInterventionTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefSigInterventionType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefSigInterventionType"> List
         /// </summary>
        public static List<RefSigInterventionType> RefSigInterventionTypeList = new List<RefSigInterventionType> =
        {
            new RefSigInterventionType { Id=Guid.Parse("1090c7e9-2e3e-4c20-8faa-c7d8f51661d8"), Code="Turnaround model is the type of intervention used by the school under the School Improvement Grant (SIG).", Description="Turnaround", Definition="", SortOrder=0 },
            new RefSigInterventionType { Id=Guid.Parse("297b2770-3828-433e-bc28-1f475b90f889"), Code="Restart model is the type of intervention used by the school under the School Improvement Grant (SIG).", Description="Restart", Definition="", SortOrder=0 },
            new RefSigInterventionType { Id=Guid.Parse("80edfa3d-47f9-47f4-90ae-a39c7db8ecc5"), Code="School closure model is the type of intervention used by the school under the School Improvement Grant (SIG).", Description="Closure", Definition="", SortOrder=0 },
            new RefSigInterventionType { Id=Guid.Parse("2c419893-53df-40fe-a6f2-c2f228aa35a6"), Code="Transformation model is the type of intervention used by the school under the School Improvement Grant (SIG).", Description="Transformation", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefSigInterventionType Pick List
         /// </summary>
        public static List<RefSigInterventionType> RefSigInterventionTypePickList = new List<RefSigInterventionType> =
        {
            new RefSigInterventionType { Id=Guid.Parse("1090c7e9-2e3e-4c20-8faa-c7d8f51661d8"), Code="Turnaround model is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=0 },
            new RefSigInterventionType { Id=Guid.Parse("297b2770-3828-433e-bc28-1f475b90f889"), Code="Restart model is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=0 },
            new RefSigInterventionType { Id=Guid.Parse("80edfa3d-47f9-47f4-90ae-a39c7db8ecc5"), Code="School closure model is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=0 },
            new RefSigInterventionType { Id=Guid.Parse("2c419893-53df-40fe-a6f2-c2f228aa35a6"), Code="Transformation model is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=0 },
       };
   }
}
