using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcForm
{
    public partial class Form1 : Form
    {
        private API api;
        public Form1()
        {
            InitializeComponent();
            api = new API();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var res = api.Calc(new CalcInfo
            {
                Field1 = Convert.ToDouble(field1.Text),
                Field2 = Convert.ToDouble(field2.Text),
                Operation = (int)operations.SelectedValue
            });

            result.Text = ($"Result: {res.Restult}" + Environment.NewLine +
                $"3 recent actions: " + Environment.NewLine); 
                res.CalculationHistories.ForEach(
                    ch => result.Text += ch.ToString() 
                    + Environment.NewLine);
            result.Text += ($"CountOperationType: {res.CountInCurrentMonth}"
                + Environment.NewLine +
                $"MinValue: {res.MinCalc}, MaxValue: {res.MaxCalc}, AvgValue: {res.AvgCalc}"); 
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            var dataSource = api.GetOperations();
            operations.DataSource = new BindingSource(dataSource, null);
            operations.DisplayMember = "Value";
            operations.ValueMember = "Key";
        }
    }
}