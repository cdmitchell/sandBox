using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using CookBook.Recipes.Core.CustomValidation;
using CookBook.Recipes.Core.CustomValidation.Repository;

namespace CookBook.Recipes.Core.CustomValidation.CustomValidationApp
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            this.btnOK.Click += new EventHandler(btnOk_Click);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Username = txtUserName.Text, DateOfBirth = dateTimePicker1.Value
            };

            ValidationContext context = new ValidationContext(user, null, null);

            IList<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(user, context,errors, true))
            {
                foreach (ValidationResult result in errors)
                    MessageBox.Show(result.ErrorMessage);
            }
            else
            {
                IRepositroy repository = new MockRepository();
                repository.AddUser(user);
                MessageBox.Show("New user added");
            }
        }

    }
}
