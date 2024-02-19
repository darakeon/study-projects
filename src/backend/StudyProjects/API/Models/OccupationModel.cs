using Npgsql;

namespace API.Models;

public class OccupationModel
{
	public OccupationModel(Int32 id, String task, DateTime start, DateTime end)
	{
		ID = id;
		Task = task;
		Start = start;
		End = end;
	}

	public Int32 ID { get; set; }
	public String Task { get; set; }
	public DateTime Start { get; set; }
	public DateTime End { get; set; }

	public void Save()
	{
		// Configuração para conectar no banco de dados
		var connectionString = 
			"Host=localhost;Database=study-projects;Username=user;Password=password";

		// Conexão com o banco sendo criada
		var dataSource = NpgsqlDataSource.Create(connectionString);

		// Query (código SQL) para inserir novos Occupations no banco
		var insertQuery = "INSERT INTO Occupations (\"Task\", \"Start\", \"End\")" +
		                  "    VALUES (@task, @start, @end)";

		// Criação do comando para executar o SQL de insert
		var command = dataSource.CreateCommand(insertQuery);
		
		// Associando dados da query acima com os dados do Model Occupation
		command.Parameters.AddWithValue("@task", Task);
		command.Parameters.AddWithValue("@start", Start);
		command.Parameters.AddWithValue("@end", End);

		// Executando o insert no banco de dados
		command.ExecuteNonQuery();
	}
}
