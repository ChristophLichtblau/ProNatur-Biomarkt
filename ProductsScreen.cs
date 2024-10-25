using System;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace ProNatur_Biomarkt_GmbH
{
    public partial class ProductsScreen : Form
    {

        private SqlConnection databaseConnection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\ChristophLichtblau\OneDrive - QESTIT\Dokumente\Pro-Natur Biomarkt GmbH.mdf;Integrated Security = True; Connect Timeout = 30");

        private int lastSelectedProductKey;

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
            
            string productName = textBoxProductName.Text;
            string productBrand = textBoxProductBrand.Text;
            string productCategory = comboBoxProductCategory.Text;
            string productPrice = textBoxProductPrice.Text;

            if (textBoxProductPrice.Text == "")
            { 
                MessageBox.Show("Der Preis beinhaltet ungültige Zeichen oder ist leer!");
                return;
            }

            string query = string.Format("insert into Products values('{0}','{1}','{2}','{3}')"
                , productName, productBrand, productCategory, productPrice);
            ExecuteQuery(query);

            ClearAllFields();
            ShowProducts();
        }

        private void btnProductEdit_Click(object sender, EventArgs e)
        {
            if (lastSelectedProductKey == 0)
            {
                MessageBox.Show("Bitte wähle zuerst ein Produkt aus!");
                return;
            }
            string productName = textBoxProductName.Text;
            string productBrand = textBoxProductBrand.Text;
            string productCategory = comboBoxProductCategory.Text;
            string productPrice = textBoxProductPrice.Text;

            String query = string.Format("update Products set Name='{0}', Brand='{1}', Category='{2}', Price='{3}' where Id={4}"
                , productName, productBrand, productCategory, productPrice, lastSelectedProductKey);
            ExecuteQuery(query);
           
            ShowProducts();
        }

        private void btnProductClear_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            if (lastSelectedProductKey == 0) {
                MessageBox.Show("Bitte wähle zuerst ein Produkt aus!");
            }
            string query = string.Format("delete from Products where Id={0};", lastSelectedProductKey);
            ExecuteQuery(query);

            ClearAllFields();
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

        private void ExecuteQuery(string query) {

            databaseConnection.Open();

            SqlCommand sqlCommand = new SqlCommand(query, databaseConnection);
            sqlCommand.ExecuteNonQuery();

            databaseConnection.Close();
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

        private void productsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxProductName.Text = productsDGV.SelectedRows[0].Cells[1].Value.ToString();
            textBoxProductBrand.Text = productsDGV.SelectedRows[0].Cells[2].Value.ToString();
            comboBoxProductCategory.Text = productsDGV.SelectedRows[0].Cells[3].Value.ToString();
            textBoxProductPrice.Text = productsDGV.SelectedRows[0].Cells[4].Value.ToString();

            lastSelectedProductKey = (int)productsDGV.SelectedRows[0].Cells[0].Value;
        }
    }
}
