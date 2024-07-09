using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Exceptions.Types
{
    public class ValidationProblemDetails
    {
        public string Title { get; set; }
        public List<string> Errors { get; set; }
    }
}
