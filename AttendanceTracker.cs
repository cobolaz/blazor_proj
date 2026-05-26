public class AttendanceTracker
{
    private readonly Dictionary<int, HashSet<string>> _attendance = new();

    public void MarkAttendance(int eventId, string email)
    {
        if (!_attendance.ContainsKey(eventId))
            _attendance[eventId] = new HashSet<string>();

        _attendance[eventId].Add(email);
    }

    public int GetAttendanceCount(int eventId)
        => _attendance.TryGetValue(eventId, out var set) ? set.Count : 0;

    public IEnumerable<string> GetAttendees(int eventId)
        => _attendance.TryGetValue(eventId, out var set) ? set : Enumerable.Empty<string>();
}
