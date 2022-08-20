//**********************************************************
//* DomainName: Autobahn.Interfaces
//* FileName:   IReferenceBase.cs
//**********************************************************

namespace Autobahn.Interfaces;

public interface IAutobahnBase
{
    /// <summary>
    /// The Id of the item
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Is the item deleted?
    /// </summary>
    public bool IsDeleted { get; set; }
}