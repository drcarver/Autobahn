//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IReferenceModel.cs
//**********************************************************

namespace Autobahn.Interfaces.Common;

public interface IReferenceModel : IAutobahnBase
{
    /// <summary>
    /// Defines the Description non nullable property
    /// </summary>
    string Description { get; set; }

    /// <summary>
    /// Defines the Code non nullable property
    /// </summary>
    string Code { get; set; }

    /// <summary>
    /// Defines the Definition non nullable property
    /// </summary>
    string Definition { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="Organization"/> model
    /// </summary>
    Guid? RefJurisdictionId { get; set; }

    /// <summary>
    /// Defines the SortOrder nullable property
    /// </summary>
    decimal? SortOrder { get; set; }
}