using System.ComponentModel;

namespace Azard.Common.Infrastructure.Interfaces
{
    public interface IQueryHandler<in TQuery, out TResult>
    {
        TResult Handle(TQuery query);
    }
}