'Alexis Villagran
'RCET
'1/27/2013
'Program Flow

Option Strict On
Option Explicit On

Module ProgramFlow

    Sub Main()
        Dim num1 As Integer
        num1 = 5

        If num1 > 6 Then
            Console.WriteLine(num1 > 6)
        End If

        If num1 > 6 Then
            Console.WriteLine(num1 > 3)
        End If

        If num1 > 4 Then
            Console.WriteLine(num1 > 4)
        End If

        'If anything evaluates to true all other evaluations are skipped
        If num1 > 6 Then
            Console.WriteLine(num1 > 6)
        ElseIf num1 > 3 Then
            Console.WriteLine(num1 > 3)
        ElseIf num1 > 4 Then
            Console.WriteLine(num1 > 4)
        End If
    End Sub

End Module
