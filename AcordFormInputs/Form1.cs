using System.Diagnostics.Metrics;

namespace AcordFormInputs
{
    public partial class Form1 : Form
    {
        List<string> masterFieldList = new List<string>();
        List<string> formLineList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            masterFieldList = new List<string>();
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                labelFormCount.Text = files.Length.ToString();
                labelFormCount.Update();
                string item = null;
                formLineList = new List<string>();

                for(int a = 0; a < files.Length;a++)
                {
                    labelCountOfInputs.Text = "0";
                    labelCountOfInputs.Update();
                    string fileName = Path.GetFileName(files[a]);
                    labelFormName.Text = fileName;
                    labelFormName.Update();

                    using (StreamReader sr = new StreamReader(files[a]))
                    {
                        while ((item = sr.ReadLine()) != null)
                        {
                            if (item.Contains("/T ("))
                            {
                                string afterReplacement = item.Replace("/T (", "/T *").Replace(") /TU (", "*").Replace(") /Type", "*").Trim();
                                formLineList.Add(afterReplacement);
                            }
                        }                        
                        sr.Close();
                        sr.Dispose();
                    }
                    List<string> finalInputList = GetInputs(formLineList);
                    WriteListOfFields(finalInputList, files[a]);
                }

                WriteMasterList(masterFieldList);
            }
        }

        private List<string> GetInputs(List<string> formLineList)
        {
            int countOf = 0;
            List<string> inputAndLabelList = new List<string>();
            foreach(string str in formLineList)
            {
                string[] tem = str.Split('*');
                inputAndLabelList.Add(tem[1] + "*" + tem[2]);
                masterFieldList.Add(tem[1] + "*" + tem[2]);
                countOf++;
                labelCountOfInputs.Text = countOf.ToString();
                labelCountOfInputs.Update();
            }
            return inputAndLabelList;
        }

        private void WriteListOfFields(List<string> finalInputList, string fileName)
        {
            string fileNamer = Path.GetFileName(fileName).Replace(".pdf", ".txt");
            string myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (!Directory.Exists(myDocuments + "\\AcordInputLists\\"))
                Directory.CreateDirectory(myDocuments + "\\AcordInputLists\\");

            string finalDirectory = myDocuments + "\\AcordInputLists\\";
            using (StreamWriter sw = new StreamWriter(finalDirectory + fileNamer, true))
            {
                foreach(string str in finalInputList)
                {
                    sw.WriteLine(str);
                }
                sw.Flush();
                sw.Close();
                sw.Dispose();
            }
        }


        private void WriteMasterList(List<string> masterInputList)
        {
            string myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (!Directory.Exists(myDocuments + "\\AcordInputLists\\"))
                Directory.CreateDirectory(myDocuments + "\\AcordInputLists\\");

            string finalDirectory = myDocuments + "\\AcordInputLists\\";
            using (StreamWriter sw = new StreamWriter(finalDirectory + "MasterInputListWithDupes.txt", true))
            {
                foreach (string str in masterInputList)
                {
                    sw.WriteLine(str);
                }
                sw.Flush();
                sw.Close();
                sw.Dispose();
            }

            List<string> masterSingleInputList = masterInputList.Distinct().ToList();
                        
            using (StreamWriter sw = new StreamWriter(finalDirectory + "MasterInputListNoDupes.txt", true))
            {
                foreach (string str in masterSingleInputList)
                {
                    sw.WriteLine(str);
                }
                sw.Flush();
                sw.Close();
                sw.Dispose();
            }
        }











    }
}