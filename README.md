**UWAGA - REPOZYTORIUM MA STATUS ARCHIWALNY - MOŻE ZAWIERAĆ ELEMENTY WYCOFANE**

**Dodawanie dokumentów handlowych**

Poniższy przykład zawiera aplikację demonstracyjną, która jest w stanie dodać nowy dokument PZ oraz dokument inwentraryzacji do bazy danych programu enova przy pomocy logiki biznesowej. W tym celu wykorzystuje klasy logiki biznesowej programu enova, które zostały zainstalowane razem z aplikacją główną. Jednak przykład ten nie integruje się bezpośrednio z oknem programu enova lecz pozwala na tworzenie niezależnych programów ściśle współpracujących z system. W podobnych rozwiązaniach stosowanych przez inne firmy do realizacji stosuje się bezpośrednie połączenie do bazy danych i przetwarzanie np za pomocą języka SQL. Rozwiązanie to jest również możliwe i w systemie enova, jednak zalety wykonywania logiki biznesowej są olbrzymie:



1. Połączenie z bazą danych następuje przez interface aplikacyjny, a nie bezpośrednio do bazy danych, dzięki czemu aplikacja nie musi dbać o zarządzanie, konfigurowanie i ustalanie połączenia do bazy danych. Jest też niezależna od wykorzystywanego typu bazy danych MSSQL, Clarion (w przyszłości MySql).
2. Nie jest konieczna dogłębna znajomość struktury bazy danych. Często w bazie danych zaszyte są pewne szczegóły implementacyjne, które wymagają od programisty poza dokonaniem podstawowych operacji na bazie dokonywanie dodatkowych czynności (np przeliczanie stanów magazynowych, itp). W wielu przypadkach powoduje to konieczność wielokrotnego programowania algorytmów, które już działają w aplikacji głównej.
3. Minimalizacja przetwarzanych danych. Często rekord bazy danych zawiera wiele pól, których poprawne wypełnienie przez programistę nastręcza wiele trudności. Logika biznesowa zadba o ich automatyczne wypełnienie, po dostarczeniu do niej tylko podstawowych informacji. Minimalizuje to ilość wymagazynych operacji tylko do tych niezbędnych.
4. Uwzględnianie konwersji struktur bazy danych oraz nowej funkcjonalności bazy danych. Pojawianie się kolejnych wersji programu wiąże się często z konwersją struktury bazy danych. Aplikacje pracujące na bazie danych muszą być odpowiednio dostosowywane. Zwiększa to oczywiście koszty ich utrzymania. W kolejnych wersjach logika biznesowa również ulega zmianom, jednak czesto nie pociąga to za sobą konieczności przeprogramowywania kodu. Istnieje więc bardzo duże prawdopodobieństwo, że raz napisane rozszerzenie systemu będzie funkcjonować równie dobrze w przyszłości.
5. Brak specjalnego interface'u komunikacyjnego, wykorzystanie standardowych klas aplikacji enova. Logika biznesowa, na której bazuje ten przykład to nie są jakieś specjalne procedury przygotowane specjalnie do komunikacji z zewnętrzymi aplikacjami. Są to standardowe klasy, na których bazuje również główna aplikacja enova. W ten sam sposób realizowane są operacje w programie głównym. Dzięki temu uzyskujemy pewność ciągłej aktualności i kompatybilności tego zestawu klas. Dodatkowo logika biznesowa daje dostęp do wszystkich aspektów działania programu enova. Ponieważ wszystko co zostało zaimplementowane przez naszych programistów bazuje na tych właśnie klasach. Daje to ogromne możliwości w tworzeniu dodatkowych rozszerzeń. Przykładem tej integracji jest okno Organizatora listy, które wyświetla strukturę właściwości bardzo podobną do tej wykorzystywanej w tym przykładzie.

**Jak uruchomić przykład?**

Do poprawnego uruchomienia przykładu konieczne jest wykonanie paru czynności wstępnych:

1. Dołączony plik archiwum ZIP należy rozpakować w dowolnym folderze.
2. Znajdujący się w nim solution i projekt został przygotowany przy pomocy Microsoft Visual Studio 2010 w oparciu o bibliotekę programu enova 4.0.
3. Po otwarciu projektu nalezy skonfigurować połączenie do aktualnej instalacji programu enova. W tym celu należy:
 - Otworzyć okno "Solution Maganer".
 - Rozwinąć gałąź drzewa PrzykladHandel/References.
 - Zaznaczyć wszystkie znajdujące się tam assembly firmy Soneta, czyli:
    - Soneta.Business
    - Soneta.Core
    - Soneta.CRM
    - Soneta.Deklaracje
    - Soneta.Handel
    - Soneta.Kasa
    - Soneta.Ksiega
    - Soneta.Start
    - Soneta.Types
 - Skasować zaznaczone assembly.
 - Prawym klawiszem myszy kliknąć na gałąź drzewa References i uruchomić funkcję Add Reference...
 - Na zakładce .NET nacisnąć przycisk Browse...
 - W oknie wybrać folder instalacyjny programu enova (standardowo jest to c:\Program Files\Soneta\enova ...).
 - Zaznaczyć pliki DLL zawierajace assembly skasowane w poprzednim punkcie (9 plików DLL).
 - Zatwierdzić wszystkie okna przyciskami OK.
 - Dla assembly Soneta.Start ustawić w oknie Properties opcję Copy Local na True, a dla pozostałych 8 assembly ustawić na False

4. Program demonstracyjny zakłada, że w programie enova mamy założoną bazę danych o nazwie Demo, w której znajduje się operator o nazwie Administrator z dostępem bez hasła. Baza danych wypełniona danymi demonstracyjnymi. Jeżeli nie masz założonej odpowiedniej bazy danych, to należy ją utworzyć lub odpowienio zmodyfikować plik Form1.cs.
5. Po wykonaniu tych czynności można uruchomić program.

**Zawartość przykładu**

Przykładowa aplikacja składa się z jednego okna, w którym znajdziemy dwa przyciski wykonujące wymagane zadania. Jednak przez otwarciem okna wykonywana jest jeszcze jedna operacja zalogowania się do bazy danych. Wszystko to znajduje się w pliku Form1.cs.

**Zalogowanie do programu**

Jest to procedura wykonywana przed otwarciem okna aplikacji. Jej zadanim jest uzyskanie połączenia do bazy danych oraz zalogowanie się do tejże bazy operatora. Wynikiem finalnym tej operacji jest uzyskanie instancji obiektu Soneta.Business.App.Login, która pozwoli na utworzenie obiektu sesji i wykonanie operacji na logice biznesowej.
