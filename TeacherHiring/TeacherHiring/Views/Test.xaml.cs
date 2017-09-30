﻿using System;
using System.Linq;
using TeacherHiring.DataBase.Access;
using Xamarin.Forms;

namespace TeacherHiring.Views
{
    public partial class Test : ContentPage
    {
        private MateriaDataAccess dataAccess;
        public DataBase.Model.Materia materia = new DataBase.Model.Materia();
        public Test()
        {
            InitializeComponent();
            // An instance of the CustomersDataAccessClass
            // that is used for data-binding and data access
            this.dataAccess = new MateriaDataAccess();
        }
        // An event that is raised when the page is shown
        protected override void OnAppearing()
        {
            this.BindingContext = this.dataAccess;
        }
        // Save any pending changes
        private void OnSaveClick(object sender, EventArgs e)
        {
            //this.dataAccess.SaveMateria();
        }
        // Add a new customer to the Customers collection
        private void OnAddClick(object sender, EventArgs e)
        {
            //this.dataAccess.AddNewCustomer();
        }
        // Remove the current customer
        // If it exist in the database, it will be removed
        // from there too
        private void OnRemoveClick(object sender, EventArgs e)
        {
            /*var currentCustomer =
              this.CustomersView.SelectedItem as Customer;
            if (currentCustomer != null)
            {
                this.dataAccess.DeleteCustomer(currentCustomer);
            }*/
        }
        // Remove all customers
        // Use a DisplayAlert object to ask the user's confirmation
        private async void OnRemoveAllClick(object sender, EventArgs e)
        {
            /*if (this.dataAccess.Customers.Any())
            {
                var result =
                  await DisplayAlert("Confirmation",
                  "Are you sure? This cannot be undone",
                  "OK", "Cancel");
                if (result == true)
                {
                    this.dataAccess.DeleteAllCustomers();
                    this.BindingContext = this.dataAccess;
                }
            }*/
        }
    }
}