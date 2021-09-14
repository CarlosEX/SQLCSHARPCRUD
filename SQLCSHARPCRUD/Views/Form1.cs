using System;
using System.Windows.Forms;
using Cison.BoxView;
using System.Drawing;

namespace SQLCSHARPCRUD {
    public partial class Form1 : Form {

        private readonly IEmployeeRepository _employeeRepository = EmployeeRepositoryFactory.Create();

        public Form1() {
            InitializeComponent();
            LoadEmployees();
            LoadEvents();
            this.dataGridView1.GridColor = Color.FromArgb(232,232,232);
        }
        
        private void LoadEmployees() {
            this.dataGridView1.DataSource = EmployeeRepositoryFactory.Create().GetAll();
            this.textBoxTotalProjects.Text = GetTotalProjects();
        }

        private void GetDataEmployeeRowClick() {
            if (dataGridView1.SelectedRows.Count > 0) {
                var row = dataGridView1.SelectedRows[0];
                var employee = (Employee)row.DataBoundItem;
                this.textBoxIdUpadate.Text = employee.Id.ToString();
                this.textBoxFirestNameUpadate.Text = employee.FirstName;
                this.textBoxLastNameUpadate.Text = employee.LastName;
            }
        }

        private void SaveRegister() {
            if (IsFildsValidate()) {
                
                IEmployee employee = EmployeeFactory.Create();
                employee.FirstName = textBoxFirestNameAdd.Text;
                employee.LastName = textBoxLastNameAdd.Text;

                _employeeRepository.Add(employee);
                LoadEmployees();
                BoxViewFactory.Show(IconBox.Success, "Resgisto salvo com sucesso", ThemeBox.Light, BoxViewBorderStyle.Single);
            }
        }

        private void UpdateRegister() {
            
            int id = int.Parse(textBoxIdUpadate.Text);
            string firstName = textBoxFirestNameUpadate.Text;
            string lastName = textBoxLastNameUpadate.Text;

            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName)) {

            IEmployee employee = EmployeeFactory.Create();
                employee.Id = id;
                employee.FirstName = firstName;
                employee.LastName = lastName;

                _employeeRepository.Update(employee);
                LoadEmployees();
                BoxViewFactory.Show(IconBox.Success, "Resgisto alterado com sucesso", ThemeBox.Light, BoxViewBorderStyle.Single);
            }
        }

        private void DeleteRegister() {
            if (!string.IsNullOrEmpty(textBoxIdUpadate.Text)) {
                int id = int.Parse(textBoxIdUpadate.Text);
                _employeeRepository.Delete(id);
                LoadEmployees();
                BoxViewFactory.Show(IconBox.Success, "Resgisto excluído com sucesso!", ThemeBox.Light, BoxViewBorderStyle.SizeDialog);
            }
        }

        private bool IsFildsValidate() {
            if (string.IsNullOrWhiteSpace(textBoxFirestNameAdd.Text))
                return false;
            if (string.IsNullOrWhiteSpace(textBoxLastNameAdd.Text)) {
                BoxViewFactory.Show(IconBox.Erro, "Campo obrigatório!", ThemeBox.Light, BoxViewBorderStyle.SizeDialog);
                return false;
            }
            else {
                return true;
            }
        }

        private string GetTotalProjects() {
            return this.dataGridView1.RowCount.ToString();
        }
        private void LoadEvents() {
            this.dataGridView1.CellClick += DataGrid_CellClick;
            this.buttonAdd.Click += ButtonSave_Click;
            this.buttonUpadate.Click += ButtonUpadate_Click;
            this.buttonDelete.Click += ButtonDelete_Click;
        }
      
        private void DataGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
            GetDataEmployeeRowClick();
        }
        private void ButtonSave_Click(object sender, EventArgs e) {
            SaveRegister();
        }
        private void ButtonUpadate_Click(object sender, EventArgs e) {
            UpdateRegister();
        }
        private void ButtonDelete_Click(object sender, EventArgs e) {
            DeleteRegister();
        }
    }
}
