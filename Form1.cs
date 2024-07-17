namespace WinForms3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAddDest_Click(object sender, EventArgs e)
        {
            //lstDest.Items.Add(lstSource.SelectedItems[0]);
            if (lstSource.Items.Count == 0)
            {
                buttonAddDest.Enabled = false;
            }
            else
            {
                if (checkDell.Checked)
                {
                    for (int i = 0; i < lstSource.SelectedItems.Count;)
                    {
                        lstDest.Items.Add(lstSource.SelectedItems[i]);
                        lstSource.Items.Remove(lstSource.SelectedItems[i]);
                        progressBar1.Value = lstDest.Items.Count * 20;
                        progressBar2.Value = lstSource.Items.Count * 20;
                    }
                }
                else
                {
                    for (int i = 0; i < lstSource.SelectedItems.Count; i++)
                    {
                        lstDest.Items.Add(lstSource.SelectedItems[i]);
                        progressBar1.Value = lstDest.Items.Count * 20;
                        progressBar2.Value = lstSource.Items.Count * 20;
                    }
                }
            }

        }

        private void buttonAddDestAll_Click(object sender, EventArgs e)
        {
            if (lstSource.Items.Count == 0)
            {
                buttonAddDestAll.Enabled = false;
            }
            else
            {
                if (checkDell.Checked)
                {
                    lstDest.Items.AddRange(lstSource.Items);
                    lstSource.Items.Clear();
                    progressBar1.Value = lstDest.Items.Count * 20;
                    progressBar2.Value = lstSource.Items.Count * 20;
                }
                else
                {
                    lstDest.Items.AddRange(lstSource.Items);
                    progressBar1.Value = lstDest.Items.Count * 20;
                    progressBar2.Value = lstSource.Items.Count * 20;
                }
            }
        }


        private void buttonDellDest_Click(object sender, EventArgs e)
        {
            if (lstDest.Items.Count == 0)
            {
                buttonDellDest.Enabled = false;
            }
            else
            {
                if (checkDell.Checked)
                {
                    for (int i = 0; i < lstDest.SelectedItems.Count;)
                    {
                        lstSource.Items.Add(lstDest.SelectedItems[i]);
                        lstDest.Items.Remove(lstDest.SelectedItems[i]);
                        progressBar1.Value = lstDest.Items.Count * 20;
                        progressBar2.Value = lstSource.Items.Count * 20;
                    }
                }
                else
                {
                    for (int i = 0; i < lstDest.SelectedItems.Count; i++)
                    {
                        lstSource.Items.Add(lstDest.SelectedItems[i]);
                        progressBar1.Value = lstDest.Items.Count * 20;
                        progressBar2.Value = lstSource.Items.Count * 20;
                    }
                }
            }

        }

        private void buttonDellDestAll_Click(object sender, EventArgs e)
        {
            if (lstDest.Items.Count == 0)
            {
                buttonDellDestAll.Enabled = false;
            }
            else
            {
                if (checkDell.Checked)
                {
                    lstSource.Items.AddRange(lstDest.Items);
                    lstDest.Items.Clear();
                    progressBar1.Value = lstDest.Items.Count * 20;
                    progressBar2.Value = lstSource.Items.Count * 20;
                }
                else
                {
                    lstSource.Items.AddRange(lstDest.Items);
                    progressBar1.Value = lstDest.Items.Count * 20;
                    progressBar2.Value = lstSource.Items.Count * 20;
                }
            }
        }



        private void buttonClearDest_Click(object sender, EventArgs e)
        {
            if (lstDest.Items.Count == 0)
            {
                buttonClearDest.Enabled = false;
            }
            else
            {
                lstDest.Items.Clear();
                progressBar1.Value = lstDest.Items.Count * 20;
                progressBar2.Value = lstSource.Items.Count * 20;
            }
        }




        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }
        Form form;
        private void btnForm2_Click(object sender, EventArgs e)
        {
            if ((form is null)||(!form.Created))
            {
                form = new Form2(lstDest);
                form.Show();
            }
        }

        
    }
}

