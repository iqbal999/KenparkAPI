using KenparkAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KenparyWinforms
{
    public partial class EmployeeForm : Form
    {
        private string baseUrl = "https://localhost:7159/api";
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);

            var response = await client.GetAsync($"{baseUrl}/Employee/GetActiveEmployeeList");

            var responseContent = await response.Content.ReadAsStringAsync();
            List<Employee> employees = JsonConvert.DeserializeObject<List<Employee>>(responseContent);

            dataGridView1.DataSource = employees;


            // Display the response content in a text box
            //textBox1.Text = responseContent;
        }

        private async void BtnAction_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee
            {
                IdNumber = TxtIdNumber.Text,
                ContactNumber = TxtCN.Text,
                Address = TxtAddress.Text,
                ActiveStatus = CmbActiveStatus.Text == "Active"
            };
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);

                var content = new StringContent(JsonConvert.SerializeObject(emp), Encoding.UTF8, "application/json");
                var response = await client.PostAsync($"{baseUrl}/Employee/Add", content);
                if (response.IsSuccessStatusCode)
                {
                    var x = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(x))
                    {
                        TxtIdNumber.Text = string.Empty;
                        TxtCN.Text = string.Empty;
                        TxtAddress.Text = string.Empty;
                        CmbActiveStatus.SelectedIndex = 0;
                        button1.PerformClick();
                    }
                }
                else
                {
                    throw new Exception($"Failed to call API. StatusCode={response.StatusCode}");
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells["EmpId"].Value.ToString()!;
        }
    }
}
