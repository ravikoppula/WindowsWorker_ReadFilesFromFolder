using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using ConfigurationSettings = System.Configuration.ConfigurationManager;

namespace Demo.Services
{
    public interface IServiceB
    {
        void Run();
    }

    public class ServiceB : IServiceB
    {
        private readonly ILogger<ServiceB> _logger;
        private IConfiguration Configuration;

        public ServiceB(ILogger<ServiceB> logger, IConfiguration configuration)
        {
            _logger = logger;
            Configuration = configuration;
        }



        private SqlConnection con;
        private SqlCommand com;

        private void connection()
        {
            //string constr = System.Configuration.ConfigurationManager.ConnectionStrings["InitialDBConn"].ToString();
            string constr = this.Configuration.GetConnectionString("InitialDBConn");
            con = new SqlConnection(constr);


        }

        public void Run()
        {
            _logger.LogInformation("In Service B");

            connection();
            com = new SqlCommand("INSERT INTO [dbo].[tblEmployees] (EmployeeName, PhoneNumber, SkillID, YearsExperience) VALUES ('rrrApp', '1231231', 9, 10); ", con);
            
            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();

            _logger.LogInformation("New Employee Added Successfully");

        }
    }
}
