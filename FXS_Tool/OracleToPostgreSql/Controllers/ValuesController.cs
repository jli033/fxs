using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Oracle.ManagedDataAccess.Client;
using Dapper;
using Dapper.Oracle;
using static OracleToPostgreSql.Models.UserModels;

namespace OracleToPostgreSql.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        const string ORACLE_CONNECTION_STRING 
            = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));User Id=C##orcl_jli033;Password=Lizikang2018;";
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            using(var conn = new OracleConnection(ORACLE_CONNECTION_STRING))
            {
                conn.Open();
                var sqlTables = @"SELECT * FROM all_tables WHERE owner = 'C##ORCL_JLI033'";
                var sqlColumns = @"SELECT * from all_tab_columns where owner = 'C##ORCL_JLI033'";
                var users = conn.Query<UserModel>(sqlTables);

                var us = users.ToList();
                conn.Close();
            }
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
