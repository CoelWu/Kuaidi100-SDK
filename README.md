<p align="center">
    <img src="https://i.loli.net/2021/01/17/aK4wpbnsmudcJLo.png" align="center" height="80"/>
</p>

<div align="center">

# 快递100 .NET SDK

[![Nuget](https://img.shields.io/nuget/v/CoelWu.Kuaidi100.SDK)](https://www.nuget.org/packages/CoelWu.Kuaidi100.SDK/)

该SDK基于[快递100网页API](https://m.kuaidi100.com)实现，在.NET Standard 2.0上构建

</div>

## 简单的开始

使用前，你需要先安装 **CoelWu.Kuaidi100.SDK** nuget包

```csharp
// 创建Client
Kuaidi100Client _client = new Kuaidi100Client();

// 获取单号对应的快递公司
var autoComNumResponse = await _client.AutoCompanyNumber(id: "快递单号");

// 获取物流信息
var postStatusResponse = await _client.QueryPostStatus(type: autoComNumResponse.Data[0].CompanyCode, postid: "快递单号", phone: "");
```

## 更多例子

如需要更多使用案例，请参考 **Kuaidi100-ConsoleApp**

## 释放

当你觉得客户端已经完成了使命，到了该释放的时候，那么你可以调用`Dispose`方法释放客户端对象。

```csharp
_client.Dispose();
```

## 鸣谢

- [快递100](https://m.kuaidi100.com)
- [Yuenov-SDK](https://github.com/Richasy/Yuenov-SDK)