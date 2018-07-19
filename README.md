# Tobii X60 & 120 を実験に利用していた際のコードをベースにしたサンプル

## 動作
- ４つのカテゴリの画像から３つずつ（計12枚）を提示しつつ，ユーザの注視点を計測
	- 画像組は固定，配置がランダム
- experiment モード　と　dammy モード（マウスを視線計測の代わりに）がある

## Usage
- Tobii を接続，物理一のキャリブレーションなどは別プログラムで
- 実行後，左のボックス内から接続したい Tobii を選択 --> `connect to Eyetracker`
- `Start Tracking` で注視点が獲得できるかが確認できる
- `Run Calibration` でキャリブレーション実行（５点 or ９点）
- `Confirm` でキャリブレーションの確認　累積誤差が一定以内なら問題ないと判断
- プルダウンからコンテンツIDを選択し，`Gaze` or `dammy` で計測開始
- まず１枚ずつ順序提示 --> 全体提示，マウスクリック２回で終了（１回目で計測終了＆画像ID表示，２回目で終了）

## Files
- CalibConfirm* : キャリブレーションの確認用
- CalibrationForm* : キャリブレーション時のフォームなど
- CalibrationResultForm* : キャリブレーション実行直後に表示されるおおまかなキャリブレーション結果表示用
- CalibrationRunner* : キャリブレーション
- GazePoints : Tobii 操作時のもの
- DammyPoints : マウス操作時のもの（基本的にGazePoints の焼き直し，この時はなぜかファイル内で分岐ではなくファイル自体を分けていた）
	- 結果はそれぞれ ./bin/Debug or Release/experiment, dammy
- MainForm* : mainプログラム．なんか色々設定したりしている．