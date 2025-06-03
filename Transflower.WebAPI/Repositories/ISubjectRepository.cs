using Transflower.WebAPI.Entities;

namespace Transflower.WebAPI.Repositories;

public interface ISubjectRepository
{
    IEnumerable<SubjectModel> GetAllSubjects();
}
