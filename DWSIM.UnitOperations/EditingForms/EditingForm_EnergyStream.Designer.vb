﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditingForm_EnergyStream
    Inherits SharedClasses.ObjectEditorForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditingForm_EnergyStream))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblTag = New System.Windows.Forms.TextBox()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.lblConnectedTo = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rtbAnnotations = New Extended.Windows.Forms.RichTextBoxExtended()
        Me.GroupBoxParameters = New System.Windows.Forms.GroupBox()
        Me.cbEnergyFlow = New System.Windows.Forms.ComboBox()
        Me.tbEnergyFlow = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBoxConnections = New System.Windows.Forms.GroupBox()
        Me.btnDisconnectOutlet1 = New System.Windows.Forms.Button()
        Me.btnDisconnect1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbOutlet1 = New System.Windows.Forms.ComboBox()
        Me.cbInlet1 = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTipChangeTag = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBoxParameters.SuspendLayout()
        Me.GroupBoxConnections.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        resources.ApplyResources(Me.GroupBox5, "GroupBox5")
        Me.GroupBox5.Controls.Add(Me.lblTag)
        Me.GroupBox5.Controls.Add(Me.chkActive)
        Me.GroupBox5.Controls.Add(Me.lblConnectedTo)
        Me.GroupBox5.Controls.Add(Me.lblStatus)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.TabStop = False
        Me.ToolTipChangeTag.SetToolTip(Me.GroupBox5, resources.GetString("GroupBox5.ToolTip"))
        Me.ToolTipValues.SetToolTip(Me.GroupBox5, resources.GetString("GroupBox5.ToolTip1"))
        Me.ToolTip1.SetToolTip(Me.GroupBox5, resources.GetString("GroupBox5.ToolTip2"))
        '
        'lblTag
        '
        resources.ApplyResources(Me.lblTag, "lblTag")
        Me.lblTag.Name = "lblTag"
        Me.ToolTipValues.SetToolTip(Me.lblTag, resources.GetString("lblTag.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.lblTag, resources.GetString("lblTag.ToolTip1"))
        Me.ToolTipChangeTag.SetToolTip(Me.lblTag, resources.GetString("lblTag.ToolTip2"))
        '
        'chkActive
        '
        resources.ApplyResources(Me.chkActive, "chkActive")
        Me.chkActive.BackgroundImage = Global.DWSIM.UnitOperations.My.Resources.Resources.bullet_tick
        Me.chkActive.Name = "chkActive"
        Me.ToolTip1.SetToolTip(Me.chkActive, resources.GetString("chkActive.ToolTip"))
        Me.ToolTipChangeTag.SetToolTip(Me.chkActive, resources.GetString("chkActive.ToolTip1"))
        Me.ToolTipValues.SetToolTip(Me.chkActive, resources.GetString("chkActive.ToolTip2"))
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'lblConnectedTo
        '
        resources.ApplyResources(Me.lblConnectedTo, "lblConnectedTo")
        Me.lblConnectedTo.Name = "lblConnectedTo"
        Me.ToolTip1.SetToolTip(Me.lblConnectedTo, resources.GetString("lblConnectedTo.ToolTip"))
        Me.ToolTipChangeTag.SetToolTip(Me.lblConnectedTo, resources.GetString("lblConnectedTo.ToolTip1"))
        Me.ToolTipValues.SetToolTip(Me.lblConnectedTo, resources.GetString("lblConnectedTo.ToolTip2"))
        '
        'lblStatus
        '
        resources.ApplyResources(Me.lblStatus, "lblStatus")
        Me.lblStatus.Name = "lblStatus"
        Me.ToolTip1.SetToolTip(Me.lblStatus, resources.GetString("lblStatus.ToolTip"))
        Me.ToolTipChangeTag.SetToolTip(Me.lblStatus, resources.GetString("lblStatus.ToolTip1"))
        Me.ToolTipValues.SetToolTip(Me.lblStatus, resources.GetString("lblStatus.ToolTip2"))
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        Me.ToolTip1.SetToolTip(Me.Label13, resources.GetString("Label13.ToolTip"))
        Me.ToolTipChangeTag.SetToolTip(Me.Label13, resources.GetString("Label13.ToolTip1"))
        Me.ToolTipValues.SetToolTip(Me.Label13, resources.GetString("Label13.ToolTip2"))
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        Me.ToolTip1.SetToolTip(Me.Label12, resources.GetString("Label12.ToolTip"))
        Me.ToolTipChangeTag.SetToolTip(Me.Label12, resources.GetString("Label12.ToolTip1"))
        Me.ToolTipValues.SetToolTip(Me.Label12, resources.GetString("Label12.ToolTip2"))
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        Me.ToolTip1.SetToolTip(Me.Label11, resources.GetString("Label11.ToolTip"))
        Me.ToolTipChangeTag.SetToolTip(Me.Label11, resources.GetString("Label11.ToolTip1"))
        Me.ToolTipValues.SetToolTip(Me.Label11, resources.GetString("Label11.ToolTip2"))
        '
        'GroupBox4
        '
        resources.ApplyResources(Me.GroupBox4, "GroupBox4")
        Me.GroupBox4.Controls.Add(Me.rtbAnnotations)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.TabStop = False
        Me.ToolTipChangeTag.SetToolTip(Me.GroupBox4, resources.GetString("GroupBox4.ToolTip"))
        Me.ToolTipValues.SetToolTip(Me.GroupBox4, resources.GetString("GroupBox4.ToolTip1"))
        Me.ToolTip1.SetToolTip(Me.GroupBox4, resources.GetString("GroupBox4.ToolTip2"))
        '
        'rtbAnnotations
        '
        resources.ApplyResources(Me.rtbAnnotations, "rtbAnnotations")
        Me.rtbAnnotations.Name = "rtbAnnotations"
        Me.rtbAnnotations.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1046{\fonttbl{\f0\fnil Microsoft " &
    "Sans Serif;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "{\*\generator Riched20 10.0.22621}\viewkind4\uc1 " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\pard\f0\fs17\" &
    "par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.rtbAnnotations.ShowRedo = False
        Me.rtbAnnotations.ShowUndo = False
        Me.ToolTipValues.SetToolTip(Me.rtbAnnotations, resources.GetString("rtbAnnotations.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.rtbAnnotations, resources.GetString("rtbAnnotations.ToolTip1"))
        Me.ToolTipChangeTag.SetToolTip(Me.rtbAnnotations, resources.GetString("rtbAnnotations.ToolTip2"))
        '
        'GroupBoxParameters
        '
        resources.ApplyResources(Me.GroupBoxParameters, "GroupBoxParameters")
        Me.GroupBoxParameters.Controls.Add(Me.cbEnergyFlow)
        Me.GroupBoxParameters.Controls.Add(Me.tbEnergyFlow)
        Me.GroupBoxParameters.Controls.Add(Me.Label3)
        Me.GroupBoxParameters.Name = "GroupBoxParameters"
        Me.GroupBoxParameters.TabStop = False
        Me.ToolTipChangeTag.SetToolTip(Me.GroupBoxParameters, resources.GetString("GroupBoxParameters.ToolTip"))
        Me.ToolTipValues.SetToolTip(Me.GroupBoxParameters, resources.GetString("GroupBoxParameters.ToolTip1"))
        Me.ToolTip1.SetToolTip(Me.GroupBoxParameters, resources.GetString("GroupBoxParameters.ToolTip2"))
        '
        'cbEnergyFlow
        '
        resources.ApplyResources(Me.cbEnergyFlow, "cbEnergyFlow")
        Me.cbEnergyFlow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEnergyFlow.FormattingEnabled = True
        Me.cbEnergyFlow.Items.AddRange(New Object() {resources.GetString("cbEnergyFlow.Items"), resources.GetString("cbEnergyFlow.Items1"), resources.GetString("cbEnergyFlow.Items2")})
        Me.cbEnergyFlow.Name = "cbEnergyFlow"
        Me.ToolTip1.SetToolTip(Me.cbEnergyFlow, resources.GetString("cbEnergyFlow.ToolTip"))
        Me.ToolTipValues.SetToolTip(Me.cbEnergyFlow, resources.GetString("cbEnergyFlow.ToolTip1"))
        Me.ToolTipChangeTag.SetToolTip(Me.cbEnergyFlow, resources.GetString("cbEnergyFlow.ToolTip2"))
        '
        'tbEnergyFlow
        '
        resources.ApplyResources(Me.tbEnergyFlow, "tbEnergyFlow")
        Me.tbEnergyFlow.Name = "tbEnergyFlow"
        Me.ToolTipValues.SetToolTip(Me.tbEnergyFlow, resources.GetString("tbEnergyFlow.ToolTip"))
        Me.ToolTip1.SetToolTip(Me.tbEnergyFlow, resources.GetString("tbEnergyFlow.ToolTip1"))
        Me.ToolTipChangeTag.SetToolTip(Me.tbEnergyFlow, resources.GetString("tbEnergyFlow.ToolTip2"))
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        Me.ToolTip1.SetToolTip(Me.Label3, resources.GetString("Label3.ToolTip"))
        Me.ToolTipChangeTag.SetToolTip(Me.Label3, resources.GetString("Label3.ToolTip1"))
        Me.ToolTipValues.SetToolTip(Me.Label3, resources.GetString("Label3.ToolTip2"))
        '
        'GroupBoxConnections
        '
        resources.ApplyResources(Me.GroupBoxConnections, "GroupBoxConnections")
        Me.GroupBoxConnections.Controls.Add(Me.btnDisconnectOutlet1)
        Me.GroupBoxConnections.Controls.Add(Me.btnDisconnect1)
        Me.GroupBoxConnections.Controls.Add(Me.Label7)
        Me.GroupBoxConnections.Controls.Add(Me.cbOutlet1)
        Me.GroupBoxConnections.Controls.Add(Me.cbInlet1)
        Me.GroupBoxConnections.Controls.Add(Me.Label19)
        Me.GroupBoxConnections.Name = "GroupBoxConnections"
        Me.GroupBoxConnections.TabStop = False
        Me.ToolTipChangeTag.SetToolTip(Me.GroupBoxConnections, resources.GetString("GroupBoxConnections.ToolTip"))
        Me.ToolTipValues.SetToolTip(Me.GroupBoxConnections, resources.GetString("GroupBoxConnections.ToolTip1"))
        Me.ToolTip1.SetToolTip(Me.GroupBoxConnections, resources.GetString("GroupBoxConnections.ToolTip2"))
        '
        'btnDisconnectOutlet1
        '
        resources.ApplyResources(Me.btnDisconnectOutlet1, "btnDisconnectOutlet1")
        Me.btnDisconnectOutlet1.Image = Global.DWSIM.UnitOperations.My.Resources.Resources.disconnect
        Me.btnDisconnectOutlet1.Name = "btnDisconnectOutlet1"
        Me.ToolTip1.SetToolTip(Me.btnDisconnectOutlet1, resources.GetString("btnDisconnectOutlet1.ToolTip"))
        Me.ToolTipChangeTag.SetToolTip(Me.btnDisconnectOutlet1, resources.GetString("btnDisconnectOutlet1.ToolTip1"))
        Me.ToolTipValues.SetToolTip(Me.btnDisconnectOutlet1, resources.GetString("btnDisconnectOutlet1.ToolTip2"))
        Me.btnDisconnectOutlet1.UseVisualStyleBackColor = True
        '
        'btnDisconnect1
        '
        resources.ApplyResources(Me.btnDisconnect1, "btnDisconnect1")
        Me.btnDisconnect1.Image = Global.DWSIM.UnitOperations.My.Resources.Resources.disconnect
        Me.btnDisconnect1.Name = "btnDisconnect1"
        Me.ToolTip1.SetToolTip(Me.btnDisconnect1, resources.GetString("btnDisconnect1.ToolTip"))
        Me.ToolTipChangeTag.SetToolTip(Me.btnDisconnect1, resources.GetString("btnDisconnect1.ToolTip1"))
        Me.ToolTipValues.SetToolTip(Me.btnDisconnect1, resources.GetString("btnDisconnect1.ToolTip2"))
        Me.btnDisconnect1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        Me.ToolTip1.SetToolTip(Me.Label7, resources.GetString("Label7.ToolTip"))
        Me.ToolTipChangeTag.SetToolTip(Me.Label7, resources.GetString("Label7.ToolTip1"))
        Me.ToolTipValues.SetToolTip(Me.Label7, resources.GetString("Label7.ToolTip2"))
        '
        'cbOutlet1
        '
        resources.ApplyResources(Me.cbOutlet1, "cbOutlet1")
        Me.cbOutlet1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOutlet1.FormattingEnabled = True
        Me.cbOutlet1.Name = "cbOutlet1"
        Me.ToolTip1.SetToolTip(Me.cbOutlet1, resources.GetString("cbOutlet1.ToolTip"))
        Me.ToolTipValues.SetToolTip(Me.cbOutlet1, resources.GetString("cbOutlet1.ToolTip1"))
        Me.ToolTipChangeTag.SetToolTip(Me.cbOutlet1, resources.GetString("cbOutlet1.ToolTip2"))
        '
        'cbInlet1
        '
        resources.ApplyResources(Me.cbInlet1, "cbInlet1")
        Me.cbInlet1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbInlet1.FormattingEnabled = True
        Me.cbInlet1.Name = "cbInlet1"
        Me.ToolTip1.SetToolTip(Me.cbInlet1, resources.GetString("cbInlet1.ToolTip"))
        Me.ToolTipValues.SetToolTip(Me.cbInlet1, resources.GetString("cbInlet1.ToolTip1"))
        Me.ToolTipChangeTag.SetToolTip(Me.cbInlet1, resources.GetString("cbInlet1.ToolTip2"))
        '
        'Label19
        '
        resources.ApplyResources(Me.Label19, "Label19")
        Me.Label19.Name = "Label19"
        Me.ToolTip1.SetToolTip(Me.Label19, resources.GetString("Label19.ToolTip"))
        Me.ToolTipChangeTag.SetToolTip(Me.Label19, resources.GetString("Label19.ToolTip1"))
        Me.ToolTipValues.SetToolTip(Me.Label19, resources.GetString("Label19.ToolTip2"))
        '
        'ToolTipChangeTag
        '
        Me.ToolTipChangeTag.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTipChangeTag.ToolTipTitle = "Info"
        '
        'EditingForm_EnergyStream
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.Controls.Add(Me.GroupBoxConnections)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBoxParameters)
        Me.Name = "EditingForm_EnergyStream"
        Me.ToolTipValues.SetToolTip(Me, resources.GetString("$this.ToolTip"))
        Me.ToolTip1.SetToolTip(Me, resources.GetString("$this.ToolTip1"))
        Me.ToolTipChangeTag.SetToolTip(Me, resources.GetString("$this.ToolTip2"))
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBoxParameters.ResumeLayout(False)
        Me.GroupBoxParameters.PerformLayout()
        Me.GroupBoxConnections.ResumeLayout(False)
        Me.GroupBoxConnections.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Public WithEvents chkActive As System.Windows.Forms.CheckBox
    Public WithEvents lblConnectedTo As System.Windows.Forms.Label
    Public WithEvents lblStatus As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Public WithEvents rtbAnnotations As Extended.Windows.Forms.RichTextBoxExtended
    Public WithEvents GroupBoxParameters As System.Windows.Forms.GroupBox
    Public WithEvents cbEnergyFlow As System.Windows.Forms.ComboBox
    Public WithEvents tbEnergyFlow As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents GroupBoxConnections As System.Windows.Forms.GroupBox
    Public WithEvents btnDisconnectOutlet1 As System.Windows.Forms.Button
    Public WithEvents btnDisconnect1 As System.Windows.Forms.Button
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents cbOutlet1 As System.Windows.Forms.ComboBox
    Public WithEvents cbInlet1 As System.Windows.Forms.ComboBox
    Public WithEvents Label19 As System.Windows.Forms.Label
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents lblTag As System.Windows.Forms.TextBox
    Friend WithEvents ToolTipChangeTag As ToolTip
End Class
