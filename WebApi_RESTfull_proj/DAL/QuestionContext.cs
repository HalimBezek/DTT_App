using Microsoft.EntityFrameworkCore;

namespace DTT_Question_Api.DAL
{
	public class QuestionContext:DbContext
	{
		public QuestionContext() : base("QuestionContext")
		{
		}
	}
}
