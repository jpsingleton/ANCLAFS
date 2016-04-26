# ANCLAFS
## ASP.NET Core Library and Framework Support

In the process of writing a [book](https://www.packtpub.com/application-development/aspnet-core-10-high-performance) on ASP.NET Core and .NET Core I've done lots of research into what .NET libraries and frameworks are currently supported by these new platforms. Here are the results, hopefully you'll find this useful. Obviously these will change over time, send me a pull request if you'd like to make a correction or add something. This is a living document.

# Categories

## Experimenting
Project | NuGet Install Command | .NET Core Support | ASP.NET Core Support | Website
------- | --------------------- | ----------------- | -------------------- | -------
[Scientist.NET](https://github.com/Haacked/Scientist.net) | Install-Package Scientist -Pre | [Hypothetically](https://github.com/Haacked/Scientist.net/issues/54) | [Hypothetically](https://github.com/Haacked/Scientist.net/pull/37) | [Blog](http://haacked.com/archive/2016/01/20/scientist)

## Feature Switching
Project | NuGet Install Command | .NET Core Support | ASP.NET Core Support | Website
------- | --------------------- | ----------------- | -------------------- | -------
[FeatureSwitcher](https://github.com/mexx/FeatureSwitcher) | Install-Package FeatureSwitcher | No | No
[FeatureToggle](https://github.com/jason-roberts/FeatureToggle) | Install-Package FeatureToggle | [Planned](https://github.com/jason-roberts/FeatureToggle/issues/109) | [Planned](https://github.com/jason-roberts/FeatureToggle/issues/109) | [Blog](http://dontcodetired.com/blog/?tag=/featuretoggle)

## Profiling
Project | NuGet Install Command | .NET Core Support | ASP.NET Core Support | Website
------- | --------------------- | ----------------- | -------------------- | -------
[MiniProfiler](https://github.com/MiniProfiler/dotnet) | Install-Package MiniProfiler | [Planned for RC2](https://github.com/MiniProfiler/dotnet/issues/116) | [Planned for RC2](https://github.com/MiniProfiler/dotnet/issues/116) | [miniprofiler.com](http://miniprofiler.com)
[Glimpse](https://github.com/Glimpse/Glimpse.Prototype) | Install-Package Glimpse -Pre | [Yes (beta)](http://blog.getglimpse.com/2015/11/19/installing-glimpse-v2-beta1) | [Yes (beta)](http://blog.getglimpse.com/2015/11/19/installing-glimpse-v2-beta1) | [getglimpse.com](http://getglimpse.com)
Prefix | N/A (download installer) | [Planned for RC2](http://stackify.com/prefix-for-asp-net-core-rc1-is-available) | [Yes](http://stackify.com/prefix-for-asp-net-core-rc1-is-available) | [prefix.io](http://www.prefix.io)

## O/RMs
Project | NuGet Install Command | .NET Core Support | ASP.NET Core Support | Website
------- | --------------------- | ----------------- | -------------------- | -------
[Dapper](https://github.com/StackExchange/dapper-dot-net) | Install-Package Dapper -Pre | Yes | Yes | [github.io](https://stackexchange.github.io/dapper-dot-net)
[Simple.Data](https://github.com/markrendle/Simple.Data) | Install-Package Simple.Data.SqlServer | [Planned](https://blog.rendle.io/another-simple-data-update) | [Planned](https://blog.rendle.io/another-simple-data-update)
[EF Core](https://github.com/aspnet/EntityFramework) | Install-Package EntityFramework.MicrosoftSqlServer -Pre | Yes | Yes | [efproject.net](http://docs.efproject.net/en/latest/)

## Background Tasks
Project | NuGet Install Command | .NET Core Support | ASP.NET Core Support | Website
------- | --------------------- | ----------------- | -------------------- | -------
[Hangfire](https://github.com/HangfireIO/Hangfire) | Install-Package Hangfire | [Planned](https://github.com/HangfireIO/Hangfire/issues/365) | [Possible](https://discuss.hangfire.io/t/how-to-config-hangfire-with-asp-net-5/945) | [hangfire.io](http://hangfire.io)

## Image Manipulation
Project | NuGet Install Command | .NET Core Support | ASP.NET Core Support | Website
------- | --------------------- | ----------------- | -------------------- | -------
[ImageResizer](https://github.com/imazen/resizer) | Install-Package ImageResizer.WebConfig | No | No | [imageresizing.net](http://imageresizing.net)
[DynamicImage](https://github.com/tgjones/dynamic-image) | Install-Package DynamicImage | No | No | [dynamicimage.apphb.com](https://dynamicimage.apphb.com/)
[ImageProcessorCore](https://github.com/JimBobSquarePants/ImageProcessor/tree/Core) | Not yet ([myget](https://www.myget.org/gallery/imageprocessor)) | Yes (WIP) | Yes (WIP) | [imageprocessor.org](http://imageprocessor.org)

## Message Queuing
Project | NuGet Install Command | .NET Core Support | ASP.NET Core Support | Website
------- | --------------------- | ----------------- | -------------------- | -------

## Windows Services
Project | NuGet Install Command | .NET Core Support | ASP.NET Core Support | Website
------- | --------------------- | ----------------- | -------------------- | -------
