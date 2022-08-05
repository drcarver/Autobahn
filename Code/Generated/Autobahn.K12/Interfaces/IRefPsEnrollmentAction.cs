//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefPsEnrollmentAction.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefPsEnrollmentAction Interface
     /// </summary>
    public partial interface IRefPsEnrollmentAction : IReferenceModel
    {
        /// <summary>
        /// Defines the RefPsEnrollmentAction.RefJurisdiction nullable property
        /// </summary>
        System.Int32? RefJurisdiction { get; set; }

    }
}
