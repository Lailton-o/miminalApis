using Dapper.Contrib.Extensions;
using MinApiDapper.Data;
using static MinApiDapper.Data.TarefaContext;

namespace MinApiDapper.Endpoints
{
    public static class TiposTarefaEndpoints
    {
        public static void MapTiposTarefaEndpoints(this WebApplication app)
        {
            app.MapGet("/tiposTarefa", async (GetConnection connectionGetter) =>
            {
                using var con = await connectionGetter();
                return con.GetAll<TipoTarefa>().ToList();
            });

            app.MapGet("/tiposTarefa/{id}", async (GetConnection connectionGetter, int id) =>
            {
                using var con = await connectionGetter();
                return con.Get<TipoTarefa>(id);
            });

            app.MapDelete("/tiposTarefa/{id}", async (GetConnection connectionGetter, int id) =>
            {
                using var con = await connectionGetter();
                con.Delete(new TipoTarefa(id, ""));
                return Results.NoContent();
            });

            app.MapPost("/tiposTarefa", async (GetConnection connectionGetter, TipoTarefa tipoTarefa) =>
            {
                using var con = await connectionGetter();
                var id = con.Insert(tipoTarefa);
                return Results.Created($"/tiposTarefa/{id}", tipoTarefa);
            });

            app.MapPut("/tiposTarefa", async (GetConnection connectionGetter, TipoTarefa Tarefa) =>
            {
                using var con = await connectionGetter();
                //var id = con.Update(Tarefa);
                return Results.Ok();
            });
        }
    }
}
