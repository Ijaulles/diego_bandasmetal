using diego_bandasmetal.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diego_bandasmetal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Slipknot");
            listBox1.Items.Add("Korn");
            listBox1.Items.Add("Avenged Sevenfold");
            listBox1.Items.Add("System of a Down");

            comboBox1.Items.Add("");
            comboBox1.Items.Add("Trajetória");
            comboBox1.Items.Add("Discografia");
            comboBox1.Items.Add("Integrantes");
            listBox1.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == 0)
            {
                this.BackgroundImage = Properties.Resources.ceifador;
                SoundPlayer simpleSound = new SoundPlayer();
                simpleSound.Stop(); 

                groupBox2.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;

                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;


                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                pictureBox10.Image = null;
                pictureBox11.Image = null;
                pictureBox12.Image = null;

                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;

                comboBox1.Visible = false;

                label1.ForeColor = SystemColors.ButtonHighlight;

            }
            
            else if (listBox1.SelectedIndex == 1)
            {
                pictureBox12.Visible = false;
                SoundPlayer simpleSound = new SoundPlayer();
                simpleSound.Stop();


                pictureBox11.Visible = true;
                pictureBox11.Image = Properties.Resources.show;

                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;

                comboBox1.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;

                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;

                if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true || radioButton5.Checked == true || radioButton6.Checked == true)
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                    
                }
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                pictureBox10.Image = null;
                pictureBox11.Image = null;
                pictureBox12.Image = null;
                comboBox1.SelectedIndex = 0;
                this.BackgroundImage = Properties.Resources.backnot;
                label1.Text = "";
                

                if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true)
                {
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                }

                

                checkBox1.Text = "The Subliminal Verses";
                checkBox2.Text = "The Gray Chapter";
                checkBox3.Text = "All Hope is Gone";

                radioButton1.Text = "Corey Taylor";
                radioButton2.Text = "Eloy Casagrande";
                radioButton3.Text = "Shawn Crahan";
                radioButton4.Text = "Sid Wilson";
                radioButton5.Text = "Michael Pfaff";
                radioButton6.Text = "Jim Root";
                radioButton5.Visible = true;
                radioButton6.Visible = true;
      
                pictureBox10.Image = Properties.Resources.sicon;
                pictureBox11.Image = Properties.Resources.show;
                label1.ForeColor = SystemColors.ButtonHighlight;

            }
            else if (listBox1.SelectedIndex == 2)
            {
                pictureBox12.Visible = false;
                SoundPlayer simpleSound = new SoundPlayer();
                simpleSound.Stop();

                pictureBox11.Visible = true;
                pictureBox11.Image = Properties.Resources.kornlogo;

                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;

                comboBox1.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;

                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;

                if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true || radioButton5.Checked == true || radioButton6.Checked == true) 
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                }
                pictureBox1.Image = null; 
                pictureBox2.Image = null; 
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                pictureBox10.Image = null;
                pictureBox11.Image = null;
                comboBox1.SelectedIndex = 0;
                this.BackgroundImage = Properties.Resources.milho;
                comboBox1.SelectedIndex = 0;
                label1.Text = "";
                
                
                if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true)
                {
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                }

                

                checkBox1.Text = "Follow the Leader";
                checkBox2.Text = "Issues";
                checkBox3.Text = "Korn";

                radioButton1.Text = "Jonathan Davis";
                radioButton2.Text = "James Shaffer";
                radioButton3.Text = "Brian Welch";
                radioButton4.Text = "Ray Luzier";
                radioButton5.Text = "";
                radioButton6.Text = "";
                radioButton5.Visible = false;
                radioButton6.Visible = false;

                pictureBox11.Image = Properties.Resources.kornlogo;
                label1.ForeColor = SystemColors.ButtonHighlight;

            }
            else if (listBox1.SelectedIndex == 3)
            {
                pictureBox12.Visible = false;
                SoundPlayer simpleSound = new SoundPlayer();
                simpleSound.Stop();

                pictureBox11.Visible = true;
                pictureBox11.Image = Properties.Resources.rodaesq;

                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;

                comboBox1.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;

                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;

                if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true || radioButton5.Checked == true || radioButton6.Checked == true)
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                }

                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                pictureBox10.Image = null;
                pictureBox11.Image = null;

                comboBox1.SelectedIndex = 0;

                this.BackgroundImage = Properties.Resources.avengers;

                label1.Text = "";
                

                if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true)
                {
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                }

                

                checkBox1.Text = "Hail to the King";
                checkBox2.Text = "City of Evil";
                checkBox3.Text = "Nightmare";

                radioButton1.Text = "M. Shadows";
                radioButton2.Text = "Zacky Vengeance";
                radioButton3.Text = "Synyster Gates";
                radioButton4.Text = "Johnny Christ";
                radioButton5.Text = "Brooks Wackerman";
                radioButton6.Text = "";
                radioButton5.Visible = true;
                radioButton6.Visible = false;

                pictureBox11.Image = Properties.Resources.rodaesq;

                label1.ForeColor = SystemColors.ButtonHighlight;

            }
            else if (listBox1.SelectedIndex == 4)
            {
                pictureBox12.Visible = false;
                SoundPlayer simpleSound = new SoundPlayer();
                simpleSound.Stop();

                pictureBox11.Visible = true;
                pictureBox11.Image = Properties.Resources.tankei;

                groupBox2.Visible = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;

                comboBox1.Visible = true;
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;

                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;

                if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true || radioButton5.Checked == true || radioButton6.Checked == true)
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                    radioButton5.Checked = false;
                    radioButton6.Checked = false;
                }

                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;
                pictureBox10.Image = null;
                pictureBox11.Image = null;

                comboBox1.SelectedIndex = 0;

                this.BackgroundImage = Properties.Resources.acucar;

                label1.Text = "";


                if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true)
                {
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                }



                checkBox1.Text = "Toxicity";
                checkBox2.Text = "Steal This Album!";
                checkBox3.Text = "Mezmerzize";

                radioButton1.Text = "Serj Tankian";
                radioButton2.Text = "Daron Malakian";
                radioButton3.Text = "Shavo Odadjian";
                radioButton4.Text = "John Dolmayan";
                radioButton5.Text = "";
                radioButton6.Text = "";
                radioButton5.Visible = false;
                radioButton6.Visible = false;

                pictureBox11.Image = Properties.Resources.tankei;
               
                

            }
        }
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
    
                if (listBox1.SelectedIndex == 1)
                {
                    pictureBox1.Image = Properties.Resources.slip;

                    if (checkBox1.Checked == false)
                    {
                        this.pictureBox1.Image = null;
                    }
                } else if (listBox1.SelectedIndex == 2)
                {
                    pictureBox1.Image = Properties.Resources.leader;

                    if (checkBox1.Checked == false)
                    {
                        this.pictureBox1.Image = null;
                    }
                }else if (listBox1.SelectedIndex == 3)
                {
                    pictureBox1.Image = Properties.Resources.king;

                    if (checkBox1.Checked == false)
                    {
                        this.pictureBox1.Image = null;
                    }
                }else if (listBox1.SelectedIndex == 4)
                {
                    pictureBox1.Image = Properties.Resources.tocico;

                    if (checkBox1.Checked == false)
                    {
                        this.pictureBox1.Image = null;
                    }
                }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
                if (listBox1.SelectedIndex == 1)
                {
                    pictureBox2.Image = Properties.Resources.graychp;

                    if (checkBox2.Checked == false)
                    {
                        this.pictureBox2.Image = null;
                    }
                } else if (listBox1.SelectedIndex == 2)
                    {
                
                    pictureBox2.Image = Properties.Resources.issues;

                    if (checkBox2.Checked == false)
                    {
                        this.pictureBox2.Image = null;
                    }
                
                } else if (listBox1.SelectedIndex == 3)
                    {
                
                    pictureBox2.Image = Properties.Resources.evil;

                    if (checkBox2.Checked == false)
                    {
                        this.pictureBox2.Image = null;
                    }
                
                }else if (listBox1.SelectedIndex == 4)
                    {
                
                    pictureBox2.Image = Properties.Resources.roubo;

                    if (checkBox2.Checked == false)
                    {
                        this.pictureBox2.Image = null;
                    }
                
                }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 1)
            {
                pictureBox3.Image = Properties.Resources.hope;

                if(checkBox3.Checked == false)
                {                    
                        this.pictureBox3.Image = null;
                }
            } else if (listBox1.SelectedIndex == 2)
            {

                pictureBox3.Image = Properties.Resources.girl;

                if (checkBox3.Checked == false)
                {
                    this.pictureBox3.Image = null;
                }

            } else if (listBox1.SelectedIndex == 3)
            {

                pictureBox3.Image = Properties.Resources.pesado;

                if (checkBox3.Checked == false)
                {
                    this.pictureBox3.Image = null;
                }

            }else if (listBox1.SelectedIndex == 4)
            {

                pictureBox3.Image = Properties.Resources.memoria;

                if (checkBox3.Checked == false)
                {
                    this.pictureBox3.Image = null;
                }

            }

        }

        private void pictureBox12_Click_1(object sender, EventArgs e)
        {

        }
        
        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 1)
            {
                pictureBox4.Image = Properties.Resources.corey;
                if (radioButton2.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true || radioButton5.Checked == true || radioButton6.Checked == true)
                {
                    this.pictureBox4.Image = null;
                }
            } else if (listBox1.SelectedIndex == 2)
            {
                pictureBox4.Image = Properties.Resources.john;
                if (radioButton2.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true || radioButton5.Checked == true || radioButton6.Checked == true)
                {
                    this.pictureBox4.Image = null;
                }
            } else if (listBox1.SelectedIndex == 3)
            {
                pictureBox4.Image = Properties.Resources.shadow;
                if (radioButton2.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true || radioButton5.Checked == true)
                {
                    this.pictureBox4.Image = null;
                }
            }else if (listBox1.SelectedIndex == 4)
            {
                pictureBox4.Image = Properties.Resources.sergio;
                if (radioButton2.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true || radioButton5.Checked == true)
                {
                    this.pictureBox4.Image = null;
                }
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 1)
            {
                pictureBox5.Image = Properties.Resources.eloy;
                if (radioButton1.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true || radioButton5.Checked == true || radioButton6.Checked == true)
                {
                    this.pictureBox5.Image = null;
                }
            }
            else if (listBox1.SelectedIndex == 2)
            {
                pictureBox5.Image = Properties.Resources.munky;
                if (radioButton1.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true || radioButton5.Checked == true || radioButton6.Checked == true)
                {
                    this.pictureBox5.Image = null;
                }
            }
            else if (listBox1.SelectedIndex == 3)
            {
                pictureBox5.Image = Properties.Resources.zack;
                if (radioButton1.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true || radioButton5.Checked == true)
                {
                    this.pictureBox5.Image = null;
                }
            }else if (listBox1.SelectedIndex == 4)
            {
                pictureBox5.Image = Properties.Resources.daria;
                if (radioButton1.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true || radioButton5.Checked == true)
                {
                    this.pictureBox5.Image = null;
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 1)
            {
                pictureBox6.Image = Properties.Resources.shawn;
                if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton4.Checked == true || radioButton5.Checked == true || radioButton6.Checked == true)
                {
                    this.pictureBox6.Image = null;
                }
            }
            else if (listBox1.SelectedIndex == 2)
            {
                pictureBox6.Image = Properties.Resources.brian;
                if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton4.Checked == true || radioButton5.Checked == true || radioButton6.Checked == true)
                {
                    this.pictureBox6.Image = null;
                }
            }
            else if (listBox1.SelectedIndex == 3)
            {
                pictureBox6.Image = Properties.Resources.syn;
                if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton4.Checked == true || radioButton5.Checked == true)
                {
                    this.pictureBox6.Image = null;
                }
            }else if (listBox1.SelectedIndex == 4)
            {
                pictureBox6.Image = Properties.Resources.chaves;
                if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton4.Checked == true || radioButton5.Checked == true)
                {
                    this.pictureBox6.Image = null;
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 1)
            {
                pictureBox7.Image = Properties.Resources.sidw;
                if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton5.Checked == true || radioButton6.Checked == true)
                {
                    this.pictureBox7.Image = null;
                }
            }
             else if (listBox1.SelectedIndex == 2)
            {
                pictureBox7.Image = Properties.Resources.ray;
                if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton5.Checked == true || radioButton6.Checked == true)
                {
                    this.pictureBox7.Image = null;
                }
            }
            else if (listBox1.SelectedIndex == 3)
            {
                pictureBox7.Image = Properties.Resources.cristo;
                if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton5.Checked == true || radioButton6.Checked == true)
                {
                    this.pictureBox7.Image = null;
                }
            }
            else if (listBox1.SelectedIndex == 4)
            {
                pictureBox7.Image = Properties.Resources.john1;
                if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton5.Checked == true || radioButton6.Checked == true)
                {
                    this.pictureBox7.Image = null;
                }
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 1)
            {
                pictureBox8.Image = Properties.Resources.pfaff;
                if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true || radioButton6.Checked == true)
                {
                    this.pictureBox8.Image = null;
                }
            }
            else if (listBox1.SelectedIndex == 3)
            {
                pictureBox8.Image = Properties.Resources.brook;
                if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true || radioButton6.Checked == true)
                {
                    this.pictureBox8.Image = null;
                }
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 1)
            {
                pictureBox9.Image = Properties.Resources.jim;
                if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true || radioButton4.Checked == true || radioButton5.Checked == true)
                {
                    this.pictureBox9.Image = null;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 1) {
                if (comboBox1.SelectedIndex == 0)
                {
                    label1.Text = null;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                label1.Text = "O Slipknot é uma banda de metal alternativo dos Estados Unidos formada em 1995 em Des Moines, Iowa. Reconhecidos por suas máscaras distintas e energia intensa no palco, eles se destacaram com seu álbum de estreia autointitulado em 1999, seguido pelo sucesso de \"Iowa\" em 2001. " +
                    "A banda mistura elementos de nu-metal e metal alternativo com letras introspectivas e pesadas. Ao longo dos anos, enfrentaram mudanças na formação e tragédias, como a morte de Paul Gray em 2010, mas continuaram a evoluir musicalmente com álbuns como \"Vol. 3: (The Subliminal Verses)\" em 2004 e \".5: The Gray Chapter\" em 2014." +
                    " Com uma base de fãs leal e global, o Slipknot continua sendo uma influência importante no cenário do metal contemporâneo.";
                }else if (comboBox1.SelectedIndex == 2)
                {
                label1.Text = "Álbuns de estúdio\r\nSlipknot (1999)\r\nIowa (2001)\r\nVol. 3: (The Subliminal Verses) (2004)\r\nAll Hope Is Gone (2008)\r\n.5: The Gray Chapter (2014)\r\nWe Are Not Your Kind (2019)\r\nThe End, So Far (2022)";
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                label1.Text = "    Integrantes\r\nSid Wilson - DJ (1998-presente), James Root - guitarra (1999-presente), Shawn Crahan - percussão e vocal de apoio (1995-presente), Mick Thomson - guitarra (1996-presente), Corey Taylor - vocais (1997-presente), Alessandro Venturella - baixo (2014-presente), Michael Pfaff - percussão e vocal de apoio (2019-presente), Eloy Casagrande - bateria (2024-presente)\r\n   Ex-integrantes\r\nJoey Jordison (falecido) - bateria (1995-2013), Paul Gray (falecido) - baixo (1995-2010), Chris Fehn - percussão e vocal de apoio (1998-2019), Josh Brainard - guitarra rítmica (1995-1999), Craig Jones - sampler e teclado (1996-2023), Jay Weinberg - bateria (2014-2023), Donnie Steele - guitarra solo (1995-1996), baixo (2011-2013), Anders Colsefini - vocais e percussão (1995-1997), Greg Welts - percussão (1997-1998), Brandon Darner - percussão (1998), Patrick M. Neuwirth - guitarra (1992), Quan \"Meld\" Nong - guitarra (1995)";
                }
            } 
            
            
            
            else if (listBox1.SelectedIndex == 2)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    label1.Text = null;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    label1.Text = "O Korn é uma banda pioneira do nu metal, formada em 1993 em Bakersfield, Califórnia. Conhecidos por seu som agressivo e letras que exploram temas como alienação e sofrimento emocional, eles influenciaram profundamente o gênero. " +
                        "Com várias mudanças na formação ao longo dos anos, o Korn continua a ser uma presença relevante e influente na música contemporânea.";
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    label1.Text = "1994 - Korn\r\n1996 - Life Is Peachy\r\n1998 - Follow The Leader\r\n1999 - Issues\r\n2002 - Untouchables\r\n2003 - Take a Look in The Mirror\r\n2005 - See You On The Other Side\r\n2007 - Untitled\r\n2010 - Korn III - Remember Who You Are\r\n2011 - The Path of Totality\r\n2013 - The Paradigm Shift\r\n2016 - The Serenity of Suffering\r\n2019 - The Nothing\r\n2022 - Requiem";
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    label1.Text = "     Integrantes\r\nJonathan Davis \"J Devil\" - vocal, gaita-de-fole, piano (1993-presente), bateria (2006-2008)\r\nJames Shaffer \"Munky\" - guitarra, vocal de apoio, Talk Box (1993-presente)\r\nBrian Welch \"Head\" - guitarra, vocal (1993-2005, 2012-presente)\r\nRay Luzier \"Ray\" - bateria (2008-presente)\r\n  Ex-Integrantes\r\nDavid Silveria \"Wally\" - bateria (1993-2006)\r\nReginald Arvizu \"Fieldy\" - baixo, vocal de apoio (1993-2021)";
                }
            }

            else if (listBox1.SelectedIndex == 3)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    label1.Text = null;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    label1.Text = "Formada em 1999 na Califórnia, o Avenged Sevenfold começou no metalcore e evoluiu para um som que combina elementos de metal tradicional, hard rock e progressivo. " +
                        "Após se destacarem com \"City of Evil\", enfrentaram a perda do baterista The Rev em 2009, lançando \"Nightmare\" em sua memória. " +
                        "Continuaram a explorar novos territórios musicais com álbuns como \"Hail to the King\" e \"The Stage\", mantendo uma base de fãs global e sendo reconhecidos por letras profundas e solos de guitarra virtuosos.";
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    label1.Text = "Sounding the Seventh Trumpet (2001)\r\nWaking the Fallen (2003)\r\nCity of Evil (2005)\r\nAvenged Sevenfold (2007)\r\nNightmare (2010)\r\nHail to the King (2013)\r\nThe Stage (2016)\r\nLife Is but a Dream... (2023)";
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    label1.Text = "     Integrantes \r\nM. Shadows – vocal principal, piano (1999–presente), guitarra base (1999–2001)\r\nZacky Vengeance – guitarra base, backing vocals (1999–presente), guitarra solo (1999–2001)\r\nSynyster Gates – guitarra solo, backing vocals (2001–presente), piano (2001–2007)\r\nJohnny Christ – baixo, backing vocals (2003–presente)\r\nBrooks Wackerman – bateria (2015–presente)\r\n    Ex-Integrantes\r\n The Rev – bateria, piano, voz (1999–2009)\r\nMatt Wendt – baixo (1999–2000)\r\nJustin Sane – baixo, piano (2001-2002)\r\nDameon Ash - baixo (2002-2003)\r\nArin Ilejay – bateria (2011–2015)";
                }

                
            }else if (listBox1.SelectedIndex == 4)
                {
                if (comboBox1.SelectedIndex == 0)
                {
                    label1.Text = null;
                }
                else if (comboBox1.SelectedIndex == 1)
                    {
                        label1.Text = "System of a Down é uma banda de rock alternativo de Los Angeles formada em 1994." +
                            "Conhecida por mesclar metal, punk e elementos da música armênia, ganhou destaque com álbuns como \"Toxicity\" (2001). " +
                            "Suas letras abordam temas sociais e políticos de forma provocativa. " +
                            "Após 2005, a banda entrou em hiato, retornando apenas para shows esporádicos.";
                    }
                    else if (comboBox1.SelectedIndex == 2)
                    {
                        label1.Text = "2002\t\"Chop Suey!\"\r\n2003\t\"Aerials\"\r\n2006\t\"B.Y.O.B.\"\r\n2007\t\"Lonely Day\"";
                    }
                    else if (comboBox1.SelectedIndex == 3)
                    {
                        label1.Text = "Atuais\r\nSerj Tankian - voz, teclados, controlador, guitarra e backing vocals (1992 a 1994 em Soil, 1995–presente)\r\nDaron Malakian - voz, guitarra, teclados e backing vocals (1992-1994 em Soil, 1995–presente)\r\nShavo Odadjian - baixo e backing vocals (1993-1994 em Soil, 1995–presente)\r\nJohn Dolmayan - bateria (1997–presente)\r\nEx-integrantes\r\nAndy Khachaturian - bateria (1995–1997)";
                    }
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja sair?", "Atenção",
               MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                //não realiza nada
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 1)
            {
                pictureBox12.Visible = true;
                SoundPlayer simpleSound = new SoundPlayer(Resources.duplo);
                simpleSound.Play();

                
                pictureBox11.Visible = false;
                pictureBox12.Image = Properties.Resources.show;
            }
            else if (listBox1.SelectedIndex == 2)
            {
                pictureBox12.Visible = true;
                SoundPlayer simpleSound = new SoundPlayer(Resources.enjaulada);
                simpleSound.Play();

                pictureBox11.Visible = false;
                pictureBox12.Image = Properties.Resources.kornlogo;
            }
            else if (listBox1.SelectedIndex == 3)
            {
                pictureBox12.Visible = true;
                SoundPlayer simpleSound = new SoundPlayer(Resources.segundo);
                simpleSound.Play();

                pictureBox11.Visible = false;
                pictureBox12.Image = Properties.Resources.rodaesq;
            }
            else if (listBox1.SelectedIndex == 4)
            {
                pictureBox12.Visible = true;
                SoundPlayer simpleSound = new SoundPlayer(Resources.picado);
                simpleSound.Play();

                pictureBox11.Visible = false;
                pictureBox12.Image = Properties.Resources.tankei;
            }
        }

        private void pictureBox12_Click_2(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 1)
            {
                pictureBox12.Visible = false;
                SoundPlayer simpleSound = new SoundPlayer();
                simpleSound.Stop();


                pictureBox11.Visible = true;
                pictureBox11.Image = Properties.Resources.show;
            }
            else if (listBox1.SelectedIndex == 2)
            {
                pictureBox12.Visible = false;
                SoundPlayer simpleSound = new SoundPlayer();
                simpleSound.Stop();

                pictureBox11.Visible = true;
                pictureBox11.Image = Properties.Resources.kornlogo;
            }
            else if (listBox1.SelectedIndex == 3)
            {
                pictureBox12.Visible = false;
                SoundPlayer simpleSound = new SoundPlayer();
                simpleSound.Stop();

                pictureBox11.Visible = true;
                pictureBox11.Image = Properties.Resources.rodaesq;
            }
            else if (listBox1.SelectedIndex == 4)
            {
                pictureBox12.Visible = false;
                SoundPlayer simpleSound = new SoundPlayer();
                simpleSound.Stop();

                pictureBox11.Visible = true;
                pictureBox11.Image = Properties.Resources.tankei;
            }
        }
    }
}
