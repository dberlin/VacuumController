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
        Me.DownButton = New AdvancedHMIControls.BasicButton()
        Me.UpButton = New AdvancedHMIControls.BasicButton()
        Me.StopButton = New AdvancedHMIControls.MomentaryBitButton()
        Me.StartButton = New AdvancedHMIControls.MomentaryBitButton()
        Me.PIDFeedback = New AdvancedHMIControls.DigitalPanelMeter()
        Me.PIDSetpoint = New AdvancedHMIControls.DigitalPanelMeter()
        Me.DigitalPanelMeter1 = New AdvancedHMIControls.DigitalPanelMeter()
        Me.SuspendLayout()
        '
        'ModBusToVC75
        '
        Me.ModBusToVC75.BaudRate = 38400
        Me.ModBusToVC75.DataBits = 8
        Me.ModBusToVC75.DisableSubscriptions = False
        Me.ModBusToVC75.Parity = System.IO.Ports.Parity.None
        Me.ModBusToVC75.PollRateOverride = 100
        Me.ModBusToVC75.PortName = "COM3"
        Me.ModBusToVC75.StationAddress = CType(100, Byte)
        Me.ModBusToVC75.StopBits = System.IO.Ports.StopBits.One
        Me.ModBusToVC75.SwapBytes = True
        Me.ModBusToVC75.SwapWords = False
        Me.ModBusToVC75.SynchronizingObject = Me
        '
        'DownButton
        '
        Me.DownButton.BackColor = System.Drawing.SystemColors.Control
        Me.DownButton.CommComponent = Me.ModBusToVC75
        Me.DownButton.Highlight = False
        Me.DownButton.HighlightColor = System.Drawing.Color.Green
        Me.DownButton.Location = New System.Drawing.Point(188, 59)
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
        'UpButton
        '
        Me.UpButton.BackColor = System.Drawing.SystemColors.Control
        Me.UpButton.CommComponent = Me.ModBusToVC75
        Me.UpButton.Highlight = False
        Me.UpButton.HighlightColor = System.Drawing.Color.Green
        Me.UpButton.Location = New System.Drawing.Point(188, 12)
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
        'StopButton
        '
        Me.StopButton.BitNumber = CType(1UI, UInteger)
        Me.StopButton.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.RedMushroom
        Me.StopButton.CommComponent = Me.ModBusToVC75
        Me.StopButton.LegendPlate = MfgControl.AdvancedHMI.Controls.PushButton.LegendPlates.Large
        Me.StopButton.Location = New System.Drawing.Point(320, 12)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.OutputType = MfgControl.AdvancedHMI.Controls.PushButton.OutputTypes.MomentarySet
        Me.StopButton.PLCAddressClick = "48193"
        Me.StopButton.PLCAddressVisible = ""
        Me.StopButton.Size = New System.Drawing.Size(184, 269)
        Me.StopButton.TabIndex = 4
        Me.StopButton.Text = "Stop"
        '
        'StartButton
        '
        Me.StartButton.BitNumber = CType(2UI, UInteger)
        Me.StartButton.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green
        Me.StartButton.CommComponent = Me.ModBusToVC75
        Me.StartButton.ForeColor = System.Drawing.Color.Black
        Me.StartButton.LegendPlate = MfgControl.AdvancedHMI.Controls.PushButton.LegendPlates.Large
        Me.StartButton.Location = New System.Drawing.Point(535, 12)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.OutputType = MfgControl.AdvancedHMI.Controls.PushButton.OutputTypes.MomentarySet
        Me.StartButton.PLCAddressClick = "48193"
        Me.StartButton.PLCAddressVisible = ""
        Me.StartButton.Size = New System.Drawing.Size(184, 269)
        Me.StartButton.TabIndex = 3
        Me.StartButton.Text = "Start"
        '
        'PIDFeedback
        '
        Me.PIDFeedback.BackColor = System.Drawing.Color.Transparent
        Me.PIDFeedback.CommComponent = Me.ModBusToVC75
        Me.PIDFeedback.DecimalPosition = 2
        Me.PIDFeedback.ForeColor = System.Drawing.Color.LightGray
        Me.PIDFeedback.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.PIDFeedback.KeypadMaxValue = 0R
        Me.PIDFeedback.KeypadMinValue = 0R
        Me.PIDFeedback.KeypadScaleFactor = 1.0R
        Me.PIDFeedback.KeypadText = Nothing
        Me.PIDFeedback.KeypadWidth = 300
        Me.PIDFeedback.Location = New System.Drawing.Point(12, 88)
        Me.PIDFeedback.Name = "PIDFeedback"
        Me.PIDFeedback.NumberOfDigits = 5
        Me.PIDFeedback.PLCAddressKeypad = ""
        Me.PIDFeedback.PLCAddressText = ""
        Me.PIDFeedback.PLCAddressValue = "4384"
        Me.PIDFeedback.PLCAddressVisible = ""
        Me.PIDFeedback.Resolution = New Decimal(New Integer() {5, 0, 0, 0})
        Me.PIDFeedback.Size = New System.Drawing.Size(162, 70)
        Me.PIDFeedback.TabIndex = 2
        Me.PIDFeedback.Text = "PID Feedback"
        Me.PIDFeedback.Value = 0R
        Me.PIDFeedback.ValueScaleFactor = New Decimal(New Integer() {1465, 0, 0, 196608})
        Me.PIDFeedback.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'PIDSetpoint
        '
        Me.PIDSetpoint.BackColor = System.Drawing.Color.Transparent
        Me.PIDSetpoint.CommComponent = Me.ModBusToVC75
        Me.PIDSetpoint.DecimalPosition = 2
        Me.PIDSetpoint.ForeColor = System.Drawing.Color.LightGray
        Me.PIDSetpoint.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.PIDSetpoint.KeypadMaxValue = 0R
        Me.PIDSetpoint.KeypadMinValue = 0R
        Me.PIDSetpoint.KeypadScaleFactor = 1.0R
        Me.PIDSetpoint.KeypadText = Nothing
        Me.PIDSetpoint.KeypadWidth = 300
        Me.PIDSetpoint.Location = New System.Drawing.Point(12, 12)
        Me.PIDSetpoint.Name = "PIDSetpoint"
        Me.PIDSetpoint.NumberOfDigits = 5
        Me.PIDSetpoint.PLCAddressKeypad = ""
        Me.PIDSetpoint.PLCAddressText = ""
        Me.PIDSetpoint.PLCAddressValue = "4465"
        Me.PIDSetpoint.PLCAddressVisible = ""
        Me.PIDSetpoint.Resolution = New Decimal(New Integer() {5, 0, 0, 0})
        Me.PIDSetpoint.Size = New System.Drawing.Size(161, 70)
        Me.PIDSetpoint.TabIndex = 1
        Me.PIDSetpoint.Text = "PID Setpoint"
        Me.PIDSetpoint.Value = 0R
        Me.PIDSetpoint.ValueScaleFactor = New Decimal(New Integer() {1465, 0, 0, 196608})
        Me.PIDSetpoint.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'DigitalPanelMeter1
        '
        Me.DigitalPanelMeter1.BackColor = System.Drawing.Color.Transparent
        Me.DigitalPanelMeter1.CommComponent = Me.ModBusToVC75
        Me.DigitalPanelMeter1.DecimalPosition = 0
        Me.DigitalPanelMeter1.ForeColor = System.Drawing.Color.LightGray
        Me.DigitalPanelMeter1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.DigitalPanelMeter1.KeypadMaxValue = 0R
        Me.DigitalPanelMeter1.KeypadMinValue = 0R
        Me.DigitalPanelMeter1.KeypadScaleFactor = 1.0R
        Me.DigitalPanelMeter1.KeypadText = ""
        Me.DigitalPanelMeter1.KeypadWidth = 300
        Me.DigitalPanelMeter1.Location = New System.Drawing.Point(12, 165)
        Me.DigitalPanelMeter1.Name = "DigitalPanelMeter1"
        Me.DigitalPanelMeter1.NumberOfDigits = 5
        Me.DigitalPanelMeter1.PLCAddressKeypad = ""
        Me.DigitalPanelMeter1.PLCAddressText = ""
        Me.DigitalPanelMeter1.PLCAddressValue = "4018"
        Me.DigitalPanelMeter1.PLCAddressVisible = ""
        Me.DigitalPanelMeter1.Resolution = New Decimal(New Integer() {1, 0, 0, 0})
        Me.DigitalPanelMeter1.Size = New System.Drawing.Size(162, 70)
        Me.DigitalPanelMeter1.TabIndex = 7
        Me.DigitalPanelMeter1.Text = "Output Power (w)"
        Me.DigitalPanelMeter1.Value = 0R
        Me.DigitalPanelMeter1.ValueScaleFactor = New Decimal(New Integer() {10, 0, 0, 0})
        Me.DigitalPanelMeter1.ValueScaleOffset = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'VacuumController
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 309)
        Me.Controls.Add(Me.DigitalPanelMeter1)
        Me.Controls.Add(Me.DownButton)
        Me.Controls.Add(Me.UpButton)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.PIDFeedback)
        Me.Controls.Add(Me.PIDSetpoint)
        Me.Name = "VacuumController"
        Me.Text = "Vacuum Controller"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ModBusToVC75 As AdvancedHMIDrivers.ModbusRTU.ModbusRTUCom
    Friend WithEvents PIDFeedback As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents PIDSetpoint As AdvancedHMIControls.DigitalPanelMeter
    Friend WithEvents StartButton As AdvancedHMIControls.MomentaryBitButton
    Friend WithEvents StopButton As AdvancedHMIControls.MomentaryBitButton
    Friend WithEvents DownButton As AdvancedHMIControls.BasicButton
    Friend WithEvents UpButton As AdvancedHMIControls.BasicButton
    Friend WithEvents DigitalPanelMeter1 As AdvancedHMIControls.DigitalPanelMeter
End Class
