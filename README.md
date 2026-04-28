#  PrecisionMotion Dashboard
### 精密位移監控與財務決策支援系統

![專案狀態](https://img.shields.io/badge/Status-Prototype-blue.svg)
![開發語言](https://img.shields.io/badge/Language-C%23-blue.svg)
![技術框架](https://img.shields.io/badge/Framework-WPF-blue.svg)
![領域](https://img.shields.io/badge/Field-Industrial%204.0-orange.svg)

##  專案概述
本專案是一款專為精密自動化設備（如線性馬達、微型滑軌）設計的 **WPF 監控終端原型**。

**開發初衷：** 解決工業自動化領域中「物理數據」與「經營成本」脫節的痛點。本系統透過實時數據監控，並結合財務會計邏輯，提供即時的設備健康診斷與成本預算建議。

---

##  監控介面展示
<p align="center">
  <img width="978" height="638" alt="監控介面展示" src="https://github.com/user-attachments/assets/a73d95b3-ce58-4fd7-8212-3611c470ff8f"width="600" style="max-height: 400px; object-fit: contain;" alt="PrecisionMotion Dashboard 介面展示">
  <br>
  <strong>圖：系統主介面 - 整合位移監控、熱損耗分析與決策支援模組</strong>
</p>

---

##  核心功能 

### 1. 微米級位移模擬控制
* **高精度反饋**：實現 $\mu m$ 級別的數值顯示（精確至小數點後三位）。
* **即時連動**：透過 WPF Data Binding 實現 UI 控制項與數據中心的零延遲同步。

### 2️. 馬達熱損耗動態監控
* **動態升降溫邏輯**：模擬線性馬達在高頻來回作動下的發熱現象（作動升溫，靜止降溫）。
* **過熱預警系統**：當溫度超過安全性門檻（60°C）時，介面會觸發視覺警示（切換為紅色警戒色調），體現工業安全思維。

### 3️. 財務決策支援模組 
* **資產價值核算**：將物理位移數據轉化為設備磨耗與維護成本，實現資產價值的動態追蹤。
* **快速報價工具 (BOM)**：結合會計背景，根據零件參數（長度、材質）自動計算生產成本與建議銷售價格（含毛利率估算）。

---

##  技術棧
* **開發環境**：Visual Studio 2022
* **語言與框架**：C# / .NET WPF
* **佈局技術**：XAML (DockPanel, UniformGrid, Grid)
* **核心機制**：DispatcherTimer (實時監控模擬)、Data Binding (MVVM Pattern)

---

##  專業背景結合 
本作品充分展現了我的跨領域優勢：
1. **精密工業領域知識**：理解線性馬達與滑軌的運作原理與精密度要求。
2. **會計商務邏輯整合**：能將複雜的「會計成本核算」模型導入軟體中，產出具備商用價值的工具。
3. **數據視覺化與 UI/UX**：具備將複雜工業數據轉化為直觀介面的能力，優化操作者的決策效率。

---
*本作品僅供技術展示使用，所有數據均為模擬生成。*
