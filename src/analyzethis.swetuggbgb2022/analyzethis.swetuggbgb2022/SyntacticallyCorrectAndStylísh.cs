namespace analyzethis.swetuggbgb2022;

public class SyntacticallyCorrectAndStylísh
{
    private void PerhapsNotMultiLine()
    {
        var multiVarAssignmentIsFun = 1;
        var theMoreTheMerrier = 2;
        var thisIsJustGreat = 3;
        var oneMoreWhyNot = 24;

        SurelyNoRiskForErrorsHere();

        void SurelyNoRiskForErrorsHere()
        {
            if (multiVarAssignmentIsFun == 10)
                theMoreTheMerrier = 14;
            {
                thisIsJustGreat = 54;
            };

            oneMoreWhyNot = 1;
        }

        var ILoveSignificantWhiteSpace = true;
        if (ILoveSignificantWhiteSpace == false)
            Console.WriteLine("Significant WhiteSpace is the best.");

        Console.WriteLine("Turns out white space is not significant in C#.");
        Console.WriteLine("I love when VS is helps me to propertly align my code.");

        using var disposableButIDontCare = new HttpClient();
    }

    bool? SHOULDTHISFIELDBEDOWNHERE = null;
}
