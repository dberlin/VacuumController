Public Class VacuumController

    Private Sub PIDSetpoint_ValueChanged(sender As Object, e As EventArgs) Handles PIDSetpointVC75.ValueChanged
        UpButton.ValueToWrite = PIDSetpointVC75.Value + 5
        DownButton.ValueToWrite = PIDSetpointVC75.Value - 5
    End Sub

    Private Sub DigitalPanelMeter1_Click(sender As Object, e As EventArgs) Handles OutputPowerVC75.Click

    End Sub

    Private Sub ModBusToSV65_ConnectionEstablished(sender As Object, e As EventArgs) Handles ModBusToSV65.ConnectionEstablished
        'Unlock drive
        ModBusToSV65.Write(40049, 0)
    End Sub



    Private Sub StartSV65Button_MouseDown(sender As Object, e As MouseEventArgs) Handles StartSV65Button.MouseDown
        'Unlock drive after command
        ModBusToSV65.Write(40049, 0)

    End Sub

    Private Sub StopSV65Button_MouseDown(sender As Object, e As MouseEventArgs) Handles StopSV65Button.MouseDown
        'Unlock drive after command
        ModBusToSV65.Write(40049, 0)
    End Sub
End Class
