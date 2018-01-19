INTRODUCTION
========================================================================
This SDK provides an easy-to-use client for the Questrade API, 
offering C#/.NET and Excel developers convenient access to our trading platform.

The SDK allows software application to execute trades directly through 
the Questrade REST API in your application. 

Following functional areas are covered:

 - Authentication
 - Account Data
 - Market Data
 - Placing Orders

Please refer to Developer Portal for additional information and services provided:
http://developer.questrade.com/


REQUIREMENTS
========================================================================
SDK requires Visual .NET Framework 4.5 from Microsoft, 
available for download from following location:
http://www.microsoft.com/en-us/download/details.aspx?id=40773

As development environment Microsoft Visual Studio 2012 or higher is recommended.


FOLDER STRUCTURE
========================================================================
\ 			- QuestradeApi.NET.dll library assembly, to be used for development and debugging
Release\	- QuestradeApi.NET.dll library assembly, for distribution, non-debug-able
Samples 	
 \CSharp 	- sample TestClient project, to demonstrate functionality in .NET
 \Excel 	- sample Excel file, to demonstrate functionality using ActiveX
EULA.pdf  	-  End user license agreement

GETTING STARTED 
========================================================================
Step 1) Authenticate

Similar to web interface, pass the refresh_token as refreshToken. 
and specify true if this is Practice account, or false for Live.

...  = AuthAgent.GetInstance().Authenticate(refreshToken, true);

Validate the result by checking AuthenticationInfoImplementation::isValid property. 
If this property value is false then token and/or consumer key was 
invalid or became invalid before this attempt.

Step 2) Once a valid AuthenticationInfoImplementation object is created

At this point, library is initialized and a session is established using provided key.
Application can start making calls to any of functions in API library to retrieve 
account data, market data, place trades, etc.

All API functions require always authentication object to be supplied, 
and generally have additional parameters.

Some calls might require parameters, such as:
 - Account Number is extracted from GetAccounts
 - Symbol ID is extracted from SearchSymbols or GetOptions
 - Primary and Secondary routes are extracted from GetMarkets
 - Order ID is extracted from any Response that has OrderData in it.

Asynchronous Calls
=====================================================================
Asynchronous method of calling API functions is supported. 

The implementation follows Asynchronous Programming Model (APM) by Microsoft:
https://msdn.microsoft.com/en-us/library/ms228963(v=vs.110).aspx

For example:

1. Start asynchronous call:
	
	SomeObject.BeginInvoke(new AsyncCallback(SomeMethod), ...);

	
2. In callback method:
	private void SomeMethod(IAsyncResult asyncResult)
	{
		... // handle result
		
		EndInvoke(asyncResult);
	}

Please note that application always needs to check response isValid property.
If the result is false, a problem has occurred and application needs to 
check AuthenticationInfoImplementation::isValid, as session might have expired 
or has been revoked by client. In particular, user would need to obtain manually 
a new refresh token. If AuthenticationInfo is valid, then application needs to 
check the error code and message in the response. 

Note: Error code and message may be still filled out even in valid responses.
These are cases of order being rejected due to business issues, etc.

========================================================================
Please refer to sample TestClient application for more details on usage.
