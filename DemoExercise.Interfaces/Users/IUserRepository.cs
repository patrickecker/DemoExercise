using DemoExercise.Models;

namespace DemoExercise.Interfaces.Users

{
    public interface IUserRepository
    {
        bool login();
        bool logout();
        //getUserInformation(); // TODO => get all user information for use in app, profile, header, user management;
    }
}
