//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffTechnicalAssistanceModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The StaffTechnicalAssistance Model
     /// </summary>
    public partial class StaffTechnicalAssistanceModel : AutobahnBase, Interfaces.IStaffTechnicalAssistance
    {
        /// <summary>
        /// Indicates whether or not the technical assistance was approved.
        /// </summary>
        public System.Boolean? TechnicalAssistanceApprovedInd { get; set; }

    }
}
