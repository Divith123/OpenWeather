using LiveWeather.Models;
using Microsoft.AspNetCore.Components;

namespace LiveWeather.Singletons
{
    public class UserStateManager
    {
        public User? User { get; set; }
        public event Action? OnChange;
        public void SetUser(User user)
        {
            User = user;
            NotifyStateChanged();
        }
        public void NotifyStateChanged() => OnChange?.Invoke();

        public bool IsLoggedIn() => User != null;
    }
}
