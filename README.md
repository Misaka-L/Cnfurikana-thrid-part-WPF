# Cnfurikana-thrid-part-WPF
Cnfurikana 的第三方 WPF+C# 实现  
![软件主界面截图](https://i.loli.net/2020/11/22/Ko4E7GqIdy8RBS3.png)
[官方 Python 版本 Cnfurikana Github 仓库链接](https://github.com/Gleiphir/cnfurikana)

## 特别感谢
- 感谢 [绯赤艾莉欧字幕组](https://space.bilibili.com/473387573) 为所有的舰长昵称注了音
- 感谢 [Graphital 石墨](https://space.bilibili.com/206898701) 开发了 Cnfurikana
- 感谢 所有为 Vtuber 圈做出贡献的字幕组与 Vtuber 们
- 感谢 所有使用项目的贡献者
- 感谢 中国电信 没在我干活的时候网络爆炸
- 感谢 我家的猫 没有咬我家的猫 (中华文化博大精深)

## Cnfurikana 是什么？
Cnfuiknana 是一个轻量级的用假名标注中文音调与读音的软件

## 它能干什么？
- 便于日语母语者快速准确读出中文，例如直播间的 Superchat 等
- 便于日语母语者学习中文

## 等待实现的特性
- [ ] 导出 html 文档
- [ ] 导出 Excel 表格
- [ ] 解决多音字问题
- [ ] 日语翻译
- [ ] 阅读汉字和注音
- [ ] 弄一个 Icon
- [ ] 对接 BiliBili 直播实现实时注音

## 使用的项目
- ### Costura.Fody
 - 许可证: [MIT](https://licenses.nuget.org/MIT "MIT")
 - Github 仓库: [Fody/Costura](https://github.com/Fody/Costura/)
 - 贡献者名单: [Github Contributors](https://github.com/Fody/Costura/graphs/contributors)
 - 用途: Cnfurikana-thrid-part-WPF 使用 Costura.Fody 以合并 dll 为单个 exe 文件
- ### Newtonsoft.Json
 - 许可证: [MIT](https://licenses.nuget.org/MIT "MIT")
 - Github 仓库: [JamesNK/Nettonsoft.json](https://github.com/JamesNK/Newtonsoft.Json) 
 - 贡献者名单: [Github Contributors](https://github.com/JamesNK/Newtonsoft.Json/graphs/contributors)
 - 用途: Cnfurikana-thrid-part-WPF 使用 Newtonsoft.Json 作为 Josn 解析库以
 保存读取设置和读取平假名对照表
- ### Material Design In XAML
 - 许可证: [MIT](https://licenses.nuget.org/MIT "MIT")
 - Github 仓库: [MaterialDesignInXAML/MaterialDesignInXamlToolKit](https://github.com/MaterialDesignInXAML/MaterialDesignInXamlToolkit)
 - 贡献者名单: [Github Contributors](https://github.com/MaterialDesignInXAML/MaterialDesignInXamlToolkit/graphs/contributors)
 - 用途: Cnfurikana-thrid-part-WPF 使用 Material Design In XAML 作为 UI 库实现软件 UI
- ### Microsoft.International.Converters.PinYinConverter
 - Nuget: [Microsoft.International.Converters.PinYinConverter](https://www.nuget.org/packages/Microsoft.International.Converters.PinYinConverter/) 
 - 用途: Cnfurikana-thrid-part-WPF 使用该项目作为拼音库