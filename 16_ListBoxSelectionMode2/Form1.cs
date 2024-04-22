using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_ListBoxSelectionMode2
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
                "農夫","狼","羊","菜"
            };
            _rightList = new List<string>();

        }
        private void SetListBoxDataSource()
        {
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox2.SelectionMode = SelectionMode.MultiSimple;
        }
        private void ChangeData()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox1.DataSource = _leftList;
            listBox2.DataSource = _rightList;

        }
        private void CheckResult()
        {
            if (!_leftList.Contains("農夫"))
            {
                if (_leftList.Contains("羊"))
                {
                    if (_leftList.Contains("狼") || _leftList.Contains("菜"))
                    {
                        MessageBox.Show("GG1");
                        CreateList();
                        ChangeData();
                    }
                }
                else if (_rightList.Contains("狼") & _rightList.Contains("羊") & _rightList.Contains("菜"))
                {
                    MessageBox.Show("win");
                }
            }
            else
            {
                if (_rightList.Contains("羊"))
                {
                    if (_rightList.Contains("狼") || _rightList.Contains("菜"))
                    {
                        MessageBox.Show("GG2");
                        CreateList();
                        ChangeData();
                    }
                }
            }
        }
        private void toRight_Click(object sender, EventArgs e)
        {
            int listbox1selectItemNumber = listBox1.SelectedItems.Count;
            if (listBox1.SelectedItems.Contains("農夫") & listbox1selectItemNumber <= 2)
            {
                for (int i = 0; i < listbox1selectItemNumber; i++)
                {
                    string item = listBox1.SelectedItems[i].ToString();
                    _leftList.Remove(item);
                    _rightList.Add(item);
                }
            }
            else
            {
                MessageBox.Show("一定要包含農夫，且一次最多只能選兩個選項");
            }
            ChangeData();
            CheckResult();
        }

        private void toLeft_Click(object sender, EventArgs e)
        {
            int listbox2selectItemNumber = listBox2.SelectedItems.Count;
            if (listBox2.SelectedItems.Contains("農夫") & listbox2selectItemNumber <= 2)
            {
                for (int i = 0; i < listbox2selectItemNumber; i++)
                {
                    string item = listBox2.SelectedItems[i].ToString();
                    _rightList.Remove(item);
                    _leftList.Add(item);
                    
                }
            }
            else
            {
                MessageBox.Show("一定要包含農夫，且一次最多只能選兩個選項");
            }
            ChangeData();
            CheckResult();
            
        }
    }
}
