using Transflower.WebAPI.Entities;
using Transflower.WebAPI.Repositories;

namespace Transflower.WebAPI.Services;

public class SubjectService : ISubjectService
{
    private readonly ISubjectRepository _repo;

    public SubjectService(ISubjectRepository repo)
    {
        _repo = repo;
    }

    public IEnumerable<SubjectModel> GetAllSubjects()
    {
        return _repo.GetAllSubjects();
    }
}
