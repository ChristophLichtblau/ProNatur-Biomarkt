using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProNatur_Biomarkt_GmbH
{
    public partial class ProductsScreen : Form
    {

        private SqlConnection databaseConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\ChristophLichtblau\OneDrive - QESTIT\Dokumente\Pro-Natur Biomarkt GmbH.mdf;Integrated Security = True; Connect Timeout = 30");

        public ProductsScreen()
        {
            InitializeComponent();
            // Startpunkt beim Laden der Seite
           ShowProducts();
        }

        private void btnProductSave_Click(object sender, EventArgs e)
        {

            if (textBoxProductName.Text == "")
            {
                MessageBox.Show("Das Feld 'Name' wurde nicht ausgefüllt!");
                return;
            }
            else if (textBoxProductBrand.Text == "") {
                MessageBox.Show("Das Feld 'Marke' wurde nicht ausgefüllt!");
                return;
            } else if (comboBoxProductCategory.SelectedItem == null) {
                MessageBox.Show("Es wurde noch keine Kategorie für das produkt ausgewählt!");
                return;
            }        
            
            String productName = textBoxProductName.Text;
            String productBrand = textBoxProductBrand.Text;
            String productCategory = comboBoxProductCategory.Text;
            float productPrice;
            if (float.TryParse(textBoxProductPrice.Text, out productPrice) && textBoxProductPrice.Text != "")
            {
            }
            else {
                MessageBox.Show("Der Preis beinhaltet ungültige Zeichen oder ist leer!");
                return;
            }

            databaseConnection.Open();

            string query = string.Format("insert into Products values('{0}','{1}','{2}','{3}')",productName, productBrand,productCategory ,productPrice);
             
            SqlCommand sqlCommand = databaseConnection.CreateCommand();
            sqlCommand.ExecuteNonQuery();

            databaseConnection.Close();

            ClearAllFields();
            ShowProducts();
        }

        private void btnProductEdit_Click(object sender, EventArgs e)
        {

            ShowProducts();
        }

        private void btnProductClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {

            ShowProducts();
        }

        private void ClearAllFields()
        {
            textBoxProductName.Text = "";
            textBoxProductBrand.Text = "";
            textBoxProductPrice.Text = "";
            comboBoxProductCategory.Text = "";
            comboBoxProductCategory.SelectedItem = null;
        }

        private void ShowProducts() {
            databaseConnection.Open();

            String query = "Select * from Products";
            SqlDataAdapter adapter = new SqlDataAdapter(query, databaseConnection);

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            productsDGV.DataSource = dataSet.Tables[0];

            productsDGV.Columns[0].Visible = false;

            databaseConnection.Close();
        }
    }
}
