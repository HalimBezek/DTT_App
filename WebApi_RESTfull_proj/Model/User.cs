﻿namespace DTT_Question_Api.Model
{
	public class User
	{
		public int Id { get; set; }
		public string UserName { get; set; }
		public virtual ICollection<Choices> Ouestions { get; set; }

	}
}