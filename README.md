 # 家具涂装车间监控系统（Modbus 上位机）

C# WinForms 上位机软件，基于 Modbus RTU 协议与涂装车间环境控制器通信，实现车间温度、相对湿度、断面排风风速的实时采集，通风设备集中控制，实时趋势曲线展示，以及风速安全联锁报警。

## 业务背景

家具厂涂装（喷漆）车间的温湿度直接决定漆膜质量
断面排风风速 0.35~0.65 m/s 是安监与环保督查的硬指标, 风速不足意味着排风系统失效、漆雾超标、存在爆炸风险。本系统负责该车间的环境参数监控与通风设备控制。

## 技术栈

| 项目 | 选型 |
| --- | --- |
| 目标框架 | .NET 8（net8.0-windows） |
| 界面框架 | Windows Forms |
| Modbus 协议库 | NModbus4.NetCore 3.0.0 |
| 曲线控件 | WinForms.DataVisualization 1.10.0 |
| 串口 | System.IO.Ports 9.0.4 |

## 功能

- **实时监控**：三路环境参数 1 秒周期采集，显示当前值 / 历史最高值 / 历史最低值
- **状态判定**：温度（温度过低 / 正常 / 温度过高）、湿度（过干 / 正常 / 过湿）、风速（风速不足 / 正常 / 风速超限）
- **通风设备控制**：送风机、排风机、新风阀、水帘泵、声光报警器单台控制 + 一键启动/停止
- **安全联锁**：断面排风风速低于 0.35 m/s（安监合规线）时自动置位声光报警器，恢复合规后自动复位，无需人工干预
- **实时趋势**：温度 / 湿度 / 风速三条曲线按序列勾选显示，同步刷新数据列表
- **车间看板**：向车间 LED 看板下发显示内容

## 目录结构

```
MonitorReader/
├── MonitorReader.slnx                  # 解决方案文件
├── nuget.config                        # 独立包源配置（避免本机全局 NuGet 源干扰）
├── README.md
└── MonitorReader/
    ├── MonitorReader.csproj
    ├── Program.cs                      # 程序入口
    ├── FrmMain.cs / .Designer.cs       # 系统主界面（导航 / 退出）
    ├── FrmChildBase.cs                 # 子窗体基类
    ├── FrmDataMonitor.cs               # 环境监控中心（通信连接、实时数据、设备控制、安全联锁）
    ├── FrmTrends.cs                    # 实时趋势曲线（曲线序列管理、定时刷新）
    ├── FrmSend.cs                      # 车间看板界面
    ├── Models/                         # 数据模型
    │   ├── EnvRecord.cs                    # 环境实时数据
    │   ├── ProcessParams.cs                # 车间环境工艺参数（报警限值）
    │   ├── TemperatureStates.cs            # 车间温度状态
    │   ├── HumidityStates.cs               # 车间湿度状态
    │   └── AirflowStates.cs                # 断面排风风速状态
    ├── Utils/CommonHelper.cs           # 通用工具类
    ├── Properties/                     # 资源
    ├── Resources/                      # 界面用图片资源
    └── bin/Debug/net8.0-windows/       # 编译输出（MonitorReader.exe）
```

## 协议说明

上位机作为 Modbus 主站，使用功能码：

| 功能码 | 名称 | 用途 |
| --- | --- | --- |
| 03 (0x03) | 读保持寄存器 | 读取温度 / 湿度 / 风速三路模拟量 |
| 01 (0x01) | 读线圈 | 读取 5 路通风设备运行状态 |
| 05 (0x05) | 写单个线圈 | 单台设备启停、声光报警器联锁置位/复位 |
| 15 (0x0F) | 写多个线圈 | 一键启动/停止全部通风设备 |
