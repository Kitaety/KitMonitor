using AutoMapper;
using KitMonitor.Server.Models.Database.Entities;
using KitMonitor.Server.Models.Dto;
using KitMonitor.Shared.Models.Entities;

namespace KitMonitor.Server.AutoMappers
{
	public class CompanyAutoMapperProfile: Profile
	{
		public CompanyAutoMapperProfile()
		{
			CreateMap<CompanyDto, Company>().ReverseMap();
			CreateMap<ClientCompany, CompanyDto>().ReverseMap();
		}
	}
}
