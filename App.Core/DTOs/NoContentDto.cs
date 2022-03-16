using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace App.Core.DTOs
{
    public class NoContentDto
    {
        [JsonIgnore]
        public List<string> Errors { get; set; }
        public int StatusCode { get; set; }


        public static NoContentDto Success(int statusCode)
        {
            return new NoContentDto { StatusCode=statusCode };
        }
        public static NoContentDto Fail(int statusCode, List<string> errors)
        {
            return new NoContentDto { StatusCode=statusCode, Errors=errors };
        }
        public static NoContentDto Fail(int statusCode, string error)
        {
            return new NoContentDto { StatusCode=statusCode, Errors=new List<string> { error } };
        }
    }
}
}
