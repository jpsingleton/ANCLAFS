# ASP.NET Core Library and Framework Support

## Contents
 - [Experimenting](#experimenting)
 - [Feature Switching](#feature-switching)
 - [Profiling](#profiling)
 - [O/RMs / DBs](#orms--dbs)
 - [Background Tasks](#background-tasks)
 - [Image Manipulation](#image-manipulation)
 - [Message Queuing](#message-queuing)
 - [Windows Services](#windows-services)
 - [Web](#web)
 - [DI / IoC Containers](#di--ioc-containers)
 - [Logging](#logging)
 - [Serialization](#serialization)
 - [Testing](#testing)
 - [Other](#other)

## Background

In the process of writing a [book](https://unop.uk/book/) on ASP.NET Core and .NET Core, I've done lots of research into what .NET libraries and frameworks are currently supported by these new platforms. Here are the results (and more), hopefully you'll find this useful. Obviously these will change (and hopefully grow) over time. Send me a pull request if you'd like to make a correction or add something. This is a living document.

---

## Experimenting
Project | NuGet Install Command | .NET Core Support | ASP.NET Core Support | Website
------- | --------------------- | ----------------- | -------------------- | -------
[Scientist.NET](https://github.com/Haacked/Scientist.net) | Install-Package Scientist -Pre | Yes | Yes | [Blog](http://haacked.com/archive/2016/01/20/scientist)

## Feature Switching
Project | NuGet Install Command | .NET Core Support | ASP.NET Core Support | Website
------- | --------------------- | ----------------- | -------------------- | -------
[FeatureSwitcher](https://github.com/mexx/FeatureSwitcher) | Install-Package FeatureSwitcher | No | No
[FeatureToggle](https://github.com/jason-roberts/FeatureToggle) | Install-Package FeatureToggle | [WIP](https://github.com/jason-roberts/FeatureToggle/issues/109) | [WIP](https://github.com/jason-roberts/FeatureToggle/issues/109) | [Blog](http://dontcodetired.com/blog/?tag=/featuretoggle)

## Profiling
Project | NuGet Install Command | .NET Core Support | ASP.NET Core Support | Website
------- | --------------------- | ----------------- | -------------------- | -------
[MiniProfiler](https://github.com/MiniProfiler/dotnet) | Install-Package MiniProfiler | [WIP](https://github.com/MiniProfiler/dotnet/issues/116) | [WIP](https://github.com/MiniProfiler/dotnet/issues/116) | [miniprofiler.com](http://miniprofiler.com)
[Glimpse](https://github.com/Glimpse/Glimpse.Prototype) | Install-Package Glimpse -Pre | [Yes](http://blog.getglimpse.com/2015/11/19/installing-glimpse-v2-beta1) | [Yes](http://blog.getglimpse.com/2015/11/19/installing-glimpse-v2-beta1) | [getglimpse.com](http://getglimpse.com)
Prefix | N/A (download installer) | [Yes](http://stackify.com/15-lessons-learned-while-converting-from-asp-net-to-net-core/) | [Yes](http://stackify.com/prefix-for-asp-net-core-rc1-is-available) | [prefix.io](http://www.prefix.io)

## O/RMs / DBs
Project | NuGet Install Command | .NET Core Support | ASP.NET Core Support | Website
------- | --------------------- | ----------------- | -------------------- | -------
[Dapper](https://github.com/StackExchange/dapper-dot-net) | Install-Package Dapper -Pre | Yes | Yes | [github.io](https://stackexchange.github.io/dapper-dot-net)
[Simple.Data](https://github.com/markrendle/Simple.Data) | Install-Package Simple.Data.SqlServer | [WIP](https://blog.rendle.io/another-simple-data-update) | [WIP](https://blog.rendle.io/net-core-a-call-to-action/)  | [GH Issue](https://github.com/markrendle/Simple.Data/issues/389)
[EF Core](https://github.com/aspnet/EntityFramework) | Install-Package EntityFramework.MicrosoftSqlServer -Pre | Yes | Yes | [efproject.net](http://docs.efproject.net/en/latest/)
[NHibernate](https://github.com/nhibernate/nhibernate-core) |  |  |  | 
[Npgsql](https://github.com/npgsql/Npgsql) | Install-Package Npgsql | Yes | Yes | [npgsql.org](http://www.npgsql.org)
[MongoDB Driver](https://github.com/mongodb/mongo-csharp-driver) |  | [WIP](https://jira.mongodb.org/browse/CSHARP-1177) | [WIP](https://jira.mongodb.org/browse/CSHARP-1177) | [mongodb.github.io/mongo-csharp-driver](https://mongodb.github.io/mongo-csharp-driver)
[Couchbase](https://github.com/couchbase/couchbase-net-client) |  |  |  | 
[Couchbase Lite for .NET](https://github.com/couchbase/couchbase-lite-net) |  |  |  | 
[Elasticsearch.Net](https://github.com/elastic/elasticsearch-net) | Install-Package Elasticsearch.Net | ? | ? | [elastic.**co**](https://www.elastic.co)
[NEST](https://github.com/elastic/elasticsearch-net) | Install-Package NEST | ? | ? | [elastic.**co**](https://www.elastic.co)
[StackExchange.Redis](https://github.com/StackExchange/StackExchange.Redis) |  | ? | ? | 
[Lucene.NET](https://github.com/apache/lucenenet) | Install-Package Lucene.Net |  |  | [lucenenet.apache.org](https://lucenenet.apache.org)
[CassandraCSharpDriver](https://github.com/datastax/csharp-driver) | Install-Package CassandraCSharpDriver |  |  | 
[RavenDB](https://github.com/ravendb/ravendb) |  |  |  | 
[Marten](https://github.com/jasperfx/marten) | Install-Package Marten | Yes | Yes | [jasperfx.github.io/marten](http://jasperfx.github.io/marten/)

## Background Tasks
Project | NuGet Install Command | .NET Core Support | ASP.NET Core Support | Website
------- | --------------------- | ----------------- | -------------------- | -------
[Hangfire](https://github.com/HangfireIO/Hangfire) | Install-Package Hangfire | [WIP](https://github.com/HangfireIO/Hangfire/issues/365) | [No](https://discuss.hangfire.io/t/how-to-config-hangfire-with-asp-net-5/945) | [hangfire.io](http://hangfire.io)

## Image Manipulation
Project | NuGet Install Command | .NET Core Support | ASP.NET Core Support | Website
------- | --------------------- | ----------------- | -------------------- | -------
[ImageResizer](https://github.com/imazen/resizer) | Install-Package ImageResizer.WebConfig | [WIP](https://github.com/imazen/imageflow) | [WIP](https://github.com/imazen/imageflow) | [imageresizing.net](http://imageresizing.net)
[DynamicImage](https://github.com/tgjones/dynamic-image) | Install-Package DynamicImage | No | No | [dynamicimage.apphb.com](https://dynamicimage.apphb.com/)
[ImageSharp](https://github.com/JimBobSquarePants/ImageSharp) | Not yet ([myget](https://www.myget.org/gallery/imagesharp)) | WIP | WIP | [ImageSharp](https://github.com/JimBobSquarePants/ImageSharp)

## Message Queuing
Project | NuGet Install Command | .NET Core Support | ASP.NET Core Support | Website
------- | --------------------- | ----------------- | -------------------- | -------
[RestBus](https://github.com/tenor/RestBus) | Install-Package RestBus.AspNet -Pre ([guide](https://github.com/tenor/RestBus/wiki/ASP.NET-Core-service-%28RabbitMQ-callable%29)) | Yes | Yes | [restbus.org](http://restbus.org) ([Blog](http://ahuwanya.net/blog/post/Introducing-RestBus))
[EasyNetQ](https://github.com/EasyNetQ/EasyNetQ) | Install-Package EasyNetQ | [WIP](https://github.com/EasyNetQ/EasyNetQ/issues/508) | [WIP](https://github.com/EasyNetQ/EasyNetQ/issues/508) | [easynetq.com](http://easynetq.com)
[RabbitMQ client](https://github.com/rabbitmq/rabbitmq-dotnet-client) | Install-Package RabbitMQ.Client | [WIP](https://github.com/rabbitmq/rabbitmq-dotnet-client/issues/148) | [WIP](https://github.com/rabbitmq/rabbitmq-dotnet-client/issues/148) | [rabbitmq.com](https://www.rabbitmq.com/dotnet.html)
[MassTransit](https://github.com/MassTransit/MassTransit) | Install-Package MassTransit.RabbitMQ | [WIP](https://github.com/MassTransit/MassTransit/issues/527) | [WIP](https://github.com/MassTransit/MassTransit/issues/527) | [masstransit-project.com](http://masstransit-project.com)
[RdKafka](https://github.com/ah-/rdkafka-dotnet) | Install-Package RdKafka | Yes | Yes | [ah-.github.io/rdkafka-dotnet](http://ah-.github.io/rdkafka-dotnet/)
[NServiceBus](https://github.com/Particular/NServiceBus) |  |  |  | 

## Windows Services
Project | NuGet Install Command | .NET Core Support | ASP.NET Core Support | Website
------- | --------------------- | ----------------- | -------------------- | -------
[Topshelf](https://github.com/Topshelf/Topshelf) | Install-Package Topshelf | [WIP](https://github.com/Topshelf/Topshelf/issues/277) | [WIP](https://github.com/Topshelf/Topshelf/issues/277) | [topshelf-project.com](http://topshelf-project.com)

## Web
Project | NuGet Install Command | .NET Core Support | ASP.NET Core Support | Website
------- | --------------------- | ----------------- | -------------------- | -------
[Nancy](https://github.com/NancyFx/Nancy) | Install-Package Nancy -Pre | Yes | Yes | [nancyfx.org](http://nancyfx.org)
[SignalR](https://github.com/SignalR/SignalR) | Install-Package Microsoft.AspNet.SignalR | [WIP](https://github.com/aspnet/home/wiki/roadmap#future-work) | [WIP](https://github.com/aspnet/home/wiki/roadmap#future-work) | [signalr.net](http://signalr.net/)
[ReactJS.NET](https://github.com/reactjs/React.NET) | Install-Package React.AspNet | [WIP](https://github.com/reactjs/React.NET/milestone/4) | [Yes](http://reactjs.net/2016/05/2.4.0-release.html) | [ReactJS.NET](http://reactjs.net/)
[Swashbuckle](https://github.com/domaindrivendev/Ahoy) | Install-Package Swashbuckle -Pre | Yes | Yes | 

## DI / IoC Containers
Project | NuGet Install Command | .NET Core Support | ASP.NET Core Support | Website
------- | --------------------- | ----------------- | -------------------- | -------
[Windsor](https://github.com/castleproject/Windsor) | {no .NET Core support} | [WIP](https://github.com/castleproject/Core/releases/tag/v4.0.0-alpha001) | [WIP](https://github.com/castleproject/Windsor/issues/120) | [castleproject.org](http://www.castleproject.org/)
[Ninject](https://github.com/ninject/Ninject) | {no .NET Core support} | [No](https://github.com/ninject/Ninject/issues/177) | [No](https://github.com/ninject/Ninject/pull/200) | [ninject.org](http://www.ninject.org/)
[Autofac](https://github.com/autofac/Autofac) | Install-Package Autofac -Pre | [Yes](https://github.com/autofac/Autofac/pull/672) | [WIP](https://github.com/autofac/Autofac/issues/594) | [autofac.org](http://autofac.org/)
[SimpleInjector](https://github.com/simpleinjector/SimpleInjector) | Install-Package SimpleInjector -Version 3.1.5 | Yes | Yes | [simpleinjector.org](https://simpleinjector.org)
[Unity](https://github.com/unitycontainer/unity) | Install-Package Unity-CoreClr -Pre | [?](https://github.com/unitycontainer/unity/issues/42) | [?](https://github.com/unitycontainer/unity/issues/63)
[StructureMap](https://github.com/structuremap/structuremap) | Install-Package StructureMap | Yes | Yes | [structuremap.github.io](https://structuremap.github.io)
[CommonServiceLocator](https://github.com/unitycontainer/commonservicelocator) |  |  |  | 
ASP.NET Core contains built-in [DI](https://docs.asp.net/en/latest/fundamentals/dependency-injection.html)

## Logging
Project | NuGet Install Command | .NET Core Support | ASP.NET Core Support | Website
------- | --------------------- | ----------------- | -------------------- | -------
[Serilog](https://github.com/serilog/serilog) |  | ? | ? | 
[NLog](https://github.com/NLog/Nlog) |  |  |  | 
[common.logging](https://github.com/net-commons/common-logging) |  |  |  | 
[log4net](https://github.com/apache/log4net) |  |  |  | 
[ELM](https://github.com/aspnet/Diagnostics) | Install-Package Microsoft.AspNetCore.Diagnostics.Elm  |  |  | 
ASP.NET Core contains built-in [logging](https://docs.asp.net/en/latest/fundamentals/logging.html)

## Serialization
Project | NuGet Install Command | .NET Core Support | ASP.NET Core Support | Website
------- | --------------------- | ----------------- | -------------------- | -------
[JSON.NET](https://github.com/JamesNK/Newtonsoft.Json) | Install-Package Newtonsoft.Json | Yes | Yes | [newtonsoft.com/json](http://www.newtonsoft.com/json)
[Jil](https://github.com/kevin-montrose/Jil) |  | [WIP](https://github.com/kevin-montrose/Jil/pull/185) | [WIP](https://github.com/kevin-montrose/Jil/pull/185) | 
[NetJSON](https://github.com/rpgmaker/NetJSON) |  | [WIP](https://github.com/rpgmaker/NetJSON/issues/105) | [WIP](https://github.com/rpgmaker/NetJSON/issues/105) | 
[ServiceStack.Text](https://github.com/ServiceStack/ServiceStack.Text) |  | No | No | 
[Bond](https://github.com/Microsoft/bond) |  | [WIP](https://github.com/Microsoft/bond/issues/166) | [WIP](https://github.com/Microsoft/bond/issues/166) | 
[protobuf-net](https://github.com/mgravell/protobuf-net) | Install-Package protobuf-net | [No](https://github.com/mgravell/protobuf-net/issues/159) | [No](https://github.com/mgravell/protobuf-net/issues/159)

## Testing
Project | NuGet Install Command | .NET Core Support | ASP.NET Core Support | Website
------- | --------------------- | ----------------- | -------------------- | -------
[xUnit.net](https://github.com/xunit/xunit) |  | [WIP](http://xunit.github.io/docs/getting-started-dotnet-core.html) | [WIP](http://xunit.github.io/docs/getting-started-dotnet-core.html) | 
[Nunit](https://github.com/nunit/nunit) |  | Yes | Yes | 
[Nunit CLI Test Runner](https://github.com/nunit/dotnet-test-nunit) | Install-Package dotnet-test-nunit -Pre | [WIP Pre](https://www.nuget.org/packages/dotnet-test-nunit/) | [WIP Pre](https://www.nuget.org/packages/dotnet-test-nunit/) |
[Moq](https://github.com/moq/moq4) |  |  |  | 
[FakeItEasy](https://github.com/FakeItEasy/FakeItEasy) | Install-Package FakeItEasy -Pre | [WIP Pre](https://github.com/FakeItEasy/FakeItEasy/issues/531) | [WIP Pre](https://github.com/FakeItEasy/FakeItEasy/issues/531) | 
[Selenium](https://github.com/SeleniumHQ/selenium) |  |  |  | 
[SpecFlow](https://github.com/techtalk/SpecFlow) |  |  |  | 
[Shouldly](https://github.com/shouldly/shouldly) | Install-Package Shouldly |  |  | [shouldly.readthedocs.io](https://shouldly.readthedocs.io)

## Other
Project | NuGet Install Command | .NET Core Support | ASP.NET Core Support | Website
------- | --------------------- | ----------------- | -------------------- | -------
[Orleans](https://github.com/dotnet/orleans) | [Multiple](https://github.com/dotnet/orleans#installation) | [WIP](https://github.com/dotnet/orleans/tree/coreclr-compatibility) | [WIP](https://github.com/dotnet/orleans/issues/368) | [dotnet.github.io/orleans](https://dotnet.github.io/orleans/)
[Huxley](https://github.com/jpsingleton/Huxley) | N/A | [WIP](https://github.com/jpsingleton/Huxley/issues/44) | [WIP](https://github.com/jpsingleton/Huxley/issues/44) | [huxley.unop.uk](https://huxley.unop.uk/)
[AutoMapper](https://github.com/AutoMapper/AutoMapper) | Install-Package AutoMapper -Pre | Yes | Yes | [automapper.org](http://automapper.org/)
[Stuntman](https://github.com/ritterim/stuntman) | Install-Package RimDev.Stuntman | [No](https://github.com/ritterim/stuntman/issues/62) | [No](https://github.com/ritterim/stuntman/issues/62) | [rimdev.io/stuntman](http://rimdev.io/stuntman/)
[Akka.NET](https://github.com/akkadotnet/akka.net/tree/netcore) | Install-Package Akka | [WIP](https://github.com/akkadotnet/akka.net/pull/2134) | [WIP](https://github.com/akkadotnet/akka.net/issues/992) | [getakka.net](http://getakka.net/)
[GraphQL for .NET](https://github.com/graphql-dotnet/graphql-dotnet) | Install-Package GraphQL | [No](https://github.com/graphql-dotnet/graphql-dotnet/issues/43) | [No](https://github.com/graphql-dotnet/graphql-dotnet/issues/43)
[Antlr](https://github.com/tunnelvisionlabs/antlr4cs) | Install-Package Antlr4 -Pre | [WIP](https://github.com/tunnelvisionlabs/antlr4cs/issues/144) | [WIP](https://github.com/antlr/antlrcs/issues/42) | [antlr.org](http://www.antlr.org)
[DotNetOpenAuth](https://github.com/DotNetOpenAuth/DotNetOpenAuth) |  |  |  | 
[RestSharp](https://github.com/restsharp/RestSharp) |  |  |  | 
[HtmlAgilityPack](https://htmlagilitypack.codeplex.com/) |  |  |  | 
[AngleSharp](https://github.com/AngleSharp/AngleSharp) |  |  |  | 
[FluentAssertions](https://github.com/dennisdoomen/fluentassertions) |  | ? | ? | 
[FluentValidation](https://github.com/JeremySkinner/FluentValidation) |  |  |  | 
[NSubstitute](https://github.com/nsubstitute/NSubstitute) |  |  |  | 
[csvhelper](https://github.com/JoshClose/CsvHelper) |  |  |  | 
[Polly](https://github.com/App-vNext/Polly) | Install-Package Polly | ? | ? | 
[slow-cheetah](https://github.com/sayedihashimi/slow-cheetah) |  |  |  | 
[iTextSharp](https://github.com/itext/itextsharp) |  |  |  | 
[Quartz](https://github.com/quartznet/quartznet) |  |  |  | 
[AutoFixture](https://github.com/AutoFixture/AutoFixture) |  |  |  | 
[Reactive Extensions](https://github.com/Reactive-Extensions/Rx.NET) |  |  |  | 
[epplus](https://epplus.codeplex.com/) |  |  |  | 
[Open XML SDK](https://github.com/OfficeDev/Open-XML-SDK) |  |  |  | 
[EnterpriseLibrary](https://entlib.codeplex.com/) |  | No | No | 
[MVVMLight](https://mvvmlight.codeplex.com/) | Install-Package MvvmLightLibs |  |  | [mvvmlight.net](http://www.mvvmlight.net)
[dotless](https://github.com/dotless/dotless) |  |  |  | 
[Google.apis](https://github.com/google/google-api-dotnet-client) |  |  |  | 
[RhinoMocks](https://github.com/meisinger/rhino-mocks) |  |  |  | 
[Twilio](https://github.com/twilio/twilio-csharp) | Install-Package Twilio -Pre | ? | ? | [twilio.com/api](https://www.twilio.com/api)
[SharpZipLib](https://github.com/icsharpcode/SharpZipLib) | Install-Package SharpZipLib |  |  | [icsharpcode.github.io/SharpZipLib](https://icsharpcode.github.io/SharpZipLib)
[BouncyCastle](https://github.com/bcgit/bc-csharp) |  | ? | ? | 
[Facebook SDK](https://github.com/facebook-csharp-sdk/facebook-csharp-sdk) | Install-Package Facebook |  |  | [facebook.com/csharpsdk](https://www.facebook.com/csharpsdk)
[NodaTime](https://github.com/nodatime/nodatime) |  |  |  | 
[SSH.NET](https://github.com/sshnet/SSH.NET) |  |  |  | 
[Mono.Cecil](https://github.com/jbevain/cecil/) |  |  |  | 
[Octokit](https://github.com/octokit/octokit.net) | Install-Package Octokit |  |  | [developer.github.com/v3](https://developer.github.com/v3)
[Octo.exe](https://github.com/OctopusDeploy/Octo.exe) |  |  |  | [octopus.com](https://octopus.com)
[IdentityServer4](https://github.com/IdentityServer/IdentityServer4) |  | ? | ? | 
[PushSharp](https://github.com/Redth/PushSharp) |  |  |  | 
[CodeContracts](https://github.com/Microsoft/CodeContracts) |  |  |  | 
[Braintree SDK](https://github.com/braintree/braintree_dotnet) |  |  |  | 
[Mimekit](https://github.com/jstedfast/MimeKit) |  | ? | ? | 
[Mailkit](http://github.com/jstedfast/MailKit) |  | ? | ? | 
[Jint](https://github.com/sebastienros/jint) |  | ? | ? | 
[IdentityManager ](https://github.com/IdentityManager/IdentityManager) |  | ? | ? | 
[MEF2](https://github.com/dotnet/corefx/) | Install-Package Microsoft.Composition | ? | ? | [mef.codeplex.com](https://mef.codeplex.com)
[XMPP](https://github.com/ubiety/xmpp) | Install-Package XMPP |  |  | [ubiety.github.io/xmpp](https://ubiety.github.io/xmpp)
[System.Net.Mail](https://github.com/joshcomley/System.Net.Mail) | Install-Package System.Net.Mail -Pre |  |  | 
[Salesforce Toolkits for .NET](https://github.com/developerforce/Force.com-Toolkit-for-NET) |  |  |  | 
[OData](https://github.com/OData/odata.net/) | Install-Package Microsoft.AspNet.OData | ? | ? | [odata.github.io](https://odata.github.io)
[Orchard](https://github.com/OrchardCMS/Orchard2) |  |  |  | [orchardproject.net](http://orchardproject.net)
[YesSql](https://github.com/sebastienros/yessql) |  | ? | ? | 
[GenFu](https://github.com/MisterJames/GenFu) |  | ? | ? | 
[MS Build](https://github.com/Microsoft/msbuild) |  |  |  | 
[Azure SDK](https://github.com/Azure/azure-sdk-for-net) |  | ? | ? | [azure.microsoft.com](https://azure.microsoft.com/en-us/develop/net/)
[Azure Storage SDK](https://github.com/Azure/azure-storage-net) | install-package WindowsAzure.Storage -Pre | Yes | Yes | [azure.microsoft.com](https://azure.microsoft.com/en-us/documentation/services/storage/)
[Microsoft.Hadoop.Client](https://github.com/Azure/azure-sdk-for-net) |  |  |  | 
[AWS SDK](https://github.com/aws/aws-sdk-net) | Install-Package AWSSDK.Core -Pre | [WIP](https://www.nuget.org/packages/AWSSDK.Core/3.2.5-beta) | [WIP](https://www.nuget.org/packages/AWSSDK.Core/3.2.5-beta) | 
[C# BitTorrent library](https://github.com/cheatdeath/research-bittorrent) |  | [No](https://github.com/jpsingleton/ANCLAFS/issues/6) | [No](https://github.com/jpsingleton/ANCLAFS/issues/6) | [cheatdeath.github.io/research-bittorrent-doc](https://cheatdeath.github.io/research-bittorrent-doc)
[FluentScheduler](https://github.com/fluentscheduler/FluentScheduler) |  | [Yes](https://github.com/fluentscheduler/FluentScheduler#using-it-with-net-core) | [Yes](https://github.com/fluentscheduler/FluentScheduler/issues/94) |
[Quartz.NET](https://github.com/quartznet/quartznet) |  | [WIP](https://github.com/quartznet/quartznet/issues/355) | [WIP](https://github.com/quartznet/quartznet/issues/355) | [quartz-scheduler.net](http://www.quartz-scheduler.net/)
[NBitcoin](https://github.com/MetacoSA/NBitcoin) | Install-Package NBitcoin | Yes 

# License

[![CC0](https://mirrors.creativecommons.org/presskit/buttons/88x31/svg/cc-zero.svg)](https://creativecommons.org/publicdomain/zero/1.0/)

To the extent possible under law, [James Singleton](http://unop.uk) has waived all copyright and related or neighboring rights to this work.
