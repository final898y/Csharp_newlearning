using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxSelectionMode
{
    public partial class Form1 : Form
    {
        private List<string> _leftList;
        private List<string> _rightList;
        public Form1()
        {
            InitializeComponent();
            CreateList(); 
            SetListBoxDataSource(); 
            ChangeData();
        }
        private void CreateList()
        {
            _leftList = new List<string>
            {
                "A","B","C","D"
            };
            _rightList = new List<string>();
        }
        private void SetListBoxDataSource()
        {
            listBox1.SelectionMode = SelectionMode.One; 
            listBox2.SelectionMode = SelectionMode.One;
        }
        private void ChangeData()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox1.DataSource = _leftList;
            listBox2.DataSource = _rightList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string item = (string)listBox1.SelectedItem; 
                _leftList.Remove(item); 
                _rightList.Add(item); 
                ChangeData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                string item = (string)listBox2.SelectedItem; 
                _rightList.Remove(item); 
                _leftList.Add(item); 
                ChangeData();
            }
        }

        //剛剛在ChangeData方法中為什麼要先設定兩個ListBox 的DataSource = null 呢
        private void button3_Click(object sender, EventArgs e)
        {
            //_leftList.Add("aaaa");
            //listBox2.DataSource = _leftList;
        }

    }
}
