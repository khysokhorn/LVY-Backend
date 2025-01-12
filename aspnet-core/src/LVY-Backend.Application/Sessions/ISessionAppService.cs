using Abp.Application.Services;
using LVY-Backend.Sessions.Dto;
using System.Threading.Tasks;

namespace LVY-Backend.Sessions;

public interface ISessionAppService : IApplicationService
{
    Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
}
