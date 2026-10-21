using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace ToDoPlanner
{
    public class MainForm : Form
    {
        TextBox txtUrl, txtData;
        Button btnDownload, btnUpload, btnStream;
        Label lblStatus;

        public MainForm()
        {
            Text = "Task 8 - WebClient Download/Upload Demo";
            Size = new Size(520, 420);
            StartPosition = FormStartPosition.CenterScreen;

            Controls.Add(new Label { Text = "URL:", Left = 20, Top = 23, Width = 40 });
            txtUrl = new TextBox { Left = 65, Top = 20, Width = 420 };
            txtUrl.Text = "https://www.example.com";
            Controls.Add(txtUrl);

            btnDownload = new Button { Text = "Download Data", Left = 20, Top = 60, Width = 140, Height = 35 };
            btnDownload.Click += BtnDownload_Click;
            Controls.Add(btnDownload);

            btnUpload = new Button { Text = "Upload Data", Left = 175, Top = 60, Width = 140, Height = 35 };
            btnUpload.Click += BtnUpload_Click;
            Controls.Add(btnUpload);

            btnStream = new Button { Text = "Read via Stream", Left = 330, Top = 60, Width = 140, Height = 35 };
            btnStream.Click += BtnStream_Click;
            Controls.Add(btnStream);

            txtData = new TextBox { Left = 20, Top = 110, Width = 465, Height = 220, Multiline = true, ScrollBars = ScrollBars.Vertical, ReadOnly = true };
            Controls.Add(txtData);

            lblStatus = new Label { Left = 20, Top = 345, Width = 465, Height = 25, ForeColor = Color.Blue };
            Controls.Add(lblStatus);
        }

        void BtnDownload_Click(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    string data = client.DownloadString(txtUrl.Text);
                    txtData.Text = data;
                    client.DownloadFile(txtUrl.Text, "downloaded.html");
                    lblStatus.ForeColor = Color.Green;
                    lblStatus.Text = "Downloaded and saved to downloaded.html";
                }
                catch (Exception ex)
                {
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "Error: " + ex.Message;
                }
            }
        }

        void BtnUpload_Click(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    byte[] response = client.UploadData(txtUrl.Text, System.Text.Encoding.UTF8.GetBytes("Sample upload data"));
                    txtData.Text = "Upload response received. Length: " + response.Length + " bytes";
                    lblStatus.ForeColor = Color.Green;
                    lblStatus.Text = "Data uploaded successfully!";
                }
                catch (Exception ex)
                {
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "Upload Error: " + ex.Message;
                }
            }
        }

        void BtnStream_Click(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                try
                {
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    Stream stream = client.OpenRead(txtUrl.Text);
                    StreamReader reader = new StreamReader(stream);
                    txtData.Text = reader.ReadToEnd();
                    reader.Close();
                    stream.Close();
                    lblStatus.ForeColor = Color.Green;
                    lblStatus.Text = "Data read through stream successfully!";
                }
                catch (Exception ex)
                {
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "Stream Error: " + ex.Message;
                }
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }
    }
}





































// Task 8: Downloading, uploading and streaming data with WebClient (Windows Forms)



// set PATH=%PATH%;C:\Windows\Microsoft.NET\Framework64\v4.0.30319


//   cd /d D:\Assemblies\Task8


//   notepad WebClientDemo.cs

//   csc /t:winexe /r:System.Windows.Forms.dll /r:System.Drawing.dll WebClientDemo.cs


//   WebClientDemo

  
//   Program: WebClientDemo.cs

//   using System;
//   using System.Drawing;
//   using System.IO;
//   using System.Net;
//   using System.Windows.Forms;

//   namespace ToDoPlanner
//   {
//       public class MainForm : Form
//       {
//           TextBox txtUrl, txtData;
//           Button btnDownload, btnUpload, btnStream;
//           Label lblStatus;

//           public MainForm()
//           {
//               Text = "Task 8 - WebClient Download/Upload Demo";
//               Size = new Size(520, 420);
//               StartPosition = FormStartPosition.CenterScreen;

//               Controls.Add(new Label { Text = "URL:", Left = 20, Top = 23, Width = 40 });
//               txtUrl = new TextBox { Left = 65, Top = 20, Width = 420 };
//               txtUrl.Text = "https://www.example.com";
//               Controls.Add(txtUrl);

//               btnDownload = new Button { Text = "Download Data", Left = 20, Top = 60, Width = 140, Height = 35 };
//               btnDownload.Click += BtnDownload_Click;
//               Controls.Add(btnDownload);

//               btnUpload = new Button { Text = "Upload Data", Left = 175, Top = 60, Width = 140, Height = 35 };
//               btnUpload.Click += BtnUpload_Click;
//               Controls.Add(btnUpload);

//               btnStream = new Button { Text = "Read via Stream", Left = 330, Top = 60, Width = 140, Height = 35 };
//               btnStream.Click += BtnStream_Click;
//               Controls.Add(btnStream);

//               txtData = new TextBox { Left = 20, Top = 110, Width = 465, Height = 220, Multiline = true, ScrollBars = ScrollBars.Vertical, ReadOnly = true };
//               Controls.Add(txtData);

//               lblStatus = new Label { Left = 20, Top = 345, Width = 465, Height = 25, ForeColor = Color.Blue };
//               Controls.Add(lblStatus);
//           }

//           void BtnDownload_Click(object sender, EventArgs e)
//           {
//               using (WebClient client = new WebClient())
//               {
//                   try
//                   {
//                       ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
//                       string data = client.DownloadString(txtUrl.Text);
//                       txtData.Text = data;
//                       client.DownloadFile(txtUrl.Text, "downloaded.html");
//                       lblStatus.ForeColor = Color.Green;
//                       lblStatus.Text = "Downloaded and saved to downloaded.html";
//                   }
//                   catch (Exception ex)
//                   {
//                       lblStatus.ForeColor = Color.Red;
//                       lblStatus.Text = "Error: " + ex.Message;
//                   }
//               }
//           }

//           void BtnUpload_Click(object sender, EventArgs e)
//           {
//               using (WebClient client = new WebClient())
//               {
//                   try
//                   {
//                       ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
//                       byte[] response = client.UploadData(txtUrl.Text, System.Text.Encoding.UTF8.GetBytes("Sample upload data"));
//                       txtData.Text = "Upload response received. Length: " + response.Length + " bytes";
//                       lblStatus.ForeColor = Color.Green;
//                       lblStatus.Text = "Data uploaded successfully!";
//                   }
//                   catch (Exception ex)
//                   {
//                       lblStatus.ForeColor = Color.Red;
//                       lblStatus.Text = "Upload Error: " + ex.Message;
//                   }
//               }
//           }

//           void BtnStream_Click(object sender, EventArgs e)
//           {
//               using (WebClient client = new WebClient())
//               {
//                   try
//                   {
//                       ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
//                       Stream stream = client.OpenRead(txtUrl.Text);
//                       StreamReader reader = new StreamReader(stream);
//                       txtData.Text = reader.ReadToEnd();
//                       reader.Close();
//                       stream.Close();
//                       lblStatus.ForeColor = Color.Green;
//                       lblStatus.Text = "Data read through stream successfully!";
//                   }
//                   catch (Exception ex)
//                   {
//                       lblStatus.ForeColor = Color.Red;
//                       lblStatus.Text = "Stream Error: " + ex.Message;
//                   }
//               }
//           }

//           [STAThread]
//           static void Main()
//           {
//               Application.EnableVisualStyles();
//               Application.Run(new MainForm());
//           }
//       }
//   }
