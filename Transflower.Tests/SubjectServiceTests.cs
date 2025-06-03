using Moq;
using Xunit;
using Transflower.WebAPI.Entities;
using Transflower.WebAPI.Services;
using Transflower.WebAPI.Repositories;

public class SubjectServiceTests
{
    [Fact]
    public void GetAllSubjects_ReturnsListOfSubjects()
    {
        // Arrange
        var mockRepo = new Mock<ISubjectRepository>();
        var subjects = new List<SubjectModel>
        {
            new SubjectModel { Id = 1, Title = "C#" },
            new SubjectModel { Id = 2, Title = "Java" }
        };

        mockRepo.Setup(r => r.GetAllSubjects()).Returns(subjects);
        var service = new SubjectService(mockRepo.Object);

        // Act
        var result = service.GetAllSubjects();

        // Assert
        Assert.Equal(2, result.Count());
        Assert.Contains(result, s => s.Title == "Java");
    }
}
