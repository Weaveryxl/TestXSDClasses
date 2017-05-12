using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TestXSDClasses
{
  [XmlRoot("Customer", Namespace = "http://antra.net")]
  public class Customer
  {
    private string _firstName;
    private string _middleName;
    private string _lastName;

    public string LastName
    {
	 get { return _lastName; }
	 set { _lastName = value; }
    }

    public string FirstName
    {
	 get { return _firstName; }
	 set { _firstName = value; }
    }

    public string MiddleName
    {
	 get { return _middleName; }
	 set { _middleName = value; }
    }

    [XmlIgnore]

    public string Name
    {
	 get
	 {
	   if (string.IsNullOrEmpty(MiddleName) == false)
		return string.Format("{0} {1} {2}", FirstName, MiddleName, LastName);
	   else return string.Format("{0} {1}", FirstName, LastName);
	 }
    }
  }
}
