using Transflower.WebAPI.Entities;

namespace Transflower.WebAPI.Services;

public interface ISubjectService
{
    IEnumerable<SubjectModel> GetAllSubjects();
}
