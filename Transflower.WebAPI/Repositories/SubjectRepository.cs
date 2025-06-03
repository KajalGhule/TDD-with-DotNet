using Transflower.WebAPI.Entities;

namespace Transflower.WebAPI.Repositories;

public class SubjectRepository : ISubjectRepository
{
    public IEnumerable<SubjectModel> GetAllSubjects()
    {
        Console.WriteLine("Fetching all subjects from the repository...");
        return new List<SubjectModel> {
            new SubjectModel { Id = 1, Title = "C#" },
            new SubjectModel { Id = 2, Title = "Java" }
        };
    }
}
