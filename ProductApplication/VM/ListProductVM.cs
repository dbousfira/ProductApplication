using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ProductApplication.VM
{
    public class ListProductVM : BaseVM
    {
        private ObservableCollection<ProductVM> _products = null;
        private ProductVM _selectedProduct = null;

        public ListProductVM()
        {
            _products = new ObservableCollection<ProductVM>();
        }

        public ObservableCollection<ProductVM> Products {
            get { return _products; }
            set
            {
                _products = value;
                OnPropertyChanged("Product");
            }
        }

        public ProductVM SelectedProduct
        {
            get { return _selectedProduct; }
            set
            {
                _selectedProduct = value;
                OnPropertyChanged("SelectedProduct");
            }
        }
    }
    
}
