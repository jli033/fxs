using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Dapper.Oracle;
namespace OracleToPostgreSql.Models
{
    [Table("ALL_TABLES")]
    public class TablesModels
    {
        [Column("TABLE_NAME")]
        public string TableName { get; set; }
        [Column("TABLESPACE_NAME")]
        public string TableSpaceName { get; set; }
    }
}
