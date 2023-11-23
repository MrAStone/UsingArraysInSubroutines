Module Module1

    Sub Main()
        Dim a(10) As String
        Dim b = createMyStringArray(20)
        printArray(a)
        printArray(b)
    End Sub
    Sub printArray(myArray() As String)
        For i = 0 To myArray.Length - 1
            Console.WriteLine(myArray(i))
        Next
    End Sub
    Function createMyStringArray(n As Integer) As String()
        Dim aNewArrayToCreate(n) As String
        'code to fill the array
        Return aNewArrayToCreate

    End Function


End Module
