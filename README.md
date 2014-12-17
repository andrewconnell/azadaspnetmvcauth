Azure AD Authentication using ADAL &amp; OWIN in an ASP.NET MVC project for use with the Office 365 APIs.
=========================================================================================================

> My blog post that accompanies this project:
**[Azure AD & ASP.NET MVC - Walk-Through Implementing ADAL & OWIN](http://www.andrewconnell.com/blog/azure-ad-asp-net-mvc-walkthrough-implementing-adal-owin)**

I created this sample to use in a blog post that explained how to setup an ASP.NET MVC application that used Azure AD to authenticate by leveraging the [Azure AD Authentication Library for .NET](http://msdn.microsoft.com/en-us/library/azure/jj573266.aspx) (aka: **ADAL**), the [Open Web Interface for .NET](http://owin.org/) (aka: **OWIN**) & Azure's support for [OpenID Connect](http://msdn.microsoft.com/en-us/library/azure/dn645541.aspx). It is the precursor that you would need to do in order to create a website that leveraged the [Office 365 APIs](http://msdn.microsoft.com/en-us/office/office365/howto/platform-development-overview).

I made specific commits along the way in creating this sample with verbose commit messages. So if you want to check the steps I performed in the order they were performed, make sure you [check the commit history](https://github.com/andrewconnell/azadaspnetmvcauth/commits/master) if you're interested.

To Make this Work on Your Machine
---------------------------------
You can clone / download this repository and make everything work for your environment. I've coded it up and left the commits "as-is" that I had to make it work except for one small thing (*I removed my Azure AD tenant ID from the `web.config`*).

In order for you to get this working in your environment you need to do the following:

> This assumes you already have an Azure subscription.

1. Open the `web.config` file in the project and either *REMOVE* the following app settings or clear their values out:
  - **ida:ClientId**
  - **ida:Password**
1. Open the `packages.config` file in the project and remove all lines that have **O365** in them... there should be two of them.
1. Obtain your Azure AD tenant ID, a *GUID*, and insert it into the app setting **ida:TenantId** in the `web.config`.
1. Run NuGet package restore to download all the NuGet packages. 

    > You *may* get a few errors if you try to build the project right now... don't worry about that for now as in the next step you will add the Office 365 NuGet packages & assembly references.

1. Run through the **Add => Connected Service** wizard in the project that will create the Azure AD application and update the `web.config` with the application's **ClientId** and **Password**.

What this does is remove all references to the Azure AD application I created when building this sample & the blog post (*step 1 above*). It then removes all instances of the Office 365 NuGet packages. These are changing frequently and by removing them & allowing the **Add => Connected Service** wizard to not only add them back, but add the most recent versions available.