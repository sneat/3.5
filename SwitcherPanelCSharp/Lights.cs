using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Windows.Forms.VisualStyles;


namespace SwitcherPanelCSharp
{
    public partial class Lights : Form
    {

        UdpClient client;
        byte[] channel1 = BitConverter.GetBytes(0);
        byte[] channel2 = BitConverter.GetBytes(0);
        byte[] channel3 = BitConverter.GetBytes(0);
        byte[] channel4 = BitConverter.GetBytes(0);
        byte[] channel5 = BitConverter.GetBytes(0);
        byte[] channel6 = BitConverter.GetBytes(0);
        byte[] channel7 = BitConverter.GetBytes(0);
        byte[] channel8 = BitConverter.GetBytes(0);
        byte[] channel9 = BitConverter.GetBytes(0);
        byte[] channel10 = BitConverter.GetBytes(0);

        public Lights()
        {
            InitializeComponent();
            Update_T_Bars();
        }


        public void Send()
        {
            client = new UdpClient("192.168.1.99", 0x1936);
            byte[] artNet = new System.Text.ASCIIEncoding().GetBytes("Art-Net");
            byte[] data = new byte[18 + 512]; // 18 + number of channels

            // ID
            artNet.CopyTo(data, 0);
            data[7] = 0x00;

            // OpCode
            data[8] = 0x00;
            data[9] = 0x50;

            // ProtVerH
            data[10] = 0x00;
            //ProtVer
            data[11] = 0x0e;

            // Sequence
            data[12] = 0x01;

            // Physical
            data[13] = 0x00;

            // Universe
            data[14] = 0x00; // <- Universe Setting
            data[15] = 0x00;

            // LengthHi
            data[16] = 0x02; // Length High Byte
            // Length
            data[17] = 0x00; // Length Low Byte

            // Data[Length]
            channel1.CopyTo(data, 18);
            channel2.CopyTo(data, 19);
            channel3.CopyTo(data, 20);
            channel4.CopyTo(data, 21);
            channel5.CopyTo(data, 22);
            channel6.CopyTo(data, 23);
            channel7.CopyTo(data, 24);
            channel8.CopyTo(data, 25);
            channel9.CopyTo(data, 26);
            channel10.CopyTo(data, 27);


            client.Send(data, data.Length);
            Update_T_Bars();
        }



        public void Update_T_Bars()
        {

            int up_channel_1 = BitConverter.ToInt32(channel1, 0);
            string num_channel_1 = up_channel_1.ToString();
            tBar_Channel_1.Value = up_channel_1;
            lbl_Channel_1.Text = num_channel_1;

            int up_channel_2 = BitConverter.ToInt32(channel2, 0);
            string num_channel_2 = up_channel_2.ToString();
            tBar_Channel_2.Value = up_channel_2;
            lbl_Channel_2.Text = num_channel_2;

            int up_channel_5 = BitConverter.ToInt32(channel5, 0);
            string num_channel_5 = up_channel_5.ToString();
            tBar_Channel_5.Value = up_channel_5;
            lbl_Channel_5.Text = num_channel_5;

            int up_channel_6 = BitConverter.ToInt32(channel6, 0);
            string num_channel_6 = up_channel_6.ToString();
            tBar_Channel_6.Value = up_channel_6;
            lbl_Channel_6.Text = num_channel_6;

            int up_channel_3 = BitConverter.ToInt32(channel3, 0);
            string num_channel_3 = up_channel_3.ToString();
            tBar_Channel_3.Value = up_channel_3;
            lbl_Channel_3.Text = num_channel_3;

            int up_channel_4 = BitConverter.ToInt32(channel4, 0);
            string num_channel_4 = up_channel_4.ToString();
            tBar_Channel_4.Value = up_channel_4;
            lbl_Channel_4.Text = num_channel_4;

        }

        private void btn_Blackout_Click_1(object sender, EventArgs e)
        {
            t8roomoff();
            t8spotsoff();
            t9roomoff();
            t9spotsoff();
            t10roomoff();
            t10spotsoff();
        }

        private void tBar_Channel_2_Scroll(object sender, EventArgs e)
        {
            int channel_2 = tBar_Channel_2.Value;
            channel2 = BitConverter.GetBytes(channel_2);
            Send();
        }

        private void tBar_Channel_1_Scroll_1(object sender, EventArgs e)
        {
            int channel_1 = tBar_Channel_1.Value;
            channel1 = BitConverter.GetBytes(channel_1);
            Send();
        }

        private void btn_All_On_Click(object sender, EventArgs e)
        {
            alllightson();
        }

        public void alllightson()
        {
            t8roomon();
            t8spotson();
            t9roomon();
            t9spotson();
            t10roomon();
            t10spotson();
        }

        public void alllightsoff()
        {
            t8roomoff();
            t8spotsoff();
            t9roomoff();
            t9spotsoff();
            t10roomoff();
            t10spotsoff();
        }

        private void tBar_Channel_10_Scroll(object sender, EventArgs e)
        {
            int channel_10 = tBar_Channel_4.Value;
            channel10 = BitConverter.GetBytes(channel_10);
            Send();
        }

      

        private void tBar_Channel_5_Scroll(object sender, EventArgs e)
        {
            int channel_5 = tBar_Channel_5.Value;
            channel5 = BitConverter.GetBytes(channel_5);
            Send();
        }

        private void tBar_Channel_6_Scroll(object sender, EventArgs e)
        {


            int channel_6 = tBar_Channel_6.Value;
            channel6 = BitConverter.GetBytes(channel_6);
            Send();
        }

      

        public void t8spotson()
        {
            channel1 = BitConverter.GetBytes(255);
            Send();
        }
        public void t9spotson()
        {
            channel3 = BitConverter.GetBytes(255);
            Send();
        }
        public void t10spotson()
        {
            channel5 = BitConverter.GetBytes(255);
            Send();
        }
        public void t8spotsoff()
        {
            channel1 = BitConverter.GetBytes(0);
            Send();
        }
        public void t9spotsoff()
        {
            channel3 = BitConverter.GetBytes(0);
            Send();
        }
        public void t10spotsoff()
        {
            channel5 = BitConverter.GetBytes(0);
            Send();
        }

        public void t8roomon()
        {
            channel2 = BitConverter.GetBytes(255);
            Send();
        }
        public void t9roomon()
        {
            channel4 = BitConverter.GetBytes(255);
            Send();
        }
        public void t10roomon()
        {
            channel6 = BitConverter.GetBytes(255);
            Send();
        }
        public void t8roomoff()
        {
            channel2 = BitConverter.GetBytes(0);
            Send();
        }
        public void t9roomoff()
        {
            channel4 = BitConverter.GetBytes(0);
            Send();
        }
        public void t10roomoff()
        {
            channel6 = BitConverter.GetBytes(0);
            Send();
        }

        private void btn_t8spotson_Click(object sender, EventArgs e)
        {
            t8spotson();
        }

        private void btnt8roomon_Click(object sender, EventArgs e)
        {
            t8roomon();
        }

        private void btn_t9spotson_Click(object sender, EventArgs e)
        {
            t9spotson();
        }

        private void btn_t9roomon_Click(object sender, EventArgs e)
        {
            t9roomon();
        }

        private void btn_t10spotson_Click(object sender, EventArgs e)
        {
            t10spotson();
        }

        private void btn_t10roomon_Click(object sender, EventArgs e)
        {
            t10roomon();
        }

        private void btn_t8spotsoff_Click(object sender, EventArgs e)
        {
            t8spotsoff();
        }

        private void btn_t8roomoff_Click(object sender, EventArgs e)
        {
            t8roomoff();
        }

        private void btn_t9spotsoff_Click(object sender, EventArgs e)
        {
            t9spotsoff();
        }

        private void btn_t9roomoff_Click(object sender, EventArgs e)
        {
            t9roomoff();
        }

        private void btn_t10spotsoff_Click(object sender, EventArgs e)
        {
            t10spotsoff();
        }

        private void btn_t10roomoff_Click(object sender, EventArgs e)
        {
            t10roomoff();
        }

        private void tBar_Channel_3_Scroll(object sender, EventArgs e)
        {
             int channel_9 = tBar_Channel_3.Value;
            channel9 = BitConverter.GetBytes(channel_9);
            Send();
        }

    }
}