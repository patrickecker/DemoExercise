using System.ComponentModel.DataAnnotations;

namespace DemoExercise.Models
{
    public class UserModel
    {
        public int id;
        [Required]
        public string userName;
        public string firstName;
        public string lastName;
        [Required, DataType(DataType.EmailAddress)]
        public string emailAddress;
        [Required, DataType(DataType.Password)]
        public string password;
        public bool isActive;
    }

}
