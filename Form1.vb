Imports MySql.Data.MySqlClient

Public Class Form1
#Region "GlobaleVariabler"
    'Her plasseres globale variabler
    'som gjenbrukes over programmet. De er uten navnekonvensjon
    'Husk å kommentere på kodensfunksjon og hvor i programmet den er tatt i bruk.
    'Test forandring
    ' Test hilsen IVar
    'Globalevariabler som må sjekkes ved ønsket tilgang. LogBool settes til TRUE ved inlogging, AdminBool settes til TRUE hvis bruker er admin.
    'e
    Dim LogBool As Boolean
    Dim AdminBool As Boolean
    Dim tilkobling As MySqlConnection


    Private Sub DBConnect()
        tilkobling = New MySqlConnection(
        "Server=mysql-ait.stud.idi.ntnu.no;" _
        & "Database=colinft;" _
        & "Uid=colinft;" &
        "Pwd=BJhYR1HS;")
        Try
            tilkobling.Open()
        Catch ex As MySqlException
            MsgBox(ex)
        End Try
    End Sub

    Private Sub DBdisconnect()
        tilkobling.Close()
    End Sub


#End Region

#Region "GlobaleFunksjonerOgProsedyrer"
    'Her plasseres globale funksjoner og prosdyrer som gjenbrukes over programmet. De er uten navnekonvensjon
    'Husk å kommentere på kodensfunksjon og hvor i programmet den er tatt i bruk.
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
    'Forhandlere og avdeling må fastsettes.
    'Standardvalg for status, skadet, savnet er henholdsvis inne, nei, nei.

    'LblInvProduktID viser ID til objekt som ønskes endret.
    'LblInvRegistrertID viser ID til produkt som er registrert ETTER registreringen er fullført.

    'MsgBox for bekreftelse av registrering og endring av objekter.

    Private Sub BtnInvRegistrer_Click(sender As Object, e As EventArgs) Handles BtnInvRegistrer.Click

        Dim InvKategori, InvSubkategori, InvAvdeling, InvProduktnavn, InvVarenummer, InvInnkjopspris,
            InvRamme, InvHjulstorrlese, InvGirsystem, InvForhandler, InvStatus, InvSkadet, InvSavnet,
            InvSokefelt, InvProduktID As String

        Dim InvRegistrerSporring As String
        Dim InvForhandlerID, InvAvdelingID, InvKategoriID As String

        Dim InvForhandlerIDSporring As String
        Dim InvAvdelingIDSporring As String
        Dim InvKategoriIDSporring As String

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
        InvSkadet = CboInvSkadet.SelectedItem
        InvSavnet = CboInvSavnet.SelectedItem

        'SQLspørring for henting av id fra navn
        InvForhandlerIDSporring = "SELECT forhandler_id FROM forhandler WHERE forhandler_navn='testforhandler';"
        InvAvdelingIDSporring = "SELECT avdeling_id FROM avdeling WHERE avd_navn='Finse';"
        InvKategoriIDSporring = "SELECT type_id FROM sykkel_typer WHERE kategori='Racer';"

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

            InvSqlID = New MySqlCommand(InvKategoriIDSporring, tilkobling)
            InvSqlLeser = InvSqlID.ExecuteReader()
            While InvSqlLeser.Read()
                InvKategoriID = InvSqlLeser("type_id")
            End While
            InvSqlLeser.Close()

            DBdisconnect()

            'LstInvSokSokeResultat.Items.Add(InvForhandlerID + " " + InvAvdelingID + " " + InvKategoriID)

        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try


        'SQLspørring for innlegging av sykkel/utstyr i database. Data hentes fra felt
        'If invkategori is sykler then try:

        'sporring = "INSERT INTO sykler (forhandler_id, type_id, avdeling_id, sykkel_pris, sykkel_status, hjul_str, sykkel_ramme, girsystem, savnet, skadet) VALUES (""" + InvForhandlerID + """, """ + InvSubkategori + """, """ +
        '    InvAvdeling + """, """ + InvInnkjopspris + """, """ + InvStatus + """, """ + InvStatus + """, """ +
        '    InvHjulstorrlese + """, """ + InvRamme + """, """ + InvGirsystem + """, """ + InvSavnet +
        '    """, """ + InvSkadet + """);"

        'sporring = "INSERT INTO sykler VALUES(""" + InvForhandlerID + """, """ + InvSubkategori + """, """ +
        '    InvAvdeling + """, """ + InvInnkjopspris + """, """ + InvStatus + """, """ + InvStatus + """, """ +
        '    InvHjulstorrlese + """, """ + InvRamme + """, """ + InvGirsystem + """, """ + InvSavnet +
        '    """, """ + InvSkadet + """);"

        'testspørring. bruk linjer over med Id fra id spørring
        InvRegistrerSporring = "INSERT INTO sykler(forhandler_id, type_id, avdeling_id, sykkel_pris, sykkel_status, hjul_str, sykkel_ramme, girsystem, savnet, skadet) " &
           "VALUES('9999', '9999', '9999', '899', 'status' , '43', 'ramme', 'gir', '1', '2');"

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

        LstInvSokSokeResultat.Items.Add(InvRegistrerSporring)

    End Sub

    Private Sub BtnInvEndre_Click(sender As Object, e As EventArgs) Handles BtnInvEndre.Click        'SQLspørring med endring av data for valgt produkt med ID fra valgt produkt i søkefelt

    End Sub

    Private Sub BtnIvnSokEndre_Click(sender As Object, e As EventArgs) Handles BtnIvnSokEndre.Click
        'ID nummer hentes fra TxtInvSokProduktID og SQLspørring henter objektet og legger verdiene i feltet for
        'registrering/endring. 
    End Sub

    Private Sub BtnInvSokSok_Click(sender As Object, e As EventArgs) Handles BtnInvSokSok.Click
        'SQLspørring med valgte søkekriterier for søk etter objekter 
    End Sub


#End Region


#Region "InventarSearchTab"
    'Her plasseres kode som er relevant til Inventar Search Tab.
    'Variabler som brukes her skal begynne med Search. Dette er for å unngå klasj.
    'Husk kode kommentarer.

    'Fritt søkefelt
    'Dropdown med tilgjengelige kategorier for å avgrense søk
    'Mulig med tomt søkefelt for å finne alle objekter i en kategori
    'Søkeresultat med alle kolonner

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
