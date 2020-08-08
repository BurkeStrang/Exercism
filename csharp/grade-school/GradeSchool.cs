using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

public sealed class GradeSchool
{
	private readonly IDictionary<int, ISet<string>> _roster = new ConcurrentDictionary<int, ISet<string>>();
	
    public void Add(string student, int grade)
    {
	    if (!_roster.ContainsKey(grade))
	    {
		    _roster[grade] = new SortedSet<string>();
	    }

	    _roster[grade].Add(student);
    }

    public IEnumerable<string> Roster()
    {
	    return _roster.Values.SelectMany(gradeRoster => gradeRoster);
    }

    public IEnumerable<string> Grade(int grade)
    {
	    return _roster.ContainsKey(grade) ? _roster[grade] : Enumerable.Empty<string>();
    }
}