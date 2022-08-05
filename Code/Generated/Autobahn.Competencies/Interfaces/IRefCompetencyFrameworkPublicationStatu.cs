//**********************************************************
//* DomainName: Autobahn.Competencies
//* FileName:   IRefCompetencyFrameworkPublicationStatu.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Competencies.Interfaces
{
     /// <summary>
     /// The RefCompetencyFrameworkPublicationStatu Interface
     /// </summary>
    public partial interface IRefCompetencyFrameworkPublicationStatu : IReferenceModel
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefCompetencyFrameworkPublicationStatus"/> model
        /// </summary>
        Guid RefCompetencyFrameworkPublicationStatusId { get; set; }

    }
}
