using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionService.Entities;

[Table("Items")]
public class Item
{
    public Guid Id { get; set; }

    public string EventName { get; set; }

    public DateTime EventTime { get; set; }

    public string Guest { get; set; }

    public EventCategory EventCategory { get; set; }

    public string ImageUrl { get; set; }

    // nav properties
    public Auction Auction {get; set; }
    public Guid AuctionId { get; set; }
}
