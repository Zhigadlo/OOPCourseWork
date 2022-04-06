using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace RouteSystem.Users
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        [BsonRepresentation(BsonType.String)]
        public Roles Role { get; set; }

        public User(string Login, string Password)
        {
            this.Login = Login;
            this.Password = Password;
        }

        public override string ToString()
        {
            return "Login: " + Login + "\nRole: " + Role.ToString();
        }
    }
}