<div align="center">
<h1>ScriptAPI for PFEssentials</h1>
</div>

>```js
>let PFEssentials = ll.require("PFEssentials");
>```
<details>
<summary><b>General<b></summary>

>## General::SetConfig
>### 设置全局配置文件（要求JSON字符串）
>|  形参   | 类型  |
>|  ----  | ----  |
>| jsonStr | String |
>返回值类型：Boolean;
>```js
>const General_SetConfig = ll.import("PFAPI", "General_SetConfig");
>let result = General_SetConfig(jsonStr);
>```
>---
>## General::GetConfig
>### 获取全局配置文件（JSON字符串）
>无参数;
>返回值类型：String;
>```js
>const General_GetConfig = ll.import("PFAPI", "General_GetConfig");
>let result = General_GetConfig();
>```
>---
>## General::Reload
>### 重新加载所有功能的配置文件
>无参数;
>无返回值;
>```js
>const General_Reload = ll.import("PFAPI", "General_Reload");
>General_Reload();
>```
</details>
<details>
<summary><b>Command<b></summary>

>## Command::SetCommandDisabled
>### 设置命令禁用（仅限PFEssentials的命令）
>|  形参   | 类型  |
>|  ----  | ----  |
>| playerName | String |
>| cmd | String |
>| feedback | String |
>无返回值;
>```js
>const Command_SetCommandDisabled = ll.import("PFAPI", "Command_SetCommandDisabled");
>Command_SetCommandDisabled(playerName,cmd,feedback);
>```
>---
>## Command::SetCommandEnabled
>### 设置命令启用（仅限PFEssentials的命令）
>|  形参   | 类型  |
>|  ----  | ----  |
>| playerName | String |
>| cmd | String |
>无返回值;
>```js
>const Command_SetCommandEnabled = ll.import("PFAPI", "Command_SetCommandEnabled");
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
>```js
>const Language_Translate = ll.import("PFAPI", "Language_Translate");
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
>```js
>const ChatEx_SetNickName = ll.import("PFAPI", "ChatEx_SetNickName");
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
>```js
>const ChatEx_SetFakeName = ll.import("PFAPI", "ChatEx_SetFakeName");
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
>```js
>const ChatEx_SetEnd = ll.import("PFAPI", "ChatEx_SetEnd");
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
>```js
>const ChatEx_SetStart = ll.import("PFAPI", "ChatEx_SetStart");
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
>```js
>const Lands_CheckCubeHasLand = ll.import("PFAPI", "Lands_CheckCubeHasLand");
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
>```js
>const Lands_CheckCubeHasLandInt = ll.import("PFAPI", "Lands_CheckCubeHasLandInt");
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
>```js
>const Lands_CheckPosHasLand = ll.import("PFAPI", "Lands_CheckPosHasLand");
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
>```js
>const Lands_CheckPosHasLandInt = ll.import("PFAPI", "Lands_CheckPosHasLandInt");
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
>```js
>const Lands_GetLandByCube = ll.import("PFAPI", "Lands_GetLandByCube");
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
>```js
>const Lands_GetLandByCubeInt = ll.import("PFAPI", "Lands_GetLandByCubeInt");
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
>```js
>const Lands_GetLandByPos = ll.import("PFAPI", "Lands_GetLandByPos");
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
>```js
>const Lands_GetLandByPosInt = ll.import("PFAPI", "Lands_GetLandByPosInt");
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
>```js
>const Lands_GetLandInfoByCube = ll.import("PFAPI", "Lands_GetLandInfoByCube");
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
>```js
>const Lands_GetLandInfoByCubeInt = ll.import("PFAPI", "Lands_GetLandInfoByCubeInt");
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
>```js
>const Lands_GetLandInfoByPos = ll.import("PFAPI", "Lands_GetLandInfoByPos");
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
>```js
>const Lands_GetLandInfoByPosInt = ll.import("PFAPI", "Lands_GetLandInfoByPosInt");
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
>```js
>const Lands_SetLandInfoByCube = ll.import("PFAPI", "Lands_SetLandInfoByCube");
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
>```js
>const Lands_SetLandInfoByCubeInt = ll.import("PFAPI", "Lands_SetLandInfoByCubeInt");
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
>```js
>const Lands_SetLandInfoByPos = ll.import("PFAPI", "Lands_SetLandInfoByPos");
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
>```js
>const Lands_SetLandInfoByPosInt = ll.import("PFAPI", "Lands_SetLandInfoByPosInt");
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
>```js
>const Money_Get = ll.import("PFAPI", "Money_Get");
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
>```js
>const Money_Add = ll.import("PFAPI", "Money_Add");
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
>```js
>const Money_Remove = ll.import("PFAPI", "Money_Remove");
>let result = Money_Remove(name,val);
>```
</details>
