using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace ProductApplication.VM
{
    public class ProductVM : BaseVM
    {
        private string _code;
        private string _name;

        public ProductVM(Product p)
        {
            _code = p.Code;
            _name = p.Name;
        }

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
