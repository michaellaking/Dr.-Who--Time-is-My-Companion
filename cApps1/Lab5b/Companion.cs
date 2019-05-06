/*
    Author: Michael Laking
    ID:     00775971
    Date:   December, 2018

    Purpose: This class contains the attributes used to describe a Companion Object.
             Including Name, Actor, Doctor, and Debut.

*/
using System;

public class Companion
{
    public string Name { get; set; }
    public string Actor { get; set; }
    public string Doctor { get; set; }
    public string Debut { get; set; }

	public Companion( string name, string actor, string doctor, string debut)
	{
        Name = name;
        Actor = actor;
        Doctor = doctor;
        Debut = debut;

	}


    public override string ToString ()
    {
        return Name + Actor + Doctor + " " + Debut;
    }
}
