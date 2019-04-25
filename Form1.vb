Imports MySql.Data.MySqlClient

Public Class Form1
#Region "GlobaleVariabler"
    'Her plasseres globale variabler
    'som gjenbrukes over programmet. De er uten navnekonvensjon
    'Husk å kommentere på kodensfunksjon og hvor i programmet den er tatt i bruk.
    'Test forandring
    ' Test hilsen IVar
    'Globalevariabler som må sjekkes ved ønsket tilgang. LogBool settes til TRUE ved inlogging, AdminBool settes til TRUE hvis bruker er admin.

    Dim LogBool As Boolean
    Dim AdminBool As Boolean
    Dim tilkobling As MySqlConnection




#End Region

#Region "GlobaleFunksjonerOgProsedyrer"
    'Her plasseres globale funksjoner og prosdyrer som gjenbrukes over programmet. De er uten navnekonvensjon
    'Husk å kommentere på kodensfunksjon og hvor i programmet den er tatt i bruk.

    Private Sub DBConnect()
        tilkobling = New MySqlConnection(
        "Server=mysql-ait.stud.idi.ntnu.no;" _
        & "Database=colinft;" _
        & "Uid=colinft;" _
        & "Pwd=BJhYR1HS;")
        Try
            tilkobling.Open()
        Catch ex As MySqlException
            MsgBox(ex)
        End Try
    End Sub

    Private Sub DBDisconnect()
        tilkobling.Close()
        tilkobling.Dispose()
    End Sub

#End Region

#Region "Form Load og Login"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


#End Region

#Region "TabSkifting"
    'Denne regionen er brukt til eventkoding av det som skjer da du skifter tab.
    'Nedenfor er en event som kjoeres hver gang man skifter tab. Den sjekker tabindex verdien og kjorer koden som er under det riktige caset.
    'Dette er til bruk for f.eks tilgangsskjekker og for aa laste inn verdier da man bytter til tabs.
    'Proev aa holde dette region saa ren som mulig, hvis man skal kjoere masse kode er det best aa lage egen prosedyre/funksjon for a derette kalle paa det nedenfor.
    Private Sub HovedTab_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HovedTab.SelectedIndexChanged
        Dim HovedTabIndex As Integer
        HovedTabIndex = HovedTab.SelectedIndex + 1

        Select Case HovedTabIndex
            Case 1 'Bestemmer det som skjer etter man har valgt startmeny.
                'MsgBox("Startmeny")
            Case 2 'Bestemmer det som skjer etter man har valgt Utleiemeny.
                'MsgBox("Utleiemeny")
            Case 3 'Bestemmer det som skjer etter man har valgt Kundedatabasemeny.
                'MsgBox("KDBmeny")
            Case 4 'Bestemmer det som skjer etter man har valgt Inventarmeny.
                'MsgBox("Inventarmeny")
            Case 5 'Bestemmer det som skjer etter man har valgt Inventarsearchmeny.
                'MsgBox("InvSearchmeny")
            Case 6 'Bestemmer det som skjer etter man har valgt Logistikkmeny.
                'MsgBox("Logistikkmeny")
            Case 7 'Bestemmer det som skjer etter man har valgt Statistikkmeny.
                'MsgBox("Statistikkmeny")
            Case 8 'Bestemmer det som skjer etter man har valgt Adminmeny.
                'MsgBox("AdminMeny")
            Case 9 'Bestemmer det som skjer etter man har valgt AdminDBmeny.
                'MsgBox("AdminDBMeny")
        End Select
    End Sub


#End Region

#Region "StartTab"
    'Her plasseres kode som er relevant til Start Tab.
    'Variabler som brukes her skal begynne med Start. Dette er for å unngå klasj.
    'Husk kode kommentarer.
#End Region


#Region "UtleieTab"
    'Her plasseres kode som er relevant til Utleie Tab.
    'Variabler som brukes her skal begynne med Leie. Dette er for å unngå klasj.
    'Husk kode kommentarer.
#End Region


#Region "KundeTab"
    'Her plasseres kode som er relevant til Kunde Tab.
    'Variabler som brukes her skal begynne med Kunde. Dette er for å unngå klasj.
    'Husk kode kommentarer.


    'Testing testing 123'
    'Håvard var her >:)'
#End Region


#Region "InventarTab"
    'Her plasseres kode som er relevant til Inventar Tab.
    'Variabler som brukes her skal begynne med Inv. Dette er for å unngå klasj.
    'Husk kode kommentarer.

    'Dropdown:
    'Kategori er delt i sykkel og utstyr.
    'Subkategorier vil avhenge av om det er sykkel eller utstyr som skal registreres. Disse må fastsettes.
    'Standardvalg for status, skadet, savnet er henholdsvis inne, nei, nei.

    'LblInvProduktID viser ID til objekt som ønskes endret.
    'LblInvRegistrertID viser ID til produkt som er registrert ETTER registreringen er fullført.

    'MsgBox for bekreftelse av registrering og endring av objekter.

    Private Sub BtnInvRegistrer_Click(sender As Object, e As EventArgs) Handles BtnInvRegistrer.Click

        Dim InvKategori, InvSubkategori, InvAvdeling, InvProduktnavn, InvVarenummer, InvInnkjopspris,
            InvRamme, InvHjulstorrlese, InvGirsystem, InvForhandler, InvStatus, InvSkadet, InvSavnet,
            InvSokefelt, InvProduktID As String

        Dim InvForhandlerID, InvAvdelingID, InvSubKategoriID As String

        Dim InvForhandlerIDSporring, InvAvdelingIDSporring, InvSubKategoriIDSporring As String

        Dim InvRegistrerSporring As String

        'Dim InvIDSporring As String    'evt reasign verdi mellom sporringer

        InvKategori = CboInvKategori.SelectedItem
        InvSubkategori = CboInvSubkategori.SelectedItem
        InvAvdeling = CboInvAvdeling.SelectedItem
        InvProduktnavn = TxtInvProduktnavn.Text
        InvVarenummer = TxtInvVareNummer.Text
        InvInnkjopspris = TxtInvInnkjopspris.Text
        InvRamme = TxtInvRamme.Text
        InvHjulstorrlese = TxtInvHjulstorrelse.Text
        InvGirsystem = TxtInvGirsystem.Text
        InvForhandler = CboInvForhandler.SelectedItem
        InvStatus = CboInvStatus.SelectedItem
        InvSkadet = CboInvSkadet.SelectedIndex
        InvSavnet = CboInvSavnet.SelectedIndex

        'SQLspørringer for henting av id fra forhandler, avdeling og subkategori
        InvForhandlerIDSporring = "SELECT forhandler_id FROM forhandler WHERE forhandler_navn='testforhandler';"
        InvAvdelingIDSporring = "SELECT avdeling_id FROM avdeling WHERE avd_navn='Finse';"
        InvSubKategoriIDSporring = "SELECT type_id FROM sykkel_typer WHERE kategori='Racer';"

        Dim InvSqlID As MySqlCommand
        Dim InvSqlLeser As MySqlDataReader
        Try
            DBConnect()

            InvSqlID = New MySqlCommand(InvForhandlerIDSporring, tilkobling)
            InvSqlLeser = InvSqlID.ExecuteReader()
            While InvSqlLeser.Read()
                InvForhandlerID = InvSqlLeser("forhandler_id")
            End While
            InvSqlLeser.Close()

            InvSqlID = New MySqlCommand(InvAvdelingIDSporring, tilkobling)
            InvSqlLeser = InvSqlID.ExecuteReader()
            While InvSqlLeser.Read()
                InvAvdelingID = InvSqlLeser("avdeling_id")
            End While
            InvSqlLeser.Close()

            InvSqlID = New MySqlCommand(InvSubKategoriIDSporring, tilkobling)
            InvSqlLeser = InvSqlID.ExecuteReader()
            While InvSqlLeser.Read()
                InvSubKategoriID = InvSqlLeser("type_id")
            End While
            InvSqlLeser.Close()

            DBDisconnect()

            'LstInvSokSokeResultat.Items.Add(InvForhandlerID + " " + InvAvdelingID + " " + InvKategoriID)
            LstInvSokSokeResultat.Items.Add(InvSkadet & " " & InvStatus)

        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

        'SQLspørring for innlegging av sykkel/utstyr i database. Data hentes fra felt

        If CboInvKategori.SelectedItem = "Sykkel" Then
            InvRegistrerSporring = "INSERT INTO sykler (forhandler_id, type_id, avdeling_id, sykkel_navn, " &
                "sykkel_modell, sykkel_pris, sykkel_status, hjul_str, sykkel_ramme, girsystem, savnet, skadet)" _
                & "VALUES (""" + InvForhandlerID & """, """ & InvSubKategoriID & """, """ _
                & InvAvdelingID + """, """ & InvProduktnavn & """, """ & InvVarenummer & """, """ _
                & InvInnkjopspris & """, """ & InvStatus & """, """ & InvHjulstorrlese & """, """ _
                & InvRamme & """, """ & InvGirsystem & """, """ & InvSavnet & """, """ & InvSkadet & """);"

            'Testspørring.
            'Dim sporring As String
            'sporring = "INSERT INTO sykler(forhandler_id, type_id, avdeling_id, sykkel_pris, sykkel_status, hjul_str, sykkel_ramme, girsystem, savnet, skadet) " &
            '  "VALUES('9999', '9999', '9999', '899', 'status' , '43', 'ramme', 'gir', '1', '2');"

            Try
                DBConnect()
                Dim da As New MySqlDataAdapter
                Dim sqlRegistrer As New MySqlCommand(InvRegistrerSporring, tilkobling)
                Dim interntabell As New DataTable
                da.SelectCommand = sqlRegistrer
                da.Fill(interntabell)
                DBdisconnect()
            Catch ex As MySqlException
                MsgBox(ex.Message)
            End Try

            'LstInvSokSokeResultat.Items.Add(InvRegistrerSporring)

        Else
            'Spørring for innlegg av utstyr.
            'Elementer i combobox for subkat må endres til subkat for utstyr.
            'VedBytteAvVerdi.comboboxkat -> comboboxsubkat.elementer = ...
        End If


    End Sub

    Private Sub BtnInvEndre_Click(sender As Object, e As EventArgs) Handles BtnInvEndre.Click
        'SQLspørring med _endring_ (alter table) av data for valgt produkt med ID fra valgt produkt i søkefelt
    End Sub

    Private Sub BtnIvnSokEndre_Click(sender As Object, e As EventArgs) Handles BtnIvnSokEndre.Click
        'ID nummer hentes fra TxtInvSokProduktID og SQLspørring henter objektet og legger verdiene i feltet for
        'registrering/endring. 
    End Sub

    Private Sub BtnInvSokSok_Click(sender As Object, e As EventArgs) Handles BtnInvSokSok.Click
        'SQLspørring med valgte søkekriterier for søk etter objekter 
        'Bruke samme skjema som reg/endre? 
        'chkbox for å velge kolonner som skal vises
        '  SELECT * FROM sykler WHERE diverse_felt = søkeverdi AND subkat, status, skadet, savnet = verdier

        DBConnect()

        'test for søk
        Dim testcommand As MySqlCommand
        Dim testleser As MySqlDataReader
        Dim testsporring As String
        Dim testarray(12) As String
        Dim arritem As ListViewItem
        'Dim testsporring2 As String
        Dim InvSokeKategori As String = "sykkel_navn"
        testsporring = "SELECT * FROM sykler WHERE " & InvSokeKategori & " LIKE '%" & TxtInvSokSokefelt.Text & "%'"
        'testsporring2 = "select * From sykler where forhandler_id=""9999"";"
        testcommand = New MySqlCommand(testsporring, tilkobling)
        testleser = testcommand.ExecuteReader()

        'for hver kolonne les inn verdi 0-12 og legg i listview
        While testleser.Read()
            For i = 0 To testleser.FieldCount - 1
                If TypeOf testleser(i) Is DBNull Then
                Else
                    testarray(i) = testleser(i)
                End If
            Next
            arritem = New ListViewItem(testarray)
            LivSok.Items.Add(arritem)
        End While

        '   legger inn i listbox
        'Dim testdata As String
        'While testleser.Read()
        '    testdata = ""
        '    For i = 0 To testleser.FieldCount - 1
        '        If TypeOf testleser(i) Is DBNull Then
        '            testdata = testdata + ""
        '        Else
        '            If testdata = "" Then
        '                testdata = CStr(testleser(i))
        '            Else
        '                testdata = testdata + " - " + CStr(testleser(i))
        '            End If
        '        End If
        '    Next
        '    LstInvSokSokeResultat.Items.Add(testdata)
        'End While

        testleser.Close()

        DBDisconnect()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim testarray(12) As String

        For i = 0 To testarray.Length - 1
            testarray(i) = CStr(i)
        Next

        Dim word As String
        For Each word In testarray
            LstInvSokSokeResultat.Items.Add(word)
        Next

        'For Each word In
        'While testleser.Read()
        '    testdata = testleser("sykkel_id")
        '    testdata = testdata + " " + testleser("sykkel_status")
        '    testdata = testdata + " " + testleser("girsystem")
        '    LstInvSokSokeResultat.Items.Add(testdata)
        'End While



        'Dim AdminSoekefelt, AdminSoekekategori As String
        '    AdminSoekefelt = TxtAdminBSFelt.Text
        '    AdminSoekekategori = CboAdminBSEtter.Text
        '    Try
        '        DBConnect()
        '        Dim AdminBrukerSearch As New MySqlCommand("SELECT * FROM brukere WHERE " & AdminSoekekategori & " LIKE '%" & AdminSoekefelt & "%'", tilkobling)
        '        Dim AdminSearchAdapter As New MySqlDataAdapter
        '        Dim AdminSearchTable As New DataTable
        '        AdminSearchAdapter.SelectCommand = AdminBrukerSearch
        '        AdminSearchAdapter.Fill(AdminSearchTable)
        '        DBDisconnect()
        '        Dim AdminRow As DataRow
        '        Dim AdminBSbruker_id, AdminBSfornavn, AdminBSetternavn, AdminBSsoekefelt As String
        '        LvAdminBS.Items.Clear()
        '        For Each AdminRow In AdminSearchTable.Rows
        '            AdminBSbruker_id = AdminRow("bruker_id")
        '            AdminBSfornavn = AdminRow("fornavn")
        '            AdminBSetternavn = AdminRow("etternavn")
        '            AdminBSsoekefelt = AdminRow(AdminSoekekategori)
        '            LvAdminBS.Items.Add(New ListViewItem({AdminBSbruker_id, AdminBSfornavn, AdminBSetternavn, AdminBSsoekefelt}))
        '        Next
        '    Catch SqlError2 As MySqlException
        '        MsgBox("Man får ikke koble til databasen: " & SqlError2.Message)
        '    End Try



    End Sub


#End Region


#Region "InventarSearchTab"
    'Her plasseres kode som er relevant til Inventar Search Tab.
    'Variabler som brukes her skal begynne med Search. Dette er for å unngå klasj.
    'Husk kode kommentarer.
#End Region


#Region "LogistikkTab"
    'Her plasseres kode som er relevant til Logistikk Tab.
    'Variabler som brukes her skal begynne med Logi. Dette er for å unngå klasj.
    'Husk kode kommentarer.
#End Region


#Region "StatistikkTab"
    'Her plasseres kode som er relevant til Statistikk Tab.
    'Variabler som brukes her skal begynne med Stat. Dette er for å unngå klasj.
    'Husk kode kommentarer.
#End Region


#Region "AdminTab"
    'Her plasseres kode som er relevant til Admin Tab.
    'Variabler som brukes her skal begynne med Admin. Dette er for å unngå klasj.
    'Husk kode kommentarer.
#End Region
End Class
