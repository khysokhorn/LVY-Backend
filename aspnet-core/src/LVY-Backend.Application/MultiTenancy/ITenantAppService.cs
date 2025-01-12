using Abp.Application.Services;
using LVY-Backend.MultiTenancy.Dto;

namespace LVY-Backend.MultiTenancy;

public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
{
}

