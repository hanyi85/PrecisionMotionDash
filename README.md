# PrecisionMotion Dashboard - 精密位移監控與財務決策支援系統

![專案狀態](https://img.shields.io/badge/Status-Prototype-blue.svg)
![開發語言](https://img.shields.io/badge/Language-C%23-blue.svg)
![技術框架](https://img.shields.io/badge/Framework-WPF-blue.svg)

## 專案概述
本專案是一款專為精密自動化設備（如線性馬達、微型滑軌）設計的 **WPF 監控終端原型**。
開發初衷是為了解決工業自動化領域中，「物理數據」與「經營成本」脫節的痛點。本系統透過實時數據監控，並結合財務會計邏輯，提供即時的設備健康診斷與成本預算建議。

## 核心功能

### 1. 微米級位移模擬控制 (Precision Position Control)
*   **高精度反饋**：實現 $\mu m$ 級別的數值顯示（精確至小數點後三位）。
*   **即時連動**：透過 WPF Data Binding 實現滑桿與數據中心的零延遲同步。

### 2. 馬達熱損耗動態監控 (Thermal Monitoring)
*   **自動升降溫邏輯**：模擬線性馬達在高頻來回作動下的發熱現象，靜止時自動回歸室溫。
*   **過熱預警系統**：當溫度超過安全性門檻（60°C）時，介面將自動切換為紅色警戒狀態，展現工業安全邏輯。

### 3. 財務決策支援模組 (Business Intelligence Module)
*   **即時損耗核算**：將物理位移數據轉化為設備磨耗與維護成本，實現資產價值動態追蹤。
*   **快速報價工具 (BOM)**：結合會計背景邏輯，根據設備參數（長度、材質）自動計算生產成本與建議銷售價格（含毛利率估算）。

##  技術棧
*   **開發環境**：Visual Studio 2022
*   **框架**：.NET WPF (C#)
*   **佈局技術**：XAML (DockPanel, UniformGrid, Grid)
*   **非同步處理**：DispatcherTimer (用於實時監控模擬)

##  專業背景結合
具備：
1.  **精密工業 Domain Knowledge**：理解線性馬達與滑軌的運作原理與精密度要求。
2.  **跨領域整合能力**：能將「會計成本核算」模型導入「軟體開發」中，產出具備商業價值的工具。
3.  **快速除錯與 UI 設計**：具備針對複雜數據進行視覺化呈現與異常排查的能力。

---
*本作品僅供面試與技術展示使用*
