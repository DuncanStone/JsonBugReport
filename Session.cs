using System;
using System.Collections.Generic;

#nullable disable

namespace JsonBugReport.Models
{
	public partial class Session
	{
		public Guid SessionId { get; set; }
		public string Title { get; set; }
		public int Index { get; set; }
		public string PublishedStreamUrl { get; set; }
		public DateTime Created { get; set; }
		public DateTime Uploaded { get; set; }
		public DateTime LastModified { get; set; }
		public string Version { get; set; }

		public Guid ProjectId { get; set; }
	}
}
