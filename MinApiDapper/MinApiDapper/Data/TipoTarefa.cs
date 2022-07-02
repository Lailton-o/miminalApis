using System.ComponentModel.DataAnnotations.Schema;

namespace MinApiDapper.Data
{
    [Table("TipoTarefa")]
    public record TipoTarefa(int Id, string Descricao);
}
