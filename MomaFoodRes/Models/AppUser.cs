using Microsoft.AspNetCore.Identity;

namespace MomaFoodRes.Models
{
    public class AppUser: IdentityUser
    {
        public ICollection<Order> Orders { get; set; }  
    }
}
