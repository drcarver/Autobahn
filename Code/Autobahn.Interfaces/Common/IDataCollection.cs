//**********************************************************
//* DomainName: Autobahn.Interfaces.Common
//* FileName:   IDataCollection.cs
//**********************************************************

namespace Autobahn.Interfaces.Common;

public interface IDataCollection : IAutobahnBase
{
    string DataCollectionAcademicSchoolYear { get; set; }
    DateTime? DataCollectionCloseDate { get; set; }
    string DataCollectionDescription { get; set; }
    string DataCollectionName { get; set; }
    string DataCollectionSchoolYear { get; set; }
    string SourceSystemDataCollectionIdentifier { get; set; }
    string SourceSystemName { get; set; }
    DateTime? DataCollectionOpenDate { get; set; }
    Guid? RefDataCollectionStatusId { get; set; }

    /// <summary>
    /// The start date and, optionally, time that a record is active as used to support version control
    /// </summary>
    DateTime? RecordStartDateTime { get; set; }

    /// <summary>
    /// The end date and, optionally, time that a record is active as used to support version control.
    /// </summary>
    DateTime? RecordEndDateTime { get; set; }

    /// <summary>
    /// The record status 
    /// </summary>
    Guid? RecordStatusId { get; set; }
}