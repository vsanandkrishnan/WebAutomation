using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WebAutomation.DataSets.UserClasses
{
	[XmlRoot(ElementName = "UserDetails")]
	public class UserDetails
	{
		[XmlElement(ElementName = "User")]
		public List<User> User { get; set; }
	}
}
