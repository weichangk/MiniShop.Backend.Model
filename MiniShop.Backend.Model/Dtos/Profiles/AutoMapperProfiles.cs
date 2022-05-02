using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace MiniShop.Backend.Model.Dto.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<IdentityUser, UserDto>();
            CreateMap<UserCreateDto, IdentityUser>();
            CreateMap<IdentityUser, UserCreateDto>();
            CreateMap<UserUpdateDto, IdentityUser>();
            CreateMap<IdentityUser, UserUpdateDto>();
            CreateMap<UserDto, UserUpdateDto>();

            CreateMap<Shop, ShopDto>();
            CreateMap<ShopCreateDto, Shop>();
            CreateMap<ShopUpdateDto, Shop>();
            CreateMap<Shop, ShopCreateDto>();
            CreateMap<Shop, ShopUpdateDto>();
            CreateMap<ShopDto, ShopCreateDto>();
            CreateMap<ShopDto, ShopUpdateDto>();

            CreateMap<Store, StoreDto>();
            CreateMap<StoreCreateDto, Store>();
            CreateMap<StoreUpdateDto, Store>();
            CreateMap<Store, StoreCreateDto>();
            CreateMap<Store, StoreUpdateDto>();
            CreateMap<StoreDto, StoreCreateDto>();
            CreateMap<StoreDto, StoreUpdateDto>();

            CreateMap<Categorie, CategorieDto>();
            CreateMap<CategorieCreateDto, Categorie>();
            CreateMap<CategorieUpdateDto, Categorie>();
            CreateMap<Categorie, CategorieCreateDto>();
            CreateMap<Categorie, CategorieUpdateDto>();
            CreateMap<CategorieDto, CategorieCreateDto>();
            CreateMap<CategorieDto, CategorieUpdateDto>();

            CreateMap<Unit, UnitDto>();
            CreateMap<UnitCreateDto, Unit>();
            CreateMap<UnitUpdateDto, Unit>();
            CreateMap<Unit, UnitCreateDto>();
            CreateMap<Unit, UnitUpdateDto>();
            CreateMap<UnitDto, UnitCreateDto>();
            CreateMap<UnitDto, UnitUpdateDto>();

            CreateMap<Supplier, SupplierDto>();
            CreateMap<SupplierCreateDto, Supplier>();
            CreateMap<SupplierUpdateDto, Supplier>();
            CreateMap<Supplier, SupplierCreateDto>();
            CreateMap<Supplier, SupplierUpdateDto>();
            CreateMap<SupplierDto, SupplierCreateDto>();
            CreateMap<SupplierDto, SupplierUpdateDto>();

            CreateMap<Item, ItemDto>()
                .ForMember(d => d.CategorieName, opt => opt.MapFrom(i => i.Categorie.Name))
                .ForMember(d => d.UnitName, opt => opt.MapFrom(i => i.Unit.Name));
            CreateMap<ItemCreateDto, Item>();
            CreateMap<ItemUpdateDto, Item>();
            CreateMap<Item, ItemCreateDto>();
            CreateMap<Item, ItemUpdateDto>();
            CreateMap<ItemDto, ItemCreateDto>();
            CreateMap<ItemDto, ItemUpdateDto>();

            CreateMap<PurchaseOder, PurchaseOderDto>()
                .ForMember(d => d.SupplierName, opt => opt.MapFrom(i => i.Supplier.Name));
            CreateMap<PurchaseOderCreateDto, PurchaseOder>();
            CreateMap<PurchaseOderUpdateDto, PurchaseOder>();
            CreateMap<PurchaseOder, PurchaseOderCreateDto>();
            CreateMap<PurchaseOder, PurchaseOderUpdateDto>();
            CreateMap<PurchaseOderDto, PurchaseOderCreateDto>();
            CreateMap<PurchaseOderDto, PurchaseOderUpdateDto>();

            CreateMap<PurchaseOder, PurchaseOderAuditDto>();
            CreateMap<PurchaseOderDto, PurchaseOderAuditDto>();
            CreateMap<PurchaseOderAuditDto, PurchaseOder>();
            CreateMap<PurchaseOderAuditDto, PurchaseOderDto>();

            CreateMap<PurchaseOderItem, PurchaseOderItemDto>()
                .ForMember(d => d.ItemCode, opt => opt.MapFrom(i => i.Item.Code))
                .ForMember(d => d.ItemName, opt => opt.MapFrom(i => i.Item.Name))
                .ForMember(d => d.UnitName, opt => opt.MapFrom(i => i.Item.Unit.Name))
                .ForMember(d => d.PurchasePrice, opt => opt.MapFrom(i => i.Item.PurchasePrice));
            CreateMap<PurchaseOderItemCreateDto, PurchaseOderItem>();
            CreateMap<PurchaseOderItemUpdateDto, PurchaseOderItem>();
            CreateMap<PurchaseOderItem, PurchaseOderItemCreateDto>();
            CreateMap<PurchaseOderItem, PurchaseOderItemUpdateDto>();
            CreateMap<PurchaseOderItemDto, PurchaseOderItemCreateDto>();
            CreateMap<PurchaseOderItemDto, PurchaseOderItemUpdateDto>();

        }
    }
}
