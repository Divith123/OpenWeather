using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LiveWeather.Models
{
    public class User
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Favourite> favourites { get; set; }
        public User(string email, string password, List<Favourite> favourites) 
        {
            this.Email = email;
            this.Password = password;
            this.favourites = favourites;
        }

    }
}
