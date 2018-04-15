Imports System.Xml
Public Class frmAbout

    Dim strArchitecture As String
    Dim XmlSettings As New XmlWriterSettings()

    Public Sub Architecture()

        If Environment.Is64BitProcess Then
            strArchitecture = "64bit"
        Else
            strArchitecture = "32bit"
        End If

    End Sub

    Public Sub LoadAboutTheme()

        Using XmlLoadAbout As XmlReader = XmlReader.Create("./Data/Theme.xml")

            XmlLoadAbout.ReadToFollowing("About")
            XmlLoadAbout.MoveToFirstAttribute()
            strArchitecture = XmlLoadAbout.Value 'Color
            lblMagatama.ForeColor = Color.FromName(strArchitecture)
            XmlLoadAbout.MoveToNextAttribute()
            strArchitecture = XmlLoadAbout.Value 'Color
            lblVersion.ForeColor = Color.FromName(strArchitecture)
        End Using
    End Sub


    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles Me.Load


        Call LoadAboutTheme()
        Call Architecture()

        Me.Text = "About " & My.Settings.strSoft & "..."
        Me.Icon = New Icon("./Graphics/Theme/icon.ico")
        Me.BackgroundImage = Image.FromFile("./Graphics/Theme/bg_about.png")
        lblMagatama.Text = My.Settings.strSoft
        lblVersion.Text = "Version : " & My.Settings.strVer & " (" & strArchitecture & ")"

        rtfCredits.Text = ("Develloped by : Aether89" & vbNewLine & vbNewLine &
            "Inspired by Mag Farm Version 0.9.7r2 Beta" & vbNewLine & "by James Baxter" & vbNewLine _
           & vbNewLine & "-- Special Thanks to --" & vbNewLine & vbNewLine & "SEGA and Sonic Team" & vbNewLine & vbNewLine &
            "PSO-World" & vbNewLine & " http://www.pso-world.com/ " & vbNewLine & vbNewLine & "Univers-PS" _
            & vbNewLine & "http://universps.online.fr" & vbNewLine & vbNewLine & "Phantasy Star Cave" _
            & vbNewLine & "http://www.pscave.com" & vbNewLine & vbNewLine & "Phantasy Star Online Wiki" _
            & vbNewLine & "http://pso.wikia.com/" & vbNewLine & vbNewLine & "Rico Journals by Koala Cuddle Party" _
            & vbNewLine & "http://koalacuddleparty.com/" & vbNewLine & vbNewLine & "Schtack for is PSO gsl Editor and PVM/XVM Tool" _
            & vbNewLine & vbNewLine & "-- Beta Tester --" & vbNewLine & vbNewLine & " [ Ephinea ] " & vbNewLine & "-Spuz" & vbNewLine _
            & "-Henonk" & vbNewLine & vbNewLine & " [ ULTIMA ] " & vbNewLine & "-Fyrewolf5" & vbNewLine & vbNewLine)

        btnOK.Focus()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub


End Class