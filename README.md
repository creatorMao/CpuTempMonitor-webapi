# CpuTempMonitor-webapi

# 说明

本项目逻辑参考该仓库：[raffy909/CpuTempMonitor](https://github.com/raffy909/CpuTempMonitor)

原作者的项目是控制台程序，而本项目是基于webapi，因此需要部署到iis上使用。

# 部署细节

- 需要设置管理员权限，[详细操作请参考链接](https://blog.csdn.net/qq_24046029/article/details/116055693)

## 接口说明 

接口地址: /api/cpu/temp

跨域情况：默认*，无跨域问题

请求类型：Get/Post

返回值:

```
{
    "result": [
        {
            "Name": "Intel Core i5-7300U",
            "Sensors": [
                {
                    "Name": "CPU Core #1",
                    "Index": 0,
                    "Temp": 55
                },
                {
                    "Name": "CPU Core #2",
                    "Index": 1,
                    "Temp": 53
                },
                {
                    "Name": "CPU Package",
                    "Index": 2,
                    "Temp": 55
                }
            ]
        }
    ]
}
```

