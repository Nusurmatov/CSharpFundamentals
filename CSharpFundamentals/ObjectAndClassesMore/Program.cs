﻿using System;

public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum) => shirtNum switch{
        1 => "goalie",
        2 => "left back",
        3 or 4 => "center back",
        5 => "right back",
        6 or 7 or 8 => "midfielder",
        9 => "left wing",
        10 => "striker",
        11 => "right wing",
        _ => throw new ArgumentOutOfRangeException()
    };

    public static string AnalyzeOffField(object report) => report switch
    {
        int number => $"There are {number} supporters at the match.",
        string announcement => announcement,
        _ => throw new ArgumentException()
    };
}

public class Incident
{

}

public class Foul : Incident
{

}

public class Injury : Incident
{
    public int ShirtNum { get; private set; }

    public Injury(int shirtNum)
    {
        
    }
}