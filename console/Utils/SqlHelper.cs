using SqlSugar;

namespace console.Utils;

public class SqlHelper
{
	public static SqlSugarClient GetClient() => new SqlSugarClient(new ConnectionConfig()
	{
		ConnectionString = @"DataSource=data.sqlite",
		DbType = DbType.Sqlite,
		IsAutoCloseConnection = true
	});
}