using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Helper
{
    public class GenericResponseObject<T> where T : class
    {
        public T Data { get; set; }
        public int ErrorCode { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public int PageSize { get; set; }
    }
}
