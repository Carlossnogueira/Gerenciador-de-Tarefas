using GerenciadorDeTarefas.Communication.Enums;

namespace GerenciadorDeTarefas.Communication.Requests
{
    public class RequestTaskJson
    {
        public int Id {  get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public TaskPriority Priority { get; set; }
        public DateTime DateLimit { get; set; }
        public TaskStatus Status { get; set; }
    }
}
