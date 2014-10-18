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
                // Ponieważ obiekt Login może przechowywać połączenie do
                // bazy danych (IDbConnection) należy zwolnić zasoby przez
                // niego używane.
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
					this.buttonWpłata = new System.Windows.Forms.Button();
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
					this.buttonKorekta.Text = "Korekta sprzedaży dokumentu o zadanym ID";
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
					this.buttonPrzelew.Text = "Faktura sprzedaży";
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
					this.cbGotówka.Text = "Zapłacono gotówką";
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
					this.buttonKontrahent.Text = "Zakładanie karty kontrahenta";
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
					// buttonWpłata
					// 
					this.buttonWpłata.FlatStyle = System.Windows.Forms.FlatStyle.System;
					this.buttonWpłata.Location = new System.Drawing.Point(360, 72);
					this.buttonWpłata.Name = "buttonWpłata";
					this.buttonWpłata.Size = new System.Drawing.Size(164, 48);
					this.buttonWpłata.TabIndex = 5;
					this.buttonWpłata.Text = "Generowanie wpłaty";
					this.buttonWpłata.Click += new System.EventHandler(this.buttonWpłata_Click);
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
					this.buttonEwidencjaSprzedazy.Text = "Ewidencja sprzedaży";
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
					this.Controls.Add(this.buttonWpłata);
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
            // należy zadbać o to, żeby wszystkie biblioteki były załadowe.
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
        private System.Windows.Forms.Button buttonWpłata;
        private System.Windows.Forms.Button buttonRozliczenie;
			private Button buttonEwidencjaSprzedazy;

        /// <summary>
        /// To jest pole zawierające informacje o loginie do bazy danych,
        /// na którym będą robione wszystkie operacje.
        /// </summary>
        Login login;

        #region Inicjacja połączenia do bazy danych

        private void Form1_Load(object sender, System.EventArgs e) {
            /////////////////////////////////////////////////////////////////
            // Następnie uzyskujemy dostęp do obiektu bazy danych
            // reprezentującego bazę danych jako taką, bez zalogowanego
            // jeszcze operatora. Rejestrowanie bazy danych można zrobić 
            // przy pomocy programu enova. Napis "Demo" jest nazwą bazy
            // wyświetlaną w programie enova.
            //
            Database database = BusApplication.Instance["Demo"];

            ////////////////////////////////////////////////////////////////
            // Kolejnym krokiem jest uzyskanie loginu do bazy danych, czyli
            // zalogowanie się operatora. Oczywiście odpowiedni operator
            // musi być wcześniej wprowadzony w programie enova.
            // W przykładzie poniżej loguję się na operatora "Administrator"
            // z pustym hasłem (brak hasła).
            //
            login = database.Login(false, "Administrator", "");
        }

        #endregion

        #region Utworzenie dokumentu PZ

        private void buttonPZ_Click(object sender, System.EventArgs e) {
            ///////////////////////////////////////////////////////////////////
            // Metoda tworzy nowy dokument PZ wypełniając go przykładowymi
            // pozycjami
            //

            //////////////////////////////////////////////////////////////////
            // Rozpoczęcie tworzenia dokumentu (w ogóle operacji na logice
            // biznesowej) polega na utworzeniu obiektu sesji (Session),
            // w którym będą odbywać się poszczególne operacje.
            // Pierwszy parametr określa, czy sesja jest tylko do odczytu
            // danych, drugi parametr, czy sesja będzie modyfikować ustawienia
            // konfiguracyjne (tj definicje dokumentów, jednostki, 
            // definicje cen, itp). Standardowo obydwa parametry dajemy false.
            //
            using (Session session = login.CreateSession(false, false)) {

                //////////////////////////////////////////////////////////////////
                // Po utworzeniu sesji dobrze jest sobie przygotować odpowiednie 
                // zmiene reprezentujące poszczególne moduły programu w tej sesji.
                // Wystarczy przygotwać tylko te moduły, które będą nam potrzebne.
                //
                HandelModule hm = HandelModule.GetInstance(session);
                TowaryModule tm = TowaryModule.GetInstance(session);
                MagazynyModule mm = MagazynyModule.GetInstance(session);
                CRMModule cm = CRMModule.GetInstance(session);

                //////////////////////////////////////////////////////////////////
                // Wszystkie operacje wykonujemy w transakcji sesji którą należy
                // na początku otworzyć. W transakcji możemy wskazać czy będą 
                // robione zmiany w danych.
                //
                using (ITransaction trans = session.Logout(true)) {

                    //////////////////////////////////////////////////////////////////
                    // Następnie należy utworzyć nowy obiekt reprezentujący dokument
                    // handlowy (nagłówek dokumentu). 
                    //
                    DokumentHandlowy dokument = new DokumentHandlowy();
		
                    //////////////////////////////////////////////////////////////////
                    // Nowy dokument nalezy również związać z definicją dokumentu 
                    // handlowego. W tym przypadku wyszukujemy definicje wyszukujemy
                    // wg jej symbolu "PZ".
                    //
                    DefDokHandlowego definicja = hm.DefDokHandlowych.WgSymbolu["PZ"];
                    if (definicja==null) 
                        throw new InvalidOperationException("Nieznaleziona definicja dokumentu PZ.");
                    dokument.Definicja = definicja;

                    /////////////////////////////////////////////////////////////////
                    // Dokument należy też przypisać do magazynu, do którego będzie
                    // przyjmowany towar. Poniżej przypisywany jest standardowy
                    // magazyn programu "Firma".
                    //
                    dokument.Magazyn = mm.Magazyny.Firma;

                    /////////////////////////////////////////////////////////////////
                    // Oraz dodajemy nowo utworzony dokument do aktualnej sesji.
                    //
                    hm.DokHandlowe.AddRow(dokument);

                    /////////////////////////////////////////////////////////////////
                    // Przyjęcie magazynowe PZ (z zewnątrz) wymaga również
                    // przypisania kontrahenta, od którego towaru jest przyjmowany.
                    // Przykład prezentuje przypisanie dokumentowi kontrahenta
                    // o kodzie "ABC".
                    Kontrahent kontrahent = cm.Kontrahenci.WgKodu["ABC"];
                    if (kontrahent==null) 
                        throw new InvalidOperationException("Nieznaleziony kontrahent o kodzie ABC.");
                    dokument.Kontrahent = kontrahent;

                    /////////////////////////////////////////////////////////////////
                    // PUNKT A ******************************************************
                    // W kartotece towarów wyszukać towar. Przykład poniżej
                    // prezentuje wyszukanie towaru wg kodu EAN "2000000000022". 
                    // Ponieważ w kartotece może znajdować się wiele towarów o tym 
                    // samym kodzie wybrazy zostanie pierwszy z nich.
                    //
					Towar towar = (Towar)tm.Towary.WgEAN["2000000000954"].GetNext();
                    if (towar!=null) {
                        //////////////////////////////////////////////////////////////
                        // Utworzyć nowy obiekt pozycji dokumentu handlowego, który
                        // zostanie dodany do sescji.
                        //
                        PozycjaDokHandlowego pozycja = new PozycjaDokHandlowego(dokument);
                        hm.PozycjeDokHan.AddRow(pozycja);

                        //////////////////////////////////////////////////////////////
                        // Przypisać towar do nowo utworzonej pozycji dokumentu, czyli
                        // wskazać, który towar ma być przyjęty do magazynu.
                        //
                        pozycja.Towar = towar;

                        //////////////////////////////////////////////////////////////
                        // W pozycji dokumentu należy jeszcze wprowadzić ilość
                        // towaru przyjmowanego na magazyn. Ilość reprezentowana jest
                        // przez liczbę 10 będącą wartością ilości (pierwszy parametr) 
                        // oraz jednostkę opisującą tę ilość (drugi parametr). Jeżeli
                        // jednostka jest null, to przyjmowana jest jednostka z
                        // karty towarowej.
                        // Poniżej znajduje się również wykomentowany przykład, w
                        // którym w sposób jawny jest wskazanie na jednostkę w metrach.
                        //
                        pozycja.Ilosc = new Quantity(10, null);
                        // pozycja.Ilosc = new Quantity(10, "m");

                        //////////////////////////////////////////////////////////////
                        // Pozycji dokumentu należy również przypisać cenę w jakiej
                        // będzie on wprowadzany do magazynu. (cena zakupu)
                        // Poniżej przypisywana jest cena w PLN. Dlatego nie jest
                        // wyspecyfikowany drugi parametr określający walutę ceny.
                        //
                        pozycja.Cena = new DoubleCy(12.34);

                        //////////////////////////////////////////////////////////////
                        // Poszczególnym pozycją można przypisać również dodatkowe
                        // cechy, które zależne są od konfiguracji programu. Przykład
                        // pokazuje jak ustawić cechę z numerem beli.
                        // Kod jest wykomentowany, ponieważ baza demo nie posiada
                        // zdefiniowanej tej cechy.
                        //
                        //pozycja.Features["Numer beli"] = "123456";
                    }

                    /////////////////////////////////////////////////////////////////
                    // Jeżeli na dokument ma zawierać więcej pozycji magazynowych
                    // to należy ponownie przejść do PUNKTU A.
                    //

                    /////////////////////////////////////////////////////////////////
                    // Dokumentowi podobnie jak pozycji dokumentu również można
                    // przypisać dodatkowe cechy zależne od konfiguracji programu. 
                    // Przykład pokazuje jak ustawić cechę z lokalizacją.
                    // Kod jest wykomentowany, ponieważ baza demo nie posiada
                    // zdefiniowanej tej cechy.
                    //
                    //dokument.Features["Lokalizacja"] = "AB/12";

                    /////////////////////////////////////////////////////////////////
                    // Po dokonaniu wszystkich operacji na dokumencie można ten
                    // dokument wprowadzić (zatwierdzić), co powoduje zabezpieczenie 
                    // przed przypadkową edycją tego dokumentu oraz przeniesienie go
                    // do ewidencji dokumentów księgowych.
                    //
                    dokument.Stan = StanDokumentuHandlowego.Zatwierdzony;

                    /////////////////////////////////////////////////////////////////
                    // Wszystkie operacje zostały poprawnie zakończone i zapewne 
                    // chcemy zatwierdzić transakcję sesji.
                    //
                    trans.Commit();
                }

                ////////////////////////////////////////////////////////////////////
                // Powyższe operacje były wykonywane na sesji, czyli w pamięci.
                // Teraz należy rezultat prac zapisać do bazy danych.
                //
                session.Save();
            }

            ////////////////////////////////////////////////////////////////////
            // I to wszystko. Dokument PZ znajduje się w bazie.
            //
        }

        #endregion

        #region Utworzenie dokumentu inwentraryzacji

        private void buttonINW_Click(object sender, System.EventArgs e) {
            ///////////////////////////////////////////////////////////////////
            // Metoda tworzy nowy dokument inwentaryzacji wypełniając go 
            // przykładowymi pozycjami
            //

            //////////////////////////////////////////////////////////////////
            // Rozpoczęcie tworzenia dokumentu (w ogóle operacji na logice
            // biznesowej) polega na utworzeniu obiektu sesji (Session),
            // w którym będą odbywać się poszczególne operacje.
            // Pierwszy parametr określa, czy sesja jest tylko do odczytu
            // danych, drugi parametr, czy sesja będzie modyfikować ustawienia
            // konfiguracyjne (tj definicje dokumentów, jednostki, 
            // definicje cen, itp). Standardowo obydwa parametry dajemy false.
            //
            using (Session session = login.CreateSession(false, false)) {

                //////////////////////////////////////////////////////////////////
                // Po utworzeniu sesji dobrze jest sobie przygotować odpowiednie 
                // zmiene reprezentujące poszczególne moduły programu w tej sesji.
                // Wystarczy przygotwać tylko te moduły, które będą nam potrzebne.
                //
                HandelModule hm = HandelModule.GetInstance(session);
                TowaryModule tm = TowaryModule.GetInstance(session);
                MagazynyModule mm = MagazynyModule.GetInstance(session);
                CRMModule cm = CRMModule.GetInstance(session);

                //////////////////////////////////////////////////////////////////
                // Wszystkie operacje wykonujemy w transakcji sesji, którą należy
                // na początku otworzyć. W transakcji możemy wskazać czy będą 
                // robione zmiany w danych.
                //
                using (ITransaction trans = session.Logout(true)) {

                    //////////////////////////////////////////////////////////////////
                    // Następnie należy utworzyć nowy obiekt reprezentujący dokument
                    // handlowy (nagłówek dokumentu). 
                    //
                    DokumentHandlowy dokument = new DokumentHandlowy();
		
                    //////////////////////////////////////////////////////////////////
                    // Nowy dokument należy również związać z definicją dokumentu 
                    // handlowego. W tym przypadku wyszukujemy definicje wyszukujemy
                    // z kolekcji standardowych definicji.
                    //
                    dokument.Definicja = hm.DefDokHandlowych.Inwentaryzacja;

                    /////////////////////////////////////////////////////////////////
                    // Dokument należy też przypisać do magazynu, do którego będzie
                    // przyjmowany towar. Poniżej przypisywany jest standardowy
                    // magazyn programu "Firma".
                    //
                    dokument.Magazyn = mm.Magazyny.Firma;
				
                    // Ale można wyszukać magazyn np wg symbolu
                    //dokument.Magazyn = mm.Magazyny.WgSymbol["MAG1"];

                    /////////////////////////////////////////////////////////////////
                    // Oraz dodajemy nowo utworzony dokument do aktualnej sesji.
                    //
                    hm.DokHandlowe.AddRow(dokument);

                    /////////////////////////////////////////////////////////////////
                    // PUNKT A ******************************************************
                    // W kartotece towarów wyszukać towar. Przykład poniżej
                    // prezentuje wyszukanie towaru wg kodu "Buty"
                    // Ponieważ w kartotece może znajdować się wiele towarów o tym 
                    // samym kodzie wybrazy zostanie pierwszy z nich.
                    //
                    Towar towar = (Towar)tm.Towary.WgKodu["Buty"];
                    if (towar!=null) {
                        //////////////////////////////////////////////////////////////
                        // Utworzyć nowy obiekt pozycji dokumentu handlowego, który
                        // zostanie dodany do sescji.
                        //
                        PozycjaDokHandlowego pozycja = new PozycjaDokHandlowego(dokument);
                        hm.PozycjeDokHan.AddRow(pozycja);

                        //////////////////////////////////////////////////////////////
                        // Przypisać towar do nowo utworzonej pozycji dokumentu, czyli
                        // wskazać, który towar ma być przyjęty do magazynu.
                        //
                        pozycja.Towar = towar;

                        //////////////////////////////////////////////////////////////
                        // W pozycji dokumentu należy jeszcze wprowadzić ilość
                        // towaru przyjmowanego na magazyn. Ilość reprezentowana jest
                        // przez liczbę 10 będącą wartością ilości (pierwszy parametr) 
                        // oraz jednostkę opisującą tę ilość (drugi parametr). Jeżeli
                        // jednostka jest null, to przyjmowana jest jednostka z
                        // karty towarowej.
                        // Poniżej znajduje się również wykomentowany przykład, w
                        // którym w sposób jawny jest wskazanie na jednostkę w metrach.
                        //
                        pozycja.Ilosc = new Quantity(10, null);
                        // pozycja.Ilosc = new Quantity(10, "m");

                        //////////////////////////////////////////////////////////////
                        // Pozycji dokumentu należy również przypisać cenę w jakiej
                        // będzie on wprowadzany do magazynu. (cena zakupu)
                        // Poniżej przypisywana jest cena w PLN. Dlatego nie jest
                        // wyspecyfikowany drugi parametr określający walutę ceny.
                        //
                        pozycja.Cena = new DoubleCy(12.34);

                        //////////////////////////////////////////////////////////////
                        // Poszczególnym pozycją można przypisać również dodatkowe
                        // cechy, które zależne są od konfiguracji programu. Przykład
                        // pokazuje jak ustawić cechę z numerem beli.
                        // Kod jest wykomentowany, ponieważ baza demo nie posiada
                        // zdefiniowanej tej cechy.
                        //
                        //pozycja.Features["Numer beli"] = "123456";
                    }

                    /////////////////////////////////////////////////////////////////
                    // Jeżeli na dokument ma zawierać więcej pozycji magazynowych
                    // to należy ponownie przejść do PUNKTU A.
                    //

                    /////////////////////////////////////////////////////////////////
                    // Dokumentowi podobnie jak pozycji dokumentu również można
                    // przypisać dodatkowe cechy zależne od konfiguracji programu. 
                    // Przykład pokazuje jak ustawić cechę z lokalizacją.
                    // Kod jest wykomentowany, ponieważ baza demo nie posiada
                    // zdefiniowanej tej cechy.
                    //
                    //dokument.Features["Lokalizacja"] = "AB/12";

                    /////////////////////////////////////////////////////////////////
                    // Wszystkie operacje zostały poprawnie zakończone i zapewne 
                    // chcemy zatwierdzić transakcję sesji.
                    //
                    trans.Commit();
                }

                ////////////////////////////////////////////////////////////////////
                // Powyższe operacje były wykonywane na sesji, czyli w pamięci.
                // Teraz należy rezultat prac zapisać do bazy danych.
                //
                session.Save();
            }

            ////////////////////////////////////////////////////////////////////
            // I to wszystko. Dokument inwentaryzacji znajduje się już w bazie.
            // Dokument ten znajduje się w buforze, więc żeby stany magazynowe
            // mogły być zmodyfikowane należy zatwierdzić ten wygenerowany 
            // właśnie dokument.
            //
        }

        #endregion

        #region Korekta dokuemntu o zadanym ID

        private void buttonKorekta_Click(object sender, System.EventArgs e) {
            ///////////////////////////////////////////////////////////////////
            // Metoda tworzy dokuemnt korygujący do faktury o zadanym ID
            // Nie umieszczam, które można znaleźć w poprzednich przykładach
            //

            using (Session session = login.CreateSession(false, false)) {

                HandelModule hm = HandelModule.GetInstance(session);
                TowaryModule tm = TowaryModule.GetInstance(session);
                MagazynyModule mm = MagazynyModule.GetInstance(session);
                CRMModule cm = CRMModule.GetInstance(session);

                using (ITransaction trans = session.Logout(true)) {

                    //////////////////////////////////////////////////////////////////
                    // Wyszukać dokument sprzedaży o wcześniej wprowadzonym ID
                    //
                    int id = int.Parse(textID.Text);
                    DokumentHandlowy dokument = hm.DokHandlowe[id];
		
                    //////////////////////////////////////////////////////////////////
                    // Wyszukać definicję relacji korekty dla danego typu dokumentu
                    //
                    DefRelacjiKorekta defKorekta =
                        dokument.Definicja.RelacjaKorektyDefinicja as DefRelacjiKorekta;
                    if (defKorekta==null)
                        throw new InvalidOperationException("Dokument "+dokument+" nie ma zdefiniowanej relacji korekty.");

                    /////////////////////////////////////////////////////////////////
                    // Utworzyć dokument korekty. Dokument korenty ma być tworzony 
                    // zawsze dla pierwszej faktury. Czyli korekta jest robiona dla
                    // "pierwszej" faktury.
                    //
                    DokumentHandlowy korekta = defKorekta.KorygujDokument(dokument);
				
                    /////////////////////////////////////////////////////////////////
                    // Następnie można zmodyfikować pozycje na tym dokumencie.
                    //
                    foreach (PozycjaDokHandlowego pozycja in korekta.Pozycje) {

                        /////////////////////////////////////////////////////////////////
                        // Tutaj należy dokonać zmian pozycji
                        //

                    }

                    /////////////////////////////////////////////////////////////////
                    // Na koniec można dokument zatwierdzić.
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
        // Metoda tworzy nowy faktury VAT wypełniając go przykładowymi
        // pozycjami.
        // Robimy to tak samo jak dokument PZ, z tym, że szukamy definicji FV.
        // Następnie modyfikujemy płatności na przelew lub zapłacone gotówką.
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
                    //Modyfikacja płatności
                    //Standradowo dokument ma wygenerowaną przez system jedną płatność. Zmienimy w niej
                    //sposób zapłaty, domyślną ewidencję oraz termin płatności.
                    //Jeżeli chcemy mieć więcej niż jedną płatność, to zmniejszamy kwotę w instniejącej
                    //i dodajemy kolejne płatności aż do zrównoważenia kwoty płatności i dokumentu.
                    //Dodatkowo, jeżeli generujemy płatność gotówkową, to dodamy do niej informację
                    //o zapłacieniu i odpowiedni wpis na raport kasowy (musi być założony 
                    //  i niezatwierdzony)

                    //Wymuszamy przeliczenie zdarzeń. W przeciwnym razie sumy mogą być nieaktualne
                    //Normalnie robi to za nas UI
                    session.Events.Invoke();

                    KasaModule kasa = KasaModule.GetInstance(session);

                    Naleznosc gotówka = null;
                    Naleznosc przelew = null;
                    //Pobieramy isntniejacą płatność. System zrobił na pewno jedną (o ile wartość
                    //dokumentu jest różna od zera).
                    //Możemy też płatność usunąć i odtworzyć dokładnie tak samo jak to jest 
                    //robione z dodatkową płatnością
                    Naleznosc płatność = (Naleznosc)dokument.Platnosci.GetNext();
                    if (cbGotówka.Checked && cbPrzelew.Checked) {
                        Currency kwota = płatność.Kwota;
                        płatność.Kwota = płatność.Kwota/2;
                        gotówka = płatność;
                        //Tworzymy nowy obiekt należności
                        przelew = new Naleznosc(dokument);
                        //Dodajemy go do tabeli Platnosci
                        kasa.Platnosci.AddRow(przelew);
                        //I ustawiamy kwotę
                        przelew.Kwota = kwota - gotówka.Kwota;
                    }
                    else if (cbGotówka.Checked)
                        gotówka = płatność;
                    else if (cbPrzelew.Checked)
                        przelew = płatność;

                    //Mamy już potrzebne płatności. Teraz musimy im zmodyfikować sposób zapłaty,
                    //ewidencję SP oraz termin płatności
                    //Najpier przelew
                    if (przelew!=null) {
                        //Wyszukujemy sposób zapłaty. Na szczęście dla gotówki mamy standardowy
                        //Możemy też szukać wg nazwy lub Guid.
                        przelew.SposobZaplaty = kasa.SposobyZaplaty.Przelew;

                        //Szukamy ewidencję SP.
                        przelew.EwidencjaSP = kasa.EwidencjeSP.WgNazwy["Firmowy rachunek bankowy"];

                        //I termin płatności
                        przelew.TerminDni = 21;
                    }

                    if (gotówka!=null) {
                        //Wyszukujemy sposób zapłaty. Na szczęście dla gotówki mamy standardowy
                        //Możemy też szukać wg nazwy lub Guid.
                        gotówka.SposobZaplaty = kasa.SposobyZaplaty.Gotówka;

                        //Szukamy ewidencję SP.
                        gotówka.EwidencjaSP = kasa.EwidencjeSP.WgNazwy["Kasa gotówkowa"];

                        //I termin płatności
                        gotówka.TerminDni = 0;

                        //Pozostaje to teraz zapłacić
                        //Szukamy raportu kasowego. Musi być istnieć i być otwarty lub 
                        //nie istnieć i mieć flagę automatyczny.
                        //Oczywiście ewidencja SP musi być typu kasa.
                        RaportESP raport = ((Kasa)gotówka.EwidencjaSP).NowyRaport(dokument, dokument.Data);
                        //Tworzymy nowy dokument wpłaty
                        Wplata wpłata = new Wplata(dokument, raport);
                        //Dodajemy go do tabeli
                        kasa.Zaplaty.AddRow(wpłata);
                        //Ustawiamy podmiot (taki jak w należności)
                        wpłata.Podmiot = dokument.Kontrahent;
                        //... sposób zapłaty
                        wpłata.SposobZaplaty = gotówka.SposobZaplaty;
                        //... opis wystawrczy zainicjować, zostanie przeliczony podczas zapisu
                        wpłata.Opis = "?";
                        //Oraz oczywiście kwotę.
                        wpłata.Kwota = gotówka.Kwota;

                        //Wpłata z należnością zostaną rozliczone podczas zatwierdzania dokumentu
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
            // Metoda tworzy nowy dokument RW wypełniając go przykładowymi
            // pozycjami
            //

            //////////////////////////////////////////////////////////////////
            // Rozpoczęcie tworzenia dokumentu (w ogóle operacji na logice
            // biznesowej) polega na utworzeniu obiektu sesji (Session),
            // w którym będą odbywać się poszczególne operacje.
            // Pierwszy parametr określa, czy sesja jest tylko do odczytu
            // danych, drugi parametr, czy sesja będzie modyfikować ustawienia
            // konfiguracyjne (tj definicje dokumentów, jednostki, 
            // definicje cen, itp). Standardowo obydwa parametry dajemy false.
            //
            using (Session session = login.CreateSession(false, false)) {

                //////////////////////////////////////////////////////////////////
                // Po utworzeniu sesji dobrze jest sobie przygotować odpowiednie 
                // zmiene reprezentujące poszczególne moduły programu w tej sesji.
                // Wystarczy przygotwać tylko te moduły, które będą nam potrzebne.
                //
                HandelModule hm = HandelModule.GetInstance(session);
                TowaryModule tm = TowaryModule.GetInstance(session);
                MagazynyModule mm = MagazynyModule.GetInstance(session);
                CRMModule cm = CRMModule.GetInstance(session);

                //////////////////////////////////////////////////////////////////
                // Wszystkie operacje wykonujemy w transakcji sesji którą należy
                // na początku otworzyć. W transakcji możemy wskazać czy będą 
                // robione zmiany w danych.
                //
                using (ITransaction trans = session.Logout(true)) {

                    //////////////////////////////////////////////////////////////////
                    // Następnie należy utworzyć nowy obiekt reprezentujący dokument
                    // handlowy (nagłówek dokumentu). 
                    //
                    DokumentHandlowy dokument = new DokumentHandlowy();
		
                    //////////////////////////////////////////////////////////////////
                    // Nowy dokument nalezy również związać z definicją dokumentu 
                    // handlowego. W tym przypadku wyszukujemy definicje wyszukujemy
                    // wg jej symbolu "PZ".
                    //
                    DefDokHandlowego definicja = hm.DefDokHandlowych.WgSymbolu["RW"];
                    if (definicja==null) 
                        throw new InvalidOperationException("Nieznaleziona definicja dokumentu RW.");
                    dokument.Definicja = definicja;

                    /////////////////////////////////////////////////////////////////
                    // Dokument należy też przypisać do magazynu, do którego będzie
                    // przyjmowany towar. Poniżej przypisywany jest standardowy
                    // magazyn programu "Firma".
                    //
                    dokument.Magazyn = mm.Magazyny.Firma;

                    /////////////////////////////////////////////////////////////////
                    // Oraz dodajemy nowo utworzony dokument do aktualnej sesji.
                    //
                    hm.DokHandlowe.AddRow(dokument);

                    /////////////////////////////////////////////////////////////////
                    // PUNKT A ******************************************************
                    // W kartotece towarów wyszukać towar. Przykład poniżej
                    // prezentuje wyszukanie towaru wg kodu EAN "2000000000022". 
                    // Ponieważ w kartotece może znajdować się wiele towarów o tym 
                    // samym kodzie wybrazy zostanie pierwszy z nich.
                    //
					Towar towar = tm.Towary.WgKodu["BIKINI"];
                    if (towar!=null) {
                        //////////////////////////////////////////////////////////////
                        // Utworzyć nowy obiekt pozycji dokumentu handlowego, który
                        // zostanie dodany do sescji.
                        //
                        PozycjaDokHandlowego pozycja = new PozycjaDokHandlowego(dokument);
                        hm.PozycjeDokHan.AddRow(pozycja);

                        //////////////////////////////////////////////////////////////
                        // Przypisać towar do nowo utworzonej pozycji dokumentu, czyli
                        // wskazać, który towar ma być wydany z magazynu.
                        //
                        pozycja.Towar = towar;

                        //////////////////////////////////////////////////////////////
                        // W pozycji dokumentu należy jeszcze wprowadzić ilość
                        // towaru wydawanego z magazynu. Ilość reprezentowana jest
                        // przez liczbę 10 będącą wartością ilości (pierwszy parametr) 
                        // oraz jednostkę opisującą tę ilość (drugi parametr). Jeżeli
                        // jednostka jest null, to przyjmowana jest jednostka z
                        // karty towarowej.
                        // Poniżej znajduje się również wykomentowany przykład, w
                        // którym w sposób jawny jest wskazanie na jednostkę w metrach.
                        //
                        pozycja.Ilosc = new Quantity(10, null);
                        // pozycja.Ilosc = new Quantity(10, "m");

                        //////////////////////////////////////////////////////////////
                        // Pozycji dokumentu należy również przypisać cenę w jakiej
                        // będzie on wprowadzany do magazynu. (cena zakupu)
                        // Poniżej przypisywana jest cena w PLN. Dlatego nie jest
                        // wyspecyfikowany drugi parametr określający walutę ceny.
                        //
                        pozycja.Cena = new DoubleCy(12.34);

                        //////////////////////////////////////////////////////////////
                        // Poszczególnym pozycją można przypisać również dodatkowe
                        // cechy, które zależne są od konfiguracji programu. Przykład
                        // pokazuje jak ustawić cechę z numerem beli.
                        // Kod jest wykomentowany, ponieważ baza demo nie posiada
                        // zdefiniowanej tej cechy.
                        //
                        //pozycja.Features["Numer beli"] = "123456";
                    }

                    /////////////////////////////////////////////////////////////////
                    // Jeżeli na dokument ma zawierać więcej pozycji magazynowych
                    // to należy ponownie przejść do PUNKTU A.
                    //

                    /////////////////////////////////////////////////////////////////
                    // Dokumentowi podobnie jak pozycji dokumentu również można
                    // przypisać dodatkowe cechy zależne od konfiguracji programu. 
                    // Przykład pokazuje jak ustawić cechę z lokalizacją.
                    // Kod jest wykomentowany, ponieważ baza demo nie posiada
                    // zdefiniowanej tej cechy.
                    //
                    //dokument.Features["Lokalizacja"] = "AB/12";

                    /////////////////////////////////////////////////////////////////
                    // W przypadku tego dokumentu przed zatwierdzeniem należy 
                    // wcześniej odpalić zdarzenia, które przeliczą stany magazynowe.
                    session.Events.Invoke();

                    /////////////////////////////////////////////////////////////////
                    // Po dokonaniu wszystkich operacji na dokumencie można ten
                    // dokument wprowadzić (zatwierdzić), co powoduje zabezpieczenie 
                    // przed przypadkową edycją tego dokumentu oraz przeniesienie go
                    // do ewidencji dokumentów księgowych.
                    //
                    dokument.Stan = StanDokumentuHandlowego.Zatwierdzony;

                    /////////////////////////////////////////////////////////////////
                    // Wszystkie operacje zostały poprawnie zakończone i zapewne 
                    // chcemy zatwierdzić transakcję sesji.
                    //
                    trans.Commit();
                }

                ////////////////////////////////////////////////////////////////////
                // Powyższe operacje były wykonywane na sesji, czyli w pamięci.
                // Teraz należy rezultat prac zapisać do bazy danych.
                //
                session.Save();
            }

            ////////////////////////////////////////////////////////////////////
            // I to wszystko. Dokument RW znajduje się w bazie.
            //
        }

        #endregion

        #region Zakładanie karty kontrahenta

        private void buttonKontrahent_Click(object sender, System.EventArgs e) {
            //
            // Przed rozpoczęciem dodawania nowego obiektu biznesowego 
            // (tj kontrahenta) należy tak jak zwykle utworzyć obiekt sesji
            //
            using (Session session = login.CreateSession(false, false)) {

                //
                // Do kontrahentów wystarczy uzyskać moduł CRM, w którym
                // znajduje się odpowiednia kolekcja
                //
                CRMModule cm = CRMModule.GetInstance(session);

                //
                // Następnie przeba otworzyć transakcje biznesową (nie bazodanową)
                // do edycji
                //
                using (ITransaction trans = session.Logout(true)) {

                    //
                    // Tworzymy nowy, pusty obiekt kontrahenta 
                    //
                    Kontrahent kontrahent = new Kontrahent();

                    //
                    // Następnie dodajemy pusty obiekt kontrahenta do tabeli. 
                    //
                    cm.Kontrahenci.AddRow(kontrahent);
					
                    //
                    // Inicjujemy wymagane pole kod kontrahenta na przypadkową wartość.
                    // Pole jest unikalne w bazie danych, wieć jeżeli kontranhent
                    // o zadanym kodzie już istnienie w bazie danych, to podczas podstawiania
                    // wartości do property zostanie wygenerowany wyjątek.
                    //
                    int nr = new Random().Next(10000);
                    kontrahent.Kod = "KOD"+nr;

                    //
                    // Inicjujemy nazwę kontrahenta. To pole nie jest już unikalne.
                    // 
                    kontrahent.Nazwa = "Nazwa "+nr;

                    //
                    // Inicjujemy pozostałe pola, które chcemy zainicjować
                    //
                    kontrahent.NIP = "123-45-67-890";
                    kontrahent.Adres.Ulica = "Szara";
                    kontrahent.Adres.NrDomu = "12";
                    kontrahent.Adres.NrLokalu = "34";
                    kontrahent.Adres.Miejscowosc = "Kraków";
			
                    // 
                    // Zatwierdzamy transakcję biznesową
                    //
                    trans.Commit();
                }

                //
                // A na końcu całość zapisujemy do bazy danych
                //
                session.Save();
            }
        }

        #endregion

        #region Przeglądanie listy kontrahentów

        private void buttonKontrahenci_Click(object sender, System.EventArgs e) {
            //
            // Przygotować zmienną do gromadzenia wyników.
            //
            ArrayList rezultat = new ArrayList();

            //
            // Do przeglądania obiektów w bazie danych wystarczy otworzyć sesje
            // w trybie read-only, pierwszy parametr true
            //
            using (Session session = login.CreateSession(true, false)) {

                //
                // Kontrahenci znajdują się w module CRM
                //
                CRMModule cm = CRMModule.GetInstance(session);

                //
                // Następnie odczytujemy obiekt reprezentujący tabele 
                // wszystkich kontrahentów znajdujących się w bazie danych.
                //
                Kontrahenci kontrahenci = cm.Kontrahenci;

                //
                // Jeżeli chcemy przeglądnąć wszystkich kontrahentów to
                // można wykorzystać enumerator w celu ich przeglądnięcia.
                // Przeglądanie odbywa się wg primary key
                // Zostanie wyciągnięta mało ciekawa statystyka.
                //
                int suma = 0;
                foreach (Kontrahent kontrahent in kontrahenci) {
                    //
                    // Tutaj można umieścić kod przetwarzający kontrahenta.
                    //
                    suma += kontrahent.Kod.Length;
                }
                rezultat.Add(string.Format(
                    "Suma długości kodów wszystkich kontrahentów {0} znaków", suma));
				
                //
                // Częściej zdarza się jednak, że chcemy wyszukać kontrahentów 
                // spełniających pewne warunki, które najlepiej gdyby liczyły się
                // na serwerze SQL. W tym celu należy uzyskać obiekt widoku view.
                //
                Soneta.Business.View view = kontrahenci.CreateView();

                //
                // I założyć filtr, np tylko kontrahentów, zawierających literkę 
                // 's' w nazwie i o kodzie nie !INCYDENTALNY.
                // Operatory
                // & to jest AND
                // | to jest OR
                // ! to jest NOT
                //
                view.Condition &= new FieldCondition.Like("Nazwa", "*s*")
                    & ! new FieldCondition.Equal("Kod", "!INCYDENTALNY");

                //
                // Teraz możemy przeglądnąć otrzymaną listę
                //
                foreach (Kontrahent kontrahent in view) {
                    rezultat.Add(string.Format("Kod={0}, Nazwa={1}",
                        kontrahent.Kod, kontrahent.Nazwa));
                }

                //
                // No i wyświetlić okno z rezultatem
                //
                ListaForm form = new ListaForm();
                form.Lista = rezultat;
                form.Owner = this;
                form.Show();

                //
                // Oczywiście Session.Save na końcu nie jest potrzebny, bo nie 
                // zmieniliśmy nic w bazie.
                //
            }
        }

        #endregion

        #region Przeglądanie listy towarów

        private void buttonTowary_Click(object sender, System.EventArgs e) {
            //
            // Przygotować zmienną do gromadzenia wyników.
            //
            ArrayList rezultat = new ArrayList();

            //
            // Do przeglądania obiektów w bazie danych wystarczy otworzyć sesje
            // w trybie read-only, pierwszy parametr true
            //
            using (Session session = login.CreateSession(true, false)) {

                //
                // Towary znajdują się w module Towary, ale kontrahenci
                // też się przydadzą.
                //
                CRMModule cm = CRMModule.GetInstance(session);
                TowaryModule tm = TowaryModule.GetInstance(session);

                //
                // Następnie odczytujemy obiekt reprezentujący tabele 
                // wszystkich towarów znajdujących się w bazie danych.
                //
                Towary towary = tm.Towary;

                //
                // Jeżeli chcemy przeglądnąć wszystkich towarów to
                // można wykorzystać enumerator w celu ich przeglądnięcia.
                // Przeglądanie będzie odbywać się wg nazwy towaru. 
                // Zostanie wyciągnięta mało ciekawa statystyka.
                //
                int suma = 0;
                foreach (Towar towar in towary.WgNazwy) {
                    //
                    // Tutaj można umieścić kod przetwarzający towar.
                    //
                    suma += towar.Nazwa.Length;
                }
                rezultat.Add(string.Format(
                    "Suma długości nazw wszystkich towarów {0} znaków", suma));

                //
                // Częściej zdarza się jednak, że chcemy wyszukać towary
                // spełniające pewne warunki, które najlepiej gdyby liczyły się
                // na serwerze SQL. W tym celu należy uzyskać obiekt widoku view.
                //
                Soneta.Business.View view = towary.CreateView();

                //
                // I założyć filtr, np tylko towary o cesze 'Kolor' 
                // równiej wartości 'Czerwony'. Warunek zakładany jest wówczas
                // gdy cecha 'Kolor' w ogóle istnieje.
                //
                if (towary.FeatureDefinitions.Contains("Kolor"))
                    view.Condition &= new FieldCondition.Equal("Features.Kolor", "Czerwony");

                //
                // Można również zakładać warunki na pola będące referencjami
                // do innych obiektów.
                // Dołóżmy jeszcze warunek, dla towarów pochodzących od dostawcy
                // 'ABC', o ile taki kontrahent istnieje w bazie.
                //
                Kontrahent kontrahentABC = cm.Kontrahenci.WgKodu["ABC"];
                if (kontrahentABC!=null)
                    view.Condition &= new FieldCondition.Equal("Dostawca", kontrahentABC);

                //
                // Teraz możemy przeglądnąć otrzymaną listę
                //
                foreach (Towar towar in view) {
                    rezultat.Add(string.Format("Kod={0}, Nazwa={1}",
                        towar.Kod, towar.Nazwa));
                }

                //
                // No i wyświetlić okno z rezultatem
                //
                ListaForm form = new ListaForm();
                form.Lista = rezultat;
                form.Owner = this;
                form.Show();

                //
                // Oczywiście Session.Save na końcu nie jest potrzebny, bo nie 
                // zmieniliśmy nic w bazie.
                //
            }
        }

        #endregion

        #region Generowanie z dokumentu PZ dokumentu ZK

        private void buttonPZZK_Click(object sender, System.EventArgs e) {
            //
            // Do poprawnego działania tej funkcji konieczne jest zdefiniowanie
            // obiegu dokumentów polegającego na wprowadzaniu dokumentu PZ
            // a potem ręcznym generowaniu faktury zakupu ZK.
            //
            // Metoda demonstruje sposób generowania dokumentu podrzędnego 
            // relacji do innego dokumentu
            //

            //
            // Standardowo, otwieramy sesję
            //
            using (Session session = login.CreateSession(false, false)) {

                //
                // Po utworzeniu sesji dobrze jest sobie przygotować odpowiednie 
                // zmiene reprezentujące poszczególne moduły programu w tej sesji.
                // Wystarczy przygotwać tylko te moduły, które będą nam potrzebne.
                //
                HandelModule hm = HandelModule.GetInstance(session);
                TowaryModule tm = TowaryModule.GetInstance(session);
                MagazynyModule mm = MagazynyModule.GetInstance(session);
                CRMModule cm = CRMModule.GetInstance(session);

                //
                // Wszystkie operacje wykonujemy w transakcji sesji którą należy
                // na początku otworzyć. W transakcji możemy wskazać czy będą 
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
                    // Wyszukujemy dokument PZ, z którego ma być utworzona faktura.
                    //
                    DokumentHandlowy dokumentPZ = hm.DokHandlowe.NumerWgNumeruDokumentu["PZ/000001/05"];
                    if (dokumentPZ==null)
                        throw new InvalidOperationException("Konieczne jest wprowadzenie dokumentu PZ/000001/05.");

                    //
                    // Wyszukujemy definicję relacji handlowej PZ->ZK
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
                    // relacji (czyli to co wyżej tylko prościej).
                    //
                    defRelPZZK = (DefRelacjiMagazynowa)hm.DefRelHandlowych.PZFZ;
                    if (defRelPZZK==null)
                        throw new InvalidOperationException("Nieznaleziona definicja relacji PZ->ZK.");

                    //
                    // Utworzuć obiekt context, który będzie potrzebny
                    //
                    Context cx = Context.Empty.Clone(session);

                    //
                    // Utworzyć dokument podrzędny ZK
                    //
                    DokumentDocelowy dd = new DokumentDocelowy(dokumentPZ, defRelPZZK, false, cx);
                    DokumentHandlowy dokumentZK = defRelPZZK.GenerujNowy(dokumentPZ, dd);

                    //
                    // Wszystkie operacje zostały poprawnie zakończone i zapewne 
                    // chcemy zatwierdzić transakcję sesji.
                    //
                    trans.Commit();
                }

                ////////////////////////////////////////////////////////////////////
                // Powyższe operacje były wykonywane na sesji, czyli w pamięci.
                // Teraz należy rezultat prac zapisać do bazy danych.
                //
                session.Save();
            }

            //
            // I to wszystko. Dokument ZK znajduje się w bazie.
            //
        }

        #endregion

        #region Generowanie raportu kasowego dla ewidencji Kasa Gotówkowa

        private void buttonRaport_Click(object sender, System.EventArgs e) {
            using (Session session = login.CreateSession(false, false)) {
                KasaModule kasa = KasaModule.GetInstance(session);
                RaportESP raport = (RaportESP)kasa.RaportyESP.WgKasa[kasa.EwidencjeSP.Kasa, Date.Today, 1];
                if (raport!=null) 
                    throw new InvalidOperationException("Raport został już założony");

                using (ITransaction t = session.Logout(true)) {
                    raport = new RaportESP(kasa.EwidencjeSP.Kasa, new FromTo(Date.Today, Date.Today));
                    kasa.RaportyESP.AddRow(raport);
                    t.Commit();
                }
                session.Save();
            }
        }

        #endregion

        #region Nowa wpłata do ewidencji Kasa Gotówkowa

        private void buttonWpłata_Click(object sender, System.EventArgs e) {
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
                    DokumentWplata wpłata = new DokumentWplata(raport);
                    kasa.DokumentyKasowe.AddRow(wpłata);
                    if (!wpłata.IsReadOnlyData())
                        wpłata.Data = Date.Today;
                    wpłata.Zaplata.Podmiot = kontrahent;
                    wpłata.Zaplata.Kwota = new Currency(100.0m, "PLN");
                    wpłata.Zaplata.Opis = "Wpłata do kasy";
                    wpłata.Zatwierdzony = true;
                    t.Commit();
                }
                session.Save();
            }
        }

        #endregion 

        #region Rozliczenie wpłaty i należności dla kontrahenta ABC

        private void buttonRozliczenie_Click(object sender, System.EventArgs e) {
            using (Session session = login.CreateSession(false, false)) {
                KasaModule kasa = KasaModule.GetInstance(session);
                CRMModule crm = CRMModule.GetInstance(session);

                Kontrahent kontrahent = crm.Kontrahenci.WgKodu["ABC"];
                if (kontrahent==null) 
                    throw new InvalidOperationException("Nieznaleziony kontrahent o kodzie ABC.");

                Wplata wpłata = null;
                Naleznosc należność = null;

                SubTable st = kasa.RozrachunkiIdx.WgPodmiot[kontrahent, Date.MaxValue];
                foreach (RozrachunekIdx idx in st) {
                    if (idx.Typ==TypRozrachunku.Wpłata && wpłata==null)
                        wpłata = (Wplata)idx.Dokument;
                    if (idx.Typ==TypRozrachunku.Należność && należność==null)
                        należność = (Naleznosc)idx.Dokument;
                    if (wpłata!=null && należność!=null)
                        break;
                }

                if (wpłata==null || należność==null)
                    throw new InvalidOperationException("Nieznalezione wpłata lub należność od kontrahenta ABC");

                using (ITransaction t = session.Logout(true)) {
                    RozliczenieSP rozliczenie = new RozliczenieSP(należność, wpłata);
                    kasa.RozliczeniaSP.AddRow(rozliczenie);
                    t.Commit();
                }
                session.Save();
            }
        }

        #endregion

			#region Generowanie ewidencji sprzedaży dla kontrahenta ABC

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
						//utowrzenie ewidencji sprzedaży i dodanie do tabeli ewidencji
						SprzedazEwidencja ewidencja = new SprzedazEwidencja();
						core.DokEwidencja.AddRow(ewidencja);

						//ustawienie dat
						ewidencja.DataWplywu = Date.Today;
						ewidencja.DataDokumentu = Date.Today;
						ewidencja.DataOperacji = Date.Today;

						//ustawienie numeru dokumentu, podmiotu i opisu
						ewidencja.NumerDokumentu = "FV/2007/123456";
						ewidencja.Podmiot = kontrahent;
						ewidencja.Opis = "Faktura sprzedaży";

						//dodanie elementów VAT
						ElemEwidencjiVATSprzedaz elemVAT = new ElemEwidencjiVATSprzedaz(ewidencja);
						vat.EleEwidencjiVATT.AddRow(elemVAT);
						elemVAT.DefinicjaStawki = core.DefStawekVat[StatusStawkiVat.Opodatkowana, new Percent(0.22m), false];
						elemVAT.Netto = 1000m;

						//Płatności generują się automatycznie po każdej zmianie wartości ewidencji

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
