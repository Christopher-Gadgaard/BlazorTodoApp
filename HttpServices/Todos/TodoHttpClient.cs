using Domain.Contracts;
using Domain.Models;

namespace HttpServices.Todos;

public class TodoClients : ITodoHome
{
    public Task<ICollection<Todo>> GetAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Todo> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Todo> AddAsync(Todo todo)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Todo todo)
    {
        throw new NotImplementedException();
    }
}