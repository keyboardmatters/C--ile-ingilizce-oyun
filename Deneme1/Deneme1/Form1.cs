using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Deneme1
{
    public partial class baslangic_ekrani : Form
    {
        List<Panel> Paneller = new List<Panel>();

        List<string> hayvanlar_ingilizce = new List<string>(new string[] { "Cow", "Horse", "Cat", "Dog", "Bear", "Spider", "Chicken", "Turtle", "Mouse", "Rabbit" });
        List<string> renk_isimleri = new List<string>(new string[] { "BLACK", "BLUE", "BROWN", "PINK", "WHITE", "RED", "PURPLE", "ORANGE", "GREEN", "YELLOW" });
        List<string> meyve_isimleri_ingilizce = new List<string>(new string[] { "Apple", "Pear", "Cherry", "Strawberry", "Orange", "Watermelon", "Melon", "Banana", "Grape" });
        List<string> ulkeler_ingilizce = new List<string>(new string[] { "Turkey", "Spain", "France", "Poland", "Germany", "Japan", "England", "Italy", "Portugal", "China" });
        string[,] ulkeler_level3_cevaplar = new string[,] { { "Turkey", "Türkey", "Turkiy", "Turkay" }, { "Spain", "Spane", "Sipain", "Ispain" }, { "France", "Franse", "Franca", "Frence" }, { "Poland", "Polany", "Polony", "Polond" }, { "Germany", "Germani", "Cermany", "Garmany" }, { "Japan", "Japon", "Japany", "Jopony" }, { "England", "Ingland", "Englond", "Ingiland", }, { "Italy", "İtaly", "Italya", "Italiy" }, { "Portugal", "Portagal", "Partugal", "Portuga" }, { "China", "Çhina", "Chine", "Chayna" } };
        List<string> sayilar_ingilizce = new List<string>(new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten","twenty","thirty", "fourty","fifty","sixty","seventy","eighty","ninety","one hundred"});

        List<PictureBox> hayvanlar_level1_resimler = new List<PictureBox>();
        List<Label> hayvanlar_level1_yazilar = new List<Label>();
        List<Button> hayvanlar_level1_oklar = new List<Button>();
        List<PictureBox> level2_hayvanlar = new List<PictureBox>();
        List<Button> hayvanlar_level2_butonlar = new List<Button>();
        List<Button> hayvanlar_level2_rastgele_butonlar = new List<Button>();
        List<int> hayvanlar_level2_rastgele_rakamlar = new List<int>();
        List<PictureBox> hayvanlar_level3_resimler = new List<PictureBox>();
        List<Label> hayvanlar_level3_yazilar = new List<Label>();
        List<int> hayvanlar_level3_rakamlar = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        List<int> hayvanlar_level3_rakamlar2 = new List<int>(new int[] { 0, 1, 2, 3, 4 });
        List<int> hayvanlar_level3_karisik_rakamlar = new List<int>();
        List<int> hayvanlar_level3_karisik_rakamlar2 = new List<int>();
        List<Button> hayvanlar_level3_oklar = new List<Button>();
        List<Point> hayvanlar_level3_resim_yerleri = new List<Point>();
        List<Point> hayvanlar_level3_okbaslangiclari = new List<Point>();

        List<PictureBox> renkler_level2_nesneler = new List<PictureBox>();
        List<PictureBox> level3_renkler = new List<PictureBox>();
        List<int> renkler_level3_rakamlar = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        List<int> renkler_level3_rastgele_rakamlar = new List<int>();
        List<int> renkler_level3_kontrol = new List<int>();

        List<Label> bodyparts_level1_yazilar = new List<Label>();
        List<Button> bodyparts_level1_butonlar = new List<Button>();
        List<PictureBox> body_level3_resimler = new List<PictureBox>();
        List<Label> body_level3_labellar = new List<Label>();
        List<int> body_level3_rakamlar = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 });
        List<int> body_level3_karisik_rakamlar = new List<int>();

        List<PictureBox> meyveler_level2_resimler = new List<PictureBox>();
        List<int> meyveler_level2_rakamlar = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 });
        List<int> meyveler_level2_rastgele_rakamlar = new List<int>();
        List<PictureBox> meyveler_level3_resimpicturebox = new List<PictureBox>();
        List<PictureBox> meyveler_level3_yazipicturebox = new List<PictureBox>();
        List<int> meyveler_level3_karisik_rakamlar = new List<int>();
        List<int> meyveler_level3_karisik_rakamlar2 = new List<int>();

        List<PictureBox> level1_ulkeler = new List<PictureBox>();
        List<PictureBox> level2_ulkeler = new List<PictureBox>();
        List<Button> ulkeler_level2_butonlar = new List<Button>();
        List<int> ulkeler_level2_rakamlar = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        List<int> ulkeler_level2_karisik1 = new List<int>();
        List<int> ulkeler_level2_karisik2 = new List<int>();
        List<PictureBox> level3_ulkeler = new List<PictureBox>();
        List<Button> ulkeler_level3_butonlar = new List<Button>();
        List<int> ulkeler_level3_karisik_rakamlar = new List<int>();
        List<Button> ulkeler_level3_karisik_butonlar = new List<Button>();

        List<PictureBox> sayilar_level2 = new List<PictureBox>();
        List<int> rakamlar_sayilar_level2 = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 });
        List<int> rastgele_rakamlar_sayilar_level2 = new List<int>();
        List<PictureBox> sayilar_level3 = new List<PictureBox>();
        List<Button> sayilar_level3_butonlar = new List<Button>();
        List<int> sayilar_level3_rakamlar = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 });
        List<int> sayilar_level3_rastgele_rakamlar = new List<int>();
        List<int> sayilar_level3_rastgele_rakamlar2 = new List<int>();       
        List<Button> sayilar_level3_rastgele_butonlar = new List<Button>();

        List<string> hayvanlar_ingilizce_bonus = new List<string>(new string[] {"Bee","Fish","Elephant","Deer","Butterfly","Sheep","Bird","Frog","Monkey","Duck","Penguin","Snail","Crocodile","Crab","Snake","Giraffe" });        
        List<PictureBox> hayvanlar_bonus = new List<PictureBox>();
        List<Button> hayvanlar_bonus_cevaplar = new List<Button>();
        List<Button> hayvanlar_bonus_cevaplar_karisik = new List<Button>();
        List<string> hayvanlar_karisik = new List<string>();
        List<int> hayvanlar_bonus_rakamlar = new List<int>(new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15});
        List<int> hayvanlar_bonus_karisik_rakamlar = new List<int>();

        List<string> sayilar_ingilizce_bonus = new List<string>(new string[] { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" });
        List<PictureBox> sayilar_bonus = new List<PictureBox>();
        List<Button> sayilar_bonus_cevaplar = new List<Button>();
        List<Button> sayilar_bonus_cevaplar_karisik = new List<Button>();
        List<string> sayilar_karisik = new List<string>();
        List<int> sayilar_bonus_rakamlar = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 });
        List<int> sayilar_bonus_karisik_rakamlar = new List<int>();

        List<string> ulkeler_ingilizce_bonus = new List<string>(new string[] { "United States of America", "Algeria", "Croatia", "Netherlands", "India", "Sweden", "Switzerland", "Hungary", "Egypt","Greece" });
        List<PictureBox> ulkeler_bonus = new List<PictureBox>();
        List<Button> ulkeler_bonus_cevaplar = new List<Button>();
        List<Button> ulkeler_bonus_cevaplar_karisik = new List<Button>();
        List<string> ulkeler_karisik = new List<string>();
        List<int> ulkeler_bonus_rakamlar = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9});
        List<int> ulkeler_bonus_karisik_rakamlar = new List<int>();

        List<string> meyveler_ingilizce_bonus = new List<string>(new string[] { "Tomato", "Patato", "Carrot", "Corn", "Cucumber", "Eggplant", "Lettuce", "Mushroom", "Olive", "Onion", "Lemon" });
        List<PictureBox> meyveler_bonus = new List<PictureBox>();
        List<Button> meyveler_bonus_cevaplar = new List<Button>();
        List<Button> meyveler_bonus_cevaplar_karisik = new List<Button>();
        List<string> meyveler_karisik = new List<string>();
        List<int> meyveler_bonus_rakamlar = new List<int>(new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10});
        List<int> meyveler_bonus_karisik_rakamlar = new List<int>();

        List<string> body_ingilizce = new List<string>(new string[] { "Hair", "Face", "Ear", "Eye", "Nose", "Lip", "Neck", "Arm", "Hand", "Abdomen", "Leg", "Foot" });
        List<string> body_ingilizce_bonus = new List<string>(new string[] { "Wrist", "Skin", "Tongue", "Elbow", "Teeth", "Knee", "Bone", "Shoulder", "Finger", "Beard", "Nail" });
        List<PictureBox> body_bonus = new List<PictureBox>();
        List<Button> body_bonus_cevaplar = new List<Button>();
        List<Button> body_bonus_cevaplar_karisik = new List<Button>();
        List<string> body_karisik = new List<string>();
        List<int> body_bonus_rakamlar = new List<int>(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
        List<int> body_bonus_karisik_rakamlar = new List<int>();

        int renkler_level2_sayac;
        int sayilar_level2_sayac;
        int sayilar_level3_sayac;
        int ulkeler_level2_sayac;
        int ulkeler_level3_sayac;
        int body_level3_sayac;
        int body_level3_rastgele_sayi;
        int meyveler_level2_sayac;
        int meyveler_level3_sayac;
        int kontrol1 = 0;
        int hayvanlar_level3_sayac;
        int kontrol2;
        int hayvanlar_level2_sayac;
        int fark;
        int zaman;
        int can;
        int tik_sayisi;
        int ulkeler_level1_kontrol;
        int hayvanlar_bonus_sayac;
        int sayilar_bonus_sayac;
        int ulkeler_bonus_sayac;
        int meyveler_bonus_sayac;
        int body_bonus_sayac;


        WindowsMediaPlayer ses = new WindowsMediaPlayer();
        
        Random rastgele = new Random();

        int dogru_yanlis;
        int sayi1;
        int sayilar_level2_rastgele_cevap;

        Point level1_one1_baslangic, level1_two1_baslangic, level1_three1_baslangic, level1_four1_baslangic, level1_five1_baslangic, level1_ten1_baslangic, level1_nine1_baslangic, level1_eight1_baslangic, level1_seven1_baslangic, level1_six1_baslangic, ok_ust, ok_alt1, ok_alt2, ok_alt3, ok_sol, ok_sag1, ok_sag2, ok_sag3, ok_orta, turkiye_baslangic, ispanya_baslangic, fransa_baslangic, polonya_baslangic, almanya_baslangic, japonya_baslangic, ingiltere_baslangic, italya_baslangic, portekiz_baslangic, cin_baslangic, bayrak_koordinat, ulke_isimleri_baslangic, level3_ok1_baslangic, level3_ok1_bitis, level3_ok2_baslangic, level3_ok2_bitis, level3_ok3_baslangic, level3_ok3_bitis, level3_ok4_baslangic, level3_ok4_bitis, level3_ok5_baslangic, level3_ok5_bitis, level3_resim1, level3_resim2, level3_resim3, level3_resim4, level3_resim5, ulkeler_level1_yazibaslangic, renkler_level3_yazi_baslangic, PanellerBaslangic;
        Size PanellerBoyut;
        public baslangic_ekrani()
        {
            InitializeComponent();

            PanellerBaslangic = new Point(0, 0);
            PanellerBoyut = new Size(1155, 687);
            Paneller = new List<Panel>(new Panel[] {hayvanlar_panel,hayvanlar_level1_panel,hayvanlar_level2_panel,hayvanlar_level2_passed,hayvanlar_level2_over,hayvanlar_level3_panel,hayvanlar_level3_passed,hayvanlar_level3_over,hayvanlar_bonuspanel,renkler_panel,renkler_level1_panel,renkler_level2_panel,renkler_level2_passed,renkler_level2_over,renkler_level3_panel,renkler_level3_passed,renkler_level3_over,bodyparts_panel,bodyparts_level1_panel,body_level2_panel,bodyparts_level2_passed,bodyparts_level2_over,body_level3_panel,bodyparts_level3_passed,bodyparts_level3_over,body_bonuspanel,meyveler_panel,meyveler_level1_panel,meyveler_level2_panel,meyveler_level2_passed,meyveler_level2_over,meyveler_level3_panel,meyveler_level3_passed,meyveler_level3_over,meyveler_bonuspanel,ulkeler_panel,ulkeler_level1_panel,ulkeler_level2_panel,ulkeler_level2_passed,ulkeler_level2_over,ulkeler_level3_panel,ulkeler_level3_passed,ulkeler_level3_over,ulkeler_bonuspanel,sayilar_panel,sayilar_level1_panel,sayilar_level2_panel,sayilar_level2_passed,sayilar_level2_over,sayilar_level3_panel,sayilar_level3_passed,sayilar_level3_over,sayilar_bonuspanel });
            for(int i = 0; i < Paneller.Count; i++)
            {
                Paneller[i].Location = PanellerBaslangic;
                Paneller[i].Size = PanellerBoyut;
            }

            level3_resim1 = new Point(34, 12);
            level3_resim2 = new Point(261, 12);
            level3_resim3 = new Point(488, 12);
            level3_resim4 = new Point(715, 12);
            level3_resim5 = new Point(942, 12);
            level3_ok1_baslangic = new Point(97, 526);
            level3_ok2_baslangic = new Point(327, 526);
            level3_ok3_baslangic = new Point(557, 526);
            level3_ok4_baslangic = new Point(787, 526);
            level3_ok5_baslangic = new Point(1017, 526);
            level3_ok1_bitis = new Point(97, 180);
            level3_ok2_bitis = new Point(327, 180);
            level3_ok3_bitis = new Point(557, 180);
            level3_ok4_bitis = new Point(787, 180);
            level3_ok5_bitis = new Point(1017, 180);


            renkler_level2_nesneler = new List<PictureBox>(new PictureBox[] {siyah_bardak,mavi_sandalye,kahverengi_yaprak,pembe_pamukseker,beyaz_bulut,kirmizi_gul,mor_sapka,turuncu_araba,yesil_yaprak,sari_gunes });            

            level3_renkler = new List<PictureBox>(new PictureBox[] { siyah_renk3, mavi_renk3, kahverengi_renk3, pembe_renk3, beyaz_renk3, kirmizi_renk3, mor_renk3, turuncu_renk3, yesil_renk3, sari_renk3 });

            sayilar_level2 = new List<PictureBox>(new PictureBox[] {bir,iki,uc,dort,bes,alti,yedi,sekiz,dokuz,on,yirmi,otuz,kirk,elli,altmis,yetmis,seksen,doksan,yuz });

            sayilar_level3 = new List<PictureBox>(new PictureBox[] {bir1,iki1,uc1,dort1,bes1,alti1,yedi1,sekiz1,dokuz1,on1,yirmi1,otuz1,kirk1,elli1,altmis1,yetmis1,seksen1,doksan1,yuz1 });

            sayilar_level3_butonlar = new List<Button>(new Button[] {sayilar_level3_cevap1,sayilar_level3_cevap2,sayilar_level3_cevap3,sayilar_level3_cevap4 });

            level1_ulkeler = new List<PictureBox>(new PictureBox[] {ulkeler_level1_turkiye,ulkeler_level1_ispanya,ulkeler_level1_fransa,ulkeler_level1_polonya,ulkeler_level1_almanya,ulkeler_level1_japonya,ulkeler_level1_ingiltere,ulkeler_level1_italya,ulkeler_level1_portekiz,ulkeler_level1_cin });

            level2_ulkeler = new List<PictureBox>(new PictureBox[] {level2_turkey,level2_spain,level2_france,level2_poland,level2_germany,level2_japan,level2_england,level2_italy,level2_portugal,level2_china });

            ulkeler_level2_butonlar = new List<Button>(new Button[] {ulkeler_level2_cevap1, ulkeler_level2_cevap2, ulkeler_level2_cevap3, ulkeler_level2_cevap4, ulkeler_level2_cevap5, ulkeler_level2_cevap6, ulkeler_level2_cevap7, ulkeler_level2_cevap8, ulkeler_level2_cevap9, ulkeler_level2_cevap10,});

            level3_ulkeler = new List<PictureBox>(new PictureBox[] {level3_turkey,level3_spain,level3_france,level3_poland,level3_germany,level3_japan,level3_england,level3_italy,level3_portugal,level3_china });

            ulkeler_level3_butonlar = new List<Button>(new Button[] {ulkeler_level3_cevap1,ulkeler_level3_cevap2,ulkeler_level3_cevap3,ulkeler_level3_cevap4 });

            body_level3_resimler = new List<PictureBox>(new PictureBox[] {body_level3_sac,body_level3_yuz,body_level3_kulak,body_level3_goz,body_level3_burun,body_level3_dudak,body_level3_boyun,body_level3_kol,body_level3_el,body_level3_karin,body_level3_bacak,body_level3_ayak });

            body_level3_labellar = new List<Label>(new Label[] {body_level3_hair,body_level3_face,body_level3_ear,body_level3_eye,body_level3_nose,body_level3_lip,body_level3_neck,body_level3_arm,body_level3_hand,body_level3_abdomen,body_level3_leg,body_level3_foot });            

            bodyparts_level1_yazilar = new List<Label>(new Label[] {body_level1_yazi1,body_level1_yazi2,body_level1_yazi3,body_level1_yazi4,body_level1_yazi5,body_level1_yazi6,body_level1_yazi7,body_level1_yazi8,body_level1_yazi9,body_level1_yazi10,body_level1_yazi11,body_level1_yazi12});

            bodyparts_level1_butonlar = new List<Button>(new Button[] { body_level1_buton1, body_level1_buton2, body_level1_buton3, body_level1_buton4, body_level1_buton5, body_level1_buton6, body_level1_buton7, body_level1_buton8, body_level1_buton9, body_level1_buton10, body_level1_buton11, body_level1_buton12 });

            meyveler_level2_resimler = new List<PictureBox>(new PictureBox[] {meyveler_level2_apple,meyveler_level2_pear,meyveler_level2_cherry,meyveler_level2_strawberry,meyveler_level2_orange,meyveler_level2_watermelon,meyveler_level2_melon,meyveler_level2_banana,meyveler_level2_grape});

            meyveler_level3_resimpicturebox = new List<PictureBox>(new PictureBox[] {meyveler_level3_mavi1,meyveler_level3_mavi2,meyveler_level3_mavi3 });
            meyveler_level3_yazipicturebox = new List<PictureBox>(new PictureBox[] { meyveler_level3_sari1,meyveler_level3_sari2,meyveler_level3_sari3 });
    
            hayvanlar_level3_resimler = new List<PictureBox>(new PictureBox[] {hayvanlar_level3_cow,hayvanlar_level3_horse,hayvanlar_level3_cat,hayvanlar_level3_dog,hayvanlar_level3_bear,hayvanlar_level3_spider,hayvanlar_level3_chicken,hayvanlar_level3_turtle,hayvanlar_level3_mouse,hayvanlar_level3_rabbit });

            hayvanlar_level3_yazilar = new List<Label>(new Label[] {hayvanlar_level3_cow_yazi,hayvanlar_level3_horse_yazi,hayvanlar_level3_cat_yazi,hayvanlar_level3_dog_yazi,hayvanlar_level3_bear_yazi,hayvanlar_level3_spider_yazi,hayvanlar_level3_chicken_yazi,hayvanlar_level3_turtle_yazi,hayvanlar_level3_mouse_yazi,hayvanlar_level3_rabbit_yazi });

 
            hayvanlar_level3_resim_yerleri = new List<Point>(new Point[] { level3_resim1, level3_resim2, level3_resim3, level3_resim4, level3_resim5 });

            hayvanlar_level3_okbaslangiclari = new List<Point>(new Point[] {level3_ok1_baslangic,level3_ok2_baslangic,level3_ok3_baslangic,level3_ok4_baslangic,level3_ok5_baslangic });

            hayvanlar_level3_oklar = new List<Button>(new Button[] {hayvanlar_level3_ok1,hayvanlar_level3_ok2,hayvanlar_level3_ok3,hayvanlar_level3_ok4,hayvanlar_level3_ok5 });

            level2_hayvanlar = new List<PictureBox>(new PictureBox[] {level2_cow,level2_horse,level2_cat,level2_dog,level2_bear,level2_spider,level2_chicken,level2_turtle,level2_mouse,level2_rabbit });

            hayvanlar_level2_butonlar = new List<Button>(new Button[] {hayvanlar_level2_cevap1,hayvanlar_level2_cevap2});

            hayvanlar_level1_yazilar = new List<Label>(new Label[] {level1_cat_y,level1_dog_y,level1_cow_y,level1_rabbit_y,level1_turtle_y,level1_horse_y,level1_chicken_y,level1_bear_y,level1_spider_y,level1_mouse_y });

            hayvanlar_level1_resimler = new List<PictureBox>(new PictureBox[] {level1_cat,level1_dog,level1_cow,level1_rabbit,level1_turtle,level1_horse,level1_chicken,level1_bear,level1_spider,level1_mouse });

            hayvanlar_level1_oklar = new List<Button>(new Button[] {level1_ok1,level1_ok2,level1_ok3,level1_ok4,level1_ok5 });

            hayvanlar_bonus = new List<PictureBox>(new PictureBox[] { ari, balik, fil, geyik, kelebek, koyun, kus, kurbaga, maymun, ordek, penguen, salyangoz, timsah, yengec, yilan, zurafa });
         
            hayvanlar_bonus_cevaplar = new List<Button>(new Button[] {hayvanlar_bonus_cevap1,hayvanlar_bonus_cevap2,hayvanlar_bonus_cevap3,hayvanlar_bonus_cevap4 });
     
            sayilar_bonus = new List<PictureBox>(new PictureBox[] { onbir, oniki, onuc, ondort, onbes, onalti, onyedi, onsekiz, ondokuz });
       
            sayilar_bonus_cevaplar = new List<Button>(new Button[] { sayilar_bonus_cevap1, sayilar_bonus_cevap2, sayilar_bonus_cevap3, sayilar_bonus_cevap4 });
     
            ulkeler_bonus = new List<PictureBox>(new PictureBox[] {abd,cezayir,hirvatistan,hollanda,india,isvec,isvicre,macaristan,misir,yunanistan });
         
            ulkeler_bonus_cevaplar = new List<Button>(new Button[] { ulkeler_bonus_cevap1, ulkeler_bonus_cevap2, ulkeler_bonus_cevap3, ulkeler_bonus_cevap4 });
       
            meyveler_bonus = new List<PictureBox>(new PictureBox[] {domates, patates, havuc, misir_s, salatalik, patlican, marul, mantar, zeytin, sogan, limon });
     
            meyveler_bonus_cevaplar = new List<Button>(new Button[] { meyveler_bonus_cevap1, meyveler_bonus_cevap2, meyveler_bonus_cevap3, meyveler_bonus_cevap4 });
       
            body_bonus = new List<PictureBox>(new PictureBox[] { bilek, deri, dil, dirsek, dis, diz, kemik, omuz, parmak, sakal, tirnak });

            body_bonus_cevaplar = new List<Button>(new Button[] { body_bonus_cevap1, body_bonus_cevap2, body_bonus_cevap3, body_bonus_cevap4 });


            ControlExtension.Draggable(level1_one1, true);
            ControlExtension.Draggable(level1_two1, true);
            ControlExtension.Draggable(level1_three1, true);
            ControlExtension.Draggable(level1_four1, true);
            ControlExtension.Draggable(level1_five1, true);
            ControlExtension.Draggable(level1_ten1, true);
            ControlExtension.Draggable(level1_nine1, true);
            ControlExtension.Draggable(level1_eight1, true);
            ControlExtension.Draggable(level1_seven1, true);
            ControlExtension.Draggable(level1_six1, true);
            ControlExtension.Draggable(ulkeler_level1_turkiye, true);
            ControlExtension.Draggable(ulkeler_level1_ispanya, true);
            ControlExtension.Draggable(ulkeler_level1_fransa, true);
            ControlExtension.Draggable(ulkeler_level1_polonya, true);
            ControlExtension.Draggable(ulkeler_level1_almanya, true);
            ControlExtension.Draggable(ulkeler_level1_japonya, true);
            ControlExtension.Draggable(ulkeler_level1_ingiltere, true);
            ControlExtension.Draggable(ulkeler_level1_italya, true);
            ControlExtension.Draggable(ulkeler_level1_portekiz, true);
            ControlExtension.Draggable(ulkeler_level1_cin, true);

            level1_one1_baslangic = new Point(level1_one1.Left, level1_one1.Top);
            level1_two1_baslangic = new Point(level1_two1.Left, level1_two1.Top);
            level1_three1_baslangic = new Point(level1_three1.Left, level1_three1.Top);
            level1_four1_baslangic = new Point(level1_four1.Left, level1_four1.Top);
            level1_five1_baslangic = new Point(level1_five1.Left, level1_five1.Top);
            level1_six1_baslangic = new Point(level1_six1.Left, level1_six1.Top);                        
            level1_seven1_baslangic = new Point(level1_seven1.Left, level1_seven1.Top);
            level1_eight1_baslangic = new Point(level1_eight1.Left, level1_eight1.Top);
            level1_nine1_baslangic = new Point(level1_nine1.Left, level1_nine1.Top);
            level1_ten1_baslangic = new Point(level1_ten1.Left, level1_ten1.Top);

            ok_ust = new Point(401, 478);
            ok_alt1 = new Point(401, 527);
            ok_alt2 = new Point(401, 582);
            ok_alt3 = new Point(401, 628);
            ok_sol = new Point(126, 18);
            ok_sag1 = new Point(401, 136);
            ok_sag2 = new Point(685, 136);
            ok_sag3 = new Point(963, 12);
            ok_orta = new Point(545, 135);

            turkiye_baslangic = new Point (ulkeler_level1_turkiye.Left, ulkeler_level1_turkiye.Top);
            ispanya_baslangic = new Point(ulkeler_level1_ispanya.Left, ulkeler_level1_ispanya.Top);
            fransa_baslangic = new Point(ulkeler_level1_fransa.Left, ulkeler_level1_fransa.Top);
            polonya_baslangic = new Point(ulkeler_level1_polonya.Left, ulkeler_level1_polonya.Top);
            almanya_baslangic = new Point(ulkeler_level1_almanya.Left, ulkeler_level1_almanya.Top);
            japonya_baslangic = new Point(ulkeler_level1_japonya.Left, ulkeler_level1_japonya.Top);
            ingiltere_baslangic = new Point(ulkeler_level1_ingiltere.Left, ulkeler_level1_ingiltere.Top);
            italya_baslangic = new Point(ulkeler_level1_italya.Left, ulkeler_level1_italya.Top);
            portekiz_baslangic = new Point(ulkeler_level1_portekiz.Left, ulkeler_level1_portekiz.Top);
            cin_baslangic = new Point(ulkeler_level1_cin.Left, ulkeler_level1_cin.Top);
            ulke_isimleri_baslangic = new Point(ulke_isimleri.Left, ulke_isimleri.Top);
            bayrak_koordinat = new Point(151, 298);
            ulkeler_level1_yazibaslangic = new Point(150, 418);
            renkler_level3_yazi_baslangic = new Point(483, 421);
        }

        private void start_butonu_Click(object sender, EventArgs e)
        {
            menu.Visible = Enabled;         
        }

        private void gorunurlugu_kapat3()
        {
            if (sayi1 == 1)
            {
                siyah_renk3.Visible = false;
            }
            else if (sayi1 == 2)
            {
                mavi_renk3.Visible = false;
            }
            else if (sayi1 == 3)
            {
                kahverengi_renk3.Visible = false;
            }
            else if (sayi1 == 4)
            {
                pembe_renk3.Visible = false;
            }
            else if (sayi1 == 5)
            {
                beyaz_renk3.Visible = false;
            }
            else if (sayi1 == 6)
            {
                kirmizi_renk3.Visible = false;
            }
            else if (sayi1 == 7)
            {
                mor_renk3.Visible = false;
            }
            else if (sayi1 == 8)
            {
                turuncu_renk3.Visible = false;
            }
            else if (sayi1 == 9)
            {
                yesil_renk3.Visible = false;
            }
            else if (sayi1 == 10)
            {
                sari_renk3.Visible = false;
            }
        }

        private void body_bonus_rastgele()
        {
            for (int i = 0; i < 4; i++)
            {
                body_bonus_cevaplar[i].BackColor = Color.Yellow;
            }
            if (body_bonus.Count == body_bonus_sayac)
            {
                body_bonuspanel.Visible = false;
            }
            else
            {
                body_bonus[body_bonus_karisik_rakamlar[body_bonus_sayac]].Visible = true;
                body_karisik = body_ingilizce.OrderBy(x => Guid.NewGuid()).ToList();
                body_bonus_cevaplar_karisik = body_bonus_cevaplar.OrderBy(x => Guid.NewGuid()).ToList();
                body_bonus_cevaplar_karisik[0].Text = body_ingilizce_bonus[body_bonus_karisik_rakamlar[body_bonus_sayac]];
                body_bonus_cevaplar_karisik[1].Text = body_karisik[0];
                body_bonus_cevaplar_karisik[2].Text = body_karisik[1];
                body_bonus_cevaplar_karisik[3].Text = body_karisik[2];                
            }
            body_bonus_sayac++;        
        }
        private void meyveler_bonus_rastgele()
        {
            for(int i = 0; i < 4; i++)
            {
                meyveler_bonus_cevaplar[i].BackColor = Color.White;
            }
            if(meyveler_bonus.Count == meyveler_bonus_sayac)
            {
                meyveler_bonuspanel.Visible = false;
            }
            else
            {
                meyveler_bonus[meyveler_bonus_karisik_rakamlar[meyveler_bonus_sayac]].Visible = true;
                meyveler_karisik = meyve_isimleri_ingilizce.OrderBy(x => Guid.NewGuid()).ToList();
                meyveler_bonus_cevaplar_karisik = meyveler_bonus_cevaplar.OrderBy(x => Guid.NewGuid()).ToList();
                meyveler_bonus_cevaplar_karisik[0].Text = meyveler_ingilizce_bonus[meyveler_bonus_karisik_rakamlar[meyveler_bonus_sayac]];
                meyveler_bonus_cevaplar_karisik[1].Text = meyveler_karisik[0];
                meyveler_bonus_cevaplar_karisik[2].Text = meyveler_karisik[1];
                meyveler_bonus_cevaplar_karisik[3].Text = meyveler_karisik[2];
            }
            meyveler_bonus_sayac++;
        }
        private void ulkeler_bonus_rastgele()
        {
            for (int i = 0; i < 4; i++)
            {
                ulkeler_bonus_cevaplar[i].BackColor = Color.Yellow;
            }
            if(ulkeler_bonus.Count == ulkeler_bonus_sayac)
            {
                ulkeler_bonuspanel.Visible = false;
            }
            else
            {
                ulkeler_bonus[ulkeler_bonus_karisik_rakamlar[ulkeler_bonus_sayac]].Visible = true;
                ulkeler_bonus_cevaplar_karisik = ulkeler_bonus_cevaplar.OrderBy(x => Guid.NewGuid()).ToList();
                if (abd.Visible == true)
                {
                    ulkeler_bonus_cevaplar_karisik[0].Font = new Font(ulkeler_bonus_cevaplar_karisik[0].Font.FontFamily, 13);
                }
                ulkeler_bonus_cevaplar_karisik[0].Text = ulkeler_ingilizce_bonus[ulkeler_bonus_karisik_rakamlar[ulkeler_bonus_sayac]];
                ulkeler_karisik = ulkeler_ingilizce.OrderBy(x => Guid.NewGuid()).ToList();
                ulkeler_bonus_cevaplar_karisik[1].Text = ulkeler_karisik[0];
                ulkeler_bonus_cevaplar_karisik[2].Text = ulkeler_karisik[1];
                ulkeler_bonus_cevaplar_karisik[3].Text = ulkeler_karisik[2];
            }
            ulkeler_bonus_sayac++;
        }
        private void sayilar_bonus_rastgele()
        {
            for (int i = 0; i < 4; i++)
            {
                sayilar_bonus_cevaplar[i].BackColor = Color.White;
            }
            if (sayilar_bonus.Count == sayilar_bonus_sayac)
            {
                sayilar_bonuspanel.Visible = false;
            }
            else
            {
                sayilar_bonus[sayilar_bonus_karisik_rakamlar[sayilar_bonus_sayac]].Visible = true;
                sayilar_bonus_cevaplar_karisik = sayilar_bonus_cevaplar.OrderBy(x => Guid.NewGuid()).ToList();
                sayilar_karisik = sayilar_ingilizce.OrderBy(x => Guid.NewGuid()).ToList();
                sayilar_bonus_cevaplar_karisik[0].Text = sayilar_ingilizce_bonus[sayilar_bonus_karisik_rakamlar[sayilar_bonus_sayac]];
                sayilar_bonus_cevaplar_karisik[1].Text = sayilar_karisik[0];
                sayilar_bonus_cevaplar_karisik[2].Text = sayilar_karisik[1];
                sayilar_bonus_cevaplar_karisik[3].Text = sayilar_karisik[2];
            }
            sayilar_bonus_sayac++;
        }
        private void hayvanlar_bonus_rastgele()
        {
            for (int i = 0; i < 4; i++)
            {
                hayvanlar_bonus_cevaplar[i].BackColor = Color.White;
            }
            if (hayvanlar_bonus.Count == hayvanlar_bonus_sayac)
            {
                hayvanlar_bonuspanel.Visible = false;
                return;
            }
            else
            {
                hayvanlar_bonus[hayvanlar_bonus_karisik_rakamlar[hayvanlar_bonus_sayac]].Visible = true;
                hayvanlar_bonus_cevaplar_karisik = hayvanlar_bonus_cevaplar.OrderBy(x => Guid.NewGuid()).ToList();
                hayvanlar_karisik = hayvanlar_ingilizce.OrderBy(x => Guid.NewGuid()).ToList();
                hayvanlar_bonus_cevaplar_karisik[0].Text = hayvanlar_ingilizce_bonus[hayvanlar_bonus_karisik_rakamlar[hayvanlar_bonus_sayac]];
                hayvanlar_bonus_cevaplar_karisik[1].Text = hayvanlar_karisik[0];
                hayvanlar_bonus_cevaplar_karisik[2].Text = hayvanlar_karisik[1];
                hayvanlar_bonus_cevaplar_karisik[3].Text = hayvanlar_karisik[2];
            }
            hayvanlar_bonus_sayac++;
        }


        private void hayvanlar_level2_rastgele()
        {
            hayvanlar_level2_cevap1.BackColor = System.Drawing.Color.Gold;
            hayvanlar_level2_cevap2.BackColor = System.Drawing.Color.Gold;
            if (hayvanlar_level2_rastgele_rakamlar.Count == hayvanlar_level2_sayac)
            {
                hayvanlar_level2_timer.Stop();
                hayvanlar_level2_passed.Visible = true;                
            }
            else
            {
                level2_hayvanlar[hayvanlar_level2_rastgele_rakamlar[hayvanlar_level2_sayac]].Visible = true;
                hayvanlar_level2_rastgele_butonlar = hayvanlar_level2_butonlar.OrderBy(x => Guid.NewGuid()).ToList();
                hayvanlar_level2_rastgele_butonlar[0].Text = hayvanlar_ingilizce[hayvanlar_level2_rastgele_rakamlar[hayvanlar_level2_sayac]];
                while (true)
                {
                    int rastgele_cevap = rastgele.Next(0, 10);
                    if(rastgele_cevap != hayvanlar_level2_rastgele_rakamlar[hayvanlar_level2_sayac])
                    {
                        hayvanlar_level2_rastgele_butonlar[1].Text = hayvanlar_ingilizce[rastgele_cevap];
                        break;
                    }
                }
            }
            hayvanlar_level2_sayac++;
        }
        private void hayvanlar_level3_rastgele()
        {
            hayvanlar_level3_karisik_rakamlar2 = hayvanlar_level3_rakamlar2.OrderBy(x => Guid.NewGuid()).ToList();
            for (int i = 0; i < 5; i++)
            {
                hayvanlar_level3_resimler[hayvanlar_level3_karisik_rakamlar[i + kontrol2]].Visible = true;
                hayvanlar_level3_resimler[hayvanlar_level3_karisik_rakamlar[i + kontrol2]].Location = hayvanlar_level3_resim_yerleri[hayvanlar_level3_karisik_rakamlar2[i]];
            }
            hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac]].Visible = true;
            hayvanlar_level3_sayac++;
            kontrol2 += 5;
        }
        private void meyveler_level3_rastgele()
        {                       
            if (meyveler_level3_karisik_rakamlar.Count == meyveler_level3_sayac)
            {
                meyveler_level3_passed.Visible = true;
                return;
            }
            List<int> meyveler_level3_rakamlar = new List<int>(new int[] { meyveler_level3_karisik_rakamlar[meyveler_level3_sayac], meyveler_level3_karisik_rakamlar[meyveler_level3_sayac + 1], meyveler_level3_karisik_rakamlar[meyveler_level3_sayac + 2] });
            meyveler_level3_karisik_rakamlar2 = meyveler_level3_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            for (int i = 0; i<3; i++)
            {
                meyveler_level3_resimpicturebox[i].Image = meyve_resimleri.Images[meyveler_level3_karisik_rakamlar[meyveler_level3_sayac]];
                meyveler_level3_yazipicturebox[i].Image = meyve_isimleri.Images[meyveler_level3_karisik_rakamlar2[i]];
                meyveler_level3_sayac++;
            }            
        }
        private void meyveler_level2_rastgele()
        {
            if (meyveler_level2_resimler.Count == meyveler_level2_sayac)
            {
                meyveler_level2_timer.Stop();
                meyveler_level2_passed.Visible = true;
            }
            else
            {
                meyveler_level2_cevap1.BackColor = Color.Yellow;
                meyveler_level2_cevap2.BackColor = Color.Yellow;
                meyveler_level2_resimler[meyveler_level2_rastgele_rakamlar[meyveler_level2_sayac]].Visible = true;
                int cevap_yeri = rastgele.Next(0, 2);
                if (cevap_yeri == 0)
                {
                    meyveler_level2_cevap1.Text = meyve_isimleri_ingilizce[meyveler_level2_rastgele_rakamlar[meyveler_level2_sayac]];
                    while (true)
                    {
                        int rastgele_cevap = rastgele.Next(0, 9);
                        if (rastgele_cevap != meyveler_level2_rastgele_rakamlar[meyveler_level2_sayac])
                        {
                            meyveler_level2_cevap2.Text = meyve_isimleri_ingilizce[rastgele_cevap];
                            break;
                        }                        
                    }
                }

                else
                {
                    meyveler_level2_cevap2.Text = meyve_isimleri_ingilizce[meyveler_level2_rastgele_rakamlar[meyveler_level2_sayac]];
                    while (true)
                    {
                        int rastgele_cevap = rastgele.Next(0, 9);
                        if (rastgele_cevap != meyveler_level2_rastgele_rakamlar[meyveler_level2_sayac])
                        {
                            meyveler_level2_cevap1.Text = meyve_isimleri_ingilizce[rastgele_cevap];
                            break;
                        }                        
                    }
                }
            }
            meyveler_level2_sayac++;
        }
        private void body_level3_rastgele()
        {
            if (body_level3_resimler.Count == body_level3_sayac)
            {
                bodyparts_level3_timer.Stop();
                bodyparts_level3_passed.Visible = true;
            }

            else
            {
                int dogru_yanlis = rastgele.Next(0, 2);
                body_level3_resimler[body_level3_karisik_rakamlar[body_level3_sayac]].Visible = true;
                if (dogru_yanlis == 1)
                {
                    body_level3_labellar[body_level3_karisik_rakamlar[body_level3_sayac]].Visible = true;
                }
                else
                {
                    while (true)
                    {
                        body_level3_rastgele_sayi = rastgele.Next(0, 12);
                        if (body_level3_rastgele_sayi != body_level3_karisik_rakamlar[body_level3_sayac])
                        {
                            body_level3_labellar[body_level3_rastgele_sayi].Visible = true;
                            break;
                        }
                    }
                }
            }
            body_level3_sayac++;

        }
        private void ulkeler_level3_rastgele()
        {
            ulkeler_level3_cevap1.BackColor = System.Drawing.Color.Transparent;
            ulkeler_level3_cevap2.BackColor = System.Drawing.Color.Transparent;
            ulkeler_level3_cevap3.BackColor = System.Drawing.Color.Transparent;
            ulkeler_level3_cevap4.BackColor = System.Drawing.Color.Transparent;
            if (level3_ulkeler.Count == ulkeler_level3_sayac)
            {
                ulkeler_level3_timer.Stop();
                ulkeler_level3_passed.Visible = true;
            }
            else
            {
                int j = 0;
                level3_ulkeler[ulkeler_level3_karisik_rakamlar[ulkeler_level3_sayac]].Visible = true;
                ulkeler_level3_karisik_butonlar = ulkeler_level3_butonlar.OrderBy(x => Guid.NewGuid()).ToList();
                for (int i = 0; i < 4; i++)
                {                    
                   ulkeler_level3_karisik_butonlar[i].Text = ulkeler_level3_cevaplar[ulkeler_level3_karisik_rakamlar[ulkeler_level3_sayac],j];
                    
                   j++;
                }
            }
            ulkeler_level3_sayac++;
        }
        private void ulkeler_level2_rastgele()
        {
            if(level2_ulkeler.Count == ulkeler_level2_sayac)
            {
                ulkeler_level2_timer.Stop();
                ulkeler_level2_passed.Visible = true;
            }
            else
            {
                level2_ulkeler[ulkeler_level2_karisik1[ulkeler_level2_sayac]].Visible = true;                            
                for (int i = 0; i < 10; i++)
                {
                    ulkeler_level2_butonlar[i].Text = ulkeler_ingilizce[ulkeler_level2_karisik2[i]];
                    ulkeler_level2_butonlar[i].BackColor = Color.FromArgb(255, 255, 128);
                }
            }
            ulkeler_level2_sayac++;
        }
        private void sayilar_level3_rastgele()
        {
            if (sayilar_level3_rastgele_rakamlar.Count == sayilar_level3_sayac)
            {
                sayilar_level3_timer.Stop();
                sayilar_level3_passed.Visible = true;
            }
            else
            {
                sayilar_level3[sayilar_level3_rastgele_rakamlar[sayilar_level3_sayac]].Visible = true;
                sayilar_level3_rastgele_butonlar = sayilar_level3_butonlar.OrderBy(x => Guid.NewGuid()).ToList();
                sayilar_level3_rastgele_butonlar[0].Text = sayilar_ingilizce[sayilar_level3_rastgele_rakamlar[sayilar_level3_sayac]];

                while (true)
                {
                    sayilar_level3_rastgele_rakamlar2 = sayilar_level3_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
                    if(sayilar_level3_rastgele_rakamlar2[0] != sayilar_level3_rastgele_rakamlar[sayilar_level3_sayac] && sayilar_level3_rastgele_rakamlar2[1] != sayilar_level3_rastgele_rakamlar[sayilar_level3_sayac] && sayilar_level3_rastgele_rakamlar2[2] != sayilar_level3_rastgele_rakamlar[sayilar_level3_sayac])
                    {
                        sayilar_level3_rastgele_butonlar[1].Text = sayilar_ingilizce[sayilar_level3_rastgele_rakamlar2[0]];
                        sayilar_level3_rastgele_butonlar[2].Text = sayilar_ingilizce[sayilar_level3_rastgele_rakamlar2[1]];
                        sayilar_level3_rastgele_butonlar[3].Text = sayilar_ingilizce[sayilar_level3_rastgele_rakamlar2[2]];
                        break;
                    }
                }                          
            }
            sayilar_level3_sayac++;
        }                   
        private void sayilar_level2_bolumler()
        {
            int altust = rastgele.Next(0, 2);
            if(sayilar_level2_sayac == rastgele_rakamlar_sayilar_level2.Count())
            {
                sayilar_level2_timer.Stop();
                sayilar_level2_passed.Visible = true;
            }
            else
            {
                sayilar_level2[rastgele_rakamlar_sayilar_level2[sayilar_level2_sayac]].Visible = true;
                while (true)
                {
                    if (rastgele_rakamlar_sayilar_level2[sayilar_level2_sayac] > 10)
                    {
                        sayilar_level2_rastgele_cevap = rastgele.Next(0, 10);
                    }
                    else
                    {
                        sayilar_level2_rastgele_cevap = rastgele.Next(0, 19);
                    }

                    if (sayilar_level2_rastgele_cevap != rastgele_rakamlar_sayilar_level2[sayilar_level2_sayac])
                    {
                        if(altust == 0)
                        {
                            alt_buton.Text = sayilar_ingilizce[rastgele_rakamlar_sayilar_level2[sayilar_level2_sayac]];
                            ust_buton.Text = sayilar_ingilizce[sayilar_level2_rastgele_cevap];
                        }
                        else
                        {
                            ust_buton.Text = sayilar_ingilizce[rastgele_rakamlar_sayilar_level2[sayilar_level2_sayac]];
                            alt_buton.Text = sayilar_ingilizce[sayilar_level2_rastgele_cevap];                            
                        }
                        break;                    
                    }                    
                }
            }
            sayilar_level2_sayac++;
        }

        private void rastgele_renk_level2()
        {
            cevap_sag.BackColor = System.Drawing.Color.Yellow;
            cevap_sol.BackColor = System.Drawing.Color.Yellow;
            int sag_sol = rastgele.Next(0, 2);
            
            if (renkler_level3_rastgele_rakamlar.Count() == renkler_level2_sayac)
            {
                renkler_level2_timer.Stop();
                renkler_level2_passed.Visible = true;
            }
            else
            {
                renkler_level2_nesneler[renkler_level3_rastgele_rakamlar[renkler_level2_sayac]].Visible = true;
                
                while (true)
                {
                    int rastgele_cevap = rastgele.Next(0, 10);
                    if (rastgele_cevap != renkler_level3_rastgele_rakamlar[renkler_level2_sayac])
                    {
                        if (sag_sol == 0)
                        {
                            cevap_sol.Text = renk_isimleri[renkler_level3_rastgele_rakamlar[renkler_level2_sayac]];
                            cevap_sag.Text = renk_isimleri[rastgele_cevap];
                            break;
                        }
                        else
                        {
                            cevap_sag.Text = renk_isimleri[renkler_level3_rastgele_rakamlar[renkler_level2_sayac]];
                            cevap_sol.Text = renk_isimleri[rastgele_cevap];
                            break;
                        }
                    }
                }
                renkler_level2_sayac++;
            }
        }
        private void rastgele_yazi_renk3(int sayi2)
        {            
                if (sayi2 == 1)               
                {
                    renkler_level3_yazi.ForeColor = System.Drawing.Color.Black;                   
                }
                else if (sayi2 == 2)
                {
                    renkler_level3_yazi.ForeColor = System.Drawing.Color.Blue;                   
                }
                else if (sayi2 == 3)
                {
                    renkler_level3_yazi.ForeColor = System.Drawing.Color.Brown;               
                }
                else if (sayi2 == 4)
                {
                    renkler_level3_yazi.ForeColor = System.Drawing.Color.FromArgb(255, 128, 255);           
                }
                else if (sayi2 == 5)
                {
                    renkler_level3_yazi.ForeColor = System.Drawing.Color.White;
                }
                else if (sayi2 == 6)
                {
                    renkler_level3_yazi.ForeColor = System.Drawing.Color.Red;
                }
                else if (sayi2 == 7)
                {
                    renkler_level3_yazi.ForeColor = System.Drawing.Color.Purple;
                }
                else if (sayi2 == 8)
                {
                    renkler_level3_yazi.ForeColor = System.Drawing.Color.Orange;
                }
                else if (sayi2 == 9)
                {
                    renkler_level3_yazi.ForeColor = System.Drawing.Color.Green;
                }
                else if (sayi2 == 10)
                {
                    renkler_level3_yazi.ForeColor = System.Drawing.Color.Yellow;
                }
            
        }
        private void rastgele_renkyazi()
        {
            while (true)
            {
                if (renkler_level3_kontrol.Count == 10)
                {
                    renkler_level3_timer.Stop();
                    renkler_level3_passed.Visible = true;
                    break;
                }
                sayi1 = rastgele.Next(1, 11);
                int sayi2 = rastgele.Next(1, 11);
                int sayi3 = rastgele.Next(0, 10);
                dogru_yanlis = rastgele.Next(0, 2);

                if (renkler_level3_kontrol.Contains(sayi1) == false)
                {
                    if (sayi1 == 1)
                    {
                        siyah_renk3.Visible = true;

                        if (dogru_yanlis == 1)
                        {
                            renkler_level3_yazi.Text = renk_isimleri[0];
                            rastgele_yazi_renk3(sayi2);
                        }
                        else
                        {
                            renkler_level3_yazi.Text = renk_isimleri[sayi3];
                            if (sayi3 == 0)
                            {
                                dogru_yanlis = 1;
                            }
                            rastgele_yazi_renk3(sayi2);
                        }
                    }
                    if (sayi1 == 2)
                    {
                        mavi_renk3.Visible = true;

                        if (dogru_yanlis == 1)
                        {
                            renkler_level3_yazi.Text = renk_isimleri[1];
                            rastgele_yazi_renk3(sayi2);
                        }
                        else
                        {
                            renkler_level3_yazi.Text = renk_isimleri[sayi3];
                            if (sayi3 == 1)
                            {
                                dogru_yanlis = 1;
                            }
                            rastgele_yazi_renk3(sayi2);
                        }

                    }
                    if (sayi1 == 3)
                    {
                        kahverengi_renk3.Visible = true;

                        if (dogru_yanlis == 1)
                        {
                            renkler_level3_yazi.Text = renk_isimleri[2];
                            rastgele_yazi_renk3(sayi2);
                        }
                        else
                        {
                            renkler_level3_yazi.Text = renk_isimleri[sayi3];
                            if (sayi3 == 2)
                            {
                                dogru_yanlis = 1;

                            }
                            rastgele_yazi_renk3(sayi2);
                        }

                    }
                    if (sayi1 == 4)
                    {
                        pembe_renk3.Visible = true;

                        if (dogru_yanlis == 1)
                        {                           
                            renkler_level3_yazi.Text = renk_isimleri[3];
                            rastgele_yazi_renk3(sayi2);
                        }
                        else
                        {
                            renkler_level3_yazi.Text = renk_isimleri[sayi3];
                            if (sayi3 == 3)
                            {
                                dogru_yanlis = 1;
                            }
                            rastgele_yazi_renk3(sayi2);
                        }

                    }
                    if (sayi1 == 5)
                    {
                        beyaz_renk3.Visible = true;

                        if (dogru_yanlis == 1)
                        {
                            renkler_level3_yazi.Text = renk_isimleri[4];
                            rastgele_yazi_renk3(sayi2);
                        }
                        else
                        {                            
                            renkler_level3_yazi.Text = renk_isimleri[sayi3];
                            if (sayi3 == 4)
                            {
                                dogru_yanlis = 1;
                            }
                            rastgele_yazi_renk3(sayi2);
                        }

                    }
                    if (sayi1 == 6)
                    {
                        kirmizi_renk3.Visible = true;

                        if (dogru_yanlis == 1)
                        {                            
                            renkler_level3_yazi.Text = renk_isimleri[5];
                            rastgele_yazi_renk3(sayi2);
                        }
                        else
                        {                           
                            renkler_level3_yazi.Text = renk_isimleri[sayi3];
                            if (sayi3 == 5)
                            {
                                dogru_yanlis = 1;
                            }
                            rastgele_yazi_renk3(sayi2);
                        }

                    }
                    if (sayi1 == 7)
                    {
                        mor_renk3.Visible = true;

                        if (dogru_yanlis == 1)
                        {                           
                            renkler_level3_yazi.Text = renk_isimleri[6];
                            rastgele_yazi_renk3(sayi2);
                        }
                        else
                        {
                            renkler_level3_yazi.Text = renk_isimleri[sayi3];
                            if (sayi3 == 6)
                            {
                                dogru_yanlis = 1;
                            }
                            rastgele_yazi_renk3(sayi2);
                        }

                    }
                    if (sayi1 == 8)
                    {
                        turuncu_renk3.Visible = true;

                        if (dogru_yanlis == 1)
                        {
                            renkler_level3_yazi.Text = renk_isimleri[7];
                            rastgele_yazi_renk3(sayi2);
                        }
                        else
                        {
                            renkler_level3_yazi.Text = renk_isimleri[sayi3];
                            if (sayi3 == 7)
                            {
                                dogru_yanlis = 1;
                            }
                            rastgele_yazi_renk3(sayi2);
                        }

                    }
                    if (sayi1 == 9)
                    {
                        yesil_renk3.Visible = true;

                        if (dogru_yanlis == 1)
                        {
                            renkler_level3_yazi.Text = renk_isimleri[8];
                            rastgele_yazi_renk3(sayi2);
                        }
                        else
                        {
                            renkler_level3_yazi.Text = renk_isimleri[sayi3];
                            if (sayi3 == 8)
                            {
                                dogru_yanlis = 1;
                            }
                            rastgele_yazi_renk3(sayi2);
                        }

                    }
                    if (sayi1 == 10)
                    {
                        sari_renk3.Visible = true;


                        if (dogru_yanlis == 1)
                        {
                            renkler_level3_yazi.Text = renk_isimleri[9];
                            rastgele_yazi_renk3(sayi2);
                        }
                        else
                        {
                            renkler_level3_yazi.Text = renk_isimleri[sayi3];
                            if (sayi3 == 9)
                            {
                                dogru_yanlis = 1;
                            }
                            rastgele_yazi_renk3(sayi2);
                        }
                    }
                    renkler_level3_kontrol.Add(sayi1);
                    break;
                }               
            }
        }
        private void rastgele_renk()
        {
            while (true)
            {
                int sayi = rastgele.Next(1, 11);
                if (sayi == 1 && siyah_buton.Visible == true)
                {
                    siyah_yazi.Visible = true;
                    break;
                }
                else if (sayi == 2 && mavi_buton.Visible == true)
                {
                    mavi_yazi.Visible = true;
                    break;
                }
                else if (sayi == 3 && kahverengi_buton.Visible == true)
                {
                    kahverengi_yazi.Visible = true;
                    break;
                }
                else if (sayi == 4 && pembe_buton.Visible == true)
                {
                    pembe_yazi.Visible = true;
                    break;

                }
                else if (sayi == 5 && beyaz_buton.Visible == true)
                {
                    beyaz_yazi.Visible = true;
                    break;
                }
                else if (sayi == 6 && kirmizi_buton.Visible == true)
                {
                    kirmizi_yazi.Visible = true;
                    break;
                }
                else if (sayi == 7 && mor_buton.Visible == true)
                {
                    mor_yazi.Visible = true;
                    break;
                }
                else if (sayi == 8 && turuncu_buton.Visible == true)
                {
                    turuncu_yazi.Visible = true;
                    break;
                }
                else if (sayi == 9 && yesil_buton.Visible == true)
                {
                    yesil_yazi.Visible = true;
                    break;
                }
                else if (sayi == 10 && sari_buton.Visible == true)
                {
                    sari_yazi.Visible = true;
                    break;
                }
                if (siyah_buton.Visible == false && mavi_buton.Visible == false && kahverengi_buton.Visible == false && pembe_buton.Visible == false && beyaz_buton.Visible == false && kirmizi_buton.Visible == false && mor_buton.Visible == false && turuncu_buton.Visible == false && yesil_buton.Visible == false && sari_buton.Visible == false)
                {                    
                    renkler_level1_panel.Visible = false;
                    break;
                }
            }
        }
        private void renkler_Click(object sender, EventArgs e)
        {
            renkler_panel.Visible = true;

        }
        private void renkler1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void siyah_buton_Click(object sender, EventArgs e)
        {
            if (siyah_yazi.Visible == true)
            {
                ses.URL = "black.mp3";
                siyah_buton.Visible = false;
                siyah_yazi.Visible = false;
                rastgele_renk();                
            }

        }
        private void mavi_buton_Click(object sender, EventArgs e)
        {
            if (mavi_yazi.Visible == true)
            {
                ses.URL = "blue.mp3";
                mavi_buton.Visible = false;
                mavi_yazi.Visible = false;
                rastgele_renk();
            }
        }

        private void kahverengi_buton_Click(object sender, EventArgs e)
        {
            if (kahverengi_yazi.Visible == true)
            {
                ses.URL = "brown.mp3";
                kahverengi_buton.Visible = false;
                kahverengi_yazi.Visible = false;
                rastgele_renk();
            }
        }

        private void pembe_buton_Click(object sender, EventArgs e)
        {
            if (pembe_yazi.Visible == true)
            {
                ses.URL = "pink.mp3";
                pembe_buton.Visible = false;
                pembe_yazi.Visible = false;
                rastgele_renk();
            }
        }

        private void beyaz_buton_Click(object sender, EventArgs e)
        {
            if (beyaz_yazi.Visible == true)
            {
                ses.URL = "white.mp3";
                beyaz_buton.Visible = false;
                beyaz_yazi.Visible = false;
                rastgele_renk();
            }
        }

        private void kirmizi_buton_Click(object sender, EventArgs e)
        {
            if (kirmizi_yazi.Visible == true)
            {
                ses.URL = "red.mp3";
                kirmizi_buton.Visible = false;
                kirmizi_yazi.Visible = false;
                rastgele_renk();
            }
        }
        private void mor_buton_Click(object sender, EventArgs e)
        {
            if (mor_yazi.Visible == true)
            {
                ses.URL = "purple.mp3";
                mor_buton.Visible = false;
                mor_yazi.Visible = false;
                rastgele_renk();
            }
        }

        private void turuncu_buton_Click(object sender, EventArgs e)
        {
            if (turuncu_yazi.Visible == true)
            {
                ses.URL = "orange.mp3";
                turuncu_buton.Visible = false;
                turuncu_yazi.Visible = false;
                rastgele_renk();
            }
        }

        private void yesil_buton_Click(object sender, EventArgs e)
        {
            if (yesil_yazi.Visible == true)
            {
                ses.URL = "green.mp3";
                yesil_buton.Visible = false;
                yesil_yazi.Visible = false;
                rastgele_renk();
            }
        }
        private void sari_buton_Click(object sender, EventArgs e)
        {
            if (sari_yazi.Visible == true)
            {
                ses.URL = "yellow.mp3";
                sari_buton.Visible = false;
                sari_yazi.Visible = false;
                rastgele_renk();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            renkler_level3_timer.Stop();
            if (dogru_yanlis == 1)
            {
                if (renkler_level3_yazi.Text == "BLACK")
                {
                    ses.URL = "black.mp3";
                }
                else if (renkler_level3_yazi.Text == "BLUE")
                {
                    ses.URL = "blue.mp3";
                }
                else if (renkler_level3_yazi.Text == "BROWN")
                {
                    ses.URL = "brown.mp3";
                }
                else if (renkler_level3_yazi.Text == "PINK")
                {
                    ses.URL = "pink.mp3";
                }
                else if (renkler_level3_yazi.Text == "WHITE")
                {
                    ses.URL = "white.mp3";
                }
                else if (renkler_level3_yazi.Text == "RED")
                {
                    ses.URL = "red.mp3";
                }
                else if (renkler_level3_yazi.Text == "PURPLE")
                {
                    ses.URL = "purple.mp3";
                }
                else if (renkler_level3_yazi.Text == "ORANGE")
                {
                    ses.URL = "orange.mp3";
                }
                else if (renkler_level3_yazi.Text == "GREEN")
                {
                    ses.URL = "green.mp3";
                }
                else if (renkler_level3_yazi.Text == "YELLOW")
                {
                    ses.URL = "yellow.mp3";
                }
                gorunurlugu_kapat3();
                zaman = 5;
                renkler_level3_sure.Text = "5";
                renkler_level3_timer.Start();
                rastgele_renkyazi();
            }
            else
            {
                renkler_level3_timer.Stop();
                renkler_level3_over.Visible = true;
            }

        }
        private void renkler_level3_carpi_Click(object sender, EventArgs e)
        {
            renkler_level3_timer.Stop();
            if (dogru_yanlis == 0)
            {
                gorunurlugu_kapat3();
                zaman = 5;
                renkler_level3_sure.Text = "5";
                renkler_level3_timer.Start();
                rastgele_renkyazi();
            }
            else
            {
                renkler_level3_timer.Stop();
                renkler_level3_over.Visible = true;
            }
        }

        private void cevap_sol_Click(object sender, EventArgs e)
        {           
            if (cevap_sol.Text == renk_isimleri[renkler_level3_rastgele_rakamlar[renkler_level2_sayac - 1]])
            {
                if (renkler_level2_nesneler[0].Visible == true)
                {
                    ses.URL = "black.mp3";
                }
                else if (renkler_level2_nesneler[1].Visible == true)
                {
                    ses.URL = "blue.mp3";
                }
                else if (renkler_level2_nesneler[2].Visible == true)
                {
                    ses.URL = "brown.mp3";
                }
                else if (renkler_level2_nesneler[3].Visible == true)
                {
                    ses.URL = "pink.mp3";
                }
                else if (renkler_level2_nesneler[4].Visible == true)
                {
                    ses.URL = "white.mp3";
                }
                else if (renkler_level2_nesneler[5].Visible == true)
                {
                    ses.URL = "red.mp3";
                }
                else if (renkler_level2_nesneler[6].Visible == true)
                {
                    ses.URL = "purple.mp3";
                }
                else if (renkler_level2_nesneler[7].Visible == true)
                {
                    ses.URL = "orange.mp3";
                }
                else if (renkler_level2_nesneler[8].Visible == true)
                {
                    ses.URL = "green.mp3";
                }
                else if (renkler_level2_nesneler[9].Visible == true)
                {
                    ses.URL = "yellow.mp3";
                }
                renkler_level2_nesneler[renkler_level3_rastgele_rakamlar[renkler_level2_sayac - 1]].Visible = false;                   
                rastgele_renk_level2();
            }
            else
            {
                cevap_sol.BackColor = Color.Red;
                can -= 1;
                if (can != -1)
                {
                    renkler_level2_can.Text = Convert.ToString(can);
                }
                else
                {
                    renkler_level2_timer.Stop();
                    renkler_level2_over.Visible = true;
                }
            }
        }
        private void cevap_sag_Click(object sender, EventArgs e)
        {            
            if (cevap_sag.Text == renk_isimleri[renkler_level3_rastgele_rakamlar[renkler_level2_sayac - 1]])
            {
                if (renkler_level2_nesneler[0].Visible == true)
                {
                    ses.URL = "black.mp3";
                }
                else if (renkler_level2_nesneler[1].Visible == true)
                {
                    ses.URL = "blue.mp3";
                }
                else if (renkler_level2_nesneler[2].Visible == true)
                {
                    ses.URL = "brown.mp3";
                }
                else if (renkler_level2_nesneler[3].Visible == true)
                {
                    ses.URL = "pink.mp3";
                }
                else if (renkler_level2_nesneler[4].Visible == true)
                {
                    ses.URL = "white.mp3";
                }
                else if (renkler_level2_nesneler[5].Visible == true)
                {
                    ses.URL = "red.mp3";
                }
                else if (renkler_level2_nesneler[6].Visible == true)
                {
                    ses.URL = "purple.mp3";
                }
                else if (renkler_level2_nesneler[7].Visible == true)
                {
                    ses.URL = "orange.mp3";
                }
                else if (renkler_level2_nesneler[8].Visible == true)
                {
                    ses.URL = "green.mp3";
                }
                else if (renkler_level2_nesneler[9].Visible == true)
                {
                    ses.URL = "yellow.mp3";
                }
                renkler_level2_nesneler[renkler_level3_rastgele_rakamlar[renkler_level2_sayac - 1]].Visible = false;
                rastgele_renk_level2();
            }
            else
            {
                cevap_sag.BackColor = Color.Red;
                can -= 1;
                if (can != -1)
                {
                    renkler_level2_can.Text = Convert.ToString(can);
                }
                else
                {
                    renkler_level2_timer.Stop();
                    renkler_level2_over.Visible = true;
                }
            }
        }

        private void label6_MouseDown(object sender, MouseEventArgs e)
        {
            
            level1_one1.BackColor = System.Drawing.Color.LawnGreen;
            sol_ok.Visible = false;
            sag_ok.Visible = false;
            sol_ok1.Visible = true;
            sag_ok1.Visible = true;
        }

        private void label6_MouseUp(object sender, MouseEventArgs e)
        {
            for (int i = 410; i<680; i++)
            {
                for (int j = 200; j<390; j++)
                {
                    if (level1_one1.Left == i && level1_one1.Top == j)
                    {
                        level1_one2.Visible = true;
                        level1_one1.Text = "";
                        ses.URL = "bir.mp3";
                        sayilar_level1_panel.BackgroundImage = Properties.Resources.foto2;
                        sol_ok1.Visible = false;
                        sag_ok1.Visible = false;
                        sag_ok2.Visible = true;
                        sol_ok2.Visible = true;
                    }
                }
            }
            level1_one1.BackColor = System.Drawing.Color.Transparent;
            level1_one1.Location = level1_one1_baslangic;
            
        }

        private void sayilar_Click(object sender, EventArgs e)
        {
            sayilar_panel.Visible = true;
        }

        private void bayraklar_level1_ispanya_MouseUp(object sender, MouseEventArgs e)
        {
            for (int i = 21; i < 345; i++)
            {
                for (int j = 195; j < 390; j++)
                {
                    if (ulkeler_level1_ispanya.Left == i && ulkeler_level1_ispanya.Top == j)
                    {
                        ulkeler_level1_ispanya.Location = bayrak_koordinat;
                        ulke_isimleri.Visible = true;
                        ulke_isimleri.Left += 13;
                        ulke_isimleri.Text = ulkeler_ingilizce[1];
                        ses.URL = "spain.mp3";
                        ulkeler_level1_panel.BackgroundImage = Properties.Resources.sonDeneme;
                    }
                }
            }            
            if (ulkeler_level1_ispanya.Location != bayrak_koordinat)
            {
                ulkeler_level1_ispanya.Location = ispanya_baslangic;
            }
            else
            {
                ulkeler_level1_kontrol += 1;
                if (ulkeler_level1_kontrol == 10)
                {
                    ulkeler_level1_tik.Visible = true;
                    levels13.Visible = false;
                }
            }
        }

        private void bayraklar_level1_turkiye_MouseDown(object sender, MouseEventArgs e)
        {
            
            for(int i = 0; i<10; i++)
            {
                if(level1_ulkeler[i].Location == bayrak_koordinat)
                {
                    level1_ulkeler[i].Visible = false;
                    ulke_isimleri.Visible = false;
                }
            }
            ulke_isimleri.Location = ulke_isimleri_baslangic;
        }

        private void bayraklar_level1_ispanya_MouseDown(object sender, MouseEventArgs e)
        {
      
            for (int i = 0; i < 10; i++)
            {
                if (level1_ulkeler[i].Location == bayrak_koordinat)
                {
                    level1_ulkeler[i].Visible = false;
                    ulke_isimleri.Visible = false;
                }
            }
            ulke_isimleri.Location = ulke_isimleri_baslangic;
        }

        private void bayraklar_level1_fransa_MouseDown(object sender, MouseEventArgs e)
        {
       
            for (int i = 0; i < 10; i++)
            {
                if (level1_ulkeler[i].Location == bayrak_koordinat)
                {
                    level1_ulkeler[i].Visible = false;
                    ulke_isimleri.Visible = false;
                }
            }
            ulke_isimleri.Location = ulke_isimleri_baslangic;
        }

        private void bayraklar_level1_polonya_MouseDown(object sender, MouseEventArgs e)
        {
      
            for (int i = 0; i < 10; i++)
            {
                if (level1_ulkeler[i].Location == bayrak_koordinat)
                {
                    level1_ulkeler[i].Visible = false;
                    ulke_isimleri.Visible = false;
                }
            }
            ulke_isimleri.Location = ulke_isimleri_baslangic;
        }

        private void bayraklar_level1_almanya_MouseDown(object sender, MouseEventArgs e)
        {
       
            for (int i = 0; i < 10; i++)
            {
                if (level1_ulkeler[i].Location == bayrak_koordinat)
                {
                    level1_ulkeler[i].Visible = false;
                    ulke_isimleri.Visible = false;
                }
            }
            ulke_isimleri.Location = ulke_isimleri_baslangic;
        }

        private void bayraklar_level1_japonya_MouseDown(object sender, MouseEventArgs e)
        {
        
            for (int i = 0; i < 10; i++)
            {
                if (level1_ulkeler[i].Location == bayrak_koordinat)
                {
                    level1_ulkeler[i].Visible = false;
                    ulke_isimleri.Visible = false;
                }
            }
            ulke_isimleri.Location = ulke_isimleri_baslangic;
        }

        private void bayraklar_level1_ingiltere_MouseDown(object sender, MouseEventArgs e)
        {
         
            for (int i = 0; i < 10; i++)
            {
                if (level1_ulkeler[i].Location == bayrak_koordinat)
                {
                    level1_ulkeler[i].Visible = false;
                    ulke_isimleri.Visible = false;
                }
            }
            ulke_isimleri.Location = ulke_isimleri_baslangic;
        }

        private void bayraklar_level1_italya_MouseDown(object sender, MouseEventArgs e)
        {
      
            for (int i = 0; i < 10; i++)
            {
                if (level1_ulkeler[i].Location == bayrak_koordinat)
                {
                    level1_ulkeler[i].Visible = false;
                    ulke_isimleri.Visible = false;
                }
            }
            ulke_isimleri.Location = ulke_isimleri_baslangic;
        }

        private void bayraklar_level1_portekiz_MouseDown(object sender, MouseEventArgs e)
        {
            
            for (int i = 0; i < 10; i++)
            {
                if (level1_ulkeler[i].Location == bayrak_koordinat)
                {
                    level1_ulkeler[i].Visible = false;
                    ulke_isimleri.Visible = false;
                }
            }
            ulke_isimleri.Location = ulke_isimleri_baslangic;
        }

        private void bayraklar_level1_cin_MouseDown(object sender, MouseEventArgs e)
        {
          
            for (int i = 0; i < 10; i++)
            {
                if (level1_ulkeler[i].Location == bayrak_koordinat)
                {
                    level1_ulkeler[i].Visible = false;
                    ulke_isimleri.Visible = false;
                }
            }
            ulke_isimleri.Location = ulke_isimleri_baslangic;
        }

        private void bayraklar_level1_fransa_MouseUp(object sender, MouseEventArgs e)
        {
            for (int i = 21; i < 345; i++)
            {
                for (int j = 195; j < 390; j++)
                {
                    if (ulkeler_level1_fransa.Left == i && ulkeler_level1_fransa.Top == j)
                    {
                        ulkeler_level1_fransa.Location = bayrak_koordinat;
                        ulke_isimleri.Visible = true;
                        ulke_isimleri.Text = ulkeler_ingilizce[2];
                        ses.URL = "france.mp3";
                        ulkeler_level1_panel.BackgroundImage = Properties.Resources.sonDeneme;
                    }
                }
            }           
            if (ulkeler_level1_fransa.Location != bayrak_koordinat)
            {
                ulkeler_level1_fransa.Location = fransa_baslangic;
            }
            else
            {
                ulkeler_level1_kontrol += 1;
                if (ulkeler_level1_kontrol == 10)
                {
                    ulkeler_level1_tik.Visible = true;
                    levels13.Visible = false;
                }
            }
        }

        private void bayraklar_level1_polonya_MouseUp(object sender, MouseEventArgs e)
        {
            for (int i = 21; i < 345; i++)
            {
                for (int j = 195; j < 390; j++)
                {
                    if (ulkeler_level1_polonya.Left == i && ulkeler_level1_polonya.Top == j)
                    {
                        ulkeler_level1_polonya.Location = bayrak_koordinat;
                        ulke_isimleri.Visible = true;
                        ulke_isimleri.Text = ulkeler_ingilizce[3];
                        ses.URL = "poland.mp3";
                        ulkeler_level1_panel.BackgroundImage = Properties.Resources.sonDeneme;
                    }
                }
            }

            if(ulkeler_level1_polonya.Location!= bayrak_koordinat)
            {
                ulkeler_level1_polonya.Location = polonya_baslangic;
            }
            else
            {
                ulkeler_level1_kontrol += 1;
                if (ulkeler_level1_kontrol == 10)
                {
                    ulkeler_level1_tik.Visible = true;
                    levels13.Visible = false;
                }
            }
        }

        private void bayraklar_level1_almanya_MouseUp(object sender, MouseEventArgs e)
        {
            for (int i = 21; i < 345; i++)
            {
                for (int j = 195; j < 390; j++)
                {
                    if (ulkeler_level1_almanya.Left == i && ulkeler_level1_almanya.Top == j)
                    {
                        ulkeler_level1_almanya.Location = bayrak_koordinat;
                        ulke_isimleri.Visible = true;
                        ulke_isimleri.Left -= 13;
                        ulke_isimleri.Text = ulkeler_ingilizce[4];
                        ses.URL = "germany.mp3";
                        ulkeler_level1_panel.BackgroundImage = Properties.Resources.sonDeneme;
                    }
                }
            }
            if(ulkeler_level1_almanya.Location!= bayrak_koordinat)
            {
                ulkeler_level1_almanya.Location = almanya_baslangic;

            }
            else
            {
                ulkeler_level1_kontrol += 1;
                if (ulkeler_level1_kontrol == 10)
                {
                    ulkeler_level1_tik.Visible = true;
                    levels13.Visible = false;
                }
            }
        }

        private void bayraklar_level1_japonya_MouseUp(object sender, MouseEventArgs e)
        {
            for (int i = 21; i < 345; i++)
            {
                for (int j = 195; j < 390; j++)
                {
                    if (ulkeler_level1_japonya.Left == i && ulkeler_level1_japonya.Top == j)
                    {
                        ulkeler_level1_japonya.Location = bayrak_koordinat;
                        ulke_isimleri.Visible = true;
                        ulke_isimleri.Left += 10;
                        ulke_isimleri.Text = ulkeler_ingilizce[5];
                        ses.URL = "japan.mp3";
                        ulkeler_level1_panel.BackgroundImage = Properties.Resources.sonDeneme;
                    }
                }
            }
            if(ulkeler_level1_japonya.Location != bayrak_koordinat)
            {
                ulkeler_level1_japonya.Location = japonya_baslangic;
            }
            else
            {
                ulkeler_level1_kontrol += 1;
                if (ulkeler_level1_kontrol == 10)
                {
                    ulkeler_level1_tik.Visible = true;
                    levels13.Visible = false;
                }
            }
        }

        private void bayraklar_level1_ingiltere_MouseUp(object sender, MouseEventArgs e)
        {
            for (int i = 21; i < 345; i++)
            {
                for (int j = 195; j < 390; j++)
                {
                    if (ulkeler_level1_ingiltere.Left == i && ulkeler_level1_ingiltere.Top == j)
                    {
                        ulkeler_level1_ingiltere.Location = bayrak_koordinat;
                        ulke_isimleri.Visible = true;
                        ulke_isimleri.Left -= 5;
                        ulke_isimleri.Text = ulkeler_ingilizce[6];
                        ses.URL = "england.mp3";
                        ulkeler_level1_panel.BackgroundImage = Properties.Resources.sonDeneme;
                    }
                }
            }
            if(ulkeler_level1_ingiltere.Location != bayrak_koordinat)
            {
                ulkeler_level1_ingiltere.Location = ingiltere_baslangic;
            }
            else
            {
                ulkeler_level1_kontrol += 1;
                if (ulkeler_level1_kontrol == 10)
                {
                    ulkeler_level1_tik.Visible = true;
                    levels13.Visible = false;
                }
            }
        }

        private void bayraklar_level1_italya_MouseUp(object sender, MouseEventArgs e)
        {
            for (int i = 21; i < 345; i++)
            {
                for (int j = 195; j < 390; j++)
                {
                    if (ulkeler_level1_italya.Left == i && ulkeler_level1_italya.Top == j)
                    {
                        ulkeler_level1_italya.Location = bayrak_koordinat;
                        ulke_isimleri.Visible = true;
                        ulke_isimleri.Left += 28;
                        ulke_isimleri.Text = ulkeler_ingilizce[7];
                        ses.URL = "italy.mp3";
                        ulkeler_level1_panel.BackgroundImage = Properties.Resources.sonDeneme;
                    }
                }
            }
            if(ulkeler_level1_italya.Location != bayrak_koordinat)
            {
                ulkeler_level1_italya.Location = italya_baslangic;
            }
            else
            {
                ulkeler_level1_kontrol += 1;
                if (ulkeler_level1_kontrol == 10)
                {
                    ulkeler_level1_tik.Visible = true;
                    levels13.Visible = false;
                }
            }
        }

        private void bayraklar_level1_portekiz_MouseUp(object sender, MouseEventArgs e)
        {
            for (int i = 21; i < 345; i++)
            {
                for (int j = 195; j < 390; j++)
                {
                    if (ulkeler_level1_portekiz.Left == i && ulkeler_level1_portekiz.Top == j)
                    {
                        ulkeler_level1_portekiz.Location = bayrak_koordinat;
                        ulke_isimleri.Visible = true;
                        ulke_isimleri.Left -= 7;
                        ulke_isimleri.Text = ulkeler_ingilizce[8];
                        ses.URL = "portugal.mp3";
                        ulkeler_level1_panel.BackgroundImage = Properties.Resources.sonDeneme;
                    }
                }
            }
            if(ulkeler_level1_portekiz.Location != bayrak_koordinat)
            {
                ulkeler_level1_portekiz.Location = portekiz_baslangic;
            }
            else
            {
                ulkeler_level1_kontrol += 1;
                if (ulkeler_level1_kontrol == 10)
                {
                    ulkeler_level1_tik.Visible = true;
                    levels13.Visible = false;
                }
            }
        }

        private void ulkeler_level2_cevap1_Click(object sender, EventArgs e)
        {
            if (ulkeler_level2_cevap1.Text == ulkeler_ingilizce[ulkeler_level2_karisik1[ulkeler_level2_sayac - 1]])
            {
                level2_ulkeler[ulkeler_level2_karisik1[ulkeler_level2_sayac - 1]].Visible = false;
                ulkeler_level2_cevap1.Visible = false;
                if(ulkeler_level2_cevap1.Text == "Turkey")
                {
                    ses.URL = "turkey.mp3";
                }
                else if(ulkeler_level2_cevap1.Text == "Spain")
                {
                    ses.URL = "spain.mp3";
                }
                else if (ulkeler_level2_cevap1.Text == "France")
                {
                    ses.URL = "france.mp3";
                }
                else if (ulkeler_level2_cevap1.Text == "Poland")
                {
                    ses.URL = "poland.mp3";
                }
                else if (ulkeler_level2_cevap1.Text == "Germany")
                {
                    ses.URL = "germany.mp3";
                }
                else if (ulkeler_level2_cevap1.Text == "Japan")
                {
                    ses.URL = "japan.mp3";
                }
                else if (ulkeler_level2_cevap1.Text == "England")
                {
                    ses.URL = "england.mp3";
                }
                else if (ulkeler_level2_cevap1.Text == "Italy")
                {
                    ses.URL = "italy.mp3";
                }
                else if (ulkeler_level2_cevap1.Text == "Portugal")
                {
                    ses.URL = "portugal.mp3";
                }
                else if (ulkeler_level2_cevap1.Text == "China")
                {
                    ses.URL = "china.mp3";
                }
                ulkeler_level2_rastgele();
            }
            else
            {
                can -= 1;
                ulkeler_level2_can.Text = Convert.ToString(can);
                if(can == -1)
                {
                    ulkeler_level2_timer.Stop();
                    ulkeler_level2_over.Visible = true;
                }
                ulkeler_level2_cevap1.BackColor = System.Drawing.Color.Red;
            }
        }

        private void ulkeler_level2_cevap2_Click(object sender, EventArgs e)
        {
            if (ulkeler_level2_cevap2.Text == ulkeler_ingilizce[ulkeler_level2_karisik1[ulkeler_level2_sayac - 1]])
            {
                level2_ulkeler[ulkeler_level2_karisik1[ulkeler_level2_sayac - 1]].Visible = false;
                ulkeler_level2_cevap2.Visible = false;
                if (ulkeler_level2_cevap2.Text == "Turkey")
                {
                    ses.URL = "turkey.mp3";
                }
                else if (ulkeler_level2_cevap2.Text == "Spain")
                {
                    ses.URL = "spain.mp3";
                }
                else if (ulkeler_level2_cevap2.Text == "France")
                {
                    ses.URL = "france.mp3";
                }
                else if (ulkeler_level2_cevap2.Text == "Poland")
                {
                    ses.URL = "poland.mp3";
                }
                else if (ulkeler_level2_cevap2.Text == "Germany")
                {
                    ses.URL = "germany.mp3";
                }
                else if (ulkeler_level2_cevap2.Text == "Japan")
                {
                    ses.URL = "japan.mp3";
                }
                else if (ulkeler_level2_cevap2.Text == "England")
                {
                    ses.URL = "england.mp3";
                }
                else if (ulkeler_level2_cevap2.Text == "Italy")
                {
                    ses.URL = "italy.mp3";
                }
                else if (ulkeler_level2_cevap2.Text == "Portugal")
                {
                    ses.URL = "portugal.mp3";
                }
                else if (ulkeler_level2_cevap2.Text == "China")
                {
                    ses.URL = "china.mp3";
                }
                ulkeler_level2_rastgele();
            }
            else
            {
                can -= 1;
                ulkeler_level2_can.Text = Convert.ToString(can);
                if (can == -1)
                {
                    ulkeler_level2_timer.Stop();
                    ulkeler_level2_over.Visible = true;
                }
                ulkeler_level2_cevap2.BackColor = System.Drawing.Color.Red;
            }
        }

        private void ulkeler_level2_cevap3_Click(object sender, EventArgs e)
        {
            if (ulkeler_level2_cevap3.Text == ulkeler_ingilizce[ulkeler_level2_karisik1[ulkeler_level2_sayac - 1]])
            {
                level2_ulkeler[ulkeler_level2_karisik1[ulkeler_level2_sayac - 1]].Visible = false;
                ulkeler_level2_cevap3.Visible = false;
                if (ulkeler_level2_cevap3.Text == "Turkey")
                {
                    ses.URL = "turkey.mp3";
                }
                else if (ulkeler_level2_cevap3.Text == "Spain")
                {
                    ses.URL = "spain.mp3";
                }
                else if (ulkeler_level2_cevap3.Text == "France")
                {
                    ses.URL = "france.mp3";
                }
                else if (ulkeler_level2_cevap3.Text == "Poland")
                {
                    ses.URL = "poland.mp3";
                }
                else if (ulkeler_level2_cevap3.Text == "Germany")
                {
                    ses.URL = "germany.mp3";
                }
                else if (ulkeler_level2_cevap3.Text == "Japan")
                {
                    ses.URL = "japan.mp3";
                }
                else if (ulkeler_level2_cevap3.Text == "England")
                {
                    ses.URL = "england.mp3";
                }
                else if (ulkeler_level2_cevap3.Text == "Italy")
                {
                    ses.URL = "italy.mp3";
                }
                else if (ulkeler_level2_cevap3.Text == "Portugal")
                {
                    ses.URL = "portugal.mp3";
                }
                else if (ulkeler_level2_cevap3.Text == "China")
                {
                    ses.URL = "china.mp3";
                }
                ulkeler_level2_rastgele();
            }
            else
            {
                can -= 1;
                ulkeler_level2_can.Text = Convert.ToString(can);
                if (can == -1)
                {
                    ulkeler_level2_timer.Stop();
                    ulkeler_level2_over.Visible = true;
                }
                ulkeler_level2_cevap3.BackColor = System.Drawing.Color.Red;
            }
        }

        private void ulkeler_level2_cevap4_Click(object sender, EventArgs e)
        {
            if (ulkeler_level2_cevap4.Text == ulkeler_ingilizce[ulkeler_level2_karisik1[ulkeler_level2_sayac - 1]])
            {
                level2_ulkeler[ulkeler_level2_karisik1[ulkeler_level2_sayac - 1]].Visible = false;
                ulkeler_level2_cevap4.Visible = false;
                if (ulkeler_level2_cevap4.Text == "Turkey")
                {
                    ses.URL = "turkey.mp3";
                }
                else if (ulkeler_level2_cevap4.Text == "Spain")
                {
                    ses.URL = "spain.mp3";
                }
                else if (ulkeler_level2_cevap4.Text == "France")
                {
                    ses.URL = "france.mp3";
                }
                else if (ulkeler_level2_cevap4.Text == "Poland")
                {
                    ses.URL = "poland.mp3";
                }
                else if (ulkeler_level2_cevap4.Text == "Germany")
                {
                    ses.URL = "germany.mp3";
                }
                else if (ulkeler_level2_cevap4.Text == "Japan")
                {
                    ses.URL = "japan.mp3";
                }
                else if (ulkeler_level2_cevap4.Text == "England")
                {
                    ses.URL = "england.mp3";
                }
                else if (ulkeler_level2_cevap4.Text == "Italy")
                {
                    ses.URL = "italy.mp3";
                }
                else if (ulkeler_level2_cevap4.Text == "Portugal")
                {
                    ses.URL = "portugal.mp3";
                }
                else if (ulkeler_level2_cevap4.Text == "China")
                {
                    ses.URL = "china.mp3";
                }
                ulkeler_level2_rastgele();
            }
            else
            {
                can -= 1;
                ulkeler_level2_can.Text = Convert.ToString(can);
                if (can == -1)
                {
                    ulkeler_level2_timer.Stop();
                    ulkeler_level2_over.Visible = true;
                }
                ulkeler_level2_cevap4.BackColor = System.Drawing.Color.Red;
            }
        }

        private void ulkeler_level2_cevap5_Click(object sender, EventArgs e)
        {
            if (ulkeler_level2_cevap5.Text == ulkeler_ingilizce[ulkeler_level2_karisik1[ulkeler_level2_sayac - 1]])
            {
                level2_ulkeler[ulkeler_level2_karisik1[ulkeler_level2_sayac - 1]].Visible = false;
                ulkeler_level2_cevap5.Visible = false;
                if (ulkeler_level2_cevap5.Text == "Turkey")
                {
                    ses.URL = "turkey.mp3";
                }
                else if (ulkeler_level2_cevap5.Text == "Spain")
                {
                    ses.URL = "spain.mp3";
                }
                else if (ulkeler_level2_cevap5.Text == "France")
                {
                    ses.URL = "france.mp3";
                }
                else if (ulkeler_level2_cevap5.Text == "Poland")
                {
                    ses.URL = "poland.mp3";
                }
                else if (ulkeler_level2_cevap5.Text == "Germany")
                {
                    ses.URL = "germany.mp3";
                }
                else if (ulkeler_level2_cevap5.Text == "Japan")
                {
                    ses.URL = "japan.mp3";
                }
                else if (ulkeler_level2_cevap5.Text == "England")
                {
                    ses.URL = "england.mp3";
                }
                else if (ulkeler_level2_cevap5.Text == "Italy")
                {
                    ses.URL = "italy.mp3";
                }
                else if (ulkeler_level2_cevap5.Text == "Portugal")
                {
                    ses.URL = "portugal.mp3";
                }
                else if (ulkeler_level2_cevap5.Text == "China")
                {
                    ses.URL = "china.mp3";
                }
                ulkeler_level2_rastgele();
            }
            else
            {
                can -= 1;
                ulkeler_level2_can.Text = Convert.ToString(can);
                if (can == -1)
                {
                    ulkeler_level2_timer.Stop();
                    ulkeler_level2_over.Visible = true;
                }
                ulkeler_level2_cevap5.BackColor = System.Drawing.Color.Red;
            }
        }

        private void ulkeler_level2_cevap6_Click(object sender, EventArgs e)
        {
            if (ulkeler_level2_cevap6.Text == ulkeler_ingilizce[ulkeler_level2_karisik1[ulkeler_level2_sayac - 1]])
            {
                level2_ulkeler[ulkeler_level2_karisik1[ulkeler_level2_sayac - 1]].Visible = false;
                ulkeler_level2_cevap6.Visible = false;
                if (ulkeler_level2_cevap6.Text == "Turkey")
                {
                    ses.URL = "turkey.mp3";
                }
                else if (ulkeler_level2_cevap6.Text == "Spain")
                {
                    ses.URL = "spain.mp3";
                }
                else if (ulkeler_level2_cevap6.Text == "France")
                {
                    ses.URL = "france.mp3";
                }
                else if (ulkeler_level2_cevap6.Text == "Poland")
                {
                    ses.URL = "poland.mp3";
                }
                else if (ulkeler_level2_cevap6.Text == "Germany")
                {
                    ses.URL = "germany.mp3";
                }
                else if (ulkeler_level2_cevap6.Text == "Japan")
                {
                    ses.URL = "japan.mp3";
                }
                else if (ulkeler_level2_cevap6.Text == "England")
                {
                    ses.URL = "england.mp3";
                }
                else if (ulkeler_level2_cevap6.Text == "Italy")
                {
                    ses.URL = "italy.mp3";
                }
                else if (ulkeler_level2_cevap6.Text == "Portugal")
                {
                    ses.URL = "portugal.mp3";
                }
                else if (ulkeler_level2_cevap6.Text == "China")
                {
                    ses.URL = "china.mp3";
                }
                ulkeler_level2_rastgele();
            }
            else
            {
                can -= 1;
                ulkeler_level2_can.Text = Convert.ToString(can);
                if (can == -1)
                {
                    ulkeler_level2_timer.Stop();
                    ulkeler_level2_over.Visible = true;
                }
                ulkeler_level2_cevap6.BackColor = System.Drawing.Color.Red;
            }
        }

        private void ulkeler_level2_cevap7_Click(object sender, EventArgs e)
        {
            if (ulkeler_level2_cevap7.Text == ulkeler_ingilizce[ulkeler_level2_karisik1[ulkeler_level2_sayac - 1]])
            {
                level2_ulkeler[ulkeler_level2_karisik1[ulkeler_level2_sayac - 1]].Visible = false;
                ulkeler_level2_cevap7.Visible = false;
                if (ulkeler_level2_cevap7.Text == "Turkey")
                {
                    ses.URL = "turkey.mp3";
                }
                else if (ulkeler_level2_cevap7.Text == "Spain")
                {
                    ses.URL = "spain.mp3";
                }
                else if (ulkeler_level2_cevap7.Text == "France")
                {
                    ses.URL = "france.mp3";
                }
                else if (ulkeler_level2_cevap7.Text == "Poland")
                {
                    ses.URL = "poland.mp3";
                }
                else if (ulkeler_level2_cevap7.Text == "Germany")
                {
                    ses.URL = "germany.mp3";
                }
                else if (ulkeler_level2_cevap7.Text == "Japan")
                {
                    ses.URL = "japan.mp3";
                }
                else if (ulkeler_level2_cevap7.Text == "England")
                {
                    ses.URL = "england.mp3";
                }
                else if (ulkeler_level2_cevap7.Text == "Italy")
                {
                    ses.URL = "italy.mp3";
                }
                else if (ulkeler_level2_cevap7.Text == "Portugal")
                {
                    ses.URL = "portugal.mp3";
                }
                else if (ulkeler_level2_cevap7.Text == "China")
                {
                    ses.URL = "china.mp3";
                }
                ulkeler_level2_rastgele();
            }
            else
            {
                can -= 1;
                ulkeler_level2_can.Text = Convert.ToString(can);
                if (can == -1)
                {
                    ulkeler_level2_timer.Stop();
                    ulkeler_level2_over.Visible = true;
                }
                ulkeler_level2_cevap7.BackColor = System.Drawing.Color.Red;
            }
        }

        private void ulkeler_level2_cevap8_Click(object sender, EventArgs e)
        {
            if (ulkeler_level2_cevap8.Text == ulkeler_ingilizce[ulkeler_level2_karisik1[ulkeler_level2_sayac - 1]])
            {
                level2_ulkeler[ulkeler_level2_karisik1[ulkeler_level2_sayac - 1]].Visible = false;
                ulkeler_level2_cevap8.Visible = false;
                if (ulkeler_level2_cevap8.Text == "Turkey")
                {
                    ses.URL = "turkey.mp3";
                }
                else if (ulkeler_level2_cevap8.Text == "Spain")
                {
                    ses.URL = "spain.mp3";
                }
                else if (ulkeler_level2_cevap8.Text == "France")
                {
                    ses.URL = "france.mp3";
                }
                else if (ulkeler_level2_cevap8.Text == "Poland")
                {
                    ses.URL = "poland.mp3";
                }
                else if (ulkeler_level2_cevap8.Text == "Germany")
                {
                    ses.URL = "germany.mp3";
                }
                else if (ulkeler_level2_cevap8.Text == "Japan")
                {
                    ses.URL = "japan.mp3";
                }
                else if (ulkeler_level2_cevap8.Text == "England")
                {
                    ses.URL = "england.mp3";
                }
                else if (ulkeler_level2_cevap8.Text == "Italy")
                {
                    ses.URL = "italy.mp3";
                }
                else if (ulkeler_level2_cevap8.Text == "Portugal")
                {
                    ses.URL = "portugal.mp3";
                }
                else if( ulkeler_level2_cevap8.Text == "China")
                {
                    ses.URL = "china.mp3";
                }
                ulkeler_level2_rastgele();
            }
            else
            {
                can -= 1;
                ulkeler_level2_can.Text = Convert.ToString(can);
                if (can == -1)
                {
                    ulkeler_level2_timer.Stop();
                    ulkeler_level2_over.Visible = true;
                }
                ulkeler_level2_cevap8.BackColor = System.Drawing.Color.Red;
            }
        }

        private void ulkeler_level2_cevap9_Click(object sender, EventArgs e)
        {
            if (ulkeler_level2_cevap9.Text == ulkeler_ingilizce[ulkeler_level2_karisik1[ulkeler_level2_sayac - 1]])
            {
                level2_ulkeler[ulkeler_level2_karisik1[ulkeler_level2_sayac - 1]].Visible = false;
                ulkeler_level2_cevap9.Visible = false;
                if (ulkeler_level2_cevap9.Text == "Turkey")
                {
                    ses.URL = "turkey.mp3";
                }
                else if (ulkeler_level2_cevap9.Text == "Spain")
                {
                    ses.URL = "spain.mp3";
                }
                else if (ulkeler_level2_cevap9.Text == "France")
                {
                    ses.URL = "france.mp3";
                }
                else if (ulkeler_level2_cevap9.Text == "Poland")
                {
                    ses.URL = "poland.mp3";
                }
                else if (ulkeler_level2_cevap9.Text == "Germany")
                {
                    ses.URL = "germany.mp3";
                }
                else if (ulkeler_level2_cevap9.Text == "Japan")
                {
                    ses.URL = "japan.mp3";
                }
                else if (ulkeler_level2_cevap9.Text == "England")
                {
                    ses.URL = "england.mp3";
                }
                else if (ulkeler_level2_cevap9.Text == "Italy")
                {
                    ses.URL = "italy.mp3";
                }
                else if (ulkeler_level2_cevap9.Text == "Portugal")
                {
                    ses.URL = "portugal.mp3";
                }
                else if (ulkeler_level2_cevap9.Text == "China")
                {
                    ses.URL = "china.mp3";
                }
                ulkeler_level2_rastgele();
            }
            else
            {
                can -= 1;
                ulkeler_level2_can.Text = Convert.ToString(can);
                if (can == -1)
                {
                    ulkeler_level2_timer.Stop();
                    ulkeler_level2_over.Visible = true;
                }
                ulkeler_level2_cevap9.BackColor = System.Drawing.Color.Red;
            }
        }

        private void ulkeler_level2_cevap10_Click(object sender, EventArgs e)
        {
            if (ulkeler_level2_cevap10.Text == ulkeler_ingilizce[ulkeler_level2_karisik1[ulkeler_level2_sayac - 1]])
            {
                level2_ulkeler[ulkeler_level2_karisik1[ulkeler_level2_sayac - 1]].Visible = false;
                ulkeler_level2_cevap10.Visible = false;
                if (ulkeler_level2_cevap10.Text == "Turkey")
                {
                    ses.URL = "turkey.mp3";
                }
                else if (ulkeler_level2_cevap10.Text == "Spain")
                {
                    ses.URL = "spain.mp3";
                }
                else if (ulkeler_level2_cevap10.Text == "France")
                {
                    ses.URL = "france.mp3";
                }
                else if (ulkeler_level2_cevap10.Text == "Poland")
                {
                    ses.URL = "poland.mp3";
                }
                else if (ulkeler_level2_cevap10.Text == "Germany")
                {
                    ses.URL = "germany.mp3";
                }
                else if (ulkeler_level2_cevap10.Text == "Japan")
                {
                    ses.URL = "japan.mp3";
                }
                else if (ulkeler_level2_cevap10.Text == "England")
                {
                    ses.URL = "england.mp3";
                }
                else if (ulkeler_level2_cevap10.Text == "Italy")
                {
                    ses.URL = "italy.mp3";
                }
                else if (ulkeler_level2_cevap10.Text == "Portugal")
                {
                    ses.URL = "portugal.mp3";
                }
                else if (ulkeler_level2_cevap10.Text == "China")
                {
                    ses.URL = "china.mp3";
                }
                ulkeler_level2_rastgele();
            }
            else
            {
                can -= 1;
                ulkeler_level2_can.Text = Convert.ToString(can);
                if (can == -1)
                {
                    ulkeler_level2_timer.Stop();
                    ulkeler_level2_over.Visible = true;
                }
                ulkeler_level2_cevap10.BackColor = System.Drawing.Color.Red;
            }
        }

        private void ulkeler_level3_cevap1_Click(object sender, EventArgs e)
        {
            if (level3_ulkeler[ulkeler_level3_karisik_rakamlar[ulkeler_level3_sayac - 1]].Visible == true && ulkeler_level3_cevap1.Text == ulkeler_ingilizce[ulkeler_level3_karisik_rakamlar[ulkeler_level3_sayac - 1]])
            {
                level3_ulkeler[ulkeler_level3_karisik_rakamlar[ulkeler_level3_sayac - 1]].Visible = false;
                if(ulkeler_level3_cevap1.Text == "Turkey")
                {
                    ses.URL = "turkey.mp3";
                }
                else if(ulkeler_level3_cevap1.Text == "Spain")
                {
                    ses.URL = "spain.mp3";
                }
                else if (ulkeler_level3_cevap1.Text == "France")
                {
                    ses.URL = "france.mp3";
                }
                else if (ulkeler_level3_cevap1.Text == "Poland")
                {
                    ses.URL = "poland.mp3";
                }
                else if (ulkeler_level3_cevap1.Text == "Germany")
                {
                    ses.URL = "germany.mp3";
                }
                else if (ulkeler_level3_cevap1.Text == "Japan")
                {
                    ses.URL = "japan.mp3";
                }
                else if (ulkeler_level3_cevap1.Text == "England")
                {
                    ses.URL = "england.mp3";
                }
                else if (ulkeler_level3_cevap1.Text == "Italy")
                {
                    ses.URL = "italy.mp3";
                }
                else if (ulkeler_level3_cevap1.Text == "Portugal")
                {
                    ses.URL = "portugal.mp3";
                }
                else if (ulkeler_level3_cevap1.Text == "China")
                {
                    ses.URL = "china.mp3";
                }                
                ulkeler_level3_timer.Stop();
                zaman = 5;
                ulkeler_level3_sure.Text = "5";
                ulkeler_level3_timer.Start();
                ulkeler_level3_rastgele();
            }
            else
            {
                ulkeler_level3_timer.Stop();
                ulkeler_level3_over.Visible = true;
                ulkeler_level3_cevap1.BackColor = System.Drawing.Color.Red;
            }
        }

        private void ulkeler_level3_cevap2_Click(object sender, EventArgs e)
        {
            if (level3_ulkeler[ulkeler_level3_karisik_rakamlar[ulkeler_level3_sayac - 1]].Visible == true && ulkeler_level3_cevap2.Text == ulkeler_ingilizce[ulkeler_level3_karisik_rakamlar[ulkeler_level3_sayac - 1]])
            {
                level3_ulkeler[ulkeler_level3_karisik_rakamlar[ulkeler_level3_sayac - 1]].Visible = false;
                if (ulkeler_level3_cevap2.Text == "Turkey")
                {
                    ses.URL = "turkey.mp3";
                }
                else if (ulkeler_level3_cevap2.Text == "Spain")
                {
                    ses.URL = "spain.mp3";
                }
                else if (ulkeler_level3_cevap2.Text == "France")
                {
                    ses.URL = "france.mp3";
                }
                else if (ulkeler_level3_cevap2.Text == "Poland")
                {
                    ses.URL = "poland.mp3";
                }
                else if (ulkeler_level3_cevap2.Text == "Germany")
                {
                    ses.URL = "germany.mp3";
                }
                else if (ulkeler_level3_cevap2.Text == "Japan")
                {
                    ses.URL = "japan.mp3";
                }
                else if (ulkeler_level3_cevap2.Text == "England")
                {
                    ses.URL = "england.mp3";
                }
                else if (ulkeler_level3_cevap2.Text == "Italy")
                {
                    ses.URL = "italy.mp3";
                }
                else if (ulkeler_level3_cevap2.Text == "Portugal")
                {
                    ses.URL = "portugal.mp3";
                }
                else if (ulkeler_level3_cevap2.Text == "China")
                {
                    ses.URL = "china.mp3";
                }
                ulkeler_level3_timer.Stop();
                zaman = 5;
                ulkeler_level3_sure.Text = "5";
                ulkeler_level3_timer.Start();
                ulkeler_level3_rastgele();
            }
            else
            {
                ulkeler_level3_timer.Stop();
                ulkeler_level3_over.Visible = true;
                ulkeler_level3_cevap2.BackColor = System.Drawing.Color.Red;
            }
        }

        private void ulkeler_level3_cevap3_Click(object sender, EventArgs e)
        {
            if (level3_ulkeler[ulkeler_level3_karisik_rakamlar[ulkeler_level3_sayac - 1]].Visible == true && ulkeler_level3_cevap3.Text == ulkeler_ingilizce[ulkeler_level3_karisik_rakamlar[ulkeler_level3_sayac - 1]])
            {
                level3_ulkeler[ulkeler_level3_karisik_rakamlar[ulkeler_level3_sayac - 1]].Visible = false;
                if (ulkeler_level3_cevap3.Text == "Turkey")
                {
                    ses.URL = "turkey.mp3";
                }
                else if (ulkeler_level3_cevap3.Text == "Spain")
                {
                    ses.URL = "spain.mp3";
                }
                else if (ulkeler_level3_cevap3.Text == "France")
                {
                    ses.URL = "france.mp3";
                }
                else if (ulkeler_level3_cevap3.Text == "Poland")
                {
                    ses.URL = "poland.mp3";
                }
                else if (ulkeler_level3_cevap3.Text == "Germany")
                {
                    ses.URL = "germany.mp3";
                }
                else if (ulkeler_level3_cevap3.Text == "Japan")
                {
                    ses.URL = "japan.mp3";
                }
                else if (ulkeler_level3_cevap3.Text == "England")
                {
                    ses.URL = "england.mp3";
                }
                else if (ulkeler_level3_cevap3.Text == "Italy")
                {
                    ses.URL = "italy.mp3";
                }
                else if (ulkeler_level3_cevap3.Text == "Portugal")
                {
                    ses.URL = "portugal.mp3";
                }
                else if (ulkeler_level3_cevap3.Text == "China")
                {
                    ses.URL = "china.mp3";
                }
                ulkeler_level3_timer.Stop();
                zaman = 5;
                ulkeler_level3_sure.Text = "5";
                ulkeler_level3_timer.Start();
                ulkeler_level3_rastgele();
            }
            else
            {
                ulkeler_level3_timer.Stop();
                ulkeler_level3_over.Visible = true;
                ulkeler_level3_cevap3.BackColor = System.Drawing.Color.Red;
            }
        }

        private void ulkeler_level3_cevap4_Click(object sender, EventArgs e)
        {
            if (level3_ulkeler[ulkeler_level3_karisik_rakamlar[ulkeler_level3_sayac - 1]].Visible == true && ulkeler_level3_cevap4.Text == ulkeler_ingilizce[ulkeler_level3_karisik_rakamlar[ulkeler_level3_sayac - 1]])
            {
                level3_ulkeler[ulkeler_level3_karisik_rakamlar[ulkeler_level3_sayac - 1]].Visible = false;
                if (ulkeler_level3_cevap4.Text == "Turkey")
                {
                    ses.URL = "turkey.mp3";
                }
                else if (ulkeler_level3_cevap4.Text == "Spain")
                {
                    ses.URL = "spain.mp3";
                }
                else if (ulkeler_level3_cevap4.Text == "France")
                {
                    ses.URL = "france.mp3";
                }
                else if (ulkeler_level3_cevap4.Text == "Poland")
                {
                    ses.URL = "poland.mp3";
                }
                else if (ulkeler_level3_cevap4.Text == "Germany")
                {
                    ses.URL = "germany.mp3";
                }
                else if (ulkeler_level3_cevap4.Text == "Japan")
                {
                    ses.URL = "japan.mp3";
                }
                else if (ulkeler_level3_cevap4.Text == "England")
                {
                    ses.URL = "england.mp3";
                }
                else if (ulkeler_level3_cevap4.Text == "Italy")
                {
                    ses.URL = "italy.mp3";
                }
                else if (ulkeler_level3_cevap4.Text == "Portugal")
                {
                    ses.URL = "portugal.mp3";
                }
                else if (ulkeler_level3_cevap4.Text == "China")
                {
                    ses.URL = "china.mp3";
                }
                ulkeler_level3_timer.Stop();
                zaman = 5;
                ulkeler_level3_sure.Text = "5";
                ulkeler_level3_timer.Start();
                ulkeler_level3_rastgele();
            }
            else
            {
                ulkeler_level3_timer.Stop();
                ulkeler_level3_over.Visible = true;
                ulkeler_level3_cevap4.BackColor = System.Drawing.Color.Red;
            }
        }

        private void body_level1_buton1_Click(object sender, EventArgs e)
        {
            ses.URL = "hair.mp3";
            body_level1_yazi1.Visible = true;
            body_level1_buton1.Enabled = false;
            tik_sayisi += 1;
            if(tik_sayisi == 12)
            {
                bodyparts_level1_tik.Visible = true;
                levels7.Visible = false;
            }
        }

        private void body_level1_buton2_Click(object sender, EventArgs e)
        {
            ses.URL = "face.mp3";
            body_level1_yazi2.Visible = true;
            body_level1_buton2.Enabled = false;
            tik_sayisi += 1;
            if (tik_sayisi == 12)
            {
                bodyparts_level1_tik.Visible = true;
                levels7.Visible = false;
            }
        }

        private void body_level1_buton3_Click(object sender, EventArgs e)
        {
            ses.URL = "ear.mp3";
            body_level1_yazi3.Visible = true;
            body_level1_buton3.Enabled = false;
            tik_sayisi += 1;
            if (tik_sayisi == 12)
            {
                bodyparts_level1_tik.Visible = true;
                levels7.Visible = false;
            }
        }

        private void body_level1_buton4_Click(object sender, EventArgs e)
        {
            ses.URL = "eye.mp3";
            body_level1_yazi4.Visible = true;
            body_level1_buton4.Enabled = false;
            tik_sayisi += 1;
            if (tik_sayisi == 12)
            {
                bodyparts_level1_tik.Visible = true;
                levels7.Visible = false;
            }
        }

        private void body_level1_buton5_Click(object sender, EventArgs e)
        {
            ses.URL = "nose.mp3";
            body_level1_yazi5.Visible = true;
            body_level1_buton5.Enabled = false;
            tik_sayisi += 1;
            if (tik_sayisi == 12)
            {
                bodyparts_level1_tik.Visible = true;
                levels7.Visible = false;
            }
        }

        private void body_level1_buton6_Click(object sender, EventArgs e)
        {
            ses.URL = "lip.mp3";
            body_level1_yazi6.Visible = true;
            body_level1_buton6.Enabled = false;
            tik_sayisi += 1;
            if (tik_sayisi == 12)
            {
                bodyparts_level1_tik.Visible = true;
                levels7.Visible = false;
            }
        }

        private void body_level1_buton7_Click(object sender, EventArgs e)
        {
            ses.URL = "neck.mp3";
            body_level1_yazi7.Visible = true;
            body_level1_buton7.Enabled = false;
            tik_sayisi += 1;
            if (tik_sayisi == 12)
            {
                bodyparts_level1_tik.Visible = true;
                levels7.Visible = false;
            }
        }

        private void body_level1_buton8_Click(object sender, EventArgs e)
        {
            ses.URL = "arm.mp3";
            body_level1_yazi8.Visible = true;
            body_level1_buton8.Enabled = false;
            tik_sayisi += 1;
            if (tik_sayisi == 12)
            {
                bodyparts_level1_tik.Visible = true;
                levels7.Visible = false;
            }
        }

        private void body_level1_buton9_Click(object sender, EventArgs e)
        {
            ses.URL = "hand.mp3";
            body_level1_yazi9.Visible = true;
            body_level1_buton9.Enabled = false;
            tik_sayisi += 1;
            if (tik_sayisi == 12)
            {
                bodyparts_level1_tik.Visible = true;
                levels7.Visible = false;
            }
        }

        private void body_level1_buton10_Click(object sender, EventArgs e)
        {
            ses.URL = "abdomen.mp3";
            body_level1_yazi10.Visible = true;
            body_level1_buton10.Enabled = false;
            tik_sayisi += 1;
            if (tik_sayisi == 12)
            {
                bodyparts_level1_tik.Visible = true;
                levels7.Visible = false;
            }
        }

        private void body_level1_buton11_Click(object sender, EventArgs e)
        {
            ses.URL = "leg.mp3";
            body_level1_yazi11.Visible = true;
            body_level1_buton11.Enabled = false;
            tik_sayisi += 1;
            if (tik_sayisi == 12)
            {
                bodyparts_level1_tik.Visible = true;
                levels7.Visible = false;
            }
        }

        private void vucutbolumleri_Click(object sender, EventArgs e)
        {
            bodyparts_panel.Visible = true;
        }

        private void bodyparts_level1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void body_level1_buton12_Click(object sender, EventArgs e)
        {
            ses.URL = "foot.mp3";
            body_level1_yazi12.Visible = true;
            body_level1_buton12.Enabled = false;
            tik_sayisi += 1;
            if (tik_sayisi == 12)
            {
                bodyparts_level1_tik.Visible = true;
                levels7.Visible = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (body_level2_yazi.Text == "Hair")
            {
                ses.URL = "hair.mp3";
                body_level2_resim.Image = Properties.Resources.body_level2_2;
                button2.Enabled = false;
                body_level2_yazi.Text = "Face";
            }
            else
            {
                can -= 1;
                bodyparts_level2_can.Text = Convert.ToString(can);
                if (can == -1)
                {
                    bodyparts_level2_over.Visible = true;
                    bodyparts_level2_timer.Stop();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (body_level2_yazi.Text == "Face")
            {
                ses.URL = "face.mp3";
                body_level2_resim.Image = Properties.Resources.body_level2_3;
                button3.Enabled = false;
                body_level2_yazi.Text = "Ear";
            }           
            else
            {
                can -= 1;
                bodyparts_level2_can.Text = Convert.ToString(can);
                if (can == -1)
                {
                    bodyparts_level2_over.Visible = true;
                    bodyparts_level2_timer.Stop();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (body_level2_yazi.Text == "Ear")
            {
                ses.URL = "ear.mp3";
                body_level2_resim.Image = Properties.Resources.body_level2_4;
                button4.Enabled = false;
                body_level2_yazi.Text = "Eye";
            }
            else
            {
                can -= 1;
                bodyparts_level2_can.Text = Convert.ToString(can);
                if (can == -1)
                {
                    bodyparts_level2_over.Visible = true;
                    bodyparts_level2_timer.Stop();
                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (body_level2_yazi.Text == "Eye")
            {
                ses.URL = "eye.mp3";
                body_level2_resim.Image = Properties.Resources.body_level2_5;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = true;
                button10.Visible = true;
                button9.Visible = true;
                button11.Visible = true;
                button5.Enabled = true;
                button10.Enabled = true;
                button9.Enabled = true;
                button11.Enabled = true;
                body_level2_yazi.Text = "Nose";
            }
            else
            {
                can -= 1;
                bodyparts_level2_can.Text = Convert.ToString(can);
                if (can == -1)
                {
                    bodyparts_level2_over.Visible = true;
                    bodyparts_level2_timer.Stop();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (body_level2_yazi.Text == "Nose")
            {
                ses.URL = "nose.mp3";
                body_level2_resim.Image = Properties.Resources.body_level2_6;
                button5.Enabled = false;
                body_level2_yazi.Text = "Lip";
            }
            else
            {
                can -= 1;
                bodyparts_level2_can.Text = Convert.ToString(can);
                if (can == -1)
                {
                    bodyparts_level2_over.Visible = true;
                    bodyparts_level2_timer.Stop();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (body_level2_yazi.Text == "Lip")
            {
                ses.URL = "lip.mp3";
                body_level2_resim.Image = Properties.Resources.body_level2_7;
                button9.Enabled = false;
                body_level2_yazi.Text = "Neck";
            }
            else
            {
                can -= 1;
                bodyparts_level2_can.Text = Convert.ToString(can);
                if (can == -1)
                {
                    bodyparts_level2_over.Visible = true;
                    bodyparts_level2_timer.Stop();
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (body_level2_yazi.Text == "Neck")
            {
                ses.URL = "neck.mp3";
                body_level2_resim.Image = Properties.Resources.body_level2_8;
                button11.Enabled = false;
                body_level2_yazi.Text = "Arm";
            }
            else
            {
                can -= 1;
                bodyparts_level2_can.Text = Convert.ToString(can);
                if (can == -1)
                {
                    bodyparts_level2_over.Visible = true;
                    bodyparts_level2_timer.Stop();
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (body_level2_yazi.Text == "Arm")
            {
                ses.URL = "arm.mp3";
                body_level2_resim.Image = Properties.Resources.body_level2_9;
                button5.Visible = false;
                button9.Visible = false;
                button10.Visible = false;
                button11.Visible = false;
                button12.Visible = true;
                button13.Visible = true;
                button14.Visible = true;
                button15.Visible = true;
                button12.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                button15.Enabled = true;
                body_level2_yazi.Text = "Hand";
            }
            else
            {
                can -= 1;
                bodyparts_level2_can.Text = Convert.ToString(can);
                if (can == -1)
                {
                    bodyparts_level2_over.Visible = true;
                    bodyparts_level2_timer.Stop();
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (body_level2_yazi.Text == "Hand")
            {
                ses.URL = "hand.mp3";
                body_level2_resim.Image = Properties.Resources.body_level2_10;
                button13.Enabled = false;
                body_level2_yazi.Text = "Abdomen";
            }
            else
            {
                can -= 1;
                bodyparts_level2_can.Text = Convert.ToString(can);
                if (can == -1)
                {
                    bodyparts_level2_over.Visible = true;
                    bodyparts_level2_timer.Stop();
                }
            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (body_level2_yazi.Text == "Abdomen")
            {
                ses.URL = "abdomen.mp3";
                body_level2_resim.Image = Properties.Resources.body_level2_11;
                button12.Enabled = false;
                body_level2_yazi.Text = "Leg";
            }
            else
            {
                can -= 1;
                bodyparts_level2_can.Text = Convert.ToString(can);
                if (can == -1)
                {
                    bodyparts_level2_over.Visible = true;
                    bodyparts_level2_timer.Stop();
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (body_level2_yazi.Text == "Leg")
            {
                ses.URL = "leg.mp3";
                body_level2_resim.Image = Properties.Resources.body_level2_12;
                button14.Enabled = false;
                body_level2_yazi.Text = "Foot";
            }
            else
            {
                can -= 1;
                bodyparts_level2_can.Text = Convert.ToString(can);
                if (can == -1)
                {
                    bodyparts_level2_over.Visible = true;
                    bodyparts_level2_timer.Stop();
                }
            }
                   
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if(body_level2_yazi.Text == "Foot")
            {
                ses.URL = "foot.mp3";
                body_level2_resim.Image = Properties.Resources.body_level2_13;
                button15.Enabled = false;
                bodyparts_level2_timer.Stop();
                bodyparts_level2_passed.Visible = true;
            }
            else
            {
                can -= 1;
                bodyparts_level2_can.Text = Convert.ToString(can);
                if (can == -1)
                {
                    bodyparts_level2_over.Visible = true;
                    bodyparts_level2_timer.Stop();
                }
            }

        }

        private void body_level3_dogru_Click(object sender, EventArgs e)
        {
            bodyparts_level3_timer.Stop();
            if (body_level3_labellar[body_level3_karisik_rakamlar[body_level3_sayac-1]].Visible == true)
            {
                if (body_level3_hair.Visible == true)
                {
                    ses.URL = "hair.mp3";
                }
                else if(body_level3_face.Visible == true)
                {
                    ses.URL = "face.mp3";
                }
                else if (body_level3_ear.Visible == true)
                {
                    ses.URL = "ear.mp3";
                }
                else if (body_level3_eye.Visible == true)
                {
                    ses.URL = "eye.mp3";
                }
                else if (body_level3_nose.Visible == true)
                {
                    ses.URL = "nose.mp3";
                }
                else if (body_level3_lip.Visible == true)
                {
                    ses.URL = "lip.mp3";
                }
                else if (body_level3_neck.Visible == true)
                {
                    ses.URL = "neck.mp3";
                }
                else if (body_level3_arm.Visible == true)
                {
                    ses.URL = "arm.mp3";
                }
                else if (body_level3_hand.Visible == true)
                {
                    ses.URL = "hand.mp3";
                }
                else if (body_level3_abdomen.Visible == true)
                {
                    ses.URL = "abdomen.mp3";
                }
                else if (body_level3_leg.Visible == true)
                {
                    ses.URL = "leg.mp3";
                }
                else if (body_level3_foot.Visible == true)
                {
                    ses.URL = "foot.mp3";
                }
                body_level3_resimler[body_level3_karisik_rakamlar[body_level3_sayac - 1]].Visible = false;
                body_level3_labellar[body_level3_karisik_rakamlar[body_level3_sayac - 1]].Visible = false;
                zaman = 5;
                bodyparts_level3_sure.Text = "5";
                bodyparts_level3_timer.Start();
                body_level3_rastgele();
            }
            else
            {
                bodyparts_level3_timer.Stop();
                bodyparts_level3_over.Visible = true;
            }
        }

        private void body_level3_yanlis_Click(object sender, EventArgs e)
        {
            bodyparts_level3_timer.Stop();
            if (body_level3_labellar[body_level3_karisik_rakamlar[body_level3_sayac - 1]].Visible == false)
            {
                body_level3_resimler[body_level3_karisik_rakamlar[body_level3_sayac - 1]].Visible = false;
                body_level3_labellar[body_level3_rastgele_sayi].Visible = false;
                zaman = 5;
                bodyparts_level3_sure.Text = "5";
                bodyparts_level3_timer.Start();
                body_level3_rastgele();
            }
            else
            {
                bodyparts_level3_timer.Stop();
                bodyparts_level3_over.Visible = true;
            }
        }

        private void meyveler_level1_uzummavi_Click(object sender, EventArgs e)
        {
            meyveler_level1_elmamavi.Visible = false;
            meyveler_level1_elmamaviimlec.Visible = false;
            meyveler_level1_muzmaviimlec.Visible = false;
            meyveler_level1_cilekmaviimlec.Visible = false;
            meyveler_level1_elmasari.BackColor = Color.Lime;
            meyveler_level1_elmasariimlec.Visible = true;
            meyveler_level1_muzmavi.Enabled = false;
            meyveler_level1_muzmaviimlec.Enabled = false;
            meyveler_level1_cilekmavi.Enabled = false;
            meyveler_level1_cilekmaviimlec.Enabled = false;
            meyveler_level1_elmasari.Enabled = true;
            meyveler_level1_elmasariimlec.Enabled = true;
        }

        private void meyveler_Click(object sender, EventArgs e)
        {
            meyveler_panel.Visible = true;
        }

        private void meyveler_level1_uzummaviimlec_Click(object sender, EventArgs e)
        {
            meyveler_level1_elmamavi.Visible = false;
            meyveler_level1_elmamaviimlec.Visible = false;
            meyveler_level1_muzmaviimlec.Visible = false;
            meyveler_level1_cilekmaviimlec.Visible = false;
            meyveler_level1_elmasari.BackColor = Color.Lime;
            meyveler_level1_elmasariimlec.Visible = true;
            meyveler_level1_muzmavi.Enabled = false;
            meyveler_level1_muzmaviimlec.Enabled = false;
            meyveler_level1_cilekmavi.Enabled = false;
            meyveler_level1_cilekmaviimlec.Enabled = false;
            meyveler_level1_elmasari.Enabled = true;
            meyveler_level1_elmasariimlec.Enabled = true;
        }

        private void meyveler_level1_uzumsari_Click(object sender, EventArgs e)
        {
            meyveler_level1_elmasari.Visible = false;
            meyveler_level1_elmasariimlec.Visible = false;
            meyveler_level1_muzmavi.Enabled = true;
            meyveler_level1_muzmaviimlec.Enabled = true;
            meyveler_level1_cilekmavi.Enabled = true;
            ses.URL = "apple.mp3";
            if (meyveler_level1_cilekmavi.Visible == true)
            {
                meyveler_level1_cilekmaviimlec.Visible = true;
            }            
            if (meyveler_level1_muzmavi.Visible == true)
            {
                meyveler_level1_muzmaviimlec.Visible = true;
            }
            if(meyveler_level1_elmamavi.Visible == false && meyveler_level1_muzmavi.Visible == false && meyveler_level1_cilekmavi.Visible == false)
            {
                meyveler_level1_tik1.Visible = true;
            }

        }

        private void meyveler_level1_uzumsariimlec_Click(object sender, EventArgs e)
        {
            meyveler_level1_elmasari.Visible = false;
            meyveler_level1_elmasariimlec.Visible = false;
            meyveler_level1_muzmavi.Enabled = true;
            meyveler_level1_muzmaviimlec.Enabled = true;
            meyveler_level1_cilekmavi.Enabled = true;
            ses.URL = "apple.mp3";
            if (meyveler_level1_cilekmavi.Visible == true)
            {
                meyveler_level1_cilekmaviimlec.Visible = true;
            }
            if (meyveler_level1_muzmavi.Visible == true)
            {
                meyveler_level1_muzmaviimlec.Visible = true;
            }
            if (meyveler_level1_elmamavi.Visible == false && meyveler_level1_muzmavi.Visible == false && meyveler_level1_cilekmavi.Visible == false)
            {
                meyveler_level1_tik1.Visible = true;
            }
        }

        private void meyveler_level1_kavunmavi_Click(object sender, EventArgs e)
        {
            meyveler_level1_elmamaviimlec.Visible = false;
            meyveler_level1_cilekmaviimlec.Visible = false;
            meyveler_level1_elmamavi.Enabled = false;
            meyveler_level1_elmamaviimlec.Enabled = false;
            meyveler_level1_cilekmavi.Enabled = false;
            meyveler_level1_cilekmaviimlec.Enabled = false;
            meyveler_level1_muzmavi.Visible = false;
            meyveler_level1_muzmaviimlec.Visible = false;
            meyveler_level1_muzsari.BackColor = Color.Lime;
            meyveler_level1_muzsari.Enabled = true;
            meyveler_level1_muzsariimlec.Enabled = true;
            meyveler_level1_muzsariimlec.Visible = true;
        }

        private void meyveler_level1_kavunmaviimlec_Click(object sender, EventArgs e)
        {
            meyveler_level1_elmamaviimlec.Visible = false;
            meyveler_level1_cilekmaviimlec.Visible = false;
            meyveler_level1_elmamavi.Enabled = false;
            meyveler_level1_elmamaviimlec.Enabled = false;
            meyveler_level1_cilekmavi.Enabled = false;
            meyveler_level1_cilekmaviimlec.Enabled = false;
            meyveler_level1_muzmavi.Visible = false;
            meyveler_level1_muzmaviimlec.Visible = false;
            meyveler_level1_muzsari.BackColor = Color.Lime;
            meyveler_level1_muzsari.Enabled = true;
            meyveler_level1_muzsariimlec.Enabled = true;
            meyveler_level1_muzsariimlec.Visible = true;
        }

        private void meyveler_level1_kavunsari_Click(object sender, EventArgs e)
        {
            meyveler_level1_muzsari.Visible = false;
            meyveler_level1_muzsariimlec.Visible = false;
            meyveler_level1_cilekmavi.Enabled = true;
            meyveler_level1_cilekmaviimlec.Enabled = true;
            meyveler_level1_elmamavi.Enabled = true;
            meyveler_level1_elmamaviimlec.Enabled = true;
            ses.URL = "banana.mp3";
            if (meyveler_level1_elmamavi.Visible == true)
            {
                meyveler_level1_elmamaviimlec.Visible = true;
            }
            if (meyveler_level1_cilekmavi.Visible == true)
            {
                meyveler_level1_cilekmaviimlec.Visible = true;
            }
            if (meyveler_level1_elmamavi.Visible == false && meyveler_level1_muzmavi.Visible == false && meyveler_level1_cilekmavi.Visible == false)
            {
                meyveler_level1_tik1.Visible = true;
            }
        }

        private void meyveler_level1_kavunsariimlec_Click(object sender, EventArgs e)
        {
            meyveler_level1_muzsari.Visible = false;
            meyveler_level1_muzsariimlec.Visible = false;
            meyveler_level1_cilekmavi.Enabled = true;
            meyveler_level1_cilekmaviimlec.Enabled = true;
            meyveler_level1_elmamavi.Enabled = true;
            meyveler_level1_elmamaviimlec.Enabled = true;
            ses.URL = "banana.mp3";
            if (meyveler_level1_elmamavi.Visible == true)
            {
                meyveler_level1_elmamaviimlec.Visible = true;
            }
            if (meyveler_level1_cilekmavi.Visible == true)
            {
                meyveler_level1_cilekmaviimlec.Visible = true;
            }
            if (meyveler_level1_elmamavi.Visible == false && meyveler_level1_muzmavi.Visible == false && meyveler_level1_cilekmavi.Visible == false)
            {
                meyveler_level1_tik1.Visible = true;
            }
        }

        private void meyveler_level1_armutmavi_Click(object sender, EventArgs e)
        {
            meyveler_level1_cileksari.Enabled = true;
            meyveler_level1_cileksariimlec.Enabled = true;
            meyveler_level1_elmamavi.Enabled = false;
            meyveler_level1_elmamaviimlec.Enabled = false;
            meyveler_level1_muzmavi.Enabled = false;
            meyveler_level1_muzmaviimlec.Enabled = false;
            meyveler_level1_cilekmavi.Visible = false;
            meyveler_level1_cilekmaviimlec.Visible = false;
            meyveler_level1_cileksariimlec.Visible = true;
            meyveler_level1_cileksari.BackColor = Color.Lime;
            meyveler_level1_elmamaviimlec.Visible = false;
            meyveler_level1_muzmaviimlec.Visible = false;

        }

        private void meyveler_level1_armutmaviimlec_Click(object sender, EventArgs e)
        {
            meyveler_level1_cileksari.Enabled = true;
            meyveler_level1_cileksariimlec.Enabled = true;
            meyveler_level1_elmamavi.Enabled = false;
            meyveler_level1_elmamaviimlec.Enabled = false;
            meyveler_level1_muzmavi.Enabled = false;
            meyveler_level1_muzmaviimlec.Enabled = false;
            meyveler_level1_cilekmavi.Visible = false;
            meyveler_level1_cilekmaviimlec.Visible = false;
            meyveler_level1_cileksariimlec.Visible = true;
            meyveler_level1_cileksari.BackColor = Color.Lime;
            meyveler_level1_elmamaviimlec.Visible = false;
            meyveler_level1_muzmaviimlec.Visible = false;
        }

        private void meyveler_level1_armutsari_Click(object sender, EventArgs e)
        {
            meyveler_level1_cileksari.Visible = false;
            meyveler_level1_cileksariimlec.Visible = false;
            meyveler_level1_muzmavi.Enabled = true;
            meyveler_level1_muzmaviimlec.Enabled = true;
            meyveler_level1_elmamavi.Enabled = true;
            meyveler_level1_elmamaviimlec.Enabled = true;
            ses.URL = "strawberry.mp3";
            if (meyveler_level1_elmamavi.Visible == true)
            {
                meyveler_level1_elmamaviimlec.Visible = true;
            }
            if (meyveler_level1_muzmavi.Visible == true)
            {
                meyveler_level1_muzmaviimlec.Visible = true;
            }
            if (meyveler_level1_elmamavi.Visible == false && meyveler_level1_muzmavi.Visible == false && meyveler_level1_cilekmavi.Visible == false)
            {
                meyveler_level1_tik1.Visible = true;
            }
        }

        private void meyveler_level1_armutsariimlec_Click(object sender, EventArgs e)
        {
            meyveler_level1_cileksari.Visible = false;
            meyveler_level1_cileksariimlec.Visible = false;
            meyveler_level1_muzmavi.Enabled = true;
            meyveler_level1_muzmaviimlec.Enabled = true;
            meyveler_level1_elmamavi.Enabled = true;
            meyveler_level1_elmamaviimlec.Enabled = true;
            ses.URL = "strawberry.mp3";
            if (meyveler_level1_elmamavi.Visible == true)
            {
                meyveler_level1_elmamaviimlec.Visible = true;
            }
            if (meyveler_level1_muzmavi.Visible == true)
            {
                meyveler_level1_muzmaviimlec.Visible = true;
            }
            if (meyveler_level1_elmamavi.Visible == false && meyveler_level1_muzmavi.Visible == false && meyveler_level1_cilekmavi.Visible == false)
            {
                meyveler_level1_tik1.Visible = true;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            gosterilmeyecek1.Visible = false;
            gosterilmeyecek2.Visible = false;
            gosterilmeyecek3.Visible = false;
            gosterilmeyecek4.Visible = false;
            gosterilmeyecek5.Visible = false;
            gosterilmeyecek6.Visible = false;
            meyveler_level1_strawberry.Visible = false;
            meyveler_level1_apple.Visible = false;
            meyveler_level1_banana.Visible = false;
            meyveler_level1_tik1.Visible = false;
        }

        private void meyveler_level1_kirazmavi_Click(object sender, EventArgs e)
        {
            meyveler_level1_karpuzmavi.Enabled = false;
            meyveler_level1_portakalmavi.Enabled = false;
            meyveler_level1_kirazmavi.Visible = false;
            meyveler_level1_kirazsari.Enabled = true;
            meyveler_level1_kirazsari.BackColor = Color.Lime;
        }

        private void meyveler_level1_kirazsari_Click(object sender, EventArgs e)
        {
            meyveler_level1_kirazsari.Visible = false;
            meyveler_level1_karpuzmavi.Enabled = true;
            meyveler_level1_portakalmavi.Enabled = true;
            ses.URL = "cherry.mp3";
            if (meyveler_level1_karpuzmavi.Visible == false && meyveler_level1_kirazmavi.Visible == false && meyveler_level1_portakalmavi.Visible == false)
            {
                meyveler_level1_tik2.Visible = true;
            }
        }

        private void meyveler_level1_karpuzmavi_Click(object sender, EventArgs e)
        {
            meyveler_level1_kirazmavi.Enabled = false;
            meyveler_level1_portakalmavi.Enabled = false;
            meyveler_level1_karpuzmavi.Visible = false;
            meyveler_level1_karpuzsari.Enabled = true;
            meyveler_level1_karpuzsari.BackColor = Color.Lime;
        }

        private void meyveler_level1_karpuzsari_Click(object sender, EventArgs e)
        {
            meyveler_level1_karpuzsari.Visible = false;
            meyveler_level1_kirazmavi.Enabled = true;
            meyveler_level1_portakalmavi.Enabled = true;
            ses.URL = "watermelon.mp3";
            if(meyveler_level1_karpuzmavi.Visible == false && meyveler_level1_kirazmavi.Visible == false && meyveler_level1_portakalmavi.Visible == false)
            {
                meyveler_level1_tik2.Visible = true;
            }
        }

        private void meyveler_level1_portakalmavi_Click(object sender, EventArgs e)
        {
            meyveler_level1_karpuzmavi.Enabled = false;
            meyveler_level1_kirazmavi.Enabled = false;
            meyveler_level1_portakalmavi.Visible = false;
            meyveler_level1_portakalsari.Enabled = true;
            meyveler_level1_portakalsari.BackColor = Color.Lime;
        }

        private void meyveler_level1_portakalsari_Click(object sender, EventArgs e)
        {
            meyveler_level1_portakalsari.Visible = false;
            meyveler_level1_kirazmavi.Enabled = true;
            meyveler_level1_karpuzmavi.Enabled = true;
            ses.URL = "orange.mp3";
            if (meyveler_level1_karpuzmavi.Visible == false && meyveler_level1_kirazmavi.Visible == false && meyveler_level1_portakalmavi.Visible == false)
            {
                meyveler_level1_tik2.Visible = true;
            }
        }

        private void meyveler_level1_tik2_Click(object sender, EventArgs e)
        {
            gosterilmeyecek7.Visible = false;
            gosterilmeyecek8.Visible = false;
            gosterilmeyecek9.Visible = false;
            gosterilmeyecek10.Visible = false;
            gosterilmeyecek11.Visible = false;
            gosterilmeyecek12.Visible = false;
            meyveler_level1_cherry.Visible = false;
            meyveler_level1_watermelon.Visible = false;
            meyveler_level1_orange.Visible = false;
            meyveler_level1_tik2.Visible = false;
            
        }

        private void meyveler_level1_armutmavi_Click_1(object sender, EventArgs e)
        {
            meyveler_level1_uzummavi.Enabled = false;
            meyveler_level1_kavunmavi.Enabled = false;
            meyveler_level1_armutmavi.Visible = false;
            meyveler_level1_armutsari.Enabled = true;
            meyveler_level1_armutsari.BackColor = Color.Lime;
        }

        private void meyveler_level1_armutsari_Click_1(object sender, EventArgs e)
        {
            meyveler_level1_armutsari.Visible = false;
            meyveler_level1_kavunmavi.Enabled = true;
            meyveler_level1_uzummavi.Enabled = true;
            ses.URL = "pear.mp3";
            if (meyveler_level1_kavunmavi.Visible == false && meyveler_level1_uzummavi.Visible == false && meyveler_level1_armutmavi.Visible == false)
            {
                meyveler_level1_tik3.Visible = true;
                levels10.Visible = false;
            }

        }

        private void meyveler_level1_uzummavi_Click_1(object sender, EventArgs e)
        {
            meyveler_level1_kavunmavi.Enabled = false;
            meyveler_level1_armutmavi.Enabled = false;
            meyveler_level1_uzummavi.Visible = false;
            meyveler_level1_uzumsari.Enabled = true;
            meyveler_level1_uzumsari.BackColor = Color.Lime;
        }

        private void meyveler_level1_uzumsari_Click_1(object sender, EventArgs e)
        {
            meyveler_level1_uzumsari.Visible = false;
            meyveler_level1_kavunmavi.Enabled = true;
            meyveler_level1_armutmavi.Enabled = true;
            ses.URL = "grape.mp3";
            if (meyveler_level1_kavunmavi.Visible == false && meyveler_level1_uzummavi.Visible == false && meyveler_level1_armutmavi.Visible == false)
            {
                meyveler_level1_tik3.Visible = true;
                levels10.Visible = false;
            }
        }

        private void meyveler_level1_kavunsari_Click_1(object sender, EventArgs e)
        {
            meyveler_level1_kavunsari.Visible = false;
            meyveler_level1_uzummavi.Enabled = true;
            meyveler_level1_armutmavi.Enabled = true;
            ses.URL = "melon.mp3";
            if (meyveler_level1_kavunmavi.Visible == false && meyveler_level1_uzummavi.Visible == false && meyveler_level1_armutmavi.Visible == false)
            {
                meyveler_level1_tik3.Visible = true;
                levels10.Visible = false;
            }
        }

        private void meyveler_level1_kavunmavi_Click_1(object sender, EventArgs e)
        {
            meyveler_level1_uzummavi.Enabled = false;
            meyveler_level1_armutmavi.Enabled = false;
            meyveler_level1_kavunmavi.Visible = false;
            meyveler_level1_kavunsari.Enabled = true;
            meyveler_level1_kavunsari.BackColor = Color.Lime;
        }

        private void meyveler_level1_tik3_Click(object sender, EventArgs e)
        {
            meyveler_level1_tik3.Visible = false;
            gosterilmeyecek1.Visible = true;
            gosterilmeyecek2.Visible = true;
            gosterilmeyecek3.Visible = true;
            gosterilmeyecek4.Visible = true;
            gosterilmeyecek5.Visible = true;
            gosterilmeyecek6.Visible = true;
            gosterilmeyecek7.Visible = true;
            gosterilmeyecek8.Visible = true;
            gosterilmeyecek9.Visible = true;
            gosterilmeyecek10.Visible = true;
            gosterilmeyecek11.Visible = true;
            gosterilmeyecek12.Visible = true;
            meyveler_level1_armutmavi.Visible = true;
            meyveler_level1_armutsari.Visible = true;
            meyveler_level1_armutsari.Enabled = false;
            meyveler_level1_armutsari.BackColor = Color.Yellow;            

            meyveler_level1_cilekmavi.Visible = true;
            meyveler_level1_cileksari.Visible = true;
            meyveler_level1_cileksari.Enabled = false;
            meyveler_level1_cileksari.BackColor = Color.Yellow;
            meyveler_level1_strawberry.Visible = true;

            meyveler_level1_elmamavi.Visible = true;
            meyveler_level1_elmasari.Visible = true;
            meyveler_level1_elmasari.Enabled = false;
            meyveler_level1_elmasari.BackColor = Color.Yellow;
            meyveler_level1_apple.Visible = true;

            meyveler_level1_karpuzmavi.Visible = true;
            meyveler_level1_karpuzsari.Visible = true;
            meyveler_level1_karpuzsari.Enabled = false;
            meyveler_level1_karpuzsari.BackColor = Color.Yellow;
            meyveler_level1_watermelon.Visible = true;

            meyveler_level1_kavunmavi.Visible = true;
            meyveler_level1_kavunsari.Visible = true;
            meyveler_level1_kavunsari.Enabled = false;
            meyveler_level1_kavunsari.BackColor = Color.Yellow;
            
            meyveler_level1_kirazmavi.Visible = true;
            meyveler_level1_kirazsari.Visible = true;
            meyveler_level1_kirazsari.Enabled = false;
            meyveler_level1_kirazsari.BackColor = Color.Yellow;
            meyveler_level1_cherry.Visible = true;

            meyveler_level1_muzmavi.Visible = true;
            meyveler_level1_muzsari.Visible = true;
            meyveler_level1_muzsari.Enabled = false;
            meyveler_level1_muzsari.BackColor = Color.Yellow;
            meyveler_level1_banana.Visible = true;

            meyveler_level1_portakalmavi.Visible = true;
            meyveler_level1_portakalsari.Visible = true;
            meyveler_level1_portakalsari.Enabled = false;
            meyveler_level1_portakalsari.BackColor = Color.Yellow;
            meyveler_level1_orange.Visible = true;

            meyveler_level1_uzummavi.Visible = true;
            meyveler_level1_uzumsari.Visible = true;
            meyveler_level1_uzumsari.Enabled = false;
            meyveler_level1_uzumsari.BackColor = Color.Yellow;

            meyveler_level1_elmamaviimlec.Visible = true;
            meyveler_level1_cilekmaviimlec.Visible = true;
            meyveler_level1_muzmaviimlec.Visible = true;

            meyveler_level1_panel.Visible = false;
        }

        private void meyveler_level2_cevap1_Click(object sender, EventArgs e)
        {
            if (meyveler_level2_cevap1.Text == meyve_isimleri_ingilizce[meyveler_level2_rastgele_rakamlar[meyveler_level2_sayac - 1]])
            {
                meyveler_level2_resimler[meyveler_level2_rastgele_rakamlar[meyveler_level2_sayac - 1]].Visible = false;
                if (meyveler_level2_cevap1.Text == "Apple")
                {
                    ses.URL = "apple.mp3";
                }
                else if (meyveler_level2_cevap1.Text == "Pear")
                {
                    ses.URL = "pear.mp3";
                }
                else if (meyveler_level2_cevap1.Text == "Cherry")
                {
                    ses.URL = "cherry.mp3";
                }
                else if (meyveler_level2_cevap1.Text == "Strawberry")
                {
                    ses.URL = "strawberry.mp3";
                }
                else if (meyveler_level2_cevap1.Text == "Orange")
                {
                    ses.URL = "orange.mp3";
                }
                else if (meyveler_level2_cevap1.Text == "Watermelon")
                {
                    ses.URL = "watermelon.mp3";
                }
                else if (meyveler_level2_cevap1.Text == "Melon")
                {
                    ses.URL = "melon.mp3";
                }
                else if (meyveler_level2_cevap1.Text == "Banana")
                {
                    ses.URL = "banana.mp3";
                }
                else if (meyveler_level2_cevap1.Text == "Grape")
                {
                    ses.URL = "grape.mp3";
                }               
                meyveler_level2_rastgele();
            }
            else
            {
                can -= 1;
                if (can == -1)
                {
                    meyveler_level2_timer.Stop();
                    meyveler_level2_over.Visible = true;
                }
                meyveler_level2_can.Text = Convert.ToString(can);
                meyveler_level2_cevap1.BackColor = Color.Red;
            }
        }

        private void meyveler_level2_cevap2_Click(object sender, EventArgs e)
        {
            if (meyveler_level2_cevap2.Text == meyve_isimleri_ingilizce[meyveler_level2_rastgele_rakamlar[meyveler_level2_sayac - 1]])
            {
                meyveler_level2_resimler[meyveler_level2_rastgele_rakamlar[meyveler_level2_sayac - 1]].Visible = false;
                if (meyveler_level2_cevap2.Text == "Apple")
                {
                    ses.URL = "apple.mp3";
                }
                else if (meyveler_level2_cevap2.Text == "Pear")
                {
                    ses.URL = "pear.mp3";
                }
                else if (meyveler_level2_cevap2.Text == "Cherry")
                {
                    ses.URL = "cherry.mp3";
                }
                else if (meyveler_level2_cevap2.Text == "Strawberry")
                {
                    ses.URL = "strawberry.mp3";
                }
                else if (meyveler_level2_cevap2.Text == "Orange")
                {
                    ses.URL = "orange.mp3";
                }
                else if (meyveler_level2_cevap2.Text == "Watermelon")
                {
                    ses.URL = "watermelon.mp3";
                }
                else if (meyveler_level2_cevap2.Text == "Melon")
                {
                    ses.URL = "melon.mp3";
                }
                else if (meyveler_level2_cevap2.Text == "Banana")
                {
                    ses.URL = "banana.mp3";
                }
                else if (meyveler_level2_cevap2.Text == "Grape")
                {
                    ses.URL = "grape.mp3";
                }
                meyveler_level2_rastgele();
            }
            else
            {
                can -= 1;
                if (can == -1)
                {
                    meyveler_level2_timer.Stop();
                    meyveler_level2_over.Visible = true;
                }
                meyveler_level2_can.Text = Convert.ToString(can);
                meyveler_level2_cevap2.BackColor = Color.Red;
            }
        }

        private void meyveler_level3_mavisol_Click(object sender, EventArgs e)
        {
            meyveler_level3_mavisol.Visible = false;
            meyveler_level3_maviclick1.Visible = false;
            meyveler_level3_maviclick2.Visible = false;
            meyveler_level3_maviclick3.Visible = false;
            if ((meyveler_level3_mavisol.Visible == true && meyveler_level3_mavisag.Visible == true) || (meyveler_level3_mavisol.Visible == true && meyveler_level3_mavialt.Visible == true) || (meyveler_level3_mavisag.Visible == true && meyveler_level3_sarialt.Visible == true))
            {
                meyveler_level3_sariclick1.Visible = true;
                meyveler_level3_sariclick2.Visible = true;
                meyveler_level3_sariclick3.Visible = true;
            }            
            meyveler_level3_mavisag.Enabled = false;
            meyveler_level3_mavialt.Enabled = false;
            meyveler_level3_sariclick1.Enabled = true;
            meyveler_level3_sariclick2.Enabled = true;
            meyveler_level3_sariclick3.Enabled = true;
            meyveler_level3_sarisol.Enabled = true;
            meyveler_level3_sarisag.Enabled = true;
            meyveler_level3_sarialt.Enabled = true;
            meyveler_level3_mavi1.BackColor = Color.Red;
        }

        private void level3_ok1_Click(object sender, EventArgs e)
        {
            level3_ok1_timer.Start();
            hayvanlar_level3_timer.Stop();
        }        
        private void level3_ok1_timer_Tick(object sender, EventArgs e)
        {
            int i=0;
            hayvanlar_level3_ok1.Top -= 12;
            if(hayvanlar_level3_ok1.Top < 180)
            {
                level3_ok1_timer.Stop();
                hayvanlar_level3_ok1.Visible = false;                
                
                while (kontrol2 == 10)
                {
                    if (hayvanlar_level3_ok1.Visible == false && hayvanlar_level3_ok2.Visible == false && hayvanlar_level3_ok3.Visible == false && hayvanlar_level3_ok4.Visible == false && hayvanlar_level3_ok5.Visible == false)
                    {                       
                        hayvanlar_level3_timer.Stop();
                        hayvanlar_level3_passed.Visible = true;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
                if(hayvanlar_level3_passed.Visible == false)
                {
                    while (i < 10)
                    {
                        if (hayvanlar_level3_resimler[i].Location == hayvanlar_level3_resim_yerleri[0] && hayvanlar_level3_yazilar[i].Visible == true)
                        {
                            hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - 1]].Visible = false;
                            if (hayvanlar_level3_ok1.Visible == false && hayvanlar_level3_ok2.Visible == false && hayvanlar_level3_ok3.Visible == false && hayvanlar_level3_ok4.Visible == false && hayvanlar_level3_ok5.Visible == false)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    hayvanlar_level3_resimler[hayvanlar_level3_karisik_rakamlar[j]].Visible = false;
                                    hayvanlar_level3_oklar[j].Location = hayvanlar_level3_okbaslangiclari[j];
                                    hayvanlar_level3_oklar[j].Visible = true;
                                }                               
                                zaman = 5;
                                hayvanlar_level3_sure.Text = "5";
                                hayvanlar_level3_timer.Start();
                                hayvanlar_level3_rastgele();
                                break;
                            }
                            else
                            {
                                hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac]].Visible = true;
                                zaman = 5;
                                hayvanlar_level3_sure.Text = "5";
                                hayvanlar_level3_timer.Start();

                                hayvanlar_level3_sayac++;
                                break;
                            }
                        }
                        i++;
                        if (i == 10)
                        {
                            hayvanlar_level3_over.Visible = true;
                        }
                    }
                }
                int fark = 2;
                if (hayvanlar_level3_passed.Visible == true)
                {
                    fark = 1;
                }
                if (hayvanlar_level3_over.Visible == false)
                {
                    if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_cow_yazi)
                    {
                        ses.URL = "cow.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_horse_yazi)
                    {
                        ses.URL = "horse.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_cat_yazi)
                    {
                        ses.URL = "cat.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_dog_yazi)
                    {
                        ses.URL = "dog.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_bear_yazi)
                    {
                        ses.URL = "bear.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_spider_yazi)
                    {
                        ses.URL = "spider.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_chicken_yazi)
                    {
                        ses.URL = "chicken.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_turtle_yazi)
                    {
                        ses.URL = "turtle.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_mouse_yazi)
                    {
                        ses.URL = "mouse.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_rabbit_yazi)
                    {
                        ses.URL = "rabbit.mp3";
                    }
                }
            }        
        }

        private void level3_ok2_Click(object sender, EventArgs e)
        {
            level3_ok2_timer.Start();
            hayvanlar_level3_timer.Stop();
        }

        private void level3_ok3_Click(object sender, EventArgs e)
        {
            level3_ok3_timer.Start();
            hayvanlar_level3_timer.Stop();
        }

        private void level3_ok4_Click(object sender, EventArgs e)
        {
            level3_ok4_timer.Start();
            hayvanlar_level3_timer.Stop();
        }

        private void level3_ok5_Click(object sender, EventArgs e)
        {
            level3_ok5_timer.Start();
            hayvanlar_level3_timer.Stop();
        }

        private void level3_ok2_timer_Tick(object sender, EventArgs e)
        {
            int i = 0;
            hayvanlar_level3_ok2.Top -= 12;
            if (hayvanlar_level3_ok2.Top < 180)
            {
                level3_ok2_timer.Stop();
                hayvanlar_level3_ok2.Visible = false;
                
                while (kontrol2 == 10)
                {
                    if (hayvanlar_level3_ok1.Visible == false && hayvanlar_level3_ok2.Visible == false && hayvanlar_level3_ok3.Visible == false && hayvanlar_level3_ok4.Visible == false && hayvanlar_level3_ok5.Visible == false)
                    {                       
                        hayvanlar_level3_timer.Stop();
                        hayvanlar_level3_passed.Visible = true;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
                if (hayvanlar_level3_passed.Visible == false)
                {
                    while (i < 10)
                    {
                        if (hayvanlar_level3_resimler[i].Location == hayvanlar_level3_resim_yerleri[1] && hayvanlar_level3_yazilar[i].Visible == true)
                        {
                            hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - 1]].Visible = false;
                            if (hayvanlar_level3_ok1.Visible == false && hayvanlar_level3_ok2.Visible == false && hayvanlar_level3_ok3.Visible == false && hayvanlar_level3_ok4.Visible == false && hayvanlar_level3_ok5.Visible == false)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    hayvanlar_level3_resimler[hayvanlar_level3_karisik_rakamlar[j]].Visible = false;
                                    hayvanlar_level3_oklar[j].Location = hayvanlar_level3_okbaslangiclari[j];
                                    hayvanlar_level3_oklar[j].Visible = true;
                                }                                
                                zaman = 5;
                                hayvanlar_level3_sure.Text = "5";
                                hayvanlar_level3_timer.Start();
                                
                                hayvanlar_level3_rastgele();
                                break;
                            }
                            else
                            {
                                hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac]].Visible = true;
                                zaman = 5;
                                hayvanlar_level3_sure.Text = "5";
                                hayvanlar_level3_timer.Start();
                                if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - 1]].Visible == true)
                                {
                                    hayvanlar_level3_over.Visible = true;
                                }
                                hayvanlar_level3_sayac++;
                                break;
                            }
                        }
                        i++;
                        if (i == 10)
                        {
                            hayvanlar_level3_over.Visible = true;
                        }
                    }
                }
                int fark = 2;
                if (hayvanlar_level3_passed.Visible == true)
                {
                    fark = 1;
                }
                if (hayvanlar_level3_over.Visible == false)
                {
                    if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_cow_yazi)
                    {
                        ses.URL = "cow.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_horse_yazi)
                    {
                        ses.URL = "horse.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_cat_yazi)
                    {
                        ses.URL = "cat.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_dog_yazi)
                    {
                        ses.URL = "dog.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_bear_yazi)
                    {
                        ses.URL = "bear.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_spider_yazi)
                    {
                        ses.URL = "spider.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_chicken_yazi)
                    {
                        ses.URL = "chicken.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_turtle_yazi)
                    {
                        ses.URL = "turtle.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_mouse_yazi)
                    {
                        ses.URL = "mouse.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_rabbit_yazi)
                    {
                        ses.URL = "rabbit.mp3";
                    }
                }
            }
        }

        private void level3_ok3_timer_Tick(object sender, EventArgs e)
        {
            int i = 0;
            hayvanlar_level3_ok3.Top -= 12;
            if (hayvanlar_level3_ok3.Top < 180)
            {
                level3_ok3_timer.Stop();
                hayvanlar_level3_ok3.Visible = false;
                
                while (kontrol2 == 10)
                {
                    if (hayvanlar_level3_ok1.Visible == false && hayvanlar_level3_ok2.Visible == false && hayvanlar_level3_ok3.Visible == false && hayvanlar_level3_ok4.Visible == false && hayvanlar_level3_ok5.Visible == false)
                    {                       
                        hayvanlar_level3_timer.Stop();
                        hayvanlar_level3_passed.Visible = true;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
                if(hayvanlar_level3_passed.Visible == false)
                {
                    while (i < 10)
                    {
                        if (hayvanlar_level3_resimler[i].Location == hayvanlar_level3_resim_yerleri[2] && hayvanlar_level3_yazilar[i].Visible == true)
                        {
                            hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - 1]].Visible = false;
                            if (hayvanlar_level3_ok1.Visible == false && hayvanlar_level3_ok2.Visible == false && hayvanlar_level3_ok3.Visible == false && hayvanlar_level3_ok4.Visible == false && hayvanlar_level3_ok5.Visible == false)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    hayvanlar_level3_resimler[hayvanlar_level3_karisik_rakamlar[j]].Visible = false;
                                    hayvanlar_level3_oklar[j].Location = hayvanlar_level3_okbaslangiclari[j];
                                    hayvanlar_level3_oklar[j].Visible = true;
                                }           
                                zaman = 5;
                                hayvanlar_level3_sure.Text = "5";
                                hayvanlar_level3_timer.Start();
                                
                                hayvanlar_level3_rastgele();
                                break;
                            }
                            else
                            {
                                hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac]].Visible = true;
                                zaman = 5;
                                hayvanlar_level3_sure.Text = "5";
                                hayvanlar_level3_timer.Start();
                                if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - 1]].Visible == true)
                                {
                                    hayvanlar_level3_over.Visible = true;
                                }
                                hayvanlar_level3_sayac++;
                                break;
                            }
                        }
                        i++;
                        if (i == 10)
                        {
                            hayvanlar_level3_over.Visible = true;
                        }
                    }
                }
                int fark = 2;
                if (hayvanlar_level3_passed.Visible == true)
                {
                    fark = 1;
                }
                if (hayvanlar_level3_over.Visible == false)
                {
                    if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_cow_yazi)
                    {
                        ses.URL = "cow.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_horse_yazi)
                    {
                        ses.URL = "horse.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_cat_yazi)
                    {
                        ses.URL = "cat.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_dog_yazi)
                    {
                        ses.URL = "dog.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_bear_yazi)
                    {
                        ses.URL = "bear.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_spider_yazi)
                    {
                        ses.URL = "spider.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_chicken_yazi)
                    {
                        ses.URL = "chicken.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_turtle_yazi)
                    {
                        ses.URL = "turtle.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_mouse_yazi)
                    {
                        ses.URL = "mouse.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_rabbit_yazi)
                    {
                        ses.URL = "rabbit.mp3";
                    }
                }
            }
        }

        private void level3_ok4_timer_Tick(object sender, EventArgs e)
        {
            int i = 0;
            hayvanlar_level3_ok4.Top -= 12;
            if (hayvanlar_level3_ok4.Top < 180)
            {
                level3_ok4_timer.Stop();
                hayvanlar_level3_ok4.Visible = false;
                
                while (kontrol2 == 10)
                {
                    if (hayvanlar_level3_ok1.Visible == false && hayvanlar_level3_ok2.Visible == false && hayvanlar_level3_ok3.Visible == false && hayvanlar_level3_ok4.Visible == false && hayvanlar_level3_ok5.Visible == false)
                    {                        
                        hayvanlar_level3_timer.Stop();
                        hayvanlar_level3_passed.Visible = true;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
                if (hayvanlar_level3_passed.Visible == false)
                {
                    while (i < 10)
                    {
                        if (hayvanlar_level3_resimler[i].Location == hayvanlar_level3_resim_yerleri[3] && hayvanlar_level3_yazilar[i].Visible == true)
                        {
                            hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - 1]].Visible = false;
                            if (hayvanlar_level3_ok1.Visible == false && hayvanlar_level3_ok2.Visible == false && hayvanlar_level3_ok3.Visible == false && hayvanlar_level3_ok4.Visible == false && hayvanlar_level3_ok5.Visible == false)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    hayvanlar_level3_resimler[hayvanlar_level3_karisik_rakamlar[j]].Visible = false;
                                    hayvanlar_level3_oklar[j].Location = hayvanlar_level3_okbaslangiclari[j];
                                    hayvanlar_level3_oklar[j].Visible = true;
                                }
                                zaman = 5;
                                hayvanlar_level3_sure.Text = "5";
                                hayvanlar_level3_timer.Start();
                                
                                hayvanlar_level3_rastgele();
                                break;
                            }
                            else
                            {
                                hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac]].Visible = true;
                                zaman = 5;
                                hayvanlar_level3_sure.Text = "5";
                                hayvanlar_level3_timer.Start();
                                if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - 1]].Visible == true)
                                {
                                    hayvanlar_level3_over.Visible = true;
                                }
                                hayvanlar_level3_sayac++;
                                break;
                            }
                        }
                        i++;
                        if (i == 10)
                        {
                            hayvanlar_level3_over.Visible = true;
                        }
                    }
                }
                int fark = 2;
                if(hayvanlar_level3_passed.Visible == true)
                {
                    fark = 1;
                }
                if (hayvanlar_level3_over.Visible == false)
                {
                    if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_cow_yazi)
                    {
                        ses.URL = "cow.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_horse_yazi)
                    {
                        ses.URL = "horse.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_cat_yazi)
                    {
                        ses.URL = "cat.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_dog_yazi)
                    {
                        ses.URL = "dog.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_bear_yazi)
                    {
                        ses.URL = "bear.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_spider_yazi)
                    {
                        ses.URL = "spider.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_chicken_yazi)
                    {
                        ses.URL = "chicken.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_turtle_yazi)
                    {
                        ses.URL = "turtle.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_mouse_yazi)
                    {
                        ses.URL = "mouse.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_rabbit_yazi)
                    {
                        ses.URL = "rabbit.mp3";
                    }
                }
            }
        }

        private void level3_ok5_timer_Tick(object sender, EventArgs e)
        {
            int i = 0;
            hayvanlar_level3_ok5.Top -= 12;
            if (hayvanlar_level3_ok5.Top < 180)
            {
                level3_ok5_timer.Stop();
                hayvanlar_level3_ok5.Visible = false;
                
                while (kontrol2 == 10)
                {
                    if (hayvanlar_level3_ok1.Visible == false && hayvanlar_level3_ok2.Visible == false && hayvanlar_level3_ok3.Visible == false && hayvanlar_level3_ok4.Visible == false && hayvanlar_level3_ok5.Visible == false)
                    {                       
                        hayvanlar_level3_timer.Stop();
                        hayvanlar_level3_passed.Visible = true;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
                if (hayvanlar_level3_passed.Visible == false)
                {
                    while (i < 10)
                    {
                        if (hayvanlar_level3_resimler[i].Location == hayvanlar_level3_resim_yerleri[4] && hayvanlar_level3_yazilar[i].Visible == true)
                        {
                            hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - 1]].Visible = false;
                            if (hayvanlar_level3_ok1.Visible == false && hayvanlar_level3_ok2.Visible == false && hayvanlar_level3_ok3.Visible == false && hayvanlar_level3_ok4.Visible == false && hayvanlar_level3_ok5.Visible == false)
                            {
                                for (int j = 0; j < 5; j++)
                                {
                                    hayvanlar_level3_resimler[hayvanlar_level3_karisik_rakamlar[j]].Visible = false;
                                    hayvanlar_level3_oklar[j].Location = hayvanlar_level3_okbaslangiclari[j];
                                    hayvanlar_level3_oklar[j].Visible = true;
                                }
                                zaman = 5;
                                hayvanlar_level3_sure.Text = "5";
                                hayvanlar_level3_timer.Start();
                               
                                hayvanlar_level3_rastgele();
                                break;
                            }
                            else
                            {
                                hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac]].Visible = true;
                                zaman = 5;
                                hayvanlar_level3_sure.Text = "5";
                                hayvanlar_level3_timer.Start();
                                if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - 1]].Visible == true)
                                {
                                    hayvanlar_level3_over.Visible = true;
                                }
                                hayvanlar_level3_sayac++;
                                break;
                            }
                        }
                        i++;
                        if (i == 10)
                        {
                            hayvanlar_level3_over.Visible = true;
                        }
                    }
                }
                int fark = 2;
                if (hayvanlar_level3_passed.Visible == true)
                {
                    fark = 1;
                }
                if (hayvanlar_level3_over.Visible == false)
                {
                    if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_cow_yazi)
                    {
                        ses.URL = "cow.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_horse_yazi)
                    {
                        ses.URL = "horse.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_cat_yazi)
                    {
                        ses.URL = "cat.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_dog_yazi)
                    {
                        ses.URL = "dog.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_bear_yazi)
                    {
                        ses.URL = "bear.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_spider_yazi)
                    {
                        ses.URL = "spider.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_chicken_yazi)
                    {
                        ses.URL = "chicken.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_turtle_yazi)
                    {
                        ses.URL = "turtle.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_mouse_yazi)
                    {
                        ses.URL = "mouse.mp3";
                    }
                    else if (hayvanlar_level3_yazilar[hayvanlar_level3_karisik_rakamlar[hayvanlar_level3_sayac - fark]] == hayvanlar_level3_rabbit_yazi)
                    {
                        ses.URL = "rabbit.mp3";
                    }
                }
            }
        }
        private void hayvanlar_level2_cevap1_Click(object sender, EventArgs e)
        {
            if (hayvanlar_level2_cevap1.Text == hayvanlar_ingilizce[hayvanlar_level2_rastgele_rakamlar[hayvanlar_level2_sayac - 1]])
            {
                level2_hayvanlar[hayvanlar_level2_rastgele_rakamlar[hayvanlar_level2_sayac - 1]].Visible = false;
                if(hayvanlar_level2_cevap1.Text == "Cow")
                {
                    ses.URL = "cow.mp3";
                }
                else if(hayvanlar_level2_cevap1.Text == "Horse")
                {
                    ses.URL = "horse.mp3";
                }
                else if(hayvanlar_level2_cevap1.Text == "Cat")
                {
                    ses.URL = "cat.mp3";
                }
                else if(hayvanlar_level2_cevap1.Text == "Dog")
                {
                    ses.URL = "dog.mp3";
                }
                else if(hayvanlar_level2_cevap1.Text == "Bear")
                {
                    ses.URL = "bear.mp3";
                }
                else if(hayvanlar_level2_cevap1.Text == "Spider")
                {
                    ses.URL = "spider.mp3";
                }
                else if(hayvanlar_level2_cevap1.Text == "Chicken")
                {
                    ses.URL = "chicken.mp3";
                }
                else if(hayvanlar_level2_cevap1.Text == "Turtle")
                {
                    ses.URL = "turtle.mp3";
                }
                else if(hayvanlar_level2_cevap1.Text == "Mouse")
                {
                    ses.URL = "mouse.mp3";
                }
                else if(hayvanlar_level2_cevap1.Text == "Rabbit")
                {
                    ses.URL = "rabbit.mp3";
                }
                hayvanlar_level2_rastgele();                
            }
            else
            {
                hayvanlar_level2_cevap1.BackColor = Color.Red;
                can -= 1;
                if (can != -1)
                {
                    hayvanlar_level2_can.Text = Convert.ToString(can);
                }
                if (can == -1)
                {
                    hayvanlar_level2_timer.Stop();
                    hayvanlar_level2_over.Visible = true;                                     
                }
            }            
        }

        private void hayvanlar_level2_cevap2_Click(object sender, EventArgs e)
        {
            if (hayvanlar_level2_cevap2.Text == hayvanlar_ingilizce[hayvanlar_level2_rastgele_rakamlar[hayvanlar_level2_sayac - 1]])
            {
                level2_hayvanlar[hayvanlar_level2_rastgele_rakamlar[hayvanlar_level2_sayac - 1]].Visible = false;
                if (hayvanlar_level2_cevap2.Text == "Cow")
                {
                    ses.URL = "cow.mp3";
                }
                else if (hayvanlar_level2_cevap2.Text == "Horse")
                {
                    ses.URL = "horse.mp3";
                }
                else if (hayvanlar_level2_cevap2.Text == "Cat")
                {
                    ses.URL = "cat.mp3";
                }
                else if (hayvanlar_level2_cevap2.Text == "Dog")
                {
                    ses.URL = "dog.mp3";
                }
                else if (hayvanlar_level2_cevap2.Text == "Bear")
                {
                    ses.URL = "bear.mp3";
                }
                else if (hayvanlar_level2_cevap2.Text == "Spider")
                {
                    ses.URL = "spider.mp3";
                }
                else if (hayvanlar_level2_cevap2.Text == "Chicken")
                {
                    ses.URL = "chicken.mp3";
                }
                else if (hayvanlar_level2_cevap2.Text == "Turtle")
                {
                    ses.URL = "turtle.mp3";
                }
                else if (hayvanlar_level2_cevap2.Text == "Mouse")
                {
                    ses.URL = "mouse.mp3";
                }
                else if (hayvanlar_level2_cevap2.Text == "Rabbit")
                {
                    ses.URL = "rabbit.mp3";
                }
                hayvanlar_level2_rastgele();
            }
            else
            {
                hayvanlar_level2_cevap2.BackColor = Color.Red;
                can -= 1;
                if (can != -1)
                {
                    hayvanlar_level2_can.Text = Convert.ToString(can);
                }

                if (can == -1)
                {
                    hayvanlar_level2_timer.Stop();
                    hayvanlar_level2_over.Visible = true;                                   
                }
            }
        }

        private void level1_ok1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                hayvanlar_level1_yazilar[i].Visible = false;
            }
            level1_ok1_timer.Start();
        }

        private void level1_ok1_timer_Tick(object sender, EventArgs e)
        {
            level1_ok1.Top -= 13;
            if(level1_ok1.Top < 180)
            {
                level1_ok1_timer.Stop();
                level1_ok1.Visible = false;
                hayvanlar_level1_yazilar[0 + fark].Visible = true;
                if(fark == 0)
                {
                    ses.URL = "cat.mp3";
                }
                else
                {
                    ses.URL = "horse.mp3";
                }
                if (level1_ok1.Visible == false && level1_ok2.Visible == false && level1_ok3.Visible == false && level1_ok4.Visible == false && level1_ok5.Visible == false)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        hayvanlar_level1_resimler[j].Visible = false;
                    }
                    fark += 5;
                    for (int i = 0; i < 5; i++)
                    {
                        hayvanlar_level1_oklar[i].Location = hayvanlar_level3_okbaslangiclari[i];
                        if (fark != 10)
                        {
                            hayvanlar_level1_oklar[i].Visible = true;
                        }
                    }

                    if(fark == 10)
                    {
                        button18.Visible = true;
                        levels1.Visible = false;
                    }
                }
            }
        }

        private void level1_ok2_timer_Tick(object sender, EventArgs e)
        {
            level1_ok2.Top -= 13;
            if (level1_ok2.Top < 180)
            {
                level1_ok2_timer.Stop();
                level1_ok2.Visible = false;
                hayvanlar_level1_yazilar[1 + fark].Visible = true;
                if(fark == 0)
                {
                    ses.URL = "dog.mp3";
                }
                else
                {
                    ses.URL = "chicken.mp3";
                }
                if (level1_ok1.Visible == false && level1_ok2.Visible == false && level1_ok3.Visible == false && level1_ok4.Visible == false && level1_ok5.Visible == false)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        hayvanlar_level1_resimler[j].Visible = false;
                    }
                    fark += 5;
                    for (int i = 0; i < 5; i++)
                    {
                        hayvanlar_level1_oklar[i].Location = hayvanlar_level3_okbaslangiclari[i];
                        if (fark != 10)
                        {
                            hayvanlar_level1_oklar[i].Visible = true;
                        }
                    }

                    if (fark == 10)
                    {
                        button18.Visible = true;
                        levels1.Visible = false;
                    }
                }
            }
        }

        private void level1_ok2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                hayvanlar_level1_yazilar[i].Visible = false;
            }
            level1_ok2_timer.Start();
        }

        private void level1_ok3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                hayvanlar_level1_yazilar[i].Visible = false;
            }
            level1_ok3_timer.Start();
        }

        private void level1_ok3_timer_Tick(object sender, EventArgs e)
        {
            level1_ok3.Top -= 13;
            if (level1_ok3.Top < 180)
            {
                level1_ok3_timer.Stop();
                level1_ok3.Visible = false;
                hayvanlar_level1_yazilar[2 + fark].Visible = true;
                if (fark == 0)
                {
                    ses.URL = "cow.mp3";
                }
                else
                {
                    ses.URL = "bear.mp3";
                }
                if (level1_ok1.Visible == false && level1_ok2.Visible == false && level1_ok3.Visible == false && level1_ok4.Visible == false && level1_ok5.Visible == false)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        hayvanlar_level1_resimler[j].Visible = false;
                    }
                    fark += 5;
                    for (int i = 0; i < 5; i++)
                    {
                        hayvanlar_level1_oklar[i].Location = hayvanlar_level3_okbaslangiclari[i];
                        if (fark != 10)
                        {
                            hayvanlar_level1_oklar[i].Visible = true;
                        }                        
                    }

                    if (fark == 10)
                    {
                        button18.Visible = true;
                        levels1.Visible = false;
                    }
                }
            }
        }

        private void level1_ok4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                hayvanlar_level1_yazilar[i].Visible = false;
            }
            level1_ok4_timer.Start();
        }

        private void level1_ok4_timer_Tick(object sender, EventArgs e)
        {
            level1_ok4.Top -= 13;
            if (level1_ok4.Top < 180)
            {
                level1_ok4_timer.Stop();
                level1_ok4.Visible = false;
                hayvanlar_level1_yazilar[3 + fark].Visible = true;
                if(fark == 0)
                {
                    ses.URL = "rabbit.mp3";
                }
                else
                {
                    ses.URL = "spider.mp3";
                }
                if (level1_ok1.Visible == false && level1_ok2.Visible == false && level1_ok3.Visible == false && level1_ok4.Visible == false && level1_ok5.Visible == false)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        hayvanlar_level1_resimler[j].Visible = false;
                    }
                    fark += 5;
                    for (int i = 0; i < 5; i++)
                    {
                        hayvanlar_level1_oklar[i].Location = hayvanlar_level3_okbaslangiclari[i];
                        if (fark != 10)
                        {
                            hayvanlar_level1_oklar[i].Visible = true;
                        }
                    }

                    if (fark == 10)
                    {
                        button18.Visible = true;
                        levels1.Visible = false;
                    }
                }
            }
        }

        private void level1_ok5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                hayvanlar_level1_yazilar[i].Visible = false;
            }
            level1_ok5_timer.Start();
        }

        private void level1_ok5_timer_Tick(object sender, EventArgs e)
        {
            level1_ok5.Top -= 13;
            if (level1_ok5.Top < 180)
            {
                level1_ok5_timer.Stop();
                level1_ok5.Visible = false;
                hayvanlar_level1_yazilar[4 + fark].Visible = true;
                if(fark == 0)
                {
                    ses.URL = "turtle.mp3";
                }
                else
                {
                    ses.URL = "mouse.mp3";
                }
                if (level1_ok1.Visible == false && level1_ok2.Visible == false && level1_ok3.Visible == false && level1_ok4.Visible == false && level1_ok5.Visible == false)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        hayvanlar_level1_resimler[j].Visible = false;
                    }
                    fark += 5;
                    for (int i = 0; i < 5; i++)
                    {
                        hayvanlar_level1_oklar[i].Location = hayvanlar_level3_okbaslangiclari[i];
                        if (fark != 10)
                        {
                            hayvanlar_level1_oklar[i].Visible = true;
                        }
                    }

                    if (fark == 10)
                    {
                        button18.Visible = true;
                        levels1.Visible = false;
                    }
                }
            }
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            hayvanlar_level1_panel.Visible = false;
        }

        private void hayvanlar_level2_timer_Tick(object sender, EventArgs e)
        {
            zaman -= 1;            
            if (zaman != -1)
            {
                hayvanlar_level2_sure.Text = Convert.ToString(zaman);
            }
            else
            {
                hayvanlar_level2_timer.Stop();
                hayvanlar_level2_over.Visible = true;
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            hayvanlar_level2_over.Visible = false;
            hayvanlar_level2_panel.Visible = true;
            hayvanlar_level2_sayac = 0;
            for (int i = 0; i < 10; i++)
            {
                level2_hayvanlar[i].Visible = false;
            }
            hayvanlar_level2_sure.Text = "90";
            hayvanlar_level2_can.Text = "2";
            zaman = 90;
            can = 2;
            hayvanlar_level2_timer.Start();
            hayvanlar_level2_rastgele_rakamlar = hayvanlar_level3_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            hayvanlar_level2_rastgele();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            hayvanlar_level2_over.Visible = false;
            hayvanlar_level2_panel.Visible = false;
            hayvanlar_level2_timer.Stop();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            hayvanlar_level2_passed.Visible = false;
            hayvanlar_level2_panel.Visible = false;
            hayvanlar_level2_timer.Stop();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            hayvanlar_level2_passed.Visible = false;
            hayvanlar_level2_panel.Visible = false;
            hayvanlar_level3_panel.Visible = true;          
            hayvanlar_level3_karisik_rakamlar = hayvanlar_level3_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            hayvanlar_level3_sayac = 0;
            kontrol2 = 0;
            zaman = 5;
            hayvanlar_level3_sure.Text = "5";
            hayvanlar_level3_timer.Start();
            for (int i = 0; i < 5; i++)
            {
                hayvanlar_level3_oklar[i].Location = hayvanlar_level3_okbaslangiclari[i];
                hayvanlar_level3_oklar[i].Visible = true;
                hayvanlar_level3_resimler[i].Visible = false;
                hayvanlar_level3_resimler[i + 5].Visible = false;
                hayvanlar_level3_yazilar[i].Visible = false;
                hayvanlar_level3_yazilar[i + 5].Visible = false;
            }
            hayvanlar_level3_rastgele();
        }

        private void hayvanlar_level3_timer_Tick(object sender, EventArgs e)
        {
            zaman -= 1;            
            if (zaman != -1)
            {
                hayvanlar_level3_sure.Text = Convert.ToString(zaman);
            }
            else
            {
                hayvanlar_level3_timer.Stop();
                hayvanlar_level3_over.Visible = true;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            hayvanlar_level3_over.Visible = false;
            hayvanlar_level3_panel.Visible = true;
            hayvanlar_level3_karisik_rakamlar = hayvanlar_level3_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            hayvanlar_level3_sayac = 0;
            kontrol2 = 0;
            zaman = 5;
            hayvanlar_level3_sure.Text = "5";
            hayvanlar_level3_timer.Start();
            for (int i = 0; i < 5; i++)
            {
                hayvanlar_level3_oklar[i].Location = hayvanlar_level3_okbaslangiclari[i];
                hayvanlar_level3_oklar[i].Visible = true;
                hayvanlar_level3_resimler[i].Visible = false;
                hayvanlar_level3_resimler[i + 5].Visible = false;
                hayvanlar_level3_yazilar[i].Visible = false;
                hayvanlar_level3_yazilar[i + 5].Visible = false;
            }
            hayvanlar_level3_rastgele();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            hayvanlar_level3_over.Visible = false;
            hayvanlar_level3_panel.Visible = false;
            hayvanlar_level3_timer.Stop();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            hayvanlar_level3_passed.Visible = false;
            hayvanlar_level3_panel.Visible = false;
            hayvanlar_level3_timer.Stop();
        }

        private void renkler_level2_timer_Tick(object sender, EventArgs e)
        {
            zaman -= 1;
            renkler_level2_sure.Text = Convert.ToString(zaman);
            if(zaman == 0)
            {
                renkler_level2_timer.Stop();
                renkler_level2_over.Visible = true;
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            renkler_level2_over.Visible = false;
            renkler_level2_panel.Visible = true;
            renkler_level2_sayac = 0;
            renkler_level3_rastgele_rakamlar = renkler_level3_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            zaman = 90;
            can = 2;
            renkler_level2_can.Text = "2";
            renkler_level2_sure.Text = "90";
            renkler_level2_timer.Start();
            for (int i = 0; i < 10; i++)
            {
                renkler_level2_nesneler[i].Visible = false;
            }
            rastgele_renk_level2();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            renkler_level2_over.Visible = false;
            renkler_level2_panel.Visible = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            renkler_level2_passed.Visible = false;
            renkler_level2_panel.Visible = false;
        }

        private void renkler_level3_timer_Tick(object sender, EventArgs e)
        {
            zaman -= 1;
            if(zaman != -1)
            {
                renkler_level3_sure.Text = Convert.ToString(zaman);
            }
            else
            {
                renkler_level3_timer.Stop();
                renkler_level3_over.Visible = true;
            }
            
        }

        private void button42_Click(object sender, EventArgs e)
        {
            renkler_level3_over.Visible = false;            
            renkler_level3_yazi.Visible = true;
            zaman = 5;
            renkler_level3_sure.Text = "5";
            renkler_level3_timer.Start();
            for (int i = 0; i < 10; i++)
            {
                level3_renkler[i].Visible = false;
            }
            renkler_level3_kontrol.Clear();
            rastgele_renkyazi();            
        }

        private void button41_Click(object sender, EventArgs e)
        {
            renkler_level3_over.Visible = false;
            renkler_level3_panel.Visible = false;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            renkler_level3_passed.Visible = false;
            renkler_level3_panel.Visible = false;
        }

        private void button33_Click(object sender, EventArgs e)
        {           
            renkler_level2_panel.Visible = false;
            renkler_level2_passed.Visible = false;
            renkler_level3_panel.Visible = true;
            renkler_level3_yazi.Visible = true;
            zaman = 5;
            renkler_level3_sure.Text = "5";
            renkler_level3_timer.Start();
            for (int i = 0; i < 10; i++)
            {
                level3_renkler[i].Visible = false;
            }
            renkler_level3_kontrol.Clear();
            rastgele_renkyazi();
        }

        private void bodyparts_level1_tik_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                bodyparts_level1_yazilar[i].Visible = false;
                bodyparts_level1_butonlar[i].Enabled = true;
            }
            bodyparts_level1_panel.Visible = false;
            bodyparts_level1_tik.Visible = false;


        }

        private void button46_Click(object sender, EventArgs e)
        {
            zaman = 90;
            can = 2;
            bodyparts_level2_can.Text = "2";
            bodyparts_level2_sure.Text = "90";
            button5.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            body_level2_resim.Image = Properties.Resources.body_level2_1;
            body_level2_yazi.Text = "Hair";
            bodyparts_level2_timer.Start();
            bodyparts_level2_over.Visible = false;
        }

        private void bodyparts_level2_timer_Tick(object sender, EventArgs e)
        {
            zaman -= 1;
            if (zaman != -1)
            {
                bodyparts_level2_sure.Text = Convert.ToString(zaman);
            }
            else
            {
                bodyparts_level2_timer.Stop();
                bodyparts_level2_over.Visible = true;
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            bodyparts_level2_over.Visible = false;
            body_level2_panel.Visible = false;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            bodyparts_level2_passed.Visible = false;
            body_level2_panel.Visible = false;
        }

        private void bodyparts_level3_timer_Tick(object sender, EventArgs e)
        {
            zaman -= 1;
            if (zaman != -1)
            {
                bodyparts_level3_sure.Text = Convert.ToString(zaman);
            }
            else
            {
                bodyparts_level3_timer.Stop();
                bodyparts_level3_over.Visible = true;
            }

        }

        private void button50_Click(object sender, EventArgs e)
        {
            body_level3_karisik_rakamlar = body_level3_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            body_level3_sayac = 0;
            zaman = 5;
            bodyparts_level3_sure.Text = "5";
            bodyparts_level3_over.Visible = false;
            for (int i = 0; i < 12; i++)
            {
                body_level3_labellar[i].Visible = false;
                body_level3_resimler[i].Visible = false;
            }
            bodyparts_level3_timer.Start();
            body_level3_rastgele();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            bodyparts_level3_over.Visible = false;
            body_level3_panel.Visible = false;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            body_level3_panel.Visible = false;
            bodyparts_level3_passed.Visible = false;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            bodyparts_level2_passed.Visible = false;
            body_level2_panel.Visible = false;
            body_level3_panel.Visible = true;
            body_level3_karisik_rakamlar = body_level3_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            body_level3_sayac = 0;
            zaman = 5;
            bodyparts_level3_sure.Text = "5";
            for (int i = 0; i < 12; i++)
            {
                body_level3_labellar[i].Visible = false;
                body_level3_resimler[i].Visible = false;
            }

            bodyparts_level3_timer.Start();
            body_level3_rastgele();
        }

        private void meyveler_level2_timer_Tick(object sender, EventArgs e)
        {
            zaman -= 1;
            if(zaman != -1)
            {
                meyveler_level2_sure.Text = Convert.ToString(zaman);
            }
            else
            {
                meyveler_level2_timer.Stop();
                meyveler_level2_over.Visible = true;
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            meyveler_level2_sayac = 0;
            zaman = 90;
            can = 2;
            meyveler_level2_sure.Text = "90";
            meyveler_level2_can.Text = "2";
            for (int i = 0; i < 8; i++)
            {
                meyveler_level2_resimler[i].Visible = false;
            }
            meyveler_level2_rastgele_rakamlar = meyveler_level2_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            meyveler_level2_over.Visible = false;
            meyveler_level2_timer.Start();
            meyveler_level2_rastgele();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            meyveler_level2_passed.Visible = false;
            meyveler_level2_panel.Visible = false;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            meyveler_level2_passed.Visible = false;
            meyveler_level2_panel.Visible = false;
        }

        private void meyveler_level3_timer_Tick(object sender, EventArgs e)
        {
            zaman -= 1;
            if (zaman != -1)
            {
                meyveler_level3_sure.Text = Convert.ToString(zaman);
            }
            else
            {
                meyveler_level3_timer.Stop();
                meyveler_level3_over.Visible = true;
            }
            
        }

        private void button58_Click(object sender, EventArgs e)
        {
            meyveler_level3_over.Visible = false;
            kontrol1 = 0;
            meyveler_level3_sayac = 0;
            meyveler_level3_karisik_rakamlar = meyveler_level2_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            zaman = 5;
            meyveler_level3_sure.Text = "5";
            for (int i = 0; i < 3; i++)
            {
                meyveler_level3_resimpicturebox[i].BackColor = Color.White;
                meyveler_level3_yazipicturebox[i].BackColor = Color.White;
            }
            meyveler_level3_mavisol.Visible = true;
            meyveler_level3_mavisag.Visible = true;
            meyveler_level3_mavialt.Visible = true;
            meyveler_level3_sarisol.Visible = true;
            meyveler_level3_sarisag.Visible = true;
            meyveler_level3_sarialt.Visible = true;
            meyveler_level3_dogru.Visible = false;
            meyveler_level3_yanlis.Visible = false;
            meyveler_level3_mavisol.Enabled= true;
            meyveler_level3_mavisag.Enabled = true;
            meyveler_level3_mavialt.Enabled = true;
            meyveler_level3_sarisol.Enabled = false;
            meyveler_level3_sarisag.Enabled = false;
            meyveler_level3_sarialt.Enabled = false;
            meyveler_level3_rastgele();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            meyveler_level3_over.Visible = false;
            meyveler_level3_panel.Visible = false;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            meyveler_level3_passed.Visible = false;
            meyveler_level3_panel.Visible = false;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            meyveler_level2_passed.Visible = false;
            meyveler_level2_panel.Visible = false;
            meyveler_level3_panel.Visible = true;
            kontrol1 = 0;
            meyveler_level3_sayac = 0;
            meyveler_level3_karisik_rakamlar = meyveler_level2_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            zaman = 5;
            meyveler_level3_sure.Text = "5";
            for (int i = 0; i < 3; i++)
            {
                meyveler_level3_resimpicturebox[i].BackColor = Color.White;
                meyveler_level3_yazipicturebox[i].BackColor = Color.White;
            }
            meyveler_level3_mavisol.Visible = true;
            meyveler_level3_mavisag.Visible = true;
            meyveler_level3_mavialt.Visible = true;
            meyveler_level3_sarisol.Visible = true;
            meyveler_level3_sarisag.Visible = true;
            meyveler_level3_sarialt.Visible = true;
            meyveler_level3_dogru.Visible = false;
            meyveler_level3_yanlis.Visible = false;
            meyveler_level3_mavisol.Enabled = true;
            meyveler_level3_mavisag.Enabled = true;
            meyveler_level3_mavialt.Enabled = true;
            meyveler_level3_sarisol.Enabled = false;
            meyveler_level3_sarisag.Enabled = false;
            meyveler_level3_sarialt.Enabled = false;
            meyveler_level3_maviclick1.Visible = true;
            meyveler_level3_maviclick1.Enabled = true;
            meyveler_level3_maviclick2.Visible = true;
            meyveler_level3_maviclick2.Enabled = true;
            meyveler_level3_maviclick3.Visible = true;
            meyveler_level3_maviclick3.Enabled = true;
            meyveler_level3_rastgele();
        }

        private void ulkeler_level1_tik_Click(object sender, EventArgs e)
        {
            ulkeler_level1_panel.Visible = false;
            ulke_isimleri.Location = ulkeler_level1_yazibaslangic;
            ulkeler_level1_kontrol = 0;           
            ulkeler_level1_turkiye.Location = turkiye_baslangic;
            ulkeler_level1_ispanya.Location = ispanya_baslangic;
            ulkeler_level1_fransa.Location = fransa_baslangic;
            ulkeler_level1_polonya.Location = polonya_baslangic;
            ulkeler_level1_almanya.Location = almanya_baslangic;
            ulkeler_level1_japonya.Location = japonya_baslangic;
            ulkeler_level1_ingiltere.Location = ingiltere_baslangic;
            ulkeler_level1_italya.Location = italya_baslangic;
            ulkeler_level1_portekiz.Location = portekiz_baslangic;
            ulkeler_level1_cin.Location = cin_baslangic;
            ulkeler_level1_turkiye.Visible = true;
            ulkeler_level1_ispanya.Visible = true;
            ulkeler_level1_fransa.Visible = true;
            ulkeler_level1_polonya.Visible = true;
            ulkeler_level1_almanya.Visible = true;
            ulkeler_level1_japonya.Visible = true;
            ulkeler_level1_ingiltere.Visible = true;
            ulkeler_level1_italya.Visible = true;
            ulkeler_level1_portekiz.Visible = true;
            ulkeler_level1_cin.Visible = true;
            ulkeler_level1_tik.Visible = false;
            ulke_isimleri.Text = "";
        }

        private void ulkeler_level2_timer_Tick(object sender, EventArgs e)
        {
            zaman -= 1;
            if(zaman != -1)
            {
                ulkeler_level2_sure.Text = Convert.ToString(zaman);
            }
            else
            {
                ulkeler_level2_timer.Stop();
                ulkeler_level2_over.Visible = true;
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            ulkeler_level2_over.Visible = false;
            ulkeler_level2_karisik1 = ulkeler_level2_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            ulkeler_level2_karisik2 = ulkeler_level2_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            ulkeler_level2_sayac = 0;
            for (int i = 0; i < 10; i++)
            {
                ulkeler_level2_butonlar[i].Visible = true;
                level2_ulkeler[i].Visible = false;
            }
            zaman = 90;
            can = 2;
            ulkeler_level2_sure.Text = "90";
            ulkeler_level2_can.Text = "2";
            ulkeler_level2_timer.Start();
            ulkeler_level2_rastgele();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            ulkeler_level2_over.Visible = false;
            ulkeler_level2_panel.Visible = false;
        }

        private void button59_Click(object sender, EventArgs e)
        {
            ulkeler_level2_passed.Visible = false;
            ulkeler_level2_panel.Visible = false;
        }

        private void ulkeler_level3_timer_Tick(object sender, EventArgs e)
        {
            zaman -= 1;
            if(zaman != -1)
            {
                ulkeler_level3_sure.Text = Convert.ToString(zaman);
            }
            else
            {
                ulkeler_level3_timer.Stop();
                ulkeler_level3_over.Visible = true;
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            ulkeler_level3_over.Visible = false;
            ulkeler_level3_karisik_rakamlar = renkler_level3_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            ulkeler_level3_sayac = 0;
            for (int i = 0; i < 10; i++)
            {
                level3_ulkeler[i].Visible = false;
            }
            zaman = 5;
            ulkeler_level3_sure.Text = "5";
            ulkeler_level3_timer.Start();
            ulkeler_level3_rastgele();
        }

        private void button65_Click(object sender, EventArgs e)
        {
            ulkeler_level3_over.Visible = false;
            ulkeler_level3_panel.Visible = false;
        }

        private void button63_Click(object sender, EventArgs e)
        {
            ulkeler_level3_passed.Visible = false;
            ulkeler_level3_panel.Visible = false;
        }

        private void button60_Click(object sender, EventArgs e)
        {
            ulkeler_level2_passed.Visible = false;
            ulkeler_level2_panel.Visible = false;
            ulkeler_level3_panel.Visible = true;
            ulkeler_level3_karisik_rakamlar = renkler_level3_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            ulkeler_level3_sayac = 0;
            for (int i = 0; i < 10; i++)
            {
                level3_ulkeler[i].Visible = false;
            }
            zaman = 5;
            ulkeler_level3_sure.Text = "5";
            ulkeler_level3_timer.Start();
            ulkeler_level3_rastgele();
        }

        private void sayilar_level3_timer_Tick(object sender, EventArgs e)
        {
            zaman -= 1;
            if (zaman != -1)
            {
                sayilar_level3_sure.Text = Convert.ToString(zaman);
            }
            else
            {
                sayilar_level3_timer.Stop();
                sayilar_level3_over.Visible = true;
            }

        }

        private void button74_Click(object sender, EventArgs e)
        {
            sayilar_level3_over.Visible = false;
            sayilar_level3_rastgele_rakamlar = sayilar_level3_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            sayilar_level3_sayac = 0;
            zaman = 5;
            sayilar_level3_sure.Text = "5";
            sayilar_level3_timer.Start();
            for (int i = 0; i < 19; i++)
            {
                sayilar_level3[i].Visible = false;
            }
            sayilar_level3_rastgele();
        }

        private void button73_Click(object sender, EventArgs e)
        {
            sayilar_level3_over.Visible = false;
            sayilar_level3_panel.Visible = false;
        }

        private void button71_Click(object sender, EventArgs e)
        {
            sayilar_level3_passed.Visible = false;
            sayilar_level3_panel.Visible = false;
        }

        private void sayilar_level2_timer_Tick(object sender, EventArgs e)
        {
            zaman -= 1;
            if (zaman != -1)
            {
                sayilar_level2_sure.Text = Convert.ToString(zaman);
            }
            else
            {
                sayilar_level2_timer.Stop();
                sayilar_level2_over.Visible = true;
            }
        }

        private void button70_Click(object sender, EventArgs e)
        {
            sayilar_level2_over.Visible = false;
            sayilar_level2_sayac = 0;
            zaman = 90;
            can = 2;
            sayilar_level2_sure.Text = "90";
            sayilar_level2_can.Text = "2";
            sayilar_level2_timer.Start();
            for (int i = 0; i < 19; i++)
            {
                sayilar_level2[i].Visible = false;
            }
            ust_buton.BackColor = Color.White;
            alt_buton.BackColor = Color.White;
            rastgele_rakamlar_sayilar_level2 = rakamlar_sayilar_level2.OrderBy(x => Guid.NewGuid()).ToList();
            sayilar_level2_bolumler();
        }

        private void button69_Click(object sender, EventArgs e)
        {
            sayilar_level2_over.Visible = false;
            sayilar_level2_panel.Visible = false;
        }

        private void button67_Click(object sender, EventArgs e)
        {            
            sayilar_level2_passed.Visible = false;
            sayilar_level2_panel.Visible = false;
        }

        private void button68_Click(object sender, EventArgs e)
        {
            sayilar_level2_passed.Visible = false;
            sayilar_level2_panel.Visible = false;
            sayilar_level3_panel.Visible = true;
            sayilar_level3_rastgele_rakamlar = sayilar_level3_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            sayilar_level3_sayac = 0;
            zaman = 5;
            sayilar_level3_sure.Text = "5";
            sayilar_level3_timer.Start();
            for (int i = 0; i < 19; i++)
            {
                sayilar_level3[i].Visible = false;
            }
            sayilar_level3_rastgele();
        }

        private void sayilar_level1_tik_Click(object sender, EventArgs e)
        {
            sayilar_level1_tik.Visible = false;
            sayilar_level1_panel.Visible = false;
            sayilar_level1_panel.BackgroundImage = Properties.Resources.foto_1;
            level1_one2.Visible = false;
            level1_two2.Visible = false;
            level1_six2.Visible = false;
            level1_seven2.Visible = false;
            level1_three2.Visible = false;
            level1_eight2.Visible = false;
            level1_nine2.Visible = false;
            level1_four2.Visible = false;
            level1_five2.Visible = false;
            level1_ten2.Visible = false;
            level1_ten1.Visible = false;
            level1_nine1.Visible = false;
            level1_eight1.Visible = false;
            level1_seven1.Visible = false;
            level1_six1.Visible = false;
            level1_one1.Visible = true;
            level1_one1.Text = "one";
            level1_two1.Visible = true;
            level1_two1.Text = "two";
            level1_three1.Visible = true;
            level1_three1.Text = "three";
            level1_four1.Visible = true;
            level1_four1.Text = "four";
            level1_five1.Visible = true;
            level1_five1.Text = "five";
        }

        private void levels1_Click(object sender, EventArgs e)
        {
            hayvanlar_level1_panel.Visible = false;            
            for (int i = 0; i < 5; i++)
            {
                hayvanlar_level1_oklar[i].Visible = true;
                hayvanlar_level1_resimler[i].Visible = true;
                hayvanlar_level1_oklar[i].Location = hayvanlar_level3_okbaslangiclari[i];
                hayvanlar_level1_yazilar[i].Visible = false;
                hayvanlar_level1_yazilar[i + 5].Visible = false;
            }
            fark = 0;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            hayvanlar_level2_panel.Visible = false;
            hayvanlar_level2_timer.Stop();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            hayvanlar_level3_panel.Visible = false;
            hayvanlar_level3_timer.Stop();
        }

        private void levels4_Click(object sender, EventArgs e)
        {
            renkler_level1_panel.Visible = false;
            siyah_yazi.Visible = false;
            mavi_yazi.Visible = false;
            kahverengi_yazi.Visible = false;
            pembe_yazi.Visible = false;
            beyaz_yazi.Visible = false;
            kirmizi_yazi.Visible = false;
            mor_yazi.Visible = false;
            turuncu_yazi.Visible = false;
            yesil_yazi.Visible = false;
            sari_yazi.Visible = false;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            renkler_level2_timer.Stop();
            renkler_level2_panel.Visible = false;
        }

        private void button64_Click(object sender, EventArgs e)
        {
            renkler_level3_panel.Visible = false;
        }

        private void levels7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                bodyparts_level1_yazilar[i].Visible = false;
                bodyparts_level1_butonlar[i].Enabled = true;
            }
            bodyparts_level1_panel.Visible = false;
        }

        private void button72_Click(object sender, EventArgs e)
        {
            bodyparts_level2_timer.Stop();
            body_level2_panel.Visible = false;
        }

        private void button75_Click(object sender, EventArgs e)
        {
            bodyparts_level3_timer.Stop();
            body_level3_panel.Visible = false;
        }

        private void button76_Click(object sender, EventArgs e)
        {
            gosterilmeyecek1.Visible = true;
            gosterilmeyecek2.Visible = true;
            gosterilmeyecek3.Visible = true;
            gosterilmeyecek4.Visible = true;
            gosterilmeyecek5.Visible = true;
            gosterilmeyecek6.Visible = true;
            gosterilmeyecek7.Visible = true;
            gosterilmeyecek8.Visible = true;
            gosterilmeyecek9.Visible = true;
            gosterilmeyecek10.Visible = true;
            gosterilmeyecek11.Visible = true;
            gosterilmeyecek12.Visible = true;
            meyveler_level1_armutmavi.Visible = true;
            meyveler_level1_armutsari.Visible = true;
            meyveler_level1_armutsari.Enabled = false;
            meyveler_level1_armutsari.BackColor = Color.Yellow;

            meyveler_level1_cilekmavi.Visible = true;
            meyveler_level1_cileksari.Visible = true;
            meyveler_level1_cileksari.Enabled = false;
            meyveler_level1_cileksari.BackColor = Color.Yellow;
            meyveler_level1_strawberry.Visible = true;

            meyveler_level1_elmamavi.Visible = true;
            meyveler_level1_elmasari.Visible = true;
            meyveler_level1_elmasari.Enabled = false;
            meyveler_level1_elmasari.BackColor = Color.Yellow;
            meyveler_level1_apple.Visible = true;

            meyveler_level1_karpuzmavi.Visible = true;
            meyveler_level1_karpuzsari.Visible = true;
            meyveler_level1_karpuzsari.Enabled = false;
            meyveler_level1_karpuzsari.BackColor = Color.Yellow;
            meyveler_level1_watermelon.Visible = true;

            meyveler_level1_kavunmavi.Visible = true;
            meyveler_level1_kavunsari.Visible = true;
            meyveler_level1_kavunsari.Enabled = false;
            meyveler_level1_kavunsari.BackColor = Color.Yellow;

            meyveler_level1_kirazmavi.Visible = true;
            meyveler_level1_kirazsari.Visible = true;
            meyveler_level1_kirazsari.Enabled = false;
            meyveler_level1_kirazsari.BackColor = Color.Yellow;
            meyveler_level1_cherry.Visible = true;

            meyveler_level1_muzmavi.Visible = true;
            meyveler_level1_muzsari.Visible = true;
            meyveler_level1_muzsari.Enabled = false;
            meyveler_level1_muzsari.BackColor = Color.Yellow;
            meyveler_level1_banana.Visible = true;

            meyveler_level1_portakalmavi.Visible = true;
            meyveler_level1_portakalsari.Visible = true;
            meyveler_level1_portakalsari.Enabled = false;
            meyveler_level1_portakalsari.BackColor = Color.Yellow;
            meyveler_level1_orange.Visible = true;

            meyveler_level1_uzummavi.Visible = true;
            meyveler_level1_uzumsari.Visible = true;
            meyveler_level1_uzumsari.Enabled = false;
            meyveler_level1_uzumsari.BackColor = Color.Yellow;

            meyveler_level1_elmamaviimlec.Visible = true;
            meyveler_level1_cilekmaviimlec.Visible = true;
            meyveler_level1_muzmaviimlec.Visible = true;

            meyveler_level1_tik1.Visible = false;
            meyveler_level1_tik2.Visible = false;
            meyveler_level1_tik3.Visible = false;

            meyveler_level1_elmasariimlec.Visible = false;
            meyveler_level1_muzsariimlec.Visible = false;
            meyveler_level1_cileksariimlec.Visible = false;

            meyveler_level1_elmamavi.Enabled = true;
            meyveler_level1_elmamaviimlec.Enabled = true;
            meyveler_level1_muzmavi.Enabled = true;
            meyveler_level1_muzmaviimlec.Enabled = true;
            meyveler_level1_cilekmavi.Enabled = true;
            meyveler_level1_cilekmaviimlec.Enabled = true;

            meyveler_level1_panel.Visible = false;
        }

        private void button76_Click_1(object sender, EventArgs e)
        {
            meyveler_level2_timer.Stop();
            meyveler_level2_panel.Visible = false;
        }

        private void button77_Click(object sender, EventArgs e)
        {
            meyveler_level3_timer.Stop();
            meyveler_level3_panel.Visible = false;
        }

        private void levels13_Click(object sender, EventArgs e)
        {
            ulkeler_level1_panel.Visible = false;
            ulke_isimleri.Location = ulkeler_level1_yazibaslangic;
            ulkeler_level1_kontrol = 0;
            ulkeler_level1_turkiye.Location = turkiye_baslangic;
            ulkeler_level1_ispanya.Location = ispanya_baslangic;
            ulkeler_level1_fransa.Location = fransa_baslangic;
            ulkeler_level1_polonya.Location = polonya_baslangic;
            ulkeler_level1_almanya.Location = almanya_baslangic;
            ulkeler_level1_japonya.Location = japonya_baslangic;
            ulkeler_level1_ingiltere.Location = ingiltere_baslangic;
            ulkeler_level1_italya.Location = italya_baslangic;
            ulkeler_level1_portekiz.Location = portekiz_baslangic;
            ulkeler_level1_cin.Location = cin_baslangic;
            ulkeler_level1_turkiye.Visible = true;
            ulkeler_level1_ispanya.Visible = true;
            ulkeler_level1_fransa.Visible = true;
            ulkeler_level1_polonya.Visible = true;
            ulkeler_level1_almanya.Visible = true;
            ulkeler_level1_japonya.Visible = true;
            ulkeler_level1_ingiltere.Visible = true;
            ulkeler_level1_italya.Visible = true;
            ulkeler_level1_portekiz.Visible = true;
            ulkeler_level1_cin.Visible = true;
            ulkeler_level1_tik.Visible = false;
            ulke_isimleri.Text = "";
        }

        private void button78_Click(object sender, EventArgs e)
        {
            ulkeler_level2_timer.Stop();
            ulkeler_level2_panel.Visible = false;
        }

        private void button79_Click(object sender, EventArgs e)
        {
            ulkeler_level3_timer.Stop();
            ulkeler_level3_panel.Visible = false;
        }

        private void button80_Click(object sender, EventArgs e)
        {
            sayilar_level1_panel.Visible = false;
            sayilar_level1_panel.BackgroundImage = Properties.Resources.foto_1;
            level1_one2.Visible = false;
            level1_two2.Visible = false;
            level1_six2.Visible = false;
            level1_seven2.Visible = false;
            level1_three2.Visible = false;
            level1_eight2.Visible = false;
            level1_nine2.Visible = false;
            level1_four2.Visible = false;
            level1_five2.Visible = false;
            level1_ten2.Visible = false;
            level1_ten1.Visible = false;
            level1_nine1.Visible = false;
            level1_eight1.Visible = false;
            level1_seven1.Visible = false;
            level1_six1.Visible = false;
            level1_one1.Visible = true;
            level1_one1.Text = "one";
            level1_two1.Visible = true;
            level1_two1.Text = "two";
            level1_three1.Visible = true;
            level1_three1.Text = "three";
            level1_four1.Visible = true;
            level1_four1.Text = "four";
            level1_five1.Visible = true;
            level1_five1.Text = "five";
        }

        private void button80_Click_1(object sender, EventArgs e)
        {
            sayilar_level2_timer.Stop();
            sayilar_level2_panel.Visible = false;
        }

        private void button82_Click(object sender, EventArgs e)
        {
            hayvanlar_bonuspanel.Visible = true;
            hayvanlar_bonus_karisik_rakamlar = hayvanlar_bonus_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();            
            hayvanlar_bonus_sayac = 0;
            hayvanlar_bonus_rastgele();
        }

        private void hayvanlar_bonus_cevap1_Click(object sender, EventArgs e)
        {
            if (hayvanlar_bonus_cevap1.Text == hayvanlar_ingilizce_bonus[hayvanlar_bonus_karisik_rakamlar[hayvanlar_bonus_sayac - 1]])
            {
                hayvanlar_bonus[hayvanlar_bonus_karisik_rakamlar[hayvanlar_bonus_sayac - 1]].Visible = false;
                if(hayvanlar_bonus_cevap1.Text == "Bee")
                {
                    ses.URL = "bee.mp3";
                }
                else if(hayvanlar_bonus_cevap1.Text == "Fish")
                {
                    ses.URL = "fish.mp3";
                }
                else if (hayvanlar_bonus_cevap1.Text == "Elephant")
                {
                    ses.URL = "elephant.mp3";
                }
                else if (hayvanlar_bonus_cevap1.Text == "Deer")
                {
                    ses.URL = "deer.mp3";
                }
                else if (hayvanlar_bonus_cevap1.Text == "Butterfly")
                {
                    ses.URL = "butterfly.mp3";
                }
                else if (hayvanlar_bonus_cevap1.Text == "Sheep")
                {
                    ses.URL = "sheep.mp3";
                }
                else if (hayvanlar_bonus_cevap1.Text == "Bird")
                {
                    ses.URL = "bird.mp3";
                }
                else if (hayvanlar_bonus_cevap1.Text == "Frog")
                {
                    ses.URL = "frog.mp3";
                }
                else if (hayvanlar_bonus_cevap1.Text == "Monkey")
                {
                    ses.URL = "monkey.mp3";
                }
                else if (hayvanlar_bonus_cevap1.Text == "Duck")
                {
                    ses.URL = "duck.mp3";
                }
                else if (hayvanlar_bonus_cevap1.Text == "Penguin")
                {
                    ses.URL = "penguin.mp3";
                }
                else if (hayvanlar_bonus_cevap1.Text == "Snail")
                {
                    ses.URL = "snail.mp3";
                }
                else if (hayvanlar_bonus_cevap1.Text == "Crocodile")
                {
                    ses.URL = "crocodile.mp3";
                }
                else if (hayvanlar_bonus_cevap1.Text == "Crab")
                {
                    ses.URL = "crab.mp3";
                }
                else if (hayvanlar_bonus_cevap1.Text == "Snake")
                {
                    ses.URL = "snake.mp3";
                }
                else if (hayvanlar_bonus_cevap1.Text == "Giraffe")
                {
                    ses.URL = "giraffe.mp3";
                }
                hayvanlar_bonus_rastgele();                
            }
            else
            {
                hayvanlar_bonus_cevap1.BackColor = Color.Red;
            }
        }

        private void hayvanlar_bonus_cevap2_Click(object sender, EventArgs e)
        {
            if (hayvanlar_bonus_cevap2.Text == hayvanlar_ingilizce_bonus[hayvanlar_bonus_karisik_rakamlar[hayvanlar_bonus_sayac - 1]])
            {
                hayvanlar_bonus[hayvanlar_bonus_karisik_rakamlar[hayvanlar_bonus_sayac - 1]].Visible = false;
                if (hayvanlar_bonus_cevap2.Text == "Bee")
                {
                    ses.URL = "bee.mp3";
                }
                else if (hayvanlar_bonus_cevap2.Text == "Fish")
                {
                    ses.URL = "fish.mp3";
                }
                else if (hayvanlar_bonus_cevap2.Text == "Elephant")
                {
                    ses.URL = "elephant.mp3";
                }
                else if (hayvanlar_bonus_cevap2.Text == "Deer")
                {
                    ses.URL = "deer.mp3";
                }
                else if (hayvanlar_bonus_cevap2.Text == "Butterfly")
                {
                    ses.URL = "butterfly.mp3";
                }
                else if (hayvanlar_bonus_cevap2.Text == "Sheep")
                {
                    ses.URL = "sheep.mp3";
                }
                else if (hayvanlar_bonus_cevap2.Text == "Bird")
                {
                    ses.URL = "bird.mp3";
                }
                else if (hayvanlar_bonus_cevap2.Text == "Frog")
                {
                    ses.URL = "frog.mp3";
                }
                else if (hayvanlar_bonus_cevap2.Text == "Monkey")
                {
                    ses.URL = "monkey.mp3";
                }
                else if (hayvanlar_bonus_cevap2.Text == "Duck")
                {
                    ses.URL = "duck.mp3";
                }
                else if (hayvanlar_bonus_cevap2.Text == "Penguin")
                {
                    ses.URL = "penguin.mp3";
                }
                else if (hayvanlar_bonus_cevap2.Text == "Snail")
                {
                    ses.URL = "snail.mp3";
                }
                else if (hayvanlar_bonus_cevap2.Text == "Crocodile")
                {
                    ses.URL = "crocodile.mp3";
                }
                else if (hayvanlar_bonus_cevap2.Text == "Crab")
                {
                    ses.URL = "crab.mp3";
                }
                else if (hayvanlar_bonus_cevap2.Text == "Snake")
                {
                    ses.URL = "snake.mp3";
                }
                else if (hayvanlar_bonus_cevap2.Text == "Giraffe")
                {
                    ses.URL = "giraffe.mp3";
                }
                hayvanlar_bonus_rastgele();
            }
            else
            {
                hayvanlar_bonus_cevap2.BackColor = Color.Red;
            }
        }

        private void hayvanlar_bonus_cevap3_Click(object sender, EventArgs e)
        {
            if (hayvanlar_bonus_cevap3.Text == hayvanlar_ingilizce_bonus[hayvanlar_bonus_karisik_rakamlar[hayvanlar_bonus_sayac - 1]])
            {
                hayvanlar_bonus[hayvanlar_bonus_karisik_rakamlar[hayvanlar_bonus_sayac - 1]].Visible = false;
                if (hayvanlar_bonus_cevap3.Text == "Bee")
                {
                    ses.URL = "bee.mp3";
                }
                else if (hayvanlar_bonus_cevap3.Text == "Fish")
                {
                    ses.URL = "fish.mp3";
                }
                else if (hayvanlar_bonus_cevap3.Text == "Elephant")
                {
                    ses.URL = "elephant.mp3";
                }
                else if (hayvanlar_bonus_cevap3.Text == "Deer")
                {
                    ses.URL = "deer.mp3";
                }
                else if (hayvanlar_bonus_cevap3.Text == "Butterfly")
                {
                    ses.URL = "butterfly.mp3";
                }
                else if (hayvanlar_bonus_cevap3.Text == "Sheep")
                {
                    ses.URL = "sheep.mp3";
                }
                else if (hayvanlar_bonus_cevap3.Text == "Bird")
                {
                    ses.URL = "bird.mp3";
                }
                else if (hayvanlar_bonus_cevap3.Text == "Frog")
                {
                    ses.URL = "frog.mp3";
                }
                else if (hayvanlar_bonus_cevap3.Text == "Monkey")
                {
                    ses.URL = "monkey.mp3";
                }
                else if (hayvanlar_bonus_cevap3.Text == "Duck")
                {
                    ses.URL = "duck.mp3";
                }
                else if (hayvanlar_bonus_cevap3.Text == "Penguin")
                {
                    ses.URL = "penguin.mp3";
                }
                else if (hayvanlar_bonus_cevap3.Text == "Snail")
                {
                    ses.URL = "snail.mp3";
                }
                else if (hayvanlar_bonus_cevap3.Text == "Crocodile")
                {
                    ses.URL = "crocodile.mp3";
                }
                else if (hayvanlar_bonus_cevap3.Text == "Crab")
                {
                    ses.URL = "crab.mp3";
                }
                else if (hayvanlar_bonus_cevap3.Text == "Snake")
                {
                    ses.URL = "snake.mp3";
                }
                else if (hayvanlar_bonus_cevap3.Text == "Giraffe")
                {
                    ses.URL = "giraffe.mp3";
                }
                hayvanlar_bonus_rastgele();
            }
            else
            {
                hayvanlar_bonus_cevap3.BackColor = Color.Red;
            }
        }

        private void hayvanlar_bonus_cevap4_Click(object sender, EventArgs e)
        {
            if (hayvanlar_bonus_cevap4.Text == hayvanlar_ingilizce_bonus[hayvanlar_bonus_karisik_rakamlar[hayvanlar_bonus_sayac - 1]])
            {
                hayvanlar_bonus[hayvanlar_bonus_karisik_rakamlar[hayvanlar_bonus_sayac - 1]].Visible = false;
                if (hayvanlar_bonus_cevap4.Text == "Bee")
                {
                    ses.URL = "bee.mp3";
                }
                else if (hayvanlar_bonus_cevap4.Text == "Fish")
                {
                    ses.URL = "fish.mp3";
                }
                else if (hayvanlar_bonus_cevap4.Text == "Elephant")
                {
                    ses.URL = "elephant.mp3";
                }
                else if (hayvanlar_bonus_cevap4.Text == "Deer")
                {
                    ses.URL = "deer.mp3";
                }
                else if (hayvanlar_bonus_cevap4.Text == "Butterfly")
                {
                    ses.URL = "butterfly.mp3";
                }
                else if (hayvanlar_bonus_cevap4.Text == "Sheep")
                {
                    ses.URL = "sheep.mp3";
                }
                else if (hayvanlar_bonus_cevap4.Text == "Bird")
                {
                    ses.URL = "bird.mp3";
                }
                else if (hayvanlar_bonus_cevap4.Text == "Frog")
                {
                    ses.URL = "frog.mp3";
                }
                else if (hayvanlar_bonus_cevap4.Text == "Monkey")
                {
                    ses.URL = "monkey.mp3";
                }
                else if (hayvanlar_bonus_cevap4.Text == "Duck")
                {
                    ses.URL = "duck.mp3";
                }
                else if (hayvanlar_bonus_cevap4.Text == "Penguin")
                {
                    ses.URL = "penguin.mp3";
                }
                else if (hayvanlar_bonus_cevap4.Text == "Snail")
                {
                    ses.URL = "snail.mp3";
                }
                else if (hayvanlar_bonus_cevap4.Text == "Crocodile")
                {
                    ses.URL = "crocodile.mp3";
                }
                else if (hayvanlar_bonus_cevap4.Text == "Crab")
                {
                    ses.URL = "crab.mp3";
                }
                else if (hayvanlar_bonus_cevap4.Text == "Snake")
                {
                    ses.URL = "snake.mp3";
                }
                else if (hayvanlar_bonus_cevap4.Text == "Giraffe")
                {
                    ses.URL = "giraffe.mp3";
                }
                hayvanlar_bonus_rastgele();
            }
            else
            {
                hayvanlar_bonus_cevap4.BackColor = Color.Red;
            }
        }

        private void button86_Click(object sender, EventArgs e)
        {
            hayvanlar_bonuspanel.Visible = false;
            for(int i = 0; i < 16; i++)
            {
                hayvanlar_bonus[i].Visible = false;
            }
        }

        private void button84_Click(object sender, EventArgs e)
        {
            sayilar_bonuspanel.Visible = true;
            sayilar_bonus_karisik_rakamlar = sayilar_bonus_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            sayilar_bonus_sayac = 0;
            for(int i = 0; i < 9; i++)
            {
                sayilar_bonus[i].Visible = false;
            }
            sayilar_bonus_rastgele();
        }

        private void sayilar_bonus_cevap1_Click(object sender, EventArgs e)
        {
            if (sayilar_bonus_cevap1.Text == sayilar_ingilizce_bonus[sayilar_bonus_karisik_rakamlar[sayilar_bonus_sayac - 1]])
            {
                sayilar_bonus[sayilar_bonus_karisik_rakamlar[sayilar_bonus_sayac - 1]].Visible = false;
                if(sayilar_bonus_cevap1.Text == "eleven")
                {
                    ses.URL = "eleven.mp3";
                }
                else if(sayilar_bonus_cevap1.Text == "twelve")
                {
                    ses.URL = "twelve.mp3";
                }
                else if (sayilar_bonus_cevap1.Text == "thirteen")
                {
                    ses.URL = "thirteen.mp3";
                }
                else if (sayilar_bonus_cevap1.Text == "fourteen")
                {
                    ses.URL = "fourteen.mp3";
                }
                else if (sayilar_bonus_cevap1.Text == "fifteen")
                {
                    ses.URL = "fifteen.mp3";
                }
                else if (sayilar_bonus_cevap1.Text == "sixteen")
                {
                    ses.URL = "sixteen.mp3";
                }
                else if (sayilar_bonus_cevap1.Text == "seventeen")
                {
                    ses.URL = "seventeen.mp3";
                }
                else if (sayilar_bonus_cevap1.Text == "eighteen")
                {
                    ses.URL = "eighteen.mp3";
                }
                else if (sayilar_bonus_cevap1.Text == "nineteen")
                {
                    ses.URL = "nineteen.mp3";
                }                
                sayilar_bonus_rastgele();
            }
            else
            {
                sayilar_bonus_cevap1.BackColor = Color.Red;
            }
        }

        private void sayilar_bonus_cevap2_Click(object sender, EventArgs e)
        {
            if (sayilar_bonus_cevap2.Text == sayilar_ingilizce_bonus[sayilar_bonus_karisik_rakamlar[sayilar_bonus_sayac - 1]])
            {
                sayilar_bonus[sayilar_bonus_karisik_rakamlar[sayilar_bonus_sayac - 1]].Visible = false;
                if (sayilar_bonus_cevap2.Text == "eleven")
                {
                    ses.URL = "eleven.mp3";
                }
                else if (sayilar_bonus_cevap2.Text == "twelve")
                {
                    ses.URL = "twelve.mp3";
                }
                else if (sayilar_bonus_cevap2.Text == "thirteen")
                {
                    ses.URL = "thirteen.mp3";
                }
                else if (sayilar_bonus_cevap2.Text == "fourteen")
                {
                    ses.URL = "fourteen.mp3";
                }
                else if (sayilar_bonus_cevap2.Text == "fifteen")
                {
                    ses.URL = "fifteen.mp3";
                }
                else if (sayilar_bonus_cevap2.Text == "sixteen")
                {
                    ses.URL = "sixteen.mp3";
                }
                else if (sayilar_bonus_cevap2.Text == "seventeen")
                {
                    ses.URL = "seventeen.mp3";
                }
                else if (sayilar_bonus_cevap2.Text == "eighteen")
                {
                    ses.URL = "eighteen.mp3";
                }
                else if (sayilar_bonus_cevap2.Text == "nineteen")
                {
                    ses.URL = "nineteen.mp3";
                }
                sayilar_bonus_rastgele();
            }
            else
            {
                sayilar_bonus_cevap2.BackColor = Color.Red;
            }
        }

        private void sayilar_bonus_cevap3_Click(object sender, EventArgs e)
        {
            if (sayilar_bonus_cevap3.Text == sayilar_ingilizce_bonus[sayilar_bonus_karisik_rakamlar[sayilar_bonus_sayac - 1]])
            {
                sayilar_bonus[sayilar_bonus_karisik_rakamlar[sayilar_bonus_sayac - 1]].Visible = false;
                if (sayilar_bonus_cevap3.Text == "eleven")
                {
                    ses.URL = "eleven.mp3";
                }
                else if (sayilar_bonus_cevap3.Text == "twelve")
                {
                    ses.URL = "twelve.mp3";
                }
                else if (sayilar_bonus_cevap3.Text == "thirteen")
                {
                    ses.URL = "thirteen.mp3";
                }
                else if (sayilar_bonus_cevap3.Text == "fourteen")
                {
                    ses.URL = "fourteen.mp3";
                }
                else if (sayilar_bonus_cevap3.Text == "fifteen")
                {
                    ses.URL = "fifteen.mp3";
                }
                else if (sayilar_bonus_cevap3.Text == "sixteen")
                {
                    ses.URL = "sixteen.mp3";
                }
                else if (sayilar_bonus_cevap3.Text == "seventeen")
                {
                    ses.URL = "seventeen.mp3";
                }
                else if (sayilar_bonus_cevap3.Text == "eighteen")
                {
                    ses.URL = "eighteen.mp3";
                }
                else if (sayilar_bonus_cevap3.Text == "nineteen")
                {
                    ses.URL = "nineteen.mp3";
                }
                sayilar_bonus_rastgele();
            }
            else
            {
                sayilar_bonus_cevap3.BackColor = Color.Red;
            }
        }

        private void sayilar_bonus_cevap4_Click(object sender, EventArgs e)
        {
            if (sayilar_bonus_cevap4.Text == sayilar_ingilizce_bonus[sayilar_bonus_karisik_rakamlar[sayilar_bonus_sayac - 1]])
            {
                sayilar_bonus[sayilar_bonus_karisik_rakamlar[sayilar_bonus_sayac - 1]].Visible = false;
                if (sayilar_bonus_cevap4.Text == "eleven")
                {
                    ses.URL = "eleven.mp3";
                }
                else if (sayilar_bonus_cevap4.Text == "twelve")
                {
                    ses.URL = "twelve.mp3";
                }
                else if (sayilar_bonus_cevap4.Text == "thirteen")
                {
                    ses.URL = "thirteen.mp3";
                }
                else if (sayilar_bonus_cevap4.Text == "fourteen")
                {
                    ses.URL = "fourteen.mp3";
                }
                else if (sayilar_bonus_cevap4.Text == "fifteen")
                {
                    ses.URL = "fifteen.mp3";
                }
                else if (sayilar_bonus_cevap4.Text == "sixteen")
                {
                    ses.URL = "sixteen.mp3";
                }
                else if (sayilar_bonus_cevap4.Text == "seventeen")
                {
                    ses.URL = "seventeen.mp3";
                }
                else if (sayilar_bonus_cevap4.Text == "eighteen")
                {
                    ses.URL = "eighteen.mp3";
                }
                else if (sayilar_bonus_cevap4.Text == "nineteen")
                {
                    ses.URL = "nineteen.mp3";
                }
                sayilar_bonus_rastgele();
            }
            else
            {
                sayilar_bonus_cevap4.BackColor = Color.Red;
            }
        }

        private void button87_Click(object sender, EventArgs e)
        {
            sayilar_bonuspanel.Visible = false;
        }

        private void button85_Click(object sender, EventArgs e)
        {
            ulkeler_bonuspanel.Visible = true;
            ulkeler_bonus_karisik_rakamlar = ulkeler_bonus_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            ulkeler_bonus_sayac = 0;
            for (int i = 0; i < 10; i++)
            {
                ulkeler_bonus[i].Visible = false;
                if(i<4)
                {
                    ulkeler_bonus_cevaplar[i].Font = new Font(ulkeler_bonus_cevaplar[i].Font.FontFamily, 22);
                }
            }
            ulkeler_bonus_rastgele();
        }

        private void ulkeler_bonus_cevap1_Click(object sender, EventArgs e)
        {
            if(ulkeler_bonus_cevap1.Text == ulkeler_ingilizce_bonus[ulkeler_bonus_karisik_rakamlar[ulkeler_bonus_sayac - 1]])
            {
                ulkeler_bonus[ulkeler_bonus_karisik_rakamlar[ulkeler_bonus_sayac - 1]].Visible = false;
                if (ulkeler_bonus_cevap1.Text == "United States of America")
                {
                    ses.URL = "UnitedStatesofAmerica.mp3";
                }
                else if(ulkeler_bonus_cevap1.Text == "Algeria")
                {
                    ses.URL = "Algeria.mp3";
                }
                else if (ulkeler_bonus_cevap1.Text == "Croatia")
                {
                    ses.URL = "Croatia.mp3";
                }
                else if (ulkeler_bonus_cevap1.Text == "Netherlands")
                {
                    ses.URL = "Netherlands.mp3";
                }
                else if (ulkeler_bonus_cevap1.Text == "India")
                {
                    ses.URL = "India.mp3";
                }
                else if (ulkeler_bonus_cevap1.Text == "Sweden")
                {
                    ses.URL = "Sweden.mp3";
                }
                else if (ulkeler_bonus_cevap1.Text == "Switzerland")
                {
                    ses.URL = "switzerland.mp3";
                }
                else if (ulkeler_bonus_cevap1.Text == "Hungary")
                {
                    ses.URL = "Hungary.mp3";
                }
                else if (ulkeler_bonus_cevap1.Text == "Egypt")
                {
                    ses.URL = "Egypt.mp3";
                }
                else if (ulkeler_bonus_cevap1.Text == "Greece")
                {
                    ses.URL = "Greece.mp3";
                }
                ulkeler_bonus_cevaplar_karisik[0].Font = new Font(ulkeler_bonus_cevaplar_karisik[0].Font.FontFamily, 23);
                ulkeler_bonus_rastgele();
            }
            else
            {
                ulkeler_bonus_cevap1.BackColor = Color.Red;
            }
        }

        private void ulkeler_bonus_cevap2_Click(object sender, EventArgs e)
        {
            if (ulkeler_bonus_cevap2.Text == ulkeler_ingilizce_bonus[ulkeler_bonus_karisik_rakamlar[ulkeler_bonus_sayac - 1]])
            {
                ulkeler_bonus[ulkeler_bonus_karisik_rakamlar[ulkeler_bonus_sayac - 1]].Visible = false;
                if (ulkeler_bonus_cevap2.Text == "United States of America")
                {
                    ses.URL = "UnitedStatesofAmerica.mp3";
                }
                else if (ulkeler_bonus_cevap2.Text == "Algeria")
                {
                    ses.URL = "Algeria.mp3";
                }
                else if (ulkeler_bonus_cevap2.Text == "Croatia")
                {
                    ses.URL = "Croatia.mp3";
                }
                else if (ulkeler_bonus_cevap2.Text == "Netherlands")
                {
                    ses.URL = "Netherlands.mp3";
                }
                else if (ulkeler_bonus_cevap2.Text == "India")
                {
                    ses.URL = "India.mp3";
                }
                else if (ulkeler_bonus_cevap2.Text == "Sweden")
                {
                    ses.URL = "Sweden.mp3";
                }
                else if (ulkeler_bonus_cevap2.Text == "Switzerland")
                {
                    ses.URL = "switzerland.mp3";
                }
                else if (ulkeler_bonus_cevap2.Text == "Hungary")
                {
                    ses.URL = "Hungary.mp3";
                }
                else if (ulkeler_bonus_cevap2.Text == "Egypt")
                {
                    ses.URL = "Egypt.mp3";
                }
                else if (ulkeler_bonus_cevap2.Text == "Greece")
                {
                    ses.URL = "Greece.mp3";
                }
                ulkeler_bonus_cevaplar_karisik[0].Font = new Font(ulkeler_bonus_cevaplar_karisik[0].Font.FontFamily, 23);
                ulkeler_bonus_rastgele();
            }
            else
            {
                ulkeler_bonus_cevap2.BackColor = Color.Red;
            }
        }

        private void ulkeler_bonus_cevap3_Click(object sender, EventArgs e)
        {
            if (ulkeler_bonus_cevap3.Text == ulkeler_ingilizce_bonus[ulkeler_bonus_karisik_rakamlar[ulkeler_bonus_sayac - 1]])
            {
                ulkeler_bonus[ulkeler_bonus_karisik_rakamlar[ulkeler_bonus_sayac - 1]].Visible = false;
                if (ulkeler_bonus_cevap3.Text == "United States of America")
                {
                    ses.URL = "UnitedStatesofAmerica.mp3";
                }
                else if (ulkeler_bonus_cevap3.Text == "Algeria")
                {
                    ses.URL = "Algeria.mp3";
                }
                else if (ulkeler_bonus_cevap3.Text == "Croatia")
                {
                    ses.URL = "Croatia.mp3";
                }
                else if (ulkeler_bonus_cevap3.Text == "Netherlands")
                {
                    ses.URL = "Netherlands.mp3";
                }
                else if (ulkeler_bonus_cevap3.Text == "India")
                {
                    ses.URL = "India.mp3";
                }
                else if (ulkeler_bonus_cevap3.Text == "Sweden")
                {
                    ses.URL = "Sweden.mp3";
                }
                else if (ulkeler_bonus_cevap3.Text == "Switzerland")
                {
                    ses.URL = "switzerland.mp3";
                }
                else if (ulkeler_bonus_cevap3.Text == "Hungary")
                {
                    ses.URL = "Hungary.mp3";
                }
                else if (ulkeler_bonus_cevap3.Text == "Egypt")
                {
                    ses.URL = "Egypt.mp3";
                }
                else if (ulkeler_bonus_cevap3.Text == "Greece")
                {
                    ses.URL = "Greece.mp3";
                }
                ulkeler_bonus_cevaplar_karisik[0].Font = new Font(ulkeler_bonus_cevaplar_karisik[0].Font.FontFamily, 23);
                ulkeler_bonus_rastgele();
            }
            else
            {
                ulkeler_bonus_cevap3.BackColor = Color.Red;
            }
        }

        private void ulkeler_bonus_cevap4_Click(object sender, EventArgs e)
        {
            if (ulkeler_bonus_cevap4.Text == ulkeler_ingilizce_bonus[ulkeler_bonus_karisik_rakamlar[ulkeler_bonus_sayac - 1]])
            {
                ulkeler_bonus[ulkeler_bonus_karisik_rakamlar[ulkeler_bonus_sayac - 1]].Visible = false;
                if (ulkeler_bonus_cevap4.Text == "United States of America")
                {
                    ses.URL = "UnitedStatesofAmerica.mp3";
                }
                else if (ulkeler_bonus_cevap4.Text == "Algeria")
                {
                    ses.URL = "Algeria.mp3";
                }
                else if (ulkeler_bonus_cevap4.Text == "Croatia")
                {
                    ses.URL = "Croatia.mp3";
                }
                else if (ulkeler_bonus_cevap4.Text == "Netherlands")
                {
                    ses.URL = "Netherlands.mp3";
                }
                else if (ulkeler_bonus_cevap4.Text == "India")
                {
                    ses.URL = "India.mp3";
                }
                else if (ulkeler_bonus_cevap4.Text == "Sweden")
                {
                    ses.URL = "Sweden.mp3";
                }
                else if (ulkeler_bonus_cevap4.Text == "Switzerland")
                {
                    ses.URL = "switzerland.mp3";
                }
                else if (ulkeler_bonus_cevap4.Text == "Hungary")
                {
                    ses.URL = "Hungary.mp3";
                }
                else if (ulkeler_bonus_cevap4.Text == "Egypt")
                {
                    ses.URL = "Egypt.mp3";
                }
                else if (ulkeler_bonus_cevap4.Text == "Greece")
                {
                    ses.URL = "Greece.mp3";
                }
                ulkeler_bonus_cevaplar_karisik[0].Font = new Font(ulkeler_bonus_cevaplar_karisik[0].Font.FontFamily, 23);
                ulkeler_bonus_rastgele();
            }
            else
            {
                ulkeler_bonus_cevap4.BackColor = Color.Red;
            }
        }

        private void button88_Click(object sender, EventArgs e)
        {
            ulkeler_bonuspanel.Visible = false;
        }

        private void button89_Click(object sender, EventArgs e)
        {
            meyveler_bonuspanel.Visible = true;
            meyveler_bonus_karisik_rakamlar = meyveler_bonus_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            meyveler_bonus_sayac = 0;
            for (int i = 0; i < 11; i++)
            {
                meyveler_bonus[i].Visible = false;
            }
            meyveler_bonus_rastgele();
        }

        private void meyveler_bonus_cevap1_Click(object sender, EventArgs e)
        {
            if (meyveler_bonus_cevap1.Text == meyveler_ingilizce_bonus[meyveler_bonus_karisik_rakamlar[meyveler_bonus_sayac - 1]])
            {
                meyveler_bonus[meyveler_bonus_karisik_rakamlar[meyveler_bonus_sayac - 1]].Visible = false;
                if(meyveler_bonus_cevap1.Text == "Tomato")
                {
                    ses.URL = "Tomato.mp3";
                }
                else if(meyveler_bonus_cevap1.Text == "Patato")
                {
                    ses.URL = "Patato.mp3";
                }
                else if(meyveler_bonus_cevap1.Text == "Carrot")
                {
                    ses.URL = "Carrot.mp3";
                }
                else if (meyveler_bonus_cevap1.Text == "Corn")
                {
                    ses.URL = "Corn.mp3";
                }
                else if (meyveler_bonus_cevap1.Text == "Cucumber")
                {
                    ses.URL = "Cucumber.mp3";
                }
                else if (meyveler_bonus_cevap1.Text == "Eggplant")
                {
                    ses.URL = "Eggplant.mp3";
                }
                else if (meyveler_bonus_cevap1.Text == "Lettuce")
                {
                    ses.URL = "Lettuce.mp3";
                }
                else if (meyveler_bonus_cevap1.Text == "Mushroom")
                {
                    ses.URL = "Mushroom.mp3";
                }
                else if (meyveler_bonus_cevap1.Text == "Olive")
                {
                    ses.URL = "Olive.mp3";
                }
                else if (meyveler_bonus_cevap1.Text == "Onion")
                {
                    ses.URL = "Onion.mp3";
                }
                else if (meyveler_bonus_cevap1.Text == "Lemon")
                {
                    ses.URL = "Lemon.mp3";
                }
                meyveler_bonus_rastgele();
            }
            else
            {
                meyveler_bonus_cevap1.BackColor = Color.Red;
            }
        }

        private void meyveler_bonus_cevap2_Click(object sender, EventArgs e)
        {
            if (meyveler_bonus_cevap2.Text == meyveler_ingilizce_bonus[meyveler_bonus_karisik_rakamlar[meyveler_bonus_sayac - 1]])
            {
                meyveler_bonus[meyveler_bonus_karisik_rakamlar[meyveler_bonus_sayac - 1]].Visible = false;
                if (meyveler_bonus_cevap2.Text == "Tomato")
                {
                    ses.URL = "Tomato.mp3";
                }
                else if (meyveler_bonus_cevap2.Text == "Patato")
                {
                    ses.URL = "Patato.mp3";
                }
                else if (meyveler_bonus_cevap2.Text == "Carrot")
                {
                    ses.URL = "Carrot.mp3";
                }
                else if (meyveler_bonus_cevap2.Text == "Corn")
                {
                    ses.URL = "Corn.mp3";
                }
                else if (meyveler_bonus_cevap2.Text == "Cucumber")
                {
                    ses.URL = "Cucumber.mp3";
                }
                else if (meyveler_bonus_cevap2.Text == "Eggplant")
                {
                    ses.URL = "Eggplant.mp3";
                }
                else if (meyveler_bonus_cevap2.Text == "Lettuce")
                {
                    ses.URL = "Lettuce.mp3";
                }
                else if (meyveler_bonus_cevap2.Text == "Mushroom")
                {
                    ses.URL = "Mushroom.mp3";
                }
                else if (meyveler_bonus_cevap2.Text == "Olive")
                {
                    ses.URL = "Olive.mp3";
                }
                else if (meyveler_bonus_cevap2.Text == "Onion")
                {
                    ses.URL = "Onion.mp3";
                }
                else if (meyveler_bonus_cevap2.Text == "Lemon")
                {
                    ses.URL = "Lemon.mp3";
                }
                meyveler_bonus_rastgele();
            }
            else
            {
                meyveler_bonus_cevap2.BackColor = Color.Red;
            }
        }

        private void meyveler_bonus_cevap3_Click(object sender, EventArgs e)
        {
            if (meyveler_bonus_cevap3.Text == meyveler_ingilizce_bonus[meyveler_bonus_karisik_rakamlar[meyveler_bonus_sayac - 1]])
            {
                meyveler_bonus[meyveler_bonus_karisik_rakamlar[meyveler_bonus_sayac - 1]].Visible = false;
                if (meyveler_bonus_cevap3.Text == "Tomato")
                {
                    ses.URL = "Tomato.mp3";
                }
                else if (meyveler_bonus_cevap3.Text == "Patato")
                {
                    ses.URL = "Patato.mp3";
                }
                else if (meyveler_bonus_cevap3.Text == "Carrot")
                {
                    ses.URL = "Carrot.mp3";
                }
                else if (meyveler_bonus_cevap3.Text == "Corn")
                {
                    ses.URL = "Corn.mp3";
                }
                else if (meyveler_bonus_cevap3.Text == "Cucumber")
                {
                    ses.URL = "Cucumber.mp3";
                }
                else if (meyveler_bonus_cevap3.Text == "Eggplant")
                {
                    ses.URL = "Eggplant.mp3";
                }
                else if (meyveler_bonus_cevap3.Text == "Lettuce")
                {
                    ses.URL = "Lettuce.mp3";
                }
                else if (meyveler_bonus_cevap3.Text == "Mushroom")
                {
                    ses.URL = "Mushroom.mp3";
                }
                else if (meyveler_bonus_cevap3.Text == "Olive")
                {
                    ses.URL = "Olive.mp3";
                }
                else if (meyveler_bonus_cevap3.Text == "Onion")
                {
                    ses.URL = "Onion.mp3";
                }
                else if (meyveler_bonus_cevap3.Text == "Lemon")
                {
                    ses.URL = "Lemon.mp3";
                }
                meyveler_bonus_rastgele();
            }
            else
            {
                meyveler_bonus_cevap3.BackColor = Color.Red;
            }
        }

        private void meyveler_bonus_cevap4_Click(object sender, EventArgs e)
        {
            if (meyveler_bonus_cevap4.Text == meyveler_ingilizce_bonus[meyveler_bonus_karisik_rakamlar[meyveler_bonus_sayac - 1]])
            {
                meyveler_bonus[meyveler_bonus_karisik_rakamlar[meyveler_bonus_sayac - 1]].Visible = false;
                if (meyveler_bonus_cevap4.Text == "Tomato")
                {
                    ses.URL = "Tomato.mp3";
                }
                else if (meyveler_bonus_cevap4.Text == "Patato")
                {
                    ses.URL = "Patato.mp3";
                }
                else if (meyveler_bonus_cevap4.Text == "Carrot")
                {
                    ses.URL = "Carrot.mp3";
                }
                else if (meyveler_bonus_cevap4.Text == "Corn")
                {
                    ses.URL = "Corn.mp3";
                }
                else if (meyveler_bonus_cevap4.Text == "Cucumber")
                {
                    ses.URL = "Cucumber.mp3";
                }
                else if (meyveler_bonus_cevap4.Text == "Eggplant")
                {
                    ses.URL = "Eggplant.mp3";
                }
                else if (meyveler_bonus_cevap4.Text == "Lettuce")
                {
                    ses.URL = "Lettuce.mp3";
                }
                else if (meyveler_bonus_cevap4.Text == "Mushroom")
                {
                    ses.URL = "Mushroom.mp3";
                }
                else if (meyveler_bonus_cevap4.Text == "Olive")
                {
                    ses.URL = "Olive.mp3";
                }
                else if (meyveler_bonus_cevap4.Text == "Onion")
                {
                    ses.URL = "Onion.mp3";
                }
                else if (meyveler_bonus_cevap4.Text == "Lemon")
                {
                    ses.URL = "Lemon.mp3";
                }
                meyveler_bonus_rastgele();
            }
            else
            {
                meyveler_bonus_cevap4.BackColor = Color.Red;
            }
        }

        private void button83_Click(object sender, EventArgs e)
        {
            body_bonuspanel.Visible = true;
            body_bonus_karisik_rakamlar = body_bonus_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            for(int i = 0; i < 11; i++)
            {
                body_bonus[i].Visible = false;
            }
            body_bonus_sayac = 0;
            body_bonus_rastgele();
        }

        private void body_bonus_cevap1_Click(object sender, EventArgs e)
        {
            if(body_bonus_cevap1.Text == body_ingilizce_bonus[body_bonus_karisik_rakamlar[body_bonus_sayac - 1]])
            {
                body_bonus[body_bonus_karisik_rakamlar[body_bonus_sayac - 1]].Visible = false;
                if(body_bonus_cevap1.Text == "Wrist")
                {
                    ses.URL = "wrist.mp3";
                }
                else if(body_bonus_cevap1.Text == "Skin")
                {
                    ses.URL = "skin.mp3";
                }
                else if (body_bonus_cevap1.Text == "Tongue")
                {
                    ses.URL = "tongue.mp3";
                }
                else if (body_bonus_cevap1.Text == "Elbow")
                {
                    ses.URL = "elbow.mp3";
                }
                else if (body_bonus_cevap1.Text == "Teeth")
                {
                    ses.URL = "teeth.mp3";
                }
                else if (body_bonus_cevap1.Text == "Knee")
                {
                    ses.URL = "knee.mp3";
                }
                else if (body_bonus_cevap1.Text == "Bone")
                {
                    ses.URL = "bone.mp3";
                }
                else if (body_bonus_cevap1.Text == "Shoulder")
                {
                    ses.URL = "shoulder.mp3";
                }
                else if (body_bonus_cevap1.Text == "Finger")
                {
                    ses.URL = "finger.mp3";
                }
                else if (body_bonus_cevap1.Text == "Beard")
                {
                    ses.URL = "beard.mp3";
                }
                else if (body_bonus_cevap1.Text == "Nail")
                {
                    ses.URL = "nail.mp3";
                }
                body_bonus_rastgele();
            }
            else
            {
                body_bonus_cevap1.BackColor = Color.Red;
            }
        }

        private void body_bonus_cevap2_Click(object sender, EventArgs e)
        {
            if (body_bonus_cevap2.Text == body_ingilizce_bonus[body_bonus_karisik_rakamlar[body_bonus_sayac - 1]])
            {
                body_bonus[body_bonus_karisik_rakamlar[body_bonus_sayac - 1]].Visible = false;
                if (body_bonus_cevap2.Text == "Wrist")
                {
                    ses.URL = "wrist.mp3";
                }
                else if (body_bonus_cevap2.Text == "Skin")
                {
                    ses.URL = "skin.mp3";
                }
                else if (body_bonus_cevap2.Text == "Tongue")
                {
                    ses.URL = "tongue.mp3";
                }
                else if (body_bonus_cevap2.Text == "Elbow")
                {
                    ses.URL = "elbow.mp3";
                }
                else if (body_bonus_cevap2.Text == "Teeth")
                {
                    ses.URL = "teeth.mp3";
                }
                else if (body_bonus_cevap2.Text == "Knee")
                {
                    ses.URL = "knee.mp3";
                }
                else if (body_bonus_cevap2.Text == "Bone")
                {
                    ses.URL = "bone.mp3";
                }
                else if (body_bonus_cevap2.Text == "Shoulder")
                {
                    ses.URL = "shoulder.mp3";
                }
                else if (body_bonus_cevap2.Text == "Finger")
                {
                    ses.URL = "finger.mp3";
                }
                else if (body_bonus_cevap2.Text == "Beard")
                {
                    ses.URL = "beard.mp3";
                }
                else if (body_bonus_cevap2.Text == "Nail")
                {
                    ses.URL = "nail.mp3";
                }
                body_bonus_rastgele();
            }
            else
            {
                body_bonus_cevap2.BackColor = Color.Red;
            }
        }

        private void body_bonus_cevap3_Click(object sender, EventArgs e)
        {
            if (body_bonus_cevap3.Text == body_ingilizce_bonus[body_bonus_karisik_rakamlar[body_bonus_sayac - 1]])
            {
                body_bonus[body_bonus_karisik_rakamlar[body_bonus_sayac - 1]].Visible = false;
                if (body_bonus_cevap3.Text == "Wrist")
                {
                    ses.URL = "wrist.mp3";
                }
                else if (body_bonus_cevap3.Text == "Skin")
                {
                    ses.URL = "skin.mp3";
                }
                else if (body_bonus_cevap3.Text == "Tongue")
                {
                    ses.URL = "tongue.mp3";
                }
                else if (body_bonus_cevap3.Text == "Elbow")
                {
                    ses.URL = "elbow.mp3";
                }
                else if (body_bonus_cevap3.Text == "Teeth")
                {
                    ses.URL = "teeth.mp3";
                }
                else if (body_bonus_cevap3.Text == "Knee")
                {
                    ses.URL = "knee.mp3";
                }
                else if (body_bonus_cevap3.Text == "Bone")
                {
                    ses.URL = "bone.mp3";
                }
                else if (body_bonus_cevap3.Text == "Shoulder")
                {
                    ses.URL = "shoulder.mp3";
                }
                else if (body_bonus_cevap3.Text == "Finger")
                {
                    ses.URL = "finger.mp3";
                }
                else if (body_bonus_cevap3.Text == "Beard")
                {
                    ses.URL = "beard.mp3";
                }
                else if (body_bonus_cevap3.Text == "Nail")
                {
                    ses.URL = "nail.mp3";
                }
                body_bonus_rastgele();
            }
            else
            {
                body_bonus_cevap3.BackColor = Color.Red;
            }
        }

        private void body_bonus_cevap4_Click(object sender, EventArgs e)
        {
            if (body_bonus_cevap4.Text == body_ingilizce_bonus[body_bonus_karisik_rakamlar[body_bonus_sayac - 1]])
            {
                body_bonus[body_bonus_karisik_rakamlar[body_bonus_sayac - 1]].Visible = false;
                if (body_bonus_cevap4.Text == "Wrist")
                {
                    ses.URL = "wrist.mp3";
                }
                else if (body_bonus_cevap4.Text == "Skin")
                {
                    ses.URL = "skin.mp3";
                }
                else if (body_bonus_cevap4.Text == "Tongue")
                {
                    ses.URL = "tongue.mp3";
                }
                else if (body_bonus_cevap4.Text == "Elbow")
                {
                    ses.URL = "elbow.mp3";
                }
                else if (body_bonus_cevap4.Text == "Teeth")
                {
                    ses.URL = "teeth.mp3";
                }
                else if (body_bonus_cevap4.Text == "Knee")
                {
                    ses.URL = "knee.mp3";
                }
                else if (body_bonus_cevap4.Text == "Bone")
                {
                    ses.URL = "bone.mp3";
                }
                else if (body_bonus_cevap4.Text == "Shoulder")
                {
                    ses.URL = "shoulder.mp3";
                }
                else if (body_bonus_cevap4.Text == "Finger")
                {
                    ses.URL = "finger.mp3";
                }
                else if (body_bonus_cevap4.Text == "Beard")
                {
                    ses.URL = "beard.mp3";
                }
                else if (body_bonus_cevap4.Text == "Nail")
                {
                    ses.URL = "nail.mp3";
                }
                body_bonus_rastgele();
            }
            else
            {
                body_bonus_cevap4.BackColor = Color.Red;
            }
        }

        private void button91_Click(object sender, EventArgs e)
        {
            body_bonuspanel.Visible = false;
        }

        private void button90_Click(object sender, EventArgs e)
        {
            meyveler_bonuspanel.Visible = false;
        }

        private void pictureBox63_Click(object sender, EventArgs e)
        {
            hayvanlar_level1_panel.Visible = true;
            levels1.Visible = true;
            button18.Visible = false;
            for (int i = 0; i < 5; i++)
            {
                hayvanlar_level1_oklar[i].Visible = true;
                hayvanlar_level1_resimler[i].Visible = true;
                hayvanlar_level1_yazilar[i].Visible = false;
                hayvanlar_level1_yazilar[i + 5].Visible = false;
            }
            fark = 0;
        }

        private void pictureBox64_Click(object sender, EventArgs e)
        {
            hayvanlar_level2_panel.Visible = true;
            hayvanlar_level2_sayac = 0;
            for (int i = 0; i < 10; i++)
            {
                level2_hayvanlar[i].Visible = false;
            }
            hayvanlar_level2_sure.Text = "90";
            hayvanlar_level2_can.Text = "2";
            zaman = 90;
            can = 2;
            hayvanlar_level2_timer.Start();
            hayvanlar_level2_rastgele_rakamlar = hayvanlar_level3_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            hayvanlar_level2_rastgele();
        }

        private void pictureBox68_Click(object sender, EventArgs e)
        {
            renkler_level1_panel.Visible = true;

            siyah_buton.Visible = true;
            mavi_buton.Visible = true;
            mor_buton.Visible = true;
            beyaz_buton.Visible = true;
            kirmizi_buton.Visible = true;
            sari_buton.Visible = true;
            turuncu_buton.Visible = true;
            yesil_buton.Visible = true;
            kahverengi_buton.Visible = true;
            pembe_buton.Visible = true;

            rastgele_renk();
        }

        private void pictureBox67_Click(object sender, EventArgs e)
        {
            renkler_level2_panel.Visible = true;
            renkler_level2_sayac = 0;
            renkler_level3_rastgele_rakamlar = renkler_level3_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            zaman = 90;
            can = 2;
            renkler_level2_can.Text = "2";
            renkler_level2_sure.Text = "90";
            renkler_level2_timer.Start();
            for (int i = 0; i < 10; i++)
            {
                renkler_level2_nesneler[i].Visible = false;
            }
            rastgele_renk_level2();
        }

        private void pictureBox66_Click(object sender, EventArgs e)
        {
            renkler_level3_panel.Visible = true;
            zaman = 5;
            renkler_level3_sure.Text = "5";
            renkler_level3_timer.Start();
            for (int i = 0; i < 10; i++)
            {
                level3_renkler[i].Visible = false;
            }
            renkler_level3_kontrol.Clear();
            rastgele_renkyazi();
        }

        private void pictureBox71_Click(object sender, EventArgs e)
        {
            tik_sayisi = 0;
            levels7.Visible = true;
            bodyparts_level1_panel.Visible = true;
        }

        private void pictureBox70_Click(object sender, EventArgs e)
        {
            zaman = 90;
            can = 2;
            bodyparts_level2_can.Text = "2";
            bodyparts_level2_sure.Text = "90";
            button12.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            button15.Visible = false;
            button5.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            body_level2_resim.Image = Properties.Resources.body_level2_1;
            body_level2_yazi.Text = "Hair";
            bodyparts_level2_timer.Start();
            body_level2_panel.Visible = true;
        }

        private void pictureBox69_Click(object sender, EventArgs e)
        {
            body_level3_panel.Visible = true;
            body_level3_karisik_rakamlar = body_level3_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            body_level3_sayac = 0;
            zaman = 5;
            bodyparts_level3_sure.Text = "5";
            for (int i = 0; i < 12; i++)
            {
                body_level3_labellar[i].Visible = false;
                body_level3_resimler[i].Visible = false;
            }

            bodyparts_level3_timer.Start();
            body_level3_rastgele();
        }

        private void pictureBox74_Click(object sender, EventArgs e)
        {
            meyveler_level1_panel.Visible = true;
            levels10.Visible = true;
        }

        private void pictureBox73_Click(object sender, EventArgs e)
        {
            meyveler_level2_panel.Visible = true;
            meyveler_level2_sayac = 0;
            zaman = 90;
            can = 2;
            meyveler_level2_sure.Text = "90";
            meyveler_level2_can.Text = "2";
            for (int i = 0; i < 9; i++)
            {
                meyveler_level2_resimler[i].Visible = false;
            }
            meyveler_level2_rastgele_rakamlar = meyveler_level2_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            meyveler_level2_timer.Start();
            meyveler_level2_rastgele();
        }

        private void pictureBox72_Click(object sender, EventArgs e)
        {
            meyveler_level3_panel.Visible = true;
            kontrol1 = 0;
            meyveler_level3_sayac = 0;
            meyveler_level3_karisik_rakamlar = meyveler_level2_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            zaman = 5;
            meyveler_level3_sure.Text = "5";
            for (int i = 0; i < 3; i++)
            {
                meyveler_level3_resimpicturebox[i].BackColor = Color.White;
                meyveler_level3_yazipicturebox[i].BackColor = Color.White;
            }
            meyveler_level3_mavisol.Visible = true;
            meyveler_level3_mavisag.Visible = true;
            meyveler_level3_mavialt.Visible = true;
            meyveler_level3_sarisol.Visible = true;
            meyveler_level3_sarisag.Visible = true;
            meyveler_level3_sarialt.Visible = true;
            meyveler_level3_dogru.Visible = false;
            meyveler_level3_yanlis.Visible = false;
            meyveler_level3_mavisol.Enabled = true;
            meyveler_level3_mavisag.Enabled = true;
            meyveler_level3_mavialt.Enabled = true;
            meyveler_level3_sarisol.Enabled = false;
            meyveler_level3_sarisag.Enabled = false;
            meyveler_level3_sarialt.Enabled = false;
            meyveler_level3_maviclick1.Visible = true;
            meyveler_level3_maviclick1.Enabled = true;
            meyveler_level3_maviclick2.Visible = true;
            meyveler_level3_maviclick2.Enabled = true;
            meyveler_level3_maviclick3.Visible = true;
            meyveler_level3_maviclick3.Enabled = true;
            meyveler_level3_rastgele();
        }

        private void pictureBox77_Click(object sender, EventArgs e)
        {
            ulkeler_level1_kontrol = 0;
            levels13.Visible = true;
            ulkeler_level1_panel.Visible = true;
        }

        private void pictureBox76_Click(object sender, EventArgs e)
        {
            ulkeler_level2_panel.Visible = true;
            ulkeler_level2_karisik1 = ulkeler_level2_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            ulkeler_level2_karisik2 = ulkeler_level2_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            ulkeler_level2_sayac = 0;
            for (int i = 0; i < 10; i++)
            {
                ulkeler_level2_butonlar[i].Visible = true;
                level2_ulkeler[i].Visible = false;
            }
            zaman = 90;
            can = 2;
            ulkeler_level2_sure.Text = "90";
            ulkeler_level2_can.Text = "2";
            ulkeler_level2_timer.Start();
            ulkeler_level2_rastgele();
        }

        private void pictureBox63_MouseEnter(object sender, EventArgs e)
        {
            ses.URL = "kolay.mp3";
        }

        private void pictureBox64_MouseEnter(object sender, EventArgs e)
        {
            ses.URL = "orta.mp3";
        }

        private void pictureBox65_MouseEnter(object sender, EventArgs e)
        {
            ses.URL = "zor.mp3";
        }

        private void pictureBox68_MouseEnter(object sender, EventArgs e)
        {
            ses.URL = "kolay.mp3";
        }

        private void pictureBox67_MouseEnter(object sender, EventArgs e)
        {
            ses.URL = "orta.mp3";
        }

        private void pictureBox66_MouseEnter(object sender, EventArgs e)
        {
            ses.URL = "zor.mp3";
        }

        private void pictureBox71_MouseEnter(object sender, EventArgs e)
        {
            ses.URL = "kolay.mp3";
        }

        private void pictureBox70_MouseEnter(object sender, EventArgs e)
        {
            ses.URL = "orta.mp3";
        }

        private void pictureBox69_MouseEnter(object sender, EventArgs e)
        {
            ses.URL = "zor.mp3";
        }

        private void pictureBox74_MouseEnter(object sender, EventArgs e)
        {
            ses.URL = "kolay.mp3";
        }

        private void pictureBox73_MouseEnter(object sender, EventArgs e)
        {
            ses.URL = "orta.mp3";
        }

        private void pictureBox72_MouseEnter(object sender, EventArgs e)
        {
            ses.URL = "zor.mp3";
        }

        private void pictureBox77_MouseEnter(object sender, EventArgs e)
        {
            ses.URL = "kolay.mp3";
        }

        private void pictureBox76_MouseEnter(object sender, EventArgs e)
        {
            ses.URL = "orta.mp3";
        }

        private void pictureBox75_MouseEnter(object sender, EventArgs e)
        {
            ses.URL = "zor.mp3";
        }

        private void pictureBox80_MouseEnter(object sender, EventArgs e)
        {
            ses.URL = "kolay.mp3";
        }

        private void pictureBox79_MouseEnter(object sender, EventArgs e)
        {
            ses.URL = "orta.mp3";
        }

        private void pictureBox78_MouseEnter(object sender, EventArgs e)
        {
            ses.URL = "zor.mp3";
        }

        private void pictureBox81_Click(object sender, EventArgs e)
        {
            hayvanlar_panel.Visible = false;
        }

        private void pictureBox82_Click(object sender, EventArgs e)
        {
            renkler_panel.Visible = false;
        }

        private void pictureBox83_Click(object sender, EventArgs e)
        {
            bodyparts_panel.Visible = false;
        }

        private void pictureBox84_Click(object sender, EventArgs e)
        {
            meyveler_panel.Visible = false;
        }

        private void pictureBox85_Click(object sender, EventArgs e)
        {
            ulkeler_panel.Visible = false;
        }

        private void pictureBox86_Click(object sender, EventArgs e)
        {
            sayilar_panel.Visible = false;
        }

        private void pictureBox80_Click(object sender, EventArgs e)
        {
            sayilar_level1_panel.Visible = true;
            levels16.Visible = true;
        }

        private void pictureBox79_Click(object sender, EventArgs e)
        {
            sayilar_level2_panel.Visible = true;
            sayilar_level2_sayac = 0;
            zaman = 90;
            can = 2;
            sayilar_level2_sure.Text = "90";
            sayilar_level2_can.Text = "2";
            sayilar_level2_timer.Start();
            for (int i = 0; i < 19; i++)
            {
                sayilar_level2[i].Visible = false;
            }
            ust_buton.BackColor = Color.White;
            alt_buton.BackColor = Color.White;
            rastgele_rakamlar_sayilar_level2 = rakamlar_sayilar_level2.OrderBy(x => Guid.NewGuid()).ToList();
            sayilar_level2_bolumler();
        }

        private void pictureBox78_Click(object sender, EventArgs e)
        {
            sayilar_level3_panel.Visible = true;
            sayilar_level3_rastgele_rakamlar = sayilar_level3_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            sayilar_level3_sayac = 0;
            zaman = 5;
            sayilar_level3_sure.Text = "5";
            sayilar_level3_timer.Start();
            for (int i = 0; i < 19; i++)
            {
                sayilar_level3[i].Visible = false;
            }
            sayilar_level3_rastgele();
        }

        private void pictureBox75_Click(object sender, EventArgs e)
        {
            ulkeler_level3_panel.Visible = true;
            ulkeler_level3_karisik_rakamlar = renkler_level3_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            ulkeler_level3_sayac = 0;
            for (int i = 0; i < 10; i++)
            {
                level3_ulkeler[i].Visible = false;
            }
            zaman = 5;
            ulkeler_level3_sure.Text = "5";
            ulkeler_level3_timer.Start();
            ulkeler_level3_rastgele();
        }

        private void pictureBox65_Click(object sender, EventArgs e)
        {
            hayvanlar_level3_panel.Visible = true;
            hayvanlar_level3_over.Visible = false;
            hayvanlar_level3_karisik_rakamlar = hayvanlar_level3_rakamlar.OrderBy(x => Guid.NewGuid()).ToList();
            hayvanlar_level3_sayac = 0;
            kontrol2 = 0;
            zaman = 5;
            hayvanlar_level3_sure.Text = "5";
            hayvanlar_level3_timer.Start();
            for (int i = 0; i < 5; i++)
            {
                hayvanlar_level3_oklar[i].Location = hayvanlar_level3_okbaslangiclari[i];
                hayvanlar_level3_oklar[i].Visible = true;
                hayvanlar_level3_resimler[i].Visible = false;
                hayvanlar_level3_resimler[i + 5].Visible = false;
                hayvanlar_level3_yazilar[i].Visible = false;
                hayvanlar_level3_yazilar[i + 5].Visible = false;
            }
            hayvanlar_level3_rastgele();
        }

        private void button81_Click(object sender, EventArgs e)
        {
            sayilar_level3_timer.Stop();
            sayilar_level3_panel.Visible = false;
        }

        private void meyveler_level3_maviclick1_Click(object sender, EventArgs e)
        {
            meyveler_level3_mavisol.Visible = false;
            meyveler_level3_maviclick1.Visible = false;
            meyveler_level3_maviclick2.Visible = false;
            meyveler_level3_maviclick3.Visible = false;
            if ((meyveler_level3_mavisol.Visible == true && meyveler_level3_mavisag.Visible == true) || (meyveler_level3_mavisol.Visible == true && meyveler_level3_mavialt.Visible == true) || (meyveler_level3_mavisag.Visible == true && meyveler_level3_sarialt.Visible == true))
            {
                meyveler_level3_sariclick1.Visible = true;
                meyveler_level3_sariclick2.Visible = true;
                meyveler_level3_sariclick3.Visible = true;
            }
            meyveler_level3_mavisag.Enabled = false;
            meyveler_level3_mavialt.Enabled = false;
            meyveler_level3_sariclick1.Enabled = true;
            meyveler_level3_sariclick2.Enabled = true;
            meyveler_level3_sariclick3.Enabled = true;
            meyveler_level3_sarisol.Enabled = true;
            meyveler_level3_sarisag.Enabled = true;
            meyveler_level3_sarialt.Enabled = true;
            meyveler_level3_mavi1.BackColor = Color.Red;
        }

        private void meyveler_level3_mavisag_Click(object sender, EventArgs e)
        {
            meyveler_level3_mavisag.Visible = false;
            meyveler_level3_maviclick1.Visible = false;
            meyveler_level3_maviclick2.Visible = false;
            meyveler_level3_maviclick3.Visible = false;
            if ((meyveler_level3_mavisol.Visible == true && meyveler_level3_mavisag.Visible == true) || (meyveler_level3_mavisol.Visible == true && meyveler_level3_mavialt.Visible == true) || (meyveler_level3_mavisag.Visible == true && meyveler_level3_sarialt.Visible == true))
            {
                meyveler_level3_sariclick1.Visible = true;
                meyveler_level3_sariclick2.Visible = true;
                meyveler_level3_sariclick3.Visible = true;
            }
            meyveler_level3_mavisol.Enabled = false;
            meyveler_level3_mavialt.Enabled = false;
            meyveler_level3_sariclick1.Enabled = true;
            meyveler_level3_sariclick2.Enabled = true;
            meyveler_level3_sariclick3.Enabled = true;
            meyveler_level3_sarisol.Enabled = true;
            meyveler_level3_sarisag.Enabled = true;
            meyveler_level3_sarialt.Enabled = true;
            meyveler_level3_mavi2.BackColor = Color.Red;
        }

        private void meyveler_level3_maviclick2_Click(object sender, EventArgs e)
        {
            meyveler_level3_mavisag.Visible = false;
            meyveler_level3_maviclick1.Visible = false;
            meyveler_level3_maviclick2.Visible = false;
            meyveler_level3_maviclick3.Visible = false;
            if ((meyveler_level3_mavisol.Visible == true && meyveler_level3_mavisag.Visible == true) || (meyveler_level3_mavisol.Visible == true && meyveler_level3_mavialt.Visible == true) || (meyveler_level3_mavisag.Visible == true && meyveler_level3_sarialt.Visible == true))
            {
                meyveler_level3_sariclick1.Visible = true;
                meyveler_level3_sariclick2.Visible = true;
                meyveler_level3_sariclick3.Visible = true;
            }
            meyveler_level3_mavisol.Enabled = false;
            meyveler_level3_mavialt.Enabled = false;
            meyveler_level3_sariclick1.Enabled = true;
            meyveler_level3_sariclick2.Enabled = true;
            meyveler_level3_sariclick3.Enabled = true;
            meyveler_level3_sarisol.Enabled = true;
            meyveler_level3_sarisag.Enabled = true;
            meyveler_level3_sarialt.Enabled = true;
            meyveler_level3_mavi2.BackColor = Color.Red;
        }

        private void meyveler_level3_mavialt_Click(object sender, EventArgs e)
        {
            meyveler_level3_mavialt.Visible = false;
            meyveler_level3_maviclick1.Visible = false;
            meyveler_level3_maviclick2.Visible = false;
            meyveler_level3_maviclick3.Visible = false;
            if ((meyveler_level3_mavisol.Visible == true && meyveler_level3_mavisag.Visible == true) || (meyveler_level3_mavisol.Visible == true && meyveler_level3_mavialt.Visible == true) || (meyveler_level3_mavisag.Visible == true && meyveler_level3_sarialt.Visible == true))
            {
                meyveler_level3_sariclick1.Visible = true;
                meyveler_level3_sariclick2.Visible = true;
                meyveler_level3_sariclick3.Visible = true;
            }
            meyveler_level3_mavisol.Enabled = false;
            meyveler_level3_mavisag.Enabled = false;
            meyveler_level3_sariclick1.Enabled = true;
            meyveler_level3_sariclick2.Enabled = true;
            meyveler_level3_sariclick3.Enabled = true;
            meyveler_level3_sarisol.Enabled = true;
            meyveler_level3_sarisag.Enabled = true;
            meyveler_level3_sarialt.Enabled = true;
            meyveler_level3_mavi3.BackColor = Color.Red;
        }

        private void meyveler_level3_maviclick3_Click(object sender, EventArgs e)
        {
            meyveler_level3_mavialt.Visible = false;
            meyveler_level3_maviclick1.Visible = false;
            meyveler_level3_maviclick2.Visible = false;
            meyveler_level3_maviclick3.Visible = false;
            if ((meyveler_level3_mavisol.Visible == true && meyveler_level3_mavisag.Visible == true) || (meyveler_level3_mavisol.Visible == true && meyveler_level3_mavialt.Visible == true) || (meyveler_level3_mavisag.Visible == true && meyveler_level3_sarialt.Visible == true))
            {
                meyveler_level3_sariclick1.Visible = true;
                meyveler_level3_sariclick2.Visible = true;
                meyveler_level3_sariclick3.Visible = true;
            }
            meyveler_level3_mavisol.Enabled = false;
            meyveler_level3_mavisag.Enabled = false;
            meyveler_level3_sariclick1.Enabled = true;
            meyveler_level3_sariclick2.Enabled = true;
            meyveler_level3_sariclick3.Enabled = true;
            meyveler_level3_sarisol.Enabled = true;
            meyveler_level3_sarisag.Enabled = true;
            meyveler_level3_sarialt.Enabled = true;
            meyveler_level3_mavi3.BackColor = Color.Red;
        }

        private void meyveler_level3_sarisol_Click(object sender, EventArgs e)
        {
            meyveler_level3_timer.Start();
            meyveler_level3_sarisag.Enabled = false;
            meyveler_level3_sarialt.Enabled = false;
            meyveler_level3_sarisol.Visible = false;
            meyveler_level3_sariclick1.Visible = false;
            meyveler_level3_sariclick2.Visible = false;
            meyveler_level3_sariclick3.Visible = false;
            meyveler_level3_dogru.Visible = true;
            meyveler_level3_yanlis.Visible = true;
            meyveler_level3_sari1.BackColor = Color.Red;            
        }

        private void meyveler_level3_sariclick1_Click(object sender, EventArgs e)
        {
            meyveler_level3_timer.Start();
            meyveler_level3_sarisag.Enabled = false;
            meyveler_level3_sarialt.Enabled = false;
            meyveler_level3_sarisol.Visible = false;
            meyveler_level3_sariclick1.Visible = false;
            meyveler_level3_sariclick2.Visible = false;
            meyveler_level3_sariclick3.Visible = false;
            meyveler_level3_dogru.Visible = true;
            meyveler_level3_yanlis.Visible = true;
            meyveler_level3_sari1.BackColor = Color.Red;
        }

        private void meyveler_level3_sarisag_Click(object sender, EventArgs e)
        {
            meyveler_level3_timer.Start();
            meyveler_level3_sarisol.Enabled = false;
            meyveler_level3_sarialt.Enabled = false;
            meyveler_level3_sarisag.Visible = false;
            meyveler_level3_sariclick1.Visible = false;
            meyveler_level3_sariclick2.Visible = false;
            meyveler_level3_sariclick3.Visible = false;
            meyveler_level3_dogru.Visible = true;
            meyveler_level3_yanlis.Visible = true;
            meyveler_level3_sari2.BackColor = Color.Red;
        }

        private void meyveler_level3_sariclick2_Click(object sender, EventArgs e)
        {
            meyveler_level3_timer.Start();
            meyveler_level3_sarisol.Enabled = false;
            meyveler_level3_sarialt.Enabled = false;
            meyveler_level3_sarisag.Visible = false;
            meyveler_level3_sariclick1.Visible = false;
            meyveler_level3_sariclick2.Visible = false;
            meyveler_level3_sariclick3.Visible = false;
            meyveler_level3_dogru.Visible = true;
            meyveler_level3_yanlis.Visible = true;
            meyveler_level3_sari2.BackColor = Color.Red;
        }

        private void meyveler_level3_sarialt_Click(object sender, EventArgs e)
        {
            meyveler_level3_timer.Start();
            meyveler_level3_sarisol.Enabled = false;
            meyveler_level3_sarisag.Enabled = false;
            meyveler_level3_sarialt.Visible = false;
            meyveler_level3_sariclick1.Visible = false;
            meyveler_level3_sariclick2.Visible = false;
            meyveler_level3_sariclick3.Visible = false;
            meyveler_level3_dogru.Visible = true;
            meyveler_level3_yanlis.Visible = true;
            meyveler_level3_sari3.BackColor = Color.Red;
        }

        private void meyveler_level3_sariclick3_Click(object sender, EventArgs e)
        {
            meyveler_level3_timer.Start();
            meyveler_level3_sarisol.Enabled = false;
            meyveler_level3_sarisag.Enabled = false;
            meyveler_level3_sarialt.Visible = false;
            meyveler_level3_sariclick1.Visible = false;
            meyveler_level3_sariclick2.Visible = false;
            meyveler_level3_sariclick3.Visible = false;
            meyveler_level3_dogru.Visible = true;
            meyveler_level3_yanlis.Visible = true;
            meyveler_level3_sari3.BackColor = Color.Red;
        }

        private void meyveler_level3_dogru_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<3; i++)
            {
                for (int j =0; j<3; j++)
                {
                    if (meyveler_level3_resimpicturebox[i].BackColor == Color.Red && meyveler_level3_yazipicturebox[j].BackColor == Color.Red)
                    {                        
                        if (meyveler_level3_karisik_rakamlar[i + kontrol1] == meyveler_level3_karisik_rakamlar2[j])
                        {
                            if(meyveler_level3_karisik_rakamlar2[j] == 0)
                            {
                                ses.URL = "apple.mp3";
                            }
                            else if(meyveler_level3_karisik_rakamlar2[j] == 1)
                            {
                                ses.URL = "pear.mp3";
                            }
                            else if (meyveler_level3_karisik_rakamlar2[j] == 2)
                            {
                                ses.URL = "cherry.mp3";
                            }
                            else if (meyveler_level3_karisik_rakamlar2[j] == 3)
                            {
                                ses.URL = "strawberry.mp3";
                            }
                            else if (meyveler_level3_karisik_rakamlar2[j] == 4)
                            {
                                ses.URL = "orange.mp3";
                            }
                            else if (meyveler_level3_karisik_rakamlar2[j] == 5)
                            {
                                ses.URL = "watermelon.mp3";
                            }
                            else if (meyveler_level3_karisik_rakamlar2[j] == 6)
                            {
                                ses.URL = "melon.mp3";
                            }
                            else if (meyveler_level3_karisik_rakamlar2[j] == 7)
                            {
                                ses.URL = "banana.mp3";
                            }
                            else if (meyveler_level3_karisik_rakamlar2[j] == 8)
                            {
                                ses.URL = "grape.mp3";
                            }                                                        

                            meyveler_level3_timer.Stop();
                            zaman = 5;
                            meyveler_level3_sure.Text = "5";
                            meyveler_level3_dogru.Visible = false;
                            meyveler_level3_yanlis.Visible = false;
                            meyveler_level3_resimpicturebox[i].BackColor = Color.White;
                            meyveler_level3_yazipicturebox[j].BackColor = Color.White;
                            meyveler_level3_mavisol.Enabled = true;
                            meyveler_level3_mavisag.Enabled = true;
                            meyveler_level3_mavialt.Enabled = true;
                            if (meyveler_level3_mavisol.Visible == false && meyveler_level3_mavisag.Visible == false && meyveler_level3_mavialt.Visible == false)
                            {
                                meyveler_level3_mavisol.Visible = true;
                                meyveler_level3_mavisag.Visible = true;
                                meyveler_level3_mavialt.Visible = true;
                                meyveler_level3_sarisol.Visible = true;
                                meyveler_level3_sarisag.Visible = true;
                                meyveler_level3_sarialt.Visible = true;
                                kontrol1 += 3;
                                meyveler_level3_rastgele();
                            }
                            return;                            
                        }
                        else
                        {
                            meyveler_level3_timer.Stop();
                            meyveler_level3_over.Visible = true;
                        }
                    }
                }
            }
        }

        private void meyveler_level3_yanlis_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (meyveler_level3_resimpicturebox[i].BackColor == Color.Red && meyveler_level3_yazipicturebox[j].BackColor == Color.Red)
                    {                                      
                        if (meyveler_level3_karisik_rakamlar[i + kontrol1] != meyveler_level3_karisik_rakamlar2[j])
                        {
                            meyveler_level3_timer.Stop();
                            zaman = 5;
                            meyveler_level3_sure.Text = "5";
                            meyveler_level3_dogru.Visible = false;
                            meyveler_level3_yanlis.Visible = false;
                            meyveler_level3_resimpicturebox[i].BackColor = Color.White;
                            meyveler_level3_yazipicturebox[j].BackColor = Color.White;
                            meyveler_level3_mavisol.Enabled = true;
                            meyveler_level3_mavisag.Enabled = true;
                            meyveler_level3_mavialt.Enabled = true;
                            if (meyveler_level3_mavisol.Visible == false && meyveler_level3_mavisag.Visible == false && meyveler_level3_mavialt.Visible == false)
                            {
                                meyveler_level3_mavisol.Visible = true;
                                meyveler_level3_mavisag.Visible = true;
                                meyveler_level3_mavialt.Visible = true;
                                meyveler_level3_sarisol.Visible = true;
                                meyveler_level3_sarisag.Visible = true;
                                meyveler_level3_sarialt.Visible = true;
                                kontrol1 += 3;
                                meyveler_level3_rastgele();
                            }
                            return;
                        }
                        else
                        {
                            meyveler_level3_timer.Stop();
                            meyveler_level3_over.Visible = true;
                        }
                    }
                }
            }
        }       
        private void hayvanlar_Click(object sender, EventArgs e)
        {
            hayvanlar_panel.Visible = true;
        }

        private void bayraklar_level1_cin_MouseUp(object sender, MouseEventArgs e)
        {
            for (int i = 21; i < 345; i++)
            {
                for (int j = 195; j < 390; j++)
                {
                    if (ulkeler_level1_cin.Left == i && ulkeler_level1_cin.Top == j)
                    {
                        ulkeler_level1_cin.Location = bayrak_koordinat;
                        ulke_isimleri.Visible = true;
                        ulke_isimleri.Left += 13;
                        ulke_isimleri.Text = ulkeler_ingilizce[9];
                        ses.URL = "china.mp3";
                        ulkeler_level1_panel.BackgroundImage = Properties.Resources.sonDeneme;
                    }
                }
            }
            if(ulkeler_level1_cin.Location != bayrak_koordinat)
            {
                ulkeler_level1_cin.Location = cin_baslangic;
            }
            else
            {
                ulkeler_level1_kontrol += 1;
                if (ulkeler_level1_kontrol == 10)
                {
                    ulkeler_level1_tik.Visible = true;
                    levels13.Visible = false;
                }
            }
        }

        private void bayraklar_level1_turkiye_MouseUp(object sender, MouseEventArgs e)
        {
            for(int i = 21; i < 345; i++)
            {
                for(int j = 195; j < 390; j++)
                {
                    if(ulkeler_level1_turkiye.Left == i && ulkeler_level1_turkiye.Top == j)
                    {
                        ulkeler_level1_turkiye.Location = bayrak_koordinat;
                        ulke_isimleri.Visible = true;
                        ulke_isimleri.Text = ulkeler_ingilizce[0];
                        ses.URL = "turkey.mp3";
                        ulkeler_level1_panel.BackgroundImage = Properties.Resources.sonDeneme;
                    }
                }
            }           
            if (ulkeler_level1_turkiye.Location != bayrak_koordinat)
            {
                ulkeler_level1_turkiye.Location = turkiye_baslangic;
            }
            else
            {
                ulkeler_level1_kontrol += 1;
                if (ulkeler_level1_kontrol == 10)
                {
                    ulkeler_level1_tik.Visible = true;
                    levels13.Visible = false;
                }
            }
        }

        private void label7_MouseDown(object sender, MouseEventArgs e)
        {            
            if (level1_one2.Visible == true)
            {
                level1_two1.BackColor = System.Drawing.Color.LawnGreen;
                sag_ok2.Visible = false;
                sol_ok2.Visible = false;
                sag_ok22.Visible = true;
                sol_ok22.Visible = true;
            }
            else
            {
                level1_two1.BackColor = System.Drawing.Color.Red;
            }
            
        }

        private void label20_MouseDown(object sender, MouseEventArgs e)
        {
            if (level1_six2.Visible == true)
            {
                level1_seven1.BackColor = System.Drawing.Color.LawnGreen;
            }
            else
            {
                level1_seven1.BackColor = System.Drawing.Color.Red;
            }
        }

        private void label20_MouseUp(object sender, MouseEventArgs e)
        {
            for (int i = 670; i < 910; i++)
            {
                for (int j = 200; j < 340; j++)
                {
                    if (level1_seven1.Left == i && level1_seven1.Top == j && level1_six2.Visible == true)
                    {
                        level1_seven2.Visible = true;
                        level1_seven1.Visible = false;
                        ses.URL = "seven.mp3";
                        sayilar_level1_panel.BackgroundImage = Properties.Resources.foto81;
                        
                    }
                }
            }
            level1_seven1.BackColor = System.Drawing.Color.Transparent;
            level1_seven1.Location = level1_seven1_baslangic;
        }

        private void sayilar_level3_cevap1_Click(object sender, EventArgs e)
        {
            if (sayilar_level3_cevap1.Text == sayilar_ingilizce[sayilar_level3_rastgele_rakamlar[sayilar_level3_sayac - 1]])
            {
                sayilar_level3[sayilar_level3_rastgele_rakamlar[sayilar_level3_sayac - 1]].Visible = false;
                sayilar_level3_timer.Stop();
                if (sayilar_level3_cevap1.Text == "one")
                {
                    ses.URL = "bir.mp3";
                }
                else if (sayilar_level3_cevap1.Text == "two")
                {
                    ses.URL = "two.mp3";
                }
                else if (sayilar_level3_cevap1.Text == "three")
                {
                    ses.URL = "three.mp3";
                }
                else if (sayilar_level3_cevap1.Text == "four")
                {
                    ses.URL = "four.mp3";
                }
                else if (sayilar_level3_cevap1.Text == "five")
                {
                    ses.URL = "five.mp3";
                }
                else if (sayilar_level3_cevap1.Text == "six")
                {
                    ses.URL = "six.mp3";
                }
                else if (sayilar_level3_cevap1.Text == "seven")
                {
                    ses.URL = "seven.mp3";
                }
                else if (sayilar_level3_cevap1.Text == "eight")
                {
                    ses.URL = "eight.mp3";
                }
                else if (sayilar_level3_cevap1.Text == "nine")
                {
                    ses.URL = "nine.mp3";
                }
                else if (sayilar_level3_cevap1.Text == "ten")
                {
                    ses.URL = "ten.mp3";
                }
                else if (sayilar_level3_cevap1.Text == "twenty")
                {
                    ses.URL = "twenty.mp3";
                }
                else if (sayilar_level3_cevap1.Text == "thirty")
                {
                    ses.URL = "thirty.mp3";
                }
                else if (sayilar_level3_cevap1.Text == "fourty")
                {
                    ses.URL = "fourty.mp3";
                }
                else if (sayilar_level3_cevap1.Text == "fifty")
                {
                    ses.URL = "fifty.mp3";
                }
                else if (sayilar_level3_cevap1.Text == "sixty")
                {
                    ses.URL = "sixty.mp3";
                }
                else if (sayilar_level3_cevap1.Text == "seventy")
                {
                    ses.URL = "seventy.mp3";
                }
                else if (sayilar_level3_cevap1.Text == "eighty")
                {
                    ses.URL = "eighty.mp3";
                }
                else if (sayilar_level3_cevap1.Text == "ninety")
                {
                    ses.URL = "ninety.mp3";
                }
                else if (sayilar_level3_cevap1.Text == "one hundred")
                {
                    ses.URL = "one hundred.mp3";
                }
                zaman = 5;
                sayilar_level3_sure.Text = "5";
                sayilar_level3_timer.Start();
                sayilar_level3_rastgele();
            }
            else
            {
                sayilar_level3_timer.Stop();
                sayilar_level3_over.Visible = true;
            }
        }

        private void sayilar_level3_cevap2_Click(object sender, EventArgs e)
        {
            if (sayilar_level3_cevap2.Text == sayilar_ingilizce[sayilar_level3_rastgele_rakamlar[sayilar_level3_sayac - 1]])
            {
                sayilar_level3[sayilar_level3_rastgele_rakamlar[sayilar_level3_sayac - 1]].Visible = false;
                sayilar_level3_timer.Stop();
                if (sayilar_level3_cevap2.Text == "one")
                {
                    ses.URL = "bir.mp3";
                }
                else if (sayilar_level3_cevap2.Text == "two")
                {
                    ses.URL = "two.mp3";
                }
                else if (sayilar_level3_cevap2.Text == "three")
                {
                    ses.URL = "three.mp3";
                }
                else if (sayilar_level3_cevap2.Text == "four")
                {
                    ses.URL = "four.mp3";
                }
                else if (sayilar_level3_cevap2.Text == "five")
                {
                    ses.URL = "five.mp3";
                }
                else if (sayilar_level3_cevap2.Text == "six")
                {
                    ses.URL = "six.mp3";
                }
                else if (sayilar_level3_cevap2.Text == "seven")
                {
                    ses.URL = "seven.mp3";
                }
                else if (sayilar_level3_cevap2.Text == "eight")
                {
                    ses.URL = "eight.mp3";
                }
                else if (sayilar_level3_cevap2.Text == "nine")
                {
                    ses.URL = "nine.mp3";
                }
                else if (sayilar_level3_cevap2.Text == "ten")
                {
                    ses.URL = "ten.mp3";
                }
                else if (sayilar_level3_cevap2.Text == "twenty")
                {
                    ses.URL = "twenty.mp3";
                }
                else if (sayilar_level3_cevap2.Text == "thirty")
                {
                    ses.URL = "thirty.mp3";
                }
                else if (sayilar_level3_cevap2.Text == "fourty")
                {
                    ses.URL = "fourty.mp3";
                }
                else if (sayilar_level3_cevap2.Text == "fifty")
                {
                    ses.URL = "fifty.mp3";
                }
                else if (sayilar_level3_cevap2.Text == "sixty")
                {
                    ses.URL = "sixty.mp3";
                }
                else if (sayilar_level3_cevap2.Text == "seventy")
                {
                    ses.URL = "seventy.mp3";
                }
                else if (sayilar_level3_cevap2.Text == "eighty")
                {
                    ses.URL = "eighty.mp3";
                }
                else if (sayilar_level3_cevap2.Text == "ninety")
                {
                    ses.URL = "ninety.mp3";
                }
                else if (sayilar_level3_cevap2.Text == "one hundred")
                {
                    ses.URL = "one hundred.mp3";
                }
                zaman = 5;
                sayilar_level3_sure.Text = "5";
                sayilar_level3_timer.Start();
                sayilar_level3_rastgele();
            }
            else
            {
                sayilar_level3_timer.Stop();
                sayilar_level3_over.Visible = true;
            }
        }

        private void sayilar_level3_cevap3_Click(object sender, EventArgs e)
        {
            if (sayilar_level3_cevap3.Text == sayilar_ingilizce[sayilar_level3_rastgele_rakamlar[sayilar_level3_sayac - 1]])
            {
                sayilar_level3[sayilar_level3_rastgele_rakamlar[sayilar_level3_sayac - 1]].Visible = false;
                sayilar_level3_timer.Stop();
                if (sayilar_level3_cevap3.Text == "one")
                {
                    ses.URL = "bir.mp3";
                }
                else if (sayilar_level3_cevap3.Text == "two")
                {
                    ses.URL = "two.mp3";
                }
                else if (sayilar_level3_cevap3.Text == "three")
                {
                    ses.URL = "three.mp3";
                }
                else if (sayilar_level3_cevap3.Text == "four")
                {
                    ses.URL = "four.mp3";
                }
                else if (sayilar_level3_cevap3.Text == "five")
                {
                    ses.URL = "five.mp3";
                }
                else if (sayilar_level3_cevap3.Text == "six")
                {
                    ses.URL = "six.mp3";
                }
                else if (sayilar_level3_cevap3.Text == "seven")
                {
                    ses.URL = "seven.mp3";
                }
                else if (sayilar_level3_cevap3.Text == "eight")
                {
                    ses.URL = "eight.mp3";
                }
                else if (sayilar_level3_cevap3.Text == "nine")
                {
                    ses.URL = "nine.mp3";
                }
                else if (sayilar_level3_cevap3.Text == "ten")
                {
                    ses.URL = "ten.mp3";
                }
                else if (sayilar_level3_cevap3.Text == "twenty")
                {
                    ses.URL = "twenty.mp3";
                }
                else if (sayilar_level3_cevap3.Text == "thirty")
                {
                    ses.URL = "thirty.mp3";
                }
                else if (sayilar_level3_cevap3.Text == "fourty")
                {
                    ses.URL = "fourty.mp3";
                }
                else if (sayilar_level3_cevap3.Text == "fifty")
                {
                    ses.URL = "fifty.mp3";
                }
                else if (sayilar_level3_cevap3.Text == "sixty")
                {
                    ses.URL = "sixty.mp3";
                }
                else if (sayilar_level3_cevap3.Text == "seventy")
                {
                    ses.URL = "seventy.mp3";
                }
                else if (sayilar_level3_cevap3.Text == "eighty")
                {
                    ses.URL = "eighty.mp3";
                }
                else if (sayilar_level3_cevap3.Text == "ninety")
                {
                    ses.URL = "ninety.mp3";
                }
                else if (sayilar_level3_cevap3.Text == "one hundred")
                {
                    ses.URL = "one hundred.mp3";
                }
                zaman = 5;
                sayilar_level3_sure.Text = "5";
                sayilar_level3_timer.Start();
                sayilar_level3_rastgele();
            }
            else
            {
                sayilar_level3_timer.Stop();
                sayilar_level3_over.Visible = true;
            }
        }

        private void sayilar_level3_cevap4_Click(object sender, EventArgs e)
        {
            if (sayilar_level3_cevap4.Text == sayilar_ingilizce[sayilar_level3_rastgele_rakamlar[sayilar_level3_sayac - 1]])
            {
                sayilar_level3[sayilar_level3_rastgele_rakamlar[sayilar_level3_sayac - 1]].Visible = false;
                sayilar_level3_timer.Stop();
                if (sayilar_level3_cevap4.Text == "one")
                {
                    ses.URL = "bir.mp3";
                }
                else if (sayilar_level3_cevap4.Text == "two")
                {
                    ses.URL = "two.mp3";
                }
                else if (sayilar_level3_cevap4.Text == "three")
                {
                    ses.URL = "three.mp3";
                }
                else if (sayilar_level3_cevap4.Text == "four")
                {
                    ses.URL = "four.mp3";
                }
                else if (sayilar_level3_cevap4.Text == "five")
                {
                    ses.URL = "five.mp3";
                }
                else if (sayilar_level3_cevap4.Text == "six")
                {
                    ses.URL = "six.mp3";
                }
                else if (sayilar_level3_cevap4.Text == "seven")
                {
                    ses.URL = "seven.mp3";
                }
                else if (sayilar_level3_cevap4.Text == "eight")
                {
                    ses.URL = "eight.mp3";
                }
                else if (sayilar_level3_cevap4.Text == "nine")
                {
                    ses.URL = "nine.mp3";
                }
                else if (sayilar_level3_cevap4.Text == "ten")
                {
                    ses.URL = "ten.mp3";
                }
                else if (sayilar_level3_cevap4.Text == "twenty")
                {
                    ses.URL = "twenty.mp3";
                }
                else if (sayilar_level3_cevap4.Text == "thirty")
                {
                    ses.URL = "thirty.mp3";
                }
                else if (sayilar_level3_cevap4.Text == "fourty")
                {
                    ses.URL = "fourty.mp3";
                }
                else if (sayilar_level3_cevap4.Text == "fifty")
                {
                    ses.URL = "fifty.mp3";
                }
                else if (sayilar_level3_cevap4.Text == "sixty")
                {
                    ses.URL = "sixty.mp3";
                }
                else if (sayilar_level3_cevap4.Text == "seventy")
                {
                    ses.URL = "seventy.mp3";
                }
                else if (sayilar_level3_cevap4.Text == "eighty")
                {
                    ses.URL = "eighty.mp3";
                }
                else if (sayilar_level3_cevap4.Text == "ninety")
                {
                    ses.URL = "ninety.mp3";
                }
                else if (sayilar_level3_cevap4.Text == "one hundred")
                {
                    ses.URL = "one hundred.mp3";
                }
                zaman = 5;
                sayilar_level3_sure.Text = "5";
                sayilar_level3_timer.Start();
                sayilar_level3_rastgele();
            }
            else
            {
                sayilar_level3_timer.Stop();
                sayilar_level3_over.Visible = true;
            }
        }

        private void bayraklarr_Click(object sender, EventArgs e)
        {
            ulkeler_panel.Visible = true;
        }

        private void label19_MouseDown(object sender, MouseEventArgs e)
        {
            if (level1_seven2.Visible == true)
            {
                level1_eight1.BackColor = System.Drawing.Color.LawnGreen;
            }
            else
            {
                level1_eight1.BackColor = System.Drawing.Color.Red;
            }
        }

        private void label19_MouseUp(object sender, MouseEventArgs e)
        {
            for (int i = 900; i < 1100; i++)
            {
                for (int j = 200; j < 390; j++)
                {
                    if (level1_eight1.Left == i && level1_eight1.Top == j && level1_seven2.Visible == true)
                    {
                        level1_eight2.Visible = true;
                        level1_eight1.Visible = false;
                        ses.URL = "eight.mp3";
                        sayilar_level1_panel.BackgroundImage = Properties.Resources.foto9;
                        
                    }
                }
            }
            level1_eight1.BackColor = System.Drawing.Color.Transparent;
            level1_eight1.Location = level1_eight1_baslangic;
        }

        private void label18_MouseDown(object sender, MouseEventArgs e)
        {
            if (level1_eight2.Visible == true)
            {
                level1_nine1.BackColor = System.Drawing.Color.LawnGreen;
            }
            else
            {
                level1_nine1.BackColor = System.Drawing.Color.Red;
            }
        }

        private void label18_MouseUp(object sender, MouseEventArgs e)
        {
            for (int i = 520; i < 750; i++)
            {
                for (int j = 500; j < 660; j++)
                {
                    if (level1_nine1.Left == i && level1_nine1.Top == j && level1_eight2.Visible == true)
                    {
                        level1_nine2.Visible = true;
                        level1_nine1.Visible = false;
                        ses.URL = "nine.mp3";
                        sayilar_level1_panel.BackgroundImage = Properties.Resources.foto10;
                        
                    }
                }
            }
            level1_nine1.BackColor = System.Drawing.Color.Transparent;
            level1_nine1.Location = level1_nine1_baslangic;
        }

        private void label16_MouseDown(object sender, MouseEventArgs e)
        {
            if (level1_nine2.Visible == true)
            {
                level1_ten1.BackColor = System.Drawing.Color.LawnGreen;
            }
            else
            {
                level1_ten1.BackColor = System.Drawing.Color.Red;
            }
        }

        private void label16_MouseUp(object sender, MouseEventArgs e)
        {
            for (int i = 850; i < 1070; i++)
            {
                for (int j = 500; j < 690; j++)
                {
                    if (level1_ten1.Left == i && level1_ten1.Top == j && level1_nine2.Visible == true)
                    {
                        level1_ten2.Visible = true;
                        level1_ten1.Visible = false;
                        ses.URL = "ten.mp3";
                    }
                }
            }
            if (level1_ten2.Visible == true)
            {
                sayilar_level1_tik.Visible = true;
                levels16.Visible = false;
            }
            level1_ten1.BackColor = System.Drawing.Color.Transparent;
            level1_ten1.Location = level1_ten1_baslangic;
        }

        private void ust_buton_Click(object sender, EventArgs e)
        {
            if (ust_buton.Text == sayilar_ingilizce[rastgele_rakamlar_sayilar_level2[sayilar_level2_sayac - 1]])
            {
                sayilar_level2[rastgele_rakamlar_sayilar_level2[sayilar_level2_sayac - 1]].Visible = false;
                if(ust_buton.Text == "one")
                {
                    ses.URL = "bir.mp3";
                }
                else if(ust_buton.Text == "two")
                {
                    ses.URL = "two.mp3";
                }
                else if (ust_buton.Text == "three")
                {
                    ses.URL = "three.mp3";
                }
                else if (ust_buton.Text == "four")
                {
                    ses.URL = "four.mp3";
                }               
                else if (ust_buton.Text == "five")
                {
                    ses.URL = "five.mp3";
                }
                else if (ust_buton.Text == "six")
                {
                    ses.URL = "six.mp3";
                }
                else if (ust_buton.Text == "seven")
                {
                    ses.URL = "seven.mp3";
                }
                else if (ust_buton.Text == "eight")
                {
                    ses.URL = "eight.mp3";
                }
                else if (ust_buton.Text == "nine")
                {
                    ses.URL = "nine.mp3";
                }
                else if (ust_buton.Text == "ten")
                {
                    ses.URL = "ten.mp3";
                }
                else if (ust_buton.Text == "twenty")
                {
                    ses.URL = "twenty.mp3";
                }
                else if (ust_buton.Text == "thirty")
                {
                    ses.URL = "thirty.mp3";
                }
                else if (ust_buton.Text == "fourty")
                {
                    ses.URL = "fourty.mp3";
                }
                else if (ust_buton.Text == "fifty")
                {
                    ses.URL = "fifty.mp3";
                }
                else if (ust_buton.Text == "sixty")
                {
                    ses.URL = "sixty.mp3";
                }
                else if (ust_buton.Text == "seventy")
                {
                    ses.URL = "seventy.mp3";
                }
                else if (ust_buton.Text == "eighty")
                {
                    ses.URL = "eighty.mp3";
                }
                else if (ust_buton.Text == "ninety")
                {
                    ses.URL = "ninety.mp3";
                }
                else if (ust_buton.Text == "one hundred")
                {
                    ses.URL = "one hundred.mp3";
                }
                ust_buton.BackColor = System.Drawing.Color.Transparent;
                alt_buton.BackColor = System.Drawing.Color.Transparent;
                sayilar_level2_bolumler();                
            }
            else
            {
                can -= 1;
                sayilar_level2_can.Text = Convert.ToString(can);
                if (can == -1)
                {
                    sayilar_level2_timer.Stop();
                    sayilar_level2_over.Visible = true;
                }
                ust_buton.BackColor = System.Drawing.Color.Red;
            }
        }

        private void alt_buton_Click(object sender, EventArgs e)
        {
            if (alt_buton.Text == sayilar_ingilizce[rastgele_rakamlar_sayilar_level2[sayilar_level2_sayac - 1]])
            {
                sayilar_level2[rastgele_rakamlar_sayilar_level2[sayilar_level2_sayac - 1]].Visible = false;
                if (alt_buton.Text == "one")
                {
                    ses.URL = "bir.mp3";
                }
                else if (alt_buton.Text == "two")
                {
                    ses.URL = "two.mp3";
                }
                else if (alt_buton.Text == "three")
                {
                    ses.URL = "three.mp3";
                }
                else if (alt_buton.Text == "four")
                {
                    ses.URL = "four.mp3";
                }
                else if (alt_buton.Text == "five")
                {
                    ses.URL = "five.mp3";
                }
                else if (alt_buton.Text == "six")
                {
                    ses.URL = "six.mp3";
                }
                else if (alt_buton.Text == "seven")
                {
                    ses.URL = "seven.mp3";
                }
                else if (alt_buton.Text == "eight")
                {
                    ses.URL = "eight.mp3";
                }
                else if (alt_buton.Text == "nine")
                {
                    ses.URL = "nine.mp3";
                }
                else if (alt_buton.Text == "ten")
                {
                    ses.URL = "ten.mp3";
                }
                else if (alt_buton.Text == "twenty")
                {
                    ses.URL = "twenty.mp3";
                }
                else if (alt_buton.Text == "thirty")
                {
                    ses.URL = "thirty.mp3";
                }
                else if (alt_buton.Text == "fourty")
                {
                    ses.URL = "fourty.mp3";
                }
                else if (alt_buton.Text == "fifty")
                {
                    ses.URL = "fifty.mp3";
                }
                else if (alt_buton.Text == "sixty")
                {
                    ses.URL = "sixty.mp3";
                }
                else if (alt_buton.Text == "seventy")
                {
                    ses.URL = "seventy.mp3";
                }
                else if (alt_buton.Text == "eighty")
                {
                    ses.URL = "eighty.mp3";
                }
                else if (alt_buton.Text == "ninety")
                {
                    ses.URL = "ninety.mp3";
                }
                else if (alt_buton.Text == "one hundred")
                {
                    ses.URL = "one hundred.mp3";
                }
                ust_buton.BackColor = System.Drawing.Color.Transparent;
                alt_buton.BackColor = System.Drawing.Color.Transparent;
                sayilar_level2_bolumler();
            }
            else
            {
                can -= 1;
                sayilar_level2_can.Text = Convert.ToString(can);
                if (can == -1)
                {
                    sayilar_level2_timer.Stop();
                    sayilar_level2_over.Visible = true;
                }
                alt_buton.BackColor = System.Drawing.Color.Red;
            }
        }        

        private void label7_MouseUp(object sender, MouseEventArgs e)
        {
            for (int i = 690; i < 890; i++)
            {
                for (int j = 200; j < 360; j++)
                {
                    if (level1_two1.Left == i && level1_two1.Top == j && level1_one2.Visible == true)
                    {
                        level1_two2.Visible = true;
                        level1_two1.Text = "";
                        ses.URL = "two.mp3";
                        sayilar_level1_panel.BackgroundImage = Properties.Resources.foto3;
                        sag_ok22.Visible = false;
                        sol_ok22.Visible = false;
                        sag_ok3.Visible = true;
                        sol_ok3.Visible = true;
                    }
                }
            }
            level1_two1.BackColor = System.Drawing.Color.Transparent;
            level1_two1.Location = level1_two1_baslangic;            
        }

        private void label8_MouseDown(object sender, MouseEventArgs e)
        {
            if (level1_two2.Visible == true)
            {
                level1_three1.BackColor = System.Drawing.Color.LawnGreen;
                sag_ok3.Visible = false;
                sol_ok3.Visible = false;
                sag_ok33.Visible = true;
                sol_ok33.Visible = true;
            }
            else
            {
                level1_three1.BackColor = System.Drawing.Color.Red;
            }
        }

        private void label8_MouseUp(object sender, MouseEventArgs e)
        {
            for (int i = 850; i < 1090; i++)
            {
                for (int j = 200; j < 350; j++)
                {
                    if (level1_three1.Left == i && level1_three1.Top == j && level1_one2.Visible == true)
                    {
                        level1_three2.Visible = true;
                        level1_three1.Text = "";
                        ses.URL = "three.mp3";
                        sayilar_level1_panel.BackgroundImage = Properties.Resources.foto4;
                        sag_ok33.Visible = false;
                        sol_ok33.Visible = false;
                        sag_ok4.Visible = true;
                        sol_ok4.Visible = true;
                    }
                }
            }
            level1_three1.BackColor = System.Drawing.Color.Transparent;
            level1_three1.Location = level1_three1_baslangic;
            
        }

        private void label21_MouseDown(object sender, MouseEventArgs e)
        {
            level1_six1.BackColor = System.Drawing.Color.LawnGreen;
        }

        private void label21_MouseUp(object sender, MouseEventArgs e)
        {
            for (int i =500;  i<750; i++)
            {
                for (int j = 200; j<330; j++)
                {
                    if (level1_six1.Left == i && level1_six1.Top == j)
                    {
                        level1_six2.Visible = true;
                        level1_six1.Visible = false;
                        ses.URL = "six.mp3";
                        sayilar_level1_panel.BackgroundImage = Properties.Resources.foto7;
                        
                    }
                }
            }
            level1_six1.BackColor = System.Drawing.Color.Transparent;
            level1_six1.Location = level1_six1_baslangic;
        }
        private void label9_MouseDown(object sender, MouseEventArgs e)
        {
            if (level1_three2.Visible == true)
            {
                level1_four1.BackColor = System.Drawing.Color.LawnGreen;
                sag_ok4.Visible = false;
                sol_ok4.Visible = false;
                sag_ok44.Visible = true;
                sol_ok44.Visible = true;
            }
            else
            {
                level1_four1.BackColor = System.Drawing.Color.Red;
            }
            
        }

        private void label9_MouseUp(object sender, MouseEventArgs e)
        {
            for (int i = 500; i < 760; i++)
            {
                for (int j = 510; j < 670; j++)
                {
                    if (level1_four1.Left == i && level1_four1.Top == j && level1_one2.Visible == true)
                    {
                        level1_four2.Visible = true;
                        level1_four1.Text = "";
                        ses.URL = "four.mp3";
                        sayilar_level1_panel.BackgroundImage = Properties.Resources.foto5;
                        sag_ok44.Visible = false;
                        sol_ok44.Visible = false;
                        
                    }
                }
            }
            level1_four1.BackColor = System.Drawing.Color.Transparent;
            level1_four1.Location = level1_four1_baslangic;
            
        }

        private void label10_MouseDown(object sender, MouseEventArgs e)
        {
            if (level1_four2.Visible == true)
            {
                level1_five1.BackColor = System.Drawing.Color.LawnGreen;
            }
            else
            {
                level1_five1.BackColor = System.Drawing.Color.Red;
            }            
        }
        private void label10_MouseUp(object sender, MouseEventArgs e)
        {
            for (int i = 820; i < 1080; i++)
            {
                for (int j = 500; j < 690; j++)
                {
                    if (level1_five1.Left == i && level1_five1.Top == j && level1_one2.Visible == true)
                    {
                        level1_five2.Visible = true;
                        level1_five1.Text = "";
                        ses.URL = "five.mp3";
                        sayilar_level1_panel.BackgroundImage = Properties.Resources.foto6;
                        level1_one2.Visible = false;
                        level1_two2.Visible = false;
                        level1_three2.Visible = false;
                        level1_four2.Visible = false;
                        level1_five2.Visible = false;
                        level1_six1.Visible = true;
                        level1_seven1.Visible = true;
                        level1_eight1.Visible = true;
                        level1_nine1.Visible = true;
                        level1_ten1.Visible = true;
                    }
                }
            }
            level1_five1.BackColor = System.Drawing.Color.Transparent;
            level1_five1.Location = level1_five1_baslangic;
            
        }
    }
}
