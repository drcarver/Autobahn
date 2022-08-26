//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IReferenceModel.cs
//**********************************************************

namespace Autobahn.Common.Interfaces;

public interface IReferenceModel : IAutobahnBase
{
    /// <summary>
    /// Defines the Description non nullable property
    /// </summary>
    System.String Description { get; set; }

    /// <summary>
    /// Defines the Code non nullable property
    /// </summary>
    System.String Code { get; set; }

    /// <summary>
    /// Defines the Definition non nullable property
    /// </summary>
    System.String Definition { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="Organization"/> model
    /// </summary>
    Guid? RefJurisdictionId { get; set; }

    /// <summary>
    /// Defines the SortOrder nullable property
    /// </summary>
    System.Decimal? SortOrder { get; set; }
}