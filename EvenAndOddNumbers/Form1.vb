Public Class Form1

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim evenNums As Integer
        Dim oddNums As Integer
        Dim returnEvenOdd As String = Nothing
        Dim numbers(9) As Integer
        Me.lstDisplay.Items.Clear()

        For index As Integer = 0 To 9
            numbers(index) = RndInt(1, 99)
        Next

        Call EvenOddNums(numbers, evenNums, oddNums, returnEvenOdd)
        Call DisplayArray(Me.lstDisplay, numbers, returnEvenOdd)

    End Sub
    '********************************************************************************************
    'RndInt
    'Returns a random integer between max and min
    '
    'post:  A number is returned
    '********************************************************************************************
    Function RndInt(ByVal min As Integer, ByVal max As Integer) As Integer
        Randomize()
        Return Int((max - min + 1) * Rnd() + min)
    End Function
    '********************************************************************************************
    'DisplayArray
    'Displays the contents of the passed array in the passed list box values index
    '
    'post:  Array results displayed in list box 
    '********************************************************************************************
    Sub DisplayArray(ByRef lstbox As ListBox, ByRef array() As Integer, ByVal EvenOdd As String)
        For index As Integer = 0 To array.Length - 1
            lstbox.Items.Add(index & vbTab & array(index) & vbCrLf & EvenOdd)
        Next
    End Sub
    '********************************************************************************************
    'EvenOddNums
    'sorts even and odd numbers
    '
    'post: returns even and odd values in a string
    '********************************************************************************************
    Sub EvenOddNums(ByRef array() As Integer, ByRef even As Integer, ByRef odd As Integer, _
                    ByRef returnValue As String)
        For i As Integer = 0 To array.Length - 1
            If array(i) Mod 2 = 0 Then
                even &= array(i) & vbCrLf
            Else
                odd &= array(i) & vbCrLf    'Error at i = 7
            End If
        Next
        returnValue = "Even numbers in the array:" & vbCrLf & even & _
            "Odd numbers in the array:" & vbCrLf & odd
    End Sub
End Class
