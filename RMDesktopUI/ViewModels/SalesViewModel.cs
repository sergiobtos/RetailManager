﻿using Caliburn.Micro;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMDesktopUI.Library.API;
using RMDesktopUI.Library.Models;

namespace RMDesktopUI.ViewModels
{
    public class SalesViewModel : Screen
    {
        IProductEndPoint _productEndPoint;

        public SalesViewModel(IProductEndPoint productEndPoint)
        {
            _productEndPoint = productEndPoint;           
        }

        protected override async void OnViewLoaded(object view)
        {
            base.OnViewLoaded(view);
            await LoadProducts();
        }

        private async Task LoadProducts()
        {
            var productList = await _productEndPoint.GetAll();
            Products = new BindingList<ProductModel>(productList);
        }
        private BindingList<ProductModel> _products;

        public BindingList<ProductModel> Products
        {
            get { return _products; }
            set 
            { 
                _products = value; 
                NotifyOfPropertyChange(() => Products);
            }
        }

        private BindingList<ProductModel> _cart;

        public BindingList<ProductModel> Cart
        {
            get { return _cart; }
            set
            {
                _cart = value;
                NotifyOfPropertyChange(() => Cart);
            }
        }

        private int _itemQuantity;

        public int ItemQuantity
        {
            get { return _itemQuantity; }
            set 
            { 
                _itemQuantity = value;
                NotifyOfPropertyChange(() => ItemQuantity);
            }
        }

        public string SubTotal
        {
            get 
            {
                //TODO - replace with calculation
                return "$0.00"; 
            }
        }

        public string Total
        {
            get
            {
                //TODO - replace with calculation
                return "$0.00";
            }
        }

        public string Tax
        {
            get
            {
                //TODO - replace with calculation
                return "$0.00";
            }
        }


        public bool CanAddToCart
        {
            get
            {
                bool ouput = false;

                //make sure something is selected
                //make sure there is an item quantity

                return ouput;
            }
        }

        public void AddToCart()
        {

        }

        public bool CanRemoveToCart
        {
            get
            {
                bool ouput = false;

                //make sure something is selected
                return ouput;
            }
        }

        public void RemoveToCart()
        {

        }

        public bool CanCheckOut
        {
            get
            {
                bool ouput = false;

                //make sure there is something in the cart
                return ouput;
            }
        }

        public void CheckOut()
        {

        }


    }
}
