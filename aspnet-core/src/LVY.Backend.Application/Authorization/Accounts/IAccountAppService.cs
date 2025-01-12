using Abp.Application.Services;
using LVY.Backend.Authorization.Accounts.Dto;
using System.Threading.Tasks;

namespace LVY.Backend.Authorization.Accounts;

public interface IAccountAppService : IApplicationService
{
    Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

    Task<RegisterOutput> Register(RegisterInput input);
}
