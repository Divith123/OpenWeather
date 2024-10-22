using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LiveWeather.Models
{
    public class Favourite
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
    }
}
