/*
    Author: Michael Laking
    ID:     00775971
    Date:   December, 2018

    Purpose: This class contains the attributes used to describe a Doctor Object.
             Including Ordinal, Actor, Series, Age, and Debut.

*/
using System;

public class Doctor
{
    public string Ordinal { get; set; }
    public string Actor { get; set; }
    public string Series { get; set; }
    public string Age { get; set; }
    public string Debut { get; set; }

	public Doctor(string ordinal, string actor, string series, string age, string debut )
	{
        Ordinal = ordinal;
        Actor = actor;
        Series = series;
        Age = age;
        Debut = debut;
	}



    public override string ToString()
    {
        return Ordinal + Actor + Series + Age + Debut;
    }
}
