using System;
using System.IO;
using System.Windows.Forms;

//-----------------------------------------
//Majid Tooranisama
//#7725070
//Assignment #3
//2018/07/01
//-----------------------------------------

namespace FilesMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string fileName = "";
        StreamWriter sw = null;
        StreamReader sr = null;
        string newFileName = "";
        string backUpFileName = "";
        string fileMode = "";
        private void buttonCreateFile_Click(object sender, EventArgs e) //when create button clicked,these codes start processing
        {
            if (radioButtonCreate.Checked && textBoxFileName.Text != "")
            {
                fileName = textBoxFileName.Text;
                fileMode = "write";
                if (!File.Exists(fileName))
                {
                    labelMessageDisplay.Text = fileName + " file created";
                }
                else if (File.Exists(fileName))
                {
                    labelMessageDisplay.Text = fileName + " file opened for appending";
                }
            }
            else if (radioButtonOpen.Checked)
            {
                DialogResult result = openFileDialog1.ShowDialog();     //this code opens the drive to open desired file
                fileName = openFileDialog1.FileName;
                textBoxFileName.Text = fileName;
            }
            else if (textBoxFileName.Text == "")
            {
                labelMessageDisplay.Text = "Enter a file name first";
            }
            else
            {
                labelMessageDisplay.Text = fileName + " error on radio button file";
            }
        }
        private void buttonAddData_Click(object sender, EventArgs e)//when write record button clicked,these codes start processing
        {
            string transact = "";
            string date = "";
            string serialNumber = "";
            string toolpurchased = "";
            double price = 0;
            int qty = 0;
            double amount = 0;
            fileMode = "write";

            transact = textBoxTransactNumber1.Text.ToString();
            date = textBoxDate.Text.ToString();
            serialNumber = textBoxSerialNumber.Text.ToString();
            toolpurchased = textBoxToolPurchased.Text.ToString();
            string textString = "";

            if (transact != "" && date != "" && serialNumber != "" && toolpurchased != "" && textBoxPrice.Text != "" && textBoxQty.Text != "")
            {
                try
                {
                    price = Convert.ToDouble(textBoxPrice.Text);
                    qty = Convert.ToInt16(textBoxQty.Text);
                    amount = price * qty;
                    textBoxAmount.Text = amount.ToString();
                    amount = Convert.ToDouble(textBoxAmount.Text);
                }
                catch (FormatException)                                             //try-catch for format exception
                {
                    MessageBox.Show("You have entered non-numeric characters");
                }
                textString = transact + "," + date + "," + serialNumber + "," + toolpurchased + "," + price.ToString() + "," + qty.ToString() + "," + amount.ToString();

                using (sw = File.AppendText(fileName))                              //using sw to write data into a file 
                {
                    sw.WriteLine(textString);
                }
                labelMessageDisplay.Text = "1 record written";

                textBoxFileName.Text = "";
                textBoxTransactNumber1.Text = "";
                textBoxDate.Text = "";
                textBoxSerialNumber.Text = "";
                textBoxToolPurchased.Text = "";
                textBoxPrice.Text = "";
                textBoxQty.Text = "";
                textBoxAmount.Text = "";
            }
            else
            {
                labelMessageDisplay.Text = "Fields not complete";
            }
        }
        private void buttonDisplayData_Click(object sender, EventArgs e)//when display data button clicked,these codes start processing
        {
            fileMode = "read";
            //textBoxFileName.Text = fileName;
            int itemsDisplayed = 0;
            //string transact = "";
            //string date = "";
            //string toolpurchased = "";
            //string serialNumber = "";
            double price = 0;
            int qty = 0;
            double amount = 0;
            richTextBoxDisplay.Text = "";
            string textString = "";
            string[] sArr;

            string fLine = "   #           Purchase-Date        Serial #    Manufacturing Tools                Price            Qty                     Amount" + Environment.NewLine;
            fLine += "-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine;

            if (fileMode == "write")
            {
                sw.Close();
            }
            if (textBoxFileName.Text != "" && File.Exists(fileName))
            {
                using (sr = File.OpenText(fileName))              //using sr to read the file for displaying on rich textbox
                {
                    while (!sr.EndOfStream)
                    {
                        textString = sr.ReadLine();
                        if (textString != "")
                        {
                            sArr = textString.Split(',');
                            fLine += String.Format("{0,4}", sArr[0]);
                            fLine += "\t" + " " + String.Format("{0,-12}", sArr[1]);
                            fLine += "\t" + " " + String.Format("{0,-5}", sArr[2]);

                            sArr[3].Trim();

                            if (sArr[3].Length < 20)
                            {
                                fLine += "\t" + " " + String.Format("{0,-20}", sArr[3]) + "\t";
                            }
                            else
                            {
                                fLine += "\t" + " " + String.Format("{0,-20}", sArr[3]);
                            }

                            price = Convert.ToDouble(sArr[4]);
                            qty = Convert.ToInt32(sArr[5]);
                            amount = Convert.ToDouble(sArr[6]);

                            fLine += "\t" + " " + String.Format("{0:c}", price);
                            fLine += "\t" + " " + String.Format("{0,6}", qty);
                            fLine += "\t" + "\t" + String.Format("{0:c}", amount);
                            fLine += Environment.NewLine;
                            itemsDisplayed++;
                        }
                    }
                    fLine += "-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";

                    richTextBoxDisplay.Text = fLine;
                    labelMessageDisplay.Text = "Item displayed: " + itemsDisplayed;
                }
            }
            else
            {
                labelMessageDisplay.Text = "Enter a valid file name first";
            }
        }
        private void buttonDeleteRecord_Click(object sender, EventArgs e)//when delete a record button clicked,these codes start processing
        {
            try
            {
                fileMode = "read";
                //textBoxFileName.Text = fileName;
                string recordString = "";
                string transact = "";
                string[] sArr;
                double price = 0;
                int qty = 0;
                double amount = 0;
                int itemsDisplayed = 0;
                richTextBoxDisplay.Text = "";
                fileName = textBoxFileName.Text;
                transact = textBoxTransactNumber2.Text;
                newFileName = fileName + ".new";
                backUpFileName = fileName + ".backup";

                string renewLine = "   #           Purchase-Date        Serial #    Manufacturing Tools                Price            Qty                     Amount" + Environment.NewLine;
                renewLine += "-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine;

                if (textBoxFileName.Text != "" && File.Exists(fileName))
                {
                    using (sr = File.OpenText(fileName))             //using sr to read the file for finding transact# to delete
                    {
                        while (!sr.EndOfStream)
                        {
                            try
                            {
                                recordString = sr.ReadLine();
                                sArr = recordString.Split(',');
                                if (transact == sArr[0])
                                {
                                    recordString = "";
                                }
                                else
                                {
                                    recordString = sArr[0] + "," + sArr[1] + "," + sArr[2] + "," + sArr[3] + "," + sArr[4] + "," + sArr[5] + "," + sArr[6];
                                    using (sw = File.AppendText(newFileName))  //using sw to make a new file for replacing to old file
                                    {
                                        sw.WriteLine(recordString);
                                    }
                                }
                            }
                            catch (IndexOutOfRangeException)
                            {
                                MessageBox.Show("Array element's index is out of range");
                            }
                            if (recordString != "")
                            {
                                sArr = recordString.Split(',');
                                renewLine += String.Format("{0,4}", sArr[0]);
                                renewLine += "\t" + " " + String.Format("{0,-12}", sArr[1]);
                                renewLine += "\t" + " " + String.Format("{0,-5}", sArr[2]);

                                sArr[3].Trim();

                                if (sArr[3].Length < 20)
                                {
                                    renewLine += "\t" + " " + String.Format("{0,-20}", sArr[3]) + "\t";
                                }
                                else
                                {
                                    renewLine += "\t" + " " + String.Format("{0,-20}", sArr[3]);
                                }

                                price = Convert.ToDouble(sArr[4]);
                                qty = Convert.ToInt32(sArr[5]);
                                amount = Convert.ToDouble(sArr[6]);

                                renewLine += "\t" + " " + String.Format("{0:c}", price);
                                renewLine += "\t" + " " + String.Format("{0,6}", qty);
                                renewLine += "\t" + "\t" + String.Format("{0:c}", amount);
                                renewLine += Environment.NewLine;
                                itemsDisplayed++;
                            }
                        }
                        renewLine += "-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";

                        richTextBoxDisplay.Text = renewLine;
                        labelMessageDisplay.Text = "File rebuilt" + Environment.NewLine;
                        labelMessageDisplay.Text += "Item displayed: " + itemsDisplayed;
                    }
                    File.Replace(newFileName, fileName, backUpFileName);
                }                                   //Replace method replaces the old file with new file and deletes the old file
                else
                {
                    labelMessageDisplay.Text = "Enter a valid file name first then choose a valid transact number";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured");
            }
        }
        private void buttonDeleteFile_Click(object sender, EventArgs e)//when delete file button clicked,these codes start processing
        {
            richTextBoxDisplay.Text = "";
            if (textBoxFileName.Text != "")
            {
                fileName = textBoxFileName.Text;
                File.Delete(fileName);
                textBoxFileName.Text = "";
                labelMessageDisplay.Text = fileName + " file deleted";
            }
            else
            {
                labelMessageDisplay.Text = "Enter a file name first";
            }
        }
        private void buttonCloseFile_Click(object sender, EventArgs e)//when close file button clicked,these codes start processing
        {
            try
            {
                if (textBoxFileName.Text != "")
                {
                    textBoxFileName.Text = "";
                    richTextBoxDisplay.Text = "";
                    if (fileMode == "read")
                    {
                        sr.Close();
                        labelMessageDisplay.Text = fileName + " file now closed";
                    }
                    else
                    {
                        sw.Close();
                        labelMessageDisplay.Text = fileName + " file now closed";
                    }
                }
                else
                {
                    labelMessageDisplay.Text = "Enter a file name first";
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Error, null reference exception");
            }
        }
    }
}
