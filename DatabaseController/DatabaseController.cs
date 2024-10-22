using MongoDB.Driver;
using MongoDB.Bson;
using LiveWeather.Models;
using LiveWeather.Components.Pages;

namespace LiveWeather.DatabaseController
{
    public class DatabaseController
    {
        public const string MONGO_URL = "mongodb+srv://dilanmelvin:dilanmelvin@liveweather.d2xbc.mongodb.net/";
        public static MongoClient client = new(MONGO_URL);

        public MongoClient GetClient()
        {
            return client;
        }

        public static IMongoCollection<User> GetUserCollection()
        {
            IMongoDatabase db = client.GetDatabase("Authentication");
            return db.GetCollection<User>("Users");
        }


        // Method to create a user item
        public Task<User> CreateAccount(User user)
        {
            GetUserCollection().InsertOne(user);
            return Task.FromResult(user);
        }

        //Find user by email
        public async Task<User> GetUserByEmail(string email)
        {
            User userItem = GetUserCollection().Find(user => user.Email == email).FirstOrDefault();
            return userItem;
        }

        public static IMongoCollection<Favourite> GetFavouriteCollection()
        {
            IMongoDatabase db = client.GetDatabase("weather");
            return db.GetCollection<Favourite>("favourites");
        }

        public Task<Favourite> AddToFavourite(Favourite favourite, ObjectId userId)
        {
            GetUserCollection().FindOneAndUpdate(user => user.Id == userId, Builders<User>.Update.Push(user => user.favourites, favourite));
            return Task.FromResult(favourite);
        }

        public Task<List<Favourite>> GetFavourites(ObjectId userId)
        {
            List<Favourite> favourites = GetUserCollection().Find<User>(user => user.Id == userId).FirstOrDefault().favourites;
            return Task.FromResult(favourites);
        }

        public Task<Favourite> GetFavourite(string cityName, ObjectId userId)
        {
            List<Favourite> favourites = GetUserCollection().Find(user => user.Id == userId).FirstOrDefault().favourites;
            return Task.FromResult(favourites.Find(fav => fav.City == cityName));
        }

        public Task<Favourite> RemoveFavourite(ObjectId userId, Favourite favourite)
        {
            GetUserCollection().FindOneAndUpdate(user => user.Id == userId, Builders<User>.Update.Pull(user => user.favourites, favourite));
            return Task.FromResult(favourite);
        }

    }
}
