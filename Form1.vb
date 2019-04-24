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


    Private Sub BtnInvRegistrer_Click(sender As Object, e As EventArgs) Handles BtnInvRegistrer.Click

        'SQLspørring for innlegging av sykkel/utstyr i database. Data hentes fra felt

    End Sub

    Private Sub BtnInvEndre_Click(sender As Object, e As EventArgs) Handles BtnInvEndre.Click

        'SQLspørring med endring av data for valgt produkt med ID fra valgt produkt i søkefelt

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
