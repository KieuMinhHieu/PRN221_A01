using ApplicationServices.IServices;
using ApplicationServices.Services;
using BusinessObjects.Models;
using DTOs.FlowerBouquetViewModels;
using KieuMinhHieuWPF.AdminWindows.Customers;
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
    /// Interaction logic for UpdateFlowerBouquetWindow.xaml
    /// </summary>
    public partial class UpdateFlowerBouquetWindow : Window
    {

        private readonly ICategoryService _categoryService;
        private readonly IFlowerBouquetService _flowerBouquetService;
        private readonly ISupplierService _supplierService;
        private IServiceProvider _serviceProvider;
        public UpdateFlowerBouquetWindow(ICategoryService categoryService, IFlowerBouquetService flowerBouquetService, IServiceProvider serviceProvider, ISupplierService supplierService)
        {
            InitializeComponent();
            _categoryService = categoryService;
            _flowerBouquetService = flowerBouquetService;
            _serviceProvider = serviceProvider;
            _supplierService = supplierService;
            ResetInputValue();
            LoadCategory();
            LoadSupplier();
        }


        public void LoadUpdateData(FlowerBouquetViewModel flowerBouquetData )
        {
            txtId.Text = flowerBouquetData.FlowerBouquetId.ToString();
            txtName.Text = flowerBouquetData.FlowerBouquetName;
            txtDescription.Text = flowerBouquetData.Description;
            txtUnitPrice.Text = flowerBouquetData.UnitPrice.ToString();
            txtUnitsInStock.Text = flowerBouquetData.UnitsInStock.ToString();
            GetIndexOfCategory(flowerBouquetData.CategoryName);
            GetIndexOfSupplier(flowerBouquetData.SupplierName);
            isActive.IsChecked= flowerBouquetData.FlowerBouquetStatus==true?true:false;
        }

        private void GetIndexOfCategory(string categoryName)
        {
            var categorys = _categoryService.GetALlCategories();
            for (int i = 0; i < categorys.Count; i++)
            {
                if (categorys[i].CategoryName.Equals(categoryName))
                {
                    cbCategory.SelectedIndex = i;
                }
            }
        }
        private void GetIndexOfSupplier (string supplierName)
        {
            var suppliers = _supplierService.GetAllSuppliers();
            for (int i = 0; i < suppliers.Count; i++)
            {
                if (suppliers[i].SupplierName.Equals(supplierName))
                {
                    cbSupplier.SelectedIndex = i;
                }
            }
        }

        public void LoadCategory()
        {
            var categorys = _categoryService.GetALlCategories();
            for (int i = 0; i < categorys.Count ; i++)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = categorys[i].CategoryName;
                item.Tag = categorys[i].CategoryId;
                cbCategory.Items.Add(item);
            }
            cbCategory.SelectedIndex = 0;
        }

        public FlowerBouquetUpdateModel GetInputValue()
        {
            try
            {
                ComboBoxItem categorySelectedItem = (ComboBoxItem)cbCategory.SelectedItem;
                ComboBoxItem supplierSelectedItem = (ComboBoxItem)cbSupplier.SelectedItem;
                return new FlowerBouquetUpdateModel
                {
                    FlowerBouquetId = int.Parse(txtId.Text),
                    CategoryId = int.Parse(categorySelectedItem.Tag.ToString()),
                    FlowerBouquetName = txtName.Text,
                    Description = txtDescription.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitsInStock.Text),
                    FlowerBouquetStatus = isActive.IsChecked,
                    SupplierId = int.Parse(supplierSelectedItem.Tag.ToString())
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void LoadSupplier()
        {
            var suppliers = _supplierService.GetAllSuppliers();
            for (int i = 0; i < suppliers.Count; i++)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = suppliers[i].SupplierName;
                item.Tag = suppliers[i].SupplierId;
                cbSupplier.Items.Add(item);
            }
            cbSupplier.SelectedIndex = 0;
        }

        private void NumericInputOnly(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+"); // Matches anything that is not a digit
            e.Handled = regex.IsMatch(e.Text);
        }

        private void ResetInputValue()
        {
            txtId.Text ="0";
            txtName.Text = "";
            txtDescription.Text = "";
            txtUnitPrice.Text = "0";
            txtUnitsInStock.Text = "0";
        }

        private void BtnSaveInfor(object sender, RoutedEventArgs e)
        {
            try
            {
                var updateFlowerBouquet = GetInputValue();

                MessageBoxResult confrim = MessageBox.Show("Are you sure you want to Updated?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (confrim == MessageBoxResult.Yes)
                {
                    var result = _flowerBouquetService.UpdateFlowerBouquet(updateFlowerBouquet);
                    if (result)
                    {
                        _serviceProvider.GetRequiredService<FlowerBouquetManagementWindow>().LoadFlowerBouquet();
                        ResetInputValue();
                        this.Hide();
                    }
                }
               
            }
            catch (Exception ex)
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
