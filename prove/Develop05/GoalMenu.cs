using System;

public class GoalMenu
{
    private string _menu = $@"
The Types of Goals are:
    1. Simple Goal
    2. Eternal Goal
Which type of goal would you like to create?  ";

    public string _goalInput;
    private int _goalChoice = 0;

    public int GoalChoice()
    {

        Console.Write(_menu);

        _goalInput = Console.ReadLine();
        _goalChoice = 0;
        try
        {
            _goalChoice = int.Parse(_goalInput);
        }
        catch (FormatException)
        {
            _goalChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return _goalChoice;
    }



}