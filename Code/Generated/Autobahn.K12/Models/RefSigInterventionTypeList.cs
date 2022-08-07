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
        /// The complete <see cref="RefSigInterventionTypeModel"> List
         /// </summary>
        public static List<RefSigInterventionTypeModel> RefSigInterventionTypeList = new List<RefSigInterventionTypeModel>
        {
            new RefSigInterventionType { Id=Guid.Parse("63d72b0b-8dcb-4348-92b7-23f96f8ea842"), Code="Turnaround", Description="Turnaround model", Definition="Turnaround model is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=Convert.ToDecimal("1.00") },
            new RefSigInterventionType { Id=Guid.Parse("0aec97bf-fa82-4bfd-8cea-1508ebcb3f87"), Code="Restart", Description="Restart model", Definition="Restart model is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=Convert.ToDecimal("2.00") },
            new RefSigInterventionType { Id=Guid.Parse("e886556a-f3ba-4145-b58d-7ccfe08124d5"), Code="Closure", Description="School closure model", Definition="School closure model is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=Convert.ToDecimal("3.00") },
            new RefSigInterventionType { Id=Guid.Parse("35d884d0-9100-46a5-a6ea-388b522efaa7"), Code="Transformation", Description="Transformation model", Definition="Transformation model is the type of intervention used by the school under the School Improvement Grant (SIG).", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefSigInterventionType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefSigInterventionTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefSigInterventionType { Id=Guid.Parse("63d72b0b-8dcb-4348-92b7-23f96f8ea842"), Description="Turnaround model", SortOrder=Convert.ToDecimal("1.00") },
            new RefSigInterventionType { Id=Guid.Parse("0aec97bf-fa82-4bfd-8cea-1508ebcb3f87"), Description="Restart model", SortOrder=Convert.ToDecimal("2.00") },
            new RefSigInterventionType { Id=Guid.Parse("e886556a-f3ba-4145-b58d-7ccfe08124d5"), Description="School closure model", SortOrder=Convert.ToDecimal("3.00") },
            new RefSigInterventionType { Id=Guid.Parse("35d884d0-9100-46a5-a6ea-388b522efaa7"), Description="Transformation model", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
