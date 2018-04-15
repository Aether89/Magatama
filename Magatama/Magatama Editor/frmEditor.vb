Imports System.Xml


Public Class frmEditor

    Dim strPathEditorPicMag As Image = My.Resources.ResourceManager.GetObject(0)
    Dim strPathEditorPicPhotonBlast As Image = My.Resources.ResourceManager.GetObject(0)

    Dim XmlLoadEditor As XmlReader = New XmlTextReader("./Data/Mag/Mag.xml")
    Dim XmlSaveEditor As XmlWriter
    Dim XmlSettings As New XmlWriterSettings()

    Dim strEditorTmp As String

    Dim strEditorPhotonBlast As String
    Dim strEditorPhotonBlastText As String

    Dim shoEditorcboCount As Short
    Dim shoEditorcboCountMax As Short
    Dim strEditorGameVer As String = "Ep4"

    Dim strEditorSearch As String


#Region "Public Sub"

    Public Sub EditorcboMagList()

        shoEditorcboCount = 0
        shoEditorcboCountMax = 0

        lsbEditorMag.Items.Clear()
        Using XmlLoadEditor As XmlReader = XmlReader.Create("./Data/List/Mag.xml")

            XmlLoadEditor.ReadToFollowing("GameVersion")
            XmlLoadEditor.MoveToAttribute(strEditorGameVer)
            shoEditorcboCountMax = XmlLoadEditor.Value

            While shoEditorcboCount < shoEditorcboCountMax

                XmlLoadEditor.ReadToFollowing("Mag" & shoEditorcboCount)
                XmlLoadEditor.MoveToFirstAttribute()
                lsbEditorMag.Items.Add(XmlLoadEditor.Value)
                shoEditorcboCount = (shoEditorcboCount + 1)
            End While

            lsbEditorMag.SelectedIndex = 0

        End Using
    End Sub

    Public Sub EditorTriggerList()

        shoEditorcboCount = 0
        shoEditorcboCountMax = 0
        strEditorTmp = ""

        cboEditorPBFilled.Items.Clear()
        cboEditor1HP10.Items.Clear()
        cboEditorBoss.Items.Clear()
        cboEditorDeath.Items.Clear()

        Using XmlLoadEditor As XmlReader = XmlReader.Create("./Data/List/ActivationTrigger.xml")

            XmlLoadEditor.ReadToFollowing("ActivationTrigger")
            XmlLoadEditor.MoveToAttribute("Total")
            shoEditorcboCountMax = XmlLoadEditor.Value

            While shoEditorcboCount < shoEditorcboCountMax

                XmlLoadEditor.ReadToFollowing("AT" & shoEditorcboCount)

                XmlLoadEditor.MoveToFirstAttribute() 'Name
                strEditorTmp = XmlLoadEditor.Value

                XmlLoadEditor.MoveToNextAttribute() 'PB Filled
                If XmlLoadEditor.Value = "YES" Then
                    cboEditorPBFilled.Items.Add(strEditorTmp)
                End If

                XmlLoadEditor.MoveToNextAttribute() 'Low HP
                If XmlLoadEditor.Value = "YES" Then
                    cboEditor1HP10.Items.Add(strEditorTmp)
                End If

                XmlLoadEditor.MoveToNextAttribute() 'Boss
                If XmlLoadEditor.Value = "YES" Then
                    cboEditorBoss.Items.Add(strEditorTmp)
                End If

                XmlLoadEditor.MoveToNextAttribute() 'Death
                If XmlLoadEditor.Value = "YES" Then
                    cboEditorDeath.Items.Add(strEditorTmp)
                End If

                shoEditorcboCount = (shoEditorcboCount + 1)
            End While

        End Using

    End Sub

    Public Sub EditorPhotonBlastList()

        shoEditorcboCount = 0
        shoEditorcboCountMax = 0


        cboEditorPhotonBlast.Items.Clear()
        Using XmlLoadEditor As XmlReader = XmlReader.Create("./Data/List/PhotonBlast.xml")

            XmlLoadEditor.ReadToFollowing("PhotonBlast")
            XmlLoadEditor.MoveToAttribute("Total")
            shoEditorcboCountMax = XmlLoadEditor.Value

            While shoEditorcboCount < shoEditorcboCountMax

                XmlLoadEditor.ReadToFollowing("PB" & shoEditorcboCount)
                XmlLoadEditor.MoveToFirstAttribute()
                cboEditorPhotonBlast.Items.Add(XmlLoadEditor.Value)
                shoEditorcboCount = (shoEditorcboCount + 1)
            End While

            cboEditorPhotonBlast.SelectedIndex = 0

        End Using
    End Sub


    Public Sub EditorInit()

        Call EditorTriggerList()

        Call EditorPhotonBlastList()

        Call EditorPhotonBlastXML()
        Call EditorcboMagList()
        Call LoadFeedingChart()

    End Sub

    Public Sub MagUpdate()

        shoEditorcboCount = lsbEditorMag.SelectedIndex
        shoEditorcboCountMax = lsbEditorMag.Items.Count

        While shoEditorcboCount < shoEditorcboCountMax
            lsbEditorMag.SelectedIndex = shoEditorcboCount
            mnuEditorFileSaveMag.PerformClick()

            shoEditorcboCount = shoEditorcboCount + 1
        End While

    End Sub

    Public Sub EditorMagSave()
        XmlSaveEditor = XmlWriter.Create("./Data/Mag/" & lsbEditorMag.SelectedIndex & ".xml", XmlSettings)
        With XmlSaveEditor

            ' Write the Xml declaration.
            .WriteStartDocument()

            .WriteStartElement("root")

            .WriteStartElement("Mag")
            .WriteAttributeString("ID", lsbEditorMag.SelectedIndex)
            .WriteAttributeString("Name", lsbEditorMag.SelectedItem)
            .WriteAttributeString("Stage", nudEditorStage.Value)

            If radEditorMagEp1.Checked = True Then
                .WriteAttributeString("GameVer", "Ep1")
            End If

            If radEditorMagEp2.Checked = True Then
                .WriteAttributeString("GameVer", "Ep2")
            End If

            If radEditorMagEp4.Checked = True Then
                .WriteAttributeString("GameVer", "Ep4")
            End If

            .WriteEndElement()

            .WriteStartElement("Table")
            .WriteAttributeString("ID", nudEditorFeedingTables.Value)
            .WriteEndElement()

            .WriteStartElement("PhotonBlast")
            .WriteAttributeString("ID", cboEditorPhotonBlast.SelectedIndex)
            .WriteAttributeString("Name", cboEditorPhotonBlast.SelectedItem)
            .WriteEndElement()

            .WriteComment("Triggered Actions")
            .WriteStartElement("Activation")
            .WriteAttributeString("Chance", nudEditorActivation.Value)
            .WriteEndElement()

            .WriteStartElement("PB_Filled")
            .WriteAttributeString("ID", cboEditorPBFilled.SelectedIndex)
            .WriteAttributeString("desc", cboEditorPBFilled.SelectedItem)
            .WriteEndElement()
            .WriteStartElement("LowHP")
            .WriteAttributeString("ID", cboEditor1HP10.SelectedIndex)
            .WriteAttributeString("desc", cboEditor1HP10.SelectedItem)
            .WriteEndElement()
            .WriteStartElement("Boss")
            .WriteAttributeString("ID", cboEditorBoss.SelectedIndex)
            .WriteAttributeString("desc", cboEditorBoss.SelectedItem)
            .WriteEndElement()
            .WriteStartElement("Death")
            .WriteAttributeString("ID", cboEditorDeath.SelectedIndex)
            .WriteAttributeString("desc", cboEditorDeath.SelectedItem)
            .WriteEndElement()

            .WriteEndDocument()
            .Close()
        End With

    End Sub

    Public Sub EditorChartSave()
        XmlSaveEditor = XmlWriter.Create("./Data/FeedingTables/Table_" & nudEditorFeedingTables.Value & ".xml", XmlSettings)
        With XmlSaveEditor

            ' Write the Xml declaration.
            .WriteStartDocument()

            .WriteStartElement("root")

            .WriteStartElement("Monomate")
            .WriteAttributeString("Sync", nudSyncMonomate.Value)
            .WriteAttributeString("IQ", nudIQMonomate.Value)
            .WriteAttributeString("DEF", nudDEFMonomate.Value)
            .WriteAttributeString("POW", nudPOWMonomate.Value)
            .WriteAttributeString("DEX", nudDEXMonomate.Value)
            .WriteAttributeString("MIND", nudMINDMonomate.Value)
            .WriteEndElement()

            .WriteStartElement("Dimate")
            .WriteAttributeString("Sync", nudSyncDimate.Value)
            .WriteAttributeString("IQ", nudIQDimate.Value)
            .WriteAttributeString("DEF", nudDEFDimate.Value)
            .WriteAttributeString("POW", nudPOWDimate.Value)
            .WriteAttributeString("DEX", nudDEXDimate.Value)
            .WriteAttributeString("MIND", nudMINDDimate.Value)
            .WriteEndElement()

            .WriteStartElement("Trimate")
            .WriteAttributeString("Sync", nudSyncTrimate.Value)
            .WriteAttributeString("IQ", nudIQTrimate.Value)
            .WriteAttributeString("DEF", nudDEFTrimate.Value)
            .WriteAttributeString("POW", nudPOWTrimate.Value)
            .WriteAttributeString("DEX", nudDEXTrimate.Value)
            .WriteAttributeString("MIND", nudMINDTrimate.Value)
            .WriteEndElement()

            .WriteStartElement("Monofluid")
            .WriteAttributeString("Sync", nudSyncMonofluid.Value)
            .WriteAttributeString("IQ", nudIQMonofluid.Value)
            .WriteAttributeString("DEF", nudDEFMonofluid.Value)
            .WriteAttributeString("POW", nudPOWMonofluid.Value)
            .WriteAttributeString("DEX", nudDEXMonofluid.Value)
            .WriteAttributeString("MIND", nudMINDMonofluid.Value)
            .WriteEndElement()

            .WriteStartElement("Difluid")
            .WriteAttributeString("Sync", nudSyncDifluid.Value)
            .WriteAttributeString("IQ", nudIQDifluid.Value)
            .WriteAttributeString("DEF", nudDEFDifluid.Value)
            .WriteAttributeString("POW", nudPOWDifluid.Value)
            .WriteAttributeString("DEX", nudDEXDifluid.Value)
            .WriteAttributeString("MIND", nudMINDDifluid.Value)
            .WriteEndElement()

            .WriteStartElement("Trifluid")
            .WriteAttributeString("Sync", nudSyncTrifluid.Value)
            .WriteAttributeString("IQ", nudIQTrifluid.Value)
            .WriteAttributeString("DEF", nudDEFTrifluid.Value)
            .WriteAttributeString("POW", nudPOWTrifluid.Value)
            .WriteAttributeString("DEX", nudDEXTrifluid.Value)
            .WriteAttributeString("MIND", nudMINDTrifluid.Value)
            .WriteEndElement()

            .WriteStartElement("Antidote")
            .WriteAttributeString("Sync", nudSyncAntidote.Value)
            .WriteAttributeString("IQ", nudIQAntidote.Value)
            .WriteAttributeString("DEF", nudDEFAntidote.Value)
            .WriteAttributeString("POW", nudPOWAntidote.Value)
            .WriteAttributeString("DEX", nudDEXAntidote.Value)
            .WriteAttributeString("MIND", nudMINDAntidote.Value)
            .WriteEndElement()

            .WriteStartElement("Antiparalysis")
            .WriteAttributeString("Sync", nudSyncAntiparalysis.Value)
            .WriteAttributeString("IQ", nudIQAntiparalysis.Value)
            .WriteAttributeString("DEF", nudDEFAntiparalysis.Value)
            .WriteAttributeString("POW", nudPOWAntiparalysis.Value)
            .WriteAttributeString("DEX", nudDEXAntiparalysis.Value)
            .WriteAttributeString("MIND", nudMINDAntiparalysis.Value)
            .WriteEndElement()

            .WriteStartElement("SolAtomizer")
            .WriteAttributeString("Sync", nudSyncSolAtomizer.Value)
            .WriteAttributeString("IQ", nudIQSolAtomizer.Value)
            .WriteAttributeString("DEF", nudDEFSolAtomizer.Value)
            .WriteAttributeString("POW", nudPOWSolAtomizer.Value)
            .WriteAttributeString("DEX", nudDEXSolAtomizer.Value)
            .WriteAttributeString("MIND", nudMINDSolAtomizer.Value)
            .WriteEndElement()

            .WriteStartElement("MoonAtomizer")
            .WriteAttributeString("Sync", nudSyncMoonAtomizer.Value)
            .WriteAttributeString("IQ", nudIQMoonAtomizer.Value)
            .WriteAttributeString("DEF", nudDEFMoonAtomizer.Value)
            .WriteAttributeString("POW", nudPOWMoonAtomizer.Value)
            .WriteAttributeString("DEX", nudDEXMoonAtomizer.Value)
            .WriteAttributeString("MIND", nudMINDMoonAtomizer.Value)
            .WriteEndElement()

            .WriteStartElement("StarAtomizer")
            .WriteAttributeString("Sync", nudSyncStarAtomizer.Value)
            .WriteAttributeString("IQ", nudIQStarAtomizer.Value)
            .WriteAttributeString("DEF", nudDEFStarAtomizer.Value)
            .WriteAttributeString("POW", nudPOWStarAtomizer.Value)
            .WriteAttributeString("DEX", nudDEXStarAtomizer.Value)
            .WriteAttributeString("MIND", nudMINDStarAtomizer.Value)
            .WriteEndElement()

            .WriteEndElement()
            .WriteEndDocument()
            .Close()
        End With

    End Sub

    Public Sub Unsaved()
        picEditorSave.Image = Image.FromFile("./Graphics/Theme/unsaved.png")
        picEditorSave.Tag = "Unsaved"
    End Sub

    Public Sub Saved()
        picEditorSave.Image = Image.FromFile("./Graphics/Theme/saved.png")
        picEditorSave.Tag = "Saved"
    End Sub

    Public Sub LoadMagData()

        Using XmlLoadMag As XmlReader = XmlReader.Create("./Data/Mag/" & lsbEditorMag.SelectedIndex & ".xml")

            XmlLoadMag.ReadToFollowing("Mag")
            XmlLoadMag.MoveToAttribute("Stage")
            nudEditorStage.Value = XmlLoadMag.Value

            XmlLoadMag.ReadToFollowing("Table")
            XmlLoadMag.MoveToFirstAttribute()
            nudEditorFeedingTables.Value = XmlLoadMag.Value

            XmlLoadMag.ReadToFollowing("PhotonBlast")
            XmlLoadMag.MoveToFirstAttribute()
            cboEditorPhotonBlast.SelectedIndex = XmlLoadMag.Value

            XmlLoadMag.ReadToFollowing("Activation")
            XmlLoadMag.MoveToFirstAttribute()
            nudEditorActivation.Value = XmlLoadMag.Value

            XmlLoadMag.ReadToFollowing("PB_Filled")
            XmlLoadMag.MoveToFirstAttribute()
            cboEditorPBFilled.SelectedIndex = XmlLoadMag.Value
            XmlLoadMag.ReadToFollowing("LowHP")
            XmlLoadMag.MoveToFirstAttribute()
            cboEditor1HP10.SelectedIndex = XmlLoadMag.Value
            XmlLoadMag.ReadToFollowing("Boss")
            XmlLoadMag.MoveToFirstAttribute()
            cboEditorBoss.SelectedIndex = XmlLoadMag.Value
            XmlLoadMag.ReadToFollowing("Death")
            XmlLoadMag.MoveToFirstAttribute()
            cboEditorDeath.SelectedIndex = XmlLoadMag.Value

        End Using

    End Sub

    Public Sub LoadFeedingChart()

        Using XmlLoadEditor As XmlReader = XmlReader.Create("./Data/FeedingTables/Table_" & nudEditorFeedingTables.Value & ".xml")

            XmlLoadEditor.ReadToFollowing("Monomate")
            XmlLoadEditor.MoveToFirstAttribute()
            nudSyncMonomate.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudIQMonomate.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudDEFMonomate.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudPOWMonomate.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudDEXMonomate.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudMINDMonomate.Value = XmlLoadEditor.Value

            XmlLoadEditor.ReadToFollowing("Dimate")
            XmlLoadEditor.MoveToFirstAttribute()
            nudSyncDimate.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudIQDimate.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudDEFDimate.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudPOWDimate.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudDEXDimate.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudMINDDimate.Value = XmlLoadEditor.Value

            XmlLoadEditor.ReadToFollowing("Trimate")
            XmlLoadEditor.MoveToFirstAttribute()
            nudSyncTrimate.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudIQTrimate.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudDEFTrimate.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudPOWTrimate.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudDEXTrimate.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudMINDTrimate.Value = XmlLoadEditor.Value

            XmlLoadEditor.ReadToFollowing("Monofluid")
            XmlLoadEditor.MoveToFirstAttribute()
            nudSyncMonofluid.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudIQMonofluid.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudDEFMonofluid.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudPOWMonofluid.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudDEXMonofluid.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudMINDMonofluid.Value = XmlLoadEditor.Value

            XmlLoadEditor.ReadToFollowing("Difluid")
            XmlLoadEditor.MoveToFirstAttribute()
            nudSyncDifluid.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudIQDifluid.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudDEFDifluid.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudPOWDifluid.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudDEXDifluid.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudMINDDifluid.Value = XmlLoadEditor.Value

            XmlLoadEditor.ReadToFollowing("Trifluid")
            XmlLoadEditor.MoveToFirstAttribute()
            nudSyncTrifluid.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudIQTrifluid.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudDEFTrifluid.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudPOWTrifluid.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudDEXTrifluid.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudMINDTrifluid.Value = XmlLoadEditor.Value

            XmlLoadEditor.ReadToFollowing("Antidote")
            XmlLoadEditor.MoveToFirstAttribute()
            nudSyncAntidote.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudIQAntidote.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudDEFAntidote.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudPOWAntidote.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudDEXAntidote.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudMINDAntidote.Value = XmlLoadEditor.Value

            XmlLoadEditor.ReadToFollowing("Antiparalysis")
            XmlLoadEditor.MoveToFirstAttribute()
            nudSyncAntiparalysis.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudIQAntiparalysis.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudDEFAntiparalysis.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudPOWAntiparalysis.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudDEXAntiparalysis.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudMINDAntiparalysis.Value = XmlLoadEditor.Value

            XmlLoadEditor.ReadToFollowing("SolAtomizer")
            XmlLoadEditor.MoveToFirstAttribute()
            nudSyncSolAtomizer.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudIQSolAtomizer.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudDEFSolAtomizer.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudPOWSolAtomizer.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudDEXSolAtomizer.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudMINDSolAtomizer.Value = XmlLoadEditor.Value

            XmlLoadEditor.ReadToFollowing("MoonAtomizer")
            XmlLoadEditor.MoveToFirstAttribute()
            nudSyncMoonAtomizer.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudIQMoonAtomizer.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudDEFMoonAtomizer.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudPOWMoonAtomizer.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudDEXMoonAtomizer.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudMINDMoonAtomizer.Value = XmlLoadEditor.Value

            XmlLoadEditor.ReadToFollowing("StarAtomizer")
            XmlLoadEditor.MoveToFirstAttribute()
            nudSyncStarAtomizer.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudIQStarAtomizer.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudDEFStarAtomizer.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudPOWStarAtomizer.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudDEXStarAtomizer.Value = XmlLoadEditor.Value
            XmlLoadEditor.MoveToNextAttribute()
            nudMINDStarAtomizer.Value = XmlLoadEditor.Value

        End Using
    End Sub

    Public Sub EditorPhotonBlastXML() 'PhotonBlast Tooltips Text

        strEditorPhotonBlast = cboEditorPhotonBlast.SelectedItem

        Using XmlLoadPhotonBlast As XmlReader = XmlReader.Create("./Data/PhotonBlast.xml")
            While (XmlLoadPhotonBlast.Read())
                Dim type = XmlLoadPhotonBlast.NodeType


                If (type = XmlNodeType.Element) Then

                    If (XmlLoadPhotonBlast.Name = strEditorPhotonBlast) Then
                        strEditorPhotonBlastText = XmlLoadPhotonBlast.ReadInnerXml.ToString()
                    End If

                End If

            End While
        End Using

        ttEditor.SetToolTip(picEditorPhotonBlast, strEditorPhotonBlastText)

    End Sub

#End Region

    Private Sub frmEditor_Load(sender As Object, e As EventArgs) Handles Me.Load
        XmlSettings.Indent = True
        XmlSettings.IndentChars = (ControlChars.Tab)
        Me.Text = My.Settings.strSoft
        Me.Icon = New Icon("./Graphics/Theme/editor.ico")
        Me.BackgroundImage = Image.FromFile("./Graphics/Theme/bg_editor.png")
        tabEditorMag.SelectedTab = tabEditorMagInfo
        Call EditorInit()
    End Sub

#Region "Value Change"
    Private Sub lsbEditorMag_SelectedValueChanged(sender As Object, e As EventArgs) Handles lsbEditorMag.SelectedValueChanged
        strPathEditorPicMag = Image.FromFile("./Graphics/Mag/" & lsbEditorMag.SelectedIndex & ".png")
        picEditorMag.Image = strPathEditorPicMag
        ttEditor.SetToolTip(picEditorMag, lsbEditorMag.SelectedItem)
        lblEditorMagName.Text = lsbEditorMag.SelectedItem

        Call LoadMagData()
    End Sub



    Private Sub nudEditorFeedingTables_ValueChanged(sender As Object, e As EventArgs) Handles nudEditorFeedingTables.ValueChanged
        Call LoadFeedingChart()
    End Sub

    Private Sub cboEditorPhotonBlast_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboEditorPhotonBlast.SelectedValueChanged
        strPathEditorPicPhotonBlast = Image.FromFile("./Graphics/PhotonBlast/" & cboEditorPhotonBlast.SelectedItem & ".png")
        picEditorPhotonBlast.Image = strPathEditorPicPhotonBlast

        Call EditorPhotonBlastXML()
    End Sub



#End Region

#Region "Mouse Click"

#Region "Menu Strip"

    Private Sub mnuEditorFileSaveMag_Click(sender As Object, e As EventArgs) Handles mnuEditorFileSaveMag.Click
        Call EditorMagSave()
    End Sub

    Private Sub mnuEditorFileSaveChart_Click(sender As Object, e As EventArgs) Handles mnuEditorFileSaveChart.Click
        Call EditorChartSave()
    End Sub

    Private Sub mnuEditorFileExit_Click(sender As Object, e As EventArgs) Handles mnuEditorFileExit.Click
        Me.Close()
    End Sub

#End Region

    Private Sub picEditorMag_Click(sender As Object, e As EventArgs) Handles picEditorMag.Click
        lsbEditorMag.Focus()
    End Sub

    Private Sub picEditorPhotonBlast_Click(sender As Object, e As EventArgs) Handles picEditorPhotonBlast.Click
        cboEditorPhotonBlast.Focus()
    End Sub


    Public Sub SearchMag()
        strEditorSearch = txtEditorSearchMag.Text
        ' Ensure we have a proper string to search for.
        If strEditorSearch <> String.Empty Then
            ' Find the item in the list and store the index to the item.
            Dim index As Integer = lsbEditorMag.FindString(strEditorSearch)
            ' Determine if a valid index is returned. Select the item if it is valid.
            If index <> -1 Then
                lsbEditorMag.SetSelected(index, True)

            End If
        End If
    End Sub



    Private Sub txtEditorSearchMag_TextChanged(sender As Object, e As EventArgs) Handles txtEditorSearchMag.TextChanged
        Call SearchMag()
    End Sub

    Private Sub txtEditorSearchMag_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEditorSearchMag.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
        Call SearchMag()
    End Sub

    Private Sub tabEditor_Click(sender As Object, e As EventArgs) Handles tabEditor.Click
        If tabEditor.SelectedIndex = 0 Then
            tabEditorMag.SelectedTab = tabEditorMagInfo
        End If
    End Sub

    Private Sub mnuEditorFileUpdate_Click(sender As Object, e As EventArgs) Handles mnuEditorFileUpdate.Click
        Call MagUpdate()
    End Sub

#End Region


End Class