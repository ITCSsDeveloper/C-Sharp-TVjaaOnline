using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;
using System.IO;

namespace TV_jaa_Online_by_Gmtan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            webBrowser1.Navigate("http://www.tvjaa.com/stream/5-channel-nipa.html");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream2/3-channel-thaitv3.html");
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            webBrowser1.Navigate("http://www.bugaboo.tv/themes/third_party/mediaplayer/player.swf?file=livech71&streamer=rtmp://112.121.153.92/liveedgech7&autostart=true&stretching=exactfit");
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            webBrowser1.Navigate("http://www.tvjaa.com/stream/mcot-2.html");
        }

        private void button5_Click(object sender, EventArgs e)
        { 
            webBrowser1.Navigate("http://www.tvjaa.com/stream/nbtlive.html");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://tv.truelife.com/content/flashplayer/104614");
        }


        private void button7_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/nationchannel-2.html");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/voicetv.html");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/springnews.html");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://tv.truelife.com/content/flashplayer/1838618");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://tv.truelife.com/content/flashplayer/104616");
        }


        private void button12_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://tv.truelife.com/content/flashplayer/104605");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://tv.truelife.com/content/flashplayer/104617");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/thaipbs.html");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www2.ch7.com/live");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             System.Diagnostics.Process.Start("http://www.speedtest.net");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://speedtest.adslthailand.com/");
        }

        private void nASALIVETVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/nasa_live.html");
        }

        private void nASALIVEEducationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/nasa_education.html");
        }

        private void kBS24ChanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/kbs24.html");
        }

        private void nHKWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/nhkworld.html");
        }

        private void arirangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/arirang.html");
        }

        private void fOXNEWSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tvjaa.com/out.php?url=http://live.foxnews.com/");
            webBrowser1.Navigate("");
        }

        private void fRANCE24ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/france24.html");
        }

        private void cCTVNEWSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/cctvnews.html");
        }

        private void oRANGESportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/orangesport.html");
        }

        private void sKYNEWSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/skynews.html");
        }

        private void bBCWorldNewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tvjaa.com/out.php?url=http://www.livestation.com/channels/10-bbc-world-news-english");
            webBrowser1.Navigate("");
        }

        private void pressTVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/presstv.html");
        }

        private void cartoonClubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://tv.truelife.com/content/flashplayer/105021");
        }

        private void gangCartoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.gangcartoon.net/");
            webBrowser1.Navigate("");
        }

        private void oldCartoonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/cartoon1.html");
        }

        private void cartoonClassicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/cartoon2.html");
        }

        private void smileChildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/smilechild.html");
        }

        private void channelVThailandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/channelvthailand.html");
        }

        private void yAAKTVชองของคนรนใหมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/yaakchannel.html");
        }

        private void yOU2Playฟงเพลงตลอด24ชมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/you2play.html");
        }

        private void yOUChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/youchannel.html");
        }

        private void pLAYChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/playchannel.html");
        }

        private void gREENChannalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/greenchannel.html");
        }

        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/gmember.html");
        }

        private void bANGCHannelเพลงและวาไรตToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/bangchannel.html");
        }

        private void virginRockTVChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/virginlive.html");
        }

        private void สบายดทวToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/sabaideetv.html");
        }

        private void trueMusicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tvjaa.com/out.php?url=http://tv.truelife.com/player/truevisions/truemusic");
            webBrowser1.Navigate("http://www.aimiszu.net/ictvip55/78544.html");
        }

        private void aFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tvjaa.com/out.php?url=http://trueaf.truelife.com/");
            webBrowser1.Navigate("http://www.aimiszu.net/ictvip55/78544.html");
        }

        private void aFChanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tvjaa.com/out.php?url=http://tv.truelife.com/player/truevisions/afch");
            webBrowser1.Navigate("http://www.aimiszu.net/ictvip55/78544.html");
        }

        private void fANTVเพลงลกทงฮตToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/out.php?url=http://tv.truelife.com/content/flashplayer/105028");
        }

        private void chiangmaiLiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/chiangmailive.html");
        }

        private void meediaChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/out.php?url=http://tv.truelife.com/content/flashplayer/105001");
        }

        private void mChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/m-channel.html");
        }

        private void majorMixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/majormix.html");
        }

        private void major2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/major2.html");
        }

        private void major4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/major4.html");
        }

        private void มงคลภาพยนตToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/out.php?url=http://tv.truelife.com/content/flashplayer/104991");
        }

        private void sMMTVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/smmtv.html");
        }

        private void ดVlloeyballสญญาณLaola1tvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/volleyball.html");
        }

        private void ชองGMMSportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tvjaa.com/out3d.php?url=http://www.gmmsport.com/livechannel/live_stream.php");
            webBrowser1.Navigate("http://www.aimiszu.net/ictvip55/78544.html");
        }

        private void สยามกฬาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tvjaa.com/out3d.php?url=http://tv.ohozaa.com/live/siamsport/");
            webBrowser1.Navigate("http://www.aimiszu.net/ictvip55/78544.html");
        }

        private void สตารซอกเกอรTVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tvjaa.com/out3d.php?url=http://tv.ohozaa.com/live/starsoccer/");
            webBrowser1.Navigate("http://www.aimiszu.net/ictvip55/78544.html");
        }

        private void rSSportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tvjaa.com/out3d.php?url=http://tv.ohozaa.com/live/rssportlaliga/");
            webBrowser1.Navigate("http://www.aimiszu.net/ictvip55/78544.html");
        }

        private void eSPNHDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tvjaa.com/out3d.php?url=http://www.wezatv.com/dootv/hd.php");
            webBrowser1.Navigate("http://www.aimiszu.net/ictvip55/78544.html");
        }

        private void dMCChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/dmc2.html");
        }

        private void tBCChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/tbc.html");
        }

        private void fMTVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/fmtv.html");
        }

        private void wBTVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/wbtv.html");
        }

        private void หลวงตาบวToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/luangta.html");
        }

        private void dDTVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/ddtv.html");
        }

        private void tVMuslimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/tvmuslim.html");
        }

        private void whiteChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/whitechannel.html");
        }

        private void nATGEOWILDสารคดสตวโลกToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tvjaa.com/out3d.php?url=http://tv.ohozaa.com/live/nat/");
            webBrowser1.Navigate("http://www.aimiszu.net/ictvip55/78544.html");
        }

        private void cATChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/catchannel.html");
        }

        private void tCCTVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/tcctv.html");
        }

        private void tCCTV2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/tcctv2.html");
        }

        private void tCITVรายการไทยภาษาจนToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/tcitv.html");
        }

        private void drTVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/drtv.html");
        }

        private void foodPlanetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/foodplanet.html");
        }

        private void kStationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/kstation.html");
        }

        private void cH8TCCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/ch8tcc.html");
        }

        private void iDeaTV8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/ideatv8.html");
        }

        private void eTVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/etv.html");
        }

        private void zAANetworkซา24ชมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/zaanetwork.html");
        }

        private void cH8FREEVARIETYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/ch8.html");
        }

        private void aCTSChannelละครบนเทงToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/out.php?url=http://tv.truelife.com/content/flashplayer/104662");
        }

        private void สาระแนฮา24ขมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/saranair.html");
        }

        private void workPointTVวาไรตเตมจอToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/workpointlive.html");
        }

        private void เวทไทยสถานคนลกทงToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/veteethailive.html");
        }

        private void gTVTHAILANDสาระบงเทงชาวสรงToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/gtvthailand.html");
        }

        private void healthPlusสขภาพ24ชมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/hpluschannel.html");
        }

        private void mAXXITVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/maxxitv.html");
        }

        private void zabbChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/zabbchannel.html");
        }

        private void grandprixChannelรทกเรองยานยนตToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/grandprixchannel.html");
        }

        private void speedChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/speedchannel.html");
        }

        private void mANTVชองสำหรบหนมๆToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/mantv.html");
        }

        private void creativeLivingChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/creativeliving.html");
        }

        private void tOPSTARChannelรายการสาระบนเทงToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/topstar.html");
        }

        private void mIXVaritrtyบนเทงวาไรตToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/mix24.html");
        }

        private void mangoTVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tvjaa.com/out.php?url=http://dcs-digital.com/mangotv/indexnew.php");
            webBrowser1.Navigate("http://www.aimiszu.net/ictvip55/78544.html");
        }

        private void travelChannelThailandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/out3d.php?url=http://www.travelchannel.co.th/");
        }

        private void mysteryChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/mysterychannel.html");
        }

        private void mYTVChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/mytv.html");
        }

        private void niceChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/nicechannel.html");
        }

        private void อารมณดทวToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/rromdtv.html");
        }

        private void ไทยไชโยToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/thaichaiyo.html");
        }

        private void pOPLiveสาระบนเทงToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/poplive.html");
        }

        private void likeTVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/liketv.html");
        }

        private void laoStarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/laostar.html");
        }

        private void laoStarMTVฟงเพลงเพราะๆToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/laostarmtv.html");
        }

        private void jawelryChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/jewelrychannel.html");
        }

        private void miracleเรองเหลอเชอลกลบToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/out.php?url=http://tv.truelife.com/content/flashplayer/104974");
        }

        private void hiWinchรายการบนเทงToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/hiwinch.html");
        }

        private void nATTYChannelสาระบนเทงToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/natty.html");
        }

        private void เจรญเคเบลทวToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/charoen.html");
        }

        private void iNTVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/intv.html");
        }

        private void kChammelบนเทงไทยเกาหลToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/out.php?url=http://tv.truelife.com/content/flashplayer/105011");
        }

        private void pandaดชวงๆกบหลนปงToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/out.php?url=http://tv.truelife.com/content/flashplayer/104639");
        }

        private void ผจดทำToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form A = new Form2();
            A.Show();
        }

        bool G = false;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (G == false)
            {
                button16.Enabled = false;
                button17.Enabled = false;

                SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                    (IntPtr)APPCOMMAND_VOLUME_MUTE);

                G = true;
            }
            else if (G == true)
            {
                button16.Enabled = true;
                button17.Enabled = true;

                SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                    (IntPtr)APPCOMMAND_VOLUME_MUTE);

                G = false;
            }
        }

        private const int APPCOMMAND_VOLUME_MUTE = 0x80000;
        private const int APPCOMMAND_VOLUME_UP = 0xA0000;
        private const int APPCOMMAND_VOLUME_DOWN = 0x90000;
        private const int WM_APPCOMMAND = 0x319;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg,
            IntPtr wParam, IntPtr lParam);

        private void button17_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
                (IntPtr)APPCOMMAND_VOLUME_UP);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            SendMessageW(this.Handle, WM_APPCOMMAND, this.Handle,
               (IntPtr)APPCOMMAND_VOLUME_DOWN);
        }

        private void tNEWSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/tnews.html");
        }

        private void moneyChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tvjaa.com/out3d.php?url=http://tv.truelife.com/content/flashplayer/104628");
            webBrowser1.Navigate("http://www.aimiszu.net/ictvip55/78544.html");
        }

        private void thaiTVDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/thaitvdlive.html");
        }

        private void เดลนวสทวToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/dailynewstv.html");
        }

        private void aSTVNews1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/astv.html");
        }

        private void asiaUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/asiaupdate2.html");
        }

        private void blueSkyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/blueskychannel.html");
        }

        private void mediaNewsรอบรขาวทวไทยToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/mediachannel.html");
        }

        private void iNNNewsขาวเดนประเดนรอนToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/innnews.html");
        }

        private void iBTVอสระขาวและความรToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/ibtv-live.html");
        }

        private void tNN24ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tvjaa.com/out.php?url=http://www.tnnthailand.com/player.php");
            webBrowser1.Navigate("http://www.aimiszu.net/ictvip55/78544.html");
        }

        private void tNN2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tvjaa.com/out.php?url=http://tv.truelife.com/player/truevisions/tnn2");
            webBrowser1.Navigate("http://www.aimiszu.net/ictvip55/78544.html");
        }

        private void bankokBizธรกจและการลงทนToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/bangkokbiz.html");
        }

        private void ชองระวงภยToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tvjaa.com/out.php?url=http://www.rawangpai.com/home/index_live.php");
            webBrowser1.Navigate("http://www.aimiszu.net/ictvip55/78544.html");
        }

        private void mcot1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/mcot1.html");
        }

        private void aseanTVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/aseantv.html");
        }

        private void สยามไทยToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/13siamthai.html");
        }

        private void kIMENGขาวสารหนการเงนToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/kimeng.html");
        }

        private void ebizChannelเจาะขาวธรกจToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tvjaa.com/out.php?url=http://www.ebizchannel.tv/");
            webBrowser1.Navigate("http://www.aimiszu.net/ictvip55/78544.html");
        }

        private void kCTVขาวจงหวดโคราชToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/kctv.html");
        }

        private void iNewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/inews.html");
        }

        private void mV5TVChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/mv5tv.html");
        }

        private void tGNChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/tgn.html");
        }

        private void pTVโทรทศนรฐสภาToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/ptv.html");
        }

        private void ชองสวรรณภมToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.tvjaa.com/stream/suwannabhumi.html");
        }

        private void chatboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form A = new Form3();
            A.Show();
        }

        private void facebookGmtanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/tvjaa");
        }

        private void downloadFlashPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.filehippo.com/download_flashplayer_ie/");
        }

        private void downloadInternetExprToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://windows.microsoft.com/th-TH/internet-explorer/downloads/ie");
        }

        private void tVJaaacomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.tvjaa.com");
        }

        private void แชทFacebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/tvjaa");
        }

        private void แชทTVJaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/tvjaa");
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form A = new Form2();
            A.Show();
        }

        private void chatBoxToDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form A = new Form3();
            A.Show();
        }

        private void facebookDeveloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.facebook.com/GmtanBeartai2010");
        }

        private void iTSundayทสดของคนรกไอทToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.facebook.com/ITsundayTV");
        }

        bool B = false;
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (B == false)
            {
                this.TopMost = true;
                B = true;
            }

            else if (B == true)
            {
                this.TopMost = false;
                B = false;
            }
        }

        int K = 0,L =0;

        private void Form1_Load(object sender, EventArgs e)
        {

            //    StreamWriter A; StreamReader B;

            //    try
            //    {
            //        B = File.OpenText(@"C:\Program Files\info.key");
            //        K = int.Parse(B.ReadLine());
            //        L = int.Parse(B.ReadLine());
            //        B.Close();

            //        if (L == 3)
            //        {
            //            goto T;
            //        }

            //        File.Delete(@"C:\Program Files\info.key");

            //        A = File.CreateText(@"C:\Program Files\info.key");
            //        A.WriteLine(K - 1);
            //        A.WriteLine("1");
            //        A.Close();

            //        if (K == 0 || K<-0)
            //        {
            //            MessageBox.Show("\aคุณได้ใช้สิทธิ์การทดลองโปรแกรมหมดแล้ว\nกรุณาติดต่อเจ้าของโปรแกรมครับ");

            //            File.Delete(@"C:\Program Files\info.key");

            //            A = File.CreateText(@"C:\Program Files\info.key");
            //            A.WriteLine("0");
            //            A.WriteLine("0");
            //            A.Close();

            //            Application.Exit();
            //        }

            //        else
            //        {MessageBox.Show("\aคุณมีสิทธิ์ทดลองใช้โปรแกรมอีก " + K + " ครั้ง");}


            //    T:
            //        { }
            //    }


            //    catch (Exception)
            //    {
            //        int I = 5;
            //        A = File.CreateText(@"C:\Program Files\info.key");
            //        A.WriteLine(I);
            //        A.WriteLine("0");
            //        A.Close();
            //        MessageBox.Show("\aคุณมีสิทธิ์ทดลองใช้โปรแกรมอีก " + I + " ครั้ง");

            //    }
            //}
        }
    }
}
    
        //System.Diagnostics.Process.Start("");
        //webBrowser1.Navigate("");

