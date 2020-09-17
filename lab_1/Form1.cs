using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ToolTip toolTipAbout = new ToolTip();
            toolTipAbout.SetToolTip(this.aboutButton, "About program");
            radioButtonRandom.Checked = true;
            buttonEnter.Visible = false;
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент 484 группы,\nКрупский Артемий Игоревич", "About program");
        }

        private static int[] arr;
        private static int[] arrCopy;
        private static int size;

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (radioButtonRandom.Checked == true)
            {
                clearAllTextBox();

                try
                {
                    size = Convert.ToInt32(textBoxSize.Text);
                }

                catch
                {
                    MessageBox.Show("Enter size of array", "Notification");
                }
                
                arr = new int[size];
                arrCopy = new int[size];

                Random rand = new Random();

                for (int i = 0; i < arr.Length; i++)
                    arr[i] = rand.Next(-1000, 1000);

                Array.Copy(arr, arrCopy, size);
                Array.Sort(arr);

                for (int i = 0; i < size; i++)
                {
                    textBoxUnsorted.Text += arrCopy[i] + " ";
                    textBoxSorted.Text += arr[i] + " ";
                    textBoxSize.Clear();
                }
            }

            else if (radioButtonFile.Checked == true)
            {
                clearAllTextBox();

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filename = ofd.FileName;
                    var str = File.ReadAllText(filename);

                    try
                    {
                        arr = str.Split(' ').Select(num => int.Parse(num)).ToArray();
                    }

                    catch
                    {
                        MessageBox.Show("Error in string", "Exception");
                    }

                    arrCopy = new int[arr.Length];

                    Array.Copy(arr, arrCopy, arr.Length);
                    Array.Sort(arr);

                    for (int i = 0; i < arr.Length; i++)
                    {
                        textBoxUnsorted.Text += arrCopy[i] + " ";
                        textBoxSorted.Text += arr[i] + " ";
                    }
                }
            }

            else if (radioButtonKeyboard.Checked == true)
            {
                clearAllTextBox();

                try
                {
                    size = Convert.ToInt32(textBoxSize.Text);
                    confirmButton.Visible = false;
                    buttonEnter.Visible = true;
                    arr = new int[size];
                    arrCopy = new int[size];
                    countdown = size;
                }

                catch
                {
                    MessageBox.Show("Enter size of array", "Notification");
                }                
            }
        }

        private void textBoxSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete)) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void textBoxElement_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete) && (e.KeyChar != 45))
            {
                e.Handled = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (arr != null)
                {
                    string name = sfd.FileName;
                    StreamWriter stream = new StreamWriter(name);
                    stream.Write(size + " ");
                    foreach (int Item in arr)
                    {
                        stream.Write(Item + " ");
                    }
                    stream.Close();
                    MessageBox.Show($"Done", "Done!");
                }
                else
                {
                    MessageBox.Show("Unable to save a file", "Error");
                }
            }
        }

        int count = 0;
        int countdown;

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (countdown != 0)
            {
                try
                {
                    arr[count] = Convert.ToInt32(textBoxElement.Text);
                    textBoxUnsorted.Text += arr[count] + " ";
                    --countdown;
                    count++;
                    textBoxElement.Clear();
                }

                catch
                {
                    MessageBox.Show("Enter element","Notification");
                }
            }

            if (countdown == 0)
            {
                Array.Copy(arr, arrCopy, size);
                Array.Sort(arr);

                for (int i = 0; i < size; i++)
                {
                    textBoxSorted.Text += arr[i] + " ";
                    buttonEnter.Visible = false;
                    confirmButton.Visible = true;
                    textBoxSize.Clear();
                }
            }
        }
        private void clearAllTextBox()
        {
            textBoxSorted.Clear();
            textBoxUnsorted.Clear();
        }
    }
}