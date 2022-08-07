//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IRefPsEnrollmentActionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The RefPsEnrollmentAction Interface Model
     /// </summary>
    public partial interface IRefPsEnrollmentActionModel : IReferenceModel
    {
        /// <summary>
        /// Defines the RefPsEnrollmentAction.RefJurisdiction nullable property
        /// </summary>
        System.Int32? RefJurisdiction { get; set; }

    }
}
