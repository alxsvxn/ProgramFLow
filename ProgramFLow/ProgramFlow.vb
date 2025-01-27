'Alexis Villagran
'RCET
'1/27/2013
'Program Flow

Option Strict On
Option Explicit On

Module ProgramFlow

    Sub Main()
        Dim num1 As Integer
        Dim userInput As String

        'num1 = 5

        'If num1 > 6 Then
        '    Console.WriteLine(num1 > 6)
        'End If

        'If num1 > 6 Then
        '    Console.WriteLine(num1 > 3)
        'End If

        'If num1 > 4 Then
        '    Console.WriteLine(num1 > 4)
        'End If

        ''If anything evaluates to true all other evaluations are skipped
        'If num1 > 6 Then
        '    Console.WriteLine(num1 > 6)
        'ElseIf num1 > 3 Then
        '    Console.WriteLine(num1 > 3)
        'ElseIf num1 > 4 Then
        '    Console.WriteLine(num1 > 4)
        'End If

        'num1 -= 3
        ''If none of the conditions are true then ELse clause triggers
        'If num1 > 6 Then
        '    Console.WriteLine($"{num1} is a bigger number.")
        'ElseIf num1 > 3 Then
        '    Console.WriteLine($"Not enough.")
        'ElseIf num1 > 4 Then
        '    Console.WriteLine($"Still Not enough.")
        'Else
        '    Console.WriteLine($"Not sure what happened")
        'End If

        Console.WriteLine("Please enter your age:")
        userInput = Console.ReadLine()
        num1 = CInt(userInput)

        Select Case num1
            Case 0 To 3

            Case 4 To 10

            Case 11 To 64

            Case 65 To 99

            Case > 100

            Case Else


        End Select
    End Sub

End Module
