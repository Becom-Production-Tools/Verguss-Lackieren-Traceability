Public Class Form_Error
    Public Property ISNR As String
    Public Property SART_Pre As String
    Public Property Fehler As Integer


    Private Sub Form_Error_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Fehler = 1    --> keine Daten aus Vorprozess
        ' Fehler = 2    --> Vorprozess NOK
        ' Fehler = 3    --> Status der Baugruppe falsch
        Lblcheck.Visible = False

        If Fehler = 1 Then
            TBFehler.Text = ISNR
            LblError.Text = "Keine Daten vom Vorprozess " & SART_Pre & " vorhanden"
        ElseIf Fehler = 2 Then
            TBFehler.Text = ISNR
            LblError.Text = "Vorprozess " & SART_Pre & " fehlerhaft"
        ElseIf Fehler = 3 Then
            TBFehler.Text = ISNR
            LblError.Text = "Seriennummer ist ungültig oder hat einen falschen Zustand (geliefert, Slave, ...)"
        ElseIf Fehler = 4 Then
            TBFehler.Text = ISNR
            LblError.Text = "Seriennummernreferenz fehlerhaft"
        ElseIf Fehler = 5 Then
            TBFehler.Text = ISNR
            LblError.Text = "Fehler Aushärtezeit"
        End If

        TBsearch.Select()
        Me.Refresh()
    End Sub

    Private Sub TBsearch_TextChanged(sender As Object, e As EventArgs) Handles TBsearch.TextChanged


        If TBsearch.TextLength = 13 Then
            TBsearch.Text = Microsoft.VisualBasic.Right(TBsearch.Text, 13)    'für Thomas Magnete
            Lblcheck.Visible = True
            If TBsearch.Text = ISNR Then
                Lblcheck.Text = "Fehlerhafte Baugruppe gefunden"
                Lblcheck.BackColor = Color.Green
                Me.BackColor = Color.LightGreen
                Timer_Error.Start()
                Label3.Visible = True
                Label4.Visible = True
                Label5.Visible = True
            Else
                Lblcheck.Text = "Falsche Seriennummer gescannt"
                Lblcheck.BackColor = Color.Red
                TBsearch.Clear()
                TBsearch.Select()
            End If
        End If

    End Sub

    Private Sub Timer_Error_Tick(sender As Object, e As EventArgs) Handles Timer_Error.Tick
        Label4.Text = Label4.Text - 1
        bclose.Enabled = True

        If Label4.Text = "0" Then
            Me.Close()
        End If

    End Sub

    Private Sub bclose_Click(sender As Object, e As EventArgs) Handles bclose.Click
        Me.Close()
    End Sub
End Class