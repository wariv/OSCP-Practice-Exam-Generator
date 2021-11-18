using System;
using System.Diagnostics;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSCP_Practice_Exam_Generator
{
    public partial class form1 : Form
    {
        static Stopwatch sw = new Stopwatch();
        static System.Timers.Timer t = new System.Timers.Timer(1000);

        private void form1_Load(object sender, EventArgs e)
        {
            
        }

        private void lblTimer_Tick(object sender, EventArgs e)
        {
            updateTimer();
        }

        private void updateTimer()
        {
            TimeSpan ts = sw.Elapsed;
            int  eHours = ts.Hours;
            int eMinutes = ts.Minutes;
            int eSeconds = ts.Seconds;

            string tstring = "";

            if (eHours < 10) { tstring = tstring + "0" + eHours + ":"; } else { tstring = tstring + eHours + ":"; }
            if (eMinutes < 10) { tstring = tstring + "0" + eMinutes + ":"; } else { tstring = tstring + eMinutes + ":"; }
            if (eSeconds < 10) { tstring = tstring + "0" + eSeconds; } else { tstring = tstring + eSeconds; }



            //lblStopWatch.Text = "Hello World";
            lblStopWatch.Text = tstring;
        }

        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            sw.Restart();
            sw.Start();


            rtbOut.Text = "";
            List<string> winboxes = new List<string>();
            List<string> linboxes = new List<string>();

            //Include machines which were deemed harder than OSCP
            if (cbHarder.Checked) 
            {
                if (cbHTB.Checked)
                {
                    winboxes.Add("Jeeves - HTB");
                    winboxes.Add("Bart - HTB");
                    winboxes.Add("Tally - HTB");
                    winboxes.Add("Netmon - HTB");
                    winboxes.Add("Sizzle - HTB");
                    winboxes.Add("Sniper - HTB");
                    winboxes.Add("Control - HTB");
                    winboxes.Add("Nest - HTB");
                    winboxes.Add("Sauna - HTB");
                    winboxes.Add("Cascade - HTB");
                    winboxes.Add("Querier - HTB");
                    winboxes.Add("BlackField - HTB");
                    winboxes.Add("APT - HTB");
                    winboxes.Add("Atom - HTB");

                    linboxes.Add("Kotarak - HTB");
                    linboxes.Add("Falafel - HTB");
                    linboxes.Add("Devops - HTB");
                    linboxes.Add("Hawk - HTB");
                    linboxes.Add("Lightweight - HTB");
                    linboxes.Add("La Casa Del Papel - HTB");
                    linboxes.Add("Jail - HTB");
                    linboxes.Add("Safe - HTB");
                    linboxes.Add("Bitlab - HTB");
                    linboxes.Add("October - HTB");
                    linboxes.Add("Mango - HTB");
                    linboxes.Add("Book - HTB");
                    linboxes.Add("Quick - HTB");
                }

                if (cbPG.Checked)
                {
                    linboxes.Add("Bratarina - PG Practice");
                    linboxes.Add("Clyde - PG Practice");
                    linboxes.Add("Shifty - PG Practice");
                    linboxes.Add("XposedAPI - PG Practice");
                    linboxes.Add("Twiggy - PG Practice");

                    winboxes.Add("Internal - PG Practice");
                    winboxes.Add("Vector - PG Practice");
                    winboxes.Add("HelpDesk - PG Practice");
                }
            }

            //Include PG Practice Machines
            if (cbPG.Checked)
            {
                winboxes.Add("Nickel - PG Practice");
                winboxes.Add("Slort - PG Practice");
                winboxes.Add("Authby - PG Practice");
                winboxes.Add("Jacko - PG Practice");
                winboxes.Add("Meathead - PG Practice");
                winboxes.Add("UT99 - PG Practice");
                winboxes.Add("MedJed - PG Practice");
                winboxes.Add("Algeron - PG Practice");
                winboxes.Add("BillyBoss - PG Practice");
                winboxes.Add("Kevin - PG Practice");
                winboxes.Add("Butch - PG Practice");
                winboxes.Add("Metallus - PG Practice");

                linboxes.Add("ClamAV - PG Practice");
                linboxes.Add("Wombo - PG Practice");
                linboxes.Add("Payday - PG Practice");
                linboxes.Add("Fail - PG Practice");
                linboxes.Add("Nibbles - PG Practice");
                linboxes.Add("Banzai - PG Practice");
                linboxes.Add("Hunit - PG Practice");
                linboxes.Add("Dibble - PG Practice");
                linboxes.Add("Zino - PG Practice");
                linboxes.Add("Hetemit - PG Practice");
                linboxes.Add("Peppo - PG Practice");
                linboxes.Add("Postfish - PG Practice");
                //linboxes.Add("Malbec - PG Practice"); Removed not simulating BOF
                linboxes.Add("Sybaris - PG Practice");
            }

            //Include Hack The Box machines
            if (cbHTB.Checked)
            {
                winboxes.Add("Legacy - HTB");
                winboxes.Add("Blue - HTB");
                winboxes.Add("Devel - HTB");
                winboxes.Add("Optimum - HTB");
                winboxes.Add("Bastard - HTB");
                winboxes.Add("Granny - HTB");
                winboxes.Add("Arctic - HTB");
                winboxes.Add("Grandpa - HTB");
                winboxes.Add("Silo - HTB");
                winboxes.Add("Bounty - HTB");
                winboxes.Add("Jerry - HTB");
                winboxes.Add("Conceal - HTB");
                winboxes.Add("Chatterbox - HTB");
                winboxes.Add("Forest - HTB");
                winboxes.Add("BankRobber - HTB");
                winboxes.Add("Secnotes - HTB");
                winboxes.Add("Bastion - HTB");
                winboxes.Add("Buff - HTB");
                winboxes.Add("Servmon - HTB");
                winboxes.Add("Active - HTB");
                winboxes.Add("Remote - HTB");
                winboxes.Add("Fuse - HTB");
                winboxes.Add("Omni - HTB");
                winboxes.Add("Worker - HTB");

                linboxes.Add("Lame - HTB");
                linboxes.Add("Brainfuck - HTB");
                linboxes.Add("Shocker - HTB");
                linboxes.Add("Bashed - HTB");
                linboxes.Add("Nibbles - HTB");
                linboxes.Add("Beep - HTB");
                linboxes.Add("Cronos - HTB");
                linboxes.Add("Nineveh - HTB");
                linboxes.Add("Sense - HTB");
                linboxes.Add("Solidstate - HTB");
                linboxes.Add("Node - HTB");
                linboxes.Add("Valentine - HTB");
                linboxes.Add("Poison - HTB");
                linboxes.Add("Sunday - HTB");
                linboxes.Add("Tartarsauce - HTB");
                linboxes.Add("Irked - HTB");
                linboxes.Add("Friendzone - HTB");
                linboxes.Add("Swagshop - HTB");
                linboxes.Add("Networked - HTB");
                linboxes.Add("Jarvis - HTB");
                linboxes.Add("Mirai - HTB");
                linboxes.Add("Popcorn - HTB");
                linboxes.Add("Haircut - HTB");
                linboxes.Add("Blocky - HTB");
                linboxes.Add("Frolic - HTB");
                linboxes.Add("Postman - HTB");
                linboxes.Add("Traverxec - HTB");
                linboxes.Add("OpenAdmin - HTB");
                linboxes.Add("Magic - HTB");
                linboxes.Add("Admirer - HTB");
                linboxes.Add("Blunder - HTB");
                linboxes.Add("Tabby - HTB");
                linboxes.Add("Doctor - HTB");
                linboxes.Add("SneakyMailer - HTB");
                linboxes.Add("Passage - HTB");
                linboxes.Add("Luanne - HTB");
                linboxes.Add("Time - HTB");
                linboxes.Add("Ready - HTB");
                linboxes.Add("Delivery - HTB");
                linboxes.Add("Ophiuchi - HTB");
            }


            if (cbVuln.Checked)
            {
                linboxes.Add("DC 9: https://www.vulnhub.com/entry/dc-9,412/");
                linboxes.Add("Digitalworld.local (Bravery): https://www.vulnhub.com/entry/digitalworldlocal-bravery,281/");
                linboxes.Add("Digitalworld.local (Development): https://www.vulnhub.com/entry/digitalworldlocal-development,280/");
                linboxes.Add("Digitalworld.local (Mercy v2): https://www.vulnhub.com/entry/digitalworldlocal-mercy-v2,263/");
                linboxes.Add("Digitalworld.local (JOY): https://www.vulnhub.com/entry/digitalworldlocal-joy,298/");
                linboxes.Add("Prime 1: https://www.vulnhub.com/entry/prime-1,358/");
                linboxes.Add("Symfonos 1: https://www.vulnhub.com/entry/symfonos-1,322/");
                linboxes.Add("Symfonos 2: https://www.vulnhub.com/entry/symfonos-2,331/");
                linboxes.Add("Symfonos 3: https://www.vulnhub.com/entry/symfonos-3,332/");
                linboxes.Add("Symfonos 4: https://www.vulnhub.com/entry/symfonos-4,347/");
                linboxes.Add("Symfonos 5.2: https://www.vulnhub.com/entry/symfonos-52,415/");
                linboxes.Add("Misdirection 1: https://www.vulnhub.com/entry/misdirection-1,371/");
                linboxes.Add("Sar 1: https://www.vulnhub.com/entry/sar-1,425/");
                linboxes.Add("Djinn 1: https://www.vulnhub.com/entry/djinn-1,397/");
                linboxes.Add("EVM 1: https://www.vulnhub.com/entry/evm-1,391/");
                linboxes.Add("DerpNStink 1: https://www.vulnhub.com/entry/derpnstink-1,221/");
                linboxes.Add("RickdiculouslyEasy 1: https://www.vulnhub.com/entry/rickdiculouslyeasy-1,207/");
                linboxes.Add("Tommy Boy 1: https://www.vulnhub.com/entry/tommy-boy-1,157/");
                linboxes.Add("Breach 1: https://www.vulnhub.com/entry/breach-1,152/");
                linboxes.Add("Breach 2.1: https://www.vulnhub.com/entry/breach-21,159/");
                linboxes.Add("Breach 3.0.1: https://www.vulnhub.com/entry/breach-301,177/");
                linboxes.Add("NullByte: https://www.vulnhub.com/entry/nullbyte-1,126/");
                linboxes.Add("Bob 1.0.1: https://www.vulnhub.com/entry/bob-101,226/");
                linboxes.Add("Toppo 1: https://www.vulnhub.com/entry/toppo-1,245/");
                linboxes.Add("W34kn3ss 1: https://www.vulnhub.com/entry/w34kn3ss-1,270/");
                linboxes.Add("GoldenEye 1: https://www.vulnhub.com/entry/goldeneye-1,240/");
                linboxes.Add("Infosec Prep OSCP Box: https://www.vulnhub.com/entry/infosec-prep-oscp,508/");
                linboxes.Add("LemonSqueezy: https://www.vulnhub.com/entry/lemonsqueezy-1,473/");
                linboxes.Add("Brainpan 1: https://www.vulnhub.com/entry/brainpan-1,51/");
                linboxes.Add("Pinkys Palace v1: https://www.vulnhub.com/entry/pinkys-palace-v1,225/");
                linboxes.Add("Lord of the root 1.0.1: https://www.vulnhub.com/entry/lord-of-the-root-101,129/");
                linboxes.Add("Tiki-1: https://www.vulnhub.com/entry/tiki-1,525/");
                linboxes.Add("Healthcare 1: https://www.vulnhub.com/entry/healthcare-1,522/");
                linboxes.Add("Photographer 1: https://www.vulnhub.com/entry/photographer-1,519/");
                linboxes.Add("Glasglow 1.1: https://www.vulnhub.com/entry/glasgow-smile-11,491/");
                linboxes.Add("DevGuru 1: https://www.vulnhub.com/entry/devguru-1,620/");
                linboxes.Add("Alpha 1: https://www.vulnhub.com/entry/alfa-1,655/");
            }


            Random r = new Random();

            rtbOut.AppendText("-- LINUX --\n");
            for (int i = 1; i <= 2; i++)
            {
                int id = r.Next(0, (linboxes.Count - 1));
                rtbOut.AppendText(linboxes[id] + "\n");
                linboxes.RemoveAt(id);
            }

            rtbOut.AppendText("\n\n");
            rtbOut.AppendText("-- WIN --\n");

            for (int i = 1; i <= 2; i++)
            {
                int id = r.Next(0, (winboxes.Count - 1));
                rtbOut.AppendText(winboxes[id] + "\n");
                winboxes.RemoveAt(id);
            }


        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            sw.Stop();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            sw.Restart();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            sw.Start();
        }

        
    }
}
