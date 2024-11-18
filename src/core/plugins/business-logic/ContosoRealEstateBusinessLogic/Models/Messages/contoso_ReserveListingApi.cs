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
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("contoso_ReserveListingApi")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("Dataverse Model Builder", "2.0.0.11")]
	public partial class contoso_ReserveListingApiRequest : Microsoft.Xrm.Sdk.OrganizationRequest
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
		
		public int Guests
		{
			get
			{
				if (this.Parameters.Contains("Guests"))
				{
					return ((int)(this.Parameters["Guests"]));
				}
				else
				{
					return default(int);
				}
			}
			set
			{
				this.Parameters["Guests"] = value;
			}
		}
		
		public string DataverseUserId
		{
			get
			{
				if (this.Parameters.Contains("DataverseUserId"))
				{
					return ((string)(this.Parameters["DataverseUserId"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["DataverseUserId"] = value;
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
		
		public contoso_ReserveListingApiRequest()
		{
			this.RequestName = "contoso_ReserveListingApi";
			this.FromDate = default(System.DateTime);
			this.ToDate = default(System.DateTime);
			this.Guests = default(int);
			this.DataverseUserId = default(string);
			this.ListingID = default(string);
		}
	}
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/new/")]
	[Microsoft.Xrm.Sdk.Client.ResponseProxyAttribute("contoso_ReserveListingApi")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("Dataverse Model Builder", "2.0.0.11")]
	public partial class contoso_ReserveListingApiResponse : Microsoft.Xrm.Sdk.OrganizationResponse
	{
		
		public contoso_ReserveListingApiResponse()
		{
		}
		
		public decimal Amount
		{
			get
			{
				if (this.Results.Contains("Amount"))
				{
					return ((decimal)(this.Results["Amount"]));
				}
				else
				{
					return default(decimal);
				}
			}
		}
		
		public System.Guid ReservationId
		{
			get
			{
				if (this.Results.Contains("ReservationId"))
				{
					return ((System.Guid)(this.Results["ReservationId"]));
				}
				else
				{
					return default(System.Guid);
				}
			}
		}
		
		public string ReservationNumber
		{
			get
			{
				if (this.Results.Contains("ReservationNumber"))
				{
					return ((string)(this.Results["ReservationNumber"]));
				}
				else
				{
					return default(string);
				}
			}
		}
	}
}
#pragma warning restore CS1591
