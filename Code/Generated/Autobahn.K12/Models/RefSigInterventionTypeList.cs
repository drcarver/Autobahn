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
        public static List<RefSigInterventionType> RefSigInterventionTypeList = new List<RefSigInterventionType>
        {
            new RefSigInterventionType { Id=Guid.Parse("5f0882d1-5899-46e3-ae55-8de27d436a5e"), Code="Turnaround", Description="Turnaround model", Definition="Turnaround model is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=Convert.ToDecimal("1.00") },
            new RefSigInterventionType { Id=Guid.Parse("838c15d5-5190-4146-a9ae-aaf939bb1fce"), Code="Restart", Description="Restart model", Definition="Restart model is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=Convert.ToDecimal("2.00") },
            new RefSigInterventionType { Id=Guid.Parse("17c0416c-4161-47a6-8164-066b4a24f983"), Code="Closure", Description="School closure model", Definition="School closure model is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=Convert.ToDecimal("3.00") },
            new RefSigInterventionType { Id=Guid.Parse("4347cd86-4095-4962-b40e-763eed30e385"), Code="Transformation", Description="Transformation model", Definition="Transformation model is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefSigInterventionType Pick List
         /// </summary>
        public static List<RefSigInterventionType> RefSigInterventionTypePickList = new List<RefSigInterventionType>
        {
            new RefSigInterventionType { Id=Guid.Parse("5f0882d1-5899-46e3-ae55-8de27d436a5e"), Code="Turnaround", Description="Turnaround model", SortOrder=Convert.ToDecimal("1.00") },
            new RefSigInterventionType { Id=Guid.Parse("838c15d5-5190-4146-a9ae-aaf939bb1fce"), Code="Restart", Description="Restart model", SortOrder=Convert.ToDecimal("2.00") },
            new RefSigInterventionType { Id=Guid.Parse("17c0416c-4161-47a6-8164-066b4a24f983"), Code="Closure", Description="School closure model", SortOrder=Convert.ToDecimal("3.00") },
            new RefSigInterventionType { Id=Guid.Parse("4347cd86-4095-4962-b40e-763eed30e385"), Code="Transformation", Description="Transformation model", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
