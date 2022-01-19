Option Explicit On
Module Variables

    Sub Main()
        'declaring some variables
        Dim firstNumber As Integer
        Dim secondNumber As Decimal 'Use a D or @ to assign the decimal type
        Dim result As Decimal
        Dim testResult As Boolean
        Dim userInput As String
        Const TAXRATE As Decimal = 0.06D

        firstNumber = 5
        secondNumber = 38.27D
        result = firstNumber + secondNumber

        'display result to user
        Console.WriteLine(result)
        userInput = Console.ReadLine()

        'shows what the user typed
        Console.WriteLine("You typed: " & userInput)
        Console.ReadLine()

        'testResult = (5 > 4)

        'Console.WriteLine(testResult)
        'Console.ReadLine()

    End Sub

End Module
