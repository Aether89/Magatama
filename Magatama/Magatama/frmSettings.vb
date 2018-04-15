Imports System.Xml

Public Class frmSettings

    Dim XmlLoadSettingsInit As XmlReader = New XmlTextReader("./Data/Init.xml")
    Dim XmlSaveSettingsInit As XmlWriter
    Dim XmlSettings As New XmlWriterSettings()
    Dim strSettingsTmp As String

    Dim shocboSettingsCount As Short
    Dim shocboSettingsCountMax As Short
    Dim strSettingsGameVer As String = ""

    Public Sub cboSettingsClassList()

        shocboSettingsCount = 0
        shocboSettingsCountMax = 0
        cboSettingsClass.Items.Clear()

        Using XmlLoadSettingsInit As XmlReader = XmlReader.Create("./Data/List/Class.xml")

            XmlLoadSettingsInit.ReadToFollowing("Class")
            XmlLoadSettingsInit.MoveToAttribute("Total")
            shocboSettingsCountMax = XmlLoadSettingsInit.Value

            While shocboSettingsCount < shocboSettingsCountMax

                XmlLoadSettingsInit.ReadToFollowing("Class" & shocboSettingsCount)
                XmlLoadSettingsInit.MoveToAttribute(strSettingsGameVer)

                If XmlLoadSettingsInit.Value = "YES" Then
                    XmlLoadSettingsInit.MoveToAttribute("Name")
                    cboSettingsClass.Items.Add(XmlLoadSettingsInit.Value)
                End If

                shocboSettingsCount = (shocboSettingsCount + 1)
            End While

        End Using

        Using XmlLoadSettingsInit As XmlReader = XmlReader.Create("./Data/Init.xml")

            XmlLoadSettingsInit.ReadToFollowing("Class")
            XmlLoadSettingsInit.MoveToAttribute(strSettingsGameVer)
            cboSettingsClass.SelectedIndex = XmlLoadSettingsInit.Value 'SectionID
        End Using

        ' we don't use cboClass.SelectedIndex = 0 because we use the init to set the initial value 
    End Sub

    Public Sub cboSettingsSectionIdList()

        shocboSettingsCount = 0
        shocboSettingsCountMax = 0
        cboSettingsSectionID.Items.Clear()

        Using XmlLoadSettingsInit As XmlReader = XmlReader.Create("./Data/List/SectionID.xml")

            XmlLoadSettingsInit.ReadToFollowing("SectionID")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            shocboSettingsCountMax = XmlLoadSettingsInit.Value

            While shocboSettingsCount < shocboSettingsCountMax

                XmlLoadSettingsInit.ReadToFollowing("ID" & shocboSettingsCount)
                XmlLoadSettingsInit.MoveToFirstAttribute()
                cboSettingsSectionID.Items.Add(XmlLoadSettingsInit.Value)
                shocboSettingsCount = (shocboSettingsCount + 1)
            End While

        End Using
        ' we don't use cboSectionID.SelectedIndex = 0 because we use the init to set the initial value 
    End Sub

    Public Sub Init()

        Using XmlLoadMag As XmlReader = XmlReader.Create("./Data/Init.xml")
            XmlLoadMag.ReadToFollowing("GameVersion")
            XmlLoadMag.MoveToFirstAttribute()
            strSettingsGameVer = XmlLoadMag.Value 'GameVersion
        End Using


        Call cboSettingsSectionIdList()
        Call LoadInit()
        btnGeneral.PerformClick()

    End Sub

    Public Sub LoadInit()

        Using XmlLoadSettingsInit As XmlReader = XmlReader.Create("./Data/Init.xml")

            XmlLoadSettingsInit.ReadToFollowing("Default")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            cboSettingsSectionID.SelectedIndex = XmlLoadSettingsInit.Value 'SectionID
            XmlLoadSettingsInit.MoveToAttribute("FeedingTime")
            nudSettingsFeedingTime.Value = XmlLoadSettingsInit.Value 'Time between feeding cycle
            XmlLoadSettingsInit.MoveToAttribute("RacialRestriction")
            chkRacialRestriction.Checked = XmlLoadSettingsInit.Value 'Mag Racial Restriction

            XmlLoadSettingsInit.ReadToFollowing("Mag")
            XmlLoadSettingsInit.MoveToFirstAttribute() 'Max Level
            nudMaxLevel.Value = XmlLoadSettingsInit.Value
            XmlLoadSettingsInit.MoveToNextAttribute() 'Synchro
            nudSettingsSynchro.Value = XmlLoadSettingsInit.Value
            XmlLoadSettingsInit.MoveToNextAttribute() 'IQ
            nudSettingsIQ.Value = XmlLoadSettingsInit.Value
            XmlLoadSettingsInit.MoveToNextAttribute() 'DEF
            nudSettingsDEF.Value = XmlLoadSettingsInit.Value
            XmlLoadSettingsInit.MoveToNextAttribute() 'POW
            nudSettingsPOW.Value = XmlLoadSettingsInit.Value
            XmlLoadSettingsInit.MoveToNextAttribute() 'DEX
            nudSettingsDEX.Value = XmlLoadSettingsInit.Value
            XmlLoadSettingsInit.MoveToNextAttribute() 'MIND
            nudSettingsMIND.Value = XmlLoadSettingsInit.Value

            XmlLoadSettingsInit.ReadToFollowing("Monomate")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            nudCostMonomate.Value = XmlLoadSettingsInit.Value
            XmlLoadSettingsInit.ReadToFollowing("Dimate")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            nudCostDimate.Value = XmlLoadSettingsInit.Value
            XmlLoadSettingsInit.ReadToFollowing("Trimate")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            nudCostTrimate.Value = XmlLoadSettingsInit.Value
            XmlLoadSettingsInit.ReadToFollowing("Monofluid")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            nudCostMonofluid.Value = XmlLoadSettingsInit.Value
            XmlLoadSettingsInit.ReadToFollowing("Difluid")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            nudCostDifluid.Value = XmlLoadSettingsInit.Value
            XmlLoadSettingsInit.ReadToFollowing("Trifluid")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            nudCostTrifluid.Value = XmlLoadSettingsInit.Value
            XmlLoadSettingsInit.ReadToFollowing("Antidote")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            nudCostAntidote.Value = XmlLoadSettingsInit.Value
            XmlLoadSettingsInit.ReadToFollowing("Antiparalysis")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            nudCostAntiparalysis.Value = XmlLoadSettingsInit.Value
            XmlLoadSettingsInit.ReadToFollowing("SolAtomizer")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            nudCostSolAtomizer.Value = XmlLoadSettingsInit.Value
            XmlLoadSettingsInit.ReadToFollowing("MoonAtomizer")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            nudCostMoonAtomizer.Value = XmlLoadSettingsInit.Value
            XmlLoadSettingsInit.ReadToFollowing("StarAtomizer")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            nudCostStarAtomizer.Value = XmlLoadSettingsInit.Value
        End Using
    End Sub

    Public Sub SaveInit()

        XmlSaveSettingsInit = XmlWriter.Create("./Data/Init.xml", XmlSettings)
        With XmlSaveSettingsInit

            ' Write the Xml declaration.
            .WriteStartDocument()

            .WriteComment("Initial Value")
            .WriteStartElement("Root")
            .WriteStartElement("GameVersion")
            .WriteAttributeString("value", strSettingsGameVer)
            .WriteEndElement()

            .WriteStartElement("Class")

            If strSettingsGameVer = "Ep2" Or strSettingsGameVer = "Ep4" Then
                Select Case cboSettingsClass.SelectedIndex
                    Case = 3 'Replace HUcaseal With HUcast
                        .WriteAttributeString("Ep1", (cboSettingsClass.SelectedIndex - 1))
                    Case = 4 'RAmar 
                        .WriteAttributeString("Ep1", (cboSettingsClass.SelectedIndex - 1))
                    Case = 5 'Replace RAmarl with RAmar
                        .WriteAttributeString("Ep1", (cboSettingsClass.SelectedIndex - 2))
                    Case = 6 'RAcast
                        .WriteAttributeString("Ep1", (cboSettingsClass.SelectedIndex - 2))
                    Case = 7 'RAcaseal
                        .WriteAttributeString("Ep1", (cboSettingsClass.SelectedIndex - 2))
                    Case = 8 'Replace FOmar with FOmarl
                        .WriteAttributeString("Ep1", (cboSettingsClass.SelectedIndex - 2))
                    Case = 9 'FOmarl
                        .WriteAttributeString("Ep1", (cboSettingsClass.SelectedIndex - 3))
                    Case = 10 'FOnewm
                        .WriteAttributeString("Ep1", (cboSettingsClass.SelectedIndex - 3))
                    Case = 11 'FOnewearl
                        .WriteAttributeString("Ep1", (cboSettingsClass.SelectedIndex - 3))
                    Case Else
                        .WriteAttributeString("Ep1", cboSettingsClass.SelectedIndex)
                End Select
            Else
                .WriteAttributeString("Ep1", cboSettingsClass.SelectedIndex)
            End If

            If strSettingsGameVer = "Ep1" Then
                Select Case cboSettingsClass.SelectedIndex
                    Case = 3
                        .WriteAttributeString("Ep2", (cboSettingsClass.SelectedIndex + 1))
                        .WriteAttributeString("Ep4", (cboSettingsClass.SelectedIndex + 1))
                    Case = 4
                        .WriteAttributeString("Ep2", (cboSettingsClass.SelectedIndex + 2))
                        .WriteAttributeString("Ep4", (cboSettingsClass.SelectedIndex + 2))
                    Case = 5
                        .WriteAttributeString("Ep2", (cboSettingsClass.SelectedIndex + 2))
                        .WriteAttributeString("Ep4", (cboSettingsClass.SelectedIndex + 2))
                    Case = 6
                        .WriteAttributeString("Ep2", (cboSettingsClass.SelectedIndex + 3))
                        .WriteAttributeString("Ep4", (cboSettingsClass.SelectedIndex + 3))
                    Case = 7
                        .WriteAttributeString("Ep2", (cboSettingsClass.SelectedIndex + 3))
                        .WriteAttributeString("Ep4", (cboSettingsClass.SelectedIndex + 3))
                    Case = 8
                        .WriteAttributeString("Ep2", (cboSettingsClass.SelectedIndex + 3))
                        .WriteAttributeString("Ep4", (cboSettingsClass.SelectedIndex + 3))
                    Case Else
                        .WriteAttributeString("Ep2", cboSettingsClass.SelectedIndex)
                        .WriteAttributeString("Ep4", cboSettingsClass.SelectedIndex)
                End Select
            Else
                .WriteAttributeString("Ep2", cboSettingsClass.SelectedIndex)
                .WriteAttributeString("Ep4", cboSettingsClass.SelectedIndex)
            End If

            .WriteEndElement()

            .WriteStartElement("Default")
            .WriteAttributeString("SectionIDNumber", cboSettingsSectionID.SelectedIndex)
            .WriteAttributeString("SectionIDName", cboSettingsSectionID.SelectedItem)
            .WriteAttributeString("FeedingTime", nudSettingsFeedingTime.Value)
            .WriteAttributeString("RacialRestriction", chkRacialRestriction.Checked)
            .WriteEndElement()

            .WriteStartElement("Mag")
            .WriteAttributeString("MaxLevel", nudMaxLevel.Value)
            .WriteAttributeString("Synchro", nudSettingsSynchro.Value)
            .WriteAttributeString("IQ", nudSettingsIQ.Value)
            .WriteAttributeString("DEF", nudSettingsDEF.Value)
            .WriteAttributeString("POW", nudSettingsPOW.Value)
            .WriteAttributeString("DEX", nudSettingsDEX.Value)
            .WriteAttributeString("MIND", nudSettingsMIND.Value)

            .WriteComment("Item Cost ")

            .WriteStartElement("Monomate")
            .WriteAttributeString("Cost", nudCostMonomate.Value)
            .WriteEndElement()
            .WriteStartElement("Dimate")
            .WriteAttributeString("Cost", nudCostDimate.Value)
            .WriteEndElement()
            .WriteStartElement("Trimate")
            .WriteAttributeString("Cost", nudCostTrimate.Value)
            .WriteEndElement()
            .WriteStartElement("Monofluid")
            .WriteAttributeString("Cost", nudCostMonofluid.Value)
            .WriteEndElement()
            .WriteStartElement("Difluid")
            .WriteAttributeString("Cost", nudCostDifluid.Value)
            .WriteEndElement()
            .WriteStartElement("Trifluid")
            .WriteAttributeString("Cost", nudCostTrifluid.Value)
            .WriteEndElement()
            .WriteStartElement("Antidote")
            .WriteAttributeString("Cost", nudCostAntidote.Value)
            .WriteEndElement()
            .WriteStartElement("Antiparalysis")
            .WriteAttributeString("Cost", nudCostAntiparalysis.Value)
            .WriteEndElement()
            .WriteStartElement("SolAtomizer")
            .WriteAttributeString("Cost", nudCostSolAtomizer.Value)
            .WriteEndElement()
            .WriteStartElement("MoonAtomizer")
            .WriteAttributeString("Cost", nudCostMoonAtomizer.Value)
            .WriteEndElement()
            .WriteStartElement("StarAtomizer")
            .WriteAttributeString("Cost", nudCostStarAtomizer.Value)
            .WriteEndElement()

            .WriteEndDocument()
            .Close()
        End With
    End Sub

    Public Sub LoadSettingsTheme()

        Using XmlLoadSettingsInit As XmlReader = XmlReader.Create("./Data/Theme.xml")

            XmlLoadSettingsInit.ReadToFollowing("Monomate")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            lblCostMonomate.Text = XmlLoadSettingsInit.Value 'Text
            XmlLoadSettingsInit.MoveToNextAttribute()
            strSettingsTmp = XmlLoadSettingsInit.Value 'Color
            lblCostMonomate.ForeColor = Color.FromName(strSettingsTmp)

            XmlLoadSettingsInit.ReadToFollowing("Dimate")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            lblCostDimate.Text = XmlLoadSettingsInit.Value 'Text
            XmlLoadSettingsInit.MoveToNextAttribute()
            strSettingsTmp = XmlLoadSettingsInit.Value 'Color
            lblCostDimate.ForeColor = Color.FromName(strSettingsTmp)

            XmlLoadSettingsInit.ReadToFollowing("Trimate")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            lblCostTrimate.Text = XmlLoadSettingsInit.Value 'Text
            XmlLoadSettingsInit.MoveToNextAttribute()
            strSettingsTmp = XmlLoadSettingsInit.Value 'Color
            lblCostTrimate.ForeColor = Color.FromName(strSettingsTmp)

            XmlLoadSettingsInit.ReadToFollowing("Monofluid")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            lblCostMonofluid.Text = XmlLoadSettingsInit.Value 'Text
            XmlLoadSettingsInit.MoveToNextAttribute()
            strSettingsTmp = XmlLoadSettingsInit.Value 'Color
            lblCostMonofluid.ForeColor = Color.FromName(strSettingsTmp)

            XmlLoadSettingsInit.ReadToFollowing("Difluid")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            lblCostDifluid.Text = XmlLoadSettingsInit.Value 'Text
            XmlLoadSettingsInit.MoveToNextAttribute()
            strSettingsTmp = XmlLoadSettingsInit.Value 'Color
            lblCostDifluid.ForeColor = Color.FromName(strSettingsTmp)

            XmlLoadSettingsInit.ReadToFollowing("Trifluid")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            lblCostTrifluid.Text = XmlLoadSettingsInit.Value 'Text
            XmlLoadSettingsInit.MoveToNextAttribute()
            strSettingsTmp = XmlLoadSettingsInit.Value 'Color
            lblCostTrifluid.ForeColor = Color.FromName(strSettingsTmp)

            XmlLoadSettingsInit.ReadToFollowing("Antidote")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            lblCostAntidote.Text = XmlLoadSettingsInit.Value 'Text
            XmlLoadSettingsInit.MoveToNextAttribute()
            strSettingsTmp = XmlLoadSettingsInit.Value 'Color
            lblCostAntidote.ForeColor = Color.FromName(strSettingsTmp)

            XmlLoadSettingsInit.ReadToFollowing("Antiparalysis")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            lblCostAntiparalysis.Text = XmlLoadSettingsInit.Value 'Text
            XmlLoadSettingsInit.MoveToNextAttribute()
            strSettingsTmp = XmlLoadSettingsInit.Value 'Color
            lblCostAntiparalysis.ForeColor = Color.FromName(strSettingsTmp)

            XmlLoadSettingsInit.ReadToFollowing("SolAtomizer")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            lblCostSolAtomizer.Text = XmlLoadSettingsInit.Value 'Text
            XmlLoadSettingsInit.MoveToNextAttribute()
            strSettingsTmp = XmlLoadSettingsInit.Value 'Color
            lblCostSolAtomizer.ForeColor = Color.FromName(strSettingsTmp)

            XmlLoadSettingsInit.ReadToFollowing("MoonAtomizer")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            lblCostMoonAtomizer.Text = XmlLoadSettingsInit.Value 'Text
            XmlLoadSettingsInit.MoveToNextAttribute()
            strSettingsTmp = XmlLoadSettingsInit.Value 'Color
            lblCostMoonAtomizer.ForeColor = Color.FromName(strSettingsTmp)

            XmlLoadSettingsInit.ReadToFollowing("StarAtomizer")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            lblCostStarAtomizer.Text = XmlLoadSettingsInit.Value 'Text
            XmlLoadSettingsInit.MoveToNextAttribute()
            strSettingsTmp = XmlLoadSettingsInit.Value 'Color
            lblCostStarAtomizer.ForeColor = Color.FromName(strSettingsTmp)

            XmlLoadSettingsInit.ReadToFollowing("GameVersion")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            lblGameVersion.Text = XmlLoadSettingsInit.Value 'Text
            XmlLoadSettingsInit.MoveToNextAttribute()
            strSettingsTmp = XmlLoadSettingsInit.Value 'Color
            lblGameVersion.ForeColor = Color.FromName(strSettingsTmp)
            XmlLoadSettingsInit.MoveToNextAttribute()
            radVer1.Text = XmlLoadSettingsInit.Value 'Ver1
            XmlLoadSettingsInit.MoveToNextAttribute()
            strSettingsTmp = XmlLoadSettingsInit.Value 'Color
            radVer1.ForeColor = Color.FromName(strSettingsTmp)
            XmlLoadSettingsInit.MoveToNextAttribute()
            radEp2.Text = XmlLoadSettingsInit.Value 'Ep2
            XmlLoadSettingsInit.MoveToNextAttribute()
            strSettingsTmp = XmlLoadSettingsInit.Value 'Color
            radEp2.ForeColor = Color.FromName(strSettingsTmp)
            XmlLoadSettingsInit.MoveToNextAttribute()
            radBB.Text = XmlLoadSettingsInit.Value 'BB
            XmlLoadSettingsInit.MoveToNextAttribute()
            strSettingsTmp = XmlLoadSettingsInit.Value 'Color
            radBB.ForeColor = Color.FromName(strSettingsTmp)

            XmlLoadSettingsInit.ReadToFollowing("InitialClass")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            lblClass.Text = XmlLoadSettingsInit.Value 'Text
            XmlLoadSettingsInit.MoveToNextAttribute()
            strSettingsTmp = XmlLoadSettingsInit.Value 'Color
            lblClass.ForeColor = Color.FromName(strSettingsTmp)

            XmlLoadSettingsInit.ReadToFollowing("InitialSectionID")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            lblSectionID.Text = XmlLoadSettingsInit.Value 'Text
            XmlLoadSettingsInit.MoveToNextAttribute()
            strSettingsTmp = XmlLoadSettingsInit.Value 'Color
            lblSectionID.ForeColor = Color.FromName(strSettingsTmp)

            XmlLoadSettingsInit.ReadToFollowing("InitialSynchro")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            lblSynchro.Text = XmlLoadSettingsInit.Value 'Text
            XmlLoadSettingsInit.MoveToNextAttribute()
            strSettingsTmp = XmlLoadSettingsInit.Value 'Color
            lblSynchro.ForeColor = Color.FromName(strSettingsTmp)

            XmlLoadSettingsInit.ReadToFollowing("Time")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            lblFeedingTime.Text = XmlLoadSettingsInit.Value 'Text
            XmlLoadSettingsInit.MoveToNextAttribute()
            strSettingsTmp = XmlLoadSettingsInit.Value 'Color
            lblFeedingTime.ForeColor = Color.FromName(strSettingsTmp)

            XmlLoadSettingsInit.ReadToFollowing("Seconds")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            lblSettingsSeconds.Text = XmlLoadSettingsInit.Value 'Text
            XmlLoadSettingsInit.MoveToNextAttribute()
            strSettingsTmp = XmlLoadSettingsInit.Value 'Color
            lblSettingsSeconds.ForeColor = Color.FromName(strSettingsTmp)

            XmlLoadSettingsInit.ReadToFollowing("SettingsItems")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            lblSettingsItems.Text = XmlLoadSettingsInit.Value 'Text
            XmlLoadSettingsInit.MoveToNextAttribute()
            strSettingsTmp = XmlLoadSettingsInit.Value 'Color
            lblSettingsItems.ForeColor = Color.FromName(strSettingsTmp)

            XmlLoadSettingsInit.ReadToFollowing("SettingsCost")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            lblSettingsCost.Text = XmlLoadSettingsInit.Value 'Text
            XmlLoadSettingsInit.MoveToNextAttribute()
            strSettingsTmp = XmlLoadSettingsInit.Value 'Color
            lblSettingsCost.ForeColor = Color.FromName(strSettingsTmp)

            XmlLoadSettingsInit.ReadToFollowing("SettingsRacialRestriction")
            XmlLoadSettingsInit.MoveToFirstAttribute()
            chkRacialRestriction.Text = XmlLoadSettingsInit.Value 'Text
            XmlLoadSettingsInit.MoveToNextAttribute()
            strSettingsTmp = XmlLoadSettingsInit.Value 'Color
            chkRacialRestriction.ForeColor = Color.FromName(strSettingsTmp)


        End Using

    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles Me.Load

        XmlSettings.Indent = True
        XmlSettings.IndentChars = (ControlChars.Tab)
        Me.Text = My.Settings.strSoft & " Settings"
        Me.Icon = New Icon("./Graphics/Theme/icon.ico")
        Me.BackgroundImage = Image.FromFile("./Graphics/Theme/bg_settings.png")

        Call LoadSettingsTheme()
        Call Init()

        Select Case strSettingsGameVer

            Case = "Ep1"
                radVer1.Checked = True
            Case = "Ep2"
                radEp2.Checked = True
            Case = "Ep4"
                radBB.Checked = True
            Case Else
                radBB.Checked = True
        End Select


    End Sub

    Private Sub btnSettingsSave_Click(sender As Object, e As EventArgs) Handles btnSettingsSave.Click
        Call SaveInit()
        Me.Close()
    End Sub

    Private Sub radVer1_CheckedChanged(sender As Object, e As EventArgs) Handles radVer1.CheckedChanged
        If radVer1.Checked = True Then
            strSettingsGameVer = "Ep1"
            Call cboSettingsClassList()
        End If
    End Sub

    Private Sub radEp2_CheckedChanged(sender As Object, e As EventArgs) Handles radEp2.CheckedChanged
        If radEp2.Checked = True Then
            strSettingsGameVer = "Ep2"
            Call cboSettingsClassList()
        End If
    End Sub

    Private Sub radBB_CheckedChanged(sender As Object, e As EventArgs) Handles radBB.CheckedChanged
        If radBB.Checked = True Then
            strSettingsGameVer = "Ep4"
            Call cboSettingsClassList()
        End If
    End Sub

    Private Sub btnGeneral_Click(sender As Object, e As EventArgs) Handles btnGeneral.Click

        pnlGeneral.Visible = True
        pnlMag.Visible = False
        pnlCost.Visible = False
        Me.BackgroundImage = Image.FromFile("./Graphics/Theme/bg_settings_tab1.png")

    End Sub

    Private Sub btnMag_Click(sender As Object, e As EventArgs) Handles btnMag.Click
        pnlGeneral.Visible = False
        pnlMag.Visible = True
        pnlCost.Visible = False
        Me.BackgroundImage = Image.FromFile("./Graphics/Theme/bg_settings_tab2.png")

    End Sub

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        pnlGeneral.Visible = False
        pnlMag.Visible = False
        pnlCost.Visible = True
        Me.BackgroundImage = Image.FromFile("./Graphics/Theme/bg_settings_tab3.png")

    End Sub

End Class