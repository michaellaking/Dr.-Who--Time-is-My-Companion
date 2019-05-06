/*
    Author: Michael Laking
    ID:     00775971
    Date:   December, 2018

    Purpose: This class contiains the attributes used to describe an Episode Object.
             Including, Story, Season, Year, and Title

*/
using System;

public class Episode
{
    public string Story { get; private set; }
    public string Season { get; private set; }
    public string Year { get; private set; }
    public string Title { get; private set; }

    public Episode(string story, string season, string year, string title)
	{
        Story = story;
        Season = season;
        Year = year;
        Title = title;
    }
 }
