//**********************************************************
//* DomainName: Autobahn.Interfaces
//* FileName:   IReferenceBase.cs
//**********************************************************

namespace Autobahn.Interfaces;

public interface IReferenceBase : IAutobahnBase
{
    /// <summary>
    /// The description of the reference item 
    /// </summary>
    string Description { get; set; }

    /// <summary>
    /// The unique code for the reference item
    /// </summary>
    string Code { get; set; }

    /// <summary>
    /// The definition of the reference item
    /// </summary>
    string Definition { get; set; }

    /// <summary>
    /// The organization that owns the reference item
    /// </summary>
    Guid? RefJurisdictionId { get; set; }

    /// <summary>
    /// The sort order for the reference items
    /// </summary>
    decimal? SortOrder { get; set; }

    /// <summary>
    /// The Id of the Item
    /// </summary>
    Guid Id { get; set; }
}