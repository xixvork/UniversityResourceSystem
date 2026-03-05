namespace Polymorphism;

public class Professor : UniversityMember
{
    public Professor(string name, string memberId) :  base(name, memberId) {}

    public override void PerformDuties()
    {
        base.PerformDuties();
        ActionLog.Add("Lecture delivered");
    }

    public void ConductResearch(string topic)
    {
        if (string.IsNullOrWhiteSpace(topic))
            throw new ArgumentException("Topic cannot be empty.", nameof(topic));

        base.PerformDuties();
        ActionLog.Add($"Research conducted: {topic}");
    }
}