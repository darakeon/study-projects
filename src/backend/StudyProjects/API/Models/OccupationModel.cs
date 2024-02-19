using Npgsql;
// ReSharper disable All

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

	public static List<OccupationModel> GetAll()
	{
		// Configuração para conectar no banco de dados
		var connectionString =
			"Host=localhost;Database=study-projects;Username=user;Password=password";

		// Conexão com o banco sendo criada
		var dataSource = NpgsqlDataSource.Create(connectionString);

		// Query (código SQL) para buscar os Occupations do banco
		var selectQuery = "SELECT * FROM Occupations";

		// Criação do comando para executar o SQL de select
		var command = dataSource.CreateCommand(selectQuery);

		// Executando o select no banco de dados
		var reader = command.ExecuteReader();

		// Criação de uma lista para colocar as Occupations dentro
		var list = new List<OccupationModel>();

		// Pega as posições das colunas na tabela usando o nome da coluna
		var columnId = reader.GetOrdinal("ID");
		var columnTask = reader.GetOrdinal("Task");
		var columnStart = reader.GetOrdinal("Start");
		var columnEnd = reader.GetOrdinal("End");

		// Leitura de cada uma das linhas que vieram do banco de dados
		while (reader.Read())
		{
			// cria um novo Occupation com os dados que vieram da tabela
			var occupation = new OccupationModel(
				reader.GetInt32(columnId),
				reader.GetString(columnTask),
				reader.GetDateTime(columnStart),
				reader.GetDateTime(columnEnd)
			);

			// adiciona o occupation na lista que será nosso resultado
			list.Add(occupation);
		}

		return list;
	}
}
