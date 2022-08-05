//**********************************************************
//* DomainName: Autobahn.AdultEducation
//* FileName:   IRefAeStaffEmploymentStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.AdultEducation.Interfaces
{
     /// <summary>
     /// The RefAeStaffEmploymentStatu Interface
     /// </summary>
    public partial interface IRefAeStaffEmploymentStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefAeStaffEmploymentStatus"/> model
        /// </summary>
        Guid RefAeStaffEmploymentStatusId { get; set; }

    }
}
