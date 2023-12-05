using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace APS8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            checkedList.SelectedIndex = 0;
            checkedList.SetItemChecked(0, true);
        }
        private void GenB_Click(object sender, EventArgs e)
        {
            if(Col.Text != "" && Convert.ToInt32(Col.Text) > 0)
            {
                int k = Convert.ToInt32(Col.Text);
                int[] mass = new int[k];

                Random rand = new Random();
                for (int i = 0; i < mass.Length; i++)
                    mass[i] = rand.Next(Convert.ToInt32(MinG.Value), Convert.ToInt32(MaxG.Value));

                richTextBox1.Text = String.Join(",", mass);
            }  
        }

        private void ResB_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "" && comboAlg.Text!="")
            {
                string str = richTextBox1.Text;
                var A = str.Split(',').Select(int.Parse).ToList();
                int[] mass = A.ToArray();

                int var = comboAlg.SelectedIndex;

                richTextBox2.Text = "";

                switch(var)
                {
                    case 0:
                        BubbleSort algorithm1 = new BubbleSort();
                        Context context1 = new Context(algorithm1);
                        var LM1 = context1.ExecuteAlgorithm(mass, checkedList.SelectedIndex);
                        for(int i=0; i<LM1.Count(); i++)
                        {
                            richTextBox2.Text +=$"Шаг {i}: " + LM1[i] + "\n";
                        }
                        break;
                    case 1:
                        SelectionSort algorithm2 = new SelectionSort();
                        Context context2 = new Context(algorithm2);
                        var LM2 = context2.ExecuteAlgorithm(mass, checkedList.SelectedIndex);
                        for (int i = 0; i < LM2.Count(); i++)
                        {
                            richTextBox2.Text += $"Шаг {i}: " + LM2[i] + "\n";
                        }
                        break;
                    case 2:
                        GnomeSort algorithm3 = new GnomeSort();
                        Context context3 = new Context(algorithm3);
                        var LM3 = context3.ExecuteAlgorithm(mass, checkedList.SelectedIndex);
                        for (int i = 0; i < LM3.Count(); i++)
                        {
                            richTextBox2.Text += $"Шаг {i}: " + LM3[i] + "\n";
                        }
                        break;
                }
            }
        }

        private void checkedList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var list = sender as CheckedListBox;
            if (e.NewValue == CheckState.Checked)
                foreach (int index in list.CheckedIndices)
                    if (index != e.Index)
                        list.SetItemChecked(index, false);

        }
    }
}
