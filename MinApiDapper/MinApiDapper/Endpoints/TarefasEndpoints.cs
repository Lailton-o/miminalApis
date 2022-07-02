using Dapper.Contrib.Extensions;
using MinApiDapper.Data;
using static MinApiDapper.Data.TarefaContext;

namespace MinApiDapper.Endpoints
{
    public static class TarefasEndpoints
    {
        public static void MapTarefasEndpoints(this WebApplication app)
        {
            app.MapGet("/", () => "Mini Tarefas API");

            app.MapGet("/tarefas", async (GetConnection connectionGetter) =>
            {
                using var con = await connectionGetter();
                return con.GetAll<Tarefa>().ToList();
            });

            app.MapGet("/tarefas/{id}", async (GetConnection connectionGetter, int id) =>
            {
                using var con = await connectionGetter();
                return con.Get<Tarefa>(id);
            });

            app.MapDelete("/tarefas/{id}", async (GetConnection connectionGetter, int id) =>
            {
                using var con = await connectionGetter();
                con.Delete(new Tarefa(id, "", ""));
                return Results.NoContent();
            });

            app.MapPost("/tarefas", async (GetConnection connectionGetter, Tarefa Tarefa) =>
            {
                using var con = await connectionGetter();
                var id = con.Insert(Tarefa);
                return Results.Created($"/tarefas/{id}", Tarefa);
            });

            app.MapPut("/tarefas", async (GetConnection connectionGetter, Tarefa Tarefa) =>
            {
                using var con = await connectionGetter();
                //var id = con.Update(Tarefa);
                return Results.Ok();
            });
        }
    }
}
