[Visual Studio 2017中使用Libman管理客户端库 - LamondLu - 博客园 (cnblogs.com)](https://www.cnblogs.com/lwqlun/p/9850261.html)

[通过 LibMan 在 ASP.NET Core 中获取客户端库 | Microsoft Docs](https://docs.microsoft.com/zh-cn/aspnet/core/client-side/libman/?view=aspnetcore-5.0)

库管理器 (LibMan) 是一个轻量型客户端库获取工具。 LibMan 可从文件系统或从内容分发网络 (CDN) 下载库和框架。 支持的 CDN 包括 CDNJS、jsDelivr 和 unpkg。 将提取所选库文件，并将其置于 ASP.NET Core 项目中的相应位置。



Grunt 是一种 JavaScript 任务运行程序，可自动执行脚本缩减、TypeScript 编译、代码质量“lint”工具、CSS 预处理器以及支持客户端开发所需的所有重复性工作。 

---------------

##### 项目分为两大块:ApplicationCore/Infrastructure/Web是基础的MVC架构Web程序

##### BlazorAdmin/BlazorShared作为Blazor 应用程序

##### PublicApi独立对外提供可访问接口,很可能采用不同的安全机制，其中利用基于 Cookie 的身份验证和 API 的基于表单的标准应用程序很可能使用基于令牌的身份验证

