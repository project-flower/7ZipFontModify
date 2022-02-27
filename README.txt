7ZipFontModify

概要:
  7-Zip for Windows の GUI のフォント サイズを変更します。

動作環境:
  Microsoft Windows 10
  .NET Framework 4.8

ファイル:
  7ZipFontModify.exe
    実行ファイルです。
  7ZipFontModify.exe.config
    設定ファイル

使い方:
  1. [Files:]に変更対象のファイル名を1行に1ファイルずつ入力して下さい。環境変数が使用できます。
     7-Zip for Windows で主に使われるのは 7zFM.exe, 7zG.exe, 7z.sfx の3つです。

  2. [Font size:]に変更対象のフォント サイズを入力して下さい。通常は 8 を指定します。
     [to]に変更後のフォント サイズを入力して下さい。

  3. [Backup to:]に元のファイルのバックアップ先を指定して下さい。
     何も入力しなかった場合、バックアップは行われません。

  4. [Exec]をクリックすると、バックアップ([Bakup to:]が入力されている場合)と変換が実行されます。

補足:
  Program Files ディレクトリ内のファイルを操作するため、管理者権限で起動します。

詳細:
  [Files:]で指定されたファイル内の"0x08 MS Shell"を"0x0A MS Shell"のように置換します。

設定:
  設定ファイル 7ZipFontModify.exe.config の内容を変更することで、動作を変更できます。
    ・BackupTo
      [Backup to:]に入力する既定値(相対パスを設定した場合、実行時パスが起点になります)
    ・Files
      [Files:]に入力する既定値。
    ・Target
      変換箇所のバイナリ値

    <configuration>
      <userSettings>
        <SevenZipFontModify.Properties.Settings>
          <setting name="BackupTo" serializeAs="String">
            <value>Backup</value>
          </setting>
          <setting name="Files" serializeAs="String">
            <value>%PROGRAMFILES%\7-Zip\7zFM.exe
    %PROGRAMFILES%\7-Zip\7zG.exe
    %PROGRAMFILES%\7-Zip\7z.sfx</value>
          </setting>
          <setting name="Target" serializeAs="String">
            <value>00 4D 00 53 00 20 00 53 00 68 00 65 00 6C 00 6C 00</value>
          </setting>
        </SevenZipFontModify.Properties.Settings>
      </userSettings>
    </configuration>

制限:
  Microsoft Windows 10 以外での動作確認は行っておりません。

注意:
  変更後のアプリケーションが予期しない動作をする可能性があります。自己責任でご利用下さい。
  実行ファイル等の変更を行うため、セキュリティ ソフト等が動作を警告／ブロック等を行う可能性があります。
