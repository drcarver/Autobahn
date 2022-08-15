//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELProgramLicensing.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELProgramLicensing Interface
     /// </summary>
    public partial interface IELProgramLicensing : IAutobahnBase
    {
        /// <summary>
        /// The year, month and day on which a program or center received its initial license.
        /// </summary>
        System.DateTime? InitialLicenseDate { get; set; }

    }
}
