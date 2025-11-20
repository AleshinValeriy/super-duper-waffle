using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Test
{
    public class InvalidParameterssExeption : Exception
    {
        public InvalidParameterssExeption(string message) : base(message) { }
    }
}
