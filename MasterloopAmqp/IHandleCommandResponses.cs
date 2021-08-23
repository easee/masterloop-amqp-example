using System.Threading.Tasks;
using Masterloop.Core.Types.Commands;

namespace MasterloopAmqp
{
    public interface IHandleCommandResponses
    {
        bool CanHandle(CommandResponse commandResponse);
        Task Handle(string serialNumber, CommandResponse commandResponse);
    }
}