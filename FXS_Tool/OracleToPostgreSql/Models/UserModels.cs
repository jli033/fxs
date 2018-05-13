using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Oracle;
namespace OracleToPostgreSql.Models
{
    public class UserModels
    {
        [Table("T_USER")]
        public class UserModel
        {
            [Column("USERNAME")]
            public string UserName { get; set; }
        }
    }
}
