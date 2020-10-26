using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganiserApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] modules = new string[] { "Database Systems",
                                              "Group Software Development Project",
                                              "Networked Software Development",
                                              "Object Oriented Programming",
                                              "Software Engineering Concepts & Methods",
                                              "Web Application Development"};

            Button[] moduleBtns = { module0, module1, module2, module3, module4, module5 };


            SetButtonNames(moduleBtns, modules);



        }

        public void SetButtonNames(Button[] btns, string[] names)
        {
            for (int i = 0; i < 6; i++)
            {
                btns[i].Text = names[i];
            }
        }

        public void OpenModulePage(object module)
        {
            Button btn = module as Button;

            string moduleName = btn.Text;

            Form2 form2 = new Form2(moduleName);

            form2.Text = moduleName;

            form2.Show();
        }

        private void module0_Click(object sender, EventArgs e)
        {
            OpenModulePage(sender);
        }

        private void module2_Click(object sender, EventArgs e)
        {
            OpenModulePage(sender);
        }

        private void module4_Click(object sender, EventArgs e)
        {
            OpenModulePage(sender);
        }

        private void module1_Click(object sender, EventArgs e)
        {
            OpenModulePage(sender);
        }

        private void module3_Click(object sender, EventArgs e)
        {
            OpenModulePage(sender);
        }

        private void module5_Click(object sender, EventArgs e)
        {
            OpenModulePage(sender);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
