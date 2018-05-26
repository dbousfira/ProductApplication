using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using BusinessLayer;
using Entities;

namespace ProductApplication.VM
{
    public class ListProductVM : BaseVM
    {
        private ObservableCollection<ProductVM> _products = null;
        private ProductVM _selectedProduct = null;

        public ListProductVM()
        {
            _products = new ObservableCollection<ProductVM>();
            Manager.Instance.CreateProduct(new Product());
            foreach (Product p in Manager.Instance.GetAllProduct())
            {
                _products.Add(new ProductVM(p));
            }

            if (_products != null && _products.Count > 0)
                _selectedProduct = _products.ElementAt(0);
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
