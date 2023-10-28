using System.ComponentModel.DataAnnotations;

namespace AuctionService.DTOs;

public class CreateAuctionDto
{
    [Required]
    public string EventName { get; set; }

    [Required]
    public DateTime EventTime { get; set; }

    [Required]
    public string Guest { get; set; }

    [Required]
    public string EventCategory { get; set; }

    [Required]
    public string ImageUrl { get; set; }

    [Required]
    public int ReservePrice {get; set; }

    [Required]
    public DateTime AuctionEnd {get; set; }
}
