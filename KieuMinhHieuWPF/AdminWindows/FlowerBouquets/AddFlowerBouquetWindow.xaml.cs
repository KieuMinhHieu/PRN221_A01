using ApplicationServices.IServices;
using BusinessObjects.Models;
using DataAccessLayer.IRepositories;
using DTOs.FlowerBouquetViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KieuMinhHieuWPF.AdminWindows.FlowerBouquets
{
    /// <summary>
    /// Interaction logic for AddFlowerBouquetWindow.xaml
    /// </summary>
    public partial class AddFlowerBouquetWindow : Window
    {
        private readonly ICategoryService _categoryService;
        private readonly IFlowerBouquetService _flowerBouquetService;
        private readonly ISupplierService _supplierService;
        private IServiceProvider _serviceProvider;
        
        public AddFlowerBouquetWindow(ICategoryService categoryService,IFlowerBouquetService flowerBouquetService,IServiceProvider serviceProvider,ISupplierService supplierService)
        {
            InitializeComponent();
            _categoryService = categoryService;
            _flowerBouquetService = flowerBouquetService;
            _serviceProvider = serviceProvider;
            _supplierService = supplierService;
            LoadCategory();
            LoadSupplier();
        }

        private void NumericInputOnly(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+"); // Matches anything that is not a digit
            e.Handled = regex.IsMatch(e.Text);
        }

        public void LoadCategory()
        {
            var categorys= _categoryService.GetALlCategories();
            categorys.ForEach(category => 
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = category.CategoryName;
                item.Tag = category.CategoryId;
                cbCategory.Items.Add(item);
               
            });
            cbCategory.SelectedIndex = 0;
        }

        public void LoadSupplier()
        {
            _supplierService.GetAllSuppliers().ForEach(supplier => 
            {
                ComboBoxItem item =new ComboBoxItem();
                item.Content =  supplier.SupplierName;
                item.Tag = supplier.SupplierId;
                cbSupplier.Items.Add(item);
            });
            cbSupplier.SelectedIndex = 0;
        }

        public FlowerBouquetNewModel? GetInputValue()
        {
            try
            {
                ComboBoxItem categorySelectedItem = (ComboBoxItem)cbCategory.SelectedItem;
                ComboBoxItem supplierSelectedItem = (ComboBoxItem)cbSupplier.SelectedItem;
                return new FlowerBouquetNewModel
                {
                    CategoryId = int.Parse(categorySelectedItem.Tag.ToString()),
                    FlowerBouquetName = txtName.Text,
                    Description = txtDescription.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text),
                    FlowerBouquetStatus = true,
                    SupplierId = int.Parse(supplierSelectedItem.Tag.ToString())
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        private void ResetInputValue()
        {
            txtName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtUnitsInStock.Text = string.Empty;
        }

        private void BtnSaveInfor(object sender, RoutedEventArgs e)
        {
            try
            {
                var newFlowerBouquet=GetInputValue();
                if(newFlowerBouquet != null )
                {
                    var result = _flowerBouquetService.AddFlowerBouquet(newFlowerBouquet);
                    if (result)
                    {
                        _serviceProvider.GetRequiredService<FlowerBouquetManagementWindow>().LoadFlowerBouquet();
                        ResetInputValue();
                        this.Hide();
                    }
                }
               

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }

        private void BtnClose(object sender, RoutedEventArgs e)
        {
            _serviceProvider.GetRequiredService<FlowerBouquetManagementWindow>().Show();
            this.Hide();
        }
    }
}
