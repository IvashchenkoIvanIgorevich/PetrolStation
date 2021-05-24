using PetrolStation.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace PetrolStation.ViewModel
{
    public class PetrolStationViewModel : INotifyPropertyChanged
    {
        //string _categoryName;
        //string _subCategoryName;
        string _productName;

        ObservableCollection<Category> _categories;
        ObservableCollection<Category> _subCategories;

        List<Category> _subCategoryCmb;

        Category _selectedCategory;
        Category _selectedSubCategory;
        bool _isEnTxtProduct;
        bool _isEnabledSubCatCmb;

        public PetrolStationViewModel()
        {
            Categories = new ObservableCollection<Category>();
            SubCategories = new ObservableCollection<Category>();

            Category carSubCategory = new Category(null) { Name = "carSubCategory_1" };
            Category foodSubCategory = new Category(null) { Name = "foodSubCategory_1" };
            Category toySubCategory = new Category(null) { Name = "toySubCategory_1" };

            Product carProduct_1 = new Product(carSubCategory) { Name = "carProduct_1" };
            Product carProduct_2 = new Product(carSubCategory) { Name = "carProduct_2" };
            Product carProduct_3 = new Product(carSubCategory) { Name = "carProduct_3" };

            Product foodProduct_1 = new Product(foodSubCategory) { Name = "foodProduct_1" };
            Product foodProduct_2 = new Product(foodSubCategory) { Name = "foodProduct_2" };

            Product toyProduct_1 = new Product(toySubCategory) { Name = "toyProduct_1" };
            Product toyProduct_2 = new Product(toySubCategory) { Name = "toyProduct_2" };

            Category carCategory = new Category(new List<Category> { carSubCategory }) { Name = "CarCategory" };
            Category foodCategory = new Category(new List<Category> { foodSubCategory }) { Name = "FoodCategory" };
            Category toyCategory = new Category(new List<Category> { toySubCategory }) { Name = "ToyCategory" };

            Categories.Add(carCategory);
            Categories.Add(foodCategory);
            Categories.Add(toyCategory);

            SubCategories.Add(carSubCategory);
            SubCategories.Add(foodSubCategory);
            SubCategories.Add(toySubCategory);
        }

        #region Category

        public ObservableCollection<Category> Categories
        {
            get
            {
                return _categories;
            }
            set
            {
                _categories = value;
                OnPropertyChanged("Categories");
            }
        }

        public Category SelectedCategory
        {
            get { return _selectedCategory; }
            set
            {
                if (value != null && value.SubCategories != null)
                {
                    IsEnabledTextProduct = true;
                    IsEnabledSubCatCmb = true;
                    SubCategoriesCmb = (List<Category>)value.SubCategories;
                }
                _selectedCategory = value;
                OnPropertyChanged("SelectedCategory");
            }
        }

        #endregion

        #region SubCategory

        public ObservableCollection<Category> SubCategories
        {
            get
            {
                return _subCategories;
            }
            set
            {
                _subCategories = value;
                OnPropertyChanged("SubCategories");
            }
        }

        public Category SelectedSubCategory
        {
            get { return _selectedSubCategory; }
            set
            {
                _selectedSubCategory = value;
                OnPropertyChanged("SelectedSubCategory");
            }
        }

        public List<Category> SubCategoriesCmb
        {
            get { return _subCategoryCmb; }
            set
            {
                _subCategoryCmb = value;
                OnPropertyChanged("SubCategoriesCmb");
            }
        }

        public bool IsEnabledSubCatCmb
        {
            get { return _isEnabledSubCatCmb; }
            set
            {
                _isEnabledSubCatCmb = value;
                OnPropertyChanged("IsEnabledSubCatCmb");
            }
        }

        #endregion

        #region Product

        public bool IsEnabledTextProduct
        {
            get { return _isEnTxtProduct; }
            set
            {
                _isEnTxtProduct = value;
                OnPropertyChanged("IsEnabledTextProduct");
            }
        }

        public string ProductName
        {
            get { return _productName; }
            set
            {
                if (SelectedCategory != null || SelectedSubCategory != null)
                {
                    _productName = value;
                    OnPropertyChanged("ProductName");
                }
            }
        }

        public RelayComand AddProduct
        {
            get
            {
                return new RelayComand((obj) =>
                {
                    AddNewProduct();
                }, obj => SelectedCategory != null && !string.IsNullOrEmpty(ProductName));
            }
        }

        #endregion        

        void AddNewProduct()
        {
            if (SelectedSubCategory != null)
            {
                var prod = new Product(SubCategories
                    .Where(sc => sc.Name == SelectedSubCategory.Name)
                    .FirstOrDefault())
                { Name = ProductName };
            }
            else
            {
                var prod = new Product(Categories
                    .Where(c => c.Name == SelectedCategory.Name)
                    .FirstOrDefault())
                { Name = ProductName };
            }
        }

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
