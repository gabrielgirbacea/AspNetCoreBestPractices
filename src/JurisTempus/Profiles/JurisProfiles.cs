using AutoMapper;
using JurisTempus.Data.Entities;
using JurisTempus.ViewModels;

namespace JurisTempus.Profiles
{
  public class JurisProfiles : Profile
  {
    public JurisProfiles()
    {
      CreateMap<Client, ClientViewModel>()
        .ForMember(vm => vm.ContactName, o => o.MapFrom(c => c.Contact))
        .ForMember(vm => vm.Address1, o => o.MapFrom(c => c.Address.Address1))
        .ForMember(vm => vm.Address2, o => o.MapFrom(c => c.Address.Address2))
        .ForMember(vm => vm.Address3, o => o.MapFrom(c => c.Address.Address3))
        .ForMember(vm => vm.CityTown, o => o.MapFrom(c => c.Address.CityTown))
        .ForMember(vm => vm.StateProvince, o => o.MapFrom(c => c.Address.StateProvince))
        .ForMember(vm => vm.PostalCode, o => o.MapFrom(c => c.Address.PostalCode))
        .ForMember(vm => vm.Country, o => o.MapFrom(c => c.Address.Country))
        .ReverseMap();
    }
  }
}
