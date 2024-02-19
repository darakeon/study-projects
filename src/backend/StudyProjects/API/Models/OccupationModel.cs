namespace API.Models;

public class OccupationModel
{
	public OccupationModel(Int32 id, String task, DateTime start, DateTime end)
	{
		ID = id;
		Task = task;
		Start = start;
		End = end;
	}

	public Int32 ID { get; set; }
	public String Task { get; set; }
	public DateTime Start { get; set; }
	public DateTime End { get; set; }
}
