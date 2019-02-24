using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DbResponse
    {
        public int RowsAffected { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
