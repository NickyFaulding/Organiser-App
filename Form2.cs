using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace OrganiserApp2
{
    public partial class Form2 : Form
    {
        public Form2(string WhichPage)
        {
            InitializeComponent();

            label1.Text = WhichPage;
            PopulateTaskList(WhichPage);
        }

        public void PopulateTaskList(string moduleName)
        {
            string line;
            string moduleFilePath = "C:\\Users\\nicky\\source\\repos\\OrganiserApp2\\ListData\\" + moduleName + ".txt";

            var tasksFile = new StreamReader(moduleFilePath);

            checkedListBox1.Items.Clear();

            while ((line = tasksFile.ReadLine()) != null)
            {
                checkedListBox1.Items.Add(line);
            }

            tasksFile.Close();
        }

        public void AddTask(string moduleName, string newTaskTxt)
        {
            string moduleFilePath = "C:\\Users\\nicky\\source\\repos\\OrganiserApp2\\ListData\\" + moduleName + ".txt";



            using (StreamWriter writer = new StreamWriter(moduleFilePath, true))
            {
                writer.WriteLine(GetNewTaskName());

                writer.Close();
            }

            PopulateTaskList(moduleName);
        }

        public void RemoveCheckedTasks(string moduleName)
        {
            string moduleFilePath = "C:\\Users\\nicky\\source\\repos\\OrganiserApp2\\ListData\\" + moduleName + ".txt";

            List<string> tasksToRemove = getCheckedTasks();

            foreach (string task in tasksToRemove)
            {
                File.WriteAllLines(moduleFilePath, File.ReadLines(moduleFilePath).Where(l => l != task).ToList()); //Linq
            }

            PopulateTaskList(moduleName);
        }

        public List<string> getCheckedTasks()
        {
            List<string> itemsToRemove = new List<string>();

            if(checkedListBox1.CheckedItems.Count > 0)
            {
                for(int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
                {
                    itemsToRemove.Add(checkedListBox1.CheckedItems[i].ToString());
                }
            }

            return itemsToRemove;
        }

        public string GetNewTaskName()
        {
            string newTask = Interaction.InputBox("Please enter the new task.");

            return newTask;
        }

        private void addTaskBtn_Click(object sender, EventArgs e)
        {
            string moduleName = label1.Text;
            AddTask(moduleName, "someTask");
        }

        private void rmvTskBtn_Click(object sender, EventArgs e)
        {
            string moduleName = label1.Text;
            RemoveCheckedTasks(moduleName);
        }
    }
}
