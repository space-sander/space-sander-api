using System;
using System.Diagnostics;

namespace space.sander.web.Domain.Catalog
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class Rating
    {
        public int Id { get; set; }
        public int Star { get; set; }
        public string UserName { get; set; }
        public string Review { get; set; }
        
        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    public Rating(int star, string userName, string review)
    {
        if (star < 1 || star > 5)
        {
            throw new ArgumentException("Star rating must be an integer: 1, 2, 3, 4, or 5.");
        }

        if(string.IsNullOrEmpty(userName))
        {
            throw new ArgumentException("UserName cannot be null.");
        }

        this.Star = star;
        this.UserName = userName;
        this.Review = review;

        

    }
}
}

