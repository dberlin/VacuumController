<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VacuumController
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ModBusToVC75 = New AdvancedHMIDrivers.ModbusRTU.ModbusRTUCom(Me.components)
        Me.ModBusToSV65 = New AdvancedHMIDrivers.ModbusRTU.ModbusRTUCom(Me.components)
        Me.PIDSetpointVC75 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.PIDFeedbackVC75 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.StartVC75Button = New AdvancedHMIControls.MomentaryBitButton()
        Me.StopVC75Button = New AdvancedHMIControls.MomentaryBitButton()
        Me.UpButton = New AdvancedHMIControls.BasicButton()
        Me.DownButton = New AdvancedHMIControls.BasicButton()
        Me.OutputPowerVC75 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.CommandedFreqVC75 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StartSV65Button = New AdvancedHMIControls.MomentaryBitButton()
        Me.StopSV65Button = New AdvancedHMIControls.MomentaryBitButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ModBusToVC75
        '
        Me.ModBusToVC75.BaudRate = 38400
        Me.ModBusToVC75.DataBits = 8
        Me.ModBusToVC75.DisableSubscriptions = False
        Me.ModBusToVC75.Parity = System.IO.Ports.Parity.Odd
        Me.ModBusToVC75.PollRateOverride = 250
        Me.ModBusToVC75.PortName = "COM3"
        Me.ModBusToVC75.StationAddress = CType(100, Byte)
        Me.ModBusToVC75.StopBits = System.IO.Ports.StopBits.One
        Me.ModBusToVC75.SwapBytes = True
        Me.ModBusToVC75.SwapWords = False
        Me.ModBusToVC75.SynchronizingObject = Me
        '
        'ModBusToSV65
        '
        Me.ModBusToSV65.BaudRate = 38400
        Me.ModBusToSV65.DataBits = 8
        Me.ModBusToSV65.DisableSubscriptions = False
        Me.ModBusToSV65.Parity = System.IO.Ports.Parity.Odd
        Me.ModBusToSV65.PollRateOverride = 500
        Me.ModBusToSV65.PortName = "COM3"
        Me.ModBusToSV65.StationAddress = CType(2, Byte)
        Me.ModBusToSV65.StopBits = System.IO.Ports.StopBits.One
        Me.ModBusToSV65.SwapBytes = True
        Me.ModBusToSV65.SwapWords = True
        Me.ModBusToSV65.SynchronizingObject = Me
        '
        'PIDSetpointVC75
        '
        Me.PIDSetpointVC75.BackColor = System.Drawing.Color.Transparent
        Me.PIDSetpointVC75.CommComponent = Me.ModBusToVC75
        Me.PIDSetpointVC75.DecimalPosition = 2
        Me.PIDSetpointVC75.ForeColor = System.Drawing.Color.LightGray
        Me.PIDSetpointVC75.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.PIDSetpointVC75.KeypadMaxValue = 0R
        Me.PIDSetpointVC75.KeypadMinValue = 0R
        Me.PIDSetpointVC75.KeypadScaleFactor = 1.0R
        Me.PIDSetpointVC75.KeypadText = Nothing
        Me.PIDSetpointVC75.KeypadWidth = 300
        Me.PIDSetpointVC75.Location = New System.Drawing.Point(4, 32)
        Me.PIDSetpointVC75.Name = "PIDSetpointVC75"
        Me.PIDSetpointVC75.NumberOfDigits = 5
        Me.PIDSetpointVC75.PLCAddressKeypad = ""
        Me.PIDSetpointVC75.PLCAddressText = ""
        Me.PIDSetpointVC75.PLCAddressValue = "4465"
        Me.PIDSetpointVC75.PLCAddressVisible = ""
        Me.PIDSetpointVC75.Resolution = New Decimal(New Integer() {5, 0, 0, 0})
        Me.PIDSetpointVC75.Size = New System.Drawing.Size(161, 70)
        Me.PIDSetpointVC75.TabIndex = 1
        Me.PIDSetpointVC75.Text = "PID Setpoint"
        Me.PIDSetpointVC75.Value = 0R
        Me.PIDSetpointVC75.ValueScaleFactor = New Decimal(New Integer() {146, 0, 0, 131072})
        Me.PIDSetpointVC75.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'PIDFeedbackVC75
        '
        Me.PIDFeedbackVC75.BackColor = System.Drawing.Color.Transparent
        Me.PIDFeedbackVC75.CommComponent = Me.ModBusToVC75
        Me.PIDFeedbackVC75.DecimalPosition = 2
        Me.PIDFeedbackVC75.ForeColor = System.Drawing.Color.LightGray
        Me.PIDFeedbackVC75.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.PIDFeedbackVC75.KeypadMaxValue = 0R
        Me.PIDFeedbackVC75.KeypadMinValue = 0R
        Me.PIDFeedbackVC75.KeypadScaleFactor = 1.0R
        Me.PIDFeedbackVC75.KeypadText = Nothing
        Me.PIDFeedbackVC75.KeypadWidth = 300
        Me.PIDFeedbackVC75.Location = New System.Drawing.Point(4, 108)
        Me.PIDFeedbackVC75.Name = "PIDFeedbackVC75"
        Me.PIDFeedbackVC75.NumberOfDigits = 5
        Me.PIDFeedbackVC75.PLCAddressKeypad = ""
        Me.PIDFeedbackVC75.PLCAddressText = ""
        Me.PIDFeedbackVC75.PLCAddressValue = "4384"
        Me.PIDFeedbackVC75.PLCAddressVisible = ""
        Me.PIDFeedbackVC75.Resolution = New Decimal(New Integer() {5, 0, 0, 0})
        Me.PIDFeedbackVC75.Size = New System.Drawing.Size(162, 70)
        Me.PIDFeedbackVC75.TabIndex = 2
        Me.PIDFeedbackVC75.Text = "PID Feedback"
        Me.PIDFeedbackVC75.Value = 0R
        Me.PIDFeedbackVC75.ValueScaleFactor = New Decimal(New Integer() {146, 0, 0, 131072})
        Me.PIDFeedbackVC75.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'StartVC75Button
        '
        Me.StartVC75Button.BitNumber = CType(2UI, UInteger)
        Me.StartVC75Button.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green
        Me.StartVC75Button.CommComponent = Me.ModBusToVC75
        Me.StartVC75Button.ForeColor = System.Drawing.Color.Black
        Me.StartVC75Button.LegendPlate = MfgControl.AdvancedHMI.Controls.PushButton.LegendPlates.Large
        Me.StartVC75Button.Location = New System.Drawing.Point(522, 44)
        Me.StartVC75Button.Name = "StartVC75Button"
        Me.StartVC75Button.OutputType = MfgControl.AdvancedHMI.Controls.PushButton.OutputTypes.MomentarySet
        Me.StartVC75Button.PLCAddressClick = "48193"
        Me.StartVC75Button.PLCAddressVisible = ""
        Me.StartVC75Button.Size = New System.Drawing.Size(184, 269)
        Me.StartVC75Button.TabIndex = 3
        Me.StartVC75Button.Text = "Start VC75"
        '
        'StopVC75Button
        '
        Me.StopVC75Button.BitNumber = CType(1UI, UInteger)
        Me.StopVC75Button.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.RedMushroom
        Me.StopVC75Button.CommComponent = Me.ModBusToVC75
        Me.StopVC75Button.LegendPlate = MfgControl.AdvancedHMI.Controls.PushButton.LegendPlates.Large
        Me.StopVC75Button.Location = New System.Drawing.Point(313, 44)
        Me.StopVC75Button.Name = "StopVC75Button"
        Me.StopVC75Button.OutputType = MfgControl.AdvancedHMI.Controls.PushButton.OutputTypes.MomentarySet
        Me.StopVC75Button.PLCAddressClick = "48193"
        Me.StopVC75Button.PLCAddressVisible = ""
        Me.StopVC75Button.Size = New System.Drawing.Size(184, 269)
        Me.StopVC75Button.TabIndex = 4
        Me.StopVC75Button.Text = "Stop VC75"
        '
        'UpButton
        '
        Me.UpButton.BackColor = System.Drawing.SystemColors.Control
        Me.UpButton.CommComponent = Me.ModBusToVC75
        Me.UpButton.Highlight = False
        Me.UpButton.HighlightColor = System.Drawing.Color.Green
        Me.UpButton.Location = New System.Drawing.Point(180, 32)
        Me.UpButton.MaximumHoldTime = 3000
        Me.UpButton.MinimumHoldTime = 500
        Me.UpButton.Name = "UpButton"
        Me.UpButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.WriteValue
        Me.UpButton.PLCAddressClick = "4465"
        Me.UpButton.PLCAddressHighlight = ""
        Me.UpButton.PLCAddressSelectTextAlternate = ""
        Me.UpButton.PLCAddressText = ""
        Me.UpButton.PLCAddressVisible = ""
        Me.UpButton.SelectTextAlternate = False
        Me.UpButton.Size = New System.Drawing.Size(75, 23)
        Me.UpButton.TabIndex = 5
        Me.UpButton.Text = "Up"
        Me.UpButton.TextAlternate = Nothing
        Me.UpButton.UseVisualStyleBackColor = True
        Me.UpButton.ValueToWrite = 1000
        '
        'DownButton
        '
        Me.DownButton.BackColor = System.Drawing.SystemColors.Control
        Me.DownButton.CommComponent = Me.ModBusToVC75
        Me.DownButton.Highlight = False
        Me.DownButton.HighlightColor = System.Drawing.Color.Green
        Me.DownButton.Location = New System.Drawing.Point(180, 79)
        Me.DownButton.MaximumHoldTime = 3000
        Me.DownButton.MinimumHoldTime = 500
        Me.DownButton.Name = "DownButton"
        Me.DownButton.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.WriteValue
        Me.DownButton.PLCAddressClick = "4465"
        Me.DownButton.PLCAddressHighlight = ""
        Me.DownButton.PLCAddressSelectTextAlternate = ""
        Me.DownButton.PLCAddressText = ""
        Me.DownButton.PLCAddressVisible = ""
        Me.DownButton.SelectTextAlternate = False
        Me.DownButton.Size = New System.Drawing.Size(75, 23)
        Me.DownButton.TabIndex = 6
        Me.DownButton.Text = "Down"
        Me.DownButton.TextAlternate = Nothing
        Me.DownButton.UseVisualStyleBackColor = True
        Me.DownButton.ValueToWrite = 0
        '
        'OutputPowerVC75
        '
        Me.OutputPowerVC75.BackColor = System.Drawing.Color.Transparent
        Me.OutputPowerVC75.CommComponent = Me.ModBusToVC75
        Me.OutputPowerVC75.DecimalPosition = 0
        Me.OutputPowerVC75.ForeColor = System.Drawing.Color.LightGray
        Me.OutputPowerVC75.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.OutputPowerVC75.KeypadMaxValue = 0R
        Me.OutputPowerVC75.KeypadMinValue = 0R
        Me.OutputPowerVC75.KeypadScaleFactor = 1.0R
        Me.OutputPowerVC75.KeypadText = ""
        Me.OutputPowerVC75.KeypadWidth = 300
        Me.OutputPowerVC75.Location = New System.Drawing.Point(4, 185)
        Me.OutputPowerVC75.Name = "OutputPowerVC75"
        Me.OutputPowerVC75.NumberOfDigits = 5
        Me.OutputPowerVC75.PLCAddressKeypad = ""
        Me.OutputPowerVC75.PLCAddressText = ""
        Me.OutputPowerVC75.PLCAddressValue = "4018"
        Me.OutputPowerVC75.PLCAddressVisible = ""
        Me.OutputPowerVC75.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.OutputPowerVC75.Size = New System.Drawing.Size(162, 70)
        Me.OutputPowerVC75.TabIndex = 7
        Me.OutputPowerVC75.Text = "Output Power (w)"
        Me.OutputPowerVC75.Value = 0R
        Me.OutputPowerVC75.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.OutputPowerVC75.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'CommandedFreqVC75
        '
        Me.CommandedFreqVC75.BackColor = System.Drawing.Color.Transparent
        Me.CommandedFreqVC75.CommComponent = Me.ModBusToVC75
        Me.CommandedFreqVC75.DecimalPosition = 2
        Me.CommandedFreqVC75.ForeColor = System.Drawing.Color.LightGray
        Me.CommandedFreqVC75.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.CommandedFreqVC75.KeypadMaxValue = 0R
        Me.CommandedFreqVC75.KeypadMinValue = 0R
        Me.CommandedFreqVC75.KeypadScaleFactor = 1.0R
        Me.CommandedFreqVC75.KeypadText = Nothing
        Me.CommandedFreqVC75.KeypadWidth = 300
        Me.CommandedFreqVC75.Location = New System.Drawing.Point(4, 261)
        Me.CommandedFreqVC75.Name = "CommandedFreqVC75"
        Me.CommandedFreqVC75.NumberOfDigits = 5
        Me.CommandedFreqVC75.PLCAddressKeypad = ""
        Me.CommandedFreqVC75.PLCAddressText = ""
        Me.CommandedFreqVC75.PLCAddressValue = "40003"
        Me.CommandedFreqVC75.PLCAddressVisible = ""
        Me.CommandedFreqVC75.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CommandedFreqVC75.Size = New System.Drawing.Size(161, 70)
        Me.CommandedFreqVC75.TabIndex = 8
        Me.CommandedFreqVC75.Text = "Commanded Frequency"
        Me.CommandedFreqVC75.Value = 0R
        Me.CommandedFreqVC75.ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CommandedFreqVC75.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(312, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 24)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "VC75"
        '
        'StartSV65Button
        '
        Me.StartSV65Button.BitNumber = CType(4UI, UInteger)
        Me.StartSV65Button.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green
        Me.StartSV65Button.CommComponent = Me.ModBusToSV65
        Me.StartSV65Button.LegendPlate = MfgControl.AdvancedHMI.Controls.PushButton.LegendPlates.Large
        Me.StartSV65Button.Location = New System.Drawing.Point(522, 366)
        Me.StartSV65Button.Name = "StartSV65Button"
        Me.StartSV65Button.OutputType = MfgControl.AdvancedHMI.Controls.PushButton.OutputTypes.SetTrue
        Me.StartSV65Button.PLCAddressClick = "40002"
        Me.StartSV65Button.PLCAddressVisible = ""
        Me.StartSV65Button.Size = New System.Drawing.Size(184, 269)
        Me.StartSV65Button.TabIndex = 12
        Me.StartSV65Button.Text = "Start SV65"
        '
        'StopSV65Button
        '
        Me.StopSV65Button.BitNumber = CType(3UI, UInteger)
        Me.StopSV65Button.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.RedMushroom
        Me.StopSV65Button.CommComponent = Me.ModBusToSV65
        Me.StopSV65Button.LegendPlate = MfgControl.AdvancedHMI.Controls.PushButton.LegendPlates.Large
        Me.StopSV65Button.Location = New System.Drawing.Point(313, 366)
        Me.StopSV65Button.Name = "StopSV65Button"
        Me.StopSV65Button.OutputType = MfgControl.AdvancedHMI.Controls.PushButton.OutputTypes.SetTrue
        Me.StopSV65Button.PLCAddressClick = "40002"
        Me.StopSV65Button.PLCAddressVisible = ""
        Me.StopSV65Button.Size = New System.Drawing.Size(184, 269)
        Me.StopSV65Button.TabIndex = 13
        Me.StopSV65Button.Text = "Stop SV65"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(313, 331)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 24)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "SV65"
        '
        'VacuumController
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 647)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StopSV65Button)
        Me.Controls.Add(Me.StartSV65Button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CommandedFreqVC75)
        Me.Controls.Add(Me.OutputPowerVC75)
        Me.Controls.Add(Me.DownButton)
        Me.Controls.Add(Me.UpButton)
        Me.Controls.Add(Me.StopVC75Button)
        Me.Controls.Add(Me.StartVC75Button)
        Me.Controls.Add(Me.PIDFeedbackVC75)
        Me.Controls.Add(Me.PIDSetpointVC75)
        Me.Name = "VacuumController"
        Me.Text = "Vacuum Controller"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ModBusToVC75 As AdvancedHMIDrivers.ModbusRTU.ModbusRTUCom
    Friend WithEvents ModBusToSV65 As AdvancedHMIDrivers.ModbusRTU.ModbusRTUCom
    Friend WithEvents Label2 As Label
    Friend WithEvents StopSV65Button As AdvancedHMIControls.MomentaryBitButton
    Friend WithEvents StartSV65Button As AdvancedHMIControls.MomentaryBitButton
    Friend WithEvents Label1 As Label
    Friend WithEvents CommandedFreqVC75 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents OutputPowerVC75 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents DownButton As AdvancedHMIControls.BasicButton
    Friend WithEvents UpButton As AdvancedHMIControls.BasicButton
    Friend WithEvents StopVC75Button As AdvancedHMIControls.MomentaryBitButton
    Friend WithEvents StartVC75Button As AdvancedHMIControls.MomentaryBitButton
    Friend WithEvents PIDFeedbackVC75 As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents PIDSetpointVC75 As AdvancedHMIControls.DigitalPanelMeter
End Class
