'Malachi Marlow
''Spring 2025
'RCET2265
'Address Label
'https://github.com/MalachiMarlow/Shuffle-The-Deck.git

Option Explicit On
Option Strict On
Public Class Form1

    Sub setDefaults()
        FirstNameTextBox.Text = " "
        LastNameTextBox.Text = " "
        StreetAddressTextBox.Text = " "
        CityTextBox.Text = " "
        StateTextBox.Text = " "
        ZipTextBox.Text = " "
        FirstNameTextBox.Focus()

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        DisplayLabel.Text = " "
    End Sub

    Function UserInputIsValid() As Boolean
        Dim Valid As Boolean = True
        Dim message As String
        If FirstNameTextBox.Text = "" Then
            Valid = False
            FirstNameTextBox.Focus()
            message &= "Please enter your name." & vbNewLine
        End If

        If LastNameTextBox.Text = "" Then
            Valid = False
            LastNameTextBox.Focus()
            message &= "Last name is required." & vbNewLine
        End If

        If StreetAddressTextBox.Text = "" Then
            Valid = False
            StreetAddressTextBox.Focus()
            message &= "Street address is required." & vbNewLine
        End If

        If CityTextBox.Text = "" Then
            Valid = False
            CityTextBox.Focus()
            message &= "City info is required." & vbNewLine
        End If

        If StateTextBox.Text = "" Then
            Valid = False
            StateTextBox.Focus()
            message &= "State is required." & vbNewLine
        End If

        If IsNumeric(ZipTextBox.Text) = False Then
            Valid = False
            ZipTextBox.Focus()
            message &= "Please enter a valid zip code." & vbNewLine
        End If

        If Not Valid Then
            MsgBox(message, MsgBoxStyle.Exclamation, "User Input Fail!!!")
        End If

        Return Valid
    End Function

    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        If UserInputIsValid() Then
            Format()
        End If
    End Sub

    Sub Format()
        DisplayLabel.Text = FirstNameTextBox.Text & " " & LastNameTextBox.Text & vbNewLine _
            & StreetAddressTextBox.Text & vbNewLine _
            & CityTextBox.Text & ", " & StateTextBox.Text & " " & ZipTextBox.Text
    End Sub
End Class
