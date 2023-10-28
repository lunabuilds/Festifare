namespace AuctionService.RequestHelpers;
using AuctionService.Entities;
using AuctionService.DTOs;
using AutoMapper;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Auction, AuctionDto>().IncludeMembers(x => x.Item);
        CreateMap<Item, AuctionDto>();
        CreateMap<CreateAuctionDto, Auction>()
            .ForMember(d => d.Item, o=>o.MapFrom(s => s));
        CreateMap<CreateAuctionDto, Item>();
    }

}
