'https://www.youtube.com/watch?v=TbjsWT2kdgs&ab_channel=BitByte

Imports System
Imports System.Xml
Imports System.IO

Public Class Einstellungen
    Public Sub Einstellungen_Load() Handles MyBase.Load


        Dim document As Xml.XmlReader = New Xml.XmlTextReader(Application.StartupPath + "\Programm_Config.xml")

        While (document.Read())
            Dim type = document.NodeType

            If (type = XmlNodeType.Element) Then
                If (document.Name = "TracePath") Then
                    TBDBPath.Text = document.ReadInnerXml.ToString
                ElseIf (document.Name = "TracePathLokal") Then
                    TBDBPathLokal.Text = document.ReadInnerXml.ToString
                ElseIf (document.Name = "BGConfig") Then
                    TBBGConfig.Text = document.ReadInnerXml.ToString
                ElseIf (document.Name = "SART") Then
                    TBSART.Text = document.ReadInnerXml.ToString
                ElseIf (document.Name = "Version_Schnittstelle") Then
                    TBVersTrace.Text = document.ReadInnerXml.ToString
                ElseIf (document.Name = "Mandant") Then
                    TBMandant.Text = document.ReadInnerXml.ToString
                End If
            End If

        End While
        document.Close()

        Form1.csvPath = TBDBPath.Text               'Trace Pfad einlesen
        Form1.csvLokal = TBDBPathLokal.Text         'lokalen Trace Pfad einlesen
        Form1.PfadBGConfig = TBBGConfig.Text        'Pfad für Baugruppen Config
        'Form1.SART = TBSART.Text                    'Anlagennummer Nutzentrenner
        Form1.Vers_Schnitt = TBVersTrace.Text       'Version Schnittstellendefinition
        Form1.Mandant = TBMandant.Text              'Mandant

    End Sub

    Public Sub Bspeichern_Click() Handles Bspeichern.Click

        Dim settings As New XmlWriterSettings()
        settings.Indent = True

        Dim xmlWrt As XmlWriter = XmlWriter.Create(Application.StartupPath + "\Programm_Config.xml", settings)

        With xmlWrt
            .WriteStartDocument()

            .WriteComment("Konfiguration")

            .WriteStartElement("Einstellungen")

            'Trace Pfad
            .WriteStartElement("TracePath")
            .WriteString(TBDBPath.Text.ToString())
            .WriteEndElement()
            'lokaler Trace Pfad
            .WriteStartElement("TracePathLokal")
            .WriteString(TBDBPathLokal.Text.ToString())
            .WriteEndElement()
            'Baugruppen Config Pfad
            .WriteStartElement("BGConfig")
            .WriteString(TBBGConfig.Text.ToString())
            .WriteEndElement()
            'Anlagennummer
            .WriteStartElement("SART")
            .WriteString(TBSART.Text.ToString())
            .WriteEndElement()
            'Version Trace Schnittstelle
            .WriteStartElement("Version_Schnittstelle")
            .WriteString(TBVersTrace.Text.ToString())
            .WriteEndElement()
            'Mandant
            .WriteStartElement("Mandant")
            .WriteString(TBMandant.Text.ToString())
            .WriteEndElement()

            .WriteEndElement()

            .WriteEndDocument()
            .Close()

        End With

        Form1.csvPath = TBDBPath.Text          'Trace Pfad einlesen
        Form1.csvLokal = TBDBPathLokal.Text         'lokalen Trace Pfad einlesen
        Form1.PfadBGConfig = TBBGConfig.Text        'Pfad für Baugruppen Config
        'Form1.SART = TBSART.Text                    'Anlagennummer Nutzentrenner
        Form1.Vers_Schnitt = TBVersTrace.Text       'Version Schnittstellendefinition
        Form1.Mandant = TBMandant.Text              'Mandant

        MsgBox("Einstellungen wurden gespeichert")
        Me.Close()
    End Sub

    Private Sub TBDBPath_Click(sender As Object, e As EventArgs) Handles TBDBPath.Click
        FolderBrowserDialog1.ShowDialog()
        TBDBPath.Text = FolderBrowserDialog1.SelectedPath + "\"
    End Sub

    Private Sub TBDBPathLokal_Click(sender As Object, e As EventArgs) Handles TBDBPathLokal.Click
        FolderBrowserDialog1.ShowDialog()
        TBDBPathLokal.Text = FolderBrowserDialog1.SelectedPath + "\"
    End Sub

    Private Sub Bspeichern_Click(sender As Object, e As EventArgs) Handles Bspeichern.Click, BBeenden.Click
        Me.Close()
    End Sub

    Private Sub TBBGConfig_Click(sender As Object, e As EventArgs) Handles TBBGConfig.Click
        OpenFileDialog1.ShowDialog()
        TBBGConfig.Text = OpenFileDialog1.FileName
    End Sub
End Class