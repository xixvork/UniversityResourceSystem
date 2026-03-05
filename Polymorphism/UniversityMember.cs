namespace Polymorphism;

public abstract class UniversityMember
{
    private string _name;

    public string Name
    {
        get => _name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty.", nameof(value));

            _name = value;
        }
    }

    public string MemberId { get; }

    protected List<string> ActionLog { get; } = new List<string>();

    protected UniversityMember(string name, string memberId)
    {
        Name = name; 

        if (string.IsNullOrWhiteSpace(memberId))
            throw new ArgumentException("MemberId cannot be empty.", nameof(memberId));

        MemberId = memberId;
    }

    public virtual void PerformDuties()
    {
        if (ActionLog.Count >= 5)
            throw new InvalidOperationException("Daily action limit (5) has been reached.");
    }

}