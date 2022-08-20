//**********************************************************
//* DomainName: Autobahn.Interfaces
//* FileName:   IPickListItem.cs
//**********************************************************

namespace Autobahn.Interfaces;

public interface IPickListItem : IAutobahnBase
{
    /// <summary>
    /// The description of the Item
    /// </summary>
    string Description { get; set; }

    /// <summary>
    /// The unique code for the Item
    /// </summary>
    string Code { get; set; }

    /// <summary>
    /// The Sort Order for the Item
    /// </summary>
    decimal? SortOrder { get; set; }
}