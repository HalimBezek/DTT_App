namespace DTT_Question_Api.Model
{
	public class Choices
	{
		public int Id { get; set; }
		public string Description{ get; set; }
		public bool IsTrue { get; set; }
		public int QuestionId { get; set; }
	}
}
