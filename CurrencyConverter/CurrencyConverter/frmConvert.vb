Public Class frmConverter
    'Variable Declaration for Various Currencies

    Dim Nigerian_Naira As Double = 360.0
    Dim US_Dollar As Double = 1.0
    Dim Indonesian_Rupiah As Double = 13.0
    Dim Philippine_Peso As Double = 52.46
    Dim Indian_Rupee As Double = 64.88
    Dim Canadian_Dollar As Double = 1.29
    Dim Brazilian_Real As Double = 3.33
    Dim Kenyan_Shilling As Double = 100.95
    'You Can Enter More Local Currencies And Its Dollar Rate Here
   
    Function CuConverter(ByVal money As Double) As Double
        'Functions That Carries Out The Calculation
        If cmbCurrency.Text = "Nigeria" Then
            Return Math.Round(Nigerian_Naira * money, 2)
        ElseIf cmbCurrency.Text = "USA" Then
            Return Math.Round(US_Dollar * money, 2)
        ElseIf cmbCurrency.Text = "Kenyan" Then
            Return Math.Round(Kenyan_Shilling * money, 2)
        ElseIf cmbCurrency.Text = "Brazil" Then
            Return Math.Round(Brazilian_Real * money, 2)
        ElseIf cmbCurrency.Text = "Canada" Then
            Return Math.Round(Canadian_Dollar * money, 2)
        ElseIf cmbCurrency.Text = "India" Then
            Return Math.Round(Indian_Rupee * money, 2)
        ElseIf cmbCurrency.Text = "Philippine" Then
            Return Math.Round(Philippine_Peso * money, 2)
        ElseIf cmbCurrency.Text = "Indonesia" Then
            Return Math.Round(Indonesian_Rupiah * money, 2)
        End If
        'Input The Function That Carries Out The Calculation 
    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This List The Countries On The Combo Control
        cmbCurrency.Text = "Choose a Country..."
        cmbCurrency.Items.Add("USA")
        cmbCurrency.Items.Add("Nigeria")
        cmbCurrency.Items.Add("Kenyan")
        cmbCurrency.Items.Add("Canada")
        cmbCurrency.Items.Add("Brazil")
        cmbCurrency.Items.Add("India")
        cmbCurrency.Items.Add("Philippine")
        cmbCurrency.Items.Add("Indonesia")
        'Add The Country Here
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'This Clears The Field
        cmbCurrency.Text = "Choose One..."
        lblConvert.Text = ""
        txtConvert.Text = ""
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        'This Carries Out The Conversion
        Dim British_Pounds As Double = CDbl(txtConvert.Text)
        lblConvert.Text = CStr(CuConverter(British_Pounds))

        If cmbCurrency.Text = "Nigeria" Then
            lblConvert.Text = "NGN" & " " & Val(lblConvert.Text)
        ElseIf cmbCurrency.Text = "USA" Then
            lblConvert.Text = "$" & " " & Val(lblConvert.Text)
        ElseIf cmbCurrency.Text = "Kenyan" Then
            lblConvert.Text = "KES" & " " & Val(lblConvert.Text)
        ElseIf cmbCurrency.Text = "Brazil" Then
            lblConvert.Text = "BRL" & " " & Val(lblConvert.Text)
        ElseIf cmbCurrency.Text = "Canada" Then
            lblConvert.Text = "C$" & " " & Val(lblConvert.Text)
        ElseIf cmbCurrency.Text = "India" Then
            lblConvert.Text = "INR" & " " & Val(lblConvert.Text)
        ElseIf cmbCurrency.Text = "Philippine" Then
            lblConvert.Text = "PHP" & " " & Val(lblConvert.Text)
        ElseIf cmbCurrency.Text = "Indonesia" Then
            'Include The Code That Carries Out The Conversion For The Country Added
            lblConvert.Text = "IDR" & " " & Val(lblConvert.Text)
        ElseIf cmbCurrency.Text = "Choose One..." Then
            MsgBox("Select a country of your choice", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'This Exit The Entire Window
        End
    End Sub

    Private Sub txtConvert_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConvert.KeyPress
        'Textbox Retricted Only To Accept Numbers Only
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") Then
            txtConvert.Text = ""
            e.Handled = True
        End If
    End Sub
End Class
