using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFriendsList
{
    public partial class Form1 : Form
    {
        List<String> myFriends = new List<string>();
        BindingSource bs = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            bs.DataSource = myFriends;
        }

        private void btn_addFriend_Click(object sender, EventArgs e)
        {
            myFriends.Add(txt_newFriend.Text);
            listBox1.DataSource = bs;
            bs.ResetBindings(false);
            label1.Text = "There are " + myFriends.Count + " people in the list";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_addFive_Click(object sender, EventArgs e)
        {
            myFriends.Add("Veronique");
            myFriends.Add("Alexandre");
            myFriends.Add("Patrick");
            myFriends.Add("Matthieu");
            myFriends.Add("Simon");
            listBox1.DataSource = bs;
            bs.ResetBindings(false);
            label1.Text = "There are " + myFriends.Count + " people in the list";
        }

        private void btn_SortAsc_Click(object sender, EventArgs e)
        {
            myFriends.Sort();
            bs.ResetBindings(false);
        }

        private void btn_SortDesc_Click(object sender, EventArgs e)
        {
            myFriends.Sort();
            myFriends.Reverse();
            bs.ResetBindings(false);
        }

        private void btn_clearList_Click(object sender, EventArgs e)
        {
            myFriends.Clear();
            txt_newFriend.Clear();
            label1.Text = "There are " + myFriends.Count + " people in the list";
            bs.ResetBindings(false);

        }
    }
}
