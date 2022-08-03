namespace Autobahn.Common.Interfaces;

public interface IAutobahnBase
{
    /// <summary>
    /// Has the ViewModelChanged?
    /// </summary>
    bool IsChanged { get; }

    /// <summary>
    /// True if the model is new and unsaved
    /// </summary>
    bool IsNew { get; set; }

    /// <summary>
    /// The Id of the ViewModel
    /// </summary>
    Guid Id { get; set; }
}