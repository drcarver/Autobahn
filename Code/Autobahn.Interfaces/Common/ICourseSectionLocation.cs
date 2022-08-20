//**********************************************************
//* DomainName: Autobahn.Interfaces.Common
//* FileName:   ICourseSectionLocation.cs
//**********************************************************

namespace Autobahn.Interfaces.Common;

public interface ICourseSectionLocation : IAutobahnBase
{
    Guid ClassroomId { get; set; }
    Guid CourseSectionId { get; set; }
    Guid? RefInstructionLocationTypeId { get; set; }
}