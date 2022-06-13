<div align="center">
<h1>ScriptAPI for PFEssentials</h1>
</div>

>```js
>let PFEssentials = ll.require("PFEssentials");
>```
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

</details>
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
