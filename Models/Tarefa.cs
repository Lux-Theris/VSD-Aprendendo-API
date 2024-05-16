namespace TarefasApi.Models;

public class TarefaItem
{
    public long Id {get; set;}
    public string? Nome {get; set;}
    public bool Completa {get; set;}
    public DateTime DataEntrega {get; set;}
}