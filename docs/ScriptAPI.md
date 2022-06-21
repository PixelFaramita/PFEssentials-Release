<div align="center">
<h1>API for PFEssentials</h1>
<div align="right"><h4>Powered by LLRemoteCall</h1></div>
</div>

> - JavaScript
>```js
>let PFEssentials = ll.require("PFEssentials");
>```
> or
> - C++
>```C++
>#include <RemoteCallAPI.h>
>```
<details>
<summary><b>General<b></summary>

>## General::SetConfig
>### 设置全局配置文件（要求JSON字符串）
>|  形参   | 类型  |
>|  ----  | ----  |
>| jsonStr | String |
>返回值类型：Boolean;
> - JavaScript
>```js
>/** 设置全局配置文件（要求JSON字符串） 返回值类型：Boolean */
>const General_SetConfig = ll.import("PFAPI", "General_SetConfig");
>let result = General_SetConfig(jsonStr);
>```
> - C++
>```C++
>// 设置全局配置文件（要求JSON字符串） 返回值类型：Boolean
>auto General_SetConfig = RemoteCall::importAs<bool(std::string const& jsonStr)>("PFAPI", "General_SetConfig");
>let result = General_SetConfig(jsonStr);
>```
>---
>## General::GetConfig
>### 获取全局配置文件（JSON字符串）
>无参数;
>返回值类型：String;
> - JavaScript
>```js
>/** 获取全局配置文件（JSON字符串） 返回值类型：String */
>const General_GetConfig = ll.import("PFAPI", "General_GetConfig");
>let result = General_GetConfig();
>```
> - C++
>```C++
>// 获取全局配置文件（JSON字符串） 返回值类型：String
>auto General_GetConfig = RemoteCall::importAs<std::string()>("PFAPI", "General_GetConfig");
>let result = General_GetConfig();
>```
>---
>## General::Reload
>### 重新加载所有功能的配置文件
>无参数;
>无返回值;
> - JavaScript
>```js
>/** 重新加载所有功能的配置文件 */
>const General_Reload = ll.import("PFAPI", "General_Reload");
>General_Reload();
>```
> - C++
>```C++
>// 重新加载所有功能的配置文件
>auto General_Reload = RemoteCall::importAs<void()>("PFAPI", "General_Reload");
>General_Reload();
>```
</details>
<details>
<summary><b>Command<b></summary>

>## Command::SetCommandDisabled
>### 设置命令禁用(可设置提示)
>|  形参   | 类型  |
>|  ----  | ----  |
>| playerName | String |
>| cmd | String |
>| feedback | String |
>无返回值;
> - JavaScript
>```js
>/** 设置命令禁用(可设置提示) */
>const Command_SetCommandDisabled = ll.import("PFAPI", "Command_SetCommandDisabled");
>Command_SetCommandDisabled(playerName,cmd,feedback);
>```
> - C++
>```C++
>// 设置命令禁用(可设置提示)
>auto Command_SetCommandDisabled = RemoteCall::importAs<void(std::string const& playerName,std::string const& cmd,std::string const& feedback)>("PFAPI", "Command_SetCommandDisabled");
>Command_SetCommandDisabled(playerName,cmd,feedback);
>```
>---
>## Command::SetCommandEnabled
>### 设置命令启用
>|  形参   | 类型  |
>|  ----  | ----  |
>| playerName | String |
>| cmd | String |
>无返回值;
> - JavaScript
>```js
>/** 设置命令启用 */
>const Command_SetCommandEnabled = ll.import("PFAPI", "Command_SetCommandEnabled");
>Command_SetCommandEnabled(playerName,cmd);
>```
> - C++
>```C++
>// 设置命令启用
>auto Command_SetCommandEnabled = RemoteCall::importAs<void(std::string const& playerName,std::string const& cmd)>("PFAPI", "Command_SetCommandEnabled");
>Command_SetCommandEnabled(playerName,cmd);
>```
</details>
<details>
<summary><b>Language<b></summary>

>## Language::Translate
>### 翻译
>|  形参   | 类型  |
>|  ----  | ----  |
>| fromLanguage | String |
>| toLanguage | String |
>| text | String |
>返回值类型：String;
> - JavaScript
>```js
>/** 翻译 返回值类型：String */
>const Language_Translate = ll.import("PFAPI", "Language_Translate");
>let result = Language_Translate(fromLanguage,toLanguage,text);
>```
> - C++
>```C++
>// 翻译 返回值类型：String
>auto Language_Translate = RemoteCall::importAs<std::string(std::string const& fromLanguage,std::string const& toLanguage,std::string const& text)>("PFAPI", "Language_Translate");
>let result = Language_Translate(fromLanguage,toLanguage,text);
>```
</details>
<details>
<summary><b>ChatEx<b></summary>

>## ChatEx::SetNickName
>### 设置玩家昵称
>|  形参   | 类型  |
>|  ----  | ----  |
>| name | String |
>| nickName | String |
>无返回值;
> - JavaScript
>```js
>/** 设置玩家昵称 */
>const ChatEx_SetNickName = ll.import("PFAPI", "ChatEx_SetNickName");
>ChatEx_SetNickName(name,nickName);
>```
> - C++
>```C++
>// 设置玩家昵称
>auto ChatEx_SetNickName = RemoteCall::importAs<void(std::string const& name,std::string const& nickName)>("PFAPI", "ChatEx_SetNickName");
>ChatEx_SetNickName(name,nickName);
>```
>---
>## ChatEx::SetFakeName
>### 设置玩家聊天时的名字
>|  形参   | 类型  |
>|  ----  | ----  |
>| name | String |
>| fakeName | String |
>无返回值;
> - JavaScript
>```js
>/** 设置玩家聊天时的名字 */
>const ChatEx_SetFakeName = ll.import("PFAPI", "ChatEx_SetFakeName");
>ChatEx_SetFakeName(name,fakeName);
>```
> - C++
>```C++
>// 设置玩家聊天时的名字
>auto ChatEx_SetFakeName = RemoteCall::importAs<void(std::string const& name,std::string const& fakeName)>("PFAPI", "ChatEx_SetFakeName");
>ChatEx_SetFakeName(name,fakeName);
>```
>---
>## ChatEx::SetEnd
>### 设置玩家聊天消息后缀
>|  形参   | 类型  |
>|  ----  | ----  |
>| name | String |
>| endStr | String |
>无返回值;
> - JavaScript
>```js
>/** 设置玩家聊天消息后缀 */
>const ChatEx_SetEnd = ll.import("PFAPI", "ChatEx_SetEnd");
>ChatEx_SetEnd(name,endStr);
>```
> - C++
>```C++
>// 设置玩家聊天消息后缀
>auto ChatEx_SetEnd = RemoteCall::importAs<void(std::string const& name,std::string const& endStr)>("PFAPI", "ChatEx_SetEnd");
>ChatEx_SetEnd(name,endStr);
>```
>---
>## ChatEx::SetStart
>### 设置玩家聊天消息前缀
>|  形参   | 类型  |
>|  ----  | ----  |
>| name | String |
>| startStr | String |
>无返回值;
> - JavaScript
>```js
>/** 设置玩家聊天消息前缀 */
>const ChatEx_SetStart = ll.import("PFAPI", "ChatEx_SetStart");
>ChatEx_SetStart(name,startStr);
>```
> - C++
>```C++
>// 设置玩家聊天消息前缀
>auto ChatEx_SetStart = RemoteCall::importAs<void(std::string const& name,std::string const& startStr)>("PFAPI", "ChatEx_SetStart");
>ChatEx_SetStart(name,startStr);
>```
</details>
<details>
<summary><b>Lands<b></summary>

>## Lands::CheckCubeHasLand
>### 检查指定立方体区域(float)是否有领地
>|  形参   | 类型  |
>|  ----  | ----  |
>| x1 | Single |
>| y1 | Single |
>| z1 | Single |
>| x2 | Single |
>| y2 | Single |
>| z2 | Single |
>| dimensionId | Integer |
>返回值类型：Boolean;
> - JavaScript
>```js
>/** 检查指定立方体区域(float)是否有领地 返回值类型：Boolean */
>const Lands_CheckCubeHasLand = ll.import("PFAPI", "Lands_CheckCubeHasLand");
>let result = Lands_CheckCubeHasLand(x1,y1,z1,x2,y2,z2,dimensionId);
>```
> - C++
>```C++
>// 检查指定立方体区域(float)是否有领地 返回值类型：Boolean
>auto Lands_CheckCubeHasLand = RemoteCall::importAs<bool(float const& x1,float const& y1,float const& z1,float const& x2,float const& y2,float const& z2,int const& dimensionId)>("PFAPI", "Lands_CheckCubeHasLand");
>let result = Lands_CheckCubeHasLand(x1,y1,z1,x2,y2,z2,dimensionId);
>```
>---
>## Lands::CheckCubeHasLandInt
>### 检查指定立方体区域(int)是否有领地
>|  形参   | 类型  |
>|  ----  | ----  |
>| x1 | Integer |
>| y1 | Integer |
>| z1 | Integer |
>| x2 | Integer |
>| y2 | Integer |
>| z2 | Integer |
>| dimensionId | Integer |
>返回值类型：Boolean;
> - JavaScript
>```js
>/** 检查指定立方体区域(int)是否有领地 返回值类型：Boolean */
>const Lands_CheckCubeHasLandInt = ll.import("PFAPI", "Lands_CheckCubeHasLandInt");
>let result = Lands_CheckCubeHasLandInt(x1,y1,z1,x2,y2,z2,dimensionId);
>```
> - C++
>```C++
>// 检查指定立方体区域(int)是否有领地 返回值类型：Boolean
>auto Lands_CheckCubeHasLandInt = RemoteCall::importAs<bool(int const& x1,int const& y1,int const& z1,int const& x2,int const& y2,int const& z2,int const& dimensionId)>("PFAPI", "Lands_CheckCubeHasLandInt");
>let result = Lands_CheckCubeHasLandInt(x1,y1,z1,x2,y2,z2,dimensionId);
>```
>---
>## Lands::CheckPosHasLand
>### 检查指定坐标(float)是否有领地
>|  形参   | 类型  |
>|  ----  | ----  |
>| x | Single |
>| y | Single |
>| z | Single |
>| dimensionId | Integer |
>返回值类型：Boolean;
> - JavaScript
>```js
>/** 检查指定坐标(float)是否有领地 返回值类型：Boolean */
>const Lands_CheckPosHasLand = ll.import("PFAPI", "Lands_CheckPosHasLand");
>let result = Lands_CheckPosHasLand(x,y,z,dimensionId);
>```
> - C++
>```C++
>// 检查指定坐标(float)是否有领地 返回值类型：Boolean
>auto Lands_CheckPosHasLand = RemoteCall::importAs<bool(float const& x,float const& y,float const& z,int const& dimensionId)>("PFAPI", "Lands_CheckPosHasLand");
>let result = Lands_CheckPosHasLand(x,y,z,dimensionId);
>```
>---
>## Lands::CheckPosHasLandInt
>### 检查指定坐标(int)是否有领地
>|  形参   | 类型  |
>|  ----  | ----  |
>| x | Integer |
>| y | Integer |
>| z | Integer |
>| dimensionId | Integer |
>返回值类型：Boolean;
> - JavaScript
>```js
>/** 检查指定坐标(int)是否有领地 返回值类型：Boolean */
>const Lands_CheckPosHasLandInt = ll.import("PFAPI", "Lands_CheckPosHasLandInt");
>let result = Lands_CheckPosHasLandInt(x,y,z,dimensionId);
>```
> - C++
>```C++
>// 检查指定坐标(int)是否有领地 返回值类型：Boolean
>auto Lands_CheckPosHasLandInt = RemoteCall::importAs<bool(int const& x,int const& y,int const& z,int const& dimensionId)>("PFAPI", "Lands_CheckPosHasLandInt");
>let result = Lands_CheckPosHasLandInt(x,y,z,dimensionId);
>```
>---
>## Lands::GetLandByCube
>### 获取立方体区域(float)领地信息（返回JSON字符串）
>|  形参   | 类型  |
>|  ----  | ----  |
>| x1 | Single |
>| y1 | Single |
>| z1 | Single |
>| x2 | Single |
>| y2 | Single |
>| z2 | Single |
>| dimensionId | Integer |
>返回值类型：String;
> - JavaScript
>```js
>/** 获取立方体区域(float)领地信息（返回JSON字符串） 返回值类型：String */
>const Lands_GetLandByCube = ll.import("PFAPI", "Lands_GetLandByCube");
>let result = Lands_GetLandByCube(x1,y1,z1,x2,y2,z2,dimensionId);
>```
> - C++
>```C++
>// 获取立方体区域(float)领地信息（返回JSON字符串） 返回值类型：String
>auto Lands_GetLandByCube = RemoteCall::importAs<std::string(float const& x1,float const& y1,float const& z1,float const& x2,float const& y2,float const& z2,int const& dimensionId)>("PFAPI", "Lands_GetLandByCube");
>let result = Lands_GetLandByCube(x1,y1,z1,x2,y2,z2,dimensionId);
>```
>---
>## Lands::GetLandByCubeInt
>### 获取立方体区域(int)领地信息（返回JSON字符串）
>|  形参   | 类型  |
>|  ----  | ----  |
>| x1 | Integer |
>| y1 | Integer |
>| z1 | Integer |
>| x2 | Integer |
>| y2 | Integer |
>| z2 | Integer |
>| dimensionId | Integer |
>返回值类型：String;
> - JavaScript
>```js
>/** 获取立方体区域(int)领地信息（返回JSON字符串） 返回值类型：String */
>const Lands_GetLandByCubeInt = ll.import("PFAPI", "Lands_GetLandByCubeInt");
>let result = Lands_GetLandByCubeInt(x1,y1,z1,x2,y2,z2,dimensionId);
>```
> - C++
>```C++
>// 获取立方体区域(int)领地信息（返回JSON字符串） 返回值类型：String
>auto Lands_GetLandByCubeInt = RemoteCall::importAs<std::string(int const& x1,int const& y1,int const& z1,int const& x2,int const& y2,int const& z2,int const& dimensionId)>("PFAPI", "Lands_GetLandByCubeInt");
>let result = Lands_GetLandByCubeInt(x1,y1,z1,x2,y2,z2,dimensionId);
>```
>---
>## Lands::GetLandByPos
>### 获取指定坐标(float)领地信息（返回JSON字符串）
>|  形参   | 类型  |
>|  ----  | ----  |
>| x | Single |
>| y | Single |
>| z | Single |
>| dimensionId | Integer |
>返回值类型：String;
> - JavaScript
>```js
>/** 获取指定坐标(float)领地信息（返回JSON字符串） 返回值类型：String */
>const Lands_GetLandByPos = ll.import("PFAPI", "Lands_GetLandByPos");
>let result = Lands_GetLandByPos(x,y,z,dimensionId);
>```
> - C++
>```C++
>// 获取指定坐标(float)领地信息（返回JSON字符串） 返回值类型：String
>auto Lands_GetLandByPos = RemoteCall::importAs<std::string(float const& x,float const& y,float const& z,int const& dimensionId)>("PFAPI", "Lands_GetLandByPos");
>let result = Lands_GetLandByPos(x,y,z,dimensionId);
>```
>---
>## Lands::GetLandByPosInt
>### 获取指定坐标(int)领地信息（返回JSON字符串）
>|  形参   | 类型  |
>|  ----  | ----  |
>| x | Integer |
>| y | Integer |
>| z | Integer |
>| dimensionId | Integer |
>返回值类型：String;
> - JavaScript
>```js
>/** 获取指定坐标(int)领地信息（返回JSON字符串） 返回值类型：String */
>const Lands_GetLandByPosInt = ll.import("PFAPI", "Lands_GetLandByPosInt");
>let result = Lands_GetLandByPosInt(x,y,z,dimensionId);
>```
> - C++
>```C++
>// 获取指定坐标(int)领地信息（返回JSON字符串） 返回值类型：String
>auto Lands_GetLandByPosInt = RemoteCall::importAs<std::string(int const& x,int const& y,int const& z,int const& dimensionId)>("PFAPI", "Lands_GetLandByPosInt");
>let result = Lands_GetLandByPosInt(x,y,z,dimensionId);
>```
>---
>## Lands::GetLandInfoByCube
>### 获取立方体区域(float)领地数据源详细信息（返回JSON字符串）
>|  形参   | 类型  |
>|  ----  | ----  |
>| x1 | Single |
>| y1 | Single |
>| z1 | Single |
>| x2 | Single |
>| y2 | Single |
>| z2 | Single |
>| dimensionId | Integer |
>返回值类型：String;
> - JavaScript
>```js
>/** 获取立方体区域(float)领地数据源详细信息（返回JSON字符串） 返回值类型：String */
>const Lands_GetLandInfoByCube = ll.import("PFAPI", "Lands_GetLandInfoByCube");
>let result = Lands_GetLandInfoByCube(x1,y1,z1,x2,y2,z2,dimensionId);
>```
> - C++
>```C++
>// 获取立方体区域(float)领地数据源详细信息（返回JSON字符串） 返回值类型：String
>auto Lands_GetLandInfoByCube = RemoteCall::importAs<std::string(float const& x1,float const& y1,float const& z1,float const& x2,float const& y2,float const& z2,int const& dimensionId)>("PFAPI", "Lands_GetLandInfoByCube");
>let result = Lands_GetLandInfoByCube(x1,y1,z1,x2,y2,z2,dimensionId);
>```
>---
>## Lands::GetLandInfoByCubeInt
>### 获取立方体区域(int)领地数据源详细信息（返回JSON字符串）
>|  形参   | 类型  |
>|  ----  | ----  |
>| x1 | Integer |
>| y1 | Integer |
>| z1 | Integer |
>| x2 | Integer |
>| y2 | Integer |
>| z2 | Integer |
>| dimensionId | Integer |
>返回值类型：String;
> - JavaScript
>```js
>/** 获取立方体区域(int)领地数据源详细信息（返回JSON字符串） 返回值类型：String */
>const Lands_GetLandInfoByCubeInt = ll.import("PFAPI", "Lands_GetLandInfoByCubeInt");
>let result = Lands_GetLandInfoByCubeInt(x1,y1,z1,x2,y2,z2,dimensionId);
>```
> - C++
>```C++
>// 获取立方体区域(int)领地数据源详细信息（返回JSON字符串） 返回值类型：String
>auto Lands_GetLandInfoByCubeInt = RemoteCall::importAs<std::string(int const& x1,int const& y1,int const& z1,int const& x2,int const& y2,int const& z2,int const& dimensionId)>("PFAPI", "Lands_GetLandInfoByCubeInt");
>let result = Lands_GetLandInfoByCubeInt(x1,y1,z1,x2,y2,z2,dimensionId);
>```
>---
>## Lands::GetLandInfoByPos
>### 获取指定坐标(float)领地数据源详细信息（返回JSON字符串）
>|  形参   | 类型  |
>|  ----  | ----  |
>| x | Single |
>| y | Single |
>| z | Single |
>| dimensionId | Integer |
>返回值类型：String;
> - JavaScript
>```js
>/** 获取指定坐标(float)领地数据源详细信息（返回JSON字符串） 返回值类型：String */
>const Lands_GetLandInfoByPos = ll.import("PFAPI", "Lands_GetLandInfoByPos");
>let result = Lands_GetLandInfoByPos(x,y,z,dimensionId);
>```
> - C++
>```C++
>// 获取指定坐标(float)领地数据源详细信息（返回JSON字符串） 返回值类型：String
>auto Lands_GetLandInfoByPos = RemoteCall::importAs<std::string(float const& x,float const& y,float const& z,int const& dimensionId)>("PFAPI", "Lands_GetLandInfoByPos");
>let result = Lands_GetLandInfoByPos(x,y,z,dimensionId);
>```
>---
>## Lands::GetLandInfoByPosInt
>### 获取指定坐标(int)领地数据源详细信息（返回JSON字符串）
>|  形参   | 类型  |
>|  ----  | ----  |
>| x | Integer |
>| y | Integer |
>| z | Integer |
>| dimensionId | Integer |
>返回值类型：String;
> - JavaScript
>```js
>/** 获取指定坐标(int)领地数据源详细信息（返回JSON字符串） 返回值类型：String */
>const Lands_GetLandInfoByPosInt = ll.import("PFAPI", "Lands_GetLandInfoByPosInt");
>let result = Lands_GetLandInfoByPosInt(x,y,z,dimensionId);
>```
> - C++
>```C++
>// 获取指定坐标(int)领地数据源详细信息（返回JSON字符串） 返回值类型：String
>auto Lands_GetLandInfoByPosInt = RemoteCall::importAs<std::string(int const& x,int const& y,int const& z,int const& dimensionId)>("PFAPI", "Lands_GetLandInfoByPosInt");
>let result = Lands_GetLandInfoByPosInt(x,y,z,dimensionId);
>```
>---
>## Lands::SetLandInfoByCube
>### 设置指定立方体区域(float)领地数据源详细信息（传入JSON字符串）
>|  形参   | 类型  |
>|  ----  | ----  |
>| x1 | Single |
>| y1 | Single |
>| z1 | Single |
>| x2 | Single |
>| y2 | Single |
>| z2 | Single |
>| dimensionId | Integer |
>| landinfo | String |
>返回值类型：Boolean;
> - JavaScript
>```js
>/** 设置指定立方体区域(float)领地数据源详细信息（传入JSON字符串） 返回值类型：Boolean */
>const Lands_SetLandInfoByCube = ll.import("PFAPI", "Lands_SetLandInfoByCube");
>let result = Lands_SetLandInfoByCube(x1,y1,z1,x2,y2,z2,dimensionId,landinfo);
>```
> - C++
>```C++
>// 设置指定立方体区域(float)领地数据源详细信息（传入JSON字符串） 返回值类型：Boolean
>auto Lands_SetLandInfoByCube = RemoteCall::importAs<bool(float const& x1,float const& y1,float const& z1,float const& x2,float const& y2,float const& z2,int const& dimensionId,std::string const& landinfo)>("PFAPI", "Lands_SetLandInfoByCube");
>let result = Lands_SetLandInfoByCube(x1,y1,z1,x2,y2,z2,dimensionId,landinfo);
>```
>---
>## Lands::SetLandInfoByCubeInt
>### 设置指定立方体区域(int)领地数据源详细信息（传入JSON字符串）
>|  形参   | 类型  |
>|  ----  | ----  |
>| x1 | Integer |
>| y1 | Integer |
>| z1 | Integer |
>| x2 | Integer |
>| y2 | Integer |
>| z2 | Integer |
>| dimensionId | Integer |
>| landinfo | String |
>返回值类型：Boolean;
> - JavaScript
>```js
>/** 设置指定立方体区域(int)领地数据源详细信息（传入JSON字符串） 返回值类型：Boolean */
>const Lands_SetLandInfoByCubeInt = ll.import("PFAPI", "Lands_SetLandInfoByCubeInt");
>let result = Lands_SetLandInfoByCubeInt(x1,y1,z1,x2,y2,z2,dimensionId,landinfo);
>```
> - C++
>```C++
>// 设置指定立方体区域(int)领地数据源详细信息（传入JSON字符串） 返回值类型：Boolean
>auto Lands_SetLandInfoByCubeInt = RemoteCall::importAs<bool(int const& x1,int const& y1,int const& z1,int const& x2,int const& y2,int const& z2,int const& dimensionId,std::string const& landinfo)>("PFAPI", "Lands_SetLandInfoByCubeInt");
>let result = Lands_SetLandInfoByCubeInt(x1,y1,z1,x2,y2,z2,dimensionId,landinfo);
>```
>---
>## Lands::SetLandInfoByPos
>### 设置指定坐标(float)领地数据源详细信息（传入JSON字符串）
>|  形参   | 类型  |
>|  ----  | ----  |
>| x | Single |
>| y | Single |
>| z | Single |
>| dimensionId | Integer |
>| landinfo | String |
>返回值类型：Boolean;
> - JavaScript
>```js
>/** 设置指定坐标(float)领地数据源详细信息（传入JSON字符串） 返回值类型：Boolean */
>const Lands_SetLandInfoByPos = ll.import("PFAPI", "Lands_SetLandInfoByPos");
>let result = Lands_SetLandInfoByPos(x,y,z,dimensionId,landinfo);
>```
> - C++
>```C++
>// 设置指定坐标(float)领地数据源详细信息（传入JSON字符串） 返回值类型：Boolean
>auto Lands_SetLandInfoByPos = RemoteCall::importAs<bool(float const& x,float const& y,float const& z,int const& dimensionId,std::string const& landinfo)>("PFAPI", "Lands_SetLandInfoByPos");
>let result = Lands_SetLandInfoByPos(x,y,z,dimensionId,landinfo);
>```
>---
>## Lands::SetLandInfoByPosInt
>### 设置或修改指定坐标(int)领地数据源详细信息（传入JSON字符串）
>|  形参   | 类型  |
>|  ----  | ----  |
>| x | Integer |
>| y | Integer |
>| z | Integer |
>| dimensionId | Integer |
>| landinfo | String |
>返回值类型：Boolean;
> - JavaScript
>```js
>/** 设置或修改指定坐标(int)领地数据源详细信息（传入JSON字符串） 返回值类型：Boolean */
>const Lands_SetLandInfoByPosInt = ll.import("PFAPI", "Lands_SetLandInfoByPosInt");
>let result = Lands_SetLandInfoByPosInt(x,y,z,dimensionId,landinfo);
>```
> - C++
>```C++
>// 设置或修改指定坐标(int)领地数据源详细信息（传入JSON字符串） 返回值类型：Boolean
>auto Lands_SetLandInfoByPosInt = RemoteCall::importAs<bool(int const& x,int const& y,int const& z,int const& dimensionId,std::string const& landinfo)>("PFAPI", "Lands_SetLandInfoByPosInt");
>let result = Lands_SetLandInfoByPosInt(x,y,z,dimensionId,landinfo);
>```
</details>
<details>
<summary><b>Money<b></summary>

>## Money::Get
>### 获取玩家(指定玩家名)金钱
>|  形参   | 类型  |
>|  ----  | ----  |
>| name | String |
>返回值类型：Integer;
> - JavaScript
>```js
>/** 获取玩家(指定玩家名)金钱 返回值类型：Integer */
>const Money_Get = ll.import("PFAPI", "Money_Get");
>let result = Money_Get(name);
>```
> - C++
>```C++
>// 获取玩家(指定玩家名)金钱 返回值类型：Integer
>auto Money_Get = RemoteCall::importAs<int(std::string const& name)>("PFAPI", "Money_Get");
>let result = Money_Get(name);
>```
>---
>## Money::Add
>### 给玩家(指定玩家名)加钱
>|  形参   | 类型  |
>|  ----  | ----  |
>| name | String |
>| val | Integer |
>返回值类型：Boolean;
> - JavaScript
>```js
>/** 给玩家(指定玩家名)加钱 返回值类型：Boolean */
>const Money_Add = ll.import("PFAPI", "Money_Add");
>let result = Money_Add(name,val);
>```
> - C++
>```C++
>// 给玩家(指定玩家名)加钱 返回值类型：Boolean
>auto Money_Add = RemoteCall::importAs<bool(std::string const& name,int const& val)>("PFAPI", "Money_Add");
>let result = Money_Add(name,val);
>```
>---
>## Money::Remove
>### 给玩家(指定玩家名)减钱
>|  形参   | 类型  |
>|  ----  | ----  |
>| name | String |
>| val | Integer |
>返回值类型：Boolean;
> - JavaScript
>```js
>/** 给玩家(指定玩家名)减钱 返回值类型：Boolean */
>const Money_Remove = ll.import("PFAPI", "Money_Remove");
>let result = Money_Remove(name,val);
>```
> - C++
>```C++
>// 给玩家(指定玩家名)减钱 返回值类型：Boolean
>auto Money_Remove = RemoteCall::importAs<bool(std::string const& name,int const& val)>("PFAPI", "Money_Remove");
>let result = Money_Remove(name,val);
>```
</details>
<details><summary><b>All Api in JavaScript<b></summary>

---
<details><summary>JavaScript imports</summary>

``` JavaScript
/** 设置全局配置文件（要求JSON字符串） 返回值类型：Boolean */
const General_SetConfig = ll.import("PFAPI", "General_SetConfig");
/** 获取全局配置文件（JSON字符串） 返回值类型：String */
const General_GetConfig = ll.import("PFAPI", "General_GetConfig");
/** 重新加载所有功能的配置文件 */
const General_Reload = ll.import("PFAPI", "General_Reload");
/** 设置命令禁用(可设置提示) */
const Command_SetCommandDisabled = ll.import("PFAPI", "Command_SetCommandDisabled");
/** 设置命令启用 */
const Command_SetCommandEnabled = ll.import("PFAPI", "Command_SetCommandEnabled");
/** 翻译 返回值类型：String */
const Language_Translate = ll.import("PFAPI", "Language_Translate");
/** 设置玩家昵称 */
const ChatEx_SetNickName = ll.import("PFAPI", "ChatEx_SetNickName");
/** 设置玩家聊天时的名字 */
const ChatEx_SetFakeName = ll.import("PFAPI", "ChatEx_SetFakeName");
/** 设置玩家聊天消息后缀 */
const ChatEx_SetEnd = ll.import("PFAPI", "ChatEx_SetEnd");
/** 设置玩家聊天消息前缀 */
const ChatEx_SetStart = ll.import("PFAPI", "ChatEx_SetStart");
/** 检查指定立方体区域(float)是否有领地 返回值类型：Boolean */
const Lands_CheckCubeHasLand = ll.import("PFAPI", "Lands_CheckCubeHasLand");
/** 检查指定立方体区域(int)是否有领地 返回值类型：Boolean */
const Lands_CheckCubeHasLandInt = ll.import("PFAPI", "Lands_CheckCubeHasLandInt");
/** 检查指定坐标(float)是否有领地 返回值类型：Boolean */
const Lands_CheckPosHasLand = ll.import("PFAPI", "Lands_CheckPosHasLand");
/** 检查指定坐标(int)是否有领地 返回值类型：Boolean */
const Lands_CheckPosHasLandInt = ll.import("PFAPI", "Lands_CheckPosHasLandInt");
/** 获取立方体区域(float)领地信息（返回JSON字符串） 返回值类型：String */
const Lands_GetLandByCube = ll.import("PFAPI", "Lands_GetLandByCube");
/** 获取立方体区域(int)领地信息（返回JSON字符串） 返回值类型：String */
const Lands_GetLandByCubeInt = ll.import("PFAPI", "Lands_GetLandByCubeInt");
/** 获取指定坐标(float)领地信息（返回JSON字符串） 返回值类型：String */
const Lands_GetLandByPos = ll.import("PFAPI", "Lands_GetLandByPos");
/** 获取指定坐标(int)领地信息（返回JSON字符串） 返回值类型：String */
const Lands_GetLandByPosInt = ll.import("PFAPI", "Lands_GetLandByPosInt");
/** 获取立方体区域(float)领地数据源详细信息（返回JSON字符串） 返回值类型：String */
const Lands_GetLandInfoByCube = ll.import("PFAPI", "Lands_GetLandInfoByCube");
/** 获取立方体区域(int)领地数据源详细信息（返回JSON字符串） 返回值类型：String */
const Lands_GetLandInfoByCubeInt = ll.import("PFAPI", "Lands_GetLandInfoByCubeInt");
/** 获取指定坐标(float)领地数据源详细信息（返回JSON字符串） 返回值类型：String */
const Lands_GetLandInfoByPos = ll.import("PFAPI", "Lands_GetLandInfoByPos");
/** 获取指定坐标(int)领地数据源详细信息（返回JSON字符串） 返回值类型：String */
const Lands_GetLandInfoByPosInt = ll.import("PFAPI", "Lands_GetLandInfoByPosInt");
/** 设置指定立方体区域(float)领地数据源详细信息（传入JSON字符串） 返回值类型：Boolean */
const Lands_SetLandInfoByCube = ll.import("PFAPI", "Lands_SetLandInfoByCube");
/** 设置指定立方体区域(int)领地数据源详细信息（传入JSON字符串） 返回值类型：Boolean */
const Lands_SetLandInfoByCubeInt = ll.import("PFAPI", "Lands_SetLandInfoByCubeInt");
/** 设置指定坐标(float)领地数据源详细信息（传入JSON字符串） 返回值类型：Boolean */
const Lands_SetLandInfoByPos = ll.import("PFAPI", "Lands_SetLandInfoByPos");
/** 设置或修改指定坐标(int)领地数据源详细信息（传入JSON字符串） 返回值类型：Boolean */
const Lands_SetLandInfoByPosInt = ll.import("PFAPI", "Lands_SetLandInfoByPosInt");
/** 获取玩家(指定玩家名)金钱 返回值类型：Integer */
const Money_Get = ll.import("PFAPI", "Money_Get");
/** 给玩家(指定玩家名)加钱 返回值类型：Boolean */
const Money_Add = ll.import("PFAPI", "Money_Add");
/** 给玩家(指定玩家名)减钱 返回值类型：Boolean */
const Money_Remove = ll.import("PFAPI", "Money_Remove");

```
</details>

---
<details><summary>JavaScript object</summary>

``` JavaScript
const PFAPI = {
	General : {
		/** 设置全局配置文件（要求JSON字符串） 返回值类型：Boolean */
		SetConfig : ll.import("PFAPI", "General_SetConfig"),
		/** 获取全局配置文件（JSON字符串） 返回值类型：String */
		GetConfig : ll.import("PFAPI", "General_GetConfig"),
		/** 重新加载所有功能的配置文件 */
		Reload : ll.import("PFAPI", "General_Reload"),
	},
	Command : {
		/** 设置命令禁用(可设置提示) */
		SetCommandDisabled : ll.import("PFAPI", "Command_SetCommandDisabled"),
		/** 设置命令启用 */
		SetCommandEnabled : ll.import("PFAPI", "Command_SetCommandEnabled"),
	},
	Language : {
		/** 翻译 返回值类型：String */
		Translate : ll.import("PFAPI", "Language_Translate"),
	},
	ChatEx : {
		/** 设置玩家昵称 */
		SetNickName : ll.import("PFAPI", "ChatEx_SetNickName"),
		/** 设置玩家聊天时的名字 */
		SetFakeName : ll.import("PFAPI", "ChatEx_SetFakeName"),
		/** 设置玩家聊天消息后缀 */
		SetEnd : ll.import("PFAPI", "ChatEx_SetEnd"),
		/** 设置玩家聊天消息前缀 */
		SetStart : ll.import("PFAPI", "ChatEx_SetStart"),
	},
	Lands : {
		/** 检查指定立方体区域(float)是否有领地 返回值类型：Boolean */
		CheckCubeHasLand : ll.import("PFAPI", "Lands_CheckCubeHasLand"),
		/** 检查指定立方体区域(int)是否有领地 返回值类型：Boolean */
		CheckCubeHasLandInt : ll.import("PFAPI", "Lands_CheckCubeHasLandInt"),
		/** 检查指定坐标(float)是否有领地 返回值类型：Boolean */
		CheckPosHasLand : ll.import("PFAPI", "Lands_CheckPosHasLand"),
		/** 检查指定坐标(int)是否有领地 返回值类型：Boolean */
		CheckPosHasLandInt : ll.import("PFAPI", "Lands_CheckPosHasLandInt"),
		/** 获取立方体区域(float)领地信息（返回JSON字符串） 返回值类型：String */
		GetLandByCube : ll.import("PFAPI", "Lands_GetLandByCube"),
		/** 获取立方体区域(int)领地信息（返回JSON字符串） 返回值类型：String */
		GetLandByCubeInt : ll.import("PFAPI", "Lands_GetLandByCubeInt"),
		/** 获取指定坐标(float)领地信息（返回JSON字符串） 返回值类型：String */
		GetLandByPos : ll.import("PFAPI", "Lands_GetLandByPos"),
		/** 获取指定坐标(int)领地信息（返回JSON字符串） 返回值类型：String */
		GetLandByPosInt : ll.import("PFAPI", "Lands_GetLandByPosInt"),
		/** 获取立方体区域(float)领地数据源详细信息（返回JSON字符串） 返回值类型：String */
		GetLandInfoByCube : ll.import("PFAPI", "Lands_GetLandInfoByCube"),
		/** 获取立方体区域(int)领地数据源详细信息（返回JSON字符串） 返回值类型：String */
		GetLandInfoByCubeInt : ll.import("PFAPI", "Lands_GetLandInfoByCubeInt"),
		/** 获取指定坐标(float)领地数据源详细信息（返回JSON字符串） 返回值类型：String */
		GetLandInfoByPos : ll.import("PFAPI", "Lands_GetLandInfoByPos"),
		/** 获取指定坐标(int)领地数据源详细信息（返回JSON字符串） 返回值类型：String */
		GetLandInfoByPosInt : ll.import("PFAPI", "Lands_GetLandInfoByPosInt"),
		/** 设置指定立方体区域(float)领地数据源详细信息（传入JSON字符串） 返回值类型：Boolean */
		SetLandInfoByCube : ll.import("PFAPI", "Lands_SetLandInfoByCube"),
		/** 设置指定立方体区域(int)领地数据源详细信息（传入JSON字符串） 返回值类型：Boolean */
		SetLandInfoByCubeInt : ll.import("PFAPI", "Lands_SetLandInfoByCubeInt"),
		/** 设置指定坐标(float)领地数据源详细信息（传入JSON字符串） 返回值类型：Boolean */
		SetLandInfoByPos : ll.import("PFAPI", "Lands_SetLandInfoByPos"),
		/** 设置或修改指定坐标(int)领地数据源详细信息（传入JSON字符串） 返回值类型：Boolean */
		SetLandInfoByPosInt : ll.import("PFAPI", "Lands_SetLandInfoByPosInt"),
	},
	Money : {
		/** 获取玩家(指定玩家名)金钱 返回值类型：Integer */
		Get : ll.import("PFAPI", "Money_Get"),
		/** 给玩家(指定玩家名)加钱 返回值类型：Boolean */
		Add : ll.import("PFAPI", "Money_Add"),
		/** 给玩家(指定玩家名)减钱 返回值类型：Boolean */
		Remove : ll.import("PFAPI", "Money_Remove"),
	},
};

```
</details>

---
</details>
<details>
<summary><b>All Api in C++<b></summary>

``` C++
// 设置全局配置文件（要求JSON字符串） 返回值类型：Boolean
auto General_SetConfig = RemoteCall::importAs<bool(std::string const& jsonStr)>("PFAPI", "General_SetConfig");
// 获取全局配置文件（JSON字符串） 返回值类型：String
auto General_GetConfig = RemoteCall::importAs<std::string()>("PFAPI", "General_GetConfig");
// 重新加载所有功能的配置文件
auto General_Reload = RemoteCall::importAs<void()>("PFAPI", "General_Reload");
// 设置命令禁用(可设置提示)
auto Command_SetCommandDisabled = RemoteCall::importAs<void(std::string const& playerName,std::string const& cmd,std::string const& feedback)>("PFAPI", "Command_SetCommandDisabled");
// 设置命令启用
auto Command_SetCommandEnabled = RemoteCall::importAs<void(std::string const& playerName,std::string const& cmd)>("PFAPI", "Command_SetCommandEnabled");
// 翻译 返回值类型：String
auto Language_Translate = RemoteCall::importAs<std::string(std::string const& fromLanguage,std::string const& toLanguage,std::string const& text)>("PFAPI", "Language_Translate");
// 设置玩家昵称
auto ChatEx_SetNickName = RemoteCall::importAs<void(std::string const& name,std::string const& nickName)>("PFAPI", "ChatEx_SetNickName");
// 设置玩家聊天时的名字
auto ChatEx_SetFakeName = RemoteCall::importAs<void(std::string const& name,std::string const& fakeName)>("PFAPI", "ChatEx_SetFakeName");
// 设置玩家聊天消息后缀
auto ChatEx_SetEnd = RemoteCall::importAs<void(std::string const& name,std::string const& endStr)>("PFAPI", "ChatEx_SetEnd");
// 设置玩家聊天消息前缀
auto ChatEx_SetStart = RemoteCall::importAs<void(std::string const& name,std::string const& startStr)>("PFAPI", "ChatEx_SetStart");
// 检查指定立方体区域(float)是否有领地 返回值类型：Boolean
auto Lands_CheckCubeHasLand = RemoteCall::importAs<bool(float const& x1,float const& y1,float const& z1,float const& x2,float const& y2,float const& z2,int const& dimensionId)>("PFAPI", "Lands_CheckCubeHasLand");
// 检查指定立方体区域(int)是否有领地 返回值类型：Boolean
auto Lands_CheckCubeHasLandInt = RemoteCall::importAs<bool(int const& x1,int const& y1,int const& z1,int const& x2,int const& y2,int const& z2,int const& dimensionId)>("PFAPI", "Lands_CheckCubeHasLandInt");
// 检查指定坐标(float)是否有领地 返回值类型：Boolean
auto Lands_CheckPosHasLand = RemoteCall::importAs<bool(float const& x,float const& y,float const& z,int const& dimensionId)>("PFAPI", "Lands_CheckPosHasLand");
// 检查指定坐标(int)是否有领地 返回值类型：Boolean
auto Lands_CheckPosHasLandInt = RemoteCall::importAs<bool(int const& x,int const& y,int const& z,int const& dimensionId)>("PFAPI", "Lands_CheckPosHasLandInt");
// 获取立方体区域(float)领地信息（返回JSON字符串） 返回值类型：String
auto Lands_GetLandByCube = RemoteCall::importAs<std::string(float const& x1,float const& y1,float const& z1,float const& x2,float const& y2,float const& z2,int const& dimensionId)>("PFAPI", "Lands_GetLandByCube");
// 获取立方体区域(int)领地信息（返回JSON字符串） 返回值类型：String
auto Lands_GetLandByCubeInt = RemoteCall::importAs<std::string(int const& x1,int const& y1,int const& z1,int const& x2,int const& y2,int const& z2,int const& dimensionId)>("PFAPI", "Lands_GetLandByCubeInt");
// 获取指定坐标(float)领地信息（返回JSON字符串） 返回值类型：String
auto Lands_GetLandByPos = RemoteCall::importAs<std::string(float const& x,float const& y,float const& z,int const& dimensionId)>("PFAPI", "Lands_GetLandByPos");
// 获取指定坐标(int)领地信息（返回JSON字符串） 返回值类型：String
auto Lands_GetLandByPosInt = RemoteCall::importAs<std::string(int const& x,int const& y,int const& z,int const& dimensionId)>("PFAPI", "Lands_GetLandByPosInt");
// 获取立方体区域(float)领地数据源详细信息（返回JSON字符串） 返回值类型：String
auto Lands_GetLandInfoByCube = RemoteCall::importAs<std::string(float const& x1,float const& y1,float const& z1,float const& x2,float const& y2,float const& z2,int const& dimensionId)>("PFAPI", "Lands_GetLandInfoByCube");
// 获取立方体区域(int)领地数据源详细信息（返回JSON字符串） 返回值类型：String
auto Lands_GetLandInfoByCubeInt = RemoteCall::importAs<std::string(int const& x1,int const& y1,int const& z1,int const& x2,int const& y2,int const& z2,int const& dimensionId)>("PFAPI", "Lands_GetLandInfoByCubeInt");
// 获取指定坐标(float)领地数据源详细信息（返回JSON字符串） 返回值类型：String
auto Lands_GetLandInfoByPos = RemoteCall::importAs<std::string(float const& x,float const& y,float const& z,int const& dimensionId)>("PFAPI", "Lands_GetLandInfoByPos");
// 获取指定坐标(int)领地数据源详细信息（返回JSON字符串） 返回值类型：String
auto Lands_GetLandInfoByPosInt = RemoteCall::importAs<std::string(int const& x,int const& y,int const& z,int const& dimensionId)>("PFAPI", "Lands_GetLandInfoByPosInt");
// 设置指定立方体区域(float)领地数据源详细信息（传入JSON字符串） 返回值类型：Boolean
auto Lands_SetLandInfoByCube = RemoteCall::importAs<bool(float const& x1,float const& y1,float const& z1,float const& x2,float const& y2,float const& z2,int const& dimensionId,std::string const& landinfo)>("PFAPI", "Lands_SetLandInfoByCube");
// 设置指定立方体区域(int)领地数据源详细信息（传入JSON字符串） 返回值类型：Boolean
auto Lands_SetLandInfoByCubeInt = RemoteCall::importAs<bool(int const& x1,int const& y1,int const& z1,int const& x2,int const& y2,int const& z2,int const& dimensionId,std::string const& landinfo)>("PFAPI", "Lands_SetLandInfoByCubeInt");
// 设置指定坐标(float)领地数据源详细信息（传入JSON字符串） 返回值类型：Boolean
auto Lands_SetLandInfoByPos = RemoteCall::importAs<bool(float const& x,float const& y,float const& z,int const& dimensionId,std::string const& landinfo)>("PFAPI", "Lands_SetLandInfoByPos");
// 设置或修改指定坐标(int)领地数据源详细信息（传入JSON字符串） 返回值类型：Boolean
auto Lands_SetLandInfoByPosInt = RemoteCall::importAs<bool(int const& x,int const& y,int const& z,int const& dimensionId,std::string const& landinfo)>("PFAPI", "Lands_SetLandInfoByPosInt");
// 获取玩家(指定玩家名)金钱 返回值类型：Integer
auto Money_Get = RemoteCall::importAs<int(std::string const& name)>("PFAPI", "Money_Get");
// 给玩家(指定玩家名)加钱 返回值类型：Boolean
auto Money_Add = RemoteCall::importAs<bool(std::string const& name,int const& val)>("PFAPI", "Money_Add");
// 给玩家(指定玩家名)减钱 返回值类型：Boolean
auto Money_Remove = RemoteCall::importAs<bool(std::string const& name,int const& val)>("PFAPI", "Money_Remove");

```

