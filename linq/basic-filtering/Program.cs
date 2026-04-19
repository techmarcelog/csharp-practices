using System.Formats.Tar;

public class Tarefa
{
    public int Id {get; set;}
    public string Titulo {get; set;}
    public bool Concluida {get; set;}
    public int Prioridade {get; set;}
}

class Program
{
    static void Main()
    {
        List<Tarefa> tarefas = new List<Tarefa>
        {
            new Tarefa { Id = 1, Titulo = "Estudar C#", Concluida = true, Prioridade = 2 },
            new Tarefa { Id = 2, Titulo = "Fazer exercícios", Concluida = false, Prioridade = 1 },
            new Tarefa { Id = 3, Titulo = "Estudar SQL", Concluida = true, Prioridade = 3 },
            new Tarefa { Id = 4, Titulo = "Criar API", Concluida = false, Prioridade = 1 },
            new Tarefa { Id = 5, Titulo = "Revisar LINQ", Concluida = true, Prioridade = 2 }
        };

        /*var concluidas = tarefas.Where(t => t.Concluida).ToList();
        foreach(var tarefa in concluidas)
        {
            Console.WriteLine($"\nTarefas concluídas: {tarefa.Titulo}");
        }*/

        /*var titulos = tarefas.Select(t => t.Titulo).ToList();
        foreach (var titulo in titulos)
        {
            Console.WriteLine(titulo);
        }*/
        /*var prioridade = tarefas.OrderBy(p => p.Titulo).ToList();
        foreach(var tarefa in prioridade)
        {
            Console.WriteLine($"Tarefa: {tarefa.Titulo} - Prioridade: {tarefa.Prioridade}");
        }*/

        /*var tarefa = tarefas.FirstOrDefault(i => i.Id == 6);

        if(tarefa != null)
        {
            Console.WriteLine($"Titulo: {tarefa.Titulo} - Id: {tarefa.Id}");
        }
        else
        {
            Console.WriteLine("Não foi encontrado");
        }*/

        /*bool naoConcluida = tarefas.Any(n => !n.Concluida);
        Console.Write($"Não concluída: {naoConcluida}");
        int total = tarefas.Count(t => t.Concluida);
        Console.WriteLine($"Total concluída: {total}"); */

        var pagina1 = tarefas.Take(2).ToList();
        foreach(var primeiro in pagina1)
        {
            Console.WriteLine($"\nPrimeira página: {primeiro.Titulo}");
        }
        var pagina2 = tarefas.Skip(2).Take(2).ToList();
        foreach(var segundo in pagina2)
        {
            Console.WriteLine($"\nSegunda página: {segundo.Titulo}");    
        }
    }
}