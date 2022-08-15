//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IPersonDegreeOrCertificate.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPersonDegreeOrCertificate Interface
     /// </summary>
    public partial interface IPersonDegreeOrCertificate : IAutobahnBase
    {
        /// <summary>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </summary>
        System.DateTime? AwardDate { get; set; }

    }
}
