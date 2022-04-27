using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using ORMLibrary.Abstract;

namespace RouteSystem.Users
{
    public class User : Entity
    {
        [BsonRepresentation(BsonType.String)]
        public string Login { get; set; }
        [BsonRepresentation(BsonType.String)]
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