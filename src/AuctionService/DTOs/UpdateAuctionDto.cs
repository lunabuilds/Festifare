namespace AuctionService.DTOs;

public class UpdateAuctionDto
{
    public string EventName { get; set; }

    public DateTime? EventTime { get; set; }

    public string Guest { get; set; }

    public string EventCategory { get; set; }
}
