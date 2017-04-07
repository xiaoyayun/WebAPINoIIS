using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Windows.Forms;

namespace WebAPi.Controller
{
    public class SignController:ApiController
    {
        [HttpGet]
        public int Get(int id)
        {
            MessageBox.Show(id.ToString());
            return id;
        }
    }
}
