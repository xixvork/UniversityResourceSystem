namespace Polymorphism;

using System;
using System.Collections.Generic;

public class UniversityRegistry
{
    private readonly List<UniversityMember> members = new List<UniversityMember>();

    public void AddMember(UniversityMember m)
    {
        if (m is null)
            throw new ArgumentNullException(nameof(m));

        members.Add(m);
    }

    public void ExecuteAllDuties()
    {
        foreach (var m in members)
        {
            m.PerformDuties();
        }
    }

    public int GetMemberStatistics()
    {
        int total = 0;

        foreach (var m in members)
        {
            total += m.TotalActions; 
        }

        return total;
    }
}