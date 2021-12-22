using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusteriBilgiSistemi.Common
{
    public class Result
    {


        public Result()
        {
            this.IsSucceeded = false;
        }
        public bool IsSucceeded { get; set; }
        public string UserMessage { get; set; }
        public int ID { get; set; }
    }

    public class Result<T> : Result
    {
        public T TransactionResult { get; set; }
    }

    #region TestResult
    //public class ResultTest
    //{
    //    public ResultTest()
    //    {

    //    }
    //} 
    #endregion
}

