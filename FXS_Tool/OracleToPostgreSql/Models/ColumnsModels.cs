using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OracleToPostgreSql.Models
{
    public class ColumnsModels
    {
        public class ColumnModel
        {
            [Column("TABLE_NAME")]
            public string TableName { get; set; }
            [Column("COLUMN_NAME")]
            public string ColumnName { get; set; }
            [Column("DATA_TYPE")]
            public string DataType { get; set; }
            [Column("DATA_LENGTH")]
            public string DataLength { get; set; }
            [Column("DATA_PRECISION")]
            public string DataPrecision { get; set; }
            [Column("NULLABLE")]
            public bool NullAble { get; set; }

        }
    }
}
