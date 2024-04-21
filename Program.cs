using System;
using System.Data.SQLite;
using System.Diagnostics;

class Program {
	static void Main() {
		string connectionString = "Data Source=:memory:"; // Using an in-memory database for benchmarking
		using (var connection = new SQLiteConnection(connectionString)) {
			connection.Open();

			// Create a table
			var command = new SQLiteCommand("CREATE TABLE data (id INTEGER PRIMARY KEY, value TEXT)", connection);
			command.ExecuteNonQuery();

			// Benchmark Insert Operation
			int insertCount = 1000000;
			var insertWatch = new Stopwatch();
			insertWatch.Start();
			using (var transaction = connection.BeginTransaction()) {
				for (int i = 0; i < insertCount; i++) {
					var insertCommand = new SQLiteCommand("INSERT INTO data (value) VALUES (@value)", connection);
					insertCommand.Parameters.AddWithValue("@value", "Sample Data " + i);
					insertCommand.ExecuteNonQuery();
				}
				transaction.Commit();
			}
			insertWatch.Stop();
			Console.WriteLine($"Time to insert {insertCount} records: {insertWatch.ElapsedMilliseconds} ms");

			// Benchmark Read Operation
			int readCount = insertCount;
			var readWatch = new Stopwatch();
			readWatch.Start();
			command = new SQLiteCommand("SELECT * FROM data", connection);
			using (var reader = command.ExecuteReader()) {
				while (reader.Read()) {
					var id = reader.GetInt32(0);
					var value = reader.GetString(1);
				}
			}
			readWatch.Stop();
			Console.WriteLine($"Time to read {readCount} records: {readWatch.ElapsedMilliseconds} ms");

			connection.Close();
		}
	}
}
