using System.ComponentModel.DataAnnotations.Schema;

namespace MinApiDapper.Data
{
    [Table("Tarefa")]
    public record Tarefa(int Id, string Atividade, string Status);
}
