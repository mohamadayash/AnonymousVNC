using System;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AnonymousVNC
{
    public partial class frmScanOpenVnc : Form
    {
        private static frmScanOpenVnc Instance;
        private static int count = 0;
        private static int done = 0;
        private static Object lk = new object();
        private string[] ips;
        private int a;

        public frmScanOpenVnc()
        {
            InitializeComponent();
            Instance = this;
        }
        private void Button1_Click(object sender, EventArgs e)
        {

 
            ips = File.ReadAllLines("input.txt");


            ips.ToList().ForEach(str =>
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(Connect), str);
            });
        }

        private static void Connect(Object ip)
        {
            try
            {
                Increment();
                var bln = false;
                if (Instance.IsVnc.Checked)
                {
                    bln = ConnectVNC((String)ip, 5900);
                    if (bln)
                    {
                        string cmd = ip + ":0 " + ip + ".jpg";
                        lock (lk)
                        {
                            System.Diagnostics.Process.Start("vncsnapshot.exe", cmd);
                        }
                    }
                }else if (Instance.IsFtp.Checked)
                {
                    bln = ConnectFTP((String)ip);
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                Decrement();
            }
        }

        private static void Decrement()
        {
            Instance.Invoke(new Action(() =>
            {
                done++;
                count--;
                Instance.lblQueue.Text = count.ToString();
                Instance.lblFinished.Text = done.ToString();
                Instance.lblRemaining.Text = (Instance.ips.Length - done).ToString();
            }));
        }

        private static void Increment()
        {
            Instance.Invoke(new Action(() =>
            {
                count++;
                Instance.lblQueue.Text = count.ToString();
            }));
        }

        public static bool ConnectVNC(String ip, int port)
        {
            Boolean snapshot_flag = false;
            TcpClient client = null;
            try
            {
                client = new TcpClient(ip, port);
                client.ReceiveTimeout = 15000;
                client.SendTimeout = 15000;
                StreamReader sr = new StreamReader(client.GetStream());
                StreamWriter sw = new StreamWriter(client.GetStream());
                if (client.Connected)
                {
                    String RFB_VERSION = sr.ReadLine();
                    if (RFB_VERSION.Contains("RFB"))
                    {
                        sw.WriteLine(RFB_VERSION);
                        sw.Flush();
                        String num_of_auth = sr.ReadLine();
                        if (String.IsNullOrEmpty(num_of_auth)) return snapshot_flag;
                        Byte[] bytes = Encoding.UTF8.GetBytes(num_of_auth);
                        for (int i = 0; i < bytes.Length; i++)
                        {
                            if (bytes[i] == 1)
                            {
                                snapshot_flag = true;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    client.Close();
                }
                client.Dispose();
                return snapshot_flag;
            }
            catch (Exception ex)
            {
                if (client != null && client.Connected)
                {
                    client.Close();
                    client.Dispose();
                }
                return snapshot_flag;
            }

        }

        public static bool ConnectFTP(String ip)
        {
            Boolean snapshot_flag = false;
            TcpClient client = null;
            try
            {
                client = new TcpClient(ip, 21);
                client.ReceiveTimeout = 15000;
                client.SendTimeout = 15000;
                StreamReader sr = new StreamReader(client.GetStream());
                StreamWriter sw = new StreamWriter(client.GetStream());
                if (client.Connected)
                {

                    String Response = sr.ReadLine();

                    sw.WriteLine("USER anonymous");
                    sw.Flush();

                    Response = sr.ReadLine();

                    sw.WriteLine("PASS guest");
                    sw.Flush();


                    Response = sr.ReadLine();

                    if (Response.Contains("230"))
                    {
                        lock (lk)
                        {
                            File.AppendAllLines("output.txt",new String[] { ip});
                        }
                    }

                    
                    client.Close();
                }
                client.Dispose();
                return snapshot_flag;
            }
            catch (Exception ex)
            {
                if (client != null && client.Connected)
                {
                    client.Close();
                    client.Dispose();
                }
                return snapshot_flag;
            }

        }
    }
}
