using System;
using System.Collections;
using System.Windows.Forms;
using Soneta.Types;
using Soneta.Business;
using Soneta.Business.App;
using Soneta.Towary;
using Soneta.Handel;
using Soneta.Magazyny;
using Soneta.CRM;
using Soneta.Kasa;
using Soneta.Core;
using Soneta.EwidencjaVat;
using Soneta.Ksiega;

namespace PrzykladHandel
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : System.Windows.Forms.Form {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public Form1() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing ) {
            if( disposing ) {
                ////////////////////////////////////////////////////////////////
                // Poniewa¿ obiekt Login mo¿e przechowywaæ po³¹czenie do
                // bazy danych (IDbConnection) nale¿y zwolniæ zasoby przez
                // niego u¿ywane.
                //
                if (login!=null)
                    login.Dispose();

                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
					this.buttonPZ = new System.Windows.Forms.Button();
					this.buttonINW = new System.Windows.Forms.Button();
					this.buttonKorekta = new System.Windows.Forms.Button();
					this.textID = new System.Windows.Forms.TextBox();
					this.buttonPrzelew = new System.Windows.Forms.Button();
					this.cbGotówka = new System.Windows.Forms.CheckBox();
					this.cbPrzelew = new System.Windows.Forms.CheckBox();
					this.buttonRW = new System.Windows.Forms.Button();
					this.buttonKontrahent = new System.Windows.Forms.Button();
					this.buttonKontrahenci = new System.Windows.Forms.Button();
					this.buttonTowary = new System.Windows.Forms.Button();
					this.buttonPZZK = new System.Windows.Forms.Button();
					this.buttonRaport = new System.Windows.Forms.Button();
					this.buttonWp³ata = new System.Windows.Forms.Button();
					this.buttonRozliczenie = new System.Windows.Forms.Button();
					this.buttonEwidencjaSprzedazy = new System.Windows.Forms.Button();
					this.SuspendLayout();
					// 
					// buttonPZ
					// 
					this.buttonPZ.FlatStyle = System.Windows.Forms.FlatStyle.System;
					this.buttonPZ.Location = new System.Drawing.Point(12, 12);
					this.buttonPZ.Name = "buttonPZ";
					this.buttonPZ.Size = new System.Drawing.Size(164, 48);
					this.buttonPZ.TabIndex = 0;
					this.buttonPZ.Text = "Generowanie dokumentu PZ";
					this.buttonPZ.Click += new System.EventHandler(this.buttonPZ_Click);
					// 
					// buttonINW
					// 
					this.buttonINW.FlatStyle = System.Windows.Forms.FlatStyle.System;
					this.buttonINW.Location = new System.Drawing.Point(12, 132);
					this.buttonINW.Name = "buttonINW";
					this.buttonINW.Size = new System.Drawing.Size(164, 48);
					this.buttonINW.TabIndex = 2;
					this.buttonINW.Text = "Generowanie dokumentu Inwentaryzacji";
					this.buttonINW.Click += new System.EventHandler(this.buttonINW_Click);
					// 
					// buttonKorekta
					// 
					this.buttonKorekta.FlatStyle = System.Windows.Forms.FlatStyle.System;
					this.buttonKorekta.Location = new System.Drawing.Point(12, 192);
					this.buttonKorekta.Name = "buttonKorekta";
					this.buttonKorekta.Size = new System.Drawing.Size(164, 44);
					this.buttonKorekta.TabIndex = 3;
					this.buttonKorekta.Text = "Korekta sprzeda¿y dokumentu o zadanym ID";
					this.buttonKorekta.Click += new System.EventHandler(this.buttonKorekta_Click);
					// 
					// textID
					// 
					this.textID.Location = new System.Drawing.Point(204, 204);
					this.textID.Name = "textID";
					this.textID.Size = new System.Drawing.Size(76, 20);
					this.textID.TabIndex = 6;
					this.textID.Text = "18";
					// 
					// buttonPrzelew
					// 
					this.buttonPrzelew.FlatStyle = System.Windows.Forms.FlatStyle.System;
					this.buttonPrzelew.Location = new System.Drawing.Point(12, 248);
					this.buttonPrzelew.Name = "buttonPrzelew";
					this.buttonPrzelew.Size = new System.Drawing.Size(164, 44);
					this.buttonPrzelew.TabIndex = 4;
					this.buttonPrzelew.Text = "Faktura sprzeda¿y";
					this.buttonPrzelew.Click += new System.EventHandler(this.buttonPrzelew_Click);
					// 
					// cbGotówka
					// 
					this.cbGotówka.Checked = true;
					this.cbGotówka.CheckState = System.Windows.Forms.CheckState.Checked;
					this.cbGotówka.Location = new System.Drawing.Point(200, 252);
					this.cbGotówka.Name = "cbGotówka";
					this.cbGotówka.Size = new System.Drawing.Size(128, 24);
					this.cbGotówka.TabIndex = 7;
					this.cbGotówka.Text = "Zap³acono gotówk¹";
					// 
					// cbPrzelew
					// 
					this.cbPrzelew.Checked = true;
					this.cbPrzelew.CheckState = System.Windows.Forms.CheckState.Checked;
					this.cbPrzelew.Location = new System.Drawing.Point(200, 276);
					this.cbPrzelew.Name = "cbPrzelew";
					this.cbPrzelew.Size = new System.Drawing.Size(116, 24);
					this.cbPrzelew.TabIndex = 8;
					this.cbPrzelew.Text = "Na przelew 21 dni";
					// 
					// buttonRW
					// 
					this.buttonRW.FlatStyle = System.Windows.Forms.FlatStyle.System;
					this.buttonRW.Location = new System.Drawing.Point(12, 72);
					this.buttonRW.Name = "buttonRW";
					this.buttonRW.Size = new System.Drawing.Size(164, 48);
					this.buttonRW.TabIndex = 1;
					this.buttonRW.Text = "Generowanie dokumentu RW";
					this.buttonRW.Click += new System.EventHandler(this.buttonRW_Click);
					// 
					// buttonKontrahent
					// 
					this.buttonKontrahent.FlatStyle = System.Windows.Forms.FlatStyle.System;
					this.buttonKontrahent.Location = new System.Drawing.Point(188, 12);
					this.buttonKontrahent.Name = "buttonKontrahent";
					this.buttonKontrahent.Size = new System.Drawing.Size(164, 48);
					this.buttonKontrahent.TabIndex = 5;
					this.buttonKontrahent.Text = "Zak³adanie karty kontrahenta";
					this.buttonKontrahent.Click += new System.EventHandler(this.buttonKontrahent_Click);
					// 
					// buttonKontrahenci
					// 
					this.buttonKontrahenci.FlatStyle = System.Windows.Forms.FlatStyle.System;
					this.buttonKontrahenci.Location = new System.Drawing.Point(12, 304);
					this.buttonKontrahenci.Name = "buttonKontrahenci";
					this.buttonKontrahenci.Size = new System.Drawing.Size(164, 44);
					this.buttonKontrahenci.TabIndex = 4;
					this.buttonKontrahenci.Text = "Filtrowana lista kontrahentów";
					this.buttonKontrahenci.Click += new System.EventHandler(this.buttonKontrahenci_Click);
					// 
					// buttonTowary
					// 
					this.buttonTowary.FlatStyle = System.Windows.Forms.FlatStyle.System;
					this.buttonTowary.Location = new System.Drawing.Point(12, 360);
					this.buttonTowary.Name = "buttonTowary";
					this.buttonTowary.Size = new System.Drawing.Size(164, 44);
					this.buttonTowary.TabIndex = 4;
					this.buttonTowary.Text = "Filtrowana lista towarów";
					this.buttonTowary.Click += new System.EventHandler(this.buttonTowary_Click);
					// 
					// buttonPZZK
					// 
					this.buttonPZZK.FlatStyle = System.Windows.Forms.FlatStyle.System;
					this.buttonPZZK.Location = new System.Drawing.Point(188, 72);
					this.buttonPZZK.Name = "buttonPZZK";
					this.buttonPZZK.Size = new System.Drawing.Size(164, 48);
					this.buttonPZZK.TabIndex = 0;
					this.buttonPZZK.Text = "Generowanie z dokumentu PZ dokumentu ZK";
					this.buttonPZZK.Click += new System.EventHandler(this.buttonPZZK_Click);
					// 
					// buttonRaport
					// 
					this.buttonRaport.FlatStyle = System.Windows.Forms.FlatStyle.System;
					this.buttonRaport.Location = new System.Drawing.Point(360, 12);
					this.buttonRaport.Name = "buttonRaport";
					this.buttonRaport.Size = new System.Drawing.Size(164, 48);
					this.buttonRaport.TabIndex = 5;
					this.buttonRaport.Text = "Generowanie raportu kasowego";
					this.buttonRaport.Click += new System.EventHandler(this.buttonRaport_Click);
					// 
					// buttonWp³ata
					// 
					this.buttonWp³ata.FlatStyle = System.Windows.Forms.FlatStyle.System;
					this.buttonWp³ata.Location = new System.Drawing.Point(360, 72);
					this.buttonWp³ata.Name = "buttonWp³ata";
					this.buttonWp³ata.Size = new System.Drawing.Size(164, 48);
					this.buttonWp³ata.TabIndex = 5;
					this.buttonWp³ata.Text = "Generowanie wp³aty";
					this.buttonWp³ata.Click += new System.EventHandler(this.buttonWp³ata_Click);
					// 
					// buttonRozliczenie
					// 
					this.buttonRozliczenie.FlatStyle = System.Windows.Forms.FlatStyle.System;
					this.buttonRozliczenie.Location = new System.Drawing.Point(360, 132);
					this.buttonRozliczenie.Name = "buttonRozliczenie";
					this.buttonRozliczenie.Size = new System.Drawing.Size(164, 48);
					this.buttonRozliczenie.TabIndex = 5;
					this.buttonRozliczenie.Text = "Rozliczenie faktury";
					this.buttonRozliczenie.Click += new System.EventHandler(this.buttonRozliczenie_Click);
					// 
					// buttonEwidencjaSprzedazy
					// 
					this.buttonEwidencjaSprzedazy.FlatStyle = System.Windows.Forms.FlatStyle.System;
					this.buttonEwidencjaSprzedazy.Location = new System.Drawing.Point(360, 190);
					this.buttonEwidencjaSprzedazy.Name = "buttonEwidencjaSprzedazy";
					this.buttonEwidencjaSprzedazy.Size = new System.Drawing.Size(164, 48);
					this.buttonEwidencjaSprzedazy.TabIndex = 9;
					this.buttonEwidencjaSprzedazy.Text = "Ewidencja sprzeda¿y";
					this.buttonEwidencjaSprzedazy.Click += new System.EventHandler(this.buttonEwidencjaSprzedazy_Click);
					// 
					// Form1
					// 
					this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
					this.ClientSize = new System.Drawing.Size(532, 418);
					this.Controls.Add(this.buttonEwidencjaSprzedazy);
					this.Controls.Add(this.cbPrzelew);
					this.Controls.Add(this.cbGotówka);
					this.Controls.Add(this.textID);
					this.Controls.Add(this.buttonKorekta);
					this.Controls.Add(this.buttonPZ);
					this.Controls.Add(this.buttonINW);
					this.Controls.Add(this.buttonPrzelew);
					this.Controls.Add(this.buttonRW);
					this.Controls.Add(this.buttonKontrahent);
					this.Controls.Add(this.buttonKontrahenci);
					this.Controls.Add(this.buttonTowary);
					this.Controls.Add(this.buttonPZZK);
					this.Controls.Add(this.buttonRaport);
					this.Controls.Add(this.buttonWp³ata);
					this.Controls.Add(this.buttonRozliczenie);
					this.Name = "Form1";
					this.Text = "Form1";
					this.Load += new System.EventHandler(this.Form1_Load);
					this.ResumeLayout(false);
					this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            //
            // Przed jakimikolwiek operacjami na logice biznesowej enova
            // nale¿y zadbaæ o to, ¿eby wszystkie biblioteki by³y za³adowe.
            // Powoduje to ich automatyczne zarejestrowanie i zainicjowanie.
            //
			Soneta.Start.Loader loader = new Soneta.Start.Loader();
			loader.WithExtensions = true;
			loader.Load();

            Application.EnableVisualStyles();
            Application.DoEvents();
            Application.Run(new Form1());
        }

        private System.Windows.Forms.Button buttonPZ;
        private System.Windows.Forms.Button buttonINW;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button buttonKorekta;
        private System.Windows.Forms.Button buttonPrzelew;
        private System.Windows.Forms.CheckBox cbGotówka;
        private System.Windows.Forms.CheckBox cbPrzelew;
        private System.Windows.Forms.Button buttonRW;
        private System.Windows.Forms.Button buttonKontrahent;
        private System.Windows.Forms.Button buttonKontrahenci;
        private System.Windows.Forms.Button buttonTowary;
        private System.Windows.Forms.Button buttonPZZK;
        private System.Windows.Forms.Button buttonRaport;
        private System.Windows.Forms.Button buttonWp³ata;
        private System.Windows.Forms.Button buttonRozliczenie;
			private Button buttonEwidencjaSprzedazy;

        /// <summary>
        /// To jest pole zawieraj¹ce informacje o loginie do bazy danych,
        /// na którym bêd¹ robione wszystkie operacje.
        /// </summary>
        Login login;

        #region Inicjacja po³¹czenia do bazy danych

        private void Form1_Load(object sender, System.EventArgs e) {
            /////////////////////////////////////////////////////////////////
            // Nastêpnie uzyskujemy dostêp do obiektu bazy danych
            // reprezentuj¹cego bazê danych jako tak¹, bez zalogowanego
            // jeszcze operatora. Rejestrowanie bazy danych mo¿na zrobiæ 
            // przy pomocy programu enova. Napis "Demo" jest nazw¹ bazy
            // wyœwietlan¹ w programie enova.
            //
            Database database = BusApplication.Instance["Demo"];

            ////////////////////////////////////////////////////////////////
            // Kolejnym krokiem jest uzyskanie loginu do bazy danych, czyli
            // zalogowanie siê operatora. Oczywiœcie odpowiedni operator
            // musi byæ wczeœniej wprowadzony w programie enova.
            // W przyk³adzie poni¿ej logujê siê na operatora "Administrator"
            // z pustym has³em (brak has³a).
            //
            login = database.Login(false, "Administrator", "");
        }

        #endregion

        #region Utworzenie dokumentu PZ

        private void buttonPZ_Click(object sender, System.EventArgs e) {
            ///////////////////////////////////////////////////////////////////
            // Metoda tworzy nowy dokument PZ wype³niaj¹c go przyk³adowymi
            // pozycjami
            //

            //////////////////////////////////////////////////////////////////
            // Rozpoczêcie tworzenia dokumentu (w ogóle operacji na logice
            // biznesowej) polega na utworzeniu obiektu sesji (Session),
            // w którym bêd¹ odbywaæ siê poszczególne operacje.
            // Pierwszy parametr okreœla, czy sesja jest tylko do odczytu
            // danych, drugi parametr, czy sesja bêdzie modyfikowaæ ustawienia
            // konfiguracyjne (tj definicje dokumentów, jednostki, 
            // definicje cen, itp). Standardowo obydwa parametry dajemy false.
            //
            using (Session session = login.CreateSession(false, false)) {

                //////////////////////////////////////////////////////////////////
                // Po utworzeniu sesji dobrze jest sobie przygotowaæ odpowiednie 
                // zmiene reprezentuj¹ce poszczególne modu³y programu w tej sesji.
                // Wystarczy przygotwaæ tylko te modu³y, które bêd¹ nam potrzebne.
                //
                HandelModule hm = HandelModule.GetInstance(session);
                TowaryModule tm = TowaryModule.GetInstance(session);
                MagazynyModule mm = MagazynyModule.GetInstance(session);
                CRMModule cm = CRMModule.GetInstance(session);

                //////////////////////////////////////////////////////////////////
                // Wszystkie operacje wykonujemy w transakcji sesji któr¹ nale¿y
                // na pocz¹tku otworzyæ. W transakcji mo¿emy wskazaæ czy bêd¹ 
                // robione zmiany w danych.
                //
                using (ITransaction trans = session.Logout(true)) {

                    //////////////////////////////////////////////////////////////////
                    // Nastêpnie nale¿y utworzyæ nowy obiekt reprezentuj¹cy dokument
                    // handlowy (nag³ówek dokumentu). 
                    //
                    DokumentHandlowy dokument = new DokumentHandlowy();
		
                    //////////////////////////////////////////////////////////////////
                    // Nowy dokument nalezy równie¿ zwi¹zaæ z definicj¹ dokumentu 
                    // handlowego. W tym przypadku wyszukujemy definicje wyszukujemy
                    // wg jej symbolu "PZ".
                    //
                    DefDokHandlowego definicja = hm.DefDokHandlowych.WgSymbolu["PZ"];
                    if (definicja==null) 
                        throw new InvalidOperationException("Nieznaleziona definicja dokumentu PZ.");
                    dokument.Definicja = definicja;

                    /////////////////////////////////////////////////////////////////
                    // Dokument nale¿y te¿ przypisaæ do magazynu, do którego bêdzie
                    // przyjmowany towar. Poni¿ej przypisywany jest standardowy
                    // magazyn programu "Firma".
                    //
                    dokument.Magazyn = mm.Magazyny.Firma;

                    /////////////////////////////////////////////////////////////////
                    // Oraz dodajemy nowo utworzony dokument do aktualnej sesji.
                    //
                    hm.DokHandlowe.AddRow(dokument);

                    /////////////////////////////////////////////////////////////////
                    // Przyjêcie magazynowe PZ (z zewn¹trz) wymaga równie¿
                    // przypisania kontrahenta, od którego towaru jest przyjmowany.
                    // Przyk³ad prezentuje przypisanie dokumentowi kontrahenta
                    // o kodzie "ABC".
                    Kontrahent kontrahent = cm.Kontrahenci.WgKodu["ABC"];
                    if (kontrahent==null) 
                        throw new InvalidOperationException("Nieznaleziony kontrahent o kodzie ABC.");
                    dokument.Kontrahent = kontrahent;

                    /////////////////////////////////////////////////////////////////
                    // PUNKT A ******************************************************
                    // W kartotece towarów wyszukaæ towar. Przyk³ad poni¿ej
                    // prezentuje wyszukanie towaru wg kodu EAN "2000000000022". 
                    // Poniewa¿ w kartotece mo¿e znajdowaæ siê wiele towarów o tym 
                    // samym kodzie wybrazy zostanie pierwszy z nich.
                    //
					Towar towar = (Towar)tm.Towary.WgEAN["2000000000954"].GetNext();
                    if (towar!=null) {
                        //////////////////////////////////////////////////////////////
                        // Utworzyæ nowy obiekt pozycji dokumentu handlowego, który
                        // zostanie dodany do sescji.
                        //
                        PozycjaDokHandlowego pozycja = new PozycjaDokHandlowego(dokument);
                        hm.PozycjeDokHan.AddRow(pozycja);

                        //////////////////////////////////////////////////////////////
                        // Przypisaæ towar do nowo utworzonej pozycji dokumentu, czyli
                        // wskazaæ, który towar ma byæ przyjêty do magazynu.
                        //
                        pozycja.Towar = towar;

                        //////////////////////////////////////////////////////////////
                        // W pozycji dokumentu nale¿y jeszcze wprowadziæ iloœæ
                        // towaru przyjmowanego na magazyn. Iloœæ reprezentowana jest
                        // przez liczbê 10 bêd¹c¹ wartoœci¹ iloœci (pierwszy parametr) 
                        // oraz jednostkê opisuj¹c¹ tê iloœæ (drugi parametr). Je¿eli
                        // jednostka jest null, to przyjmowana jest jednostka z
                        // karty towarowej.
                        // Poni¿ej znajduje siê równie¿ wykomentowany przyk³ad, w
                        // którym w sposób jawny jest wskazanie na jednostkê w metrach.
                        //
                        pozycja.Ilosc = new Quantity(10, null);
                        // pozycja.Ilosc = new Quantity(10, "m");

                        //////////////////////////////////////////////////////////////
                        // Pozycji dokumentu nale¿y równie¿ przypisaæ cenê w jakiej
                        // bêdzie on wprowadzany do magazynu. (cena zakupu)
                        // Poni¿ej przypisywana jest cena w PLN. Dlatego nie jest
                        // wyspecyfikowany drugi parametr okreœlaj¹cy walutê ceny.
                        //
                        pozycja.Cena = new DoubleCy(12.34);

                        //////////////////////////////////////////////////////////////
                        // Poszczególnym pozycj¹ mo¿na przypisaæ równie¿ dodatkowe
                        // cechy, które zale¿ne s¹ od konfiguracji programu. Przyk³ad
                        // pokazuje jak ustawiæ cechê z numerem beli.
                        // Kod jest wykomentowany, poniewa¿ baza demo nie posiada
                        // zdefiniowanej tej cechy.
                        //
                        //pozycja.Features["Numer beli"] = "123456";
                    }

                    /////////////////////////////////////////////////////////////////
                    // Je¿eli na dokument ma zawieraæ wiêcej pozycji magazynowych
                    // to nale¿y ponownie przejœæ do PUNKTU A.
                    //

                    /////////////////////////////////////////////////////////////////
                    // Dokumentowi podobnie jak pozycji dokumentu równie¿ mo¿na
                    // przypisaæ dodatkowe cechy zale¿ne od konfiguracji programu. 
                    // Przyk³ad pokazuje jak ustawiæ cechê z lokalizacj¹.
                    // Kod jest wykomentowany, poniewa¿ baza demo nie posiada
                    // zdefiniowanej tej cechy.
                    //
                    //dokument.Features["Lokalizacja"] = "AB/12";

                    /////////////////////////////////////////////////////////////////
                    // Po dokonaniu wszystkich operacji na dokumencie mo¿na ten
                    // dokument wprowadziæ (zatwierdziæ), co powoduje zabezpieczenie 
                    // przed przypadkow¹ edycj¹ tego dokumentu oraz przeniesienie go
                    // do ewidencji dokumentów ksiêgowych.
                    //
                    dokument.Stan = StanDokumentuHandlowego.Zatwierdzony;

                    /////////////////////////////////////////////////////////////////
                    // Wszystkie operacje zosta³y poprawnie zakoñczone i zapewne 
                    // chcemy zatwierdziæ transakcjê sesji.
                    //
                    trans.Commit();
                }

                ////////////////////////////////////////////////////////////////////
                // Powy¿sze operacje by³y wykonywane na sesji, czyli w pamiêci.
                // Teraz nale¿y rezultat prac zapisaæ do bazy danych.
                //
                session.Save();
            }

            ////////////////////////////////////////////////////////////////////
            // I to wszystko. Dokument PZ znajduje siê w bazie.
            //
        }

        #endregion

        #region Utworzenie dokumentu inwentraryzacji

        private void buttonINW_Click(object sender, System.EventArgs e) {
            ///////////////////////////////////////////////////////////////////
            // Metoda tworzy nowy dokument inwentaryzacji wype³niaj¹c go 
            // przyk³adowymi pozycjami
            //

            //////////////////////////////////////////////////////////////////
            // Rozpoczêcie tworzenia dokumentu (w ogóle operacji na logice
            // biznesowej) polega na utworzeniu obiektu sesji (Session),
            // w którym bêd¹ odbywaæ siê poszczególne operacje.
            // Pierwszy parametr okreœla, czy sesja jest tylko do odczytu
            // danych, drugi parametr, czy sesja bêdzie modyfikowaæ ustawienia
            // konfiguracyjne (tj definicje dokumentów, jednostki, 
            // definicje cen, itp). Standardowo obydwa parametry dajemy false.
            //
            using (Session session = login.CreateSession(false, false)) {

                //////////////////////////////////////////////////////////////////
                // Po utworzeniu sesji dobrze jest sobie przygotowaæ odpowiednie 
                // zmiene reprezentuj¹ce poszczególne modu³y programu w tej sesji.
                // Wystarczy przygotwaæ tylko te modu³y, które bêd¹ nam potrzebne.
                //
                HandelModule hm = HandelModule.GetInstance(session);
                TowaryModule tm = TowaryModule.GetInstance(session);
                MagazynyModule mm = MagazynyModule.GetInstance(session);
                CRMModule cm = CRMModule.GetInstance(session);

                //////////////////////////////////////////////////////////////////
                // Wszystkie operacje wykonujemy w transakcji sesji, któr¹ nale¿y
                // na pocz¹tku otworzyæ. W transakcji mo¿emy wskazaæ czy bêd¹ 
                // robione zmiany w danych.
                //
                using (ITransaction trans = session.Logout(true)) {

                    //////////////////////////////////////////////////////////////////
                    // Nastêpnie nale¿y utworzyæ nowy obiekt reprezentuj¹cy dokument
                    // handlowy (nag³ówek dokumentu). 
                    //
                    DokumentHandlowy dokument = new DokumentHandlowy();
		
                    //////////////////////////////////////////////////////////////////
                    // Nowy dokument nale¿y równie¿ zwi¹zaæ z definicj¹ dokumentu 
                    // handlowego. W tym przypadku wyszukujemy definicje wyszukujemy
                    // z kolekcji standardowych definicji.
                    //
                    dokument.Definicja = hm.DefDokHandlowych.Inwentaryzacja;

                    /////////////////////////////////////////////////////////////////
                    // Dokument nale¿y te¿ przypisaæ do magazynu, do którego bêdzie
                    // przyjmowany towar. Poni¿ej przypisywany jest standardowy
                    // magazyn programu "Firma".
                    //
                    dokument.Magazyn = mm.Magazyny.Firma;
				
                    // Ale mo¿na wyszukaæ magazyn np wg symbolu
                    //dokument.Magazyn = mm.Magazyny.WgSymbol["MAG1"];

                    /////////////////////////////////////////////////////////////////
                    // Oraz dodajemy nowo utworzony dokument do aktualnej sesji.
                    //
                    hm.DokHandlowe.AddRow(dokument);

                    /////////////////////////////////////////////////////////////////
                    // PUNKT A ******************************************************
                    // W kartotece towarów wyszukaæ towar. Przyk³ad poni¿ej
                    // prezentuje wyszukanie towaru wg kodu "Buty"
                    // Poniewa¿ w kartotece mo¿e znajdowaæ siê wiele towarów o tym 
                    // samym kodzie wybrazy zostanie pierwszy z nich.
                    //
                    Towar towar = (Towar)tm.Towary.WgKodu["Buty"];
                    if (towar!=null) {
                        //////////////////////////////////////////////////////////////
                        // Utworzyæ nowy obiekt pozycji dokumentu handlowego, który
                        // zostanie dodany do sescji.
                        //
                        PozycjaDokHandlowego pozycja = new PozycjaDokHandlowego(dokument);
                        hm.PozycjeDokHan.AddRow(pozycja);

                        //////////////////////////////////////////////////////////////
                        // Przypisaæ towar do nowo utworzonej pozycji dokumentu, czyli
                        // wskazaæ, który towar ma byæ przyjêty do magazynu.
                        //
                        pozycja.Towar = towar;

                        //////////////////////////////////////////////////////////////
                        // W pozycji dokumentu nale¿y jeszcze wprowadziæ iloœæ
                        // towaru przyjmowanego na magazyn. Iloœæ reprezentowana jest
                        // przez liczbê 10 bêd¹c¹ wartoœci¹ iloœci (pierwszy parametr) 
                        // oraz jednostkê opisuj¹c¹ tê iloœæ (drugi parametr). Je¿eli
                        // jednostka jest null, to przyjmowana jest jednostka z
                        // karty towarowej.
                        // Poni¿ej znajduje siê równie¿ wykomentowany przyk³ad, w
                        // którym w sposób jawny jest wskazanie na jednostkê w metrach.
                        //
                        pozycja.Ilosc = new Quantity(10, null);
                        // pozycja.Ilosc = new Quantity(10, "m");

                        //////////////////////////////////////////////////////////////
                        // Pozycji dokumentu nale¿y równie¿ przypisaæ cenê w jakiej
                        // bêdzie on wprowadzany do magazynu. (cena zakupu)
                        // Poni¿ej przypisywana jest cena w PLN. Dlatego nie jest
                        // wyspecyfikowany drugi parametr okreœlaj¹cy walutê ceny.
                        //
                        pozycja.Cena = new DoubleCy(12.34);

                        //////////////////////////////////////////////////////////////
                        // Poszczególnym pozycj¹ mo¿na przypisaæ równie¿ dodatkowe
                        // cechy, które zale¿ne s¹ od konfiguracji programu. Przyk³ad
                        // pokazuje jak ustawiæ cechê z numerem beli.
                        // Kod jest wykomentowany, poniewa¿ baza demo nie posiada
                        // zdefiniowanej tej cechy.
                        //
                        //pozycja.Features["Numer beli"] = "123456";
                    }

                    /////////////////////////////////////////////////////////////////
                    // Je¿eli na dokument ma zawieraæ wiêcej pozycji magazynowych
                    // to nale¿y ponownie przejœæ do PUNKTU A.
                    //

                    /////////////////////////////////////////////////////////////////
                    // Dokumentowi podobnie jak pozycji dokumentu równie¿ mo¿na
                    // przypisaæ dodatkowe cechy zale¿ne od konfiguracji programu. 
                    // Przyk³ad pokazuje jak ustawiæ cechê z lokalizacj¹.
                    // Kod jest wykomentowany, poniewa¿ baza demo nie posiada
                    // zdefiniowanej tej cechy.
                    //
                    //dokument.Features["Lokalizacja"] = "AB/12";

                    /////////////////////////////////////////////////////////////////
                    // Wszystkie operacje zosta³y poprawnie zakoñczone i zapewne 
                    // chcemy zatwierdziæ transakcjê sesji.
                    //
                    trans.Commit();
                }

                ////////////////////////////////////////////////////////////////////
                // Powy¿sze operacje by³y wykonywane na sesji, czyli w pamiêci.
                // Teraz nale¿y rezultat prac zapisaæ do bazy danych.
                //
                session.Save();
            }

            ////////////////////////////////////////////////////////////////////
            // I to wszystko. Dokument inwentaryzacji znajduje siê ju¿ w bazie.
            // Dokument ten znajduje siê w buforze, wiêc ¿eby stany magazynowe
            // mog³y byæ zmodyfikowane nale¿y zatwierdziæ ten wygenerowany 
            // w³aœnie dokument.
            //
        }

        #endregion

        #region Korekta dokuemntu o zadanym ID

        private void buttonKorekta_Click(object sender, System.EventArgs e) {
            ///////////////////////////////////////////////////////////////////
            // Metoda tworzy dokuemnt koryguj¹cy do faktury o zadanym ID
            // Nie umieszczam, które mo¿na znaleŸæ w poprzednich przyk³adach
            //

            using (Session session = login.CreateSession(false, false)) {

                HandelModule hm = HandelModule.GetInstance(session);
                TowaryModule tm = TowaryModule.GetInstance(session);
                MagazynyModule mm = MagazynyModule.GetInstance(session);
                CRMModule cm = CRMModule.GetInstance(session);

                using (ITransaction trans = session.Logout(true)) {

                    //////////////////////////////////////////////////////////////////
                    // Wyszukaæ dokument sprzeda¿y o wczeœniej wprowadzonym ID
                    //
                    int id = int.Parse(textID.Text);
                    DokumentHandlowy dokument = hm.DokHandlowe[id];
		
                    //////////////////////////////////////////////////////////////////
                    // Wyszukaæ definicjê relacji korekty dla danego typu dokumentu
                    //
                    DefRelacjiKorekta defKorekta =
                        dokument.Definicja.RelacjaKorektyDefinicja as DefRelacjiKorekta;
                    if (defKorekta==null)
                        throw new InvalidOperationException("Dokument "+dokument+" nie ma zdefiniowanej relacji korekty.");

                    /////////////////////////////////////////////////////////////////
                    // Utworzyæ dokument korekty. Dokument korenty ma byæ tworzony 
                    // zawsze dla pierwszej faktury. Czyli korekta jest robiona dla
                    // "pierwszej" faktury.
                    //
                    DokumentHandlowy korekta = defKorekta.KorygujDokument(dokument);
				
                    /////////////////////////////////////////////////////////////////
                    // Nastêpnie mo¿na zmodyfikowaæ pozycje na tym dokumencie.
                    //
                    foreach (PozycjaDokHandlowego pozycja in korekta.Pozycje) {

                        /////////////////////////////////////////////////////////////////
                        // Tutaj nale¿y dokonaæ zmian pozycji
                        //

                    }

                    /////////////////////////////////////////////////////////////////
                    // Na koniec mo¿na dokument zatwierdziæ.
                    //

                    korekta.Stan = StanDokumentuHandlowego.Zatwierdzony;

                    trans.Commit();
                }

                session.Save();
            }
        }

        #endregion

        #region Faktura VAT

        ///////////////////////////////////////////////////////////////////
        // Metoda tworzy nowy faktury VAT wype³niaj¹c go przyk³adowymi
        // pozycjami.
        // Robimy to tak samo jak dokument PZ, z tym, ¿e szukamy definicji FV.
        // Nastêpnie modyfikujemy p³atnoœci na przelew lub zap³acone gotówk¹.
        private void buttonPrzelew_Click(object sender, System.EventArgs e) {
            using (Session session = login.CreateSession(false, false)) {

                HandelModule hm = HandelModule.GetInstance(session);
                TowaryModule tm = TowaryModule.GetInstance(session);
                MagazynyModule mm = MagazynyModule.GetInstance(session);
                CRMModule cm = CRMModule.GetInstance(session);

                using (ITransaction trans = session.Logout(true)) {
                    DokumentHandlowy dokument = new DokumentHandlowy();
                    DefDokHandlowego definicja = hm.DefDokHandlowych.WgSymbolu["FV"];
                    if (definicja==null) 
                        throw new InvalidOperationException("Nieznaleziona definicja dokumentu FV.");
                    dokument.Definicja = definicja;

                    dokument.Magazyn = mm.Magazyny.Firma;

                    hm.DokHandlowe.AddRow(dokument);

                    Kontrahent kontrahent = cm.Kontrahenci.WgKodu["ABC"];
                    if (kontrahent==null) 
                        throw new InvalidOperationException("Nieznaleziony kontrahent o kodzie ABC.");
                    dokument.Kontrahent = kontrahent;

                    Towar towar = (Towar)tm.Towary.WgEAN["2000000000022"].GetNext();
                    if (towar!=null) {
                        PozycjaDokHandlowego pozycja = new PozycjaDokHandlowego(dokument);
                        hm.PozycjeDokHan.AddRow(pozycja);
                        pozycja.Towar = towar;
                        pozycja.Ilosc = new Quantity(10, null);
                        pozycja.Cena = new DoubleCy(12.34);
                    }

                    ///////////////////////////////////////////////////////////////////
                    //Modyfikacja p³atnoœci
                    //Standradowo dokument ma wygenerowan¹ przez system jedn¹ p³atnoœæ. Zmienimy w niej
                    //sposób zap³aty, domyœln¹ ewidencjê oraz termin p³atnoœci.
                    //Je¿eli chcemy mieæ wiêcej ni¿ jedn¹ p³atnoœæ, to zmniejszamy kwotê w instniej¹cej
                    //i dodajemy kolejne p³atnoœci a¿ do zrównowa¿enia kwoty p³atnoœci i dokumentu.
                    //Dodatkowo, je¿eli generujemy p³atnoœæ gotówkow¹, to dodamy do niej informacjê
                    //o zap³acieniu i odpowiedni wpis na raport kasowy (musi byæ za³o¿ony 
                    //  i niezatwierdzony)

                    //Wymuszamy przeliczenie zdarzeñ. W przeciwnym razie sumy mog¹ byæ nieaktualne
                    //Normalnie robi to za nas UI
                    session.Events.Invoke();

                    KasaModule kasa = KasaModule.GetInstance(session);

                    Naleznosc gotówka = null;
                    Naleznosc przelew = null;
                    //Pobieramy isntniejac¹ p³atnoœæ. System zrobi³ na pewno jedn¹ (o ile wartoœæ
                    //dokumentu jest ró¿na od zera).
                    //Mo¿emy te¿ p³atnoœæ usun¹æ i odtworzyæ dok³adnie tak samo jak to jest 
                    //robione z dodatkow¹ p³atnoœci¹
                    Naleznosc p³atnoœæ = (Naleznosc)dokument.Platnosci.GetNext();
                    if (cbGotówka.Checked && cbPrzelew.Checked) {
                        Currency kwota = p³atnoœæ.Kwota;
                        p³atnoœæ.Kwota = p³atnoœæ.Kwota/2;
                        gotówka = p³atnoœæ;
                        //Tworzymy nowy obiekt nale¿noœci
                        przelew = new Naleznosc(dokument);
                        //Dodajemy go do tabeli Platnosci
                        kasa.Platnosci.AddRow(przelew);
                        //I ustawiamy kwotê
                        przelew.Kwota = kwota - gotówka.Kwota;
                    }
                    else if (cbGotówka.Checked)
                        gotówka = p³atnoœæ;
                    else if (cbPrzelew.Checked)
                        przelew = p³atnoœæ;

                    //Mamy ju¿ potrzebne p³atnoœci. Teraz musimy im zmodyfikowaæ sposób zap³aty,
                    //ewidencjê SP oraz termin p³atnoœci
                    //Najpier przelew
                    if (przelew!=null) {
                        //Wyszukujemy sposób zap³aty. Na szczêœcie dla gotówki mamy standardowy
                        //Mo¿emy te¿ szukaæ wg nazwy lub Guid.
                        przelew.SposobZaplaty = kasa.SposobyZaplaty.Przelew;

                        //Szukamy ewidencjê SP.
                        przelew.EwidencjaSP = kasa.EwidencjeSP.WgNazwy["Firmowy rachunek bankowy"];

                        //I termin p³atnoœci
                        przelew.TerminDni = 21;
                    }

                    if (gotówka!=null) {
                        //Wyszukujemy sposób zap³aty. Na szczêœcie dla gotówki mamy standardowy
                        //Mo¿emy te¿ szukaæ wg nazwy lub Guid.
                        gotówka.SposobZaplaty = kasa.SposobyZaplaty.Gotówka;

                        //Szukamy ewidencjê SP.
                        gotówka.EwidencjaSP = kasa.EwidencjeSP.WgNazwy["Kasa gotówkowa"];

                        //I termin p³atnoœci
                        gotówka.TerminDni = 0;

                        //Pozostaje to teraz zap³aciæ
                        //Szukamy raportu kasowego. Musi byæ istnieæ i byæ otwarty lub 
                        //nie istnieæ i mieæ flagê automatyczny.
                        //Oczywiœcie ewidencja SP musi byæ typu kasa.
                        RaportESP raport = ((Kasa)gotówka.EwidencjaSP).NowyRaport(dokument, dokument.Data);
                        //Tworzymy nowy dokument wp³aty
                        Wplata wp³ata = new Wplata(dokument, raport);
                        //Dodajemy go do tabeli
                        kasa.Zaplaty.AddRow(wp³ata);
                        //Ustawiamy podmiot (taki jak w nale¿noœci)
                        wp³ata.Podmiot = dokument.Kontrahent;
                        //... sposób zap³aty
                        wp³ata.SposobZaplaty = gotówka.SposobZaplaty;
                        //... opis wystawrczy zainicjowaæ, zostanie przeliczony podczas zapisu
                        wp³ata.Opis = "?";
                        //Oraz oczywiœcie kwotê.
                        wp³ata.Kwota = gotówka.Kwota;

                        //Wp³ata z nale¿noœci¹ zostan¹ rozliczone podczas zatwierdzania dokumentu
                    }

                    //...
                    dokument.Stan = StanDokumentuHandlowego.Zatwierdzony;

                    trans.Commit();
                }

                session.Save();
            }
        }

        #endregion

        #region Utworzenie dokumentu RW

        private void buttonRW_Click(object sender, System.EventArgs e) {
            ///////////////////////////////////////////////////////////////////
            // Metoda tworzy nowy dokument RW wype³niaj¹c go przyk³adowymi
            // pozycjami
            //

            //////////////////////////////////////////////////////////////////
            // Rozpoczêcie tworzenia dokumentu (w ogóle operacji na logice
            // biznesowej) polega na utworzeniu obiektu sesji (Session),
            // w którym bêd¹ odbywaæ siê poszczególne operacje.
            // Pierwszy parametr okreœla, czy sesja jest tylko do odczytu
            // danych, drugi parametr, czy sesja bêdzie modyfikowaæ ustawienia
            // konfiguracyjne (tj definicje dokumentów, jednostki, 
            // definicje cen, itp). Standardowo obydwa parametry dajemy false.
            //
            using (Session session = login.CreateSession(false, false)) {

                //////////////////////////////////////////////////////////////////
                // Po utworzeniu sesji dobrze jest sobie przygotowaæ odpowiednie 
                // zmiene reprezentuj¹ce poszczególne modu³y programu w tej sesji.
                // Wystarczy przygotwaæ tylko te modu³y, które bêd¹ nam potrzebne.
                //
                HandelModule hm = HandelModule.GetInstance(session);
                TowaryModule tm = TowaryModule.GetInstance(session);
                MagazynyModule mm = MagazynyModule.GetInstance(session);
                CRMModule cm = CRMModule.GetInstance(session);

                //////////////////////////////////////////////////////////////////
                // Wszystkie operacje wykonujemy w transakcji sesji któr¹ nale¿y
                // na pocz¹tku otworzyæ. W transakcji mo¿emy wskazaæ czy bêd¹ 
                // robione zmiany w danych.
                //
                using (ITransaction trans = session.Logout(true)) {

                    //////////////////////////////////////////////////////////////////
                    // Nastêpnie nale¿y utworzyæ nowy obiekt reprezentuj¹cy dokument
                    // handlowy (nag³ówek dokumentu). 
                    //
                    DokumentHandlowy dokument = new DokumentHandlowy();
		
                    //////////////////////////////////////////////////////////////////
                    // Nowy dokument nalezy równie¿ zwi¹zaæ z definicj¹ dokumentu 
                    // handlowego. W tym przypadku wyszukujemy definicje wyszukujemy
                    // wg jej symbolu "PZ".
                    //
                    DefDokHandlowego definicja = hm.DefDokHandlowych.WgSymbolu["RW"];
                    if (definicja==null) 
                        throw new InvalidOperationException("Nieznaleziona definicja dokumentu RW.");
                    dokument.Definicja = definicja;

                    /////////////////////////////////////////////////////////////////
                    // Dokument nale¿y te¿ przypisaæ do magazynu, do którego bêdzie
                    // przyjmowany towar. Poni¿ej przypisywany jest standardowy
                    // magazyn programu "Firma".
                    //
                    dokument.Magazyn = mm.Magazyny.Firma;

                    /////////////////////////////////////////////////////////////////
                    // Oraz dodajemy nowo utworzony dokument do aktualnej sesji.
                    //
                    hm.DokHandlowe.AddRow(dokument);

                    /////////////////////////////////////////////////////////////////
                    // PUNKT A ******************************************************
                    // W kartotece towarów wyszukaæ towar. Przyk³ad poni¿ej
                    // prezentuje wyszukanie towaru wg kodu EAN "2000000000022". 
                    // Poniewa¿ w kartotece mo¿e znajdowaæ siê wiele towarów o tym 
                    // samym kodzie wybrazy zostanie pierwszy z nich.
                    //
					Towar towar = tm.Towary.WgKodu["BIKINI"];
                    if (towar!=null) {
                        //////////////////////////////////////////////////////////////
                        // Utworzyæ nowy obiekt pozycji dokumentu handlowego, który
                        // zostanie dodany do sescji.
                        //
                        PozycjaDokHandlowego pozycja = new PozycjaDokHandlowego(dokument);
                        hm.PozycjeDokHan.AddRow(pozycja);

                        //////////////////////////////////////////////////////////////
                        // Przypisaæ towar do nowo utworzonej pozycji dokumentu, czyli
                        // wskazaæ, który towar ma byæ wydany z magazynu.
                        //
                        pozycja.Towar = towar;

                        //////////////////////////////////////////////////////////////
                        // W pozycji dokumentu nale¿y jeszcze wprowadziæ iloœæ
                        // towaru wydawanego z magazynu. Iloœæ reprezentowana jest
                        // przez liczbê 10 bêd¹c¹ wartoœci¹ iloœci (pierwszy parametr) 
                        // oraz jednostkê opisuj¹c¹ tê iloœæ (drugi parametr). Je¿eli
                        // jednostka jest null, to przyjmowana jest jednostka z
                        // karty towarowej.
                        // Poni¿ej znajduje siê równie¿ wykomentowany przyk³ad, w
                        // którym w sposób jawny jest wskazanie na jednostkê w metrach.
                        //
                        pozycja.Ilosc = new Quantity(10, null);
                        // pozycja.Ilosc = new Quantity(10, "m");

                        //////////////////////////////////////////////////////////////
                        // Pozycji dokumentu nale¿y równie¿ przypisaæ cenê w jakiej
                        // bêdzie on wprowadzany do magazynu. (cena zakupu)
                        // Poni¿ej przypisywana jest cena w PLN. Dlatego nie jest
                        // wyspecyfikowany drugi parametr okreœlaj¹cy walutê ceny.
                        //
                        pozycja.Cena = new DoubleCy(12.34);

                        //////////////////////////////////////////////////////////////
                        // Poszczególnym pozycj¹ mo¿na przypisaæ równie¿ dodatkowe
                        // cechy, które zale¿ne s¹ od konfiguracji programu. Przyk³ad
                        // pokazuje jak ustawiæ cechê z numerem beli.
                        // Kod jest wykomentowany, poniewa¿ baza demo nie posiada
                        // zdefiniowanej tej cechy.
                        //
                        //pozycja.Features["Numer beli"] = "123456";
                    }

                    /////////////////////////////////////////////////////////////////
                    // Je¿eli na dokument ma zawieraæ wiêcej pozycji magazynowych
                    // to nale¿y ponownie przejœæ do PUNKTU A.
                    //

                    /////////////////////////////////////////////////////////////////
                    // Dokumentowi podobnie jak pozycji dokumentu równie¿ mo¿na
                    // przypisaæ dodatkowe cechy zale¿ne od konfiguracji programu. 
                    // Przyk³ad pokazuje jak ustawiæ cechê z lokalizacj¹.
                    // Kod jest wykomentowany, poniewa¿ baza demo nie posiada
                    // zdefiniowanej tej cechy.
                    //
                    //dokument.Features["Lokalizacja"] = "AB/12";

                    /////////////////////////////////////////////////////////////////
                    // W przypadku tego dokumentu przed zatwierdzeniem nale¿y 
                    // wczeœniej odpaliæ zdarzenia, które przelicz¹ stany magazynowe.
                    session.Events.Invoke();

                    /////////////////////////////////////////////////////////////////
                    // Po dokonaniu wszystkich operacji na dokumencie mo¿na ten
                    // dokument wprowadziæ (zatwierdziæ), co powoduje zabezpieczenie 
                    // przed przypadkow¹ edycj¹ tego dokumentu oraz przeniesienie go
                    // do ewidencji dokumentów ksiêgowych.
                    //
                    dokument.Stan = StanDokumentuHandlowego.Zatwierdzony;

                    /////////////////////////////////////////////////////////////////
                    // Wszystkie operacje zosta³y poprawnie zakoñczone i zapewne 
                    // chcemy zatwierdziæ transakcjê sesji.
                    //
                    trans.Commit();
                }

                ////////////////////////////////////////////////////////////////////
                // Powy¿sze operacje by³y wykonywane na sesji, czyli w pamiêci.
                // Teraz nale¿y rezultat prac zapisaæ do bazy danych.
                //
                session.Save();
            }

            ////////////////////////////////////////////////////////////////////
            // I to wszystko. Dokument RW znajduje siê w bazie.
            //
        }

        #endregion

        #region Zak³adanie karty kontrahenta

        private void buttonKontrahent_Click(object sender, System.EventArgs e) {
            //
            // Przed rozpoczêciem dodawania nowego obiektu biznesowego 
            // (tj kontrahenta) nale¿y tak jak zwykle utworzyæ obiekt sesji
            //
            using (Session session = login.CreateSession(false, false)) {

                //
                // Do kontrahentów wystarczy uzyskaæ modu³ CRM, w którym
                // znajduje siê odpowiednia kolekcja
                //
                CRMModule cm = CRMModule.GetInstance(session);

                //
                // Nastêpnie przeba otworzyæ transakcje biznesow¹ (nie bazodanow¹)
                // do edycji
                //
                using (ITransaction trans = session.Logout(true)) {

                    //
                    // Tworzymy nowy, pusty obiekt kontrahenta 
                    //
                    Kontrahent kontrahent = new Kontrahent();

                    //
                    // Nastêpnie dodajemy pusty obiekt kontrahenta do tabeli. 
                    //
                    cm.Kontrahenci.AddRow(kontrahent);
					
                    //
                    // Inicjujemy wymagane pole kod kontrahenta na przypadkow¹ wartoœæ.
                    // Pole jest unikalne w bazie danych, wieæ je¿eli kontranhent
                    // o zadanym kodzie ju¿ istnienie w bazie danych, to podczas podstawiania
                    // wartoœci do property zostanie wygenerowany wyj¹tek.
                    //
                    int nr = new Random().Next(10000);
                    kontrahent.Kod = "KOD"+nr;

                    //
                    // Inicjujemy nazwê kontrahenta. To pole nie jest ju¿ unikalne.
                    // 
                    kontrahent.Nazwa = "Nazwa "+nr;

                    //
                    // Inicjujemy pozosta³e pola, które chcemy zainicjowaæ
                    //
                    kontrahent.NIP = "123-45-67-890";
                    kontrahent.Adres.Ulica = "Szara";
                    kontrahent.Adres.NrDomu = "12";
                    kontrahent.Adres.NrLokalu = "34";
                    kontrahent.Adres.Miejscowosc = "Kraków";
			
                    // 
                    // Zatwierdzamy transakcjê biznesow¹
                    //
                    trans.Commit();
                }

                //
                // A na koñcu ca³oœæ zapisujemy do bazy danych
                //
                session.Save();
            }
        }

        #endregion

        #region Przegl¹danie listy kontrahentów

        private void buttonKontrahenci_Click(object sender, System.EventArgs e) {
            //
            // Przygotowaæ zmienn¹ do gromadzenia wyników.
            //
            ArrayList rezultat = new ArrayList();

            //
            // Do przegl¹dania obiektów w bazie danych wystarczy otworzyæ sesje
            // w trybie read-only, pierwszy parametr true
            //
            using (Session session = login.CreateSession(true, false)) {

                //
                // Kontrahenci znajduj¹ siê w module CRM
                //
                CRMModule cm = CRMModule.GetInstance(session);

                //
                // Nastêpnie odczytujemy obiekt reprezentuj¹cy tabele 
                // wszystkich kontrahentów znajduj¹cych siê w bazie danych.
                //
                Kontrahenci kontrahenci = cm.Kontrahenci;

                //
                // Je¿eli chcemy przegl¹dn¹æ wszystkich kontrahentów to
                // mo¿na wykorzystaæ enumerator w celu ich przegl¹dniêcia.
                // Przegl¹danie odbywa siê wg primary key
                // Zostanie wyci¹gniêta ma³o ciekawa statystyka.
                //
                int suma = 0;
                foreach (Kontrahent kontrahent in kontrahenci) {
                    //
                    // Tutaj mo¿na umieœciæ kod przetwarzaj¹cy kontrahenta.
                    //
                    suma += kontrahent.Kod.Length;
                }
                rezultat.Add(string.Format(
                    "Suma d³ugoœci kodów wszystkich kontrahentów {0} znaków", suma));
				
                //
                // Czêœciej zdarza siê jednak, ¿e chcemy wyszukaæ kontrahentów 
                // spe³niaj¹cych pewne warunki, które najlepiej gdyby liczy³y siê
                // na serwerze SQL. W tym celu nale¿y uzyskaæ obiekt widoku view.
                //
                Soneta.Business.View view = kontrahenci.CreateView();

                //
                // I za³o¿yæ filtr, np tylko kontrahentów, zawieraj¹cych literkê 
                // 's' w nazwie i o kodzie nie !INCYDENTALNY.
                // Operatory
                // & to jest AND
                // | to jest OR
                // ! to jest NOT
                //
                view.Condition &= new FieldCondition.Like("Nazwa", "*s*")
                    & ! new FieldCondition.Equal("Kod", "!INCYDENTALNY");

                //
                // Teraz mo¿emy przegl¹dn¹æ otrzyman¹ listê
                //
                foreach (Kontrahent kontrahent in view) {
                    rezultat.Add(string.Format("Kod={0}, Nazwa={1}",
                        kontrahent.Kod, kontrahent.Nazwa));
                }

                //
                // No i wyœwietliæ okno z rezultatem
                //
                ListaForm form = new ListaForm();
                form.Lista = rezultat;
                form.Owner = this;
                form.Show();

                //
                // Oczywiœcie Session.Save na koñcu nie jest potrzebny, bo nie 
                // zmieniliœmy nic w bazie.
                //
            }
        }

        #endregion

        #region Przegl¹danie listy towarów

        private void buttonTowary_Click(object sender, System.EventArgs e) {
            //
            // Przygotowaæ zmienn¹ do gromadzenia wyników.
            //
            ArrayList rezultat = new ArrayList();

            //
            // Do przegl¹dania obiektów w bazie danych wystarczy otworzyæ sesje
            // w trybie read-only, pierwszy parametr true
            //
            using (Session session = login.CreateSession(true, false)) {

                //
                // Towary znajduj¹ siê w module Towary, ale kontrahenci
                // te¿ siê przydadz¹.
                //
                CRMModule cm = CRMModule.GetInstance(session);
                TowaryModule tm = TowaryModule.GetInstance(session);

                //
                // Nastêpnie odczytujemy obiekt reprezentuj¹cy tabele 
                // wszystkich towarów znajduj¹cych siê w bazie danych.
                //
                Towary towary = tm.Towary;

                //
                // Je¿eli chcemy przegl¹dn¹æ wszystkich towarów to
                // mo¿na wykorzystaæ enumerator w celu ich przegl¹dniêcia.
                // Przegl¹danie bêdzie odbywaæ siê wg nazwy towaru. 
                // Zostanie wyci¹gniêta ma³o ciekawa statystyka.
                //
                int suma = 0;
                foreach (Towar towar in towary.WgNazwy) {
                    //
                    // Tutaj mo¿na umieœciæ kod przetwarzaj¹cy towar.
                    //
                    suma += towar.Nazwa.Length;
                }
                rezultat.Add(string.Format(
                    "Suma d³ugoœci nazw wszystkich towarów {0} znaków", suma));

                //
                // Czêœciej zdarza siê jednak, ¿e chcemy wyszukaæ towary
                // spe³niaj¹ce pewne warunki, które najlepiej gdyby liczy³y siê
                // na serwerze SQL. W tym celu nale¿y uzyskaæ obiekt widoku view.
                //
                Soneta.Business.View view = towary.CreateView();

                //
                // I za³o¿yæ filtr, np tylko towary o cesze 'Kolor' 
                // równiej wartoœci 'Czerwony'. Warunek zak³adany jest wówczas
                // gdy cecha 'Kolor' w ogóle istnieje.
                //
                if (towary.FeatureDefinitions.Contains("Kolor"))
                    view.Condition &= new FieldCondition.Equal("Features.Kolor", "Czerwony");

                //
                // Mo¿na równie¿ zak³adaæ warunki na pola bêd¹ce referencjami
                // do innych obiektów.
                // Do³ó¿my jeszcze warunek, dla towarów pochodz¹cych od dostawcy
                // 'ABC', o ile taki kontrahent istnieje w bazie.
                //
                Kontrahent kontrahentABC = cm.Kontrahenci.WgKodu["ABC"];
                if (kontrahentABC!=null)
                    view.Condition &= new FieldCondition.Equal("Dostawca", kontrahentABC);

                //
                // Teraz mo¿emy przegl¹dn¹æ otrzyman¹ listê
                //
                foreach (Towar towar in view) {
                    rezultat.Add(string.Format("Kod={0}, Nazwa={1}",
                        towar.Kod, towar.Nazwa));
                }

                //
                // No i wyœwietliæ okno z rezultatem
                //
                ListaForm form = new ListaForm();
                form.Lista = rezultat;
                form.Owner = this;
                form.Show();

                //
                // Oczywiœcie Session.Save na koñcu nie jest potrzebny, bo nie 
                // zmieniliœmy nic w bazie.
                //
            }
        }

        #endregion

        #region Generowanie z dokumentu PZ dokumentu ZK

        private void buttonPZZK_Click(object sender, System.EventArgs e) {
            //
            // Do poprawnego dzia³ania tej funkcji konieczne jest zdefiniowanie
            // obiegu dokumentów polegaj¹cego na wprowadzaniu dokumentu PZ
            // a potem rêcznym generowaniu faktury zakupu ZK.
            //
            // Metoda demonstruje sposób generowania dokumentu podrzêdnego 
            // relacji do innego dokumentu
            //

            //
            // Standardowo, otwieramy sesjê
            //
            using (Session session = login.CreateSession(false, false)) {

                //
                // Po utworzeniu sesji dobrze jest sobie przygotowaæ odpowiednie 
                // zmiene reprezentuj¹ce poszczególne modu³y programu w tej sesji.
                // Wystarczy przygotwaæ tylko te modu³y, które bêd¹ nam potrzebne.
                //
                HandelModule hm = HandelModule.GetInstance(session);
                TowaryModule tm = TowaryModule.GetInstance(session);
                MagazynyModule mm = MagazynyModule.GetInstance(session);
                CRMModule cm = CRMModule.GetInstance(session);

                //
                // Wszystkie operacje wykonujemy w transakcji sesji któr¹ nale¿y
                // na pocz¹tku otworzyæ. W transakcji mo¿emy wskazaæ czy bêd¹ 
                // robione zmiany w danych.
                //
                using (ITransaction trans = session.Logout(true)) {

                    //
                    // Potrzebna definicja dokumentu PZ i dokumentu ZK.
                    //
                    DefDokHandlowego definicjaPZ = hm.DefDokHandlowych.WgSymbolu["PZ"];
                    DefDokHandlowego definicjaZK = hm.DefDokHandlowych.WgSymbolu["ZK"];
                    if (definicjaPZ==null || definicjaZK==null) 
                        throw new InvalidOperationException("Nieznaleziona definicja dokumentu PZ i/lub ZK.");

                    //
                    // Wyszukujemy dokument PZ, z którego ma byæ utworzona faktura.
                    //
                    DokumentHandlowy dokumentPZ = hm.DokHandlowe.NumerWgNumeruDokumentu["PZ/000001/05"];
                    if (dokumentPZ==null)
                        throw new InvalidOperationException("Konieczne jest wprowadzenie dokumentu PZ/000001/05.");

                    //
                    // Wyszukujemy definicjê relacji handlowej PZ->ZK
                    //
                    DefRelacjiMagazynowa defRelPZZK = null;
                    foreach (DefRelacjiHandlowej defRel in definicjaPZ.Podrzedne) {
                        if (defRel.DefinicjaPodrzednego==definicjaZK) {
                            defRelPZZK = (DefRelacjiMagazynowa)defRel;
                            break;
                        }
                    }
                    if (defRelPZZK==null)
                        throw new InvalidOperationException("Nieznaleziona definicja relacji PZ->ZK.");

                    //
                    // Alternatywny, szybki sposób znalezienia tej szczególnej definicji
                    // relacji (czyli to co wy¿ej tylko proœciej).
                    //
                    defRelPZZK = (DefRelacjiMagazynowa)hm.DefRelHandlowych.PZFZ;
                    if (defRelPZZK==null)
                        throw new InvalidOperationException("Nieznaleziona definicja relacji PZ->ZK.");

                    //
                    // Utworzuæ obiekt context, który bêdzie potrzebny
                    //
                    Context cx = Context.Empty.Clone(session);

                    //
                    // Utworzyæ dokument podrzêdny ZK
                    //
                    DokumentDocelowy dd = new DokumentDocelowy(dokumentPZ, defRelPZZK, false, cx);
                    DokumentHandlowy dokumentZK = defRelPZZK.GenerujNowy(dokumentPZ, dd);

                    //
                    // Wszystkie operacje zosta³y poprawnie zakoñczone i zapewne 
                    // chcemy zatwierdziæ transakcjê sesji.
                    //
                    trans.Commit();
                }

                ////////////////////////////////////////////////////////////////////
                // Powy¿sze operacje by³y wykonywane na sesji, czyli w pamiêci.
                // Teraz nale¿y rezultat prac zapisaæ do bazy danych.
                //
                session.Save();
            }

            //
            // I to wszystko. Dokument ZK znajduje siê w bazie.
            //
        }

        #endregion

        #region Generowanie raportu kasowego dla ewidencji Kasa Gotówkowa

        private void buttonRaport_Click(object sender, System.EventArgs e) {
            using (Session session = login.CreateSession(false, false)) {
                KasaModule kasa = KasaModule.GetInstance(session);
                RaportESP raport = (RaportESP)kasa.RaportyESP.WgKasa[kasa.EwidencjeSP.Kasa, Date.Today, 1];
                if (raport!=null) 
                    throw new InvalidOperationException("Raport zosta³ ju¿ za³o¿ony");

                using (ITransaction t = session.Logout(true)) {
                    raport = new RaportESP(kasa.EwidencjeSP.Kasa, new FromTo(Date.Today, Date.Today));
                    kasa.RaportyESP.AddRow(raport);
                    t.Commit();
                }
                session.Save();
            }
        }

        #endregion

        #region Nowa wp³ata do ewidencji Kasa Gotówkowa

        private void buttonWp³ata_Click(object sender, System.EventArgs e) {
            using (Session session = login.CreateSession(false, false)) {
                KasaModule kasa = KasaModule.GetInstance(session);
                CRMModule crm = CRMModule.GetInstance(session);

                RaportESP raport = (RaportESP)kasa.RaportyESP.WgKasa[kasa.EwidencjeSP.Kasa, Date.Today, 1];
                if (raport==null) 
                    throw new InvalidOperationException("Nie znaleziono raportu kasowego");

                Kontrahent kontrahent = crm.Kontrahenci.WgKodu["ABC"];
                if (kontrahent==null) 
                    throw new InvalidOperationException("Nieznaleziony kontrahent o kodzie ABC.");

                using (ITransaction t = session.Logout(true)) {
                    DokumentWplata wp³ata = new DokumentWplata(raport);
                    kasa.DokumentyKasowe.AddRow(wp³ata);
                    if (!wp³ata.IsReadOnlyData())
                        wp³ata.Data = Date.Today;
                    wp³ata.Zaplata.Podmiot = kontrahent;
                    wp³ata.Zaplata.Kwota = new Currency(100.0m, "PLN");
                    wp³ata.Zaplata.Opis = "Wp³ata do kasy";
                    wp³ata.Zatwierdzony = true;
                    t.Commit();
                }
                session.Save();
            }
        }

        #endregion 

        #region Rozliczenie wp³aty i nale¿noœci dla kontrahenta ABC

        private void buttonRozliczenie_Click(object sender, System.EventArgs e) {
            using (Session session = login.CreateSession(false, false)) {
                KasaModule kasa = KasaModule.GetInstance(session);
                CRMModule crm = CRMModule.GetInstance(session);

                Kontrahent kontrahent = crm.Kontrahenci.WgKodu["ABC"];
                if (kontrahent==null) 
                    throw new InvalidOperationException("Nieznaleziony kontrahent o kodzie ABC.");

                Wplata wp³ata = null;
                Naleznosc nale¿noœæ = null;

                SubTable st = kasa.RozrachunkiIdx.WgPodmiot[kontrahent, Date.MaxValue];
                foreach (RozrachunekIdx idx in st) {
                    if (idx.Typ==TypRozrachunku.Wp³ata && wp³ata==null)
                        wp³ata = (Wplata)idx.Dokument;
                    if (idx.Typ==TypRozrachunku.Nale¿noœæ && nale¿noœæ==null)
                        nale¿noœæ = (Naleznosc)idx.Dokument;
                    if (wp³ata!=null && nale¿noœæ!=null)
                        break;
                }

                if (wp³ata==null || nale¿noœæ==null)
                    throw new InvalidOperationException("Nieznalezione wp³ata lub nale¿noœæ od kontrahenta ABC");

                using (ITransaction t = session.Logout(true)) {
                    RozliczenieSP rozliczenie = new RozliczenieSP(nale¿noœæ, wp³ata);
                    kasa.RozliczeniaSP.AddRow(rozliczenie);
                    t.Commit();
                }
                session.Save();
            }
        }

        #endregion

			#region Generowanie ewidencji sprzeda¿y dla kontrahenta ABC

			private void buttonEwidencjaSprzedazy_Click(object sender, System.EventArgs e) {
				using (Session session = login.CreateSession(false, false)) {
					EwidencjaVatModule vat = EwidencjaVatModule.GetInstance(session);
					CoreModule core = CoreModule.GetInstance(session);
					CRMModule crm = CRMModule.GetInstance(session);
					KsiegaModule ks = KsiegaModule.GetInstance(session);

					Kontrahent kontrahent = crm.Kontrahenci.WgKodu["ABC"];
					if (kontrahent == null)
						throw new InvalidOperationException("Nieznaleziony kontrahent o kodzie ABC.");

					using (ITransaction t = session.Logout(true)) {
						//utowrzenie ewidencji sprzeda¿y i dodanie do tabeli ewidencji
						SprzedazEwidencja ewidencja = new SprzedazEwidencja();
						core.DokEwidencja.AddRow(ewidencja);

						//ustawienie dat
						ewidencja.DataWplywu = Date.Today;
						ewidencja.DataDokumentu = Date.Today;
						ewidencja.DataOperacji = Date.Today;

						//ustawienie numeru dokumentu, podmiotu i opisu
						ewidencja.NumerDokumentu = "FV/2007/123456";
						ewidencja.Podmiot = kontrahent;
						ewidencja.Opis = "Faktura sprzeda¿y";

						//dodanie elementów VAT
						ElemEwidencjiVATSprzedaz elemVAT = new ElemEwidencjiVATSprzedaz(ewidencja);
						vat.EleEwidencjiVATT.AddRow(elemVAT);
						elemVAT.DefinicjaStawki = core.DefStawekVat[StatusStawkiVat.Opodatkowana, new Percent(0.22m), false];
						elemVAT.Netto = 1000m;

						//P³atnoœci generuj¹ siê automatycznie po ka¿dej zmianie wartoœci ewidencji

						// dodanie opisu analitycznego
						ElementOpisuEwidencji elemOpisu = new ElementOpisuEwidencji(ewidencja);
						ks.OpisAnalityczny.AddRow(elemOpisu);
						elemOpisu.Wymiar = "Przychody";
						elemOpisu.Symbol = "701-0";
						elemOpisu.Kwota = 1000m;

						t.Commit();
					}
					session.Save();
				}
			}

			#endregion

	}
}
