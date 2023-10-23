using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Todo_Grpc.Models
{
    public class TodoModel
    {
        public Guid Id { get; init; }
        public string Description { get; set; }
        public bool IsDone { get; private set; }

        public TodoModel()
        {
            Id =  Guid.NewGuid();
            IsDone = false;
        }

        public void ConcluirTarefa(){
            IsDone = true;
        }
    }
}