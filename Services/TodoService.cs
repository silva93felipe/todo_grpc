using Grpc.Core;
using Todo_Grpc.Models;

namespace Todo_Grpc.Services;

public class TodoService : Todo.TodoBase
{
       private static List<TodoResponse> lisTodos = new List<TodoResponse>(){
            new TodoResponse(){
                Id = 1,
                Description = "Levar o lixo",
                IsDone = false
            },
            new TodoResponse(){
                Id = 2,
                Description = "Lavar a louça",
                IsDone = false
            },
            new TodoResponse(){
                Id = 3,
                Description = "Lavar a louça",
                IsDone = false
            },
        };

        private static TodoResponse taskTest = new TodoResponse(){
            Id = 1,
            Description = "Levar o lixo",
            IsDone = false
        };

    private readonly ILogger<TodoService> _logger;
    public TodoService(ILogger<TodoService> logger)
    {
        _logger = logger;
    }

    public override async TodoResponse GetAll(TodoRequest task, IServerStreamWriter<TodoResponse> responseStream, ServerCallContext context)
    {

       foreach (var t in lisTodos)
       {
            await responseStream.WriteAsync(t);
       }
    }
}
