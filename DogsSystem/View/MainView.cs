using DogsSystem.Controller;
using DogsSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogsSystem.View
{
    public partial class MainView : Form
    {
        MainController mainController = new MainController();
        
        
        public MainView()
        {
            InitializeComponent();
        }

        private void RefreshTable()
        {
            dgvDogs.DataSource = mainController.GetAllDogs();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Dog dog = new Dog();
            dog.Name = txtName.Text;
            dog.Age = txtAge.Text;
            mainController.AddDog(dog);
            RefreshTable();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvDogs.CurrentRow;
            int id = int.Parse(row.Cells[0].Value.ToString());
            Dog dog = new Dog();
            dog.Name = txtName.Text;
            dog.Age = txtAge.Text;
            mainController.UpdateDog(id, dog);
            RefreshTable();
        }
    }
}
