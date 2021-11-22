using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WebAutomation.DataSets.UserClasses
{
	[XmlRoot(ElementName = "User")]
	public class User
	{
		[XmlElement(ElementName = "UserId")]
		public string UserId { get; set; }
		[XmlElement(ElementName = "UserName")]
		public string UserName { get; set; }
		[XmlElement(ElementName = "Password")]
		public string Password { get; set; }
		[XmlElement(ElementName = "PassWord")]
		public string PassWord { get; set; }
	}

}
