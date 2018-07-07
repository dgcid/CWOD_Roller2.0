using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace CWOD_ROller2._0
{
    public partial class Roller : Form

    {
        XmlSerializer xs;
        List<Information> ls;
        //Random Roll = new Random();

        //// Attributes //
        //int Str = Convert.ToInt32(Str_Box.Text);
        //int Dex = Convert.ToInt32(Dex_Box.Text);
        //int Stam = Convert.ToInt32(Stam_Box.Text);
        //int Char = Convert.ToInt32(Char_Box.Text);
        //int Mani = Convert.ToInt32(Man_box.Text);
        //int appear = Convert.ToInt32(Appear_Box.Text);
        //int Intel = Convert.ToInt32(Intel_box.Text);
        //int Perc = Convert.ToInt32(Per_Box.Text);
        //int Wit = Convert.ToInt32(Wits_box.Text);

        //// Abilites // 
        //int Alert = Convert.ToInt32(Alert_Box.Text);
        //int Ath = Convert.ToInt32(Ath_Box.Text);
        //int Brawl = Convert.ToInt32(Brawl_Box.Text);
        //int Dodge = Convert.ToInt32(Dodge_Box.Text);
        //int Emp = Convert.ToInt32(Emp_Box.Text);
        //int Express = Convert.ToInt32(Express_Box.Text);
        //int Intim = Convert.ToInt32(Intim_Box.Text);
        //int Lead = Convert.ToInt32(Lead_Box.Text);
        //int Street = Convert.ToInt32(Street_Box.Text);
        //int Sub = Convert.ToInt32(Subt_Box.Text);
        //int AniK = Convert.ToInt32(AK_Box.Text);
        //int Craft = Convert.ToInt32(Crafts_box.Text);
        //int Drive = Convert.ToInt32(Drive_Box.Text);
        //int Eti = Convert.ToInt32(Eti_Box.Text);
        //int FireA = Convert.ToInt32(Fire_Box.Text);
        //int Melee = Convert.ToInt32(Mel_Box.Text);
        //int Perf = Convert.ToInt32(Perf_Box.Text);
        //int Sec = Convert.ToInt32(Sec_box.Text);
        //int Steal = Convert.ToInt32(Stealth_Box.Text);
        //int Surv = Convert.ToInt32(Surv_Box.Text);
        //int Acad = Convert.ToInt32(Ac_Box.Text);
        //int Comp = Convert.ToInt32(Com_Box.Text);
        //int Fin = Convert.ToInt32(Fin_Box.Text);
        //int Invest = Convert.ToInt32(Invest_Box.Text);
        //int Law = Convert.ToInt32(Law_Box.Text);
        //int Ling = Convert.ToInt32(Ling_Box.Text);
        //int Med = Convert.ToInt32(Med_Box.Text);
        //int Occ = Convert.ToInt32(Occ_Box.Text);
        //int Poli = Convert.ToInt32(Poli_Box.Text);
        //int Sci = Convert.ToInt32(Sci_Box.Text);
        //// Difficulty //
        //int Diff = Convert.ToInt32(Diff_Box.Text);

        //////Possible Outcomes// 
        ////int frequency1 = 0;
        ////int frequency2 = 2;
        ////int frequency3 = 3;
        ////int frequency4 = 4;
        ////int frequency5 = 5;
        ////int frequency6 = 6;
        ////int frequency7 = 7;
        ////int frequency8 = 8;
        ////int frequency9 = 9;
        ////int frequency10 = 10;

        //// Face Storage //
        //int Face;


        ////Success counter//
        //int Success = 0;
        //int Fail = 0;
        public Roller()
        {
            InitializeComponent();

            ls = new List<Information>();
            xs = new XmlSerializer(typeof(List<Information>));



        }

        private void NewPlayerButt_Click(object sender, EventArgs e)
        {
            NewPlayerLanding.Visible = true;
        }

        private void ReturningPlayerButt_Click(object sender, EventArgs e)
        {
            //FileStream fs = new FileStream("J:\\Vampire.xml", FileMode.Open, FileAccess.Read);
            //ls = (List<Information>)xs.Deserialize(fs);
            if (File.Exists("...\\Vampire.Xml"))
            {
                NewPlayerLanding.Visible = true;
                VampireStart.Visible = true;
                XmlSerializer xs = new XmlSerializer(typeof(Information));
                FileStream fs = new FileStream("...\\Vampire.Xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                Information I = (Information)xs.Deserialize(fs);
               


                // Load Vampire Boxes

                Str_Box.Text = Convert.ToString(I.Str_Box);
                Dex_Box.Text = Convert.ToString(I.Dex_Box);
                Stam_Box.Text = Convert.ToString(I.Stam_Box);
                Char_Box.Text = Convert.ToString(I.Char_Box);
                Man_box.Text =Convert.ToString(I.Man_Box);
                Appear_Box.Text = Convert.ToString(I.Appear_Box);
                Intel_box.Text = Convert.ToString(I.intel_Box);
                Perc_Box.Text = Convert.ToString(I.Per_Box);
                Wits_box.Text = Convert.ToString(I.Wits_Box);
                Alert_Box.Text = Convert.ToString(I.Alert_Box);
                Ath_Box.Text = Convert.ToString(I.Ath_Box);
                Brawl_Box.Text = Convert.ToString(I.Brawl_Box);
                Dodge_Box.Text = Convert.ToString(I.Dodge_Box);
                Emp_Box.Text = Convert.ToString(I.Emp_Box);
                Express_Box.Text = Convert.ToString(I.Express_Box);
                Intim_Box.Text = Convert.ToString(I.intim_Box);
                Lead_Box.Text = Convert.ToString(I.Lead_Box);
                Street_Box.Text = Convert.ToString(I.Street_Box);
                Subt_Box.Text = Convert.ToString(I.Subt_Box);
                AK_Box.Text = Convert.ToString(I.AK_Box);
                Crafts_box.Text = Convert.ToString(I.Crafts_box);
                Drive_Box.Text = Convert.ToString(I.Drive_Box);
                Eti_Box.Text = Convert.ToString(I.Eti_Box);
                Fire_Box.Text = Convert.ToString(I.Fire_Box);
                Mel_Box.Text = Convert.ToString(I.Mel_Box);
                Perf_Box.Text = Convert.ToString(I.Perf_Box);
                Sec_box.Text = Convert.ToString(I.Sec_box);
                Stealth_Box.Text = Convert.ToString(I.Stealth_Box);
                Surv_Box.Text = Convert.ToString(I.Surv_Box);
                Ac_Box.Text = Convert.ToString(I.Ac_Box);
                Com_Box.Text = Convert.ToString(I.Com_Box);
                Fin_Box.Text = Convert.ToString(I.Fin_Box);
                Invest_Box.Text = Convert.ToString(I.Invest_Box);
                Law_Box.Text = Convert.ToString(I.Law_Box);
                Ling_Box.Text = Convert.ToString(I.Ling_Box);
                Med_Box.Text = Convert.ToString(I.Med_Box);
                Sci_Box.Text = Convert.ToString(I.Sci_Box);
                Poli_Box.Text = Convert.ToString(I.Poli_Box);
                Occ_Box.Text = Convert.ToString(I.Occ_Box);
                CurBloodNum.Text = Convert.ToString(I.Blood);
                CurWillNum.Text = Convert.ToString(I.Will);
                CurHealth.Text = Convert.ToString(I.Hp);
                CurHealthStatus.Text = Convert.ToString(I.HStatus);
                CurHealthNegative.Text = Convert.ToString(I.HNeg);
                VampireName.Text = Convert.ToString(I.Name);
                VampClan.Text = Convert.ToString(I.Clan);
                VampSire.Text = Convert.ToString(I.Sire);
                GenerationTextBox.Text = Convert.ToString(I.Gen);
                VampCons.Text = Convert.ToString(I.Cons);
                VampConv.Text = Convert.ToString(I.Conv);
                VampCour.Text = Convert.ToString(I.Cour);
                VampHum.Text = Convert.ToString(I.Human);
                MaxWillBox.Text = Convert.ToString(I.MaxWill);
                fs.Close();


            }
            else
            if (File.Exists("...\\Demon.Xml"))
            {
                // Load Demon Boxes
                NewPlayerLanding.Visible = true;
                VampireStart.Visible = true;
                VampCombat.Visible = true;
                VampireSocial.Visible = true;
                DemonStart.Visible = true;
                XmlSerializer xs = new XmlSerializer(typeof(Information));
                FileStream fs = new FileStream("...\\Demon.Xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                Information I = (Information)xs.Deserialize(fs);

                DemStrBox.Text = Convert.ToString(I.DemStr);
                DemDexBox.Text = Convert.ToString(I.DemDex);
                DemStamBox.Text = Convert.ToString(I.DemStam);
                DemCharBox.Text = Convert.ToString(I.DemChar);
                DemManBox.Text = Convert.ToString(I.DemMan);
                DemAppBox.Text = Convert.ToString(I.DemApp);
                DemIntBox.Text = Convert.ToString(I.DemIntel);
                DemPercBox.Text = Convert.ToString(I.DemPerc);
                DemWitsBox.Text = Convert.ToString(I.DemWits);
                DemAlertBox.Text = Convert.ToString(I.DemAlert);
                DemAthBox.Text = Convert.ToString(I.DemAth);
                DemBrawlBox.Text = Convert.ToString(I.DemBrawl);
                DemDodBox.Text = Convert.ToString(I.DemDod);
                DemEmpBox.Text = Convert.ToString(I.DemEmp);
                DemExpBox.Text = Convert.ToString(I.DemExp);
                DemIntiBox.Text = Convert.ToString(I.DemIntim);
                DemLeadBox.Text = Convert.ToString(I.DemLead);
                DemStreetBox.Text = Convert.ToString(I.Demstreet);
                DemSubBox.Text = Convert.ToString(I.DemSubt);
                DemAKBox.Text = Convert.ToString(I.DemAK);
                DemCraftBox.Text = Convert.ToString(I.DemCraft);
                DemDriveBox.Text = Convert.ToString(I.DemDrive);
                DemEtiBox.Text = Convert.ToString(I.DemEti);
                DemFABox.Text = Convert.ToString(I.DemFire);
                DemMelBox.Text = Convert.ToString(I.DemMel);
                DemPerfbox.Text = Convert.ToString(I.DemPerf);
                DemSecBox.Text = Convert.ToString(I.DemLarc);
                DemStlBox.Text = Convert.ToString(I.DemSteal);
                DemSurvBox.Text = Convert.ToString(I.DemSurv);
                DemAcaBox.Text = Convert.ToString(I.DemAcad);
                DemComBox.Text = Convert.ToString(I.Demcomp);
                DemFinBox.Text = Convert.ToString(I.DemFin);
                DemInvBox.Text = Convert.ToString(I.DemInvest);
                DemLawBox.Text = Convert.ToString(I.DemLaw);
                DemReliBox.Text = Convert.ToString(I.DemReli);
                DemMedBox.Text = Convert.ToString(I.DemMed);
                DemSciBox.Text = Convert.ToString(I.DemSci);
                DemPolBox.Text = Convert.ToString(I.Dempoli);
                DemOccBox.Text = Convert.ToString(I.DemOcc);
                DemonTormentBox.Text = Convert.ToString(I.DemTorm);
                TempTormNum.Text = Convert.ToString(I.DemTempTorm);
                DemCurHealthNum.Text = Convert.ToString(I.DemHp);
                DemHealthStatus.Text = Convert.ToString(I.DemHStatus);
                DemonCurHealthNeg.Text = Convert.ToString(I.DemHNeg);
                DemonTormentBox.Text = Convert.ToString(I.DemTorm);
                MaxDemWillBox.Text = Convert.ToString(I.DemWill);
                DemCurWillNum.Text = Convert.ToString(I.DemCurWill);
                MaxFaithBox.Text = Convert.ToString(I.DemFaith);
                CurFaithNum.Text = Convert.ToString(I.DemCurFaith);
                HouseBox.Text = Convert.ToString(I.DemHouse);
                FactionTextBox.Text = Convert.ToString(I.DemFaction);
                DemonNameBox.Text = Convert.ToString(I.DemName);
                VisageBox.Text = Convert.ToString(I.DemVis);
                DemonConvBox.Text = Convert.ToString(I.DemConv);
                DemonConsBox.Text = Convert.ToString(I.DemCons);
                DemCourBox.Text = Convert.ToString(I.DemCour);

                fs.Close();

            }
            else
            if ((File.Exists("...\\Wraith.Xml")))
            {
                // Load Wraith Boxes
                NewPlayerLanding.Visible = true;
                VampireStart.Visible = true;
                VampCombat.Visible = true;
                VampireSocial.Visible = true;
                DemonStart.Visible = true;
                XmlSerializer xs = new XmlSerializer(typeof(Information));
                FileStream fs = new FileStream("...\\Wraith.Xml", FileMode.Open, FileAccess.Read, FileShare.Read);
                Information I = (Information)xs.Deserialize(fs);

                WraStrBox.Text = Convert.ToString(I.Wrastr);
                WraDexBox.Text = Convert.ToString(I.Wradex);
                wraStamBox.Text = Convert.ToString(I.Wrastam);
                WraCharBox.Text = Convert.ToString(I.Wrachar);
                WraManiBox.Text = Convert.ToString(I.wraman);
                WraAppBox.Text = Convert.ToString(I.wraapp);
                WraIntBox.Text = Convert.ToString(I.wraintel);
                WraPercBox.Text = Convert.ToString(I.wraperc);
                WraWitsbox.Text = Convert.ToString(I.wrawits);
                WraAlertBox.Text = Convert.ToString(I.wraalert);
                WraAthBox.Text = Convert.ToString(I.wraath);
                WraAwBox.Text = Convert.ToString(I.wraawa);
                WraBraBox.Text = Convert.ToString(I.wrabra);
                WraDodBox.Text = Convert.ToString(I.wradod);
                WraEmpBox.Text = Convert.ToString(I.wraemp);
                WraExpBox.Text = Convert.ToString(I.wraexp);
                WraIntimBox.Text = Convert.ToString(I.wrainti);
                WraStreetBox.Text = Convert.ToString(I.wrastreet);
                WraSubbox.Text = Convert.ToString(I.wrasubt);
                WraCraBox.Text = Convert.ToString(I.wracraft);
                WraDrvBox.Text = Convert.ToString(I.wradrive);
                WraEtiBox.Text = Convert.ToString(I.wraeti);
                WraFABox.Text = Convert.ToString(I.wrafa);
                WraLeadBox.Text = Convert.ToString(I.wralead);
                WraMeditBox.Text = Convert.ToString(I.wramedit);
                WraMelBox.Text = Convert.ToString(I.wramel);
                WraPerfBox.Text = Convert.ToString(I.wraperf);
                WraSecBox.Text = Convert.ToString(I.wrasec);
                WraStealbox.Text = Convert.ToString(I.wrasteal);
                WraAcadBox.Text = Convert.ToString(I.wraacad);
                WraCompBox.Text = Convert.ToString(I.wracomp);
                WraEngBox.Text = Convert.ToString(I.wraenig);
                WraInvestBox.Text = Convert.ToString(I.wrainvest);
                WraLawbox.Text = Convert.ToString(I.wralaw);
                WraLingbox.Text = Convert.ToString(I.wraling);
                WraMedBox.Text = Convert.ToString(I.wramed);
                WraOccBox.Text = Convert.ToString(I.wraocc);
                WraPolibox.Text = Convert.ToString(I.wrapoli);
                WraScibox.Text = Convert.ToString(I.wrasci);
                WraithPathos.Text = Convert.ToString(I.wrapathos);
                WraCurPathNum.Text = Convert.ToString(I.wracurpathos);
                WraithCorpus.Text = Convert.ToString(I.corpus);
                WraCurCorpNum.Text = Convert.ToString(I.wracurcorp);
                WraMWillBox.Text = Convert.ToString(I.wraMaxWill);
                WraCurWillNum.Text = Convert.ToString(I.wraWill);
                WraithNameBox.Text = Convert.ToString(I.wraName);
                WraithLifeBox.Text = Convert.ToString(I.wraLife);
                WraithDeathBox.Text = Convert.ToString(I.wraDeath);
                fs.Close();
            }


        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        //Vampire Button
        private void button1_Click(object sender, EventArgs e)
        {
            VampireStart.Visible = true;

        }

        //Werewolf Button
        private void button2_Click(object sender, EventArgs e)
        {

        }

        //Mage Button
        private void button3_Click(object sender, EventArgs e)
        {
            VampireStart.Visible = true;
            VampCombat.Visible = true;
            VampireSocial.Visible = true;
            DemonStart.Visible = true;
            DemonCombat2.Visible = true;
            DemonSocial.Visible = true;
            //    WraithStart.Visible = true;
            //   WraithCombat.Visible = true;
            //  WraithSocial.Visible = true;
        }

        //HunterButton
        private void button5_Click(object sender, EventArgs e)
        {

        }

        //ChangelingButton
        private void button7_Click(object sender, EventArgs e)
        {

        }

        //Mummy Button
        private void button8_Click(object sender, EventArgs e)
        {

        }

        //Dragon Button
        private void button9_Click(object sender, EventArgs e)
        {

        }

        ///////////////////
        //Vampire Roller//
        //////////////////


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //Load Blood//
        private void LoadBloosButt_Click(object sender, EventArgs e)
        {
            int generation = Convert.ToInt32(GenerationTextBox.Text);

            if (generation >= 13)
            {
                MaxBloodPoolBox.Text = Convert.ToString(10);
                BlodNumTurn.Text = Convert.ToString(1);

            }
            else
            if (generation == 12)
            {
                MaxBloodPoolBox.Text = Convert.ToString(11);
                BlodNumTurn.Text = Convert.ToString(1);

            }
            else
            if (generation == 11)
            {
                MaxBloodPoolBox.Text = Convert.ToString(12);
                BlodNumTurn.Text = Convert.ToString(1);

            }
            else
             if (generation == 10)
            {
                MaxBloodPoolBox.Text = Convert.ToString(13);
                BlodNumTurn.Text = Convert.ToString(1);

            }
            else
            if (generation == 9)
            {
                MaxBloodPoolBox.Text = Convert.ToString(14);
                BlodNumTurn.Text = Convert.ToString(2);

            }
            else
            if (generation == 8)
            {
                MaxBloodPoolBox.Text = Convert.ToString(15);
                BlodNumTurn.Text = Convert.ToString(3);

            }
            else
            if (generation == 7)
            {
                MaxBloodPoolBox.Text = Convert.ToString(20);
                BlodNumTurn.Text = Convert.ToString(4);

            }
            else
             if (generation == 6)
            {
                MaxBloodPoolBox.Text = Convert.ToString(30);
                BlodNumTurn.Text = Convert.ToString(6);

            }
            else
             if (generation == 5)
            {
                MaxBloodPoolBox.Text = Convert.ToString(40);
                BlodNumTurn.Text = Convert.ToString(8);

            }
            else
             if (generation == 4)
            {
                MaxBloodPoolBox.Text = Convert.ToString(50);
                BlodNumTurn.Text = Convert.ToString(10);

            }
            else
             if (generation <= 3)
            {
                MaxBloodPoolBox.Text = Convert.ToString(999);
                BlodNumTurn.Text = Convert.ToString(999);

            }

        }
        //Vampire Startover//
        private void StartOverButt_Click(object sender, EventArgs e)
        {
            VampireStart.Visible = false;

        }
        //Vampire Combat//
        private void CombatButtV_Click(object sender, EventArgs e)
        {
            VampCombat.Visible = true;
        }



        //Close Combat Buttons//

        //Punch//
        private void button19_Click(object sender, EventArgs e)
        {
            {
                Random Roll = new Random();

                // Attributes //
                var Dex = Convert.ToInt32(Dex_Box.Text);

                // Abilites // 
                var Brawl = Convert.ToInt32(Brawl_Box.Text);
                var Punch = (Dex + Brawl);

                // Difficulty //
                int Diff = Convert.ToInt32(Diff_Box.Text);
                var Actions = Convert.ToDouble(ActionsNum.Text);
                var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
                var actionDec = Convert.ToDecimal("1.5");
                var actionInt = Convert.ToInt32(Math.Floor(Actions));
                var dicecount = Punch + NegHealth;

                if (Actions > 0.5)
                {
                    dicecount = Punch - actionInt + NegHealth;

                }
                else
                {
                    dicecount = Punch + NegHealth;
                }



                // Face Storage //
                int Face;

                //Success counter//
                int Success = 0;
                int Fail = 0;

                //Actual Roll
                for (int roll = 1; roll <= dicecount; ++roll)
                {
                    Face = Roll.Next(1, 11);
                    switch (Face)
                    {
                        case 1:
                            if (1 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                //--Success;
                                // ++Fail;
                            }
                            break;
                        case 2:
                            if (2 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                ++Fail;
                            }
                            break;
                        case 3:
                            if (3 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                ++Fail;
                            }
                            break;
                        case 4:
                            if (4 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                ++Fail;
                            }
                            break;
                        case 5:
                            if (5 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                ++Fail;
                            }
                            break;
                        case 6:
                            if (6 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                ++Fail;
                            }
                            break;
                        case 7:
                            if (7 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                ++Fail;
                            }
                            break;
                        case 8:
                            if (8 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                ++Fail;
                            }
                            break;
                        case 9:
                            if (9 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                ++Fail;
                            }
                            break;
                        case 10:
                            if (10 >= Diff)
                            {
                                ++Success;
                                ++roll;
                            }
                            else
                            {
                                ++Fail;
                            }
                            break;
                    }

                    ////Ensures that lists are working properly//
                    // Numbers.Text = Convert.ToString("S" + Success + " " + "F" + Fail );



                    if (Success >= Fail)
                    {
                        Numbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        
                    }
                    else
                    {
                        Numbers.Text = Convert.ToString("Fail");
                       
                    }
                    
                }
                var Act = Convert.ToDecimal(ActionsNum.Text) + Convert.ToDecimal("1.0");
                ActionsNum.Text = Convert.ToString(Act);
            }
        }

        //Bite//
        private void button20_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();

            // Attributes //
            int Str = Convert.ToInt32(Str_Box.Text);
            int Dex = Convert.ToInt32(Dex_Box.Text);
            int Bite = Dex + Str;

            // Difficulty //
            int Diff = Convert.ToInt32(Diff_Box.Text);
            var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
            var Actions = Convert.ToDouble(ActionsNum.Text);
            var actionDec = Convert.ToDecimal("1.5");
            var actionInt = Convert.ToInt32(Math.Floor(Actions));
            var dicecount = Bite + NegHealth + 1;

            if (Actions > 0.5)
            {
                dicecount = Bite - actionInt + NegHealth + 1;

            }
            else
            {
                dicecount = Bite + NegHealth + 1;
            }


            // Face Storage //
            int Face;


            //Success counter//
            int Success = 0;
            int Fail = 0;


            for (int roll = 1; roll <= dicecount + 1; ++roll)
            {
                Face = Roll.Next(1, 11);
                switch (Face)
                {
                    case 1:
                        if (1 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            --Success;
                            ++Fail;
                        }
                        break;
                    case 2:
                        if (2 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 3:
                        if (3 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 4:
                        if (4 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 5:
                        if (5 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 6:
                        if (6 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 7:
                        if (7 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 8:

                        if (8 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 9:
                        if (9 >= Diff)
                        {
                            ++Success;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                    case 10:
                        if (10 >= Diff)
                        {
                            ++Success;
                            ++roll;
                        }
                        else
                        {
                            ++Fail;
                        }
                        break;
                }

                //Ensures that lists are working properly//
                // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                //

                if (Success >= Fail)
                {
                    Numbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                }
                else
                {
                    Numbers.Text = Convert.ToString("Fail");
                }
            }
            var Act = Convert.ToDecimal(ActionsNum.Text) + Convert.ToDecimal("1.0");
            ActionsNum.Text = Convert.ToString(Act);
        }

        //Kiss//
        private void button18_Click(object sender, EventArgs e)
        {
            {
                Random Roll = new Random();

                // Attributes //
                int Dex = Convert.ToInt32(Dex_Box.Text);


                // Abilites // 
                int Brawl = Convert.ToInt32(Brawl_Box.Text);
                var Kiss = Dex + Brawl;

                // Difficulty //
                int Diff = Convert.ToInt32(Diff_Box.Text);
                var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
                var Actions = Convert.ToDouble(ActionsNum.Text);
                var actionDec = Convert.ToDecimal("1.5");
                var actionInt = Convert.ToInt32(Math.Floor(Actions));
                var dicecount = Kiss + NegHealth + 1;

                if (Actions > 0.5)
                {
                    dicecount = Kiss - actionInt + NegHealth + 1;

                }
                else
                {
                    dicecount = Kiss + NegHealth + 1;
                }


                // Face Storage //
                int Face;


                //Success counter//
                int Success = 0;
                int Fail = 0;


                for (int roll = 1; roll <= dicecount + 1; ++roll)
                {
                    Face = Roll.Next(1, 11);
                    switch (Face)
                    {
                        case 1:
                            if (1 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                --Success;
                                ++Fail;
                            }
                            break;
                        case 2:
                            if (2 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                ++Fail;
                            }
                            break;
                        case 3:
                            if (3 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                ++Fail;
                            }
                            break;
                        case 4:
                            if (4 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                ++Fail;
                            }
                            break;
                        case 5:
                            if (5 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                ++Fail;
                            }
                            break;
                        case 6:
                            if (6 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                ++Fail;
                            }
                            break;
                        case 7:
                            if (7 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                ++Fail;
                            }
                            break;
                        case 8:
                            if (8 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                ++Fail;
                            }
                            break;
                        case 9:
                            if (9 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                ++Fail;
                            }
                            break;
                        case 10:
                            if (10 >= Diff)
                            {
                                ++Success;
                                ++roll;
                            }
                            else
                            {
                                ++Fail;
                            }
                            break;
                    }

                    //Ensures that lists are working properly//
                    // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                    //

                    if (Success >= Fail)
                    {
                        Numbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                    }
                    else
                    {
                        Numbers.Text = Convert.ToString("Fail");
                    }
                }
                var Act = Convert.ToDecimal(ActionsNum.Text) + Convert.ToDecimal("1.0");
                ActionsNum.Text = Convert.ToString(Act);

            }
        }

        //Claw//
        private void button17_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(Dex_Box.Text);

                    // Abilites // 
                    int Brawl = Convert.ToInt32(Brawl_Box.Text);
                    var Claw = Dex + Brawl;
                    // Difficulty //
                    int Diff = Convert.ToInt32(Diff_Box.Text);
                    var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
                    var Actions = Convert.ToDouble(ActionsNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Claw + NegHealth;

                    if (Actions > 0.5)
                    {
                        dicecount = Claw - actionInt + NegHealth;

                    }
                    else
                    {
                        dicecount = Claw + NegHealth;
                    }

                    ////Possible Outcomes// 
                    //int frequency1 = 0;
                    //int frequency2 = 2;
                    //int frequency3 = 3;
                    //int frequency4 = 4;
                    //int frequency5 = 5;
                    //int frequency6 = 6;
                    //int frequency7 = 7;
                    //int frequency8 = 8;
                    //int frequency9 = 9;
                    //int frequency10 = 10;

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            Numbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            Numbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(ActionsNum.Text) + Convert.ToDecimal("1.0");
                    ActionsNum.Text = Convert.ToString(Act);
                

                }
            }
        }

        //Clinch//
        private void button16_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    var Str = Convert.ToInt32(Str_Box.Text);

                    // Abilites // 

                    var Brawl = Convert.ToInt32(Brawl_Box.Text);
                    var Clinch = Str + Brawl;
                    // Difficulty //
                    var Diff = Convert.ToInt32(Diff_Box.Text);
                    var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
                    var Actions = Convert.ToDouble(ActionsNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Clinch + NegHealth + 1;

                    if (Actions > 0.5)
                    {
                        dicecount = Clinch - actionInt + NegHealth + 1;

                    }
                    else
                    {
                        dicecount = Clinch + NegHealth + 1;
                    }


                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            Numbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            Numbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(ActionsNum.Text) + Convert.ToDecimal("1.0");
                    ActionsNum.Text = Convert.ToString(Act);

                }
            }
        }

        //Disarm//
        private void button15_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(Dex_Box.Text);

                    // Abilites // 
                    int Melee = Convert.ToInt32(Mel_Box.Text);
                    var Disarm = Melee + Dex;
                    // Difficulty //
                    int Diff = Convert.ToInt32(Diff_Box.Text);
                    var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
                    var Actions = Convert.ToDouble(ActionsNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Disarm + NegHealth + 1;

                    if (Actions > 0.5)
                    {
                        dicecount = Disarm - actionInt + NegHealth + 1;

                    }
                    else
                    {
                        dicecount = Disarm + NegHealth + 1;
                    }


                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            Numbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            Numbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(ActionsNum.Text) + Convert.ToDecimal("1.0");
                    ActionsNum.Text = Convert.ToString(Act);

                }
            }
        }

        //Hold//
        private void button14_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Str = Convert.ToInt32(Str_Box.Text);

                    // Abilites // 
                    int Brawl = Convert.ToInt32(Brawl_Box.Text);
                    var hold = Str + Brawl;
                    // Difficulty //
                    int Diff = Convert.ToInt32(Diff_Box.Text);
                    var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
                    var Actions = Convert.ToDouble(ActionsNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = hold + NegHealth;

                    if (Actions > 0.5)
                    {
                        dicecount = hold - actionInt + NegHealth;

                    }
                    else
                    {
                        dicecount = hold + NegHealth;
                    }

                    ////Possible Outcomes// 
                    //int frequency1 = 0;
                    //int frequency2 = 2;
                    //int frequency3 = 3;
                    //int frequency4 = 4;
                    //int frequency5 = 5;
                    //int frequency6 = 6;
                    //int frequency7 = 7;
                    //int frequency8 = 8;
                    //int frequency9 = 9;
                    //int frequency10 = 10;

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            Numbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            Numbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(ActionsNum.Text) + Convert.ToDecimal("1.0");
                    ActionsNum.Text = Convert.ToString(Act);

                }
            }
        }

        //Kick//
        private void button12_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Abilites // 
                    int Brawl = Convert.ToInt32(Brawl_Box.Text);

                    // Difficulty //
                    int Diff = Convert.ToInt32(Diff_Box.Text);
                    var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
                    var Actions = Convert.ToDouble(ActionsNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Brawl + NegHealth;

                    if (Actions > 0.5)
                    {
                        dicecount = Brawl - actionInt + NegHealth;

                    }
                    else
                    {
                        dicecount = Brawl + NegHealth;
                    }

                    ////Possible Outcomes// 
                    //int frequency1 = 0;
                    //int frequency2 = 2;
                    //int frequency3 = 3;
                    //int frequency4 = 4;
                    //int frequency5 = 5;
                    //int frequency6 = 6;
                    //int frequency7 = 7;
                    //int frequency8 = 8;
                    //int frequency9 = 9;
                    //int frequency10 = 10;

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            Numbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            Numbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(ActionsNum.Text) + Convert.ToDecimal("1.0");
                    ActionsNum.Text = Convert.ToString(Act);

                }
            }
        }

        //Leg Sweep//
        private void button13_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(Dex_Box.Text);


                    // Abilites // 
                    int Brawl = Convert.ToInt32(Brawl_Box.Text);
                    var Sweep = Dex + Brawl;
                    // Difficulty //
                    int Diff = Convert.ToInt32(Diff_Box.Text);
                    var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
                    var Actions = Convert.ToDouble(ActionsNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Sweep + NegHealth;

                    if (Actions > 0.5)
                    {
                        dicecount = Sweep - actionInt + NegHealth;

                    }
                    else
                    {
                        dicecount = Sweep + NegHealth;
                    }
                    ////Possible Outcomes// 
                    //int frequency1 = 0;
                    //int frequency2 = 2;
                    //int frequency3 = 3;
                    //int frequency4 = 4;
                    //int frequency5 = 5;
                    //int frequency6 = 6;
                    //int frequency7 = 7;
                    //int frequency8 = 8;
                    //int frequency9 = 9;
                    //int frequency10 = 10;

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            Numbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            Numbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(ActionsNum.Text) + Convert.ToDecimal("1.0");
                    ActionsNum.Text = Convert.ToString(Act);

                }
            }
        }

        //Tackle//
        private void button11_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Str = Convert.ToInt32(Str_Box.Text);

                    // Abilites // 
                    int Brawl = Convert.ToInt32(Brawl_Box.Text);
                    var Tackle = Brawl + Str;
                    // Difficulty //
                    int Diff = Convert.ToInt32(Diff_Box.Text);
                    var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
                    var Actions = Convert.ToDouble(ActionsNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Tackle + NegHealth;

                    if (Actions > 0.5)
                    {
                        dicecount = Tackle - actionInt + NegHealth;

                    }
                    else
                    {
                        dicecount = Tackle + NegHealth;
                    }

                    ////Possible Outcomes// 
                    //int frequency1 = 0;
                    //int frequency2 = 2;
                    //int frequency3 = 3;
                    //int frequency4 = 4;
                    //int frequency5 = 5;
                    //int frequency6 = 6;
                    //int frequency7 = 7;
                    //int frequency8 = 8;
                    //int frequency9 = 9;
                    //int frequency10 = 10;

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            Numbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            Numbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(ActionsNum.Text) + Convert.ToDecimal("1.0");
                    ActionsNum.Text = Convert.ToString(Act);

                }
            }
        }

        //Weapon Strike//
        private void button10_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(Dex_Box.Text);

                    // Abilites // 
                    int Melee = Convert.ToInt32(Mel_Box.Text);
                    var WS = Melee + Dex;
                    // Difficulty //
                    int Diff = Convert.ToInt32(Diff_Box.Text);
                    var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
                    var Actions = Convert.ToDouble(ActionsNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = WS + NegHealth;

                    if (Actions > 0.5)
                    {
                        dicecount = WS - actionInt + NegHealth;

                    }
                    else
                    {
                        dicecount = WS + NegHealth;
                    }


                    ////Possible Outcomes// 
                    //int frequency1 = 0;
                    //int frequency2 = 2;
                    //int frequency3 = 3;
                    //int frequency4 = 4;
                    //int frequency5 = 5;
                    //int frequency6 = 6;
                    //int frequency7 = 7;
                    //int frequency8 = 8;
                    //int frequency9 = 9;
                    //int frequency10 = 10;

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }
                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            Numbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            Numbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(ActionsNum.Text) + Convert.ToDecimal("1.0");
                    ActionsNum.Text = Convert.ToString(Act);

                }
            }
        }

        //Spend Blood//
        private void button21_Click(object sender, EventArgs e)
        {
            var Act = Convert.ToDecimal(ActionsNum.Text) + Convert.ToDecimal("1.0");
            ActionsNum.Text = Convert.ToString(Act);

        }

        //Blood Button
        private void BloodButton_Click(object sender, EventArgs e)
        {
            var blood = Convert.ToInt32(CurBloodNum.Text);
            CurBloodNum.Text = Convert.ToString(blood - 1);
        }

        //Ranged Combat Buttons//

        //Aiming//
        private void button22_Click(object sender, EventArgs e)
        {
            Numbers.Text = "You have taken Aim";
        }

        //Auto-Fire//
        private void button23_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //

                    int Dex = Convert.ToInt32(Dex_Box.Text);


                    // Abilites //
                    int FireA = Convert.ToInt32(Fire_Box.Text);
                    var Auto = FireA + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(Diff_Box.Text);
                    var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
                    var Actions = Convert.ToDouble(ActionsNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Auto + NegHealth + 10;

                    if (Actions > 0.5)
                    {
                        dicecount = Auto - actionInt + NegHealth + 10;

                    }
                    else
                    {
                        dicecount = Auto + NegHealth + 10;
                    }

                    ////Possible Outcomes// 
                    //int frequency1 = 0;
                    //int frequency2 = 2;
                    //int frequency3 = 3;
                    //int frequency4 = 4;
                    //int frequency5 = 5;
                    //int frequency6 = 6;
                    //int frequency7 = 7;
                    //int frequency8 = 8;
                    //int frequency9 = 9;
                    //int frequency10 = 10;

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            Numbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            Numbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(ActionsNum.Text) + Convert.ToDecimal("1.0");
                    ActionsNum.Text = Convert.ToString(Act);

                }
            }
        }


        // Cover //
        private void button24_Click(object sender, EventArgs e)
        {
            Numbers.Text = Convert.ToString("You are in cover remind storyteller");
        }

        // three Round Burst //
        private void button25_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(Dex_Box.Text);

                    // Abilites // 
                    int FireA = Convert.ToInt32(Fire_Box.Text);
                    var Auto = FireA = Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(Diff_Box.Text);
                    var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
                    var Actions = Convert.ToDouble(ActionsNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Auto + NegHealth + 2;

                    if (Actions > 0.5)
                    {
                        dicecount = Auto - actionInt + NegHealth + 2;

                    }
                    else
                    {
                        dicecount = Auto + NegHealth + 2;
                    }

                    ////Possible Outcomes// 
                    //int frequency1 = 0;
                    //int frequency2 = 2;
                    //int frequency3 = 3;
                    //int frequency4 = 4;
                    //int frequency5 = 5;
                    //int frequency6 = 6;
                    //int frequency7 = 7;
                    //int frequency8 = 8;
                    //int frequency9 = 9;
                    //int frequency10 = 10;

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            Numbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            Numbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(ActionsNum.Text) + Convert.ToDecimal("1.0");
                    ActionsNum.Text = Convert.ToString(Act);

                }
            }
        }

        //Dual Weapons//
        private void button26_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(Dex_Box.Text);


                    // Abilites // 
                    int FireA = Convert.ToInt32(Fire_Box.Text);
                    var Auto = FireA + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(Diff_Box.Text);
                    var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
                    var Actions = Convert.ToDouble(ActionsNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Auto + NegHealth;

                    if (Actions > 0.5)
                    {
                        dicecount = Auto - actionInt + NegHealth;

                    }
                    else
                    {
                        dicecount = Auto + NegHealth;
                    }

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff + 2)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //
                        if (Success >= Fail)
                        {
                            Numbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            Numbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(ActionsNum.Text) + Convert.ToDecimal("1.0");
                    ActionsNum.Text = Convert.ToString(Act);

                }
            }
        }


        //Ranged Combat Buttons//

        //Block//
        private void button22_Click_1(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(Dex_Box.Text);
                    // Abilites // 
                    int Brawl = Convert.ToInt32(Brawl_Box.Text);
                    // Difficulty //
                    int Diff = Convert.ToInt32(Diff_Box.Text);
                    // Face Storage //
                    int Face;
                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= Dex + Brawl; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            Numbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            Numbers.Text = Convert.ToString("Fail");
                        }
                    }

                }
            }
        }


        //parry//
        private void button23_Click_1(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(Dex_Box.Text);

                    // Abilites // 
                    int Melee = Convert.ToInt32(Mel_Box.Text);
                    var parry = Melee + Dex;
                    // Difficulty //
                    int Diff = Convert.ToInt32(Diff_Box.Text);
                    var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
                    var dicecount = parry + NegHealth;

                    ////Possible Outcomes// 
                    //int frequency1 = 0;
                    //int frequency2 = 2;
                    //int frequency3 = 3;
                    //int frequency4 = 4;
                    //int frequency5 = 5;
                    //int frequency6 = 6;
                    //int frequency7 = 7;
                    //int frequency8 = 8;
                    //int frequency9 = 9;
                    //int frequency10 = 10;

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            Numbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            Numbers.Text = Convert.ToString("Fail");
                        }
                    }

                }
            }
        }


        //Dodge//
        private void button24_Click_1(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(Dex_Box.Text);

                    // Abilites // 
                    int Dodge = Convert.ToInt32(Dodge_Box.Text);
                    // Difficulty //
                    int Diff = Convert.ToInt32(Diff_Box.Text);
                    var NegHealth = Convert.ToInt32(CurHealthNegative.Text);
                    var Dod = Dodge + Dex;
                    var dicecount = Dod + NegHealth;
                    ////Possible Outcomes// 
                    //int frequency1 = 0;
                    //int frequency2 = 2;
                    //int frequency3 = 3;
                    //int frequency4 = 4;
                    //int frequency5 = 5;
                    //int frequency6 = 6;
                    //int frequency7 = 7;
                    //int frequency8 = 8;
                    //int frequency9 = 9;
                    //int frequency10 = 10;

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            DodgeRatingNum.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }

                    }

                }
            }
        }

        //Soak//
        private void button25_Click_1(object sender, EventArgs e)
        {
            //  Damage Box - Soak
            var Arm = Convert.ToInt32(ArmorBox.Text);
            var Stam = Convert.ToInt32(Stam_Box.Text);
            var Dmg = Convert.ToInt32(DamageTakenBox.Text);
            var Health = Convert.ToInt32(CurHealth.Text);
            var Soak = Arm + Stam;
            var Damagetaken = Dmg - Soak;
            var ExistingDamage = Health + Damagetaken;

            switch (Damagetaken)
            {
                case 0:
                    if (Damagetaken <= 0)
                    {
                        Numbers.Text = Convert.ToString("No Damage");

                    }
                    break;
                case 1:
                    if (Damagetaken == 1)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);


                    }
                    break;
                case 2:
                    if (Damagetaken == 2)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);


                    }
                    break;
                case 3:
                    if (Damagetaken == 3)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 4:
                    if (Damagetaken == 4)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 5:
                    if (Damagetaken == 5)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 6:
                    if (Damagetaken == 6)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 7:
                    if (Damagetaken == 7)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 8:
                    if (Damagetaken == 8)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 9:
                    if (Damagetaken == 9)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 10:
                    if (Damagetaken == 10)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 11:
                    if (Damagetaken == 11)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 12:
                    if (Damagetaken == 12)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 13:
                    if (Damagetaken == 13)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 14:
                    if (Damagetaken >= 14)
                    {
                        CurHealth.Text = Convert.ToString(ExistingDamage);

                    }
                    break;

            }
            if (ExistingDamage == 0)
            {
                CurHealthStatus.Text = Convert.ToString("Fine");
            }
            if (ExistingDamage == 1)
            {
                CurHealthStatus.Text = Convert.ToString("Bruised");
            }
            if (ExistingDamage == 2)
            {
                CurHealthStatus.Text = Convert.ToString("Bruised");
            }
            if (ExistingDamage == 3)
            {
                CurHealthStatus.Text = Convert.ToString("Hurt");
                CurHealthNegative.Text = Convert.ToString(-1);
            }
            if (ExistingDamage == 4)
            {
                CurHealthStatus.Text = Convert.ToString("Hurt");
                CurHealthNegative.Text = Convert.ToString(-1);
            }
            if (ExistingDamage == 5)
            {
                CurHealthStatus.Text = Convert.ToString("Injured");
                CurHealthNegative.Text = Convert.ToString(-2);
            }
            if (ExistingDamage == 6)
            {
                CurHealthStatus.Text = Convert.ToString("Injured");
                CurHealthNegative.Text = Convert.ToString(-2);
            }
            if (ExistingDamage == 7)
            {
                CurHealthStatus.Text = Convert.ToString("Wounded");
                CurHealthNegative.Text = Convert.ToString(-2);
            }
            if (ExistingDamage == 8)
            {
                CurHealthStatus.Text = Convert.ToString("Wounded");
                CurHealthNegative.Text = Convert.ToString(-2);
            }
            if (ExistingDamage == 9)
            {
                CurHealthStatus.Text = Convert.ToString("Mauled");
                CurHealthNegative.Text = Convert.ToString(-2);
            }
            if (ExistingDamage == 10)
            {
                CurHealthStatus.Text = Convert.ToString("Mauled");
                CurHealthNegative.Text = Convert.ToString(-2);
            }
            if (ExistingDamage == 11)
            {
                CurHealthStatus.Text = Convert.ToString("Crippled");
                CurHealthNegative.Text = Convert.ToString(-5);
            }
            if (ExistingDamage == 12)
            {
                CurHealthStatus.Text = Convert.ToString("Crippled");
                CurHealthNegative.Text = Convert.ToString(-5);
            }
            if (ExistingDamage == 13)
            {
                CurHealthStatus.Text = Convert.ToString("Incapacitated");
                CurHealthNegative.Text = Convert.ToString(-99);
            }
            if (ExistingDamage == 14)
            {
                CurHealthStatus.Text = Convert.ToString("Dead");
                CurHealthNegative.Text = Convert.ToString(-99);
            }
        }
        //Heal Buttons
        private void Heal1Butt_Click(object sender, EventArgs e)
        {
            var Health = Convert.ToInt32(CurHealth.Text);



            if (Health == 1)
            {
                CurHealth.Text = Convert.ToString("0");
                CurHealthStatus.Text = Convert.ToString("Fine");


            }

            if (Health == 2)
            {
                CurHealth.Text = Convert.ToString("1");
                CurHealthStatus.Text = Convert.ToString("Bruised");

            }
            if (Health == 3)
            {
                CurHealth.Text = Convert.ToString("2");
                CurHealthStatus.Text = Convert.ToString("Bruised");
                CurHealthNegative.Text = Convert.ToString("0");

            }
            if (Health == 4)
            {
                CurHealth.Text = Convert.ToString("3");
                CurHealthStatus.Text = Convert.ToString("Hurt");

            }
            if (Health == 5)
            {
                CurHealth.Text = Convert.ToString("4");
                CurHealthStatus.Text = Convert.ToString("Hurt");

            }
            if (Health == 6)
            {
                CurHealth.Text = Convert.ToString("5");
                CurHealthStatus.Text = Convert.ToString("Injured");

            }
            if (Health == 7)
            {
                CurHealth.Text = Convert.ToString("6");
                CurHealthStatus.Text = Convert.ToString("Injured");
                CurHealthNegative.Text = Convert.ToString("-1");

            }
            if (Health == 8)
            {
                CurHealth.Text = Convert.ToString("7");
                CurHealthStatus.Text = Convert.ToString("Wounded");

            }
            if (Health == 9)
            {
                CurHealth.Text = Convert.ToString("8");
                CurHealthStatus.Text = Convert.ToString("Wounded");

            }
            if (Health == 10)
            {
                CurHealth.Text = Convert.ToString("9");
                CurHealthStatus.Text = Convert.ToString("Mauled");

            }
            if (Health == 11)
            {
                CurHealth.Text = Convert.ToString("10");
                CurHealthStatus.Text = Convert.ToString("Mauled");
                CurHealthNegative.Text = Convert.ToString("-2");

            }
            if (Health == 12)
            {
                CurHealth.Text = Convert.ToString("11");
                CurHealthStatus.Text = Convert.ToString("Crippled");

            }
            if (Health == 13)
            {
                CurHealth.Text = Convert.ToString("12");
                CurHealthStatus.Text = Convert.ToString("Crippled");
                CurHealthNegative.Text = Convert.ToString("-5");

            }


        }

        private void HealAllButt_Click(object sender, EventArgs e)
        {
            CurHealth.Text = Convert.ToString(0);
            CurHealthStatus.Text = Convert.ToString("Fine");
            CurHealthNegative.Text = Convert.ToString(0);
        }

        //Rating Controls//

        //Initiative Button//
        private void button27_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();
            int Face;
            int Dex = Convert.ToInt32(Dex_Box.Text);
            int Wit = Convert.ToInt32(Wits_box.Text);

            Face = Roll.Next(1, 11);
            InitiativeRating.Text = Convert.ToString(Dex + Wit + Face);

            // Dex + Wits + 1 d10 roll
        }

        //Dodge Rating Button//
        private void DodgeRateButt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Str = Convert.ToInt32(Str_Box.Text);
                    int Dex = Convert.ToInt32(Dex_Box.Text);
                    int Stam = Convert.ToInt32(Stam_Box.Text);
                    int Char = Convert.ToInt32(Char_Box.Text);
                    int Mani = Convert.ToInt32(Man_box.Text);
                    int appear = Convert.ToInt32(Appear_Box.Text);
                    int Intel = Convert.ToInt32(Intel_box.Text);
                    int Perc = Convert.ToInt32(Perc_Box.Text);
                    int Wit = Convert.ToInt32(Wits_box.Text);

                    // Abilites // 
                    int Alert = Convert.ToInt32(Alert_Box.Text);
                    int Ath = Convert.ToInt32(Ath_Box.Text);
                    int Brawl = Convert.ToInt32(Brawl_Box.Text);
                    int Dodge = Convert.ToInt32(Dodge_Box.Text);
                    int Emp = Convert.ToInt32(Emp_Box.Text);
                    int Express = Convert.ToInt32(Express_Box.Text);
                    int Intim = Convert.ToInt32(Intim_Box.Text);
                    int Lead = Convert.ToInt32(Lead_Box.Text);
                    int Street = Convert.ToInt32(Street_Box.Text);
                    int Sub = Convert.ToInt32(Subt_Box.Text);
                    int AniK = Convert.ToInt32(AK_Box.Text);
                    int Craft = Convert.ToInt32(Crafts_box.Text);
                    int Drive = Convert.ToInt32(Drive_Box.Text);
                    int Eti = Convert.ToInt32(Eti_Box.Text);
                    int FireA = Convert.ToInt32(Fire_Box.Text);
                    int Melee = Convert.ToInt32(Mel_Box.Text);
                    int Perf = Convert.ToInt32(Perf_Box.Text);
                    int Sec = Convert.ToInt32(Sec_box.Text);
                    int Steal = Convert.ToInt32(Stealth_Box.Text);
                    int Surv = Convert.ToInt32(Surv_Box.Text);
                    int Acad = Convert.ToInt32(Ac_Box.Text);
                    int Comp = Convert.ToInt32(Com_Box.Text);
                    int Fin = Convert.ToInt32(Fin_Box.Text);
                    int Invest = Convert.ToInt32(Invest_Box.Text);
                    int Law = Convert.ToInt32(Law_Box.Text);
                    int Ling = Convert.ToInt32(Ling_Box.Text);
                    int Med = Convert.ToInt32(Med_Box.Text);
                    int Occ = Convert.ToInt32(Occ_Box.Text);
                    int Poli = Convert.ToInt32(Poli_Box.Text);
                    int Sci = Convert.ToInt32(Sci_Box.Text);
                    // Difficulty //
                    int Diff = Convert.ToInt32(Diff_Box.Text);

                    ////Possible Outcomes// 
                    //int frequency1 = 0;
                    //int frequency2 = 2;
                    //int frequency3 = 3;
                    //int frequency4 = 4;
                    //int frequency5 = 5;
                    //int frequency6 = 6;
                    //int frequency7 = 7;
                    //int frequency8 = 8;
                    //int frequency9 = 9;
                    //int frequency10 = 10;

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= Dex + Dodge; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success > Fail)
                        {
                            DodgeRatingNum.Text = Convert.ToString(Success - Fail);
                        }
                        else
                        {
                            Numbers.Text = Convert.ToString("Fail");
                        }
                    }

                }
            }
        }

        //Calculate jog/Run//
        private void ActionDistanceCalculator_Click(object sender, EventArgs e)
        {
            int Dex = Convert.ToInt32(Dex_Box.Text);
            JogNumLabel.Text = Convert.ToString(Dex + 36);
            RunNumLabel.Text = Convert.ToString(Dex + 60);
        }

        //Damage Taken Control//
        private void DamageTakenBox_TextChanged(object sender, EventArgs e)
        {

        }

        //Back to First vamp Page//
        private void BackToVampStart_Click(object sender, EventArgs e)
        {
            VampCombat.Visible = false;
        }

        // Load Will and Blood //
        private void LoadWillBloodButt_Click(object sender, EventArgs e)
        {
            CurWillNum.Text = Convert.ToString(MaxWillBox.Text);
            CurBloodNum.Text = Convert.ToString(MaxBloodPoolBox.Text);
        }

        // Run Button
        private void RunButt_Click(object sender, EventArgs e)
        {
            var Act = Convert.ToDecimal(ActionsNum.Text) + Convert.ToDecimal("1.0");
            ActionsNum.Text = Convert.ToString(Act);

        }

        //Jog Button
        private void JogButt_Click(object sender, EventArgs e)
        {
            var Act = Convert.ToDecimal(ActionsNum.Text) + Convert.ToDecimal("0.5");
            ActionsNum.Text = Convert.ToString(Act);
        }

        //NOT NEEDED
        private void InitiativeRating_Click(object sender, EventArgs e)
        {

        }

        //EndTurn
        private void button22_Click_2(object sender, EventArgs e)
        {
            ActionsNum.Text = Convert.ToString(0);
        }

        // Spend Will Button
        private void WillButton_Click(object sender, EventArgs e)
        {
            var Will = Convert.ToInt32(CurWillNum.Text);
            CurWillNum.Text = Convert.ToString(Will - 1);

        }

        //Save Button
        private void SaveButton_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("...\\Vampire.xml", FileMode.Create, FileAccess.Write);
            Information i = new Information();
            //Save Attributes
            i.Str_Box = int.Parse(Str_Box.Text);
            i.Dex_Box = int.Parse(Dex_Box.Text);
            i.Stam_Box = int.Parse(Stam_Box.Text);
            i.Char_Box = int.Parse(Char_Box.Text);
            i.Man_Box = int.Parse(Man_box.Text);
            i.Appear_Box = int.Parse(Appear_Box.Text);
            i.intel_Box = int.Parse(Intel_box.Text);
            i.Per_Box = int.Parse(Perc_Box.Text);
            i.Wits_Box = int.Parse(Wits_box.Text);

            i.Alert_Box = int.Parse(Alert_Box.Text);
            i.Ath_Box = int.Parse(Ath_Box.Text);
            i.Brawl_Box = int.Parse(Brawl_Box.Text);
                i.Dodge_Box = int.Parse(Dodge_Box.Text);
                i.Emp_Box = int.Parse(Emp_Box.Text);
                i.Express_Box = int.Parse(Express_Box.Text);
                i.intim_Box = int.Parse(Intim_Box.Text);
                i.Lead_Box = int.Parse(Lead_Box.Text);
                i.Street_Box = int.Parse(Street_Box.Text);
                i.Subt_Box = int.Parse(Subt_Box.Text);
                i.AK_Box = int.Parse(AK_Box.Text);
                i.Crafts_box = int.Parse(Crafts_box.Text);
                i.Drive_Box = int.Parse(Drive_Box.Text);
                i.Fire_Box = int.Parse(Fire_Box.Text);
                i.Mel_Box = int.Parse(Mel_Box.Text);
                i.Perf_Box = int.Parse(Perf_Box.Text);
                i.Sec_box = int.Parse(Sec_box.Text);
                i.Stealth_Box = int.Parse(Stealth_Box.Text);
                i.Surv_Box = int.Parse(Surv_Box.Text);
                i.Ac_Box = int.Parse(Ac_Box.Text);
                i.Com_Box = int.Parse(Com_Box.Text);
                i.Fin_Box = int.Parse(Fin_Box.Text);
                i.Invest_Box = int.Parse(Invest_Box.Text);
                i.Law_Box = int.Parse(Law_Box.Text);
                i.Ling_Box = int.Parse(Ling_Box.Text);
                i.Med_Box = int.Parse(Med_Box.Text);
                i.Occ_Box = int.Parse(Occ_Box.Text);
                i.Poli_Box = int.Parse(Poli_Box.Text);
                i.Sci_Box = int.Parse(Sci_Box.Text);
                i.Blood = int.Parse(CurBloodNum.Text);
                 i.Will = int.Parse(CurWillNum.Text);
            i.Human = int.Parse(VampHum.Text);
            i.Hp = int.Parse(CurHealth.Text);
            i.HStatus = Convert.ToString(CurHealthStatus.Text);
            i.HNeg = int.Parse(CurHealthNegative.Text);
            i.Name = Convert.ToString(VampireName.Text);
            i.Clan = Convert.ToString(VampClan.Text);
            i.Sire = Convert.ToString(VampSire.Text);
            i.Gen = int.Parse(GenerationTextBox.Text);
            i.Cons = int.Parse(VampCons.Text);
            i.Conv = int.Parse(VampConv.Text);
            i.Cour = int.Parse(VampCour.Text);
            i.MaxWill = int.Parse(MaxWillBox.Text);
            ls.Add(i);
            xs.Serialize(fs, ls);
            Numbers.Text = Convert.ToString("Save Successful");
            fs.Close();
           
        }

      

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {


            }
        }

        //Move to Social page button
        private void SocialButton_Click(object sender, EventArgs e)
        {
            // VampireSocial.Visible = true;
        }


        /////////////////
        //Demon Roller//
        ////////////////

        //Demon Button
        private void button6_Click(object sender, EventArgs e)
        {
            VampireStart.Visible = true;
            VampCombat.Visible = true;
            VampireSocial.Visible = true;
            DemonStart.Visible = true;
        }

        //Demon Start Over
        private void button59_Click_1(object sender, EventArgs e)
        {
            VampireStart.Visible = false;
            VampCombat.Visible = false;
            VampireSocial.Visible = false;
            DemonStart.Visible = false;
        }

        //Demon Combat Button
        private void button58_Click_1(object sender, EventArgs e)
        {
            DemonCombat2.Visible = true;
        }

        //Demon Back Button
        private void button36_Click(object sender, EventArgs e)
        {
            DemonCombat2.Visible = false;
        }

        //Demon Social Button
        private void button23_Click_2(object sender, EventArgs e)
        {
            DemonSocial.Visible = true;
        }

        //Demon Save Button
        private void button24_Click_2(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("...\\Demon.xml", FileMode.Create, FileAccess.Write);
            Information i = new Information();
            //Save Attributes
            i.DemStr = int.Parse(DemStrBox.Text);
            i.DemDex = int.Parse(DemDexBox.Text);
            i.DemStam = int.Parse(DemStamBox.Text);
            i.DemChar = int.Parse(DemCharBox.Text);
            i.DemMan = int.Parse(DemManBox.Text);
            i.DemApp = int.Parse(DemAppBox.Text);
            i.DemIntel = int.Parse(DemIntBox.Text);
            i.DemPerc = int.Parse(DemPercBox.Text);
            i.DemWits = int.Parse(DemWitsBox.Text);

            i.DemAlert = int.Parse(DemAlertBox.Text);
            i.DemAth = int.Parse(DemAthBox.Text);
            i.DemBrawl = int.Parse(DemBrawlBox.Text);
            i.DemDod = int.Parse(DemDodBox.Text);
            i.DemEmp = int.Parse(DemEmpBox.Text);
            i.DemExp = int.Parse(DemExpBox.Text);
            i.DemIntim = int.Parse(DemIntiBox.Text);
            i.DemLead = int.Parse(DemLeadBox.Text);
            i.Demstreet = int.Parse(DemStreetBox.Text);
            i.DemSubt = int.Parse(DemSubBox.Text);
            i.DemAK = int.Parse(DemAKBox.Text);
            i.DemCraft = int.Parse(DemCraftBox.Text);
            i.DemDrive = int.Parse(DemDriveBox.Text);
            i.DemFire = int.Parse(DemFABox.Text);
            i.DemMel = int.Parse(DemMelBox.Text);
            i.DemPerf = int.Parse(DemPerfbox.Text);
            i.DemLarc = int.Parse(DemSecBox.Text);
            i.DemSteal = int.Parse(DemStlBox.Text);
            i.DemSurv = int.Parse(DemSurvBox.Text);
            i.DemAcad = int.Parse(DemAcaBox.Text);
            i.Demcomp = int.Parse(DemComBox.Text);
            i.DemFin = int.Parse(DemFinBox.Text);
            i.DemInvest = int.Parse(DemInvBox.Text);
            i.DemLaw = int.Parse(DemLawBox.Text);
            i.DemReli = int.Parse(DemReliBox.Text);
            i.DemMed = int.Parse(DemMedBox.Text);
            i.DemOcc = int.Parse(DemOccBox.Text);
            i.Dempoli = int.Parse(DemPolBox.Text);
            i.DemSci = int.Parse(DemSciBox.Text);
            i.DemFaith = int.Parse(MaxFaithBox.Text);
            i.DemCurFaith = int.Parse(CurFaithNum.Text);
            i.DemWill = int.Parse(MaxDemWillBox.Text);
            i.DemCurWill = int.Parse(DemCurWillNum.Text);
            i.DemTorm = int.Parse(DemonTormentBox.Text);
            i.DemTempTorm = int.Parse(TempTormNum.Text);
            i.DemHp = int.Parse(DemCurHealthNum.Text);
            i.DemHStatus = Convert.ToString(DemHealthStatus.Text);
            i.DemHNeg = int.Parse(DemonCurHealthNeg.Text);
            i.DemName = Convert.ToString(DemonNameBox.Text);
            i.DemFaction = Convert.ToString(FactionTextBox.Text);
            i.DemVis = Convert.ToString(VisageBox.Text);
            i.DemHouse = Convert.ToString(HouseBox.Text);
            ls.Add(i);
            xs.Serialize(fs, ls);
            DemNumbers.Text = Convert.ToString("Save successful");
            fs.Close();


        }


        //Close Combat//

        //Dem Clinch
        private void DemClinchbutt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    var Str = Convert.ToInt32(DemStrBox.Text);

                    // Abilites // 

                    var Brawl = Convert.ToInt32(DemBrawlBox.Text);
                    var Clinch = Str + Brawl;
                    // Difficulty //
                    var Diff = Convert.ToInt32(DemDiffBox.Text);
                    var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);
                    var Actions = Convert.ToDouble(DemActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Clinch + NegHealth;

                    if (Actions > 0.5)
                    {
                        dicecount = Clinch - actionInt + NegHealth;

                    }
                    else
                    {
                        dicecount = Clinch + NegHealth;
                    }


                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            DemNumbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            DemNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("1.0");
                    DemActNum.Text = Convert.ToString(Act);
                }
            }
        }


        //Dem Disarm
        private void button52_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(DemDexBox.Text);

                    // Abilites // 
                    int Melee = Convert.ToInt32(DemMelBox.Text);
                    var Disarm = Melee + Dex;
                    // Difficulty //
                    int Diff = Convert.ToInt32(DemDiffBox.Text);
                    var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);
                    var Actions = Convert.ToDouble(DemActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Disarm + NegHealth + 1;

                    if (Actions > 0.5)
                    {
                        dicecount = Disarm - actionInt + NegHealth + 1;

                    }
                    else
                    {
                        dicecount = Disarm + NegHealth + 1;
                    }


                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            DemNumbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            DemNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("1.0");
                    DemActNum.Text = Convert.ToString(Act);

                }
            }
        }


        //Dem Hold
        private void button51_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Str = Convert.ToInt32(DemStrBox.Text);

                    // Abilites // 
                    int Brawl = Convert.ToInt32(DemBrawlBox.Text);
                    var hold = Str + Brawl;
                    // Difficulty //
                    int Diff = Convert.ToInt32(DemDiffBox.Text);
                    var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);
                    var Actions = Convert.ToDouble(DemActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = hold + NegHealth;

                    if (Actions > 0.5)
                    {
                        dicecount = hold - actionInt + NegHealth;

                    }
                    else
                    {
                        dicecount = hold + NegHealth;
                    }

                    ////Possible Outcomes// 
                    //int frequency1 = 0;
                    //int frequency2 = 2;
                    //int frequency3 = 3;
                    //int frequency4 = 4;
                    //int frequency5 = 5;
                    //int frequency6 = 6;
                    //int frequency7 = 7;
                    //int frequency8 = 8;
                    //int frequency9 = 9;
                    //int frequency10 = 10;

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            DemNumbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            DemNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("1.0");
                    DemActNum.Text = Convert.ToString(Act);

                }
            }
        }


        //Dem Kick
        private void DemKickButt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Abilites // 
                    int Brawl = Convert.ToInt32(DemBrawlBox.Text);

                    // Difficulty //
                    int Diff = Convert.ToInt32(DemDiffBox.Text);
                    var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);
                    var Actions = Convert.ToDouble(DemActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Brawl + NegHealth;

                    if (Actions > 0.5)
                    {
                        dicecount = Brawl - actionInt + NegHealth;

                    }
                    else
                    {
                        dicecount = Brawl + NegHealth;
                    }

                    ////Possible Outcomes// 
                    //int frequency1 = 0;
                    //int frequency2 = 2;
                    //int frequency3 = 3;
                    //int frequency4 = 4;
                    //int frequency5 = 5;
                    //int frequency6 = 6;
                    //int frequency7 = 7;
                    //int frequency8 = 8;
                    //int frequency9 = 9;
                    //int frequency10 = 10;

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            DemNumbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            DemNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("1.0");
                    DemActNum.Text = Convert.ToString(Act);

                }
            }
        }


        //Dem Punch
        private void button56_Click(object sender, EventArgs e)
        {
            {
                Random Roll = new Random();

                // Attributes //
                var Dex = Convert.ToInt32(DemDexBox.Text);

                // Abilites // 
                var Brawl = Convert.ToInt32(DemBrawlBox.Text);
                var Punch = (Dex + Brawl);

                // Difficulty //
                int Diff = Convert.ToInt32(DemDiffBox.Text);
                var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);
                var Actions = Convert.ToDouble(DemActNum.Text);
                var actionDec = Convert.ToDecimal("1.5");
                var actionInt = Convert.ToInt32(Math.Floor(Actions));
                var dicecount = Punch + NegHealth;

                if (Actions > 0.5)
                {
                    dicecount = Punch - actionInt + NegHealth;

                }
                else
                {
                    dicecount = Punch + NegHealth;
                }



                // Face Storage //
                int Face;

                //Success counter//
                int Success = 0;
                int Fail = 0;

                //Actual Roll
                for (int roll = 1; roll <= dicecount; ++roll)
                {
                    Face = Roll.Next(1, 11);
                    switch (Face)
                    {
                        case 1:
                            if (1 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                //--Success;
                                // ++Fail;
                            }
                            break;
                        case 2:
                            if (2 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                ++Fail;
                            }
                            break;
                        case 3:
                            if (3 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                ++Fail;
                            }
                            break;
                        case 4:
                            if (4 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                ++Fail;
                            }
                            break;
                        case 5:
                            if (5 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                ++Fail;
                            }
                            break;
                        case 6:
                            if (6 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                ++Fail;
                            }
                            break;
                        case 7:
                            if (7 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                ++Fail;
                            }
                            break;
                        case 8:
                            if (8 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                ++Fail;
                            }
                            break;
                        case 9:
                            if (9 >= Diff)
                            {
                                ++Success;
                            }
                            else
                            {
                                ++Fail;
                            }
                            break;
                        case 10:
                            if (10 >= Diff)
                            {
                                ++Success;
                                ++roll;
                            }
                            else
                            {
                                ++Fail;
                            }
                            break;
                    }

                    ////Ensures that lists are working properly//
                    // Numbers.Text = Convert.ToString("S" + Success + " " + "F" + Fail );


                    if (Success >= Fail)
                    {
                        DemNumbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                    }
                    else
                    {
                        DemNumbers.Text = Convert.ToString("Fail");
                    }
                }
                var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("1.0");
                DemActNum.Text = Convert.ToString(Act);

            }
        }


        //Dem Sweep
        private void DemLegSweepButt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(DemDexBox.Text);


                    // Abilites // 
                    int Brawl = Convert.ToInt32(DemBrawlBox.Text);
                    var Sweep = Dex + Brawl;
                    // Difficulty //
                    int Diff = Convert.ToInt32(DemDiffBox.Text);
                    var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);
                    var Actions = Convert.ToDouble(DemActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Sweep + NegHealth;

                    if (Actions > 0.5)
                    {
                        dicecount = Sweep - actionInt + NegHealth;

                    }
                    else
                    {
                        dicecount = Sweep + NegHealth;
                    }
                    ////Possible Outcomes// 
                    //int frequency1 = 0;
                    //int frequency2 = 2;
                    //int frequency3 = 3;
                    //int frequency4 = 4;
                    //int frequency5 = 5;
                    //int frequency6 = 6;
                    //int frequency7 = 7;
                    //int frequency8 = 8;
                    //int frequency9 = 9;
                    //int frequency10 = 10;

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            DemNumbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            DemNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("1.0");
                    DemActNum.Text = Convert.ToString(Act);

                }
            }
        }


        //Dem Tackle
        private void DemTackleButt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Str = Convert.ToInt32(DemStrBox.Text);

                    // Abilites // 
                    int Brawl = Convert.ToInt32(DemBrawlBox.Text);
                    var Tackle = Brawl + Str;
                    // Difficulty //
                    int Diff = Convert.ToInt32(DemDiffBox.Text);
                    var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);
                    var Actions = Convert.ToDouble(DemActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Tackle + NegHealth;

                    if (Actions > 0.5)
                    {
                        dicecount = Tackle - actionInt + NegHealth;

                    }
                    else
                    {
                        dicecount = Tackle + NegHealth;
                    }

                    ////Possible Outcomes// 
                    //int frequency1 = 0;
                    //int frequency2 = 2;
                    //int frequency3 = 3;
                    //int frequency4 = 4;
                    //int frequency5 = 5;
                    //int frequency6 = 6;
                    //int frequency7 = 7;
                    //int frequency8 = 8;
                    //int frequency9 = 9;
                    //int frequency10 = 10;

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            DemNumbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            DemNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("1.0");
                    DemActNum.Text = Convert.ToString(Act);

                }
            }
        }


        //Dem Weapon Stirke
        private void DemWSButt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(DemDexBox.Text);

                    // Abilites // 
                    int Melee = Convert.ToInt32(DemMelBox.Text);
                    var WS = Melee + Dex;
                    // Difficulty //
                    int Diff = Convert.ToInt32(DemDiffBox.Text);
                    var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);
                    var Actions = Convert.ToDouble(DemActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = WS + NegHealth;

                    if (Actions > 0.5)
                    {
                        dicecount = WS - actionInt + NegHealth;

                    }
                    else
                    {
                        dicecount = WS + NegHealth;
                    }


                    ////Possible Outcomes// 
                    //int frequency1 = 0;
                    //int frequency2 = 2;
                    //int frequency3 = 3;
                    //int frequency4 = 4;
                    //int frequency5 = 5;
                    //int frequency6 = 6;
                    //int frequency7 = 7;
                    //int frequency8 = 8;
                    //int frequency9 = 9;
                    //int frequency10 = 10;

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }
                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            DemNumbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            DemNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("1.0");
                    DemActNum.Text = Convert.ToString(Act);

                }
            }
        }


        //Demon Use Power
        private void DemUseButt_Click(object sender, EventArgs e)
        {
            var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("1.0");
            DemActNum.Text = Convert.ToString(Act);
        }

        //Ranged Combat//

        // Dem Aim
        private void button45_Click(object sender, EventArgs e)
        {
            DemNumbers.Text = "You have taken Aim";
        }

        //Dem Auto-Fire
        private void button44_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //

                    int Dex = Convert.ToInt32(DemDexBox.Text);


                    // Abilites //
                    int FireA = Convert.ToInt32(DemFABox.Text);
                    var Auto = FireA + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(DemDiffBox.Text);
                    var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);
                    var Actions = Convert.ToDouble(DemActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Auto + NegHealth + 10;

                    if (Actions > 0.5)
                    {
                        dicecount = Auto - actionInt + NegHealth + 10;

                    }
                    else
                    {
                        dicecount = Auto + NegHealth + 10;
                    }

                    ////Possible Outcomes// 
                    //int frequency1 = 0;
                    //int frequency2 = 2;
                    //int frequency3 = 3;
                    //int frequency4 = 4;
                    //int frequency5 = 5;
                    //int frequency6 = 6;
                    //int frequency7 = 7;
                    //int frequency8 = 8;
                    //int frequency9 = 9;
                    //int frequency10 = 10;

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            DemNumbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            DemNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("1.0");
                    DemActNum.Text = Convert.ToString(Act);

                }
            }
        }


        //Dem Cover
        private void button43_Click(object sender, EventArgs e)
        {
            DemNumbers.Text = Convert.ToString("You are in cover remind storyteller");

        }

        //Dem 3RB
        private void button42_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(DemDexBox.Text);

                    // Abilites // 
                    int FireA = Convert.ToInt32(DemFABox.Text);
                    var Auto = FireA = Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(DemDiffBox.Text);
                    var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);
                    var Actions = Convert.ToDouble(DemActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Auto + NegHealth + 2;

                    if (Actions > 0.5)
                    {
                        dicecount = Auto - actionInt + NegHealth + 2;

                    }
                    else
                    {
                        dicecount = Auto + NegHealth + 2;
                    }

                    ////Possible Outcomes// 
                    //int frequency1 = 0;
                    //int frequency2 = 2;
                    //int frequency3 = 3;
                    //int frequency4 = 4;
                    //int frequency5 = 5;
                    //int frequency6 = 6;
                    //int frequency7 = 7;
                    //int frequency8 = 8;
                    //int frequency9 = 9;
                    //int frequency10 = 10;

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            DemNumbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            DemNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("1.0");
                    DemActNum.Text = Convert.ToString(Act);

                }
            }
        }

        //Dem Dual-Weapons
        private void button41_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(DemDexBox.Text);


                    // Abilites // 
                    int FireA = Convert.ToInt32(DemFABox.Text);
                    var Auto = FireA + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(DemDiffBox.Text);
                    var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);
                    var Actions = Convert.ToDouble(DemActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Auto + NegHealth;

                    if (Actions > 0.5)
                    {
                        dicecount = Auto - actionInt + NegHealth;

                    }
                    else
                    {
                        dicecount = Auto + NegHealth;
                    }

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff + 2)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            DemNumbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            DemNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("1.0");
                    DemActNum.Text = Convert.ToString(Act);

                }
            }
        }


        //Defense Controls//

        //Dem Block
        private void DemBlockButt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(DemDexBox.Text);
                    // Abilites // 
                    int Brawl = Convert.ToInt32(DemBrawlBox.Text);
                    var Block = Dex + Brawl;
                    // Difficulty //
                    int Diff = Convert.ToInt32(DemDiffBox.Text);
                    var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);               
                    var dicecount = Block + NegHealth;

                    
                    // Face Storage //
                    int Face;
                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            DemNumbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            DemNumbers.Text = Convert.ToString("Fail");
                        }
                    }

                }
            }
        }

        //Dem Parry
        private void DemParButt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(DemDexBox.Text);

                    // Abilites // 
                    int Melee = Convert.ToInt32(DemMelBox.Text);
                    var parry = Dex + Melee;
                    // Difficulty //
                    int Diff = Convert.ToInt32(DemDiffBox.Text);
                    var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);
                    var dicecount = parry + NegHealth;

                    ////Possible Outcomes// 
                    //int frequency1 = 0;
                    //int frequency2 = 2;
                    //int frequency3 = 3;
                    //int frequency4 = 4;
                    //int frequency5 = 5;
                    //int frequency6 = 6;
                    //int frequency7 = 7;
                    //int frequency8 = 8;
                    //int frequency9 = 9;
                    //int frequency10 = 10;

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            DemNumbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            DemNumbers.Text = Convert.ToString("Fail");
                        }
                    }

                }
            }
        }

        //Dem Dodge
        private void DemDodButt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(DemDexBox.Text);

                    // Abilites // 
                    int Dodge = Convert.ToInt32(DemDodBox.Text);
                    var Dod = Dex + Dodge;
                    // Difficulty //
                    int Diff = Convert.ToInt32(DemDiffBox.Text);
                    var NegHealth = Convert.ToInt32(DemonCurHealthNeg.Text);
                    var dicecount = Dod + NegHealth;
                    ////Possible Outcomes// 
                    //int frequency1 = 0;
                    //int frequency2 = 2;
                    //int frequency3 = 3;
                    //int frequency4 = 4;
                    //int frequency5 = 5;
                    //int frequency6 = 6;
                    //int frequency7 = 7;
                    //int frequency8 = 8;
                    //int frequency9 = 9;
                    //int frequency10 = 10;

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            DemNumbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            DemNumbers.Text = Convert.ToString("Fail");
                        }

                    }

                }
            }
        }


       
        //Dem Soak
        private void DemSoakButt_Click(object sender, EventArgs e)
        {
            //  Damage Box - Soak
            var Arm = Convert.ToInt32(DemArmBox.Text);
            var Stam = Convert.ToInt32(DemStamBox.Text);
            var Dmg = Convert.ToInt32(DDTBox.Text);
            var Health = Convert.ToInt32(DemCurHealthNum.Text);
            var Soak = Arm + Stam;
            var Damagetaken = Dmg - Soak;
            var ExistingDamage = Health + Damagetaken;

            switch (Damagetaken)
            {
                case 0:
                    if (Damagetaken <= 0)
                    {
                        DemNumbers.Text = Convert.ToString("No Damage");

                    }
                    break;
                case 1:
                    if (Damagetaken == 1)
                    {
                        DemCurHealthNum.Text = Convert.ToString(ExistingDamage);


                    }
                    break;
                case 2:
                    if (Damagetaken == 2)
                    {
                        DemCurHealthNum.Text = Convert.ToString(ExistingDamage);


                    }
                    break;
                case 3:
                    if (Damagetaken == 3)
                    {
                        DemCurHealthNum.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 4:
                    if (Damagetaken == 4)
                    {
                        DemCurHealthNum.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 5:
                    if (Damagetaken == 5)
                    {
                        DemCurHealthNum.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 6:
                    if (Damagetaken == 6)
                    {
                        DemCurHealthNum.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 7:
                    if (Damagetaken == 7)
                    {
                        DemCurHealthNum.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 8:
                    if (Damagetaken == 8)
                    {
                        DemCurHealthNum.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 9:
                    if (Damagetaken == 9)
                    {
                        DemCurHealthNum.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 10:
                    if (Damagetaken == 10)
                    {
                        DemCurHealthNum.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 11:
                    if (Damagetaken == 11)
                    {
                        DemCurHealthNum.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 12:
                    if (Damagetaken == 12)
                    {
                        DemCurHealthNum.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 13:
                    if (Damagetaken == 13)
                    {
                        DemCurHealthNum.Text = Convert.ToString(ExistingDamage);

                    }
                    break;
                case 14:
                    if (Damagetaken >= 14)
                    {
                        DemCurHealthNum.Text = Convert.ToString(ExistingDamage);

                    }
                    break;

            }
            if (ExistingDamage == 0)
            {
                DemHealthStatus.Text = Convert.ToString("Fine");
            }
            if (ExistingDamage == 1)
            {
                DemHealthStatus.Text = Convert.ToString("Bruised");
            }
            if (ExistingDamage == 2)
            {
                DemHealthStatus.Text = Convert.ToString("Bruised");
            }
            if (ExistingDamage == 3)
            {
                DemHealthStatus.Text = Convert.ToString("Hurt");
                DemonCurHealthNeg.Text = Convert.ToString(-1);
            }
            if (ExistingDamage == 4)
            {
                DemHealthStatus.Text = Convert.ToString("Hurt");
                DemonCurHealthNeg.Text = Convert.ToString(-1);
            }
            if (ExistingDamage == 5)
            {
                DemHealthStatus.Text = Convert.ToString("Injured");
                DemonCurHealthNeg.Text = Convert.ToString(-2);
            }
            if (ExistingDamage == 6)
            {
                DemHealthStatus.Text = Convert.ToString("Injured");
                DemonCurHealthNeg.Text = Convert.ToString(-2);
            }
            if (ExistingDamage == 7)
            {
                DemHealthStatus.Text = Convert.ToString("Wounded");
                DemonCurHealthNeg.Text = Convert.ToString(-2);
            }
            if (ExistingDamage == 8)
            {
                DemHealthStatus.Text = Convert.ToString("Wounded");
                DemonCurHealthNeg.Text = Convert.ToString(-2);
            }
            if (ExistingDamage == 9)
            {
                DemHealthStatus.Text = Convert.ToString("Mauled");
                DemonCurHealthNeg.Text = Convert.ToString(-2);
            }
            if (ExistingDamage == 10)
            {
                DemHealthStatus.Text = Convert.ToString("Mauled");
                DemonCurHealthNeg.Text = Convert.ToString(-2);
            }
            if (ExistingDamage == 11)
            {
                DemHealthStatus.Text = Convert.ToString("Crippled");
                DemonCurHealthNeg.Text = Convert.ToString(-5);
            }
            if (ExistingDamage == 12)
            {
                DemHealthStatus.Text = Convert.ToString("Crippled");
                DemonCurHealthNeg.Text = Convert.ToString(-5);
            }
            if (ExistingDamage == 13)
            {
                DemHealthStatus.Text = Convert.ToString("Incapacitated");
                DemonCurHealthNeg.Text = Convert.ToString(-99);
            }
            if (ExistingDamage == 14)
            {
                DemHealthStatus.Text = Convert.ToString("Dead");
                DemonCurHealthNeg.Text = Convert.ToString(-99);
            }
        }


        //Rating Controls

        //Dem Load Various Stats
        private void LoadWTFButt_Click(object sender, EventArgs e)
        {
            DemCurWillNum.Text = MaxDemWillBox.Text;
            CurFaithNum.Text = MaxFaithBox.Text;
        }

        //Dem Spend Will
        private void DemSpendWill_Click(object sender, EventArgs e)
        {
            var Will = Convert.ToInt32(DemCurWillNum.Text);
            DemCurWillNum.Text = Convert.ToString(Will - 1);
        }

        //Dem Gain Temp. Torment
        private void DemTormButt_Click(object sender, EventArgs e)
        {
            var TempTorm = Convert.ToInt32(TempTormNum.Text);
            TempTormNum.Text = Convert.ToString(TempTorm + 1);
            var Torm = Convert.ToInt32(DemonTormentBox.Text);
            if (TempTorm == 10)
            {
                TempTormNum.Text = Convert.ToString(0);
                DemonTormentBox.Text = Convert.ToString(Torm + 1);

            }
        }

        //Dem Spend faith
        private void SpendFaithButt_Click(object sender, EventArgs e)
        {
            var faith = Convert.ToInt32(CurFaithNum.Text);
            CurFaithNum.Text = Convert.ToString(faith - 1);
        }

        //Dem Initiative Rate
        private void DemInitiativeButt_Click(object sender, EventArgs e)
        {
            Random Roll = new Random();
            int Face;
            int Dex = Convert.ToInt32(DemDexBox.Text);
            int Wit = Convert.ToInt32(DemWitsBox.Text);

            Face = Roll.Next(1, 11);
            DemInitiativeNum.Text = Convert.ToString(Dex + Wit + Face);

            // Dex + Wits + 1 d10 roll
        }


        //Dem Dodge Rate
        private void demDodgeRateButt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(DemDexBox.Text);

                    // Abilites // 
                    int Dodge = Convert.ToInt32(DemDodBox.Text);
                    // Difficulty //
                    int Diff = Convert.ToInt32(DemDiffBox.Text);

                

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= Dex + Dodge; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            DemDodgeRateNum.Text = Convert.ToString(Success - Fail);
                        }
                        else
                        {
                            Numbers.Text = Convert.ToString("Fail");
                        }
                    }

                }
            }
        }


        //Dem Jog/Run Calcukate
        private void DemCalcBox_Click(object sender, EventArgs e)
        {
            int Dex = Convert.ToInt32(DemDexBox.Text);
            DemJogNum.Text = Convert.ToString(Dex + 36);
            DemRunNum.Text = Convert.ToString(Dex + 60);
        }


        //Dem Jog Button
        private void DemJogButt_Click(object sender, EventArgs e)
        {
            var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("0.5");
            DemActNum.Text = Convert.ToString(Act);
        }


        //Dem Run button
        private void DemRunbutt_Click(object sender, EventArgs e)
        {
            var Act = Convert.ToDecimal(DemActNum.Text) + Convert.ToDecimal("1.0");
            DemActNum.Text = Convert.ToString(Act);

        }

        //Dem Heal 1 button (Natural Heal)
        private void Demheal1Butt_Click(object sender, EventArgs e)
        {
            var Health = Convert.ToInt32(DemCurHealthNum.Text);



            if (Health == 1)
            {
                DemCurHealthNum.Text = Convert.ToString("0");
                DemHealthStatus.Text = Convert.ToString("Fine");


            }

            if (Health == 2)
            {
                DemCurHealthNum.Text = Convert.ToString("1");
                DemHealthStatus.Text = Convert.ToString("Bruised");

            }
            if (Health == 3)
            {
                DemCurHealthNum.Text = Convert.ToString("2");
                DemHealthStatus.Text = Convert.ToString("Bruised");
                DemonCurHealthNeg.Text = Convert.ToString("0");

            }
            if (Health == 4)
            {
                DemCurHealthNum.Text = Convert.ToString("3");
                DemHealthStatus.Text = Convert.ToString("Hurt");

            }
            if (Health == 5)
            {
                DemCurHealthNum.Text = Convert.ToString("4");
                DemHealthStatus.Text = Convert.ToString("Hurt");

            }
            if (Health == 6)
            {
                DemCurHealthNum.Text = Convert.ToString("5");
                DemHealthStatus.Text = Convert.ToString("Injured");

            }
            if (Health == 7)
            {
                DemCurHealthNum.Text = Convert.ToString("6");
                DemHealthStatus.Text = Convert.ToString("Injured");
                DemonCurHealthNeg.Text = Convert.ToString("-1");

            }
            if (Health == 8)
            {
                DemCurHealthNum.Text = Convert.ToString("7");
                DemHealthStatus.Text = Convert.ToString("Wounded");

            }
            if (Health == 9)
            {
                DemCurHealthNum.Text = Convert.ToString("8");
                DemHealthStatus.Text = Convert.ToString("Wounded");

            }
            if (Health == 10)
            {
                DemCurHealthNum.Text = Convert.ToString("9");
                DemHealthStatus.Text = Convert.ToString("Mauled");

            }
            if (Health == 11)
            {
                DemCurHealthNum.Text = Convert.ToString("10");
                DemHealthStatus.Text = Convert.ToString("Mauled");
                DemonCurHealthNeg.Text = Convert.ToString("-2");

            }
            if (Health == 12)
            {
                DemCurHealthNum.Text = Convert.ToString("11");
                DemHealthStatus.Text = Convert.ToString("Crippled");

            }
            if (Health == 13)
            {
                DemCurHealthNum.Text = Convert.ToString("12");
                DemHealthStatus.Text = Convert.ToString("Crippled");
                DemonCurHealthNeg.Text = Convert.ToString("-5");

            }


        }


        // Heal All Button
        private void DemHealAllbutt_Click(object sender, EventArgs e)
        {
            DemCurHealthNum.Text = Convert.ToString(0);
            DemHealthStatus.Text = Convert.ToString("Fine");
            DemonCurHealthNeg.Text = Convert.ToString(0);
        }


        //Dem Faith Healing
        private void FaithHealButt_Click(object sender, EventArgs e)
        {
            var Health = Convert.ToInt32(DemCurHealthNum.Text);
            var faith = Convert.ToInt32(CurFaithNum.Text);



            if (Health == 1)
            {
                DemCurHealthNum.Text = Convert.ToString("0");
                DemHealthStatus.Text = Convert.ToString("Fine");
                CurFaithNum.Text = Convert.ToString(faith - 1);



            }

            if (Health == 2)
            {
                DemCurHealthNum.Text = Convert.ToString("1");
                DemHealthStatus.Text = Convert.ToString("Bruised");
                CurFaithNum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 3)
            {
                DemCurHealthNum.Text = Convert.ToString("2");
                DemHealthStatus.Text = Convert.ToString("Bruised");
                DemonCurHealthNeg.Text = Convert.ToString("0");
                CurFaithNum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 4)
            {
                DemCurHealthNum.Text = Convert.ToString("3");
                DemHealthStatus.Text = Convert.ToString("Hurt");
                CurFaithNum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 5)
            {
                DemCurHealthNum.Text = Convert.ToString("4");
                DemHealthStatus.Text = Convert.ToString("Hurt");
                CurFaithNum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 6)
            {
                DemCurHealthNum.Text = Convert.ToString("5");
                DemHealthStatus.Text = Convert.ToString("Injured");
                CurFaithNum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 7)
            {
                DemCurHealthNum.Text = Convert.ToString("6");
                DemHealthStatus.Text = Convert.ToString("Injured");
                DemonCurHealthNeg.Text = Convert.ToString("-1");
                CurFaithNum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 8)
            {
                DemCurHealthNum.Text = Convert.ToString("7");
                DemHealthStatus.Text = Convert.ToString("Wounded");
                CurFaithNum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 9)
            {
                DemCurHealthNum.Text = Convert.ToString("8");
                DemHealthStatus.Text = Convert.ToString("Wounded");
                CurFaithNum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 10)
            {
                DemCurHealthNum.Text = Convert.ToString("9");
                DemHealthStatus.Text = Convert.ToString("Mauled");
                CurFaithNum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 11)
            {
                DemCurHealthNum.Text = Convert.ToString("10");
                DemHealthStatus.Text = Convert.ToString("Mauled");
                DemonCurHealthNeg.Text = Convert.ToString("-2");
                CurFaithNum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 12)
            {
                DemCurHealthNum.Text = Convert.ToString("11");
                DemHealthStatus.Text = Convert.ToString("Crippled");
                CurFaithNum.Text = Convert.ToString(faith - 1);

            }
            if (Health == 13)
            {
                DemCurHealthNum.Text = Convert.ToString("12");
                DemHealthStatus.Text = Convert.ToString("Crippled");
                DemonCurHealthNeg.Text = Convert.ToString("-5");
                CurFaithNum.Text = Convert.ToString(faith - 1);

            }


        }


        //Dem End Turn
        private void button31_Click(object sender, EventArgs e)
        {
            DemActNum.Text = Convert.ToString(0);
        }


        //////////////////
        //Wraith Roller//
        ////////////////

        //Wraith Button
        private void button4_Click(object sender, EventArgs e)
        {
            VampireStart.Visible = true;
            VampCombat.Visible = true;
            VampireSocial.Visible = true;
            DemonStart.Visible = true;
            DemonCombat2.Visible = true;
            DemonSocial.Visible = true;
            Wraithstart.Visible = true;
        }

        private void WraStartOver_Click(object sender, EventArgs e)
        {
            VampireStart.Visible = false;
            VampCombat.Visible = false;
            VampireSocial.Visible = false;
            DemonStart.Visible = false;
            DemonCombat2.Visible = false;
            DemonSocial.Visible = false;
            Wraithstart.Visible = false;
        }

        private void WraithCombatbutt_Click(object sender, EventArgs e)
        {
            WraithCombat.Visible = true;
        }

        ////Various Loads
        //Load Pathos Corpus Will
        private void WraithLoadStats_Click(object sender, EventArgs e)
        {
            WraCurCorpNum.Text = Convert.ToString(WraithCorpusBox.Text);
            WraCurPathNum.Text = Convert.ToString(WraPathosBox.Text);
            WraCurWillNum.Text = Convert.ToString(WraMWillBox.Text);
        }

        //Initiative rating
        private void WraInitButt_Click(object sender, EventArgs e)
        {
            var Dex = Convert.ToInt32(WraDexBox.Text);
            var Wits = Convert.ToInt32(WraWitsbox.Text);
            Random Roll = new Random();
            int Face;
            Face = Roll.Next(1, 11);
            WraInitNum.Text = Convert.ToString(Dex + Wits + Face);
        }
        
        //Wraith Dodge Rating
        private void WraDodgeRatebutt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(WraDexBox.Text);

                    // Abilites // 
                    int Dodge = Convert.ToInt32(WraDodBox.Text);
                    // Difficulty //
                    int Diff = Convert.ToInt32(WraDiffBox.Text);



                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= Dex + Dodge; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success > Fail)
                        {
                            WraDodRateNum.Text = Convert.ToString(Success - Fail);
                        }
                        else
                        {
                            WraithNumbers.Text = Convert.ToString("Fail");
                        }
                    }

                }
            }
        }

        // Wraith Jog / Run Calc
        private void WraCalcButt_Click(object sender, EventArgs e)
        {
            var Dex = Convert.ToInt32(WraDexBox.Text);
            WraRunNum.Text = Convert.ToString(Dex + 60);
            WraJogNum.Text = Convert.ToString(Dex + 36);
        }

        //Wraith End turn 
        private void button33_Click(object sender, EventArgs e)
        {
            WraActNum.Text = Convert.ToString(0);
        }

        ////Wraith Spend buttons

        //Lose Corpus
        private void WraSpendCorpbutt_Click(object sender, EventArgs e)
        {
            var corp = Convert.ToInt32(WraCurCorpNum.Text);
            WraCurCorpNum.Text = Convert.ToString(corp - 1);
        }
        
        //Wraith jog Button
        private void WraJogbutt_Click(object sender, EventArgs e)
        {
            var Act = Convert.ToDecimal(WraActNum.Text) + Convert.ToDecimal("0.5");
            WraActNum.Text = Convert.ToString(Act);

        }

        //Wraith run button
        private void WraRunButt_Click(object sender, EventArgs e)
        {
            var Act = Convert.ToDecimal(WraActNum.Text) + Convert.ToDecimal("1.0");
            WraActNum.Text = Convert.ToString(Act);
        }

        //Gain Corpus
        private void GainCorpusbutt_Click(object sender, EventArgs e)
        {
            var corp = Convert.ToInt32(WraCurCorpNum.Text);
            WraCurCorpNum.Text = Convert.ToString(corp + 1);
        }

        //Spens Pathos
        private void WraCurPathButt_Click(object sender, EventArgs e)
        {
            var pathos = Convert.ToInt32(WraCurPathNum.Text);
            WraCurPathNum.Text = Convert.ToString(pathos - 1);
        }
        //Use Will
        private void WraSpendWillbutt_Click(object sender, EventArgs e)
        {
            var Will = Convert.ToInt32(WraCurWillNum.Text);
            WraCurWillNum.Text = Convert.ToString(Will - 1);
        }


        ////Close Combat

            //Flank
        private void WraFlankButt_Click(object sender, EventArgs e)
        {
            WraithNumbers.Text = Convert.ToString("You are Flanking enemy add 1 auto success to your next close combat Attack.");
        }

       
        //Body slam
        private void WraBodSlambutt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(WraDexBox.Text);


                    // Abilites // 
                    int Brawl = Convert.ToInt32(WraBraBox.Text);
                    var BS = Brawl + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(WraDiffBox.Text);
                    var Actions = Convert.ToDouble(WraActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = BS  ;

                    if (Actions > 0.5)
                    {
                        dicecount = BS - actionInt  ;

                    }
                    else
                    {
                        dicecount = BS ;
                    }

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff + 2)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            WraithNumbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            WraithNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(WraActNum.Text) + Convert.ToDecimal("1.0");
                    WraActNum.Text = Convert.ToString(Act);

                }
            }
        }

        //Grapple
        private void WraGrappleButt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Str = Convert.ToInt32(WraStrBox.Text);


                    // Abilites // 
                    int Brawl = Convert.ToInt32(WraBraBox.Text);
                    var Grap = Str + Brawl;

                    // Difficulty //
                    int Diff = Convert.ToInt32(WraDiffBox.Text);
                    var Actions = Convert.ToDouble(WraActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Grap ;

                    if (Actions > 0.5)
                    {
                        dicecount = Grap - actionInt ;

                    }
                    else
                    {
                        dicecount = Grap ;
                    }

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            WraithNumbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            WraithNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(WraActNum.Text) + Convert.ToDecimal("1.0");
                    WraActNum.Text = Convert.ToString(Act);

                }
            }
        }


        //Kick
        private void WraKickButt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();



                    // Abilites // 
                    int Brawl = Convert.ToInt32(WraBraBox.Text);
               

                    // Difficulty //
                    int Diff = Convert.ToInt32(WraDiffBox.Text);
                    var Actions = Convert.ToDouble(WraActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = Brawl;

                    if (Actions > 0.5)
                    {
                        dicecount = Brawl - actionInt;

                    }
                    else
                    {
                        dicecount = Brawl;
                    }

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff )
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            WraithNumbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            WraithNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(WraActNum.Text) + Convert.ToDecimal("1.0");
                    WraActNum.Text = Convert.ToString(Act);

                }
            }
        }

        //Punch
        private void WraPunchbutt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(WraDexBox.Text);


                    // Abilites // 
                    int Brawl = Convert.ToInt32(WraBraBox.Text);
                    var BS = Brawl + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(WraDiffBox.Text);
                    var Actions = Convert.ToDouble(WraActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = BS;

                    if (Actions > 0.5)
                    {
                        dicecount = BS - actionInt;

                    }
                    else
                    {
                        dicecount = BS;
                    }

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff )
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            WraithNumbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            WraithNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(WraActNum.Text) + Convert.ToDecimal("1.0");
                    WraActNum.Text = Convert.ToString(Act);

                }
            }
        }

        //Leaping Rake
        private void WraLeapingRake_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(WraDexBox.Text);


                    // Abilites // 
                    int Brawl = Convert.ToInt32(WraBraBox.Text);
                    var BS = Brawl + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(WraDiffBox.Text);
                    var Actions = Convert.ToDouble(WraActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = BS;

                    if (Actions > 0.5)
                    {
                        dicecount = BS - actionInt;

                    }
                    else
                    {
                        dicecount = BS;
                    }

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff )
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            WraithNumbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            WraithNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(WraActNum.Text) + Convert.ToDecimal("1.0");
                    WraActNum.Text = Convert.ToString(Act);

                }
            }
        }

        private void WraUsePowButt_Click(object sender, EventArgs e)
        {
            var Act = Convert.ToDecimal(WraActNum.Text) + Convert.ToDecimal("1.0");
            WraActNum.Text = Convert.ToString(Act);
        }

        ////Ranged Combat

        //Take Aim
        private void WraAimButt_Click(object sender, EventArgs e)
        {
            WraithNumbers.Text = Convert.ToString("You have taken aim add 1 auto success");
        }

        //Auto-Fire
        private void WraAutoFButt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(WraDexBox.Text);


                    // Abilites // 
                    int Firea = Convert.ToInt32(WraFABox.Text);
                    var BS = Firea + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(WraDiffBox.Text);
                    var Actions = Convert.ToDouble(WraActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = BS + 10;

                    if (Actions > 0.5)
                    {
                        dicecount = BS - actionInt + 10;

                    }
                    else
                    {
                        dicecount = BS + 10;
                    }

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            WraithNumbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            WraithNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(WraActNum.Text) + Convert.ToDecimal("1.0");
                    WraActNum.Text = Convert.ToString(Act);

                }
            }
        }

        //Wraith 3rb
        private void Wra3rbbutt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(WraDexBox.Text);


                    // Abilites // 
                    int Firea = Convert.ToInt32(WraFABox.Text);
                    var BS = Firea + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(WraDiffBox.Text);
                    var Actions = Convert.ToDouble(WraActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = BS + 2;

                    if (Actions > 0.5)
                    {
                        dicecount = BS - actionInt + 2;

                    }
                    else
                    {
                        dicecount = BS + 2;
                    }

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff )
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            WraithNumbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            WraithNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(WraActNum.Text) + Convert.ToDecimal("1.0");
                    WraActNum.Text = Convert.ToString(Act);

                }
            }
        }


        //Dual Wep
        private void WraDualWepButt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(WraDexBox.Text);


                    // Abilites // 
                    int Firea = Convert.ToInt32(WraFABox.Text);
                    var BS = Firea + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(WraDiffBox.Text);
                    var Actions = Convert.ToDouble(WraActNum.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = BS;

                    if (Actions > 0.5)
                    {
                        dicecount = BS - actionInt;

                    }
                    else
                    {
                        dicecount = BS;
                    }

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff + 2)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff + 2)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            WraithNumbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            WraithNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(WraActNum.Text) + Convert.ToDecimal("1.0");
                    WraActNum.Text = Convert.ToString(Act);

                }
            }
        }


        // Wraith Cover
        private void WraCovButt_Click(object sender, EventArgs e)
        {
            WraithNumbers.Text = Convert.ToString("you are in cover remind StoryTeller");
        }

        //// Defense Manuevers

        //Block
        private void WraBlockButt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(WraDexBox.Text);


                    // Abilites // 
                    int Brawl = Convert.ToInt32(WraBraBox.Text);
                    var BS = Brawl + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(WraDiffBox.Text);
                    var Actions = Convert.ToDouble(WraFABox.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = BS;

                 

                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff )
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            WraithNumbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            WraithNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(WraActNum.Text) + Convert.ToDecimal("1.0");
                    WraActNum.Text = Convert.ToString(Act);

                }
            }
        }

        //Wraith Dodge
        private void WraDodgeButt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(WraDexBox.Text);


                    // Abilites // 
                    int Dodge = Convert.ToInt32(WraDodBox.Text);
                    var BS = Dodge + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(WraDiffBox.Text);
                    var Actions = Convert.ToDouble(WraFABox.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = BS;



                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            WraithNumbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            WraithNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(WraActNum.Text) + Convert.ToDecimal("1.0");
                    WraActNum.Text = Convert.ToString(Act);

                }
            }
        }

        //Parry
        private void WraParrybutt_Click(object sender, EventArgs e)
        {
            {
                {
                    Random Roll = new Random();

                    // Attributes //
                    int Dex = Convert.ToInt32(WraDexBox.Text);


                    // Abilites // 
                    int Melee = Convert.ToInt32(WraMelBox.Text);
                    var BS = Melee + Dex;

                    // Difficulty //
                    int Diff = Convert.ToInt32(WraDiffBox.Text);
                    var Actions = Convert.ToDouble(WraFABox.Text);
                    var actionDec = Convert.ToDecimal("1.5");
                    var actionInt = Convert.ToInt32(Math.Floor(Actions));
                    var dicecount = BS;



                    // Face Storage //
                    int Face;


                    //Success counter//
                    int Success = 0;
                    int Fail = 0;


                    for (int roll = 1; roll <= dicecount; ++roll)
                    {
                        Face = Roll.Next(1, 11);
                        switch (Face)
                        {
                            case 1:
                                if (1 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    --Success;
                                    ++Fail;
                                }
                                break;
                            case 2:
                                if (2 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 3:
                                if (3 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 4:
                                if (4 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 5:
                                if (5 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 6:
                                if (6 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 7:
                                if (7 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 8:
                                if (8 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 9:
                                if (9 >= Diff)
                                {
                                    ++Success;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                            case 10:
                                if (10 >= Diff)
                                {
                                    ++Success;
                                    ++roll;
                                }
                                else
                                {
                                    ++Fail;
                                }
                                break;
                        }

                        //Ensures that lists are working properly//
                        // Numbers.Text = Convert.ToString("S"+Success+" "+"F"+Fail);
                        //

                        if (Success >= Fail)
                        {
                            WraithNumbers.Text = Convert.ToString(Success - Fail + " " + "Successes");
                        }
                        else
                        {
                            WraithNumbers.Text = Convert.ToString("Fail");
                        }
                    }
                    var Act = Convert.ToDecimal(WraActNum.Text) + Convert.ToDecimal("1.0");
                    WraActNum.Text = Convert.ToString(Act);

                }
            }
        }

        //Wraith Soak
        private void WraSoakButt_Click(object sender, EventArgs e)
        {
            var Arm = Convert.ToInt32(WraArmBox.Text);
            var Stam = Convert.ToInt32(wraStamBox.Text);
            var Dmg = Convert.ToInt32(WraDamagebox.Text);
            var Soak = Arm + Stam;
            var Damagetaken = Dmg - Soak;
            if (Damagetaken <= 0)
            {
                WraithNumbers.Text = Convert.ToString("No Damage");

            }
            else 
            if (Damagetaken > 0)
            {
                WraithNumbers.Text = Convert.ToString("You take" + " " + Damagetaken + " " + "Damage");

            }
        }

        //Wraith Save
        private void wraSaveButt_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("...\\Wraith.xml", FileMode.Create, FileAccess.Write);
            Information i = new Information();
            //Save Attributes
            i.Wrastr = int.Parse(WraStrBox.Text);
            i.Wradex = int.Parse(WraDexBox.Text);
            i.Wrastam = int.Parse(wraStamBox.Text);
            i.Wrachar = int.Parse(WraCharBox.Text);
            i.wraman = int.Parse(WraManiBox.Text);
            i.wraapp = int.Parse(WraAppBox.Text);
            i.wraintel = int.Parse(WraIntBox.Text);
            i.wraperc = int.Parse(WraPercBox.Text);
            i.wrawits = int.Parse(WraWitsbox.Text);

            i.wraalert = int.Parse(WraAlertBox.Text);
            i.wraath = int.Parse(WraAthBox.Text);
            i.wrabra = int.Parse(WraBraBox.Text);
            i.wradod = int.Parse(WraDodBox.Text);
            i.wraemp = int.Parse(WraEmpBox.Text);
            i.wraexp = int.Parse(WraExpBox.Text);
            i.wrainti = int.Parse(WraIntimBox.Text);
            i.wralead = int.Parse(WraLeadBox.Text);
            i.wrastreet = int.Parse(WraStreetBox.Text);
            i.wrasubt = int.Parse(WraSubbox.Text);
            i.wracraft = int.Parse(WraCraBox.Text);
            i.wradrive = int.Parse(WraDrvBox.Text);
            i.wraeti = int.Parse(WraEtiBox.Text);
            i.wrafa = int.Parse(WraFABox.Text);
            i.wramel = int.Parse(WraMelBox.Text);
            i.wraperf = int.Parse(WraPerfBox.Text);
            i.wrasec = int.Parse(WraSecBox.Text);
            i.wrasteal = int.Parse(WraStealbox.Text);
            i.wraacad = int.Parse(WraAcadBox.Text);
            i.wracomp = int.Parse(WraCompBox.Text);
            i.wraenig = int.Parse(WraEngBox.Text);
            i.wrainvest = int.Parse(WraInvestBox.Text);
            i.wralaw = int.Parse(WraLawbox.Text);
            i.wraling = int.Parse(WraLingbox.Text);
            i.wramed = int.Parse(WraMedBox.Text);
            i.wraocc = int.Parse(WraOccBox.Text);
            i.wrapoli = int.Parse(WraPolibox.Text);
            i.wrasci = int.Parse(WraScibox.Text);
            i.wrapathos = int.Parse(WraPathosBox.Text);
            i.wracurpathos = int.Parse(WraCurPathNum.Text);
            i.corpus = int.Parse(WraithCorpusBox.Text);
            i.wracurcorp = int.Parse(WraCurCorpNum.Text);
            i.wraName = Convert.ToString(WraithNameBox.Text);
            i.wraLife = Convert.ToString(WraithLifeBox.Text);
            i.wraDeath = Convert.ToString(WraithDeathBox.Text);
            i.wraMaxWill = int.Parse(WraMWillBox.Text);
            i.wraWill = int.Parse(WraCurWillNum.Text);
            ls.Add(i);
            xs.Serialize(fs, ls);
            Numbers.Text = Convert.ToString("Save Successful");
            fs.Close();

        }


        private void wraithSocButt_Click(object sender, EventArgs e)
        {
            //w
        }

        
    }
}

        //////////////////
        // Mage Roller //
        /////////////////

      