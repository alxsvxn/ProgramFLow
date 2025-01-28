Option Strict On
Option Explicit On
Option Compare Text

'Alexis Villagran
'RCET
'1/27/2013
'Program Flow

Imports System.Linq.Expressions

Module ProgramFlow

    Sub Main()
        'Dim num1 As Integer
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

        '    Do
        '        Console.WriteLine("Please enter your age:")
        '        userInput = Console.ReadLine()

        '        Try 'Try will run this code first and read the userinput to see if it's a valid integer or "Q" 
        '            num1 = CInt(userInput)
        '            Select Case num1
        '                Case 0 To 3
        '                    Console.WriteLine("TOO TINY!")
        '                Case 4 To 10
        '                    Console.WriteLine("You're still to young to enter.")
        '                Case 11 To 64
        '                    Console.WriteLine("Enjoy the ride!")
        '                Case 65 To 99
        '                    Console.WriteLine("Please sign this liability release form")
        '                Case > 100
        '                    Console.WriteLine("gramps")
        '                Case Else
        '                    Console.WriteLine("Invalid")
        '            End Select
        '        Catch ex As Exception 'If user entered non-integer, it reiterate input
        '            Console.WriteLine($"You entered {userInput}.")
        '        End Try

        '    Loop Until userInput = "Q"

        '    Console.WriteLine("Have a nice day.")


        Do
            Console.WriteLine("Type sommething & Press Enter")
            userInput = Console.ReadLine()
            Console.WriteLine($"In the Do Until Loop.")
        Loop Until userInput = "Q"

        Do While userInput = "Q"
            Console.WriteLine("Type sommething & Press Enter")
            userInput = Console.ReadLine()
            Console.WriteLine($"In the Do While Loop.")
        Loop
    End Sub
End Module
