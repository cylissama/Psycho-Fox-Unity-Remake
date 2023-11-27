using SQLite4Unity3d;

public class UserData
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public int Score { get; set; }

    public override string ToString()
    {
        return string.Format("[UserData: Id={0}, Username={1}, Password={2}, Score={3}]", Id, Username, Password, Score);
    }
}
