using Moq;
using UserTicketService.Repository;

namespace UserTicketService.Tests;
public class UserRepositoryTests
{
    [Test]
    public static void FindAllShouldReturnCorrectValue()
    {
        var mock = new Mock<IUserRepository>();
        mock.Setup(m => m.FindAll()).Returns(new List<User>
        { new User { Name = "Антон"},
           new User { Name = "Иван"}, 
           new User {Name = "Алексей"} });

        Assert.That(mock.Object.FindAll().Any(user => user.Name == "Антон"));
        Assert.That(mock.Object.FindAll().Any(user => user.Name == "Иван"));
        Assert.That(mock.Object.FindAll().Any(user => user.Name == "Алексей"));
    }
}
