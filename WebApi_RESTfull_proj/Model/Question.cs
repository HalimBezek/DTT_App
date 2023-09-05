namespace DTT_Question_Api.Model
{
	public class Question
	{
		public int Id{ get; set; }
		public string Title { get; set; }
		public int Number{ get; set; }
		public int UnitId { get; set; }
		public virtual ICollection<Choices> Answers { get; set; }
	}
}
