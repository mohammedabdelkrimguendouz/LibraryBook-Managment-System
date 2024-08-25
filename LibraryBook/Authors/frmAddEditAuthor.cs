using DVLD_Buisness;
using LibraryBook_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;
using static LibraryBook.Authors.frmAddEditAuthor;


namespace LibraryBook.Authors
{
    public partial class frmAddEditAuthor : Form
    {
        public class AuthorEventArgs : EventArgs
        {
            public int AuthorID { get; }
            public AuthorEventArgs(int AuthorID)
            {
                this.AuthorID = AuthorID;
            }
        }

        public delegate void DataBackEventHandler(object sender, AuthorEventArgs e);

        public event DataBackEventHandler DataBack;
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode;


        private int _AuthorID = -1;
        private clsAuthor _Author;
        
        public frmAddEditAuthor()
        {
            InitializeComponent();
            _Mode= enMode.AddNew;   
        }

        public frmAddEditAuthor(int AuthorID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _AuthorID = AuthorID;
        }

        private void chkIsDeath_CheckedChanged(object sender, EventArgs e)
        {
            dtpDeathDate.Enabled = chkIsDeath.Checked;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _FillCountriesInComboBox()
        {
            DataTable dt = clsCountry.GetAllCountries();
            foreach (DataRow dataRow in dt.Rows)
            {
                cbCountries.Items.Add(dataRow["CountryName"]);
            }
            if (cbCountries.Items.Count > 0)
                cbCountries.SelectedIndex = 0;
        }

        private void _ResetDefaultValues()
        {
            _FillCountriesInComboBox();
            if (_Mode == enMode.AddNew)
            {
                this.Text = lblTitle.Text = "Add New Author";
                _Author = new clsAuthor();

            }
            else
            {
                this.Text = lblTitle.Text = "Edit Author";
            }


            lblAuthorID.Text = "[????]";
            txtFullName.Text = "";
            chkIsDeath.Checked = true;


        }

        private void _LoadData()
        {
            _Author = clsAuthor.Find(_AuthorID);
            if (_Author == null)
            {
                MessageBox.Show("this form well be closed because No Author With ID : " + _AuthorID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            lblAuthorID.Text = _Author.AuthorID.ToString(); ;
            txtFullName.Text = _Author.FullName;
            dtpBirthDate.Value = _Author.BirthDate;
            if(_Author.DeathDate != null)
            {
                dtpDeathDate.Value = _Author.DeathDate.Value;
            }
            else
            {
                chkIsDeath.Checked = false;
                dtpDeathDate.Enabled=false;
            }
            cbCountries.SelectedIndex=cbCountries.FindString(_Author.NationalityCountryInfo.CountryName);
            
        }
        private void frmAddEditAuthor_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void txtFullName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                e.Cancel = true;
                txtFullName.Focus();
                errorProvider1.SetError(txtFullName, "This field is required !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFullName, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Author.FullName=txtFullName.Text;
            _Author.BirthDate=dtpBirthDate.Value;
            _Author.DeathDate = (chkIsDeath.Checked) ? (DateTime?)dtpDeathDate.Value : null;
            _Author.NationalityCountryID = clsCountry.Find(cbCountries.Text.Trim()).ID;

            if (_Author.Save())
            {

                this.Text = lblTitle.Text = "Edit Author ";
                _Mode = enMode.Update;
                lblAuthorID.Text = _Author.AuthorID.ToString();
                _AuthorID = _Author.AuthorID;
                MessageBox.Show("Data Saved Successfully ", "Saved",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataBack?.Invoke(this, new AuthorEventArgs(_Author.AuthorID));
            }
            else
                MessageBox.Show("Data is not Saved Successfully ", "Error ",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }
}
