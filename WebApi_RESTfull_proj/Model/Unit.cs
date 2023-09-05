namespace DTT_Question_Api.Model
{
	public class Unit
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public virtual ICollection<Choices> Ouestions { get; set; }
		public bool IsThatFinish { get; set; }

	}
}
