# YGOPro2MDPro

简单的 MDPro2 代理启动器，更方便的从萌卡启动 MDPro2（MDPro3暂时好像不支持命令行调用，因此无法使用本工具）。

还是比较喜欢萌卡的聊天室以及天梯匹配，但是 MDPro 完全替换掉 YGOPro2 的话出现更新的时候会非常麻烦，也无法再使用萌卡的修复功能。本工具就是将文件覆盖掉原先的 YGOPro2 文件夹（建议备份先前的 .exe），通过转发调用的启动参数的方式来实现 YGOPro2 和 MDPro2 共存。后续 YGOPro2 更新时，您可能需要手动的从 YGOPro2 中复制以下内容至 MDPro2 完成更新以适配萌卡平台（大部分情况下直接打上补丁包就可以直接用了）。

**注意，你需要手动同步两者的卡组文件！！！**

| 原路径          | 目标路径       | 文件名      | 说明                                                        |
| --------------- | -------------- | ----------- | ----------------------------------------------------------- |
| ygopro2\deck    | MDPro2\deck    | 全部内容    | 卡组文件                                                    |
| ygopro2\config  | MDPro2\config  | lflist.conf | 禁限制表                                                    |
| ygopro2\picture | MDPro2\picture | 全部内容    | 卡图                                                        |
| ygopro2\cdb     | MDPro2\cdb     | cards.cdb   | 卡片数据                                                    |
| ygopro2\script  | MDPro2\data    | script.zip  | 打开 MDPro2 的压缩包然后将 YGOPro2 位置下的文件更新进去即可 |

