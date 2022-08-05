//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefStudentSchoolAffiliationStateDefinedStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefStudentSchoolAffiliationStateDefinedStatu Interface
     /// </summary>
    public partial interface IRefStudentSchoolAffiliationStateDefinedStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefStudentSchoolAffiliationStateDefinedStatus"/> model
        /// </summary>
        Guid RefStudentSchoolAffiliationStateDefinedStatusId { get; set; }

    }
}
