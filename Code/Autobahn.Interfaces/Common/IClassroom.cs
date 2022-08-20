//**********************************************************
//* DomainName: Autobahn.Interfaces.Common
//* FileName:   IClassroom.cs
//**********************************************************

namespace Autobahn.Interfaces.Common;

public interface IClassroom : IAutobahnBase
{
    Guid LocationId { get; set; }
    string ClassroomIdentifier { get; set; }
}