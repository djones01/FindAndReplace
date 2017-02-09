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

namespace FindAndReplace
{
    public partial class ReplaceForm : Form
    {
        public string SourceText = "";
        public BindingList<KeyValuePair<string, string>> kvPairsOne = new BindingList<KeyValuePair<string, string>>();
        public BindingList<KeyValuePair<string, string>> kvPairsTwo = new BindingList<KeyValuePair<string, string>>();
        string logText = "";
        bool single = true;

        public ReplaceForm()
        {
            InitializeComponent();
            dataGridViewKVOne.DataSource = kvPairsOne;
            dataGridViewKVTwo.DataSource = kvPairsTwo;
        }

        private void buttonSelectSource_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogSource.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialogSource.FileName;
                try
                {
                    SourceText = File.ReadAllText(file);
                    string extension = Path.GetExtension(openFileDialogSource.FileName);
                    if (extension == ".xml")
                    {
                        webBrowserXML.Visible = true;
                        webBrowserXML.Url = new Uri(openFileDialogSource.FileName);
                    }
                    else
                    {
                        textBoxSource.Text = SourceText;
                    }
                }
                catch (IOException ex)
                {
                    logText += ex.Message;
                }
            }
        }

        private void buttonClearSource_Click(object sender, EventArgs e)
        {
            ClearSource();
        }

        private void ClearSource()
        {
            SourceText = "";
            textBoxSource.Text = "";
            textBoxSource.Visible = true;
            webBrowserXML.Url = null;
            webBrowserXML.Visible = false;
        }

        private void ClearAll()
        {
            ClearSource();
            kvPairsOne.Clear();
            kvPairsTwo.Clear();
            logText = "";
            single = true;
            textBoxResult.Text = "";
            buttonSaveResult.Enabled = false;
            textBoxLogs.Text = "";
        }

        private void buttonSelectKVOne_Click(object sender, EventArgs e)
        {
            GetKVs(true);
        }

        private void buttonClearKVOne_Click(object sender, EventArgs e)
        {
            kvPairsOne.Clear();
        }

        private void buttonClearKVTwo_Click(object sender, EventArgs e)
        {
            kvPairsTwo.Clear();
        }

        private void buttonSelectKVTwo_Click(object sender, EventArgs e)
        {
            GetKVs(false);
        }

        private void GetKVs(bool kvOne)
        {
            DialogResult result = openFileDialogKV.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialogKV.FileName;
                try
                {
                    StreamReader reader = new StreamReader(file);
                    string line = "";
                    int i = 1;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] items = line.Split(',');
                        int count = items.Count(s => String.IsNullOrWhiteSpace(s) == false);
                        if (count >= 2)
                        {
                            var key = "";
                            var val = "";
                            foreach (var item in items)
                            {
                                if (String.IsNullOrWhiteSpace(item) == false)
                                {
                                    if (key == "")
                                    {
                                        key = item.Trim();
                                    }
                                    else
                                    {
                                        val = item.Trim();
                                        break;
                                    }
                                }
                            }
                            if (kvOne)
                            {
                                kvPairsOne.Add(new KeyValuePair<string, string>(key, val));
                            }
                            else
                            {
                                kvPairsTwo.Add(new KeyValuePair<string, string>(key, val));
                            }              
                        }
                        else
                        {
                            logText += "Couldn't properly split line # " + i + " in Key / Value pairs file " + (kvOne? "1":"2") + " \r\n";
                        }
                        i++;
                    }
                }
                catch (IOException ex)
                {
                    logText += ex.Message;
                }
            }
            this.textBoxLogs.Text = this.logText;
        }

        private void buttonRunReplace_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(SourceText) == false)
            {
                if((single && kvPairsOne.Count == 0) || (!single && (kvPairsOne.Count == 0 || kvPairsTwo.Count == 0)))
                {
                    MessageBox.Show("Key / Value pairs are blank, please provide a file.", "Provide Key / Value File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tabPageKeyValues.Show();
                }
                else
                {
                    try
                    {
                        if (single)
                        {
                            foreach (var pair in kvPairsOne)
                            {
                                if (SourceText.Contains(pair.Key))
                                {
                                    SourceText = SourceText.Replace(pair.Key, pair.Value);
                                    logText += "[Success] Found instance(s) of Key: '" + pair.Key + "' in the source text, replaced with Value: '" + pair.Value + "'\r\n";
                                }
                                else
                                {
                                    logText += "[Failure] Unable to find any instance(s) of Key: '" + pair.Key + "' in the source text \r\n";
                                }
                            }
                        }
                        else
                        {
                            foreach (var pair in kvPairsOne)
                            {
                                if (SourceText.Contains(pair.Value))
                                {                                    
                                    if (kvPairsTwo.Any(x => x.Key == pair.Key))
                                    {
                                        var kvTwo = kvPairsTwo.FirstOrDefault(x => x.Key == pair.Key);
                                        logText += "[Success] Found instance(s) of Value: '" + pair.Value + "' in the source text, replacing with Value: '" + kvTwo.Value + "' after matching on " + pair.Key + " = " + kvTwo.Key + "\r\n";
                                        SourceText = SourceText.Replace(pair.Value, kvTwo.Value);
                                    }                                   
                                }
                                else
                                {
                                    logText += "[Failure] Unable to find any instance(s) of Key: '" + pair.Key + "' in the source text \r\n";
                                }
                            }
                        }
                        textBoxResult.Text = SourceText;
                        buttonSaveResult.Enabled = true;
                    }
                    catch(Exception ex)
                    {
                        logText += ex.Message;
                    }      
                }
            }
            else
            {
                MessageBox.Show("Source Text is blank, please provide a file.", "Provide Source File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabPageSource.Show();
            }
            this.textBoxLogs.Text = this.logText;
        }

        private void textBoxSource_TextChanged(object sender, EventArgs e)
        {
            SourceText = textBoxSource.Text;
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void buttonSaveResult_Click(object sender, EventArgs e)
        {
            this.saveFileDialogResult.ShowDialog();
            if(saveFileDialogResult.FileName != "")
            {
                StreamWriter writer = new StreamWriter(saveFileDialogResult.FileName);
                writer.Write(this.SourceText);
                writer.Close();
                writer.Dispose();
            }
        }

        private void radioButtonSingle_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSingle.Checked)
            {
                groupBoxKVTwo.Visible = false;
                single = true;
            }
            else
            {
                groupBoxKVTwo.Visible = true;
                single = false;
            }
        }

        private void radioButtonDouble_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSingle.Checked)
            {
                groupBoxKVTwo.Visible = false;
                single = true;
            }
            else
            {
                groupBoxKVTwo.Visible = true;
                single = false;
            }
        }
    }
}
