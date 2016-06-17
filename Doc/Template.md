<h2><p align="center">模板工程简介</p></h2>

### 1. 文件目录
| 头文件  | 源文件 | 导出库 | Win工程 | Linux工程 | Matlab工程 | 文档 | Demo工程 |
|---------|--------|--------|---------|-----------|------------|------|----------|
| Include | Source | Export | Micsoft | Linux     | Matlab     | Doc  | Demo     |


### 2. Demo文件目录
| 第一级目录 | 第二级目录 |     说明     |
|------------|------------|--------------|
| Demo       | Bin        | 结果文件目录 |
|            | Include    | 头文件目录   |
|            | Source     | 源文件目录   |
|            | Resource   | 第三方库目录 |
|            | AutoCmds   | 自动命令     |

其中第三方库Resource中平行三个文件夹`inc`,`lib`,`bin`