using AuctionService.Data;
using AuctionService.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionService;

public class DbInitializer
{
    public static void InitDb(WebApplication app)
    {
        using var scope = app.Services.CreateScope();

        SeedData(scope.ServiceProvider.GetService<AuctionDbContext>());
    }

    private static void SeedData(AuctionDbContext context)
    {
        context.Database.Migrate();

        if (context.Auctions.Any())
        {
            Console.WriteLine("Already have data - no need to seed");
            return;
        }

        var auctions = new List<Auction>()
        {
            new Auction
            {
                Id = Guid.Parse("afbee524-5972-4075-8800-7d1f9d7b0a0c"),
                Status = Status.Live,
                ReservePrice = 300,
                Seller = "abby",
                AuctionEnd = DateTime.UtcNow.AddDays(20),
                Item = new Item
                {
                    EventName = "ND v. Clemson Ticket",
                    EventTime = DateTime.UtcNow.AddDays(35),
                    Guest = "Irish & Tigers",
                    EventCategory = EventCategory.Sports,
                    ImageUrl = "https://cdn.pixabay.com/photo/2013/02/20/01/03/football-83513_1280.jpg"
                }
            },
            new Auction
            {
                Id = Guid.Parse("c8c3ec17-01bf-49db-82aa-1ef80b833a9f"),
                Status = Status.Live,
                ReservePrice = 1500,
                Seller = "catelyn",
                AuctionEnd = DateTime.UtcNow.AddDays(100),
                Item = new Item
                {
                    EventName = "2024 Anita.org GHC In-Person Ticket",
                    EventTime = DateTime.UtcNow.AddDays(365),
                    Guest = "GHC Sponsors & Employers",
                    EventCategory = EventCategory.Conference,
                    ImageUrl = "https://cdn.pixabay.com/photo/2018/08/10/15/43/woman-3597095_1280.jpg"
                }
            },
            new Auction
            {
                Id = Guid.Parse("bbab4d5a-8565-48b1-9450-5ac2a5c4a654"),
                Status = Status.Live,
                ReservePrice = 400,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(25),
                Item = new Item
                {
                    EventName = "2023 Escape Halloween",
                    EventTime = DateTime.UtcNow.AddDays(30),
                    Guest = "Afrojack, Zedd, Ed Rush, etc.",
                    EventCategory = EventCategory.Concert,
                    ImageUrl = "https://cdn.pixabay.com/photo/2016/11/22/18/56/audience-1850022_1280.jpg"
                }
            },
            new Auction
            {
                Id = Guid.Parse("8fbca6db-3491-4f37-932c-ecf77d3a98e2"),
                Status = Status.Live,
                ReservePrice = 30,
                Seller = "jake",
                AuctionEnd = DateTime.UtcNow.AddDays(40),
                Item = new Item
                {
                    EventName = "2023 Seattle Winter Intl Film Festival",
                    EventTime = DateTime.UtcNow.AddDays(40),
                    Guest = "Many indie filmmakers",
                    EventCategory = EventCategory.Film,
                    ImageUrl = "https://cdn.pixabay.com/photo/2013/11/28/10/02/camera-219958_1280.jpg"
                }
            },
            new Auction
            {
                Id = Guid.Parse("adecd784-2f68-4e93-9d7a-1bd6c9a05f01"),
                Status = Status.Live,
                ReservePrice = 200,
                Seller = "mae",
                AuctionEnd = DateTime.UtcNow.AddDays(150),
                Item = new Item
                {
                    EventName = "2024 PNW Yoga Week",
                    EventTime = DateTime.UtcNow.AddDays(160),
                    Guest = "Major studios in the PNW area",
                    EventCategory = EventCategory.Wellness,
                    ImageUrl = "https://cdn.pixabay.com/photo/2017/03/26/21/54/yoga-2176668_1280.jpg"
                }
            },
            new Auction
            {
                Id = Guid.Parse("c2b8e4fa-6a9f-4d2c-851e-9f7b3e60d8b5"),
                Status = Status.Live,
                ReservePrice = 30,
                Seller = "todd",
                AuctionEnd = DateTime.UtcNow.AddDays(19),
                Item = new Item
                {
                    EventName = "Leavenworth Fall Fest",
                    EventTime = DateTime.UtcNow.AddDays(23),
                    Guest = "Bavarian cultural experience",
                    EventCategory = EventCategory.HolidayandSeasonal,
                    ImageUrl = "https://cdn.pixabay.com/photo/2018/10/14/18/29/meatloaf-3747129_1280.jpg"
                }
            },
            new Auction
            {
                Id = Guid.Parse("6c5d8bfa-784e-41a9-9538-2d17c8e8b1fc"),
                Status = Status.Live,
                ReservePrice = 200,
                Seller = "yusuf",
                AuctionEnd = DateTime.UtcNow.AddDays(5),
                Item = new Item
                {
                    EventName = "Taylor Tomlinson Show",
                    EventTime = DateTime.UtcNow.AddDays(6),
                    Guest = "Taylor Tomlinson",
                    EventCategory = EventCategory.Comedy,
                    ImageUrl = "https://cdn.pixabay.com/photo/2020/03/28/19/06/comedy-4978258_1280.jpg"
                }
            },
            new Auction
            {
                Id = Guid.Parse("5da2b8c3-9e4d-1f7a-8c5d-36bf5b7a8d21"),
                Status = Status.Live,
                ReservePrice = 300,
                Seller = "lucy",
                AuctionEnd = DateTime.UtcNow.AddDays(21),
                Item = new Item
                {
                    EventName = "Seahawks v. Browns Ticket",
                    EventTime = DateTime.UtcNow.AddDays(27),
                    Guest = "Seahawks & Browns",
                    EventCategory = EventCategory.Sports,
                    ImageUrl = "https://cdn.pixabay.com/photo/2017/03/04/22/45/seattle-2117139_1280.jpg"
                }
            },
            new Auction
            {
                Id = Guid.Parse("b6e1d4f8-3ac5-4e96-7d2f-15bc9a2c8b4e"),
                Status = Status.Live,
                ReservePrice = 70,
                Seller = "bob",
                AuctionEnd = DateTime.UtcNow.AddDays(3),
                Item = new Item
                {
                    EventName = "Lake Wenatchee Camping Group",
                    EventTime = DateTime.UtcNow.AddDays(4),
                    Guest = "3/4 campsites filled",
                    EventCategory = EventCategory.Outdoor,
                    ImageUrl = "https://cdn.pixabay.com/photo/2014/11/27/18/36/tent-548022_1280.jpg"
                }
            },
            new Auction
            {
                Id = Guid.Parse("47fbc9e2-9a5d-14c8-62bf-3d1a5d8c7a9f"),
                Status = Status.Live,
                ReservePrice = 100,
                Seller = "edmond",
                AuctionEnd = DateTime.UtcNow.AddDays(13),
                Item = new Item
                {
                    EventName = "East Washington Wine Tasting Festival",
                    EventTime = DateTime.UtcNow.AddDays(17),
                    Guest = "Willamette Valley Vineyards",
                    EventCategory = EventCategory.FoodandWine,
                    ImageUrl = "https://cdn.pixabay.com/photo/2016/10/22/20/34/wines-1761613_1280.jpg"
                }
            }
        };

        context.AddRange(auctions);

        context.SaveChanges();
    }
}
