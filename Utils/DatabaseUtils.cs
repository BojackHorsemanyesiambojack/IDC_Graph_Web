using Npgsql;
using DotEnv;
using DotNetEnv;

namespace IDC_Web.Utils
{
    public interface DatabaseUtils
    {
        public static string GetDataBaseStringConnection()
        {
            Env.Load();
            var StringConnection = new NpgsqlConnectionStringBuilder
            {
                Host = Environment.GetEnvironmentVariable("PG_HOST"),
                Database = Environment.GetEnvironmentVariable("PG_DATABASE"),
                Port = Convert.ToInt32(Environment.GetEnvironmentVariable("PG_PORT")),
                Password = Environment.GetEnvironmentVariable("PG_PASSWORD"),
                Username = Environment.GetEnvironmentVariable("PG_ROLE"),
                SslMode = SslMode.VerifyFull
            }.ConnectionString;

            return StringConnection;
        }
    }
}
