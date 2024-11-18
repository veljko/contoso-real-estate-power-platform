#pragma warning disable CS1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContosoRealEstate.BusinessLogic.Models
{
	
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/new/")]
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("contoso_IsListingAvailableAPI")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("Dataverse Model Builder", "2.0.0.11")]
	public partial class contoso_IsListingAvailableAPIRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public System.DateTime FromDate
		{
			get
			{
				if (this.Parameters.Contains("FromDate"))
				{
					return ((System.DateTime)(this.Parameters["FromDate"]));
				}
				else
				{
					return default(System.DateTime);
				}
			}
			set
			{
				this.Parameters["FromDate"] = value;
			}
		}
		
		public System.DateTime ToDate
		{
			get
			{
				if (this.Parameters.Contains("ToDate"))
				{
					return ((System.DateTime)(this.Parameters["ToDate"]));
				}
				else
				{
					return default(System.DateTime);
				}
			}
			set
			{
				this.Parameters["ToDate"] = value;
			}
		}
		
		public string ListingID
		{
			get
			{
				if (this.Parameters.Contains("ListingID"))
				{
					return ((string)(this.Parameters["ListingID"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["ListingID"] = value;
			}
		}
		
		public string ExcludeReservation
		{
			get
			{
				if (this.Parameters.Contains("ExcludeReservation"))
				{
					return ((string)(this.Parameters["ExcludeReservation"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["ExcludeReservation"] = value;
			}
		}
		
		public contoso_IsListingAvailableAPIRequest()
		{
			this.RequestName = "contoso_IsListingAvailableAPI";
			this.FromDate = default(System.DateTime);
			this.ToDate = default(System.DateTime);
			this.ListingID = default(string);
			this.ExcludeReservation = default(string);
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/new/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("contoso_IsListingAvailableAPI")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("Dataverse Model Builder", "2.0.0.11")]
	public partial class contoso_IsListingAvailableAPIResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public contoso_IsListingAvailableAPIResponse()
		{
		}
		
		public bool Available
		{
			get
			{
				if (this.Results.Contains("Available"))
				{
					return ((bool)(this.Results["Available"]));
				}
				else
				{
					return default(bool);
				}
			}
		}
	}
}
#pragma warning restore CS1591
