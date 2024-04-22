using _13_Dictionary_List;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_Dictionary_List
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            CreateDictionary();
            CreateList();
            SetCombobox();
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            ComboBox theComboBox = (ComboBox)sender;
            int index = theComboBox.SelectedIndex;
            MyRectangle2 item = _list[index];
            MessageBox.Show($"取得索引 {index} 的面積為: {item.Area}");
        }

        private Dictionary<string, MyRectangle> _dictionary;
        private List<MyRectangle2> _list;
        private void CreateDictionary()
        {
            _dictionary = new Dictionary<string, MyRectangle>();
            _dictionary.Add("D1", new MyRectangle { Width = 5, Height = 5 });
            _dictionary.Add("D2", new MyRectangle { Width = 10, Height = 10 });
            _dictionary.Add("D3", new MyRectangle { Width = 20, Height = 20 });
            _dictionary.Add("D4", new MyRectangle { Width = 100, Height = 100 });
        }
        private void CreateList()
        {
            _list = new List<MyRectangle2>();
            _list.Add(new MyRectangle2 { Name = "D1", Width = 5, Height = 5 });
            _list.Add(new MyRectangle2 { Name = "D2", Width = 10, Height = 10 });
            _list.Add(new MyRectangle2 { Name = "D3", Width = 20, Height = 20 });
            _list.Add(new MyRectangle2 { Name = "D4", Width = 100, Height = 100 });
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string key = textBox1.Text;
            if (_dictionary.ContainsKey(key))
            {
                int area = _dictionary[key].GetArea();
                MessageBox.Show($"{key} 的面積為： {area}");
            }
            else
            {
                MessageBox.Show("查無資料");
            }
        }
        private void SetCombobox()
        {
            comboBox1.DataSource = _list;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Area";
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 來點變化，從參數中取得觸發該事件的物件}
            /*
            ComboBox theComboBox = (ComboBox)sender; 
            int index = theComboBox.SelectedIndex; 
            MyRectangle2 item = _list[index]; 
            MessageBox.Show($"取得索引 {index} 的面積為: {item.Area}");
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyRectangle2 item = (MyRectangle2)comboBox1.SelectedItem;
            MessageBox.Show($" {item.Name} 的面積為: {item.GetArea()}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // SelectedItem 還是 MyRectangle2
            int area = (int)comboBox1.SelectedValue;
            MessageBox.Show(area.ToString());
        }
    }
    }

