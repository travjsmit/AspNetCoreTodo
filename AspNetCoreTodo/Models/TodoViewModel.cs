namespace AspNetCoreTodo.Models
{
    public class TodoViewModel
    {
        public TodoItem[] Items { get; set; }
        public TodoViewModel()
        {
            Items = Array.Empty<TodoItem>();
        }
    }
}