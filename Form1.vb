Public Class Form1

    Dim v(5) As Integer
    Dim may(5) As Integer
    Dim men(5) As Integer
    Dim i As Integer
    Dim cadena As String
    Dim random As New Random
    Dim suma As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()

        For i = 0 To 4
            v(i) = random.Next(0, 9)
            cadena = cadena & v(i) & " "
            suma = suma + v(i)

        Next
        suma = suma / 5

        cadena = cadena & vbNewLine


        For i = 0 To 4

            If (v(i) <= suma) Then
                men(i) = v(i)
                cadena = cadena & "La candena men es = " & men(i) & vbNewLine
            Else

                may(i) = v(i)

                cadena = cadena & "La candena may es = " & may(i) & vbNewLine


            End If


        Next


        TextBox1.Text = "la media es = " & suma & vbNewLine & cadena

    End Sub
End Class
