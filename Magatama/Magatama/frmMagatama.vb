Imports System.Xml
Public Class frmMagatama

#Region "Variable"
    Dim XmlWriter As XmlWriter
    Dim XmlSettings As New XmlWriterSettings()

    Dim sdfSave As New SaveFileDialog()

    'Used to store the path of the files to Open.
    Dim strPathTmp As String

    'Version of PSO to load Mag from
    Public strGameVer As String = "Ep4"

    'Contain the Path to the Picture that should be shown
    Dim strPathPicClass As Image = My.Resources.ResourceManager.GetObject(0)
    Dim strPathPicClassBackground As Image = My.Resources.ResourceManager.GetObject(0)
    Dim strPathPicSectionID As Image = My.Resources.ResourceManager.GetObject(0)
    Dim strPathPicMag As Image = My.Resources.ResourceManager.GetObject(0)

    Dim strPathPicPhotonBlast01 As Image = My.Resources.ResourceManager.GetObject(0)
    Dim strPathPicPhotonBlast02 As Image = My.Resources.ResourceManager.GetObject(0)
    Dim strPathPicPhotonBlast03 As Image = My.Resources.ResourceManager.GetObject(0)

    'Name of the Current Photon Blast
    Dim strPhotonBlast01 As String = "PhotonBlast01"
    Dim strPhotonBlast02 As String = "PhotonBlast02"
    Dim strPhotonBlast03 As String = "PhotonBlast03"

    ' Description of the Current Photon Blast
    Dim strPhotonBlastText01 As String
    Dim strPhotonBlastText02 As String
    Dim strPhotonBlastText03 As String

    ' Serve to switch between Edit Mode and Standard Mode
    Dim blnEditMode As Boolean
    Dim blnEvolve As Boolean = True

    ' Variable for the time between feeding
    Dim shoFeedingTime As Short = 210

    Dim lngEstimatedTime As ULong = 0 'Keep the Estimated Time in Memory for operations
    Dim lngEstimatedCost As Long = 0 'keep the Estimated Cose in Memory for Operations

    ' Keep The Cost of Items in Memory
    Dim shoCostMonomate As Short = 50
    Dim shoCostDimate As Short = 300
    Dim shoCostTrimate As Short = 2000
    Dim shoCostMonofluid As Short = 100
    Dim shoCostDifluid As Short = 500
    Dim shoCostTrifluid As Short = 3600
    Dim shoCostAntidote As Short = 60
    Dim shoCostAntiparalysis As Short = 60
    Dim shoCostSolAtomizer As Short = 300
    Dim shoCostMoonAtomizer As Short = 500
    Dim shoCostStarAtomizer As Short = 5000

    Dim blnMagRacialRestriction As Boolean = True


    ' Keep in Memory of Used Items from Before the Mag Evolved, so the value can be reset in the Output Windows.
    Dim shoevoTmp As CallType
    Dim shoEvoCycle As Short = 0
    Dim shoEvoMonomate As Short = 0
    Dim shoEvoDimate As Short = 0
    Dim shoEvoTrimate As Short = 0
    Dim shoEvoMonofluid As Short = 0
    Dim shoEvoDifluid As Short = 0
    Dim shoEvoTrifluid As Short = 0
    Dim shoEvoAntidote As Short = 0
    Dim shoEvoAntiparalysis As Short = 0
    Dim shoEvoSolAtomizer As Short = 0
    Dim shoEvoMoonAtomizer As Short = 0
    Dim shoEvoStarAtomizer As Short = 0


    'Variable to determine if 3 items have been feed to the mag.
    Dim bytFeedingCount As Byte = 0

    Dim bytStage3 As Byte = 50
    Dim bytStage4 As Byte = 100

    Dim strTmp As String 'Used by the Feeding Process, The Mag Saving and the Export of the Output
    Dim strEvo As String 'Used by the Evolution process if it use the same as the feeding process is causes crashes
    Dim strEvoCND As String
    Dim strEvoCND2 As String

    ' nud uses to manipulate the appropriate nud when feeding a mag
    Dim nudQtyTmp As NumericUpDown 'Used to know which Quantity Column shoud be used when the Feeding function is called
    Dim nudHistoryTmp As NumericUpDown 'Used to know which History Column shoud be Incremented when the Feeding function is called
    Dim nudStats As NumericUpDown 'Used to know which Stats shoud be incremented when the Feeding function is called
    Dim nudProgressStats As NumericUpDown 'Used to know which Progress Stats shoud be incremented when the Feeding function is called
    Dim btnTmp As Button 'Used to get the text from the button and show it into the output.

    ' Variable USedfor Calculating the New Value When Feeding a Mag
    Dim shoProgress As Short = 0

    'Variable Used when Feeding Mag to see if the required number of Mass Feeding have been completed and also by some Mag Cell evolutions
    Dim shoCount As Short = 0


    Dim shoUndo As Short ' Variable used to count were we are in Redo
    Dim shoRedo As Short ' Variable used to count How far we can redo

    'Contain the Value of which Feeding Chart does the Mag use.
    Dim strFeedingChart = 0

    Dim bytMagCheck As String 'Check if the mag evolved

    'Variable used for populating the various ComboBox
    Dim shocboCount As Short
    Dim shocboCountMax As Short


    ' Strings Used for making translation easier to do.
    Dim strChangedClass As String = "Changed Class to "
    Dim strChangedSectionID As String = "Changed Section ID to "
    Dim strEvolvedMag As String = "Evolved into a "
    Dim strEvolvedMagRare As String = "Evolved into the Rare "
    Dim strMagCellUsed As String = " was Used"
    Dim strEvolveRare As String = "Your Mag is rare and can't no longer evolve "
    Dim strLevelUp As String = "--- Level UP ---"








#End Region

#Region "Public Sub"

    Public Sub cboMagList()

        shocboCount = 0
        shocboCountMax = 0
        cboMag.Items.Clear()

        Using XmlLoadMag As XmlReader = XmlReader.Create("./Data/List/Mag.xml")

            XmlLoadMag.ReadToFollowing("GameVersion")
            XmlLoadMag.MoveToAttribute(strGameVer)
            shocboCountMax = XmlLoadMag.Value

            While shocboCount < shocboCountMax

                XmlLoadMag.ReadToFollowing("Mag" & shocboCount)
                XmlLoadMag.MoveToFirstAttribute()
                cboMag.Items.Add(XmlLoadMag.Value)
                shocboCount = (shocboCount + 1)
            End While
            cboMag.SelectedIndex = 0
        End Using
    End Sub

    Public Sub cboMagCellList()

        shocboCount = 0
        shocboCountMax = 0
        cboMagCell.Items.Clear()

        Using XmlLoadMag As XmlReader = XmlReader.Create("./Data/List/MagCells.xml")

            XmlLoadMag.ReadToFollowing("GameVersion")
            XmlLoadMag.MoveToAttribute(strGameVer)
            shocboCountMax = XmlLoadMag.Value

            While shocboCount < shocboCountMax

                XmlLoadMag.ReadToFollowing("Cell" & shocboCount)
                XmlLoadMag.MoveToFirstAttribute()
                cboMagCell.Items.Add(XmlLoadMag.Value)
                shocboCount = (shocboCount + 1)
            End While
            cboMagCell.SelectedIndex = 0
        End Using
    End Sub

    Public Sub cboClassList()

        shocboCount = 0
        shocboCountMax = 0
        cboClass.Items.Clear()

        Using XmlLoadMag As XmlReader = XmlReader.Create("./Data/List/Class.xml")

            XmlLoadMag.ReadToFollowing("Class")
            XmlLoadMag.MoveToAttribute("Total")
            shocboCountMax = XmlLoadMag.Value

            While shocboCount < shocboCountMax

                XmlLoadMag.ReadToFollowing("Class" & shocboCount)
                XmlLoadMag.MoveToAttribute(strGameVer)
                strTmp = XmlLoadMag.Value


                If strTmp = "YES" Then
                    XmlLoadMag.MoveToAttribute("Name")
                    cboClass.Items.Add(XmlLoadMag.Value)
                End If

                shocboCount = (shocboCount + 1)
            End While

        End Using

        ' we don't use cboClass.SelectedIndex = 0 because we use the init to set the initial value 
    End Sub

    Public Sub cboSectionIdList()

        shocboCount = 0
        shocboCountMax = 0
        cboSectionID.Items.Clear()

        Using XmlLoadMag As XmlReader = XmlReader.Create("./Data/List/SectionID.xml")

            XmlLoadMag.ReadToFollowing("SectionID")
            XmlLoadMag.MoveToFirstAttribute()
            shocboCountMax = XmlLoadMag.Value

            While shocboCount < shocboCountMax

                XmlLoadMag.ReadToFollowing("ID" & shocboCount)
                XmlLoadMag.MoveToFirstAttribute()
                cboSectionID.Items.Add(XmlLoadMag.Value)
                shocboCount = (shocboCount + 1)
            End While

        End Using
        ' we don't use cboSectionID.SelectedIndex = 0 because we use the init to set the initial value 
    End Sub


    Public Sub Init()
        blnEditMode = True
        Using XmlLoadMag As XmlReader = XmlReader.Create("./Data/Init.xml")

            XmlLoadMag.ReadToFollowing("GameVersion")
            XmlLoadMag.MoveToFirstAttribute()
            strGameVer = XmlLoadMag.Value 'GameVersion
        End Using

        Call cboClassList()
        Call cboSectionIdList()
        Call cboMagList()

        Call LoadInit()

#Region "Reset NUD"

        'nudLevel.Value = 5
        nudProgressDEF.Value = 0
        nudProgressPOW.Value = 0
        nudProgressDEX.Value = 0
        nudProgressMIND.Value = 0

        nudHistoryMonomate.Value = 0
        nudHistoryDimate.Value = 0
        nudHistoryTrimate.Value = 0
        nudHistoryMonofluid.Value = 0
        nudHistoryDifluid.Value = 0
        nudHistoryTrifluid.Value = 0
        nudHistoryAntidote.Value = 0
        nudHistoryAntiparalysis.Value = 0
        nudHistorySolAtomizer.Value = 0
        nudHistoryMoonAtomizer.Value = 0
        nudHistoryStarAtomizer.Value = 0

        nudHistoryCostMonomate.Value = 0
        nudHistoryCostDimate.Value = 0
        nudHistoryCostTrimate.Value = 0
        nudHistoryCostMonofluid.Value = 0
        nudHistoryCostDifluid.Value = 0
        nudHistoryCostTrifluid.Value = 0
        nudHistoryCostAntidote.Value = 0
        nudHistoryCostAntiparalysis.Value = 0
        nudHistoryCostSolAtomizer.Value = 0
        nudHistoryCostMoonAtomizer.Value = 0
        nudHistoryCostStarAtomizer.Value = 0

        Call MagLevel() 'Calculated the Mag Level depending on it current Stats

#End Region


#Region "Photon Blast"
        With cboPhotonBlast01
            .Items.Clear()
            .Items.Add("None")
            .Items.Add("Farlla")
            .Items.Add("Estlla")
            .Items.Add("Leilla")
            .SelectedIndex = 0
        End With

        With cboPhotonBlast02
            .Items.Clear()
            .Items.Add("None")
            .Items.Add("Golla")
            .Items.Add("Pilla")
            .Items.Add("Mylla")
            .SelectedIndex = 0
        End With

        Call PhotonBlast03()
#End Region

        Call cboMagCellList()

        bytFeedingCount = 0
        lngEstimatedCost = 0
        lngEstimatedTime = 0

        picClass.Image = strPathPicClass
        picSectionID.Image = strPathPicSectionID

        mnuEditStat.Checked = False
        Call MagatamaTitle()
        sdfSave.FileName = ""

        lblCyclesCount.Text = 0

        Call Cost()
        Call ResetQty()
        Call PhotonBlastXML()

        strTmp = ""



        bytMagCheck = cboMag.SelectedIndex

        shoEvoCycle = 0
        shoEvoMonomate = 0
        shoEvoDimate = 0
        shoEvoTrimate = 0
        shoEvoMonofluid = 0
        shoEvoDifluid = 0
        shoEvoTrifluid = 0
        shoEvoAntidote = 0
        shoEvoAntiparalysis = 0
        shoEvoSolAtomizer = 0
        shoEvoMoonAtomizer = 0
        shoEvoStarAtomizer = 0

        shoUndo = 0
        shoRedo = 0


    End Sub

    Public Sub InitFinalize() 'This had to be separated so New Blank Mag Work

        rtfOutput.Text = ""
        rtfOutput.AppendText(strChangedClass & cboClass.SelectedItem & vbNewLine & Chr(13))
        rtfOutput.AppendText(strChangedSectionID & cboSectionID.SelectedItem & vbNewLine & Chr(13))

        Call Saved()
        If (Not System.IO.Directory.Exists("./Tmp/")) Then
            System.IO.Directory.CreateDirectory("./Tmp/")
        End If

        Call DeleteTemporaryFiles()
        Call UndoRedo()
    End Sub

    Public Sub MagatamaTitle()
        Me.Text = My.Settings.strSoft & " : Stage " & picMag.Tag & " " & cboMag.SelectedItem
    End Sub

    Public Sub Tooltips()

        With ttMagatama
            .SetToolTip(picClass, cboClass.SelectedItem)
            .SetToolTip(picSectionID, cboSectionID.SelectedItem)
            .SetToolTip(picMag, cboMag.SelectedItem)
        End With

    End Sub

    Public Sub ResetQty()
        nudQtyMonomate.Value = 0
        nudQtyDimate.Value = 0
        nudQtyTrimate.Value = 0
        nudQtyMonofluid.Value = 0
        nudQtyDifluid.Value = 0
        nudQtyTrifluid.Value = 0
        nudQtyAntidote.Value = 0
        nudQtyAntiparalysis.Value = 0
        nudQtySolAtomizer.Value = 0
        nudQtyMoonAtomizer.Value = 0
        nudQtyStarAtomizer.Value = 0
    End Sub

#Region "Photon Blast Public Sub"

    Public Sub PhotonBlast03()
        With cboPhotonBlast03
            .Items.Clear()
            .Items.Add("None")
            .Items.Add("Farlla")
            .Items.Add("Estlla")
            .Items.Add("Golla")
            .Items.Add("Pilla")
            .Items.Add("Mylla")
            .SelectedIndex = 0
        End With
    End Sub

    Public Sub PhotonBlastCheck()
        Call PhotonBlastCheck01()
        Call PhotonBlastCheck02()

        Call PhotonBlastXML()
        Call Unsaved()
    End Sub

    Public Sub PhotonBlastCheck01()
        Select Case cboPhotonBlast01.Text
            Case Is = "None"
                Call PhotonBlast03()
            Case Is = "Leilla"
                Call PhotonBlast03()
            Case Else
                Call PhotonBlast03()
                cboPhotonBlast03.SelectedIndex = 0
                cboPhotonBlast03.Items.Remove(cboPhotonBlast01.Text)
        End Select
    End Sub

    Public Sub PhotonBlastCheck02()
        Select Case cboPhotonBlast02.Text
            Case Is = "None"
                Call PhotonBlast03()
                Call PhotonBlastCheck01()
            Case Else
                Call PhotonBlast03()
                Call PhotonBlastCheck01()
                cboPhotonBlast03.SelectedIndex = 0
                cboPhotonBlast03.Items.Remove(cboPhotonBlast02.Text)
        End Select
    End Sub

    Public Sub PhotonBlastXML() 'PhotonBlast Tooltips Text

        strPhotonBlast01 = cboPhotonBlast01.Tag
        strPhotonBlast02 = cboPhotonBlast02.Tag
        strPhotonBlast03 = cboPhotonBlast03.Tag


        If cboPhotonBlast01.SelectedIndex = 0 Then
            strPhotonBlast01 = "PhotonBlast01"
        End If

        If cboPhotonBlast01.SelectedIndex = 0 Then
            strPhotonBlast01 = "PhotonBlast02"
        End If

        If cboPhotonBlast01.SelectedIndex = 0 Then
            strPhotonBlast01 = "PhotonBlast03"
        End If


        Using XmlLoadPhotonBlast As XmlReader = XmlReader.Create("./Data/PhotonBlast.xml")
            While (XmlLoadPhotonBlast.Read())
                Dim type = XmlLoadPhotonBlast.NodeType


                If (type = XmlNodeType.Element) Then

                    If (XmlLoadPhotonBlast.Name = strPhotonBlast01) Then
                        strPhotonBlastText01 = XmlLoadPhotonBlast.ReadInnerXml.ToString()
                    End If

                    If (XmlLoadPhotonBlast.Name = strPhotonBlast02) Then
                        strPhotonBlastText02 = XmlLoadPhotonBlast.ReadInnerXml.ToString()
                    End If

                    If (XmlLoadPhotonBlast.Name = strPhotonBlast03) Then
                        strPhotonBlastText03 = XmlLoadPhotonBlast.ReadInnerXml.ToString()
                    End If

                End If

            End While
        End Using

        If cboPhotonBlast01.SelectedIndex = 0 Then

        End If

        ttMagatama.SetToolTip(picPhotonBlast01, strPhotonBlastText01)
        ttMagatama.SetToolTip(picPhotonBlast02, strPhotonBlastText02)
        ttMagatama.SetToolTip(picPhotonBlast03, strPhotonBlastText03)

    End Sub

#End Region

#Region "Save"

    Public Sub SavePrompt()

        If picSave.Tag = "Unsaved" Then

            shoProgress = MessageBox.Show("You have some unsaved Change!" & Environment.NewLine & "Do you want to Save them ?", "Save", MessageBoxButtons.YesNo)
            If shoProgress = DialogResult.No Then
            ElseIf shoProgress = DialogResult.Yes Then

                If sdfSave.FileName.Length > 0 Then
                    Call MagSave()
                Else
                    Call MagSaveAs()
                End If
            End If

        End If
    End Sub

    Public Sub MagSave()
        XmlWriter = XmlWriter.Create(strPathTmp, XmlSettings)
        With XmlWriter

            ' Write the Xml declaration.
            .WriteStartDocument()
            .WriteStartElement("root")


            .WriteStartElement("Owner")
            .WriteAttributeString("Class_ID", cboClass.SelectedIndex)
            .WriteAttributeString("Class", cboClass.SelectedItem)
            .WriteAttributeString("SectionID_ID", cboSectionID.SelectedIndex)
            .WriteAttributeString("SectionID", cboSectionID.SelectedItem)
            .WriteEndElement()


            .WriteStartElement("Mag")
            .WriteAttributeString("ID", cboMag.SelectedIndex)
            .WriteAttributeString("Name", cboMag.SelectedItem)
            .WriteAttributeString("Level", nudLevel.Value.ToString)
            .WriteAttributeString("Synchro", nudSynchro.Value.ToString)
            .WriteAttributeString("IQ", nudIQ.Value.ToString)
            .WriteStartElement("NextLevel")
            .WriteAttributeString("Stage3", bytStage3)
            .WriteAttributeString("Stage4", bytStage4)

            .WriteEndElement()
            .WriteStartElement("Stats")
            .WriteAttributeString("DEF", nudDEF.Value.ToString)
            .WriteAttributeString("POW", nudPOW.Value.ToString)
            .WriteAttributeString("DEX", nudDEX.Value.ToString)
            .WriteAttributeString("MIND", nudMIND.Value.ToString)
            .WriteEndElement()
            .WriteStartElement("Progress")
            .WriteAttributeString("DEF", nudProgressDEF.Value.ToString)
            .WriteAttributeString("POW", nudProgressPOW.Value.ToString)
            .WriteAttributeString("DEX", nudProgressDEX.Value.ToString)
            .WriteAttributeString("MIND", nudProgressMIND.Value.ToString)
            .WriteEndElement()
            .WriteStartElement("PhotonBlast")
            .WriteAttributeString("Middle", cboPhotonBlast01.SelectedItem)
            .WriteAttributeString("Right", cboPhotonBlast02.SelectedItem)
            .WriteAttributeString("Left", cboPhotonBlast03.SelectedItem)
            .WriteEndElement()

            .WriteComment("History")
            .WriteStartElement("Cycle")
            .WriteAttributeString("Count", lblCyclesCount.Text)
            .WriteAttributeString("Feed", bytFeedingCount)
            .WriteAttributeString("Evo", shoevoCycle)
            .WriteEndElement()
            .WriteStartElement("Estimation")
            .WriteAttributeString("Time", lngEstimatedTime)
            .WriteAttributeString("Cost", lblCost.Text)
            .WriteEndElement()
            .WriteStartElement("Monomate")
            .WriteAttributeString("Qty", nudHistoryMonomate.Value.ToString)
            .WriteAttributeString("Evo", shoEvoMonomate)
            .WriteEndElement()
            .WriteStartElement("Dimate")
            .WriteAttributeString("Qty", nudHistoryDimate.Value.ToString)
            .WriteAttributeString("Evo", shoEvoDimate)
            .WriteEndElement()
            .WriteStartElement("Trimate")
            .WriteAttributeString("Qty", nudHistoryTrimate.Value.ToString)
            .WriteAttributeString("Evo", shoEvoTrimate)
            .WriteEndElement()
            .WriteStartElement("Monofluid")
            .WriteAttributeString("Qty", nudHistoryMonofluid.Value.ToString)
            .WriteAttributeString("Evo", shoEvoMonofluid)
            .WriteEndElement()
            .WriteStartElement("Difluid")
            .WriteAttributeString("Qty", nudHistoryDifluid.Value.ToString)
            .WriteAttributeString("Evo", shoEvoDifluid)
            .WriteEndElement()
            .WriteStartElement("Trifluid")
            .WriteAttributeString("Qty", nudHistoryTrifluid.Value.ToString)
            .WriteAttributeString("Evo", shoEvoTrifluid)
            .WriteEndElement()
            .WriteStartElement("Antidote")
            .WriteAttributeString("Qty", nudHistoryAntidote.Value.ToString)
            .WriteAttributeString("Evo", shoEvoAntidote)
            .WriteEndElement()
            .WriteStartElement("Antiparalysis")
            .WriteAttributeString("Qty", nudHistoryAntiparalysis.Value.ToString)
            .WriteAttributeString("Evo", shoEvoAntiparalysis)
            .WriteEndElement()
            .WriteStartElement("SolAtomizer")
            .WriteAttributeString("Qty", nudHistorySolAtomizer.Value.ToString)
            .WriteAttributeString("Evo", shoEvoSolAtomizer)
            .WriteEndElement()
            .WriteStartElement("MoonAtomizer")
            .WriteAttributeString("Qty", nudHistoryMoonAtomizer.Value.ToString)
            .WriteAttributeString("Evo", shoEvoMoonAtomizer)
            .WriteEndElement()
            .WriteStartElement("StarAtomizer")
            .WriteAttributeString("Qty", nudHistoryStarAtomizer.Value.ToString)
            .WriteAttributeString("Evo", shoEvoStarAtomizer)
            .WriteEndElement()
            .WriteComment("Log")
            .WriteElementString("Output", rtfOutput.Text)

            .WriteEndDocument()
            .Close()
        End With

    End Sub

    Public Sub MagSaveAs()
        sdfSave.DefaultExt = "*.mag"
        sdfSave.Filter = "Mag Files|*.mag"
        sdfSave.FileName = (cboClass.SelectedItem & "_" & cboSectionID.SelectedItem & "_Stage" & picMag.Tag & "_" & cboMag.SelectedItem)

        If (sdfSave.ShowDialog() = System.Windows.Forms.DialogResult.OK) _
            And (sdfSave.FileName.Length) > 0 Then
            strPathTmp = sdfSave.FileName
            Call MagSave()
        End If
    End Sub

    Public Sub ExportOutput()
        ' Create a SaveFileDialog to request a path and file name to save to.


        ' Initialize the SaveFileDialog to specify the RTF extension for the file.
        sdfSave.DefaultExt = "*.txt"
        sdfSave.Filter = "Text Files|*.txt"
        sdfSave.FileName = (cboClass.SelectedItem & "_" & cboSectionID.SelectedItem & "_Stage" & picMag.Tag & "_" & cboMag.SelectedItem & "_Output")

        ' Determine if the user selected a file name from the saveFileDialog.
        If (sdfSave.ShowDialog() = System.Windows.Forms.DialogResult.OK) _
            And (sdfSave.FileName.Length) > 0 Then

            strTmp = rtfOutput.Text
            rtfOutput.Clear()
            ' Save the contents of the RichTextBox into the file.
            rtfOutput.AppendText("Log of " & cboMag.SelectedItem & Chr(13) & Chr(13)) 'Add the name of the mag

            rtfOutput.AppendText(cboMag.SelectedItem & Chr(13) & lblLevel.Text & " : " & nudLevel.Value & Chr(13) & lblSynchro.Text & " : " & nudSynchro.Value &
                                 Chr(13) & lblIQ.Text & " : " & nudIQ.Value & Chr(13) & Chr(13))

            'Append the Stats to the Outputt
            rtfOutput.AppendText("DEF " & nudDEF.Value & "/" & nudProgressDEF.Value & " POW " & nudPOW.Value & "/" & nudProgressPOW.Value &
                              " DEX " & nudDEX.Value & "/" & nudProgressDEX.Value & " MIND " & nudMIND.Value & "/" & nudProgressMIND.Value & Chr(13) & Chr(13))
            'Append the Photon Blast
            rtfOutput.AppendText("Photon Blast :" & Chr(13) & cboPhotonBlast01.SelectedItem & Chr(13) & cboPhotonBlast02.SelectedItem _
                              & Chr(13) & cboPhotonBlast03.SelectedItem & Chr(13) & Chr(13))
            'Append the Time and Cost Estimation
            rtfOutput.AppendText("Estimated Time : " & lblTime.Text & " " & lblMinutes.Text & Chr(13) & "Estimated Cost : " & lblCost.Text & " " & lblMeseta.Text & Chr(13) & Chr(13))

            ' We finnaly append the text inside rtfOutput
            rtfOutput.AppendText("[                                          ]" & Chr(13) & Chr(13) & strTmp & Chr(13) & "[                                          ]")

            rtfOutput.SaveFile(sdfSave.FileName, RichTextBoxStreamType.PlainText)
            rtfOutput.Text = strTmp
        End If
    End Sub

#End Region

#Region "Load"

    Public Sub MagLoad()


        Using XmlLoadMag As XmlReader = XmlReader.Create(ofdMagatama.FileName)
            XmlLoadMag.ReadToFollowing("Owner")
            XmlLoadMag.MoveToAttribute("Class_ID")
            cboClass.SelectedIndex = XmlLoadMag.Value 'Class
            XmlLoadMag.MoveToAttribute("SectionID_ID")
            cboSectionID.SelectedIndex = XmlLoadMag.Value 'Section ID

            XmlLoadMag.ReadToFollowing("Mag")
            XmlLoadMag.MoveToAttribute("ID")
            cboMag.SelectedIndex = XmlLoadMag.Value 'Mag ID Number
            XmlLoadMag.MoveToAttribute("Synchro")
            nudSynchro.Value = XmlLoadMag.Value
            XmlLoadMag.MoveToAttribute("IQ")
            nudIQ.Value = XmlLoadMag.Value

            XmlLoadMag.ReadToFollowing("NextLevel")
            XmlLoadMag.MoveToAttribute("Stage3")
            bytStage3 = XmlLoadMag.Value 'Next Level 3 Level Up Opportunity
            XmlLoadMag.MoveToAttribute("Stage4")
            bytStage4 = XmlLoadMag.Value 'Next Level 4 Level Up Opportunity

            XmlLoadMag.ReadToFollowing("Stats")
            XmlLoadMag.MoveToFirstAttribute()
            nudDEF.Value = XmlLoadMag.Value
            XmlLoadMag.MoveToNextAttribute()
            nudPOW.Value = XmlLoadMag.Value
            XmlLoadMag.MoveToNextAttribute()
            nudDEX.Value = XmlLoadMag.Value
            XmlLoadMag.MoveToNextAttribute()
            nudMIND.Value = XmlLoadMag.Value

            XmlLoadMag.ReadToFollowing("Progress")
            XmlLoadMag.MoveToFirstAttribute()
            nudProgressDEF.Value = XmlLoadMag.Value
            XmlLoadMag.MoveToNextAttribute()
            nudProgressPOW.Value = XmlLoadMag.Value
            XmlLoadMag.MoveToNextAttribute()
            nudProgressDEX.Value = XmlLoadMag.Value
            XmlLoadMag.MoveToNextAttribute()
            nudProgressMIND.Value = XmlLoadMag.Value

            XmlLoadMag.ReadToFollowing("PhotonBlast")
            XmlLoadMag.MoveToFirstAttribute()
            cboPhotonBlast01.SelectedItem = XmlLoadMag.Value
            XmlLoadMag.MoveToNextAttribute()
            cboPhotonBlast02.SelectedItem = XmlLoadMag.Value
            XmlLoadMag.MoveToNextAttribute()
            cboPhotonBlast03.SelectedItem = XmlLoadMag.Value

            'History
            XmlLoadMag.ReadToFollowing("Cycle")
            XmlLoadMag.MoveToFirstAttribute()
            lblCyclesCount.Text = XmlLoadMag.Value
            XmlLoadMag.MoveToNextAttribute()
            bytFeedingCount = XmlLoadMag.Value
            XmlLoadMag.MoveToNextAttribute()
            shoevoCycle = XmlLoadMag.Value

            XmlLoadMag.ReadToFollowing("Monomate")
            XmlLoadMag.MoveToFirstAttribute()
            nudHistoryMonomate.Value = XmlLoadMag.Value
            XmlLoadMag.MoveToNextAttribute()
            shoEvoMonomate = XmlLoadMag.Value

            XmlLoadMag.ReadToFollowing("Dimate")
            XmlLoadMag.MoveToFirstAttribute()
            nudHistoryDimate.Value = XmlLoadMag.Value
            XmlLoadMag.MoveToNextAttribute()
            shoEvoDimate = XmlLoadMag.Value

            XmlLoadMag.ReadToFollowing("Trimate")
            XmlLoadMag.MoveToFirstAttribute()
            nudHistoryTrimate.Value = XmlLoadMag.Value
            XmlLoadMag.MoveToNextAttribute()
            shoEvoTrimate = XmlLoadMag.Value

            XmlLoadMag.ReadToFollowing("Monofluid")
            XmlLoadMag.MoveToFirstAttribute()
            nudHistoryMonofluid.Value = XmlLoadMag.Value
            XmlLoadMag.MoveToNextAttribute()
            shoEvoMonofluid = XmlLoadMag.Value

            XmlLoadMag.ReadToFollowing("Difluid")
            XmlLoadMag.MoveToFirstAttribute()
            nudHistoryDifluid.Value = XmlLoadMag.Value
            XmlLoadMag.MoveToNextAttribute()
            shoEvoDifluid = XmlLoadMag.Value

            XmlLoadMag.ReadToFollowing("Trifluid")
            XmlLoadMag.MoveToFirstAttribute()
            nudHistoryTrifluid.Value = XmlLoadMag.Value
            XmlLoadMag.MoveToNextAttribute()
            shoEvoTrifluid = XmlLoadMag.Value

            XmlLoadMag.ReadToFollowing("Antidote")
            XmlLoadMag.MoveToFirstAttribute()
            nudHistoryAntidote.Value = XmlLoadMag.Value
            XmlLoadMag.MoveToNextAttribute()
            shoEvoAntidote = XmlLoadMag.Value

            XmlLoadMag.ReadToFollowing("Antiparalysis")
            XmlLoadMag.MoveToFirstAttribute()
            nudHistoryAntiparalysis.Value = XmlLoadMag.Value
            XmlLoadMag.MoveToNextAttribute()
            shoEvoAntiparalysis = XmlLoadMag.Value

            XmlLoadMag.ReadToFollowing("SolAtomizer")
            XmlLoadMag.MoveToFirstAttribute()
            nudHistorySolAtomizer.Value = XmlLoadMag.Value
            XmlLoadMag.MoveToNextAttribute()
            shoEvoSolAtomizer = XmlLoadMag.Value

            XmlLoadMag.ReadToFollowing("MoonAtomizer")
            XmlLoadMag.MoveToFirstAttribute()
            nudHistoryMoonAtomizer.Value = XmlLoadMag.Value
            XmlLoadMag.MoveToNextAttribute()
            shoEvoMoonAtomizer = XmlLoadMag.Value

            XmlLoadMag.ReadToFollowing("StarAtomizer")
            XmlLoadMag.MoveToFirstAttribute()
            nudHistoryStarAtomizer.Value = XmlLoadMag.Value
            XmlLoadMag.MoveToNextAttribute()
            shoEvoStarAtomizer = XmlLoadMag.Value

            'Output

            XmlLoadMag.ReadToFollowing("Output")
            rtfOutput.Clear()
            rtfOutput.AppendText(XmlLoadMag.ReadInnerXml.ToString())
        End Using

        Call Cost()
    End Sub

    Public Sub LoadInit()

        Using XmlLoadMag As XmlReader = XmlReader.Create("./Data/Init.xml")

            XmlLoadMag.ReadToFollowing("Class")
            XmlLoadMag.MoveToAttribute(strGameVer)
            cboClass.SelectedIndex = XmlLoadMag.Value 'Class

            XmlLoadMag.ReadToFollowing("Default")
            XmlLoadMag.MoveToFirstAttribute()
            cboSectionID.SelectedIndex = XmlLoadMag.Value 'SectionID
            XmlLoadMag.MoveToAttribute("FeedingTime")
            shoFeedingTime = XmlLoadMag.Value 'Time between feeding cycle
            XmlLoadMag.MoveToAttribute("RacialRestriction")
            blnMagRacialRestriction = XmlLoadMag.Value 'Mag Racial Restriction

            XmlLoadMag.ReadToFollowing("Mag")
            XmlLoadMag.MoveToFirstAttribute() 'Max Level
            nudLevel.Maximum = XmlLoadMag.Value
            XmlLoadMag.MoveToNextAttribute() 'Synchro
            nudSynchro.Value = XmlLoadMag.Value
            XmlLoadMag.MoveToNextAttribute() 'IQ
            nudIQ.Value = XmlLoadMag.Value
            XmlLoadMag.MoveToNextAttribute() 'DEF
            nudDEF.Value = XmlLoadMag.Value
            XmlLoadMag.MoveToNextAttribute() 'POW
            nudPOW.Value = XmlLoadMag.Value
            XmlLoadMag.MoveToNextAttribute() 'DEX
            nudDEX.Value = XmlLoadMag.Value
            XmlLoadMag.MoveToNextAttribute() 'MIND
            nudMIND.Value = XmlLoadMag.Value


            XmlLoadMag.ReadToFollowing("Monomate")
            XmlLoadMag.MoveToFirstAttribute()
            shoCostMonomate = XmlLoadMag.Value
            XmlLoadMag.ReadToFollowing("Dimate")
            XmlLoadMag.MoveToFirstAttribute()
            shoCostDimate = XmlLoadMag.Value
            XmlLoadMag.ReadToFollowing("Trimate")
            XmlLoadMag.MoveToFirstAttribute()
            shoCostTrimate = XmlLoadMag.Value
            XmlLoadMag.ReadToFollowing("Monofluid")
            XmlLoadMag.MoveToFirstAttribute()
            shoCostMonofluid = XmlLoadMag.Value
            XmlLoadMag.ReadToFollowing("Difluid")
            XmlLoadMag.MoveToFirstAttribute()
            shoCostDifluid = XmlLoadMag.Value
            XmlLoadMag.ReadToFollowing("Trifluid")
            XmlLoadMag.MoveToFirstAttribute()
            shoCostTrifluid = XmlLoadMag.Value
            XmlLoadMag.ReadToFollowing("Antidote")
            XmlLoadMag.MoveToFirstAttribute()
            shoCostAntidote = XmlLoadMag.Value
            XmlLoadMag.ReadToFollowing("Antiparalysis")
            XmlLoadMag.MoveToFirstAttribute()
            shoCostAntiparalysis = XmlLoadMag.Value
            XmlLoadMag.ReadToFollowing("SolAtomizer")
            XmlLoadMag.MoveToFirstAttribute()
            shoCostSolAtomizer = XmlLoadMag.Value
            XmlLoadMag.ReadToFollowing("MoonAtomizer")
            XmlLoadMag.MoveToFirstAttribute()
            shoCostMoonAtomizer = XmlLoadMag.Value
            XmlLoadMag.ReadToFollowing("StarAtomizer")
            XmlLoadMag.MoveToFirstAttribute()
            shoCostStarAtomizer = XmlLoadMag.Value
        End Using
    End Sub

    Public Sub LoadTheme()

        Using XmlLoadMag As XmlReader = XmlReader.Create("./Data/Theme.xml")
            XmlLoadMag.ReadToFollowing("Level")
            XmlLoadMag.MoveToFirstAttribute()
            lblLevel.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            lblLevel.ForeColor = Color.FromName(strTmp)
            XmlLoadMag.ReadToFollowing("Synchro")
            XmlLoadMag.MoveToFirstAttribute()
            lblSynchro.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            lblSynchro.ForeColor = Color.FromName(strTmp)
            XmlLoadMag.ReadToFollowing("IQ")
            XmlLoadMag.MoveToFirstAttribute()
            lblIQ.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            lblIQ.ForeColor = Color.FromName(strTmp)


            XmlLoadMag.ReadToFollowing("DEF")
            XmlLoadMag.MoveToFirstAttribute()
            lblDEF.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            lblDEF.ForeColor = Color.FromName(strTmp)
            XmlLoadMag.MoveToAttribute("tt") 'Tooltips
            ttMagatama.SetToolTip(lblDEF, XmlLoadMag.Value)

            XmlLoadMag.ReadToFollowing("POW")
            XmlLoadMag.MoveToFirstAttribute()
            lblPOW.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            lblPOW.ForeColor = Color.FromName(strTmp)
            XmlLoadMag.MoveToAttribute("tt") 'Tooltips
            ttMagatama.SetToolTip(lblPOW, XmlLoadMag.Value)

            XmlLoadMag.ReadToFollowing("DEX")
            XmlLoadMag.MoveToFirstAttribute()
            lblDEX.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            lblDEX.ForeColor = Color.FromName(strTmp)
            XmlLoadMag.MoveToAttribute("tt") 'Tooltips
            ttMagatama.SetToolTip(lblDEX, XmlLoadMag.Value)

            XmlLoadMag.ReadToFollowing("MIND")
            XmlLoadMag.MoveToFirstAttribute()
            lblMIND.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            lblMIND.ForeColor = Color.FromName(strTmp)
            XmlLoadMag.MoveToAttribute("tt") 'Tooltips
            ttMagatama.SetToolTip(lblMIND, XmlLoadMag.Value)

            XmlLoadMag.ReadToFollowing("PBFull")
            XmlLoadMag.MoveToFirstAttribute()
            lblPBFilled.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            lblPBFilled.ForeColor = Color.FromName(strTmp)
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            lblPBFilledText.ForeColor = Color.FromName(strTmp) ' color2
            XmlLoadMag.ReadToFollowing("LowHP")
            XmlLoadMag.MoveToFirstAttribute()
            lbl1HP10.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            lbl1HP10.ForeColor = Color.FromName(strTmp)
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            lbl1HP10Text.ForeColor = Color.FromName(strTmp) ' color2
            XmlLoadMag.ReadToFollowing("Boss")
            XmlLoadMag.MoveToFirstAttribute()
            lblBoss.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            lblBoss.ForeColor = Color.FromName(strTmp)
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            lblBossText.ForeColor = Color.FromName(strTmp) ' color2
            XmlLoadMag.ReadToFollowing("Death")
            XmlLoadMag.MoveToFirstAttribute()
            lblDeath.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            lblDeath.ForeColor = Color.FromName(strTmp)
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            lblDeathText.ForeColor = Color.FromName(strTmp) ' color2
            XmlLoadMag.ReadToFollowing("Activation")
            XmlLoadMag.MoveToFirstAttribute()
            lblActivation.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            lblActivation.ForeColor = Color.FromName(strTmp)
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            lblActivationPercent.ForeColor = Color.FromName(strTmp) ' color2

            XmlLoadMag.ReadToFollowing("Items")
            XmlLoadMag.MoveToFirstAttribute()
            lblItems.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            lblItems.ForeColor = Color.FromName(strTmp)
            XmlLoadMag.ReadToFollowing("Qty")
            XmlLoadMag.MoveToFirstAttribute()
            lblQTY.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            lblQTY.ForeColor = Color.FromName(strTmp)
            XmlLoadMag.ReadToFollowing("History")
            XmlLoadMag.MoveToFirstAttribute()
            lblHistory.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            lblHistory.ForeColor = Color.FromName(strTmp)
            XmlLoadMag.ReadToFollowing("TotalCost")
            XmlLoadMag.MoveToFirstAttribute()
            lblHistoryCost.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            lblHistoryCost.ForeColor = Color.FromName(strTmp)

            XmlLoadMag.ReadToFollowing("Output")
            XmlLoadMag.MoveToFirstAttribute()
            lblOutput.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            lblOutput.ForeColor = Color.FromName(strTmp)
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            rtfOutput.BackColor = Color.FromName(strTmp)
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            rtfOutput.ForeColor = Color.FromName(strTmp)


            XmlLoadMag.ReadToFollowing("FeedingCycles")
            XmlLoadMag.MoveToFirstAttribute()
            lblCycles.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            lblCycles.ForeColor = Color.FromName(strTmp)
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            lblCyclesCount.ForeColor = Color.FromName(strTmp)


            XmlLoadMag.ReadToFollowing("Minutes")
            XmlLoadMag.MoveToFirstAttribute()
            lblMinutes.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            lblMinutes.ForeColor = Color.FromName(strTmp)
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            lblTime.ForeColor = Color.FromName(strTmp)

            XmlLoadMag.ReadToFollowing("Meseta")
            XmlLoadMag.MoveToFirstAttribute()
            lblMeseta.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            lblMeseta.ForeColor = Color.FromName(strTmp)
            XmlLoadMag.MoveToNextAttribute()
            strTmp = XmlLoadMag.Value 'Color
            lblCost.ForeColor = Color.FromName(strTmp)

            ' Only Edit the translation strings

            XmlLoadMag.ReadToFollowing("ChangedClass")
            XmlLoadMag.MoveToFirstAttribute()
            strChangedClass = XmlLoadMag.Value 'Text

            XmlLoadMag.ReadToFollowing("ChangedSectionID")
            XmlLoadMag.MoveToFirstAttribute()
            strChangedSectionID = XmlLoadMag.Value 'Text

            XmlLoadMag.ReadToFollowing("EvolveMag")
            XmlLoadMag.MoveToFirstAttribute()
            strEvolvedMag = XmlLoadMag.Value 'Text

            XmlLoadMag.ReadToFollowing("EvolveMagRare")
            XmlLoadMag.MoveToFirstAttribute()
            strEvolvedMagRare = XmlLoadMag.Value 'Text

            XmlLoadMag.ReadToFollowing("MagCellUsed")
            XmlLoadMag.MoveToFirstAttribute()
            strMagCellUsed = XmlLoadMag.Value 'Text

            XmlLoadMag.ReadToFollowing("EvolveRare")
            XmlLoadMag.MoveToFirstAttribute()
            strEvolveRare = XmlLoadMag.Value 'Text



            XmlLoadMag.ReadToFollowing("Space")
            XmlLoadMag.MoveToFirstAttribute()
            btnOutputSpace.Text = XmlLoadMag.Value 'Text

            XmlLoadMag.ReadToFollowing("MassFeed")
            XmlLoadMag.MoveToFirstAttribute()
            btnFeedAll.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToNextAttribute() 'Tooltips
            ttMagatama.SetToolTip(btnFeedAll, XmlLoadMag.Value)

            XmlLoadMag.ReadToFollowing("Feed")
            XmlLoadMag.MoveToFirstAttribute()
            btnMagCell.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToNextAttribute() 'Tooltips
            ttMagatama.SetToolTip(btnMagCell, XmlLoadMag.Value)


            XmlLoadMag.ReadToFollowing("Monomate")
            XmlLoadMag.MoveToFirstAttribute()
            btnMonomate.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToAttribute("tt") 'Tooltips
            ttMagatama.SetToolTip(nudQtyMonomate, XmlLoadMag.Value)

            XmlLoadMag.ReadToFollowing("Dimate")
            XmlLoadMag.MoveToFirstAttribute()
            btnDimate.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToAttribute("tt") 'Tooltips
            ttMagatama.SetToolTip(nudQtyDimate, XmlLoadMag.Value)

            XmlLoadMag.ReadToFollowing("Trimate")
            XmlLoadMag.MoveToFirstAttribute()
            btnTrimate.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToAttribute("tt") 'Tooltips
            ttMagatama.SetToolTip(nudQtyTrimate, XmlLoadMag.Value)

            XmlLoadMag.ReadToFollowing("Monofluid")
            XmlLoadMag.MoveToFirstAttribute()
            btnMonofluid.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToAttribute("tt") 'Tooltips
            ttMagatama.SetToolTip(nudQtyMonofluid, XmlLoadMag.Value)

            XmlLoadMag.ReadToFollowing("Difluid")
            XmlLoadMag.MoveToFirstAttribute()
            btnDifluid.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToAttribute("tt") 'Tooltips
            ttMagatama.SetToolTip(nudQtyDifluid, XmlLoadMag.Value)

            XmlLoadMag.ReadToFollowing("Trifluid")
            XmlLoadMag.MoveToFirstAttribute()
            btnTrifluid.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToAttribute("tt") 'Tooltips
            ttMagatama.SetToolTip(nudQtyTrifluid, XmlLoadMag.Value)

            XmlLoadMag.ReadToFollowing("Antidote")
            XmlLoadMag.MoveToFirstAttribute()
            btnAntidote.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToAttribute("tt") 'Tooltips
            ttMagatama.SetToolTip(nudQtyAntidote, XmlLoadMag.Value)

            XmlLoadMag.ReadToFollowing("Antiparalysis")
            XmlLoadMag.MoveToFirstAttribute()
            btnAntiparalysis.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToAttribute("tt") 'Tooltips
            ttMagatama.SetToolTip(nudQtyAntiparalysis, XmlLoadMag.Value)

            XmlLoadMag.ReadToFollowing("SolAtomizer")
            XmlLoadMag.MoveToFirstAttribute()
            btnSolAtomizer.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToAttribute("tt") 'Tooltips
            ttMagatama.SetToolTip(nudQtySolAtomizer, XmlLoadMag.Value)

            XmlLoadMag.ReadToFollowing("MoonAtomizer")
            XmlLoadMag.MoveToFirstAttribute()
            btnMoonAtomizer.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToAttribute("tt") 'Tooltips
            ttMagatama.SetToolTip(nudQtyMoonAtomizer, XmlLoadMag.Value)

            XmlLoadMag.ReadToFollowing("StarAtomizer")
            XmlLoadMag.MoveToFirstAttribute()
            btnStarAtomizer.Text = XmlLoadMag.Value 'Text
            XmlLoadMag.MoveToAttribute("tt") 'Tooltips
            ttMagatama.SetToolTip(nudQtyStarAtomizer, XmlLoadMag.Value)

        End Using
    End Sub


#End Region

    Public Sub EditMode()
        blnEditMode = mnuEditStat.Checked

        cboMag.Enabled = blnEditMode
        'nudLevel.Enabled = blnEditMode
        nudSynchro.Enabled = blnEditMode
        nudIQ.Enabled = blnEditMode
        nudDEF.Enabled = blnEditMode
        nudPOW.Enabled = blnEditMode
        nudDEX.Enabled = blnEditMode
        nudMIND.Enabled = blnEditMode
        nudProgressDEF.Enabled = blnEditMode
        nudProgressPOW.Enabled = blnEditMode
        nudProgressDEX.Enabled = blnEditMode
        nudProgressMIND.Enabled = blnEditMode
        cboPhotonBlast01.Enabled = blnEditMode
        cboPhotonBlast02.Enabled = blnEditMode
        cboPhotonBlast03.Enabled = blnEditMode

        nudHistoryMonomate.Enabled = blnEditMode
        nudHistoryDimate.Enabled = blnEditMode
        nudHistoryTrimate.Enabled = blnEditMode
        nudHistoryMonofluid.Enabled = blnEditMode
        nudHistoryDifluid.Enabled = blnEditMode
        nudHistoryTrifluid.Enabled = blnEditMode
        nudHistoryAntidote.Enabled = blnEditMode
        nudHistoryAntiparalysis.Enabled = blnEditMode
        nudHistorySolAtomizer.Enabled = blnEditMode
        nudHistoryMoonAtomizer.Enabled = blnEditMode
        nudHistoryStarAtomizer.Enabled = blnEditMode

        If mnuEditStat.Checked = False Then
            rtfOutput.AppendText(vbNewLine & "[---------------------]" & vbNewLine & "Set Stats" & vbNewLine & "Set Mag to " & cboMag.SelectedItem & vbNewLine & "Set Class to " &
                                 cboClass.SelectedItem & vbNewLine & "Set Section ID to " & cboSectionID.SelectedItem & vbNewLine &
                                 lblLevel.Text & " " & nudLevel.Value & vbNewLine &
                                 lblSynchro.Text & " " & nudSynchro.Value & vbNewLine &
                                 lblIQ.Text & " " & nudIQ.Value & vbNewLine &
                                 lblDEF.Text & " " & nudDEF.Value & "/" & nudProgressDEF.Value & vbNewLine &
                                 lblPOW.Text & " " & nudPOW.Value & "/" & nudProgressPOW.Value & vbNewLine &
                                 lblDEX.Text & " " & nudDEX.Value & "/" & nudProgressDEX.Value & vbNewLine &
                                 lblMIND.Text & " " & nudMIND.Value & "/" & nudProgressMIND.Value & vbNewLine &
                                 cboPhotonBlast01.SelectedItem & vbNewLine & cboPhotonBlast02.SelectedItem & vbNewLine &
                                 cboPhotonBlast03.SelectedItem & vbNewLine & "[---------------------]" & vbNewLine & vbNewLine)
        End If

    End Sub

    Public Sub Unsaved()
        picSave.Image = Image.FromFile("./Graphics/Theme/unsaved.png")
        picSave.Tag = "Unsaved"
    End Sub

    Public Sub UndoRedo()
        strPathTmp = ("./Tmp/" & shoUndo & ".mag")
        shoUndo = (shoUndo + 1)
        shoRedo = shoUndo
        Call MagSave()
    End Sub

    Public Sub Saved()
        picSave.Image = Image.FromFile("./Graphics/Theme/saved.png")
        picSave.Tag = "Saved"
    End Sub

    Public Sub MagLevel()
        nudLevel.Value = nudDEF.Value + nudPOW.Value + nudDEX.Value + nudMIND.Value
        nudDEF.Maximum = nudDEF.Value + (200 - nudLevel.Value)
        nudPOW.Maximum = nudPOW.Value + (200 - nudLevel.Value)
        nudDEX.Maximum = nudDEX.Value + (200 - nudLevel.Value)
        nudMIND.Maximum = nudMIND.Value + (200 - nudLevel.Value)
        Call Unsaved()
    End Sub

    Public Sub DeleteTemporaryFiles() 'It delete all the files made for the undo redo function
        For Each foundFile As String In My.Computer.FileSystem.GetFiles("./Tmp",
        Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, "*.*")
            My.Computer.FileSystem.DeleteFile(foundFile)
        Next
    End Sub

#End Region

#Region "Main"

    Private Sub frmMagatama_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.Icon = New Icon("./Graphics/Theme/icon.ico")
        Me.BackgroundImage = Image.FromFile("./Graphics/Theme/bg.png")
        Call EditMode()
        XmlSettings.Indent = True
        XmlSettings.IndentChars = (ControlChars.Tab)
        Call LoadTheme()
        Call Init()
        Call InitFinalize()

    End Sub

    Private Sub frmMagatama_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Call SavePrompt()
        Call DeleteTemporaryFiles()
    End Sub

#Region "Tooltips"

    Private Sub picClass_MouseHover(sender As Object, e As EventArgs) Handles picClass.MouseHover
        Call Tooltips()
    End Sub

    Private Sub picPhotonBlast01_MouseHover(sender As Object, e As EventArgs) Handles picPhotonBlast01.MouseHover
        Call PhotonBlastXML()
    End Sub

    Private Sub picPhotonBlast02_MouseHover(sender As Object, e As EventArgs) Handles picPhotonBlast02.MouseHover
        Call PhotonBlastXML()
    End Sub

    Private Sub picPhotonBlast03_MouseHover(sender As Object, e As EventArgs) Handles picPhotonBlast03.MouseHover
        Call PhotonBlastXML()
    End Sub


#End Region

#Region "Value Change"

#Region "Nud"

#Region "Mag"

    Private Sub nudLevel_ValueChanged(sender As Object, e As EventArgs) Handles nudLevel.ValueChanged

        If mnuEditStat.Checked = False Then

            If nudLevel.Value > bytStage3 Then
                bytStage3 = (bytStage3 + 5)
            End If

            If nudLevel.Value > bytStage4 Then
                bytStage4 = (bytStage4 + 10)
            End If

            rtfOutput.AppendText(strLevelUp & " (" & nudLevel.Value & ")" & vbNewLine)

        Else

            While bytStage3 > nudLevel.Value
                bytStage3 = bytStage3 - 5
            End While

            While bytStage4 > nudLevel.Value
                bytStage4 = bytStage4 - 10
            End While

            While bytStage3 < nudLevel.Value
                bytStage3 = bytStage3 + 5
            End While

            While bytStage4 < nudLevel.Value
                bytStage4 = bytStage4 + 10
            End While

        End If

        If nudLevel.Value < 50 Then
            bytStage3 = 50

        End If

        If nudLevel.Value < 100 Then
            bytStage4 = 100
        End If

        Call Unsaved()
    End Sub

    Private Sub nudSynchro_ValueChanged(sender As Object, e As EventArgs) Handles nudSynchro.ValueChanged
        Call Unsaved()
    End Sub

    Private Sub nudIQ_ValueChanged(sender As Object, e As EventArgs) Handles nudIQ.ValueChanged
        Call Unsaved()
    End Sub

    Private Sub nudDEF_ValueChanged(sender As Object, e As EventArgs) Handles nudDEF.ValueChanged
        Call MagLevel()
    End Sub

    Private Sub nudPOW_ValueChanged(sender As Object, e As EventArgs) Handles nudPOW.ValueChanged
        Call MagLevel()
    End Sub

    Private Sub nudDEX_ValueChanged(sender As Object, e As EventArgs) Handles nudDEX.ValueChanged
        Call MagLevel()
    End Sub

    Private Sub nudMIND_ValueChanged(sender As Object, e As EventArgs) Handles nudMIND.ValueChanged
        Call MagLevel()
    End Sub

#End Region

#Region "History"

    Private Sub nudHistoryMonomate_ValueChanged(sender As Object, e As EventArgs) Handles nudHistoryMonomate.ValueChanged
        nudHistoryCostMonomate.Value = (nudHistoryMonomate.Value * shoCostMonomate)
        Call Cost()
        Call Unsaved()
    End Sub

    Private Sub nudHistoryDimate_ValueChanged(sender As Object, e As EventArgs) Handles nudHistoryDimate.ValueChanged
        nudHistoryCostDimate.Value = (nudHistoryDimate.Value * shoCostDimate)
        Call Cost()
        Call Unsaved()
    End Sub

    Private Sub nudHistoryTrimate_ValueChanged(sender As Object, e As EventArgs) Handles nudHistoryTrimate.ValueChanged
        nudHistoryCostTrimate.Value = (nudHistoryTrimate.Value * shoCostTrimate)
        Call Cost()
        Call Unsaved()
    End Sub

    Private Sub nudHistoryMonofluid_ValueChanged(sender As Object, e As EventArgs) Handles nudHistoryMonofluid.ValueChanged
        nudHistoryCostMonofluid.Value = (nudHistoryMonofluid.Value * shoCostMonofluid)
        Call Cost()
        Call Unsaved()
    End Sub

    Private Sub nudHistoryDifluid_ValueChanged(sender As Object, e As EventArgs) Handles nudHistoryDifluid.ValueChanged
        nudHistoryCostDifluid.Value = (nudHistoryDifluid.Value * shoCostDifluid)
        Call Cost()
        Call Unsaved()
    End Sub

    Private Sub nudHistoryTrifluid_ValueChanged(sender As Object, e As EventArgs) Handles nudHistoryTrifluid.ValueChanged
        nudHistoryCostTrifluid.Value = (nudHistoryTrifluid.Value * shoCostTrifluid)
        Call Cost()
        Call Unsaved()
    End Sub

    Private Sub nudHistoryAntidote_ValueChanged(sender As Object, e As EventArgs) Handles nudHistoryAntidote.ValueChanged
        nudHistoryCostAntidote.Value = (nudHistoryAntidote.Value * shoCostAntidote)
        Call Cost()
        Call Unsaved()
    End Sub

    Private Sub nudHistoryAntiparalysis_ValueChanged(sender As Object, e As EventArgs) Handles nudHistoryAntiparalysis.ValueChanged
        nudHistoryCostAntiparalysis.Value = (nudHistoryAntiparalysis.Value * shoCostAntiparalysis)
        Call Cost()
        Call Unsaved()
    End Sub

    Private Sub nudHistorySolAtomizer_ValueChanged(sender As Object, e As EventArgs) Handles nudHistorySolAtomizer.ValueChanged
        nudHistoryCostSolAtomizer.Value = (nudHistorySolAtomizer.Value * shoCostSolAtomizer)
        Call Cost()
        Call Unsaved()
    End Sub

    Private Sub nudHistoryMoonAtomizer_ValueChanged(sender As Object, e As EventArgs) Handles nudHistoryMoonAtomizer.ValueChanged
        nudHistoryCostMoonAtomizer.Value = (nudHistoryMoonAtomizer.Value * shoCostMoonAtomizer)
        Call Cost()
        Call Unsaved()
    End Sub

    Private Sub nudHistoryStarAtomizer_ValueChanged(sender As Object, e As EventArgs) Handles nudHistoryStarAtomizer.ValueChanged
        nudHistoryCostStarAtomizer.Value = (nudHistoryStarAtomizer.Value * shoCostStarAtomizer)
        Call Cost()
        Call Unsaved()
    End Sub

#End Region


#End Region

#Region "Progress Bar"

    Private Sub nudProgressDEF_ValueChanged(sender As Object, e As EventArgs) Handles nudProgressDEF.ValueChanged
        prgDEF.Value = nudProgressDEF.Value
        Call Unsaved()
    End Sub

    Private Sub nudProgressPow_ValueChanged(sender As Object, e As EventArgs) Handles nudProgressPOW.ValueChanged
        prgPOW.Value = nudProgressPOW.Value
        Call Unsaved()
    End Sub
    Private Sub nudProgressDEX_ValueChanged(sender As Object, e As EventArgs) Handles nudProgressDEX.ValueChanged
        prgDEX.Value = nudProgressDEX.Value
        Call Unsaved()
    End Sub

    Private Sub nudProgressMIND_ValueChanged(sender As Object, e As EventArgs) Handles nudProgressMIND.ValueChanged
        prgMind.Value = nudProgressMIND.Value
        Call Unsaved()
    End Sub

#End Region

#Region "ComboBox"

    Private Sub cboClass_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboClass.SelectedValueChanged
        strPathPicClass = Image.FromFile("./Graphics/Class/" & cboClass.SelectedItem & ".png")
        strPathPicClassBackground = Image.FromFile("./Graphics/Class/" & cboClass.SelectedItem.Substring(0, 2) & ".png")
        With picClass
            .Image = strPathPicClass
            .BackgroundImage = strPathPicClassBackground
        End With
        Call Tooltips()
        If blnEditMode = False Then
            rtfOutput.AppendText(strChangedClass & cboClass.SelectedItem & vbNewLine & Chr(13))
        End If
        Call Unsaved()
    End Sub

    Private Sub cboSectionID_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboSectionID.SelectedValueChanged
        strPathPicSectionID = Image.FromFile("./Graphics/SectionID/" & cboSectionID.SelectedItem & ".png")
        picSectionID.Image = strPathPicSectionID
        Call Tooltips()

        If blnEditMode = False Then
            rtfOutput.AppendText(strChangedSectionID & cboSectionID.SelectedItem & vbNewLine & Chr(13))
        End If
        Call Unsaved()
    End Sub

    Private Sub cboMag_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboMag.SelectedValueChanged
        strPathPicMag = Image.FromFile("./Graphics/Mag/" & cboMag.SelectedIndex & ".png")
        picMag.Image = strPathPicMag

        Using XmlLoadMag As XmlReader = XmlReader.Create("./Data/Mag/" & cboMag.SelectedIndex & ".xml")

            XmlLoadMag.ReadToFollowing("Mag")
            XmlLoadMag.MoveToAttribute("Stage")
            picMag.Tag = XmlLoadMag.Value

            XmlLoadMag.ReadToFollowing("Table")
            XmlLoadMag.MoveToFirstAttribute()
            strFeedingChart = XmlLoadMag.Value

            XmlLoadMag.ReadToFollowing("Activation")
            XmlLoadMag.MoveToFirstAttribute()
            lblActivationPercent.Text = XmlLoadMag.Value

            XmlLoadMag.ReadToFollowing("PB_Filled")
            XmlLoadMag.MoveToFirstAttribute()
            Using XmlLoadTrigger As XmlReader = XmlReader.Create("./Data/List/ActivationTrigger.xml")
                XmlLoadTrigger.ReadToFollowing("AT" & XmlLoadMag.Value)
                XmlLoadTrigger.MoveToFirstAttribute()
                lblPBFilledText.Text = XmlLoadTrigger.Value
            End Using

            XmlLoadMag.ReadToFollowing("LowHP")
            XmlLoadMag.MoveToFirstAttribute()
            Using XmlLoadTrigger As XmlReader = XmlReader.Create("./Data/List/ActivationTrigger.xml")
                XmlLoadTrigger.ReadToFollowing("AT" & XmlLoadMag.Value)
                XmlLoadTrigger.MoveToFirstAttribute()
                lbl1HP10Text.Text = XmlLoadTrigger.Value
            End Using

            XmlLoadMag.ReadToFollowing("Boss")
            XmlLoadMag.MoveToFirstAttribute()
            Using XmlLoadTrigger As XmlReader = XmlReader.Create("./Data/List/ActivationTrigger.xml")
                XmlLoadTrigger.ReadToFollowing("AT" & XmlLoadMag.Value)
                XmlLoadTrigger.MoveToFirstAttribute()
                lblBossText.Text = XmlLoadTrigger.Value
            End Using

            XmlLoadMag.ReadToFollowing("Death")
            XmlLoadMag.MoveToFirstAttribute()
            Using XmlLoadTrigger As XmlReader = XmlReader.Create("./Data/List/ActivationTrigger.xml")
                XmlLoadTrigger.ReadToFollowing("AT" & XmlLoadMag.Value)
                XmlLoadTrigger.MoveToFirstAttribute()
                lblDeathText.Text = XmlLoadTrigger.Value
            End Using

        End Using

            If mnuEditStat.Checked = False Then

            If cboMag.SelectedItem = "Mag" Then

            Else
                rtfOutput.AppendText(vbNewLine & strEvolvedMag & cboMag.SelectedItem & vbNewLine & Chr(13))
            End If
        End If



        Call MagatamaTitle()
        Call Tooltips()
        Call Unsaved()

    End Sub

#End Region

#Region "Photon Blast"

    Private Sub cboPhotonBlast01_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboPhotonBlast01.SelectedValueChanged
        strPathPicPhotonBlast01 = Image.FromFile("./Graphics/PhotonBlast/" & cboPhotonBlast01.SelectedItem & ".png")
        picPhotonBlast01.Image = strPathPicPhotonBlast01
        Call PhotonBlastCheck()

    End Sub

    Private Sub cboPhotonBlast02_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboPhotonBlast02.SelectedValueChanged
        strPathPicPhotonBlast02 = Image.FromFile("./Graphics/PhotonBlast/" & cboPhotonBlast02.SelectedItem & ".png")
        picPhotonBlast02.Image = strPathPicPhotonBlast02
        Call PhotonBlastCheck()
    End Sub

    Private Sub cboPhotonBlast03_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboPhotonBlast03.SelectedValueChanged

        ' Redundancy check for PhotonBlast.
        Select Case cboPhotonBlast03.Text
            Case Is = cboPhotonBlast01.Text
                If cboPhotonBlast03.Text = "None" Then

                Else
                    MsgBox("Invalid Selection")
                    cboPhotonBlast03.SelectedIndex = 0
                End If

            Case Is = cboPhotonBlast02.Text
                If cboPhotonBlast03.Text = "None" Then

                Else
                    MsgBox("Invalid Selection")
                    cboPhotonBlast03.SelectedIndex = 0
                End If

            Case Else

        End Select
        strPathPicPhotonBlast03 = Image.FromFile("./Graphics/PhotonBlast/" & cboPhotonBlast03.SelectedItem & ".png")
        picPhotonBlast03.Image = strPathPicPhotonBlast03

        Call PhotonBlastXML()
        Call Unsaved()
    End Sub

#End Region

#End Region

#Region "Remove System Sound when Enter is pressed by suppressing the key press and for the Quantity it perform a click on the appropriate buttons"

#Region "Combo Box"

    Private Sub cboClass_KeyDown(sender As Object, e As KeyEventArgs) Handles cboClass.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub cboSectionID_KeyDown(sender As Object, e As KeyEventArgs) Handles cboSectionID.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub cboMag_KeyDown(sender As Object, e As KeyEventArgs) Handles cboMag.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub cboPhotonBlast01_KeyDown(sender As Object, e As KeyEventArgs) Handles cboPhotonBlast01.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub cboPhotonBlast02_KeyDown(sender As Object, e As KeyEventArgs) Handles cboPhotonBlast02.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub cboPhotonBlast03_KeyDown(sender As Object, e As KeyEventArgs) Handles cboPhotonBlast03.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub cboMagCell_KeyDown(sender As Object, e As KeyEventArgs) Handles cboMagCell.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

#End Region

#Region "nud Stats"

    Private Sub nudSynchro_KeyDown(sender As Object, e As KeyEventArgs) Handles nudSynchro.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub nudIQ_KeyDown(sender As Object, e As KeyEventArgs) Handles nudIQ.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub nudDEF_KeyDown(sender As Object, e As KeyEventArgs) Handles nudDEF.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub nudPOW_KeyDown(sender As Object, e As KeyEventArgs) Handles nudPOW.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub nudDEX_KeyDown(sender As Object, e As KeyEventArgs) Handles nudDEX.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub nudMIND_KeyDown(sender As Object, e As KeyEventArgs) Handles nudMIND.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub nudProgressDEF_KeyDown(sender As Object, e As KeyEventArgs) Handles nudProgressDEF.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub nudProgressPOW_KeyDown(sender As Object, e As KeyEventArgs) Handles nudProgressPOW.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub nudProgressDEX_KeyDown(sender As Object, e As KeyEventArgs) Handles nudProgressDEX.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub nudProgressMIND_KeyDown(sender As Object, e As KeyEventArgs) Handles nudProgressMIND.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

#End Region

#Region "nud Qty"

    Private Sub nudQtyMonomate_KeyDown(sender As Object, e As KeyEventArgs) Handles nudQtyMonomate.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
            btnMonomate.PerformClick()
        End If
    End Sub

    Private Sub nudQtyDimate_KeyDown(sender As Object, e As KeyEventArgs) Handles nudQtyDimate.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
            btnDimate.PerformClick()
        End If
    End Sub

    Private Sub nudQtyTrimate_KeyDown(sender As Object, e As KeyEventArgs) Handles nudQtyTrimate.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
            btnTrimate.PerformClick()
        End If
    End Sub

    Private Sub nudQtyMonofluid_KeyDown(sender As Object, e As KeyEventArgs) Handles nudQtyMonofluid.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
            btnMonofluid.PerformClick()
        End If
    End Sub

    Private Sub nudQtyDifluid_KeyDown(sender As Object, e As KeyEventArgs) Handles nudQtyDifluid.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
            btnDifluid.PerformClick()
        End If
    End Sub

    Private Sub nudQtyTrifluid_KeyDown(sender As Object, e As KeyEventArgs) Handles nudQtyTrifluid.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
            btnTrifluid.PerformClick()
        End If
    End Sub

    Private Sub nudQtyAntidote_KeyDown(sender As Object, e As KeyEventArgs) Handles nudQtyAntidote.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
            btnAntidote.PerformClick()
        End If
    End Sub

    Private Sub nudQtyAntiparalysis_KeyDown(sender As Object, e As KeyEventArgs) Handles nudQtyAntiparalysis.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
            btnAntiparalysis.PerformClick()
        End If
    End Sub

    Private Sub nudQtySolAtomizer_KeyDown(sender As Object, e As KeyEventArgs) Handles nudQtySolAtomizer.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
            btnSolAtomizer.PerformClick()
        End If
    End Sub

    Private Sub nudQtyMoonAtomizer_KeyDown(sender As Object, e As KeyEventArgs) Handles nudQtyMoonAtomizer.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
            btnMoonAtomizer.PerformClick()
        End If
    End Sub

    Private Sub nudQtyStarAtomizer_KeyDown(sender As Object, e As KeyEventArgs) Handles nudQtyStarAtomizer.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
            btnStarAtomizer.PerformClick()
        End If
    End Sub

#End Region

#Region "nud History"

    Private Sub nudHistoryMonomate_KeyDown(sender As Object, e As KeyEventArgs) Handles nudHistoryMonomate.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub nudHistoryDimate_KeyDown(sender As Object, e As KeyEventArgs) Handles nudHistoryDimate.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub nudHistoryTrimate_KeyDown(sender As Object, e As KeyEventArgs) Handles nudHistoryTrimate.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub nudHistoryMonofluid_KeyDown(sender As Object, e As KeyEventArgs) Handles nudHistoryMonofluid.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub nudHistoryDifluid_KeyDown(sender As Object, e As KeyEventArgs) Handles nudHistoryDifluid.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub nudHistoryTrifluid_KeyDown(sender As Object, e As KeyEventArgs) Handles nudHistoryTrifluid.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub nudHistoryAntidote_KeyDown(sender As Object, e As KeyEventArgs) Handles nudHistoryAntidote.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub nudHistoryAntiparalysis_KeyDown(sender As Object, e As KeyEventArgs) Handles nudHistoryAntiparalysis.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub nudHistorySolAtomizer_KeyDown(sender As Object, e As KeyEventArgs) Handles nudHistorySolAtomizer.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub nudHistoryMoonAtomizer_KeyDown(sender As Object, e As KeyEventArgs) Handles nudHistoryMoonAtomizer.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub nudHistoryStarAtomizer_KeyDown(sender As Object, e As KeyEventArgs) Handles nudHistoryStarAtomizer.KeyDown
        If e.KeyCode = Keys.Return Then
            e.SuppressKeyPress = True
        End If
    End Sub

#End Region

#End Region

#Region "Mouse Click"

#Region "Menu Strip"

    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        Call SavePrompt()
        Call Init()
        Call InitFinalize()

    End Sub

    Private Sub mnuFileNewBlank_Click(sender As Object, e As EventArgs) Handles mnuFileNewBlank.Click
        Call SavePrompt()

        Call Init()

        nudSynchro.Value = 0
        nudIQ.Value = 0
        nudDEF.Value = 0
        nudPOW.Value = 0
        nudDEX.Value = 0
        nudMIND.Value = 0
        Call InitFinalize()

    End Sub

    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click

        If sdfSave.FileName.Length > 0 Then
            strPathTmp = sdfSave.FileName
            Call MagSave()
            Call Saved()
        Else
            Call MagSaveAs()
            Call Saved()
        End If

    End Sub

    Private Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click
        Call MagSaveAs()
        Call Saved()
    End Sub

    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        With ofdMagatama
            .InitialDirectory = "./"
            .Filter = "Mag files (*.mag)|*.mag"
            .FilterIndex = 2
            .RestoreDirectory = True
        End With

        If ofdMagatama.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Call Init() 'Used to Reset the Maximum  value of the stats nud
            Call InitFinalize()
            Call MagLoad()
        End If
        Call Saved()

    End Sub

    Private Sub mnuFileExportOutput_Click(sender As Object, e As EventArgs) Handles mnuFileExportOutput.Click
        Call ExportOutput()
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click

        Call SavePrompt()

        Me.Close()
    End Sub

    Private Sub nmuHelpAbout_Click(sender As Object, e As EventArgs) Handles nmuHelpAbout.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub mnuEditUndo_Click(sender As Object, e As EventArgs) Handles mnuEditUndo.Click


        shoUndo = (shoUndo - 1)

        If shoUndo <= 0 Then
            shoUndo = 0
            strPathTmp = ("./Tmp/" & shoUndo & ".mag")

            ofdMagatama.FileName = strPathTmp.ToString
            Call MagLoad()
        Else
            strPathTmp = ("./Tmp/" & shoUndo & ".mag")

            ofdMagatama.FileName = strPathTmp.ToString
            Call MagLoad()

        End If
    End Sub

    Private Sub mnuEditRedo_Click(sender As Object, e As EventArgs) Handles mnuEditRedo.Click
        shoUndo = (shoUndo + 1)
        If shoUndo >= shoRedo Then
            shoUndo = (shoRedo - 1)
            strPathTmp = ("./Tmp/" & shoUndo & ".mag")
            ofdMagatama.FileName = strPathTmp.ToString
            Call MagLoad()
        Else
            strPathTmp = ("./Tmp/" & shoUndo & ".mag")
            ofdMagatama.FileName = strPathTmp.ToString
            Call MagLoad()
        End If
    End Sub

    Private Sub mnuEditResetQty_Click(sender As Object, e As EventArgs) Handles mnuEditResetQty.Click
        Call ResetQty()
    End Sub

    Private Sub mnuEditInit_Click(sender As Object, e As EventArgs) Handles mnuEditInit.Click
        frmSettings.ShowDialog()
    End Sub

    Private Sub nmuEditStat_CheckedChanged(sender As Object, e As EventArgs) Handles mnuEditStat.CheckedChanged
        Call EditMode()
    End Sub

#End Region

#Region "Focus"

    Private Sub picClass_Click(sender As Object, e As EventArgs) Handles picClass.Click
        cboClass.Focus()
    End Sub

    Private Sub picSectionID_Click(sender As Object, e As EventArgs) Handles picSectionID.Click
        cboSectionID.Focus()
    End Sub

    Private Sub picMag_Click(sender As Object, e As EventArgs) Handles picMag.Click
        cboMag.Focus()
    End Sub

    Private Sub picPhotonBlast01_Click(sender As Object, e As EventArgs) Handles picPhotonBlast01.Click
        cboPhotonBlast01.Focus()
    End Sub

    Private Sub picPhotonBlast02_Click(sender As Object, e As EventArgs) Handles picPhotonBlast02.Click
        cboPhotonBlast02.Focus()
    End Sub

    Private Sub picPhotonBlast03_Click(sender As Object, e As EventArgs) Handles picPhotonBlast03.Click
        cboPhotonBlast03.Focus()
    End Sub



#End Region

#End Region

#End Region

#Region "Feeding"

#Region "Verification"

    Public Sub StatsChecks()

        If nudStats.Value = nudStats.Maximum Then
            Call ProgressCheck()
        Else
            Call ProgressCheckLevel()
        End If
    End Sub

    Public Sub ProgressCheck()

        If shoProgress >= nudProgressStats.Maximum Then
            nudProgressStats.Value = nudProgressStats.Maximum
        ElseIf shoProgress <= nudProgressStats.Minimum Then
            nudProgressStats.Value = nudProgressStats.Minimum
        Else
            nudProgressStats.Value = shoProgress
        End If

    End Sub

    Public Sub ProgressCheckLevel()

        If shoProgress >= nudProgressStats.Maximum Then
            nudProgressStats.Value = shoProgress - nudProgressStats.Maximum
            nudStats.Value = nudStats.Value + 1
            Call MagLevel()

        ElseIf shoProgress <= nudProgressStats.Minimum Then
            nudProgressStats.Value = nudProgressStats.Minimum
        Else
            nudProgressStats.Value = shoProgress
        End If
    End Sub

    Public Sub LevelSyncIQCheck()

        If shoProgress > nudStats.Maximum Then
            nudStats.Value = nudStats.Maximum
        ElseIf shoProgress <= nudStats.Minimum Then
            nudStats.Value = nudStats.Minimum
        Else
            nudStats.Value = shoProgress
        End If

    End Sub

    Public Sub EvolutionCheck()
        bytMagCheck = cboMag.SelectedIndex

        If nudLevel.Value >= 10 AndAlso nudLevel.Value <= 14 Then
            If picMag.Tag = 0 Then
                Call MagStage01()
            End If
        ElseIf nudLevel.Value >= 35 AndAlso nudLevel.Value <= 39 Then
            If picMag.Tag = 0 Or picMag.Tag = 1 Then
                Call MagStage02()
            End If
        ElseIf nudLevel.Value = bytStage3 Or nudLevel.Value = bytStage4 Then
            Call MagStage04()

            If picMag.Tag <> "4" Then
                Call MagStage03()
            End If

        End If


        Call ResetCountEvo()
    End Sub

    Public Sub Cost() 'Calcule the Cost both in Meseta and time.

        lngEstimatedTime = shoFeedingTime * lblCyclesCount.Text

        lblTime.Text = lngEstimatedTime / 60

        lngEstimatedCost = (nudHistoryCostMonomate.Value + nudHistoryCostDimate.Value + nudHistoryCostTrimate.Value + nudHistoryCostMonofluid.Value +
        nudHistoryCostDifluid.Value + nudHistoryCostTrifluid.Value + nudHistoryCostAntidote.Value + nudHistoryCostAntiparalysis.Value +
        nudHistoryCostSolAtomizer.Value + nudHistoryCostMoonAtomizer.Value + nudHistoryCostStarAtomizer.Value)
        lblCost.Text = lngEstimatedCost

    End Sub

#End Region

    Public Sub Feed()

        shoCount = 0

        While shoCount < nudQtyTmp.Value


            shoProgress = 0
            nudHistoryTmp.Value = nudHistoryTmp.Value + 1

            rtfOutput.AppendText(btnTmp.Text & " x" & ((nudHistoryTmp.Value) - (shoevoTmp)) & Chr(13))
            shoCount = shoCount + 1
            bytFeedingCount = bytFeedingCount + 1
            strTmp = strTmp.Replace(" ", "")

            Using XmlLoadTable As XmlReader = XmlReader.Create("./Data/FeedingTables/Table_" & strFeedingChart & ".xml")

                XmlLoadTable.ReadToFollowing(strTmp)

                XmlLoadTable.MoveToAttribute("Sync")
                shoProgress = nudSynchro.Value + XmlLoadTable.Value
                nudStats = nudSynchro
                Call LevelSyncIQCheck()
            End Using

            Using XmlLoadTable As XmlReader = XmlReader.Create("./Data/FeedingTables/Table_" & strFeedingChart & ".xml")
                XmlLoadTable.ReadToFollowing(strTmp)
                XmlLoadTable.MoveToAttribute("IQ")
                shoProgress = nudIQ.Value + XmlLoadTable.Value
                nudStats = nudIQ
                Call LevelSyncIQCheck()
            End Using

            Using XmlLoadTable As XmlReader = XmlReader.Create("./Data/FeedingTables/Table_" & strFeedingChart & ".xml")
                XmlLoadTable.ReadToFollowing(strTmp)
                XmlLoadTable.MoveToAttribute("DEF")
                shoProgress = nudProgressDEF.Value + XmlLoadTable.Value
                nudStats = nudDEF
                nudProgressStats = nudProgressDEF
                Call StatsChecks()
            End Using

            Using XmlLoadTable As XmlReader = XmlReader.Create("./Data/FeedingTables/Table_" & strFeedingChart & ".xml")
                XmlLoadTable.ReadToFollowing(strTmp)
                XmlLoadTable.MoveToAttribute("POW")
                shoProgress = nudProgressPOW.Value + XmlLoadTable.Value
                nudStats = nudPOW
                nudProgressStats = nudProgressPOW
                Call StatsChecks()
            End Using

            Using XmlLoadTable As XmlReader = XmlReader.Create("./Data/FeedingTables/Table_" & strFeedingChart & ".xml")
                XmlLoadTable.ReadToFollowing(strTmp)
                XmlLoadTable.MoveToAttribute("DEX")
                shoProgress = nudProgressDEX.Value + XmlLoadTable.Value
                nudStats = nudDEX
                nudProgressStats = nudProgressDEX
                Call StatsChecks()
            End Using

            Using XmlLoadTable As XmlReader = XmlReader.Create("./Data/FeedingTables/Table_" & strFeedingChart & ".xml")
                XmlLoadTable.ReadToFollowing(strTmp)
                XmlLoadTable.MoveToAttribute("MIND")
                shoProgress = nudProgressMIND.Value + XmlLoadTable.Value
                nudStats = nudMIND
                nudProgressStats = nudProgressMIND
                Call StatsChecks()
            End Using




            If bytFeedingCount = 3 Then
                lblCyclesCount.Text = lblCyclesCount.Text + 1
                bytFeedingCount = 0
                rtfOutput.AppendText("------------------------------------------" & " [" & (lblCyclesCount.Text - shoEvoCycle) & "]" & Chr(13))
            End If

            Call EvolutionCheck()
            Call Cost()
            Call UndoRedo()


        End While


    End Sub

    Public Sub ResetCountEvo()

        If bytMagCheck <> cboMag.SelectedIndex Then
            shoEvoCycle = lblCyclesCount.Text
            shoEvoMonomate = nudHistoryMonomate.Value
            shoEvoDimate = nudHistoryDimate.Value
            shoEvoTrimate = nudHistoryTrimate.Value
            shoEvoMonofluid = nudHistoryMonofluid.Value
            shoEvoDifluid = nudHistoryDifluid.Value
            shoEvoTrifluid = nudHistoryTrifluid.Value
            shoEvoAntidote = nudHistoryAntidote.Value
            shoEvoAntiparalysis = nudHistoryAntiparalysis.Value
            shoEvoSolAtomizer = nudHistorySolAtomizer.Value
            shoEvoMoonAtomizer = nudHistoryMoonAtomizer.Value
            shoEvoStarAtomizer = nudHistoryStarAtomizer.Value
        End If

        Select Case strTmp
            Case = "Monomate"
                shoevoTmp = shoEvoMonomate
            Case = "Dimate"
                shoevoTmp = shoEvoDimate
            Case = "Trimate"
                shoevoTmp = shoEvoTrimate
            Case = "Monofluid"
                shoevoTmp = shoEvoMonofluid
            Case = "Difluid"
                shoevoTmp = shoEvoDifluid
            Case = "Trifluid"
                shoevoTmp = shoEvoTrifluid

            Case = "Antidote"
                shoevoTmp = shoEvoAntidote
            Case = "Antiparalysis"
                shoevoTmp = shoEvoAntiparalysis

            Case = "SolAtomizer"
                shoevoTmp = shoEvoSolAtomizer
            Case = "MoonAtomizer"
                shoevoTmp = shoEvoMoonAtomizer
            Case = "StarAtomizer"
                shoevoTmp = shoEvoStarAtomizer
        End Select

    End Sub


#Region "Evolution"

    Public Sub MagCellEvolutionCheck()
        strTmp = "Cell_" & cboMagCell.SelectedIndex
        If picMag.Tag = "4" Then

            Using XmlLoadTable As XmlReader = XmlReader.Create("./Data/Evolution/MagCellsExclusion.xml")
                XmlLoadTable.ReadToFollowing(strTmp)
                XmlLoadTable.MoveToFirstAttribute()
                strEvo = XmlLoadTable.Value
            End Using

            If strEvo = "NO" Then
                MessageBox.Show(strEvolveRare)
            Else
                CallByName(Me, strTmp, CallType.Method)
            End If
        Else
            CallByName(Me, strTmp, CallType.Method)
        End If

    End Sub

    Public Sub MagCellError()

        Using XmlLoadTable As XmlReader = XmlReader.Create("./Data/Evolution/MagCellsError.xml")
            XmlLoadTable.ReadToFollowing(strTmp)
            XmlLoadTable.MoveToFirstAttribute()
            strTmp = XmlLoadTable.Value
        End Using


        MessageBox.Show(strTmp)

    End Sub


#Region "Standard"

    Public Sub MagStage01()

        Using XmlLoadMag As XmlReader = XmlReader.Create("./Data/Evolution/Basic.xml")

            XmlLoadMag.ReadToFollowing("Stage01_" & cboClass.SelectedItem.Substring(0, 2))
            XmlLoadMag.MoveToFirstAttribute()
            cboMag.SelectedIndex = XmlLoadMag.Value
        End Using


        Using XmlLoadMag As XmlReader = XmlReader.Create("./Data/Mag/" & cboMag.SelectedIndex & ".xml")

            XmlLoadMag.ReadToFollowing("PhotonBlast")
            XmlLoadMag.MoveToFirstAttribute()
            XmlLoadMag.MoveToNextAttribute()
            cboPhotonBlast01.SelectedItem = XmlLoadMag.Value

        End Using

    End Sub

    Public Sub MagStage02()

#Region "Stalemate Check"

        If cboMag.SelectedIndex = 1 Then 'Varuna

            If nudDEF.Value = nudLevel.Value Then
                strEvo = "POW"
            End If

            If nudPOW.Value = nudDEX.Value Then
                strEvo = "POW"
            End If

            If nudPOW.Value = nudMIND.Value Then
                strEvo = "POW"
            End If

            If nudDEX.Value = nudMIND.Value Then
                strEvo = "POW"
            End If

        End If


        If cboMag.SelectedIndex = 2 Then 'Kalki

            If nudDEF.Value = nudLevel.Value Then
                strEvo = "DEX"
            End If


            If nudPOW.Value = nudDEX.Value Then
                strEvo = "DEX"
            End If

            If nudPOW.Value = nudMIND.Value Then
                strEvo = "DEX"
            End If

            If nudDEX.Value = nudMIND.Value Then
                strEvo = "DEX"
            End If

        End If


        If cboMag.SelectedIndex = 3 Then 'Vritra

            If nudDEF.Value = nudLevel.Value Then
                strEvo = "MIND"
            End If

            If nudPOW.Value = nudDEX.Value Then
                strEvo = "MIND"
            End If

            If nudPOW.Value = nudMIND.Value Then
                strEvo = "MIND"
            End If

            If nudDEX.Value = nudMIND.Value Then
                strEvo = "MIND"
            End If

        End If


#End Region

        If nudPOW.Value > nudDEX.Value AndAlso nudPOW.Value > nudMIND.Value Then
            If nudPOW.Value > nudMIND.Value Then
                strEvo = "POW"
            End If
        End If

        If nudDEX.Value > nudPOW.Value AndAlso nudDEX.Value > nudMIND.Value Then
            If nudDEX.Value > nudMIND.Value Then
                strEvo = "DEX"
            End If
        End If

        If nudMIND.Value > nudPOW.Value AndAlso nudMIND.Value > nudDEX.Value Then
            If nudMIND.Value > nudDEX.Value Then
                strEvo = "MIND"
            End If
        End If


        Using XmlLoadMag As XmlReader = XmlReader.Create("./Data/Evolution/Basic.xml")
            XmlLoadMag.ReadToFollowing("Stage02_" & cboMag.SelectedIndex)
            XmlLoadMag.MoveToAttribute(strEvo)
            cboMag.SelectedIndex = XmlLoadMag.Value
        End Using

        Using XmlLoadMag As XmlReader = XmlReader.Create("./Data/Mag/" & cboMag.SelectedIndex & ".xml")

            XmlLoadMag.ReadToFollowing("PhotonBlast")
            XmlLoadMag.MoveToFirstAttribute()
            XmlLoadMag.MoveToNextAttribute()
            cboPhotonBlast02.SelectedItem = XmlLoadMag.Value


        End Using

    End Sub

    Public Sub MagStage03()

        strEvoCND = "" 'Represent the stats requirement
                strEvo = "" ' Represent the Section ID

#Region "Hunter"

        If cboClass.SelectedItem.Substring(0, 2) = "HU" Then

            If nudPOW.Value >= nudDEX.Value AndAlso nudDEX.Value >= nudMIND.Value Then
                strEvoCND = "POW_DEX_MIND"
            End If

            If nudDEX.Value = nudMIND.Value AndAlso nudMIND.Value > nudPOW.Value Then
                strEvoCND = "POW_DEX_MIND"
            End If

            If nudDEF.Value = nudLevel.Value Then
                strEvoCND = "POW_DEX_MIND"
            End If

            If nudPOW.Value >= nudMIND.Value AndAlso nudMIND.Value > nudDEX.Value Then
                strEvoCND = "POW_MIND_DEX"
            End If

            If nudDEX.Value > nudPOW.Value AndAlso nudPOW.Value > nudMIND.Value Then
                strEvoCND = "DEX_POW_MIND"
            End If

            If nudDEX.Value > nudMIND.Value AndAlso nudMIND.Value >= nudPOW.Value Then
                strEvoCND = "DEX_MIND_POW"
            End If

            If nudMIND.Value > nudPOW.Value AndAlso nudPOW.Value >= nudDEX.Value Then
                strEvoCND = "MIND_POW_DEX"
            End If


            If nudMIND.Value > nudDEX.Value AndAlso nudDEX.Value > nudPOW.Value Then
                strEvoCND = "MIND_DEX_POW"
            End If

        End If

#End Region

#Region "Ranger"

        If cboClass.SelectedItem.Substring(0, 2) = "RA" Then

            If nudPOW.Value > nudDEX.Value AndAlso nudDEX.Value >= nudMIND.Value Then
                strEvoCND = "POW_DEX_MIND"
            End If

            If nudPOW.Value > nudMIND.Value AndAlso nudMIND.Value > nudDEX.Value Then
                strEvoCND = "POW_MIND_DEX"
            End If

            If nudDEX.Value >= nudPOW.Value AndAlso nudPOW.Value > nudMIND.Value Then
                strEvoCND = "DEX_POW_MIND"
            End If

            If nudDEX.Value >= nudMIND.Value AndAlso nudMIND.Value >= nudPOW.Value Then
                strEvoCND = "DEX_MIND_POW"
            End If

            If nudPOW.Value = nudMIND.Value AndAlso nudMIND.Value > nudDEX.Value Then
                strEvoCND = "DEX_MIND_POW"
            End If

            If nudDEF.Value = nudLevel.Value Then
                strEvoCND = "DEX_MIND_POW"
            End If

            If nudMIND.Value > nudPOW.Value AndAlso nudPOW.Value >= nudDEX.Value Then
                strEvoCND = "MIND_POW_DEX"
            End If

            If nudMIND.Value > nudDEX.Value AndAlso nudDEX.Value > nudPOW.Value Then
                strEvoCND = "MIND_DEX_POW"
            End If

        End If
#End Region

#Region "Force"

        If cboClass.SelectedItem.Substring(0, 2) = "FO" Then

            If nudPOW.Value > nudDEX.Value AndAlso nudDEX.Value >= nudMIND.Value Then
                strEvoCND = "POW_DEX_MIND"
            End If

            If nudPOW.Value > nudMIND.Value AndAlso nudMIND.Value > nudDEX.Value Then
                strEvoCND = "POW_MIND_DEX"
            End If

            If nudDEX.Value > nudPOW.Value AndAlso nudPOW.Value > nudMIND.Value Then
                strEvoCND = "DEX_POW_MIND"
            End If

            If nudDEX.Value > nudMIND.Value AndAlso nudMIND.Value >= nudPOW.Value Then
                strEvoCND = "DEX_MIND_POW"
            End If

            If nudMIND.Value >= nudPOW.Value AndAlso nudPOW.Value >= nudDEX.Value Then
                strEvoCND = "MIND_POW_DEX"
            End If

            If nudPOW.Value = nudDEX.Value AndAlso nudDEX.Value > nudMIND.Value Then
                strEvoCND = "MIND_POW_DEX"
            End If

            If nudDEF.Value = nudLevel.Value Then
                strEvoCND = "MIND_POW_DEX"
            End If

            If nudMIND.Value >= nudDEX.Value AndAlso nudDEX.Value > nudPOW.Value Then
                strEvoCND = "MIND_DEX_POW"
            End If

            ' Special Force Evolution DEF >= 45

            If nudDEF.Value >= 45 Then

                If nudPOW.Value > (nudMIND.Value + nudDEX.Value) Then
                    strEvoCND = "POW_DEXMIND"
                End If

                If nudDEX.Value > (nudPOW.Value + nudMIND.Value) Then
                    strEvoCND = "DEX_POWMIND"
                End If

                If nudMIND.Value > (nudPOW.Value + nudDEX.Value) Then
                    strEvoCND = "MIND_POWDEX"
                End If

            End If
        End If
#End Region


#Region "Section ID Group"

        Select Case cboSectionID.SelectedItem

                 ' Section ID Group A
                        Case = "Purplenum"
                            strEvo = ("A")
                        Case = "Redria"
                            strEvo = ("A")
                        Case = "Skyly"
                            strEvo = ("A")
                        Case = "Viridia"
                            strEvo = ("A")
                        Case = "Yellowboze"
                            strEvo = ("A")

                 ' Section ID Group B
                        Case = "Bluefull"
                            strEvo = ("B")
                        Case = "Greenill"
                            strEvo = ("B")
                        Case = "Oran"
                            strEvo = ("B")
                        Case = "Pinkal"
                            strEvo = ("B")
                        Case = "Whitill"
                            strEvo = ("B")

                        Case Else ' Redundant but if an error cause to have no Section ID the program should not crash on this part
                            strEvo = ("A")

                    End Select

#End Region

        Using XmlLoadMag As XmlReader = XmlReader.Create("./Data/Evolution/" & cboClass.SelectedItem.Substring(0, 2) & "_Stage03.xml")
                        XmlLoadMag.ReadToFollowing(strEvoCND)
                        XmlLoadMag.MoveToAttribute(strEvo)
            cboMag.SelectedIndex = XmlLoadMag.Value
        End Using

        Using XmlLoadMag As XmlReader = XmlReader.Create("./Data/Mag/" & cboMag.SelectedIndex & ".xml")

            XmlLoadMag.ReadToFollowing("PhotonBlast")
            XmlLoadMag.MoveToFirstAttribute()
            XmlLoadMag.MoveToNextAttribute()
            strEvo = XmlLoadMag.Value

        End Using



        If cboPhotonBlast01.SelectedItem = strEvo Then

                    ElseIf cboPhotonBlast02.SelectedItem = strEvo Then

                    ElseIf cboPhotonBlast03.SelectedIndex = 0 Then
                        cboPhotonBlast03.SelectedItem = strEvo
                    End If

    End Sub

    Public Sub MagStage04()
        If nudLevel.Value = bytStage4 Then

            strEvo = "" ' Represent The Gender
            strEvoCND = "" ' Represent Stats Condition
            strEvoCND2 = "" 'Represent the Section ID

            Select Case cboClass.SelectedItem.Remove(0, 2)

                Case "mar"
                    strEvo = "M"
                Case "cast"
                    strEvo = "M"
                Case "newm"
                    strEvo = "M"
                Case "marl"
                    strEvo = "F"
                Case "caseal"
                    strEvo = "F"
                Case "newearl"
                    strEvo = "F"
                Case Else
                    strEvo = "F"
            End Select

#Region "Section ID Group"

            Select Case cboSectionID.SelectedItem

                 ' Section ID Group A
                Case = "Purplenum"
                    strEvoCND2 = ("GPO")
                Case = "Redria"
                    strEvoCND2 = ("VBRW")
                Case = "Skyly"
                    strEvoCND2 = ("SKY")
                Case = "Viridia"
                    strEvoCND2 = ("VBRW")
                Case = "Yellowboze"
                    strEvoCND2 = ("SKY")

                 ' Section ID Group B
                Case = "Bluefull"
                    strEvoCND2 = ("VBRW")
                Case = "Greenill"
                    strEvoCND2 = ("GPO")
                Case = "Oran"
                    strEvoCND2 = ("GPO")
                Case = "Pinkal"
                    strEvoCND2 = ("SKY")
                Case = "Whitill"
                    strEvoCND2 = ("VBRW")

                Case Else ' Redundant but if an error cause to have no Section ID the program should not crash on this part
                    strEvo = ("VBRW")

            End Select

#End Region


            If strEvoCND2 = "SKY" Then
                If (nudDEF.Value + nudPOW.Value) = (nudDEX.Value + nudMIND.Value) Then
                    strEvoCND = "DEFPOW-DEXMIND"
                End If
            End If

            If strEvoCND2 = "VBRW" Then
                If (nudDEF.Value + nudDEX.Value) = (nudPOW.Value + nudMIND.Value) Then
                    strEvoCND = "DEFDEX-POWMIND"
                End If
            End If

            If strEvoCND2 = "GPO" Then
                    If (nudDEF.Value + nudMIND.Value) = (nudPOW.Value + nudDEX.Value) Then
                        strEvoCND = "DEFMIND-POWDEX"
                    End If
                End If

Evolve:
            If strEvoCND <> "" Then

                Using XmlLoadMag As XmlReader = XmlReader.Create("./Data/Evolution/" & cboClass.SelectedItem.Substring(0, 2) & "_Stage04.xml")
                    XmlLoadMag.ReadToFollowing(strEvoCND)
                    XmlLoadMag.MoveToAttribute(strEvo)
                    cboMag.SelectedIndex = XmlLoadMag.Value
                End Using
            End If

        End If

    End Sub

#End Region

#Region "Mag Cells"

    Public Sub Cell_0() 'No Mag Cell
        'Exist only so the program doesn't crash
    End Sub

#Region "Classic"

    'CellofMAG213
    Public Sub Cell_1()

        If nudLevel.Value >= 100 Then

#Region "Section ID Group"

            Select Case cboSectionID.SelectedItem

                 ' Section ID Group A
                Case = "Purplenum"
                    strEvo = ("A")
                Case = "Redria"
                    strEvo = ("A")
                Case = "Skyly"
                    strEvo = ("A")
                Case = "Viridia"
                    strEvo = ("A")
                Case = "Yellowboze"
                    strEvo = ("A")

                 ' Section ID Group B
                Case = "Bluefull"
                    strEvo = ("B")
                Case = "Greenill"
                    strEvo = ("B")
                Case = "Oran"
                    strEvo = ("B")
                Case = "Pinkal"
                    strEvo = ("B")
                Case = "Whitill"
                    strEvo = ("B")

                Case Else ' Redundant but if an error cause to have no Section ID the program should not crash on this part
                    strEvo = ("A")

            End Select

#End Region

            rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)
            If strEvo = "A" Then
                cboMag.SelectedIndex = 37 'Churel
            ElseIf strEvo = "B" Then
                cboMag.SelectedIndex = 36 'Preta
            End If
        Else
            Call MagCellError()
        End If
    End Sub

    'CellofMAG502
    Public Sub Cell_2()

        If nudLevel.Value >= 100 Then

#Region "Section ID Group"

            Select Case cboSectionID.SelectedItem

                 ' Section ID Group A
                Case = "Purplenum"
                    strEvo = ("A")
                Case = "Redria"
                    strEvo = ("A")
                Case = "Skyly"
                    strEvo = ("A")
                Case = "Viridia"
                    strEvo = ("A")
                Case = "Yellowboze"
                    strEvo = ("A")

                 ' Section ID Group B
                Case = "Bluefull"
                    strEvo = ("B")
                Case = "Greenill"
                    strEvo = ("B")
                Case = "Oran"
                    strEvo = ("B")
                Case = "Pinkal"
                    strEvo = ("B")
                Case = "Whitill"
                    strEvo = ("B")

                Case Else ' Redundant but if an error cause to have no Section ID the program should not crash on this part
                    strEvo = ("A")

            End Select

#End Region


            rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)

            If strEvo = "A" Then
                cboMag.SelectedIndex = 39 'Soniti
            ElseIf strEvo = "B" Then
                cboMag.SelectedIndex = 38 'Pitri
            End If

        Else
            Call MagCellError()
        End If
    End Sub

    'HeartofChao
    Public Sub Cell_3()

        If nudDEF.Value >= 35 Then
            If nudPOW.Value >= 35 Then
                If nudDEX.Value >= 35 Then
                    If nudMIND.Value >= 35 Then
                        rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)
                        cboMag.SelectedIndex = 40 'Chao
                    End If
                End If
            End If
        Else
            Call MagCellError()
        End If
    End Sub

    'HeartofRoboChao
    Public Sub Cell_4()

        If nudDEF.Value >= 70 Then
            shoCount = 1
        End If

        If nudPOW.Value >= 70 Then
            shoCount = strEvo + 1
        End If

        If nudDEX.Value >= 70 Then
            shoCount = strEvo + 1
        End If

        If nudMIND.Value >= 70 Then
            shoCount = strEvo + 1
        End If

        If shoCount >= 2 Then
            rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)
            cboMag.SelectedIndex = 41 'Robochao
        Else
            Call MagCellError()
        End If

    End Sub

    'HeartofPian
    Public Sub Cell_5()

        If nudLevel.Value >= 120 Then
            If nudSynchro.Value >= 120 Then
                If nudIQ.Value >= 180 Then
                    rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)
                    cboMag.SelectedIndex = 42 'Pian
                End If

            End If
        Else
            Call MagCellError()
        End If

    End Sub

    'HeartofOpaOpa
    Public Sub Cell_6()

        If nudLevel.Value >= 100 Then
            rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)
            cboMag.SelectedIndex = 43 'OpaOpa
        Else
            Call MagCellError()
        End If

    End Sub

    'HeartofChuChu
    Public Sub Cell_7()

        If nudLevel.Value >= 50 Then
            rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)
            cboMag.SelectedIndex = 44 'Chu CHu
        Else
            Call MagCellError()
        End If

    End Sub

    'HeartofKapuKapu
    Public Sub Cell_8()

        If nudLevel.Value >= 50 Then
            rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)
            cboMag.SelectedIndex = 45 'Kapu Kapu
        Else
            Call MagCellError()
        End If

    End Sub

    'HeartofAngel
    Public Sub Cell_9()


        Select Case cboClass.SelectedItem.Remove(0, 2)

            Case "cast"
                strEvo = ""
            Case "caseal"
                strEvo = ""
            Case Else
                strEvo = "OK"
        End Select

        If blnMagRacialRestriction = False Then
            strEvo = "OK"
        End If

        If strEvo = "OK" Then
            If nudLevel.Value >= 100 Then
                rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)
                cboMag.SelectedIndex = 46 'Angel's Wings
            Else
                Call MagCellError()
            End If
        Else
            strTmp = strTmp & "_Droid"
            Call MagCellError()
        End If

    End Sub

    'HeartofDevil
    Public Sub Cell_10()

        Select Case cboClass.SelectedItem.Remove(0, 2)

            Case "cast"
                strEvo = ""
            Case "caseal"
                strEvo = ""
            Case Else
                strEvo = "OK"
        End Select

        If blnMagRacialRestriction = False Then
            strEvo = "OK"
        End If

        If strEvo = "OK" Then

            If cboMag.SelectedIndex = 47 Then 'Devíl's Wings
                rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)
                cboMag.SelectedIndex = 48 'Devil's Tail
            ElseIf nudLevel.Value >= 100 Then
                rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)
                cboMag.SelectedIndex = 47 'Devíl's Wings
            Else
                Call MagCellError()
            End If
        Else
            strTmp = strTmp & "_Droid"
            Call MagCellError()
        End If

    End Sub

    'PanthersSpirit
    Public Sub Cell_11()
        If cboMag.SelectedIndex = 30 Then 'Naga

            If nudLevel.Value >= 50 Then
                rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)
                cboMag.SelectedIndex = 49 'Panzer's Tail
            Else
                strTmp = strTmp & "_lvl"
                Call MagCellError()

            End If
        Else
            Call MagCellError()
        End If

    End Sub

    'KitofHamburger
    Public Sub Cell_12()
        If cboMag.SelectedIndex = 26 Then 'Kaithabha

            If nudLevel.Value >= 50 Then
                rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)
                cboMag.SelectedIndex = 50 'Hamburger

            Else
                strTmp = strTmp & "_lvl"
                Call MagCellError()
            End If
        Else
            Call MagCellError()
        End If
    End Sub

    'KitofMarkIII
    Public Sub Cell_13()
        If nudLevel.Value <= 9 Then
            rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)
            cboMag.SelectedIndex = 51 'Mark III
        Else
            Call MagCellError()
        End If
    End Sub

    'KitofMasterSystem
    Public Sub Cell_14()
        If cboMag.SelectedIndex = 51 Then 'Mark III
            If nudLevel.Value >= 60 Then
                rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)
                cboMag.SelectedIndex = 52 'Master System
            Else
                strTmp = strTmp & "_lvl"
                Call MagCellError()
            End If
        Else
            Call MagCellError()
        End If
    End Sub

    'Kit of Genesis
    Public Sub Cell_15()
        If cboMag.SelectedIndex = 52 Then 'Master System
            If nudLevel.Value >= 70 Then
                rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)
                cboMag.SelectedIndex = 53 'Genesis
            Else
                strTmp = strTmp & "_lvl"
                Call MagCellError()
            End If
        Else
            Call MagCellError()
        End If
    End Sub

    'Kit of Saturn
    Public Sub Cell_16()
        If cboMag.SelectedIndex = 53 Then 'Genesis
            If nudLevel.Value >= 90 Then
                rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)
                cboMag.SelectedIndex = "54" 'Saturn
            Else
                strTmp = strTmp & "_lvl"
                Call MagCellError()
            End If
        Else
            Call MagCellError()
        End If
    End Sub

    'Kit of Dreamcast
    Public Sub Cell_17()
        If cboMag.SelectedIndex = "54" Then 'Saturn
            If nudLevel.Value >= 165 Then
                rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)
                cboMag.SelectedIndex = "55" 'Dreamcast
            Else
                strTmp = strTmp & "_lvl"
                Call MagCellError()
            End If
        Else
            Call MagCellError()
        End If
    End Sub

    'HeartofYN1107
    Public Sub Cell_18()


        Select Case cboClass.SelectedItem.Remove(0, 2)

            Case "cast"
                strEvo = "OK"
            Case "caseal"
                strEvo = "OK"
            Case Else
                strEvo = ""
        End Select

        If blnMagRacialRestriction = False Then
            strEvo = "OK"
        End If

        If strEvo = "OK" Then
            If nudLevel.Value >= 50 Then
                rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)
                cboMag.SelectedIndex = 56
            Else
                Call MagCellError()
            End If
        Else
            strTmp = strTmp & "_Droid"
            Call MagCellError()
        End If
    End Sub

#End Region

#Region "Blue Burst"

    'LibertaKit
    Public Sub Cell_19()
        If nudLevel.Value >= 50 Then
            rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)
            cboMag.SelectedIndex = 66 'Agastya
        Else
            Call MagCellError()
        End If
    End Sub

    'DPhotonCore
    Public Sub Cell_20()

        If cboMag.SelectedIndex = 14 Then 'Kama
            If nudLevel.Value >= 100 Then
                rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)
                cboMag.SelectedIndex = 67 'Gael-Giel
            Else
                strTmp = strTmp & "_lvl"
                Call MagCellError()
            End If
        Else
            Call MagCellError()
        End If

    End Sub

    'Tablet
    Public Sub Cell_21()

        If cboMag.SelectedIndex = 61 Then 'Rukmin
            rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)
            cboMag.SelectedIndex = 68 'sGeung-si
        Else
            Call MagCellError()
        End If

    End Sub

    'HeartofMorolian
    Public Sub Cell_22()

        If cboMag.SelectedIndex = 33 Then 'Kumara
            rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)
            cboMag.SelectedIndex = 69 'Morolian
        Else
            Call MagCellError()
        End If

    End Sub

    'Pioneer Parts
    Public Sub Cell_23()
        If nudLevel.Value >= 50 Then
            rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)
            cboMag.SelectedItem = 70 'Pioneer 2
        End If
    End Sub

    'AmitiesMeno
    Public Sub Cell_24()
        If cboMag.SelectedIndex = 44 Then 'Chu Chu
            rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)
            cboMag.SelectedIndex = 71 'Puyo
        Else
            Call MagCellError()
        End If
    End Sub

    'Rappy Beak
    Public Sub Cell_25()
        If nudLevel.Value >= 50 Then
            rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)
            cboMag.SelectedIndex = 72 'Rappy
        Else
            Call MagCellError()
        End If
    End Sub

    'HeavenStrikerCoat
    Public Sub cell_26()
        If cboMag.SelectedIndex = 18 Then 'Garuda
            rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)
            cboMag.SelectedIndex = 73 'Striker Unit
        Else
            Call MagCellError()
        End If
    End Sub

    'DragonScale
    Public Sub Cell_27()
        If cboMag.SelectedIndex = 14 Then 'Kama
            rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)
            cboMag.SelectedIndex = 74 'Tellusis
        Else
            Call MagCellError()
        End If
    End Sub

    'YahoosEngine
    Public Sub Cell_28()
        If nudLevel.Value >= 50 Then
            rtfOutput.AppendText(vbNewLine & cboMagCell.SelectedItem & strMagCellUsed & vbNewLine)
            cboMag.SelectedIndex = 74 'Yahoo!
        Else
            Call MagCellError()
        End If
    End Sub

#End Region

#End Region

#End Region

#Region "Sets Variable for the Feeding Process"

    Public Sub MonomateFeed()
        strTmp = "Monomate"
        nudQtyTmp = nudQtyMonomate
        nudHistoryTmp = nudHistoryMonomate
        btnTmp = btnMonomate
        shoevoTmp = shoEvoMonomate
    End Sub

    Public Sub DimateFeed()
        strTmp = "Dimate"
        nudQtyTmp = nudQtyDimate
        nudHistoryTmp = nudHistoryDimate
        btnTmp = btnDimate
        shoevoTmp = shoEvoDimate
    End Sub

    Public Sub TrimateFeed()
        strTmp = "Trimate"
        nudQtyTmp = nudQtyTrimate
        nudHistoryTmp = nudHistoryTrimate
        btnTmp = btnTrimate
        shoevoTmp = shoEvoTrimate
    End Sub

    Public Sub MonofluidFeed()
        strTmp = "Monofluid"
        nudQtyTmp = nudQtyMonofluid
        nudHistoryTmp = nudHistoryMonofluid
        btnTmp = btnMonofluid
        shoevoTmp = shoEvoMonofluid
    End Sub

    Public Sub DifluidFeed()
        strTmp = "Difluid"
        nudQtyTmp = nudQtyDifluid
        nudHistoryTmp = nudHistoryDifluid
        btnTmp = btnDifluid
        shoevoTmp = shoEvoDifluid
    End Sub

    Public Sub TrifluidFeed()
        strTmp = "Trifluid"
        nudQtyTmp = nudQtyTrifluid
        nudHistoryTmp = nudHistoryTrifluid
        btnTmp = btnTrifluid
        shoevoTmp = shoEvoTrifluid
    End Sub

    Public Sub AntidoteFeed()
        strTmp = "Antidote"
        nudQtyTmp = nudQtyAntidote
        nudHistoryTmp = nudHistoryAntidote
        btnTmp = btnAntidote
        shoevoTmp = shoEvoAntidote
    End Sub

    Public Sub AntiparalysisFeed()
        strTmp = "Antiparalysis"
        nudQtyTmp = nudQtyAntiparalysis
        nudHistoryTmp = nudHistoryAntiparalysis
        btnTmp = btnAntiparalysis
        shoevoTmp = shoEvoAntiparalysis
    End Sub

    Public Sub SolAtomizerFeed()
        strTmp = "SolAtomizer"
        nudQtyTmp = nudQtySolAtomizer
        nudHistoryTmp = nudHistorySolAtomizer
        btnTmp = btnSolAtomizer
        shoevoTmp = shoEvoSolAtomizer
    End Sub

    Public Sub MoonAtomizerFeed()
        strTmp = "MoonAtomizer"
        nudQtyTmp = nudQtyMoonAtomizer
        nudHistoryTmp = nudHistoryMoonAtomizer
        btnTmp = btnMoonAtomizer
        shoevoTmp = shoEvoMoonAtomizer
    End Sub

    Public Sub StarAtomizerFeed()
        strTmp = "StarAtomizer"
        nudQtyTmp = nudQtyStarAtomizer
        nudHistoryTmp = nudHistoryStarAtomizer
        btnTmp = btnStarAtomizer
        shoevoTmp = shoEvoStarAtomizer
    End Sub

#End Region

#Region "Buttons"

    Private Sub btnMonomate_Click(sender As Object, e As EventArgs) Handles btnMonomate.Click
        If nudQtyMonomate.Value = 0 Then
            nudQtyMonomate.Value = 1
            Call MonomateFeed()
            Call Feed()
            nudQtyMonomate.Value = 0
        Else
            Call MonomateFeed()
            Call Feed()
        End If

    End Sub

    Private Sub btnDimate_Click(sender As Object, e As EventArgs) Handles btnDimate.Click
        If nudQtyDimate.Value = 0 Then
            nudQtyDimate.Value = 1
            Call DimateFeed()
            Call Feed()
            nudQtyDimate.Value = 0
        Else
            Call DimateFeed()
            Call Feed()
        End If

    End Sub

    Private Sub btnTrimate_Click(sender As Object, e As EventArgs) Handles btnTrimate.Click
        If nudQtyTrimate.Value = 0 Then
            nudQtyTrimate.Value = 1
            Call TrimateFeed()
            Call Feed()
            nudQtyTrimate.Value = 0
        Else
            Call TrimateFeed()
            Call Feed()
        End If

    End Sub

    Private Sub btnMonofluid_Click(sender As Object, e As EventArgs) Handles btnMonofluid.Click
        If nudQtyMonofluid.Value = 0 Then
            nudQtyMonofluid.Value = 1
            Call MonofluidFeed()
            Call Feed()
            nudQtyMonofluid.Value = 0
        Else
            Call MonofluidFeed()
            Call Feed()
        End If

    End Sub

    Private Sub btnDifluid_Click(sender As Object, e As EventArgs) Handles btnDifluid.Click
        If nudQtyDifluid.Value = 0 Then
            nudQtyDifluid.Value = 1
            Call DifluidFeed()
            Call Feed()
            nudQtyDifluid.Value = 0
        Else
            Call DifluidFeed()
            Call Feed()
        End If

    End Sub

    Private Sub btnTrifluid_Click(sender As Object, e As EventArgs) Handles btnTrifluid.Click
        If nudQtyTrifluid.Value = 0 Then
            nudQtyTrifluid.Value = 1
            Call TrifluidFeed()
            Call Feed()
            nudQtyTrifluid.Value = 0
        Else
            Call TrifluidFeed()
            Call Feed()
        End If

    End Sub

    Private Sub btnAntidote_Click(sender As Object, e As EventArgs) Handles btnAntidote.Click
        If nudQtyAntidote.Value = 0 Then
            nudQtyAntidote.Value = 1
            Call AntidoteFeed()
            Call Feed()
            nudQtyAntidote.Value = 0
        Else
            Call AntidoteFeed()
            Call Feed()
        End If

    End Sub

    Private Sub btnAntiparalysis_Click(sender As Object, e As EventArgs) Handles btnAntiparalysis.Click
        If nudQtyAntiparalysis.Value = 0 Then
            nudQtyAntiparalysis.Value = 1
            Call AntiparalysisFeed()
            Call Feed()
            nudQtyAntiparalysis.Value = 0
        Else
            Call AntiparalysisFeed()
            Call Feed()
        End If

    End Sub

    Private Sub btnSolAtomizer_Click(sender As Object, e As EventArgs) Handles btnSolAtomizer.Click
        If nudQtySolAtomizer.Value = 0 Then
            nudQtySolAtomizer.Value = 1
            Call SolAtomizerFeed()
            Call Feed()
            nudQtySolAtomizer.Value = 0
        Else
            Call SolAtomizerFeed()
            Call Feed()
        End If

    End Sub

    Private Sub btnMoonAtomizer_Click(sender As Object, e As EventArgs) Handles btnMoonAtomizer.Click
        If nudQtyMoonAtomizer.Value = 0 Then
            nudQtyMoonAtomizer.Value = 1
            Call MoonAtomizerFeed()
            Call Feed()
            nudQtyMoonAtomizer.Value = 0
        Else
            Call MoonAtomizerFeed()
            Call Feed()
        End If

    End Sub

    Private Sub btnStarAtomizer_Click(sender As Object, e As EventArgs) Handles btnStarAtomizer.Click
        If nudQtyStarAtomizer.Value = 0 Then
            nudQtyStarAtomizer.Value = 1
            Call StarAtomizerFeed()
            Call Feed()
            nudQtyStarAtomizer.Value = 0
        Else
            Call StarAtomizerFeed()
            Call Feed()
        End If

    End Sub

    Private Sub btnFeedAll_Click(sender As Object, e As EventArgs) Handles btnFeedAll.Click

        Call MonomateFeed()
        Call Feed()

        Call DimateFeed()
        Call Feed()

        Call TrimateFeed()
        Call Feed()

        Call MonofluidFeed()
        Call Feed()

        Call DifluidFeed()
        Call Feed()

        Call TrifluidFeed()
        Call Feed()

        Call AntidoteFeed()
        Call Feed()

        Call AntiparalysisFeed()
        Call Feed()

        Call SolAtomizerFeed()
        Call Feed()

        Call MoonAtomizerFeed()
        Call Feed()

        Call StarAtomizerFeed()
        Call Feed()

    End Sub

    Private Sub btnMagCell_Click(sender As Object, e As EventArgs) Handles btnMagCell.Click

        Call MagCellEvolutionCheck()
        Call UndoRedo()

    End Sub

    Private Sub btnOutputSpace_Click(sender As Object, e As EventArgs) Handles btnOutputSpace.Click
        rtfOutput.AppendText(Chr(13))
    End Sub


#End Region

#End Region

End Class
