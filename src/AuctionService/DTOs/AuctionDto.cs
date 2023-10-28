﻿namespace AuctionService.DTOs;

public class AuctionDto
{
    public Guid Id { get; set; }

    public int ReservePrice { get; set; } = 0;

    public string Seller { get; set; }

    public string Winner { get; set; }

    public int SoldAmount { get; set; }

    public int CurrentHighBid { get; set; }

    public DateTime CreatedAt { get; set; } 

    public DateTime UpdatedAt { get; set; }

    public DateTime AuctionEnd { get; set; }

    public string Status { get; set; }
    public string EventName { get; set; }

    public DateTime EventTime { get; set; }

    public string Guest { get; set; }

    public string EventCategory { get; set; }

    public string ImageUrl { get; set; }
}
