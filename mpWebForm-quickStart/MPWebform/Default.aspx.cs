using ServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

	protected void onSoapClick(object sender, EventArgs e)
	{
		const string username = "username";
		const string password = "password";
		const string from = "5000...";
		const string to = "09123456789";
		const string text = "تست وب سرویس ملی پیامک";
		const bool isFlash = false;
		SendSoapClient soapClient = new SendSoapClient();
		var result = soapClient.SendSimpleSMS2(username, password, to, from, text, isFlash);
	}

	protected void onSoapAsyncClick(object sender, EventArgs e)
	{
		const string username = "username";
		const string password = "password";
		const string from = "5000...";
		const string to = "09123456789";
		const string text = "تست وب سرویس ملی پیامک";
		const bool isFlash = false;
		SendSoapClient soapClient = new SendSoapClient();
		var result = soapClient.SendSimpleSMS2Async(username, password, to, from, text, isFlash);
	}

	protected void onRestClick(object sender, EventArgs e)
	{
		const string username = "username";
		const string password = "password";
		const string from = "5000...";
		const string to = "09123456789";
		const string text = "تست وب سرویس ملی پیامک";
		const bool isFlash = false;
		RestClient restClient = new RestClient(username, password);
		var result = restClient.Send(to, from, text, isFlash);
	}

	protected void onRestAsyncClick(object sender, EventArgs e)
	{
		const string username = "username";
		const string password = "password";
		const string from = "5000...";
		const string to = "09123456789";
		const string text = "تست وب سرویس ملی پیامک";
		const bool isFlash = false;
		RestClientAsync restClient = new RestClientAsync(username, password);
		var result = restClient.SendAsync(to, from, text, isFlash);
	}
}